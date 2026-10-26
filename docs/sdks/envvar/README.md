# Envvar

## Overview

### Available Operations

* [CreateComputeEnvvar](#createcomputeenvvar) - Create an envvar
* [GetComputeEnvvar](#getcomputeenvvar) - Retrieve an envvar
* [ListComputeEnvvars](#listcomputeenvvars) - List all envvars
* [PatchComputeEnvvar](#patchcomputeenvvar) - Update an envvar
* [RemoveComputeEnvvar](#removecomputeenvvar) - Remove an envvar
* [UpdateComputeEnvvar](#updatecomputeenvvar) - Update an envvar

## CreateComputeEnvvar

Creates a ComputeEnvvar. Provide the unified ComputeEnvvar fields in the request body; they are mapped to the provider's API. Returns the created ComputeEnvvar.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeEnvvar" method="post" path="/compute/{connection_id}/envvar" example="compute_envvar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Envvar.CreateComputeEnvvarAsync(
    computeEnvvar: new ComputeEnvvar() {
        CreatedAt = System.DateTime.Parse("2021-08-16T07:52:27.306Z").ToUniversalTime(),
        Environments = new List<PropertyComputeEnvvarEnvironments>() {
            PropertyComputeEnvvarEnvironments.Preview,
        },
        Id = "6b69d0c9-610e-497e-969b-77e3a60564b1",
        IsSecret = true,
        Metadata = new List<ComputeMetadata>() {},
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-07-07T06:44:56.255Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeEnvvar`                                                                                                                                  | [ComputeEnvvar](../../Models/Components/ComputeEnvvar.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeEnvvarQueryParamFields](../../Models/Requests/CreateComputeEnvvarQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeEnvvarResponse](../../Models/Requests/CreateComputeEnvvarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeEnvvar

Retrieves a single ComputeEnvvar by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeEnvvar" method="get" path="/compute/{connection_id}/envvar/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Envvar.GetComputeEnvvarAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Envvar                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetComputeEnvvarQueryParamFields](../../Models/Requests/GetComputeEnvvarQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeEnvvarResponse](../../Models/Requests/GetComputeEnvvarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeEnvvars

Returns a list of ComputeEnvvars. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeEnvvars" method="get" path="/compute/{connection_id}/envvar" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeEnvvarsRequest req = new ListComputeEnvvarsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Envvar.ListComputeEnvvarsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListComputeEnvvarsRequest](../../Models/Requests/ListComputeEnvvarsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListComputeEnvvarsResponse](../../Models/Requests/ListComputeEnvvarsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeEnvvar

Updates the ComputeEnvvar identified by `id`. Provide the unified ComputeEnvvar fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeEnvvar" method="patch" path="/compute/{connection_id}/envvar/{id}" example="compute_envvar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeEnvvarRequest req = new PatchComputeEnvvarRequest() {
    ComputeEnvvar = new ComputeEnvvar() {
        CreatedAt = System.DateTime.Parse("2021-08-16T07:52:27.306Z").ToUniversalTime(),
        Environments = new List<PropertyComputeEnvvarEnvironments>() {
            PropertyComputeEnvvarEnvironments.Preview,
        },
        Id = "02d66fcc-3f1b-48bb-acdc-d85b8efe5b12",
        IsSecret = true,
        Metadata = new List<ComputeMetadata>() {},
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-07-07T06:44:56.271Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Envvar.PatchComputeEnvvarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchComputeEnvvarRequest](../../Models/Requests/PatchComputeEnvvarRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchComputeEnvvarResponse](../../Models/Requests/PatchComputeEnvvarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeEnvvar

Deletes the ComputeEnvvar identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeEnvvar" method="delete" path="/compute/{connection_id}/envvar/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Envvar.RemoveComputeEnvvarAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Envvar     |

### Response

**[RemoveComputeEnvvarResponse](../../Models/Requests/RemoveComputeEnvvarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeEnvvar

Updates the ComputeEnvvar identified by `id`. Provide the unified ComputeEnvvar fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeEnvvar" method="put" path="/compute/{connection_id}/envvar/{id}" example="compute_envvar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeEnvvarRequest req = new UpdateComputeEnvvarRequest() {
    ComputeEnvvar = new ComputeEnvvar() {
        CreatedAt = System.DateTime.Parse("2021-08-16T07:52:27.306Z").ToUniversalTime(),
        Environments = new List<PropertyComputeEnvvarEnvironments>() {
            PropertyComputeEnvvarEnvironments.Preview,
        },
        Id = "02d66fcc-3f1b-48bb-acdc-d85b8efe5b12",
        IsSecret = true,
        Metadata = new List<ComputeMetadata>() {},
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-07-07T06:44:56.271Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Envvar.UpdateComputeEnvvarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateComputeEnvvarRequest](../../Models/Requests/UpdateComputeEnvvarRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateComputeEnvvarResponse](../../Models/Requests/UpdateComputeEnvvarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |