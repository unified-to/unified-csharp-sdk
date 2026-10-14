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

Create a deployment

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
        FinishedAt = System.DateTime.Parse("2025-08-24T08:43:14.650Z").ToUniversalTime(),
        Id = "50d3279e-c059-42e8-9d6e-1c11be57dbcc",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-05T16:16:05.682Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-22T16:03:20.206Z").ToUniversalTime(),
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

Retrieve a deployment

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

List all deployments

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

Update a deployment

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
        FinishedAt = System.DateTime.Parse("2025-08-24T08:43:14.661Z").ToUniversalTime(),
        Id = "6850c8fe-2e9e-48dc-88ca-f78a3ec12733",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-05T16:16:05.691Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-22T16:03:20.218Z").ToUniversalTime(),
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

Remove a deployment

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

Update a deployment

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
        FinishedAt = System.DateTime.Parse("2025-08-24T08:43:14.661Z").ToUniversalTime(),
        Id = "6850c8fe-2e9e-48dc-88ca-f78a3ec12733",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-05T16:16:05.691Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-22T16:03:20.218Z").ToUniversalTime(),
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