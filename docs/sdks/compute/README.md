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

var res = await sdk.Compute.CreateComputeDeploymentAsync(
    computeDeployment: new ComputeDeployment() {
        Branch = "develop",
        CommitIdentifier = "fadfe54eefd8fea670bea6d58b4b15d406c4b02b",
        CommitMessage = "copy primary pixel",
        CreatedAt = System.DateTime.Parse("2022-06-07T03:52:04.613Z").ToUniversalTime(),
        Environment = UnifiedTo.Models.Components.Environment.Preview,
        FinishedAt = System.DateTime.Parse("2025-08-25T22:51:05.705Z").ToUniversalTime(),
        Id = "d18ab909-f7ca-48b8-b4ec-d40cad4aa4c4",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-07T01:49:49.783Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-24T12:06:23.846Z").ToUniversalTime(),
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

Create a domain

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeDomain" method="post" path="/compute/{connection_id}/domain" example="compute_domain" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.CreateComputeDomainAsync(
    computeDomain: new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "67a33aa3-12ff-4ca6-8efa-cba26c5556a2",
        IsPrimary = false,
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-10-31T18:57:06.636Z").ToUniversalTime(),
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

Create an envvar

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
        Id = "bd9b18ac-9bc8-4794-bee2-64982d5b2da2",
        IsSecret = true,
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-06-29T20:51:27.237Z").ToUniversalTime(),
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

Create an instance

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
        Id = "8f79139c-897a-414f-b5c5-d8756c0deb11",
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
        StartedAt = System.DateTime.Parse("2025-03-20T22:30:22.836Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-12T21:13:25.166Z").ToUniversalTime(),
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

Create a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeKey" method="post" path="/compute/{connection_id}/key" example="compute_key" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Compute.CreateComputeKeyAsync(
    computeKey: new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "5a07b344-049c-4dc8-85ca-8e29f1ea114e",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T04:36:32.102Z").ToUniversalTime(),
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

var res = await sdk.Compute.CreateComputeServiceAsync(
    computeService: new ComputeService() {
        Branch = "main",
        BuildCommand = "npm run build",
        CreatedAt = System.DateTime.Parse("2023-10-04T02:06:29.391Z").ToUniversalTime(),
        Id = "ec585267-2366-41af-a234-bb893c4bb540",
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
        UpdatedAt = System.DateTime.Parse("2025-04-02T05:36:50.633Z").ToUniversalTime(),
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

Create a snapshot

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
        Id = "d5087b77-b99c-423a-ba2b-adefcebe029e",
        Metadata = new List<ComputeMetadata>() {},
        Name = "snap-alius",
        SizeMb = 169984D,
        Status = ComputeSnapshotStatus.Deleting,
        Type = ComputeSnapshotType.Disk,
        UpdatedAt = System.DateTime.Parse("2026-03-26T11:05:54.684Z").ToUniversalTime(),
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

Create a template

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
        Id = "fd9fba1a-91a2-4387-8a3f-63a9634dc389",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-19T15:51:54.914Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-10T02:11:50.084Z").ToUniversalTime(),
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

Create a volume

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
        Id = "daf6adc4-6d8e-4a05-9405-34d403b2267d",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T08:17:28.956Z").ToUniversalTime(),
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

Retrieve a deployment

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

Retrieve a domain

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

Retrieve an envvar

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

Retrieve a gputype

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

Retrieve an instance

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

Retrieve a key

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

Retrieve a region

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

Retrieve a service

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

Retrieve a snapshot

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

Retrieve a template

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

Retrieve a volume

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

List all domains

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

List all envvars

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

List all gputypes

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

List all instances

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

List all keys

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

List all regions

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

List all snapshots

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

List all templates

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

List all usages

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

List all volumes

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
        FinishedAt = System.DateTime.Parse("2025-08-25T22:51:05.720Z").ToUniversalTime(),
        Id = "76d14581-00b2-4f08-b760-0d68905ceaf8",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-07T01:49:49.796Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-24T12:06:23.863Z").ToUniversalTime(),
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

Update a domain

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeDomain" method="patch" path="/compute/{connection_id}/domain/{id}" example="compute_domain" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeDomainRequest req = new PatchComputeDomainRequest() {
    ComputeDomain = new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "09687682-9919-451f-af76-8995497a47dc",
        IsPrimary = false,
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-10-31T18:57:06.641Z").ToUniversalTime(),
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

Update an envvar

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
        Id = "efd74e44-baa5-4664-bdf4-560e0f1f0c9a",
        IsSecret = true,
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-06-29T20:51:27.243Z").ToUniversalTime(),
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

Update an instance

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
        Id = "9fe4acd5-73e8-4f28-9893-21ac14a5602e",
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
        StartedAt = System.DateTime.Parse("2025-03-20T22:30:22.863Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-12T21:13:25.195Z").ToUniversalTime(),
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

Update a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeKey" method="patch" path="/compute/{connection_id}/key/{id}" example="compute_key" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeKeyRequest req = new PatchComputeKeyRequest() {
    ComputeKey = new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "afea9d64-045e-4466-bb67-9e5016ad12c8",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T04:36:32.107Z").ToUniversalTime(),
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
        Id = "5236e363-6e25-46e8-ad54-c0e9809e530e",
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
        UpdatedAt = System.DateTime.Parse("2025-04-02T05:36:50.646Z").ToUniversalTime(),
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

Update a template

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
        Id = "17c5b9cd-a507-4f10-a5ee-74fe251a030b",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-19T15:51:54.932Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-10T02:11:50.094Z").ToUniversalTime(),
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

Update a volume

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
        Id = "20ef0065-46a1-499d-908b-037cb07be73a",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T08:17:28.964Z").ToUniversalTime(),
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

Remove a deployment

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

Remove a domain

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

Remove an envvar

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

Remove an instance

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

Remove a key

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

Remove a service

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

Remove a snapshot

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

Remove a template

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

Remove a volume

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
        FinishedAt = System.DateTime.Parse("2025-08-25T22:51:05.720Z").ToUniversalTime(),
        Id = "76d14581-00b2-4f08-b760-0d68905ceaf8",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-07T01:49:49.796Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-24T12:06:23.863Z").ToUniversalTime(),
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

Update a domain

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeDomain" method="put" path="/compute/{connection_id}/domain/{id}" example="compute_domain" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeDomainRequest req = new UpdateComputeDomainRequest() {
    ComputeDomain = new ComputeDomain() {
        CreatedAt = System.DateTime.Parse("2019-11-22T16:38:26.009Z").ToUniversalTime(),
        Id = "09687682-9919-451f-af76-8995497a47dc",
        IsPrimary = false,
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-10-31T18:57:06.641Z").ToUniversalTime(),
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

Update an envvar

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
        Id = "efd74e44-baa5-4664-bdf4-560e0f1f0c9a",
        IsSecret = true,
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-06-29T20:51:27.243Z").ToUniversalTime(),
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

Update an instance

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
        Id = "9fe4acd5-73e8-4f28-9893-21ac14a5602e",
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
        StartedAt = System.DateTime.Parse("2025-03-20T22:30:22.863Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-12T21:13:25.195Z").ToUniversalTime(),
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

Update a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeKey" method="put" path="/compute/{connection_id}/key/{id}" example="compute_key" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeKeyRequest req = new UpdateComputeKeyRequest() {
    ComputeKey = new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "afea9d64-045e-4466-bb67-9e5016ad12c8",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T04:36:32.107Z").ToUniversalTime(),
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
        Id = "5236e363-6e25-46e8-ad54-c0e9809e530e",
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
        UpdatedAt = System.DateTime.Parse("2025-04-02T05:36:50.646Z").ToUniversalTime(),
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

Update a template

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
        Id = "17c5b9cd-a507-4f10-a5ee-74fe251a030b",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-19T15:51:54.932Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-10T02:11:50.094Z").ToUniversalTime(),
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

Update a volume

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
        Id = "20ef0065-46a1-499d-908b-037cb07be73a",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T08:17:28.964Z").ToUniversalTime(),
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