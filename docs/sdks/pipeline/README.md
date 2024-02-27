# Pipeline
(*Pipeline*)

### Available Operations

* [CreateCrmPipeline](#createcrmpipeline) - Create a pipeline
* [GetCrmPipeline](#getcrmpipeline) - Retrieve a pipeline
* [ListCrmPipelines](#listcrmpipelines) - List all pipelines
* [PatchCrmPipeline](#patchcrmpipeline) - Update a pipeline
* [RemoveCrmPipeline](#removecrmpipeline) - Remove a pipeline
* [UpdateCrmPipeline](#updatecrmpipeline) - Update a pipeline

## CreateCrmPipeline

Create a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Pipeline.CreateCrmPipelineAsync(
    connectionId: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreateCrmPipelineResponse](../../Models/Requests/CreateCrmPipelineResponse.md)**


## GetCrmPipeline

Retrieve a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Pipeline.GetCrmPipelineAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Pipeline               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmPipelineResponse](../../Models/Requests/GetCrmPipelineResponse.md)**


## ListCrmPipelines

List all pipelines

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmPipelinesRequest req = new ListCrmPipelinesRequest() {
    ConnectionId = "<value>",
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


## PatchCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Pipeline.PatchCrmPipelineAsync(
    connectionId: "<value>",
    id: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Pipeline                                    |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchCrmPipelineResponse](../../Models/Requests/PatchCrmPipelineResponse.md)**


## RemoveCrmPipeline

Remove a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Pipeline.RemoveCrmPipelineAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Pipeline   |


### Response

**[RemoveCrmPipelineResponse](../../Models/Requests/RemoveCrmPipelineResponse.md)**


## UpdateCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Pipeline.UpdateCrmPipelineAsync(
    connectionId: "<value>",
    id: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Pipeline                                    |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdateCrmPipelineResponse](../../Models/Requests/UpdateCrmPipelineResponse.md)**

