# Recording

## Overview

### Available Operations

* [CreateUcRecording](#createucrecording) - Create a recording
* [GetCalendarRecording](#getcalendarrecording) - Retrieve a recording
* [GetUcRecording](#getucrecording) - Retrieve a recording
* [ListCalendarRecordings](#listcalendarrecordings) - List all recordings
* [ListUcRecordings](#listucrecordings) - List all recordings
* [PatchUcRecording](#patchucrecording) - Update a recording
* [RemoveUcRecording](#removeucrecording) - Remove a recording
* [UpdateUcRecording](#updateucrecording) - Update a recording

## CreateUcRecording

Create a recording

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUcRecording" method="post" path="/uc/{connection_id}/recording" example="uc_recording" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Recording.CreateUcRecordingAsync(
    ucRecording: new UcRecording() {
        Contacts = new List<UcContact>() {},
        ConversationIdentifier = "76dfc8b1-d808-4846-9409-be6f6e0dfa8c",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-03T00:20:23.751Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-04-22T09:10:43.046Z").ToUniversalTime(),
        Id = "76dfc8b1-d808-4846-9409-be6f6e0dfa8c",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-03-30T22:39:40.687Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-10T23:45:03.272Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-02-20T07:53:56.486Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-05-31T04:13:23.444Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-10T00:46:54.954Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-07-29T03:58:41.122Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        StartAt = System.DateTime.Parse("2023-04-27T00:19:34.359Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-13T10:19:28.380Z").ToUniversalTime(),
        UserName = "Melyna Larson",
        UserPhone = "1-915-327-0429 x509",
        WebUrl = "https://spherical-comparison.org",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `UcRecording`                                                                                                                                    | [UcRecording](../../Models/Components/UcRecording.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateUcRecordingQueryParamFields](../../Models/Requests/CreateUcRecordingQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateUcRecordingResponse](../../Models/Requests/CreateUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarRecording

Retrieve a recording

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarRecording" method="get" path="/calendar/{connection_id}/recording/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Recording.GetCalendarRecordingAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Recording                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetCalendarRecordingQueryParamFields](../../Models/Requests/GetCalendarRecordingQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarRecordingResponse](../../Models/Requests/GetCalendarRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcRecording

Retrieve a recording

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcRecording" method="get" path="/uc/{connection_id}/recording/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Recording.GetUcRecordingAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Recording                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetUcRecordingQueryParamFields](../../Models/Requests/GetUcRecordingQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcRecordingResponse](../../Models/Requests/GetUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarRecordings

List all recordings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarRecordings" method="get" path="/calendar/{connection_id}/recording" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarRecordingsRequest req = new ListCalendarRecordingsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Recording.ListCalendarRecordingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListCalendarRecordingsRequest](../../Models/Requests/ListCalendarRecordingsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListCalendarRecordingsResponse](../../Models/Requests/ListCalendarRecordingsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcRecordings

List all recordings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcRecordings" method="get" path="/uc/{connection_id}/recording" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcRecordingsRequest req = new ListUcRecordingsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Recording.ListUcRecordingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListUcRecordingsRequest](../../Models/Requests/ListUcRecordingsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListUcRecordingsResponse](../../Models/Requests/ListUcRecordingsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcRecording

Update a recording

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUcRecording" method="patch" path="/uc/{connection_id}/recording/{id}" example="uc_recording" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchUcRecordingRequest req = new PatchUcRecordingRequest() {
    UcRecording = new UcRecording() {
        Contacts = new List<UcContact>() {},
        ConversationIdentifier = "a548f708-1e2d-4bdb-9574-1d46ee525c72",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-03T00:20:23.765Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-04-22T09:10:43.076Z").ToUniversalTime(),
        Id = "a548f708-1e2d-4bdb-9574-1d46ee525c72",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-03-30T22:39:40.700Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-10T23:45:03.303Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-02-20T07:53:56.515Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-05-31T04:13:23.458Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-10T00:46:54.972Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-07-29T03:58:41.154Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        StartAt = System.DateTime.Parse("2023-04-27T00:19:34.364Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-13T10:19:28.400Z").ToUniversalTime(),
        UserName = "Melyna Larson",
        UserPhone = "1-915-327-0429 x509",
        WebUrl = "https://spherical-comparison.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Recording.PatchUcRecordingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchUcRecordingRequest](../../Models/Requests/PatchUcRecordingRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchUcRecordingResponse](../../Models/Requests/PatchUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUcRecording

Remove a recording

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUcRecording" method="delete" path="/uc/{connection_id}/recording/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Recording.RemoveUcRecordingAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Recording  |

### Response

**[RemoveUcRecordingResponse](../../Models/Requests/RemoveUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcRecording

Update a recording

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUcRecording" method="put" path="/uc/{connection_id}/recording/{id}" example="uc_recording" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateUcRecordingRequest req = new UpdateUcRecordingRequest() {
    UcRecording = new UcRecording() {
        Contacts = new List<UcContact>() {},
        ConversationIdentifier = "a548f708-1e2d-4bdb-9574-1d46ee525c72",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-03T00:20:23.765Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-04-22T09:10:43.076Z").ToUniversalTime(),
        Id = "a548f708-1e2d-4bdb-9574-1d46ee525c72",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-03-30T22:39:40.700Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-10T23:45:03.303Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-02-20T07:53:56.515Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-05-31T04:13:23.458Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-10T00:46:54.972Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-07-29T03:58:41.154Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        StartAt = System.DateTime.Parse("2023-04-27T00:19:34.364Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-13T10:19:28.400Z").ToUniversalTime(),
        UserName = "Melyna Larson",
        UserPhone = "1-915-327-0429 x509",
        WebUrl = "https://spherical-comparison.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Recording.UpdateUcRecordingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateUcRecordingRequest](../../Models/Requests/UpdateUcRecordingRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateUcRecordingResponse](../../Models/Requests/UpdateUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |