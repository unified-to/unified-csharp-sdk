# Instance

## Overview

### Available Operations

* [CreateComputeInstance](#createcomputeinstance) - Create an instance
* [GetComputeInstance](#getcomputeinstance) - Retrieve an instance
* [ListComputeInstances](#listcomputeinstances) - List all instances
* [PatchComputeInstance](#patchcomputeinstance) - Update an instance
* [RemoveComputeInstance](#removecomputeinstance) - Remove an instance
* [UpdateComputeInstance](#updatecomputeinstance) - Update an instance

## CreateComputeInstance

Creates a ComputeInstance. Provide the unified ComputeInstance fields in the request body; they are mapped to the provider's API. Returns the created ComputeInstance.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeInstance" method="post" path="/compute/{connection_id}/instance" example="compute_instance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Instance.CreateComputeInstanceAsync(
    computeInstance: new ComputeInstance() {
        AllowedActions = new List<PropertyComputeInstanceAllowedActions>() {
            PropertyComputeInstanceAllowedActions.Terminate,
        },
        Architecture = ComputeInstanceArchitecture.Other,
        CpuCount = 8D,
        CreatedAt = System.DateTime.Parse("2022-10-07T14:18:53.874Z").ToUniversalTime(),
        Currency = "USD",
        DiskMb = 1024000D,
        Endpoints = new List<ComputeEndpoint>() {
            new ComputeEndpoint() {
                IsAuthRequired = true,
                Port = 8080D,
                Protocol = Protocol.Https,
                Url = "https://serene-shark.biz/",
            },
        },
        GpuCount = 0D,
        HasInternetAccess = true,
        Id = "085ebb01-db1f-4fe6-96bc-d2819cea8f41",
        Image = "ubuntu:24.04",
        Market = Market.Spot,
        MemoryMb = 2048D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "digital-panel",
        OnIdle = OnIdle.Terminate,
        PriceAmount = 24.90336107776966D,
        PriceUnit = PriceUnit.PerInstanceHour,
        ProjectIdentifier = "g547KrivqY",
        Ssh = new PropertyComputeInstanceSsh() {
            Host = "116.42.165.89",
            Port = 22D,
            Username = "root",
        },
        StartedAt = System.DateTime.Parse("2025-03-27T15:22:03.103Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-20T05:10:01.456Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeInstance`                                                                                                                                | [ComputeInstance](../../Models/Components/ComputeInstance.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeInstanceQueryParamFields](../../Models/Requests/CreateComputeInstanceQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeInstanceResponse](../../Models/Requests/CreateComputeInstanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeInstance

Retrieves a single ComputeInstance by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeInstance" method="get" path="/compute/{connection_id}/instance/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Instance.GetComputeInstanceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Instance                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetComputeInstanceQueryParamFields](../../Models/Requests/GetComputeInstanceQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeInstanceResponse](../../Models/Requests/GetComputeInstanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeInstances

Returns a list of ComputeInstances. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeInstances" method="get" path="/compute/{connection_id}/instance" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeInstancesRequest req = new ListComputeInstancesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Instance.ListComputeInstancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListComputeInstancesRequest](../../Models/Requests/ListComputeInstancesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListComputeInstancesResponse](../../Models/Requests/ListComputeInstancesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeInstance

Updates the ComputeInstance identified by `id`. Provide the unified ComputeInstance fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeInstance" method="patch" path="/compute/{connection_id}/instance/{id}" example="compute_instance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeInstanceRequest req = new PatchComputeInstanceRequest() {
    ComputeInstance = new ComputeInstance() {
        AllowedActions = new List<PropertyComputeInstanceAllowedActions>() {
            PropertyComputeInstanceAllowedActions.Terminate,
        },
        Architecture = ComputeInstanceArchitecture.Other,
        CpuCount = 8D,
        CreatedAt = System.DateTime.Parse("2022-10-07T14:18:53.874Z").ToUniversalTime(),
        Currency = "USD",
        DiskMb = 1024000D,
        Endpoints = new List<ComputeEndpoint>() {
            new ComputeEndpoint() {
                IsAuthRequired = true,
                Port = 8080D,
                Protocol = Protocol.Https,
                Url = "https://serene-shark.biz/",
            },
        },
        GpuCount = 0D,
        HasInternetAccess = true,
        Id = "d796f797-f7ca-4a22-ba27-1f7cc393dd84",
        Image = "ubuntu:24.04",
        Market = Market.Spot,
        MemoryMb = 2048D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "digital-panel",
        OnIdle = OnIdle.Terminate,
        PriceAmount = 24.90336107776966D,
        PriceUnit = PriceUnit.PerInstanceHour,
        ProjectIdentifier = "g547KrivqY",
        Ssh = new PropertyComputeInstanceSsh() {
            Host = "116.42.165.89",
            Port = 22D,
            Username = "root",
        },
        StartedAt = System.DateTime.Parse("2025-03-27T15:22:03.122Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-20T05:10:01.477Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Instance.PatchComputeInstanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchComputeInstanceRequest](../../Models/Requests/PatchComputeInstanceRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchComputeInstanceResponse](../../Models/Requests/PatchComputeInstanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeInstance

Deletes the ComputeInstance identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeInstance" method="delete" path="/compute/{connection_id}/instance/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Instance.RemoveComputeInstanceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Instance   |

### Response

**[RemoveComputeInstanceResponse](../../Models/Requests/RemoveComputeInstanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeInstance

Updates the ComputeInstance identified by `id`. Provide the unified ComputeInstance fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeInstance" method="put" path="/compute/{connection_id}/instance/{id}" example="compute_instance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeInstanceRequest req = new UpdateComputeInstanceRequest() {
    ComputeInstance = new ComputeInstance() {
        AllowedActions = new List<PropertyComputeInstanceAllowedActions>() {
            PropertyComputeInstanceAllowedActions.Terminate,
        },
        Architecture = ComputeInstanceArchitecture.Other,
        CpuCount = 8D,
        CreatedAt = System.DateTime.Parse("2022-10-07T14:18:53.874Z").ToUniversalTime(),
        Currency = "USD",
        DiskMb = 1024000D,
        Endpoints = new List<ComputeEndpoint>() {
            new ComputeEndpoint() {
                IsAuthRequired = true,
                Port = 8080D,
                Protocol = Protocol.Https,
                Url = "https://serene-shark.biz/",
            },
        },
        GpuCount = 0D,
        HasInternetAccess = true,
        Id = "d796f797-f7ca-4a22-ba27-1f7cc393dd84",
        Image = "ubuntu:24.04",
        Market = Market.Spot,
        MemoryMb = 2048D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "digital-panel",
        OnIdle = OnIdle.Terminate,
        PriceAmount = 24.90336107776966D,
        PriceUnit = PriceUnit.PerInstanceHour,
        ProjectIdentifier = "g547KrivqY",
        Ssh = new PropertyComputeInstanceSsh() {
            Host = "116.42.165.89",
            Port = 22D,
            Username = "root",
        },
        StartedAt = System.DateTime.Parse("2025-03-27T15:22:03.122Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-20T05:10:01.477Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Instance.UpdateComputeInstanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateComputeInstanceRequest](../../Models/Requests/UpdateComputeInstanceRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateComputeInstanceResponse](../../Models/Requests/UpdateComputeInstanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |