# Deployment

## Overview

### Available Operations

* [CreateComputeDeployment](#createcomputedeployment) - Create a deployment
* [GetComputeDeployment](#getcomputedeployment) - Retrieve a deployment
* [ListComputeDeployments](#listcomputedeployments) - List all deployments
* [PatchComputeDeployment](#patchcomputedeployment) - Update a deployment
* [RemoveComputeDeployment](#removecomputedeployment) - Remove a deployment
* [UpdateComputeDeployment](#updatecomputedeployment) - Update a deployment

## CreateComputeDeployment

Creates a ComputeDeployment. Provide the unified ComputeDeployment fields in the request body; they are mapped to the provider's API. Returns the created ComputeDeployment.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeDeployment" method="post" path="/compute/{connection_id}/deployment" example="compute_deployment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deployment.CreateComputeDeploymentAsync(
    computeDeployment: new ComputeDeployment() {
        Branch = "develop",
        CommitIdentifier = "fadfe54eefd8fea670bea6d58b4b15d406c4b02b",
        CommitMessage = "copy primary pixel",
        CreatedAt = System.DateTime.Parse("2022-06-07T03:52:04.613Z").ToUniversalTime(),
        Environment = UnifiedTo.Models.Components.Environment.Preview,
        FinishedAt = System.DateTime.Parse("2025-08-30T07:16:06.906Z").ToUniversalTime(),
        Id = "8fe619d8-d808-4266-b6bc-328ceadbd5d8",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-10T21:44:12.866Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-03-01T12:44:07.143Z").ToUniversalTime(),
        Url = "https://comfortable-petal.name",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeDeployment`                                                                                                                              | [ComputeDeployment](../../Models/Components/ComputeDeployment.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeDeploymentQueryParamFields](../../Models/Requests/CreateComputeDeploymentQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeDeploymentResponse](../../Models/Requests/CreateComputeDeploymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeDeployment

Retrieves a single ComputeDeployment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeDeployment" method="get" path="/compute/{connection_id}/deployment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deployment.GetComputeDeploymentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Deployment                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetComputeDeploymentQueryParamFields](../../Models/Requests/GetComputeDeploymentQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeDeploymentResponse](../../Models/Requests/GetComputeDeploymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeDeployments

Returns a list of ComputeDeployments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeDeployments" method="get" path="/compute/{connection_id}/deployment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeDeploymentsRequest req = new ListComputeDeploymentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Deployment.ListComputeDeploymentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListComputeDeploymentsRequest](../../Models/Requests/ListComputeDeploymentsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListComputeDeploymentsResponse](../../Models/Requests/ListComputeDeploymentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeDeployment

Updates the ComputeDeployment identified by `id`. Provide the unified ComputeDeployment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeDeployment" method="patch" path="/compute/{connection_id}/deployment/{id}" example="compute_deployment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeDeploymentRequest req = new PatchComputeDeploymentRequest() {
    ComputeDeployment = new ComputeDeployment() {
        Branch = "develop",
        CommitIdentifier = "fadfe54eefd8fea670bea6d58b4b15d406c4b02b",
        CommitMessage = "copy primary pixel",
        CreatedAt = System.DateTime.Parse("2022-06-07T03:52:04.613Z").ToUniversalTime(),
        Environment = UnifiedTo.Models.Components.Environment.Preview,
        FinishedAt = System.DateTime.Parse("2025-08-30T07:16:06.920Z").ToUniversalTime(),
        Id = "e0d84afa-4513-4fd6-b2f4-e0743e6c83ba",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-10T21:44:12.879Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-03-01T12:44:07.159Z").ToUniversalTime(),
        Url = "https://comfortable-petal.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deployment.PatchComputeDeploymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchComputeDeploymentRequest](../../Models/Requests/PatchComputeDeploymentRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchComputeDeploymentResponse](../../Models/Requests/PatchComputeDeploymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeDeployment

Deletes the ComputeDeployment identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeDeployment" method="delete" path="/compute/{connection_id}/deployment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deployment.RemoveComputeDeploymentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deployment |

### Response

**[RemoveComputeDeploymentResponse](../../Models/Requests/RemoveComputeDeploymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeDeployment

Updates the ComputeDeployment identified by `id`. Provide the unified ComputeDeployment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeDeployment" method="put" path="/compute/{connection_id}/deployment/{id}" example="compute_deployment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeDeploymentRequest req = new UpdateComputeDeploymentRequest() {
    ComputeDeployment = new ComputeDeployment() {
        Branch = "develop",
        CommitIdentifier = "fadfe54eefd8fea670bea6d58b4b15d406c4b02b",
        CommitMessage = "copy primary pixel",
        CreatedAt = System.DateTime.Parse("2022-06-07T03:52:04.613Z").ToUniversalTime(),
        Environment = UnifiedTo.Models.Components.Environment.Preview,
        FinishedAt = System.DateTime.Parse("2025-08-30T07:16:06.920Z").ToUniversalTime(),
        Id = "e0d84afa-4513-4fd6-b2f4-e0743e6c83ba",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-10T21:44:12.879Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-03-01T12:44:07.159Z").ToUniversalTime(),
        Url = "https://comfortable-petal.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deployment.UpdateComputeDeploymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateComputeDeploymentRequest](../../Models/Requests/UpdateComputeDeploymentRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateComputeDeploymentResponse](../../Models/Requests/UpdateComputeDeploymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |