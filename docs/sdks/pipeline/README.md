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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Pipeline.CreateCrmPipelineAsync(
    security: new CreateCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.CreateCrmPipelineSecurity](../../Models/Requests/CreateCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `CrmPipeline`                                                                                             | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[CreateCrmPipelineResponse](../../Models/Requests/CreateCrmPipelineResponse.md)**


## GetCrmPipeline

Retrieve a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Pipeline.GetCrmPipelineAsync(
    security: new GetCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.GetCrmPipelineSecurity](../../Models/Requests/GetCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Pipeline                                                                                  |
| `Fields`                                                                                            | List<*string*>                                                                                      | :heavy_minus_sign:                                                                                  | Comma-delimited fields to return                                                                    |


### Response

**[GetCrmPipelineResponse](../../Models/Requests/GetCrmPipelineResponse.md)**


## ListCrmPipelines

List all pipelines

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmPipelinesRequest req = new ListCrmPipelinesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Pipeline.ListCrmPipelinesAsync(
    security: new ListCrmPipelinesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListCrmPipelinesRequest](../../Models/Requests/ListCrmPipelinesRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListCrmPipelinesSecurity](../../Models/Requests/ListCrmPipelinesSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListCrmPipelinesResponse](../../Models/Requests/ListCrmPipelinesResponse.md)**


## PatchCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Pipeline.PatchCrmPipelineAsync(
    security: new PatchCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.PatchCrmPipelineSecurity](../../Models/Requests/PatchCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Pipeline                                                                                      |
| `CrmPipeline`                                                                                           | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                   | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |


### Response

**[PatchCrmPipelineResponse](../../Models/Requests/PatchCrmPipelineResponse.md)**


## RemoveCrmPipeline

Remove a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Pipeline.RemoveCrmPipelineAsync(
    security: new RemoveCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.RemoveCrmPipelineSecurity](../../Models/Requests/RemoveCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Pipeline                                                                                        |


### Response

**[RemoveCrmPipelineResponse](../../Models/Requests/RemoveCrmPipelineResponse.md)**


## UpdateCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Pipeline.UpdateCrmPipelineAsync(
    security: new UpdateCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.UpdateCrmPipelineSecurity](../../Models/Requests/UpdateCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Pipeline                                                                                        |
| `CrmPipeline`                                                                                             | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[UpdateCrmPipelineResponse](../../Models/Requests/UpdateCrmPipelineResponse.md)**

