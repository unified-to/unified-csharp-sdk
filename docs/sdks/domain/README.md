# Domain

## Overview

### Available Operations

* [CreateComputeDomain](#createcomputedomain) - Create a domain
* [GetComputeDomain](#getcomputedomain) - Retrieve a domain
* [ListComputeDomains](#listcomputedomains) - List all domains
* [PatchComputeDomain](#patchcomputedomain) - Update a domain
* [RemoveComputeDomain](#removecomputedomain) - Remove a domain
* [UpdateComputeDomain](#updatecomputedomain) - Update a domain

## CreateComputeDomain

Creates a ComputeDomain. Provide the unified ComputeDomain fields in the request body; they are mapped to the provider's API. Returns the created ComputeDomain.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeDomain" method="post" path="/compute/{connection_id}/domain" example="compute_domain" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Domain.CreateComputeDomainAsync(
    computeDomain: new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "3232d9d3-f8be-4d32-bee6-4e46f3d18248",
        IsPrimary = false,
        Metadata = new List<ComputeMetadata>() {},
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-04T18:46:37.053Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeDomain`                                                                                                                                  | [ComputeDomain](../../Models/Components/ComputeDomain.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeDomainQueryParamFields](../../Models/Requests/CreateComputeDomainQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeDomainResponse](../../Models/Requests/CreateComputeDomainResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeDomain

Retrieves a single ComputeDomain by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeDomain" method="get" path="/compute/{connection_id}/domain/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Domain.GetComputeDomainAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Domain                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetComputeDomainQueryParamFields](../../Models/Requests/GetComputeDomainQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeDomainResponse](../../Models/Requests/GetComputeDomainResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeDomains

Returns a list of ComputeDomains. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeDomains" method="get" path="/compute/{connection_id}/domain" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeDomainsRequest req = new ListComputeDomainsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Domain.ListComputeDomainsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListComputeDomainsRequest](../../Models/Requests/ListComputeDomainsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListComputeDomainsResponse](../../Models/Requests/ListComputeDomainsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeDomain

Updates the ComputeDomain identified by `id`. Provide the unified ComputeDomain fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeDomain" method="patch" path="/compute/{connection_id}/domain/{id}" example="compute_domain" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeDomainRequest req = new PatchComputeDomainRequest() {
    ComputeDomain = new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "110e9f67-fef1-4954-bd8d-c0c80a54ea29",
        IsPrimary = false,
        Metadata = new List<ComputeMetadata>() {},
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-04T18:46:37.060Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Domain.PatchComputeDomainAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchComputeDomainRequest](../../Models/Requests/PatchComputeDomainRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchComputeDomainResponse](../../Models/Requests/PatchComputeDomainResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeDomain

Deletes the ComputeDomain identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeDomain" method="delete" path="/compute/{connection_id}/domain/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Domain.RemoveComputeDomainAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Domain     |

### Response

**[RemoveComputeDomainResponse](../../Models/Requests/RemoveComputeDomainResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeDomain

Updates the ComputeDomain identified by `id`. Provide the unified ComputeDomain fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeDomain" method="put" path="/compute/{connection_id}/domain/{id}" example="compute_domain" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeDomainRequest req = new UpdateComputeDomainRequest() {
    ComputeDomain = new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "110e9f67-fef1-4954-bd8d-c0c80a54ea29",
        IsPrimary = false,
        Metadata = new List<ComputeMetadata>() {},
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-04T18:46:37.060Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Domain.UpdateComputeDomainAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateComputeDomainRequest](../../Models/Requests/UpdateComputeDomainRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateComputeDomainResponse](../../Models/Requests/UpdateComputeDomainResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |