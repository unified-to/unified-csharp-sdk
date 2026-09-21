# Uc

## Overview

### Available Operations

* [CreateUcComment](#createuccomment) - Create a comment
* [CreateUcContact](#createuccontact) - Create a contact
* [CreateUcRecording](#createucrecording) - Create a recording
* [GetUcCall](#getuccall) - Retrieve a call
* [GetUcComment](#getuccomment) - Retrieve a comment
* [GetUcContact](#getuccontact) - Retrieve a contact
* [GetUcRecording](#getucrecording) - Retrieve a recording
* [ListUcCalls](#listuccalls) - List all calls
* [ListUcComments](#listuccomments) - List all comments
* [ListUcContacts](#listuccontacts) - List all contacts
* [ListUcRecordings](#listucrecordings) - List all recordings
* [PatchUcComment](#patchuccomment) - Update a comment
* [PatchUcContact](#patchuccontact) - Update a contact
* [PatchUcRecording](#patchucrecording) - Update a recording
* [RemoveUcComment](#removeuccomment) - Remove a comment
* [RemoveUcContact](#removeuccontact) - Remove a contact
* [RemoveUcRecording](#removeucrecording) - Remove a recording
* [UpdateUcComment](#updateuccomment) - Update a comment
* [UpdateUcContact](#updateuccontact) - Update a contact
* [UpdateUcRecording](#updateucrecording) - Update a recording

## CreateUcComment

Create a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUcComment" method="post" path="/uc/{connection_id}/comment" example="uc_comment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcCommentAsync(
    ucComment: new UcComment() {
        Content = "Vociferor vitiosus.",
        CreatedAt = "2023-04-02T23:42:31.571Z",
        Id = "d421c4ff-cae4-4a9f-82dc-4b463f68c6e2",
        UpdatedAt = "2024-02-02T11:40:40.170Z",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `UcComment`                                                                                                                                      | [UcComment](../../Models/Components/UcComment.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateUcCommentQueryParamFields](../../Models/Requests/CreateUcCommentQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateUcCommentResponse](../../Models/Requests/CreateUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateUcContact

Create a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUcContact" method="post" path="/uc/{connection_id}/contact" example="uc_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcContactAsync(
    ucContact: new UcContact() {
        Company = "Tillman Group",
        CreatedAt = System.DateTime.Parse("2019-10-28T11:06:56.460Z").ToUniversalTime(),
        Emails = new List<UcEmail>() {
            new UcEmail() {
                Email = "Luther_Rogahn32@yahoo.com",
                Type = UcEmailType.Work,
            },
        },
        FirstName = "Luther",
        Id = "a07b6979-089e-4649-be28-728229ad5c33",
        LastName = "Rogahn",
        Name = "Luther Rogahn",
        Telephones = new List<UcTelephone>() {
            new UcTelephone() {
                Telephone = "(809) 992-1681",
                Type = UcTelephoneType.Fax,
            },
            new UcTelephone() {
                Telephone = "(868) 238-2746",
                Type = UcTelephoneType.Home,
            },
            new UcTelephone() {
                Telephone = "(219) 736-0357",
                Type = UcTelephoneType.Mobile,
            },
        },
        Title = "Chief Optimization Executive",
        UpdatedAt = System.DateTime.Parse("2023-11-20T14:03:27.338Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `UcContact`                                                                                                                                      | [UcContact](../../Models/Components/UcContact.md)                                                                                                | :heavy_check_mark:                                                                                                                               | A contact represents a person that optionally is associated with a call                                                                          |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateUcContactQueryParamFields](../../Models/Requests/CreateUcContactQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateUcContactResponse](../../Models/Requests/CreateUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Uc.CreateUcRecordingAsync(
    ucRecording: new UcRecording() {
        Contacts = new List<UcContact>() {},
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-04-22T23:09:58.257Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-03-31T03:31:56.772Z").ToUniversalTime(),
        Id = "8b9b82d0-2e7d-4849-acf6-98a4606897db",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-03-21T10:55:57.895Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-04-18T10:32:22.668Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-01-30T03:04:30.679Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-05-20T15:35:59.030Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-09-27T06:32:59.084Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-07-05T06:34:34.659Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        StartAt = System.DateTime.Parse("2023-04-23T06:23:46.157Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-02-26T01:19:09.006Z").ToUniversalTime(),
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

## GetUcCall

Retrieve a call

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcCall" method="get" path="/uc/{connection_id}/call/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcCallAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Call                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetUcCallQueryParamFields](../../Models/Requests/GetUcCallQueryParamFields.md)>                                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcCallResponse](../../Models/Requests/GetUcCallResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcComment

Retrieve a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcComment" method="get" path="/uc/{connection_id}/comment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Comment                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetUcCommentQueryParamFields](../../Models/Requests/GetUcCommentQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcCommentResponse](../../Models/Requests/GetUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcContact

Retrieve a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcContact" method="get" path="/uc/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Contact                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetUcContactQueryParamFields](../../Models/Requests/GetUcContactQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcContactResponse](../../Models/Requests/GetUcContactResponse.md)**

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

var res = await sdk.Uc.GetUcRecordingAsync(
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

## ListUcCalls

List all calls

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcCalls" method="get" path="/uc/{connection_id}/call" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcCallsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListUcCallsRequest](../../Models/Requests/ListUcCallsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListUcCallsResponse](../../Models/Requests/ListUcCallsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcComments

List all comments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcComments" method="get" path="/uc/{connection_id}/comment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcCommentsRequest req = new ListUcCommentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcCommentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListUcCommentsRequest](../../Models/Requests/ListUcCommentsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListUcCommentsResponse](../../Models/Requests/ListUcCommentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcContacts

List all contacts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcContacts" method="get" path="/uc/{connection_id}/contact" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcContactsRequest req = new ListUcContactsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListUcContactsRequest](../../Models/Requests/ListUcContactsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListUcContactsResponse](../../Models/Requests/ListUcContactsResponse.md)**

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

var res = await sdk.Uc.ListUcRecordingsAsync(req);

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

## PatchUcComment

Update a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUcComment" method="patch" path="/uc/{connection_id}/comment/{id}" example="uc_comment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchUcCommentRequest req = new PatchUcCommentRequest() {
    UcComment = new UcComment() {
        Content = "Vociferor vitiosus.",
        CreatedAt = "2023-04-02T23:42:31.571Z",
        Id = "a5ef67a9-9f23-4951-b5e0-dcbf92747aa9",
        UpdatedAt = "2024-02-02T11:40:40.172Z",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.PatchUcCommentAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchUcCommentRequest](../../Models/Requests/PatchUcCommentRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchUcCommentResponse](../../Models/Requests/PatchUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUcContact" method="patch" path="/uc/{connection_id}/contact/{id}" example="uc_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchUcContactRequest req = new PatchUcContactRequest() {
    UcContact = new UcContact() {
        Company = "Tillman Group",
        CreatedAt = System.DateTime.Parse("2019-10-28T11:06:56.460Z").ToUniversalTime(),
        Emails = new List<UcEmail>() {
            new UcEmail() {
                Email = "Luther_Rogahn32@yahoo.com",
                Type = UcEmailType.Work,
            },
        },
        FirstName = "Luther",
        Id = "c2fb5726-94f5-4b43-94a5-49c7d7dd7be8",
        LastName = "Rogahn",
        Name = "Luther Rogahn",
        Telephones = new List<UcTelephone>() {
            new UcTelephone() {
                Telephone = "(809) 992-1681",
                Type = UcTelephoneType.Fax,
            },
            new UcTelephone() {
                Telephone = "(868) 238-2746",
                Type = UcTelephoneType.Home,
            },
            new UcTelephone() {
                Telephone = "(219) 736-0357",
                Type = UcTelephoneType.Mobile,
            },
        },
        Title = "Chief Optimization Executive",
        UpdatedAt = System.DateTime.Parse("2023-11-20T14:03:27.344Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.PatchUcContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchUcContactRequest](../../Models/Requests/PatchUcContactRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchUcContactResponse](../../Models/Requests/PatchUcContactResponse.md)**

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
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-04-22T23:09:58.269Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-03-31T03:31:56.797Z").ToUniversalTime(),
        Id = "76e6eeb7-e7fc-4942-a26e-c387b757090d",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-03-21T10:55:57.906Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-04-18T10:32:22.694Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-01-30T03:04:30.702Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-05-20T15:35:59.042Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-09-27T06:32:59.098Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-07-05T06:34:34.685Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        StartAt = System.DateTime.Parse("2023-04-23T06:23:46.161Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-02-26T01:19:09.024Z").ToUniversalTime(),
        UserName = "Melyna Larson",
        UserPhone = "1-915-327-0429 x509",
        WebUrl = "https://spherical-comparison.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.PatchUcRecordingAsync(req);

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

## RemoveUcComment

Remove a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUcComment" method="delete" path="/uc/{connection_id}/comment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.RemoveUcCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Comment    |

### Response

**[RemoveUcCommentResponse](../../Models/Requests/RemoveUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUcContact

Remove a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUcContact" method="delete" path="/uc/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.RemoveUcContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |

### Response

**[RemoveUcContactResponse](../../Models/Requests/RemoveUcContactResponse.md)**

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

var res = await sdk.Uc.RemoveUcRecordingAsync(
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

## UpdateUcComment

Update a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUcComment" method="put" path="/uc/{connection_id}/comment/{id}" example="uc_comment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateUcCommentRequest req = new UpdateUcCommentRequest() {
    UcComment = new UcComment() {
        Content = "Vociferor vitiosus.",
        CreatedAt = "2023-04-02T23:42:31.571Z",
        Id = "a5ef67a9-9f23-4951-b5e0-dcbf92747aa9",
        UpdatedAt = "2024-02-02T11:40:40.172Z",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.UpdateUcCommentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateUcCommentRequest](../../Models/Requests/UpdateUcCommentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateUcCommentResponse](../../Models/Requests/UpdateUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUcContact" method="put" path="/uc/{connection_id}/contact/{id}" example="uc_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateUcContactRequest req = new UpdateUcContactRequest() {
    UcContact = new UcContact() {
        Company = "Tillman Group",
        CreatedAt = System.DateTime.Parse("2019-10-28T11:06:56.460Z").ToUniversalTime(),
        Emails = new List<UcEmail>() {
            new UcEmail() {
                Email = "Luther_Rogahn32@yahoo.com",
                Type = UcEmailType.Work,
            },
        },
        FirstName = "Luther",
        Id = "c2fb5726-94f5-4b43-94a5-49c7d7dd7be8",
        LastName = "Rogahn",
        Name = "Luther Rogahn",
        Telephones = new List<UcTelephone>() {
            new UcTelephone() {
                Telephone = "(809) 992-1681",
                Type = UcTelephoneType.Fax,
            },
            new UcTelephone() {
                Telephone = "(868) 238-2746",
                Type = UcTelephoneType.Home,
            },
            new UcTelephone() {
                Telephone = "(219) 736-0357",
                Type = UcTelephoneType.Mobile,
            },
        },
        Title = "Chief Optimization Executive",
        UpdatedAt = System.DateTime.Parse("2023-11-20T14:03:27.344Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.UpdateUcContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateUcContactRequest](../../Models/Requests/UpdateUcContactRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateUcContactResponse](../../Models/Requests/UpdateUcContactResponse.md)**

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
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-04-22T23:09:58.269Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-03-31T03:31:56.797Z").ToUniversalTime(),
        Id = "76e6eeb7-e7fc-4942-a26e-c387b757090d",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-03-21T10:55:57.906Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-04-18T10:32:22.694Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-01-30T03:04:30.702Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-05-20T15:35:59.042Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-09-27T06:32:59.098Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-07-05T06:34:34.685Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        StartAt = System.DateTime.Parse("2023-04-23T06:23:46.161Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-02-26T01:19:09.024Z").ToUniversalTime(),
        UserName = "Melyna Larson",
        UserPhone = "1-915-327-0429 x509",
        WebUrl = "https://spherical-comparison.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.UpdateUcRecordingAsync(req);

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