# Call

## Overview

### Available Operations

* [CreateUcCall](#createuccall) - Create a call
* [GetUcCall](#getuccall) - Retrieve a call
* [ListUcCalls](#listuccalls) - List all calls
* [PatchUcCall](#patchuccall) - Update a call
* [UpdateUcCall](#updateuccall) - Update a call

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

var res = await sdk.Call.CreateUcCallAsync(
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

var res = await sdk.Call.GetUcCallAsync(
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

var res = await sdk.Call.ListUcCallsAsync(req);

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

var res = await sdk.Call.PatchUcCallAsync(req);

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

var res = await sdk.Call.UpdateUcCallAsync(req);

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