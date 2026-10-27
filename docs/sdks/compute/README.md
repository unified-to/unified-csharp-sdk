# Compute

## Overview

### Available Operations

* [CreateComputeDeployment](#createcomputedeployment) - Create a deployment
* [CreateComputeDomain](#createcomputedomain) - Create a domain
* [CreateComputeEnvvar](#createcomputeenvvar) - Create an envvar
* [CreateComputeInstance](#createcomputeinstance) - Create an instance
* [CreateComputeKey](#createcomputekey) - Create a key
* [CreateComputeService](#createcomputeservice) - Create a service
* [CreateComputeSnapshot](#createcomputesnapshot) - Create a snapshot
* [CreateComputeTemplate](#createcomputetemplate) - Create a template
* [CreateComputeVolume](#createcomputevolume) - Create a volume
* [GetComputeDeployment](#getcomputedeployment) - Retrieve a deployment
* [GetComputeDomain](#getcomputedomain) - Retrieve a domain
* [GetComputeEnvvar](#getcomputeenvvar) - Retrieve an envvar
* [GetComputeGputype](#getcomputegputype) - Retrieve a gputype
* [GetComputeInstance](#getcomputeinstance) - Retrieve an instance
* [GetComputeKey](#getcomputekey) - Retrieve a key
* [GetComputeRegion](#getcomputeregion) - Retrieve a region
* [GetComputeService](#getcomputeservice) - Retrieve a service
* [GetComputeSnapshot](#getcomputesnapshot) - Retrieve a snapshot
* [GetComputeTemplate](#getcomputetemplate) - Retrieve a template
* [GetComputeVolume](#getcomputevolume) - Retrieve a volume
* [ListComputeDeployments](#listcomputedeployments) - List all deployments
* [ListComputeDomains](#listcomputedomains) - List all domains
* [ListComputeEnvvars](#listcomputeenvvars) - List all envvars
* [ListComputeGputypes](#listcomputegputypes) - List all gputypes
* [ListComputeInstances](#listcomputeinstances) - List all instances
* [ListComputeKeys](#listcomputekeys) - List all keys
* [ListComputeRegions](#listcomputeregions) - List all regions
* [ListComputeServices](#listcomputeservices) - List all services
* [ListComputeSnapshots](#listcomputesnapshots) - List all snapshots
* [ListComputeTemplates](#listcomputetemplates) - List all templates
* [ListComputeUsages](#listcomputeusages) - List all usages
* [ListComputeVolumes](#listcomputevolumes) - List all volumes
* [PatchComputeDeployment](#patchcomputedeployment) - Update a deployment
* [PatchComputeDomain](#patchcomputedomain) - Update a domain
* [PatchComputeEnvvar](#patchcomputeenvvar) - Update an envvar
* [PatchComputeInstance](#patchcomputeinstance) - Update an instance
* [PatchComputeKey](#patchcomputekey) - Update a key
* [PatchComputeService](#patchcomputeservice) - Update a service
* [PatchComputeTemplate](#patchcomputetemplate) - Update a template
* [PatchComputeVolume](#patchcomputevolume) - Update a volume
* [RemoveComputeDeployment](#removecomputedeployment) - Remove a deployment
* [RemoveComputeDomain](#removecomputedomain) - Remove a domain
* [RemoveComputeEnvvar](#removecomputeenvvar) - Remove an envvar
* [RemoveComputeInstance](#removecomputeinstance) - Remove an instance
* [RemoveComputeKey](#removecomputekey) - Remove a key
* [RemoveComputeService](#removecomputeservice) - Remove a service
* [RemoveComputeSnapshot](#removecomputesnapshot) - Remove a snapshot
* [RemoveComputeTemplate](#removecomputetemplate) - Remove a template
* [RemoveComputeVolume](#removecomputevolume) - Remove a volume
* [UpdateComputeDeployment](#updatecomputedeployment) - Update a deployment
* [UpdateComputeDomain](#updatecomputedomain) - Update a domain
* [UpdateComputeEnvvar](#updatecomputeenvvar) - Update an envvar
* [UpdateComputeInstance](#updatecomputeinstance) - Update an instance
* [UpdateComputeKey](#updatecomputekey) - Update a key
* [UpdateComputeService](#updatecomputeservice) - Update a service
* [UpdateComputeTemplate](#updatecomputetemplate) - Update a template
* [UpdateComputeVolume](#updatecomputevolume) - Update a volume

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

var res = await sdk.Compute.CreateComputeDeploymentAsync(
    computeDeployment: new ComputeDeployment() {
        Branch = "develop",
        CommitIdentifier = "fadfe54eefd8fea670bea6d58b4b15d406c4b02b",
        CommitMessage = "copy primary pixel",
        CreatedAt = System.DateTime.Parse("2022-06-07T03:52:04.613Z").ToUniversalTime(),
        Environment = UnifiedTo.Models.Components.Environment.Preview,
        FinishedAt = System.DateTime.Parse("2025-09-03T01:51:06.179Z").ToUniversalTime(),
        Id = "325e114e-cec1-4e4b-aaa2-7b84cd481cfd",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-14T05:28:00.976Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-03-05T21:22:56.307Z").ToUniversalTime(),
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

var res = await sdk.Compute.CreateComputeDomainAsync(
    computeDomain: new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "df9e628c-1cb1-4ef3-a378-2c52b235772d",
        IsPrimary = false,
        Metadata = new List<ComputeMetadata>() {},
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-07T01:45:21.859Z").ToUniversalTime(),
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

var res = await sdk.Compute.CreateComputeEnvvarAsync(
    computeEnvvar: new ComputeEnvvar() {
        CreatedAt = System.DateTime.Parse("2021-08-16T07:52:27.306Z").ToUniversalTime(),
        Environments = new List<PropertyComputeEnvvarEnvironments>() {
            PropertyComputeEnvvarEnvironments.Preview,
        },
        Id = "800ae970-995f-4a91-84bf-e9155a3f9d4c",
        IsSecret = true,
        Metadata = new List<ComputeMetadata>() {},
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-07-08T02:39:10.759Z").ToUniversalTime(),
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

var res = await sdk.Compute.CreateComputeInstanceAsync(
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

## CreateComputeKey

Creates a ComputeKey. Provide the unified ComputeKey fields in the request body; they are mapped to the provider's API. Returns the created ComputeKey.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeKey" method="post" path="/compute/{connection_id}/key" example="compute_key" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.CreateComputeKeyAsync(
    computeKey: new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "225d3457-7795-457f-976f-ebbedfb707c3",
        Metadata = new List<ComputeMetadata>() {},
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-09T03:02:43.814Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeKey`                                                                                                                                     | [ComputeKey](../../Models/Components/ComputeKey.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeKeyQueryParamFields](../../Models/Requests/CreateComputeKeyQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeKeyResponse](../../Models/Requests/CreateComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateComputeService

Creates a ComputeService. Provide the unified ComputeService fields in the request body; they are mapped to the provider's API. Returns the created ComputeService.

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

var res = await sdk.Compute.CreateComputeServiceAsync(
    computeService: new ComputeService() {
        Branch = "main",
        BuildCommand = "npm run build",
        CreatedAt = System.DateTime.Parse("2023-10-04T02:06:29.391Z").ToUniversalTime(),
        Id = "c6eac0c8-5775-4a9a-98a4-0e72d6351171",
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
        UpdatedAt = System.DateTime.Parse("2025-04-07T15:45:09.879Z").ToUniversalTime(),
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

## CreateComputeSnapshot

Creates a ComputeSnapshot. Provide the unified ComputeSnapshot fields in the request body; they are mapped to the provider's API. Returns the created ComputeSnapshot.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeSnapshot" method="post" path="/compute/{connection_id}/snapshot" example="compute_snapshot" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.CreateComputeSnapshotAsync(
    computeSnapshot: new ComputeSnapshot() {
        CreatedAt = System.DateTime.Parse("2021-09-24T14:40:06.110Z").ToUniversalTime(),
        Id = "0c8d4da4-1926-4eb7-b85e-3653647b295e",
        Metadata = new List<ComputeMetadata>() {},
        Name = "snap-alius",
        SizeMb = 169984D,
        Status = ComputeSnapshotStatus.Deleting,
        Type = ComputeSnapshotType.Disk,
        UpdatedAt = System.DateTime.Parse("2026-04-05T06:00:44.129Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeSnapshot`                                                                                                                                | [ComputeSnapshot](../../Models/Components/ComputeSnapshot.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeSnapshotQueryParamFields](../../Models/Requests/CreateComputeSnapshotQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeSnapshotResponse](../../Models/Requests/CreateComputeSnapshotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateComputeTemplate

Creates a ComputeTemplate. Provide the unified ComputeTemplate fields in the request body; they are mapped to the provider's API. Returns the created ComputeTemplate.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeTemplate" method="post" path="/compute/{connection_id}/template" example="compute_template" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.CreateComputeTemplateAsync(
    computeTemplate: new ComputeTemplate() {
        CpuCount = 4D,
        CreatedAt = System.DateTime.Parse("2023-02-23T03:28:59.864Z").ToUniversalTime(),
        DiskMb = 10240D,
        Dockerfile = @"FROM ubuntu:24.04
        RUN apt-get update",
        GpuCount = 2D,
        GpuModel = ComputeTemplateGpuModel.NvidiaGh200,
        Id = "b612e8ae-b21e-4b9f-bf4b-8a853d046d90",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-28T22:08:25.240Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-16T00:36:54.783Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeTemplate`                                                                                                                                | [ComputeTemplate](../../Models/Components/ComputeTemplate.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeTemplateQueryParamFields](../../Models/Requests/CreateComputeTemplateQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeTemplateResponse](../../Models/Requests/CreateComputeTemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateComputeVolume

Creates a ComputeVolume. Provide the unified ComputeVolume fields in the request body; they are mapped to the provider's API. Returns the created ComputeVolume.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeVolume" method="post" path="/compute/{connection_id}/volume" example="compute_volume" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.CreateComputeVolumeAsync(
    computeVolume: new ComputeVolume() {
        CreatedAt = System.DateTime.Parse("2022-11-15T15:12:48.055Z").ToUniversalTime(),
        Id = "d540de03-d0c6-4a6f-b391-39dac065f4f6",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-11T19:17:37.500Z").ToUniversalTime(),
        UsedMb = 524986D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeVolume`                                                                                                                                  | [ComputeVolume](../../Models/Components/ComputeVolume.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeVolumeQueryParamFields](../../Models/Requests/CreateComputeVolumeQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeVolumeResponse](../../Models/Requests/CreateComputeVolumeResponse.md)**

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

var res = await sdk.Compute.GetComputeDeploymentAsync(
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

var res = await sdk.Compute.GetComputeDomainAsync(
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

var res = await sdk.Compute.GetComputeEnvvarAsync(
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

## GetComputeGputype

Retrieves a single ComputeGputype by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeGputype" method="get" path="/compute/{connection_id}/gputype/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeGputypeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Gputype                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetComputeGputypeQueryParamFields](../../Models/Requests/GetComputeGputypeQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeGputypeResponse](../../Models/Requests/GetComputeGputypeResponse.md)**

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

var res = await sdk.Compute.GetComputeInstanceAsync(
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

## GetComputeKey

Retrieves a single ComputeKey by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeKey" method="get" path="/compute/{connection_id}/key/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeKeyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Key                                                                                                                                    |
| `Fields`                                                                                                                                         | List<[GetComputeKeyQueryParamFields](../../Models/Requests/GetComputeKeyQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeKeyResponse](../../Models/Requests/GetComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeRegion

Retrieves a single ComputeRegion by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeRegion" method="get" path="/compute/{connection_id}/region/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeRegionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Region                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetComputeRegionQueryParamFields](../../Models/Requests/GetComputeRegionQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeRegionResponse](../../Models/Requests/GetComputeRegionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeService

Retrieves a single ComputeService by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeService" method="get" path="/compute/{connection_id}/service/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeServiceAsync(
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

## GetComputeSnapshot

Retrieves a single ComputeSnapshot by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeSnapshot" method="get" path="/compute/{connection_id}/snapshot/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeSnapshotAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Snapshot                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetComputeSnapshotQueryParamFields](../../Models/Requests/GetComputeSnapshotQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeSnapshotResponse](../../Models/Requests/GetComputeSnapshotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeTemplate

Retrieves a single ComputeTemplate by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeTemplate" method="get" path="/compute/{connection_id}/template/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeTemplateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Template                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetComputeTemplateQueryParamFields](../../Models/Requests/GetComputeTemplateQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeTemplateResponse](../../Models/Requests/GetComputeTemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeVolume

Retrieves a single ComputeVolume by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeVolume" method="get" path="/compute/{connection_id}/volume/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.GetComputeVolumeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Volume                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetComputeVolumeQueryParamFields](../../Models/Requests/GetComputeVolumeQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeVolumeResponse](../../Models/Requests/GetComputeVolumeResponse.md)**

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

var res = await sdk.Compute.ListComputeDeploymentsAsync(req);

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

var res = await sdk.Compute.ListComputeDomainsAsync(req);

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

var res = await sdk.Compute.ListComputeEnvvarsAsync(req);

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

## ListComputeGputypes

Returns a list of ComputeGputypes. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeGputypes" method="get" path="/compute/{connection_id}/gputype" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeGputypesRequest req = new ListComputeGputypesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeGputypesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListComputeGputypesRequest](../../Models/Requests/ListComputeGputypesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListComputeGputypesResponse](../../Models/Requests/ListComputeGputypesResponse.md)**

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

var res = await sdk.Compute.ListComputeInstancesAsync(req);

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

## ListComputeKeys

Returns a list of ComputeKeys. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeKeys" method="get" path="/compute/{connection_id}/key" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeKeysRequest req = new ListComputeKeysRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeKeysAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListComputeKeysRequest](../../Models/Requests/ListComputeKeysRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListComputeKeysResponse](../../Models/Requests/ListComputeKeysResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeRegions

Returns a list of ComputeRegions. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeRegions" method="get" path="/compute/{connection_id}/region" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeRegionsRequest req = new ListComputeRegionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeRegionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListComputeRegionsRequest](../../Models/Requests/ListComputeRegionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListComputeRegionsResponse](../../Models/Requests/ListComputeRegionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeServices

Returns a list of ComputeServices. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Compute.ListComputeServicesAsync(req);

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

## ListComputeSnapshots

Returns a list of ComputeSnapshots. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeSnapshots" method="get" path="/compute/{connection_id}/snapshot" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeSnapshotsRequest req = new ListComputeSnapshotsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeSnapshotsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListComputeSnapshotsRequest](../../Models/Requests/ListComputeSnapshotsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListComputeSnapshotsResponse](../../Models/Requests/ListComputeSnapshotsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeTemplates

Returns a list of ComputeTemplates. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeTemplates" method="get" path="/compute/{connection_id}/template" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeTemplatesRequest req = new ListComputeTemplatesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeTemplatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListComputeTemplatesRequest](../../Models/Requests/ListComputeTemplatesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListComputeTemplatesResponse](../../Models/Requests/ListComputeTemplatesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeUsages

Returns a list of ComputeUsages. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeUsages" method="get" path="/compute/{connection_id}/usage" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeUsagesRequest req = new ListComputeUsagesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeUsagesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListComputeUsagesRequest](../../Models/Requests/ListComputeUsagesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListComputeUsagesResponse](../../Models/Requests/ListComputeUsagesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeVolumes

Returns a list of ComputeVolumes. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeVolumes" method="get" path="/compute/{connection_id}/volume" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeVolumesRequest req = new ListComputeVolumesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Compute.ListComputeVolumesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListComputeVolumesRequest](../../Models/Requests/ListComputeVolumesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListComputeVolumesResponse](../../Models/Requests/ListComputeVolumesResponse.md)**

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
        FinishedAt = System.DateTime.Parse("2025-09-03T01:51:06.187Z").ToUniversalTime(),
        Id = "c3b29238-18da-497b-bdb9-79b3b0f96cff",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-14T05:28:00.983Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-03-05T21:22:56.317Z").ToUniversalTime(),
        Url = "https://comfortable-petal.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeDeploymentAsync(req);

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
        Id = "86201de8-17c7-47d0-b68d-3685c6e31da8",
        IsPrimary = false,
        Metadata = new List<ComputeMetadata>() {},
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-07T01:45:21.864Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeDomainAsync(req);

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
        Id = "5fe49bc6-3e5e-464e-a6b8-e7d8e4a90bcb",
        IsSecret = true,
        Metadata = new List<ComputeMetadata>() {},
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-07-08T02:39:10.765Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeEnvvarAsync(req);

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

var res = await sdk.Compute.PatchComputeInstanceAsync(req);

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

## PatchComputeKey

Updates the ComputeKey identified by `id`. Provide the unified ComputeKey fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeKey" method="patch" path="/compute/{connection_id}/key/{id}" example="compute_key" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeKeyRequest req = new PatchComputeKeyRequest() {
    ComputeKey = new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "c8a31667-ab5a-4c6a-ac9e-f30c84269a90",
        Metadata = new List<ComputeMetadata>() {},
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-09T03:02:43.818Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchComputeKeyRequest](../../Models/Requests/PatchComputeKeyRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchComputeKeyResponse](../../Models/Requests/PatchComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeService

Updates the ComputeService identified by `id`. Provide the unified ComputeService fields to change in the request body.

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
        Id = "ea2ab1f5-1765-4151-869a-ec3f6d14644f",
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
        UpdatedAt = System.DateTime.Parse("2025-04-07T15:45:09.887Z").ToUniversalTime(),
        Url = "https://tame-sideboard.rotating-shoulder.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeServiceAsync(req);

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

## PatchComputeTemplate

Updates the ComputeTemplate identified by `id`. Provide the unified ComputeTemplate fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeTemplate" method="patch" path="/compute/{connection_id}/template/{id}" example="compute_template" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeTemplateRequest req = new PatchComputeTemplateRequest() {
    ComputeTemplate = new ComputeTemplate() {
        CpuCount = 4D,
        CreatedAt = System.DateTime.Parse("2023-02-23T03:28:59.864Z").ToUniversalTime(),
        DiskMb = 10240D,
        Dockerfile = @"FROM ubuntu:24.04
        RUN apt-get update",
        GpuCount = 2D,
        GpuModel = ComputeTemplateGpuModel.NvidiaGh200,
        Id = "f7942d80-b3ce-4c78-9312-4895d45d34b5",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-28T22:08:25.259Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-16T00:36:54.795Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeTemplateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchComputeTemplateRequest](../../Models/Requests/PatchComputeTemplateRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchComputeTemplateResponse](../../Models/Requests/PatchComputeTemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeVolume

Updates the ComputeVolume identified by `id`. Provide the unified ComputeVolume fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeVolume" method="patch" path="/compute/{connection_id}/volume/{id}" example="compute_volume" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeVolumeRequest req = new PatchComputeVolumeRequest() {
    ComputeVolume = new ComputeVolume() {
        CreatedAt = System.DateTime.Parse("2022-11-15T15:12:48.055Z").ToUniversalTime(),
        Id = "b1c4581c-89df-4e37-99ea-20632caa5268",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-11T19:17:37.503Z").ToUniversalTime(),
        UsedMb = 524986D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.PatchComputeVolumeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchComputeVolumeRequest](../../Models/Requests/PatchComputeVolumeRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchComputeVolumeResponse](../../Models/Requests/PatchComputeVolumeResponse.md)**

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

var res = await sdk.Compute.RemoveComputeDeploymentAsync(
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

var res = await sdk.Compute.RemoveComputeDomainAsync(
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

var res = await sdk.Compute.RemoveComputeEnvvarAsync(
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

var res = await sdk.Compute.RemoveComputeInstanceAsync(
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

## RemoveComputeKey

Deletes the ComputeKey identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeKey" method="delete" path="/compute/{connection_id}/key/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.RemoveComputeKeyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Key        |

### Response

**[RemoveComputeKeyResponse](../../Models/Requests/RemoveComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeService

Deletes the ComputeService identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeService" method="delete" path="/compute/{connection_id}/service/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.RemoveComputeServiceAsync(
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

## RemoveComputeSnapshot

Deletes the ComputeSnapshot identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeSnapshot" method="delete" path="/compute/{connection_id}/snapshot/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.RemoveComputeSnapshotAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Snapshot   |

### Response

**[RemoveComputeSnapshotResponse](../../Models/Requests/RemoveComputeSnapshotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeTemplate

Deletes the ComputeTemplate identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeTemplate" method="delete" path="/compute/{connection_id}/template/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.RemoveComputeTemplateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Template   |

### Response

**[RemoveComputeTemplateResponse](../../Models/Requests/RemoveComputeTemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeVolume

Deletes the ComputeVolume identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeVolume" method="delete" path="/compute/{connection_id}/volume/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.RemoveComputeVolumeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Volume     |

### Response

**[RemoveComputeVolumeResponse](../../Models/Requests/RemoveComputeVolumeResponse.md)**

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
        FinishedAt = System.DateTime.Parse("2025-09-03T01:51:06.187Z").ToUniversalTime(),
        Id = "c3b29238-18da-497b-bdb9-79b3b0f96cff",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-14T05:28:00.983Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-03-05T21:22:56.317Z").ToUniversalTime(),
        Url = "https://comfortable-petal.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeDeploymentAsync(req);

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
        Id = "86201de8-17c7-47d0-b68d-3685c6e31da8",
        IsPrimary = false,
        Metadata = new List<ComputeMetadata>() {},
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-07T01:45:21.864Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeDomainAsync(req);

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
        Id = "5fe49bc6-3e5e-464e-a6b8-e7d8e4a90bcb",
        IsSecret = true,
        Metadata = new List<ComputeMetadata>() {},
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-07-08T02:39:10.765Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeEnvvarAsync(req);

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

var res = await sdk.Compute.UpdateComputeInstanceAsync(req);

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

## UpdateComputeKey

Updates the ComputeKey identified by `id`. Provide the unified ComputeKey fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeKey" method="put" path="/compute/{connection_id}/key/{id}" example="compute_key" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeKeyRequest req = new UpdateComputeKeyRequest() {
    ComputeKey = new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "c8a31667-ab5a-4c6a-ac9e-f30c84269a90",
        Metadata = new List<ComputeMetadata>() {},
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-09T03:02:43.818Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateComputeKeyRequest](../../Models/Requests/UpdateComputeKeyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateComputeKeyResponse](../../Models/Requests/UpdateComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeService

Updates the ComputeService identified by `id`. Provide the unified ComputeService fields to change in the request body.

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
        Id = "ea2ab1f5-1765-4151-869a-ec3f6d14644f",
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
        UpdatedAt = System.DateTime.Parse("2025-04-07T15:45:09.887Z").ToUniversalTime(),
        Url = "https://tame-sideboard.rotating-shoulder.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeServiceAsync(req);

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

## UpdateComputeTemplate

Updates the ComputeTemplate identified by `id`. Provide the unified ComputeTemplate fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeTemplate" method="put" path="/compute/{connection_id}/template/{id}" example="compute_template" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeTemplateRequest req = new UpdateComputeTemplateRequest() {
    ComputeTemplate = new ComputeTemplate() {
        CpuCount = 4D,
        CreatedAt = System.DateTime.Parse("2023-02-23T03:28:59.864Z").ToUniversalTime(),
        DiskMb = 10240D,
        Dockerfile = @"FROM ubuntu:24.04
        RUN apt-get update",
        GpuCount = 2D,
        GpuModel = ComputeTemplateGpuModel.NvidiaGh200,
        Id = "f7942d80-b3ce-4c78-9312-4895d45d34b5",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-28T22:08:25.259Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-16T00:36:54.795Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeTemplateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateComputeTemplateRequest](../../Models/Requests/UpdateComputeTemplateRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateComputeTemplateResponse](../../Models/Requests/UpdateComputeTemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeVolume

Updates the ComputeVolume identified by `id`. Provide the unified ComputeVolume fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeVolume" method="put" path="/compute/{connection_id}/volume/{id}" example="compute_volume" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeVolumeRequest req = new UpdateComputeVolumeRequest() {
    ComputeVolume = new ComputeVolume() {
        CreatedAt = System.DateTime.Parse("2022-11-15T15:12:48.055Z").ToUniversalTime(),
        Id = "b1c4581c-89df-4e37-99ea-20632caa5268",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-11T19:17:37.503Z").ToUniversalTime(),
        UsedMb = 524986D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Compute.UpdateComputeVolumeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateComputeVolumeRequest](../../Models/Requests/UpdateComputeVolumeRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateComputeVolumeResponse](../../Models/Requests/UpdateComputeVolumeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |