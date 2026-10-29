# Uc

## Overview

### Available Operations

* [CreateUcCall](#createuccall) - Create a call
* [CreateUcComment](#createuccomment) - Create a comment
* [CreateUcContact](#createuccontact) - Create a contact
* [CreateUcRecording](#createucrecording) - Create a recording
* [GetUcCall](#getuccall) - Retrieve a call
* [GetUcComment](#getuccomment) - Retrieve a comment
* [GetUcContact](#getuccontact) - Retrieve a contact
* [GetUcRecording](#getucrecording) - Retrieve a recording
* [GetUcScorecard](#getucscorecard) - Retrieve a scorecard
* [GetUcScorecardtemplate](#getucscorecardtemplate) - Retrieve a scorecardtemplate
* [ListUcCalls](#listuccalls) - List all calls
* [ListUcComments](#listuccomments) - List all comments
* [ListUcContacts](#listuccontacts) - List all contacts
* [ListUcRecordings](#listucrecordings) - List all recordings
* [ListUcScorecards](#listucscorecards) - List all scorecards
* [ListUcScorecardtemplates](#listucscorecardtemplates) - List all scorecardtemplates
* [PatchUcCall](#patchuccall) - Update a call
* [PatchUcComment](#patchuccomment) - Update a comment
* [PatchUcContact](#patchuccontact) - Update a contact
* [PatchUcRecording](#patchucrecording) - Update a recording
* [RemoveUcComment](#removeuccomment) - Remove a comment
* [RemoveUcContact](#removeuccontact) - Remove a contact
* [RemoveUcRecording](#removeucrecording) - Remove a recording
* [UpdateUcCall](#updateuccall) - Update a call
* [UpdateUcComment](#updateuccomment) - Update a comment
* [UpdateUcContact](#updateuccontact) - Update a contact
* [UpdateUcRecording](#updateucrecording) - Update a recording

## CreateUcCall

Creates a UcCall. Provide the unified UcCall fields in the request body; they are mapped to the provider's API. Returns the created UcCall.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUcCall" method="post" path="/uc/{connection_id}/call" example="uc_call" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcCallAsync(
    ucCall: new UcCall() {
        AnswerAt = System.DateTime.Parse("2025-05-18T03:34:42.227Z").ToUniversalTime(),
        Contacts = new List<UcContact>() {},
        ConversationIdentifier = "65870c5e-7ff3-465b-9732-7212a2e4671c",
        CostAmount = 1.564D,
        CreatedAt = System.DateTime.Parse("2023-04-22T19:05:34.882Z").ToUniversalTime(),
        Currency = "USD",
        DurationSeconds = 2556D,
        EndAt = System.DateTime.Parse("2024-06-01T11:38:09.352Z").ToUniversalTime(),
        Id = "65870c5e-7ff3-465b-9732-7212a2e4671c",
        IsPrivate = false,
        Metadata = new List<UcMetadata>() {
            new UcMetadata() {
                ExtraData = UcMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = UcMetadataFormat.Price,
                Id = "a2653887-0ec7-478d-86f3-1a83e663f017",
                Namespace = "custom",
                Slug = "custom_field",
                Value = UcMetadataValue.CreateStr(
                    "tui"
                ),
            },
        },
        StartAt = System.DateTime.Parse("2023-12-18T20:22:36.621Z").ToUniversalTime(),
        Status = UcCallStatus.InProgress,
        Telephone = new PropertyUcCallTelephone() {
            Telephone = "(493) 534-0768",
            Type = PropertyUcCallTelephoneType.Mobile,
        },
        Type = UcCallType.Inbound,
        UpdatedAt = System.DateTime.Parse("2023-08-03T23:20:31.004Z").ToUniversalTime(),
        UserPhone = "819-894-3317 x163",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `UcCall`                                                                                                                                         | [UcCall](../../Models/Components/UcCall.md)                                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateUcCallQueryParamFields](../../Models/Requests/CreateUcCallQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateUcCallResponse](../../Models/Requests/CreateUcCallResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateUcComment

Creates a UcComment. Provide the unified UcComment fields in the request body; they are mapped to the provider's API. Returns the created UcComment.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUcComment" method="post" path="/uc/{connection_id}/comment" example="uc_comment" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcCommentAsync(
    ucComment: new UcComment() {
        Content = "Vociferor vitiosus.",
        CreatedAt = "2023-04-02T23:42:31.571Z",
        Id = "8dcec3b8-ca39-4aac-a650-7ccf778e621b",
        Metadata = new List<UcMetadata>() {},
        UpdatedAt = "2024-02-11T14:50:27.495Z",
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

Creates a UcContact. Provide the unified UcContact fields in the request body; they are mapped to the provider's API. Returns the created UcContact.

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
        Id = "7880599d-0b73-403b-9798-e626b7d516bc",
        LastName = "Rogahn",
        Metadata = new List<UcMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2023-12-12T21:25:24.170Z").ToUniversalTime(),
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

Creates a UcRecording. Provide the unified UcRecording fields in the request body; they are mapped to the provider's API. Returns the created UcRecording.

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
        ConversationIdentifier = "bba3ce69-11df-42be-a8ae-10ac0b39f6cd",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-08T01:10:04.858Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-05-03T12:32:07.606Z").ToUniversalTime(),
        Id = "bba3ce69-11df-42be-a8ae-10ac0b39f6cd",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-04-04T16:45:12.032Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-22T06:53:52.235Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-03-02T22:49:11.438Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-06-05T10:47:15.235Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-16T10:12:15.496Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-08-10T03:15:08.919Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        Metadata = new List<UcMetadata>() {},
        StartAt = System.DateTime.Parse("2023-04-28T21:22:52.259Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-21T03:11:46.690Z").ToUniversalTime(),
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

Retrieves a single UcCall by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single UcComment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single UcContact by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single UcRecording by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

## GetUcScorecard

Retrieves a single UcScorecard by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcScorecard" method="get" path="/uc/{connection_id}/scorecard/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcScorecardAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Scorecard                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetUcScorecardQueryParamFields](../../Models/Requests/GetUcScorecardQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcScorecardResponse](../../Models/Requests/GetUcScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcScorecardtemplate

Retrieves a single UcScorecardtemplate by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcScorecardtemplate" method="get" path="/uc/{connection_id}/scorecardtemplate/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcScorecardtemplateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Scorecardtemplate                                                                                                                      |
| `Fields`                                                                                                                                         | List<[GetUcScorecardtemplateQueryParamFields](../../Models/Requests/GetUcScorecardtemplateQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcScorecardtemplateResponse](../../Models/Requests/GetUcScorecardtemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcCalls

Returns a list of UcCalls. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of UcComments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of UcContacts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of UcRecordings. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

## ListUcScorecards

Returns a list of UcScorecards. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcScorecards" method="get" path="/uc/{connection_id}/scorecard" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcScorecardsRequest req = new ListUcScorecardsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcScorecardsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListUcScorecardsRequest](../../Models/Requests/ListUcScorecardsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListUcScorecardsResponse](../../Models/Requests/ListUcScorecardsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcScorecardtemplates

Returns a list of UcScorecardtemplates. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcScorecardtemplates" method="get" path="/uc/{connection_id}/scorecardtemplate" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcScorecardtemplatesRequest req = new ListUcScorecardtemplatesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcScorecardtemplatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListUcScorecardtemplatesRequest](../../Models/Requests/ListUcScorecardtemplatesRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListUcScorecardtemplatesResponse](../../Models/Requests/ListUcScorecardtemplatesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcCall

Updates the UcCall identified by `id`. Provide the unified UcCall fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUcCall" method="patch" path="/uc/{connection_id}/call/{id}" example="uc_call" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchUcCallRequest req = new PatchUcCallRequest() {
    UcCall = new UcCall() {
        AnswerAt = System.DateTime.Parse("2025-05-18T03:34:42.253Z").ToUniversalTime(),
        Contacts = new List<UcContact>() {},
        ConversationIdentifier = "34ed46fd-aab2-47e5-9663-5718a6a848ea",
        CostAmount = 1.564D,
        CreatedAt = System.DateTime.Parse("2023-04-22T19:05:34.882Z").ToUniversalTime(),
        Currency = "USD",
        DurationSeconds = 2556D,
        EndAt = System.DateTime.Parse("2024-06-01T11:38:09.366Z").ToUniversalTime(),
        Id = "34ed46fd-aab2-47e5-9663-5718a6a848ea",
        IsPrivate = false,
        Metadata = new List<UcMetadata>() {
            new UcMetadata() {
                ExtraData = UcMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = UcMetadataFormat.Price,
                Id = "afd0ef3d-ec84-4ccf-9d41-66b3a8d74b7e",
                Namespace = "custom",
                Slug = "custom_field",
                Value = UcMetadataValue.CreateStr(
                    "tui"
                ),
            },
        },
        StartAt = System.DateTime.Parse("2023-12-18T20:22:36.629Z").ToUniversalTime(),
        Status = UcCallStatus.InProgress,
        Telephone = new PropertyUcCallTelephone() {
            Telephone = "(493) 534-0768",
            Type = PropertyUcCallTelephoneType.Mobile,
        },
        Type = UcCallType.Inbound,
        UpdatedAt = System.DateTime.Parse("2023-08-03T23:20:31.008Z").ToUniversalTime(),
        UserPhone = "819-894-3317 x163",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.PatchUcCallAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [PatchUcCallRequest](../../Models/Requests/PatchUcCallRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[PatchUcCallResponse](../../Models/Requests/PatchUcCallResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcComment

Updates the UcComment identified by `id`. Provide the unified UcComment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUcComment" method="patch" path="/uc/{connection_id}/comment/{id}" example="uc_comment" -->
```csharp
using System.Collections.Generic;
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
        Id = "0534bbc8-94cd-429e-bcca-6fdde8020021",
        Metadata = new List<UcMetadata>() {},
        UpdatedAt = "2024-02-11T14:50:27.498Z",
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

Updates the UcContact identified by `id`. Provide the unified UcContact fields to change in the request body.

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
        Id = "3064aa35-57bb-4256-9bba-86889df0b32e",
        LastName = "Rogahn",
        Metadata = new List<UcMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2023-12-12T21:25:24.179Z").ToUniversalTime(),
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

Updates the UcRecording identified by `id`. Provide the unified UcRecording fields to change in the request body.

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
        ConversationIdentifier = "4a839961-6220-4b6d-a98d-4da834d1b5a1",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-08T01:10:04.879Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-05-03T12:32:07.653Z").ToUniversalTime(),
        Id = "4a839961-6220-4b6d-a98d-4da834d1b5a1",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-04-04T16:45:12.053Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-22T06:53:52.284Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-03-02T22:49:11.485Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-06-05T10:47:15.258Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-16T10:12:15.524Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-08-10T03:15:08.971Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        Metadata = new List<UcMetadata>() {},
        StartAt = System.DateTime.Parse("2023-04-28T21:22:52.267Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-21T03:11:46.723Z").ToUniversalTime(),
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

Deletes the UcComment identified by `id`.

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

Deletes the UcContact identified by `id`.

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

Deletes the UcRecording identified by `id`.

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

## UpdateUcCall

Updates the UcCall identified by `id`. Provide the unified UcCall fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUcCall" method="put" path="/uc/{connection_id}/call/{id}" example="uc_call" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateUcCallRequest req = new UpdateUcCallRequest() {
    UcCall = new UcCall() {
        AnswerAt = System.DateTime.Parse("2025-05-18T03:34:42.253Z").ToUniversalTime(),
        Contacts = new List<UcContact>() {},
        ConversationIdentifier = "34ed46fd-aab2-47e5-9663-5718a6a848ea",
        CostAmount = 1.564D,
        CreatedAt = System.DateTime.Parse("2023-04-22T19:05:34.882Z").ToUniversalTime(),
        Currency = "USD",
        DurationSeconds = 2556D,
        EndAt = System.DateTime.Parse("2024-06-01T11:38:09.366Z").ToUniversalTime(),
        Id = "34ed46fd-aab2-47e5-9663-5718a6a848ea",
        IsPrivate = false,
        Metadata = new List<UcMetadata>() {
            new UcMetadata() {
                ExtraData = UcMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = UcMetadataFormat.Price,
                Id = "afd0ef3d-ec84-4ccf-9d41-66b3a8d74b7e",
                Namespace = "custom",
                Slug = "custom_field",
                Value = UcMetadataValue.CreateStr(
                    "tui"
                ),
            },
        },
        StartAt = System.DateTime.Parse("2023-12-18T20:22:36.629Z").ToUniversalTime(),
        Status = UcCallStatus.InProgress,
        Telephone = new PropertyUcCallTelephone() {
            Telephone = "(493) 534-0768",
            Type = PropertyUcCallTelephoneType.Mobile,
        },
        Type = UcCallType.Inbound,
        UpdatedAt = System.DateTime.Parse("2023-08-03T23:20:31.008Z").ToUniversalTime(),
        UserPhone = "819-894-3317 x163",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Uc.UpdateUcCallAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [UpdateUcCallRequest](../../Models/Requests/UpdateUcCallRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[UpdateUcCallResponse](../../Models/Requests/UpdateUcCallResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcComment

Updates the UcComment identified by `id`. Provide the unified UcComment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUcComment" method="put" path="/uc/{connection_id}/comment/{id}" example="uc_comment" -->
```csharp
using System.Collections.Generic;
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
        Id = "0534bbc8-94cd-429e-bcca-6fdde8020021",
        Metadata = new List<UcMetadata>() {},
        UpdatedAt = "2024-02-11T14:50:27.498Z",
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

Updates the UcContact identified by `id`. Provide the unified UcContact fields to change in the request body.

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
        Id = "3064aa35-57bb-4256-9bba-86889df0b32e",
        LastName = "Rogahn",
        Metadata = new List<UcMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2023-12-12T21:25:24.179Z").ToUniversalTime(),
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

Updates the UcRecording identified by `id`. Provide the unified UcRecording fields to change in the request body.

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
        ConversationIdentifier = "4a839961-6220-4b6d-a98d-4da834d1b5a1",
        CreatedAt = System.DateTime.Parse("2022-09-17T19:41:46.956Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2024-05-08T01:10:04.879Z").ToUniversalTime(),
        ExpiresAt = System.DateTime.Parse("2026-05-03T12:32:07.653Z").ToUniversalTime(),
        Id = "4a839961-6220-4b6d-a98d-4da834d1b5a1",
        Media = new List<UcRecordingMedia>() {
            new UcRecordingMedia() {
                EndAt = System.DateTime.Parse("2024-04-04T16:45:12.053Z").ToUniversalTime(),
                Language = "en",
                RecordingDownloadUrl = "https://parched-wasabi.com/",
                StartAt = System.DateTime.Parse("2026-05-22T06:53:52.284Z").ToUniversalTime(),
                TranscriptDownloadUrl = "https://colossal-cuckoo.name",
                Transcripts = new List<UcRecordingTranscript>() {
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2026-03-02T22:49:11.485Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2024-06-05T10:47:15.258Z").ToUniversalTime(),
                        Text = "Turpis maiores ducimus tero speculum.",
                    },
                    new UcRecordingTranscript() {
                        EndAt = System.DateTime.Parse("2024-10-16T10:12:15.524Z").ToUniversalTime(),
                        StartAt = System.DateTime.Parse("2026-08-10T03:15:08.971Z").ToUniversalTime(),
                        Text = "Magnam consuasor uxor tergiversatio subseco.",
                    },
                },
            },
        },
        Metadata = new List<UcMetadata>() {},
        StartAt = System.DateTime.Parse("2023-04-28T21:22:52.267Z").ToUniversalTime(),
        Type = UcRecordingType.Outbound,
        UpdatedAt = System.DateTime.Parse("2025-03-21T03:11:46.723Z").ToUniversalTime(),
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