# Pullrequest

## Overview

### Available Operations

* [CreateRepoPullrequest](#createrepopullrequest) - Create a pullrequest
* [GetRepoPullrequest](#getrepopullrequest) - Retrieve a pullrequest
* [ListRepoPullrequests](#listrepopullrequests) - List all pullrequests
* [PatchRepoPullrequest](#patchrepopullrequest) - Update a pullrequest
* [RemoveRepoPullrequest](#removerepopullrequest) - Remove a pullrequest
* [UpdateRepoPullrequest](#updaterepopullrequest) - Update a pullrequest

## CreateRepoPullrequest

Creates a RepoPullrequest. Provide the unified RepoPullrequest fields in the request body; they are mapped to the provider's API. Returns the created RepoPullrequest.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoPullrequest" method="post" path="/repo/{connection_id}/pullrequest" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pullrequest.CreateRepoPullrequestAsync(
    repoPullrequest: new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-05-03T06:41:06.305Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "ebe1dd21-ff58-42b9-aa15-85a65cca5cfb",
        Labels = new List<string>() {
            "creptio",
            "tutamen",
        },
        Metadata = new List<RepoMetadata>() {},
        Notes = "Texo advoco bibo amet. Defero coadunatio turbo curtus. Consuasor aggero veritatis suggero adeo.",
        Status = RepoPullrequestStatus.Approved,
        Title = "reboot mobile application",
        UpdatedAt = System.DateTime.Parse("2026-01-19T13:17:55.887Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoPullrequest`                                                                                                                                | [RepoPullrequest](../../Models/Components/RepoPullrequest.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoPullrequestQueryParamFields](../../Models/Requests/CreateRepoPullrequestQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoPullrequestResponse](../../Models/Requests/CreateRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoPullrequest

Retrieves a single RepoPullrequest by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoPullrequest" method="get" path="/repo/{connection_id}/pullrequest/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pullrequest.GetRepoPullrequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Pullrequest                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetRepoPullrequestQueryParamFields](../../Models/Requests/GetRepoPullrequestQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoPullrequestResponse](../../Models/Requests/GetRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoPullrequests

Returns a list of RepoPullrequests. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoPullrequests" method="get" path="/repo/{connection_id}/pullrequest" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoPullrequestsRequest req = new ListRepoPullrequestsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Pullrequest.ListRepoPullrequestsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListRepoPullrequestsRequest](../../Models/Requests/ListRepoPullrequestsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListRepoPullrequestsResponse](../../Models/Requests/ListRepoPullrequestsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoPullrequest

Updates the RepoPullrequest identified by `id`. Provide the unified RepoPullrequest fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoPullrequest" method="patch" path="/repo/{connection_id}/pullrequest/{id}" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoPullrequestRequest req = new PatchRepoPullrequestRequest() {
    RepoPullrequest = new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-05-03T06:41:06.318Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "a5e287b4-383e-4b15-a304-ac494337082b",
        Labels = new List<string>() {
            "creptio",
            "tutamen",
        },
        Metadata = new List<RepoMetadata>() {},
        Notes = "Texo advoco bibo amet. Defero coadunatio turbo curtus. Consuasor aggero veritatis suggero adeo.",
        Status = RepoPullrequestStatus.Approved,
        Title = "reboot mobile application",
        UpdatedAt = System.DateTime.Parse("2026-01-19T13:17:55.903Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Pullrequest.PatchRepoPullrequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchRepoPullrequestRequest](../../Models/Requests/PatchRepoPullrequestRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchRepoPullrequestResponse](../../Models/Requests/PatchRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoPullrequest

Deletes the RepoPullrequest identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoPullrequest" method="delete" path="/repo/{connection_id}/pullrequest/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pullrequest.RemoveRepoPullrequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Pullrequest |

### Response

**[RemoveRepoPullrequestResponse](../../Models/Requests/RemoveRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoPullrequest

Updates the RepoPullrequest identified by `id`. Provide the unified RepoPullrequest fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoPullrequest" method="put" path="/repo/{connection_id}/pullrequest/{id}" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoPullrequestRequest req = new UpdateRepoPullrequestRequest() {
    RepoPullrequest = new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-05-03T06:41:06.318Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "a5e287b4-383e-4b15-a304-ac494337082b",
        Labels = new List<string>() {
            "creptio",
            "tutamen",
        },
        Metadata = new List<RepoMetadata>() {},
        Notes = "Texo advoco bibo amet. Defero coadunatio turbo curtus. Consuasor aggero veritatis suggero adeo.",
        Status = RepoPullrequestStatus.Approved,
        Title = "reboot mobile application",
        UpdatedAt = System.DateTime.Parse("2026-01-19T13:17:55.903Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Pullrequest.UpdateRepoPullrequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateRepoPullrequestRequest](../../Models/Requests/UpdateRepoPullrequestRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateRepoPullrequestResponse](../../Models/Requests/UpdateRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |