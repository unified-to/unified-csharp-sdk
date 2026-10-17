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
        FinishedAt = System.DateTime.Parse("2025-08-26T16:40:57.572Z").ToUniversalTime(),
        Id = "88bfdf78-69f1-47d0-801c-e2585d5fd6ad",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-07T17:31:30.584Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-25T08:42:22.087Z").ToUniversalTime(),
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
        Id = "bf8bf7e3-df45-4f5f-a553-0b4b3fc43fd0",
        IsPrimary = false,
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-01T08:44:29.707Z").ToUniversalTime(),
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
        Id = "d1ec446d-b11f-4c10-9ba5-7aa169489434",
        IsSecret = true,
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-06-30T14:56:39.285Z").ToUniversalTime(),
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
        Id = "ffa4b0f6-1e19-4c50-86af-24b69978e665",
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
        StartedAt = System.DateTime.Parse("2025-03-21T13:12:56.538Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-13T13:18:43.769Z").ToUniversalTime(),
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
        Id = "1fdc2d5d-ee3b-4331-883b-c0630f2aef1c",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T13:14:39.578Z").ToUniversalTime(),
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
        Id = "fbb7c2bc-b670-4804-9d29-24849114dba9",
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
        UpdatedAt = System.DateTime.Parse("2025-04-02T17:30:50.839Z").ToUniversalTime(),
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
        Id = "8985a683-fa9f-49d8-a071-2e67924da9e2",
        Metadata = new List<ComputeMetadata>() {},
        Name = "snap-alius",
        SizeMb = 169984D,
        Status = ComputeSnapshotStatus.Deleting,
        Type = ComputeSnapshotType.Disk,
        UpdatedAt = System.DateTime.Parse("2026-03-27T08:34:45.674Z").ToUniversalTime(),
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
        Id = "3490a54a-ca77-4b04-b7d9-c1aa5a676be0",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-20T12:11:25.392Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-10T15:13:12.489Z").ToUniversalTime(),
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
        Id = "2f6a1e11-3313-456e-9e83-807eb93c3908",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T15:52:52.417Z").ToUniversalTime(),
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
        FinishedAt = System.DateTime.Parse("2025-08-26T16:40:57.589Z").ToUniversalTime(),
        Id = "54283388-8dc2-457b-b05e-5da5842a10ee",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-07T17:31:30.599Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-25T08:42:22.107Z").ToUniversalTime(),
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
        Id = "91d5c22a-adce-4aaa-9b2a-a740d99426aa",
        IsPrimary = false,
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-01T08:44:29.712Z").ToUniversalTime(),
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
        Id = "f0962f80-2175-4ac7-b37a-c35fc79ff4ca",
        IsSecret = true,
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-06-30T14:56:39.291Z").ToUniversalTime(),
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
        Id = "02ede4e6-3ff9-45bc-8357-8cebcc365250",
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
        StartedAt = System.DateTime.Parse("2025-03-21T13:12:56.567Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-13T13:18:43.800Z").ToUniversalTime(),
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
        Id = "6b9b513e-2251-485d-913c-82c037d5309f",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T13:14:39.582Z").ToUniversalTime(),
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
        Id = "f2b03c8d-68b8-4b6f-b72f-77094f7f5de0",
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
        UpdatedAt = System.DateTime.Parse("2025-04-02T17:30:50.850Z").ToUniversalTime(),
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
        Id = "ec9575f1-7e5e-4afd-b879-824fd0e5d877",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-20T12:11:25.416Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-10T15:13:12.505Z").ToUniversalTime(),
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
        Id = "ee9a1fc1-cc73-4628-a6e4-4107c72bdc99",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T15:52:52.423Z").ToUniversalTime(),
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
        FinishedAt = System.DateTime.Parse("2025-08-26T16:40:57.589Z").ToUniversalTime(),
        Id = "54283388-8dc2-457b-b05e-5da5842a10ee",
        Metadata = new List<ComputeMetadata>() {},
        StartedAt = System.DateTime.Parse("2025-04-07T17:31:30.599Z").ToUniversalTime(),
        Status = ComputeDeploymentStatus.Live,
        Trigger = Trigger.Api,
        UpdatedAt = System.DateTime.Parse("2026-02-25T08:42:22.107Z").ToUniversalTime(),
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
        Id = "91d5c22a-adce-4aaa-9b2a-a740d99426aa",
        IsPrimary = false,
        Name = "mysterious-republican.usable-section.info",
        Status = ComputeDomainStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-11-01T08:44:29.712Z").ToUniversalTime(),
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
        Id = "f0962f80-2175-4ac7-b37a-c35fc79ff4ca",
        IsSecret = true,
        Name = "AEGER_SUBSTANTIA",
        UpdatedAt = System.DateTime.Parse("2025-06-30T14:56:39.291Z").ToUniversalTime(),
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
        Id = "02ede4e6-3ff9-45bc-8357-8cebcc365250",
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
        StartedAt = System.DateTime.Parse("2025-03-21T13:12:56.567Z").ToUniversalTime(),
        Status = ComputeInstanceStatus.Error,
        StatusReason = "Sponte quasi adversus alioqui reiciendis arca carmen canis.",
        Type = ComputeInstanceType.Baremetal,
        UpdatedAt = System.DateTime.Parse("2025-06-13T13:18:43.800Z").ToUniversalTime(),
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
        Id = "6b9b513e-2251-485d-913c-82c037d5309f",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T13:14:39.582Z").ToUniversalTime(),
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
        Id = "f2b03c8d-68b8-4b6f-b72f-77094f7f5de0",
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
        UpdatedAt = System.DateTime.Parse("2025-04-02T17:30:50.850Z").ToUniversalTime(),
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
        Id = "ec9575f1-7e5e-4afd-b879-824fd0e5d877",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-20T12:11:25.416Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-10T15:13:12.505Z").ToUniversalTime(),
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
        Id = "ee9a1fc1-cc73-4628-a6e4-4107c72bdc99",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T15:52:52.423Z").ToUniversalTime(),
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