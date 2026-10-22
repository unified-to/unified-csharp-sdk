# Pipeline

## Overview

### Available Operations

* [CreateCrmPipeline](#createcrmpipeline) - Create a pipeline
* [GetCrmPipeline](#getcrmpipeline) - Retrieve a pipeline
* [ListCrmPipelines](#listcrmpipelines) - List all pipelines
* [PatchCrmPipeline](#patchcrmpipeline) - Update a pipeline
* [RemoveCrmPipeline](#removecrmpipeline) - Remove a pipeline
* [UpdateCrmPipeline](#updatecrmpipeline) - Update a pipeline

## CreateCrmPipeline

Creates a CrmPipeline. Provide the unified CrmPipeline fields in the request body; they are mapped to the provider's API. Returns the created CrmPipeline.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmPipeline" method="post" path="/crm/{connection_id}/pipeline" example="crm_pipeline" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pipeline.CreateCrmPipelineAsync(
    crmPipeline: new CrmPipeline() {
        CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
        DealProbability = 99D,
        DisplayOrder = 8D,
        Id = "10591808-59c1-4e3a-a5d6-4e3342e22d0b",
        IsActive = true,
        Metadata = new List<CrmMetadata>() {},
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "656770a4-f402-4d92-b17d-673ac784f505",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-11T04:27:55.653Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-11-01T22:14:45.106Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmPipeline`                                                                                                                                    | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmPipelineQueryParamFields](../../Models/Requests/CreateCrmPipelineQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmPipelineResponse](../../Models/Requests/CreateCrmPipelineResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmPipeline

Retrieves a single CrmPipeline by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmPipeline" method="get" path="/crm/{connection_id}/pipeline/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pipeline.GetCrmPipelineAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Pipeline                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetCrmPipelineQueryParamFields](../../Models/Requests/GetCrmPipelineQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmPipelineResponse](../../Models/Requests/GetCrmPipelineResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmPipelines

Returns a list of CrmPipelines. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmPipelines" method="get" path="/crm/{connection_id}/pipeline" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmPipelinesRequest req = new ListCrmPipelinesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Pipeline.ListCrmPipelinesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListCrmPipelinesRequest](../../Models/Requests/ListCrmPipelinesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListCrmPipelinesResponse](../../Models/Requests/ListCrmPipelinesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmPipeline

Updates the CrmPipeline identified by `id`. Provide the unified CrmPipeline fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmPipeline" method="patch" path="/crm/{connection_id}/pipeline/{id}" example="crm_pipeline" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmPipelineRequest req = new PatchCrmPipelineRequest() {
    CrmPipeline = new CrmPipeline() {
        CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
        DealProbability = 99D,
        DisplayOrder = 8D,
        Id = "33ab3e86-cb90-496d-8f33-72c34af17e83",
        IsActive = true,
        Metadata = new List<CrmMetadata>() {},
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "bcf35b65-992d-4396-bbbc-f4ad0fc0c2d0",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-11T04:27:55.659Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-11-01T22:14:45.113Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Pipeline.PatchCrmPipelineAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchCrmPipelineRequest](../../Models/Requests/PatchCrmPipelineRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchCrmPipelineResponse](../../Models/Requests/PatchCrmPipelineResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmPipeline

Deletes the CrmPipeline identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmPipeline" method="delete" path="/crm/{connection_id}/pipeline/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pipeline.RemoveCrmPipelineAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Pipeline   |

### Response

**[RemoveCrmPipelineResponse](../../Models/Requests/RemoveCrmPipelineResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmPipeline

Updates the CrmPipeline identified by `id`. Provide the unified CrmPipeline fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmPipeline" method="put" path="/crm/{connection_id}/pipeline/{id}" example="crm_pipeline" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmPipelineRequest req = new UpdateCrmPipelineRequest() {
    CrmPipeline = new CrmPipeline() {
        CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
        DealProbability = 99D,
        DisplayOrder = 8D,
        Id = "33ab3e86-cb90-496d-8f33-72c34af17e83",
        IsActive = true,
        Metadata = new List<CrmMetadata>() {},
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "bcf35b65-992d-4396-bbbc-f4ad0fc0c2d0",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-11T04:27:55.659Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-11-01T22:14:45.113Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Pipeline.UpdateCrmPipelineAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateCrmPipelineRequest](../../Models/Requests/UpdateCrmPipelineRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateCrmPipelineResponse](../../Models/Requests/UpdateCrmPipelineResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |