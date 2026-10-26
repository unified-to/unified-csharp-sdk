# Request

## Overview

### Available Operations

* [CreateVerificationRequest](#createverificationrequest) - Create a request
* [GetVerificationRequest](#getverificationrequest) - Retrieve a request
* [ListVerificationRequests](#listverificationrequests) - List all requests
* [PatchVerificationRequest](#patchverificationrequest) - Update a request
* [RemoveVerificationRequest](#removeverificationrequest) - Remove a request
* [UpdateVerificationRequest](#updateverificationrequest) - Update a request

## CreateVerificationRequest

Creates a VerificationRequest. Provide the unified VerificationRequest fields in the request body; they are mapped to the provider's API. Returns the created VerificationRequest.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createVerificationRequest" method="post" path="/verification/{connection_id}/request" example="verification_request" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Request.CreateVerificationRequestAsync(
    verificationRequest: new VerificationRequest() {
        CreatedAt = System.DateTime.Parse("2023-11-20T08:17:29.950Z").ToUniversalTime(),
        Id = "818754bc-9b27-4bb3-b042-300f099ccfc9",
        Metadata = new List<VerificationMetadata>() {},
        Parameters = new List<VerificationParameterInput>() {},
        ProfileAddresses = new List<VerificationAddress>() {},
        ProfileEmails = new List<string>() {},
        ProfileTelephones = new List<string>() {},
        ResponseDetails = new List<VerificationResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseSource = "Implemented regional protocol",
        ResponseStatus = VerificationRequestResponseStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-12-27T11:06:31.815Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `VerificationRequest`                                                                                                                            | [VerificationRequest](../../Models/Components/VerificationRequest.md)                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateVerificationRequestQueryParamFields](../../Models/Requests/CreateVerificationRequestQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateVerificationRequestResponse](../../Models/Requests/CreateVerificationRequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetVerificationRequest

Retrieves a single VerificationRequest by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVerificationRequest" method="get" path="/verification/{connection_id}/request/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Request.GetVerificationRequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Request                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetVerificationRequestQueryParamFields](../../Models/Requests/GetVerificationRequestQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetVerificationRequestResponse](../../Models/Requests/GetVerificationRequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListVerificationRequests

Returns a list of VerificationRequests. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listVerificationRequests" method="get" path="/verification/{connection_id}/request" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListVerificationRequestsRequest req = new ListVerificationRequestsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Request.ListVerificationRequestsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListVerificationRequestsRequest](../../Models/Requests/ListVerificationRequestsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListVerificationRequestsResponse](../../Models/Requests/ListVerificationRequestsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchVerificationRequest

Updates the VerificationRequest identified by `id`. Provide the unified VerificationRequest fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchVerificationRequest" method="patch" path="/verification/{connection_id}/request/{id}" example="verification_request" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchVerificationRequestRequest req = new PatchVerificationRequestRequest() {
    VerificationRequest = new VerificationRequest() {
        CreatedAt = System.DateTime.Parse("2023-11-20T08:17:29.950Z").ToUniversalTime(),
        Id = "c2a31ea1-2995-4703-8e0d-d99e385f9d6c",
        Metadata = new List<VerificationMetadata>() {},
        Parameters = new List<VerificationParameterInput>() {},
        ProfileAddresses = new List<VerificationAddress>() {},
        ProfileEmails = new List<string>() {},
        ProfileTelephones = new List<string>() {},
        ResponseDetails = new List<VerificationResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseSource = "Implemented regional protocol",
        ResponseStatus = VerificationRequestResponseStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-12-27T11:06:31.816Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Request.PatchVerificationRequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [PatchVerificationRequestRequest](../../Models/Requests/PatchVerificationRequestRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[PatchVerificationRequestResponse](../../Models/Requests/PatchVerificationRequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveVerificationRequest

Deletes the VerificationRequest identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeVerificationRequest" method="delete" path="/verification/{connection_id}/request/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Request.RemoveVerificationRequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Request    |

### Response

**[RemoveVerificationRequestResponse](../../Models/Requests/RemoveVerificationRequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateVerificationRequest

Updates the VerificationRequest identified by `id`. Provide the unified VerificationRequest fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateVerificationRequest" method="put" path="/verification/{connection_id}/request/{id}" example="verification_request" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateVerificationRequestRequest req = new UpdateVerificationRequestRequest() {
    VerificationRequest = new VerificationRequest() {
        CreatedAt = System.DateTime.Parse("2023-11-20T08:17:29.950Z").ToUniversalTime(),
        Id = "c2a31ea1-2995-4703-8e0d-d99e385f9d6c",
        Metadata = new List<VerificationMetadata>() {},
        Parameters = new List<VerificationParameterInput>() {},
        ProfileAddresses = new List<VerificationAddress>() {},
        ProfileEmails = new List<string>() {},
        ProfileTelephones = new List<string>() {},
        ResponseDetails = new List<VerificationResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseSource = "Implemented regional protocol",
        ResponseStatus = VerificationRequestResponseStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-12-27T11:06:31.816Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Request.UpdateVerificationRequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateVerificationRequestRequest](../../Models/Requests/UpdateVerificationRequestRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[UpdateVerificationRequestResponse](../../Models/Requests/UpdateVerificationRequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |