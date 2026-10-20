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
        ConversationIdentifier = "2f8181c3-2e87-450d-a029-31d0ec69f8a5",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-04T12:22:12.260Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-04-25T16:54:09.620Z").ToUniversalTime(),
        Id = "2f8181c3-2e87-450d-a029-31d0ec69f8a5",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-04-01T08:40:58.077Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-14T08:36:18.518Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-02-23T11:54:53.058Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-06-01T17:57:49.852Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-11T22:31:53.312Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-08-01T17:38:29.131Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        Metadata = new List<UcMetadata>() {},
        StartAt = System.DateTime.Parse("2023-04-27T13:45:40.708Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-15T17:27:07.532Z").ToUniversalTime(),
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
        ConversationIdentifier = "7756fb8b-ef33-4e99-905a-fa877679d38f",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-04T12:22:12.281Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-04-25T16:54:09.665Z").ToUniversalTime(),
        Id = "7756fb8b-ef33-4e99-905a-fa877679d38f",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-04-01T08:40:58.096Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-14T08:36:18.563Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-02-23T11:54:53.101Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-06-01T17:57:49.873Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-11T22:31:53.338Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-08-01T17:38:29.179Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        Metadata = new List<UcMetadata>() {},
        StartAt = System.DateTime.Parse("2023-04-27T13:45:40.715Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-15T17:27:07.563Z").ToUniversalTime(),
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
        ConversationIdentifier = "7756fb8b-ef33-4e99-905a-fa877679d38f",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-04T12:22:12.281Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-04-25T16:54:09.665Z").ToUniversalTime(),
        Id = "7756fb8b-ef33-4e99-905a-fa877679d38f",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-04-01T08:40:58.096Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-14T08:36:18.563Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-02-23T11:54:53.101Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-06-01T17:57:49.873Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-11T22:31:53.338Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-08-01T17:38:29.179Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        Metadata = new List<UcMetadata>() {},
        StartAt = System.DateTime.Parse("2023-04-27T13:45:40.715Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-15T17:27:07.563Z").ToUniversalTime(),
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