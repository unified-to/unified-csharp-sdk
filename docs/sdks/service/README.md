# Service

## Overview

### Available Operations

* [CreateComputeService](#createcomputeservice) - Create a service
* [GetComputeService](#getcomputeservice) - Retrieve a service
* [ListComputeServices](#listcomputeservices) - List all services
* [PatchComputeService](#patchcomputeservice) - Update a service
* [RemoveComputeService](#removecomputeservice) - Remove a service
* [UpdateComputeService](#updatecomputeservice) - Update a service

## CreateComputeService

Create a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeService" method="post" path="/compute/{connection_id}/service" example="compute_service" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Service.CreateComputeServiceAsync(
    computeService: new ComputeService() {
        Branch = "main",
        BuildCommand = "npm run build",
        CreatedAt = System.DateTime.Parse("2023-10-04T02:06:29.391Z").ToUniversalTime(),
        Id = "3ca9d640-b48e-4ebe-b519-5b6a1ef05c3b",
        InstanceCount = 6D,
        MaxInstanceCount = 6D,
        Metadata = new List<ComputeMetadata>() {},
        MinInstanceCount = 1D,
        Name = "tame-sideboard",
        ProjectIdentifier = "4nyWICvPfi",
        RepoUrl = "https://github.com/Kimberly_Muller95/tame-sideboard",
        Runtime = "python",
        Status = ComputeServiceStatus.Suspended,
        Type = ComputeServiceType.Other,
        UpdatedAt = System.DateTime.Parse("2025-04-01T04:09:59.050Z").ToUniversalTime(),
        Url = "https://tame-sideboard.rotating-shoulder.biz",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeService`                                                                                                                                 | [ComputeService](../../Models/Components/ComputeService.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeServiceQueryParamFields](../../Models/Requests/CreateComputeServiceQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeServiceResponse](../../Models/Requests/CreateComputeServiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeService

Retrieve a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeService" method="get" path="/compute/{connection_id}/service/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Service.GetComputeServiceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Service                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetComputeServiceQueryParamFields](../../Models/Requests/GetComputeServiceQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeServiceResponse](../../Models/Requests/GetComputeServiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeServices

List all services

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeServices" method="get" path="/compute/{connection_id}/service" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeServicesRequest req = new ListComputeServicesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Service.ListComputeServicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListComputeServicesRequest](../../Models/Requests/ListComputeServicesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListComputeServicesResponse](../../Models/Requests/ListComputeServicesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeService

Update a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeService" method="patch" path="/compute/{connection_id}/service/{id}" example="compute_service" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeServiceRequest req = new PatchComputeServiceRequest() {
    ComputeService = new ComputeService() {
        Branch = "main",
        BuildCommand = "npm run build",
        CreatedAt = System.DateTime.Parse("2023-10-04T02:06:29.391Z").ToUniversalTime(),
        Id = "d5b098fa-2e75-4c28-8b15-eaab97a02e05",
        InstanceCount = 6D,
        MaxInstanceCount = 6D,
        Metadata = new List<ComputeMetadata>() {},
        MinInstanceCount = 1D,
        Name = "tame-sideboard",
        ProjectIdentifier = "4nyWICvPfi",
        RepoUrl = "https://github.com/Kimberly_Muller95/tame-sideboard",
        Runtime = "python",
        Status = ComputeServiceStatus.Suspended,
        Type = ComputeServiceType.Other,
        UpdatedAt = System.DateTime.Parse("2025-04-01T04:09:59.057Z").ToUniversalTime(),
        Url = "https://tame-sideboard.rotating-shoulder.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Service.PatchComputeServiceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchComputeServiceRequest](../../Models/Requests/PatchComputeServiceRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchComputeServiceResponse](../../Models/Requests/PatchComputeServiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeService

Remove a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeService" method="delete" path="/compute/{connection_id}/service/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Service.RemoveComputeServiceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Service    |

### Response

**[RemoveComputeServiceResponse](../../Models/Requests/RemoveComputeServiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeService

Update a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeService" method="put" path="/compute/{connection_id}/service/{id}" example="compute_service" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeServiceRequest req = new UpdateComputeServiceRequest() {
    ComputeService = new ComputeService() {
        Branch = "main",
        BuildCommand = "npm run build",
        CreatedAt = System.DateTime.Parse("2023-10-04T02:06:29.391Z").ToUniversalTime(),
        Id = "d5b098fa-2e75-4c28-8b15-eaab97a02e05",
        InstanceCount = 6D,
        MaxInstanceCount = 6D,
        Metadata = new List<ComputeMetadata>() {},
        MinInstanceCount = 1D,
        Name = "tame-sideboard",
        ProjectIdentifier = "4nyWICvPfi",
        RepoUrl = "https://github.com/Kimberly_Muller95/tame-sideboard",
        Runtime = "python",
        Status = ComputeServiceStatus.Suspended,
        Type = ComputeServiceType.Other,
        UpdatedAt = System.DateTime.Parse("2025-04-01T04:09:59.057Z").ToUniversalTime(),
        Url = "https://tame-sideboard.rotating-shoulder.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Service.UpdateComputeServiceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateComputeServiceRequest](../../Models/Requests/UpdateComputeServiceRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateComputeServiceResponse](../../Models/Requests/UpdateComputeServiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |