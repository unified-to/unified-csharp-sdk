# Template

## Overview

### Available Operations

* [CreateComputeTemplate](#createcomputetemplate) - Create a template
* [GetComputeTemplate](#getcomputetemplate) - Retrieve a template
* [GetSigningTemplate](#getsigningtemplate) - Retrieve a template
* [ListComputeTemplates](#listcomputetemplates) - List all templates
* [ListSigningTemplates](#listsigningtemplates) - List all templates
* [PatchComputeTemplate](#patchcomputetemplate) - Update a template
* [RemoveComputeTemplate](#removecomputetemplate) - Remove a template
* [UpdateComputeTemplate](#updatecomputetemplate) - Update a template

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

var res = await sdk.Template.CreateComputeTemplateAsync(
    computeTemplate: new ComputeTemplate() {
        CpuCount = 4D,
        CreatedAt = System.DateTime.Parse("2023-02-23T03:28:59.864Z").ToUniversalTime(),
        DiskMb = 10240D,
        Dockerfile = @"FROM ubuntu:24.04
        RUN apt-get update",
        GpuCount = 2D,
        GpuModel = ComputeTemplateGpuModel.NvidiaGh200,
        Id = "f6f36ea5-8966-4092-8c75-5c8411d767e0",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-24T14:53:14.008Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-13T06:27:28.825Z").ToUniversalTime(),
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

var res = await sdk.Template.GetComputeTemplateAsync(
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

## GetSigningTemplate

Retrieves a single SigningTemplate by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSigningTemplate" method="get" path="/signing/{connection_id}/template/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Template.GetSigningTemplateAsync(
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
| `Fields`                                                                                                                                         | List<[GetSigningTemplateQueryParamFields](../../Models/Requests/GetSigningTemplateQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSigningTemplateResponse](../../Models/Requests/GetSigningTemplateResponse.md)**

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

var res = await sdk.Template.ListComputeTemplatesAsync(req);

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

## ListSigningTemplates

Returns a list of SigningTemplates. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSigningTemplates" method="get" path="/signing/{connection_id}/template" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSigningTemplatesRequest req = new ListSigningTemplatesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Template.ListSigningTemplatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListSigningTemplatesRequest](../../Models/Requests/ListSigningTemplatesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListSigningTemplatesResponse](../../Models/Requests/ListSigningTemplatesResponse.md)**

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
        Id = "84b24b1c-67b4-41e2-bf47-ce745df66bc8",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-24T14:53:14.024Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-13T06:27:28.835Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Template.PatchComputeTemplateAsync(req);

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

var res = await sdk.Template.RemoveComputeTemplateAsync(
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
        Id = "84b24b1c-67b4-41e2-bf47-ce745df66bc8",
        Image = "perfumed-molasses/cohibeo:5.2",
        IsPublic = false,
        LastUsedAt = System.DateTime.Parse("2026-03-24T14:53:14.024Z").ToUniversalTime(),
        MemoryMb = 8192D,
        Metadata = new List<ComputeMetadata>() {},
        Name = "multi-byte-card",
        Ports = new List<double>() {
            8080D,
        },
        Status = ComputeTemplateStatus.Other,
        UpdatedAt = System.DateTime.Parse("2025-02-13T06:27:28.835Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Template.UpdateComputeTemplateAsync(req);

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