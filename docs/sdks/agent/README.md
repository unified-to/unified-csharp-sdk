# Agent

## Overview

### Available Operations

* [CreateGenaiAgent](#creategenaiagent) - Create an agent
* [GetGenaiAgent](#getgenaiagent) - Retrieve an agent
* [ListGenaiAgents](#listgenaiagents) - List all agents
* [PatchGenaiAgent](#patchgenaiagent) - Update an agent
* [RemoveGenaiAgent](#removegenaiagent) - Remove an agent
* [UpdateGenaiAgent](#updategenaiagent) - Update an agent

## CreateGenaiAgent

Creates a GenaiAgent. Provide the unified GenaiAgent fields in the request body; they are mapped to the provider's API. Returns the created GenaiAgent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiAgent" method="post" path="/genai/{connection_id}/agent" example="genai_agent" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Agent.CreateGenaiAgentAsync(
    genaiAgent: new GenaiAgent() {
        CreatedAt = System.DateTime.Parse("2020-12-18T02:23:33.723Z").ToUniversalTime(),
        Description = "Assentator tero sequi.",
        Id = "57de3093-9715-434d-a94f-8d5dba027e84",
        Instructions = "Delicate tabella addo vita ver auctus corrumpo. Conscendo auctus maiores astrum sulum aufero bis stella. Non varius sto solus admitto vado suggero theatrum.",
        IsActive = false,
        Name = "daughter with",
        UpdatedAt = System.DateTime.Parse("2025-10-18T17:42:22.176Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiAgent`                                                                                                                                     | [GenaiAgent](../../Models/Components/GenaiAgent.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiAgentQueryParamFields](../../Models/Requests/CreateGenaiAgentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiAgentResponse](../../Models/Requests/CreateGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiAgent

Retrieves a single GenaiAgent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiAgent" method="get" path="/genai/{connection_id}/agent/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Agent.GetGenaiAgentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Agent                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetGenaiAgentQueryParamFields](../../Models/Requests/GetGenaiAgentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiAgentResponse](../../Models/Requests/GetGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiAgents

Returns a list of GenaiAgents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiAgents" method="get" path="/genai/{connection_id}/agent" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiAgentsRequest req = new ListGenaiAgentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Agent.ListGenaiAgentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListGenaiAgentsRequest](../../Models/Requests/ListGenaiAgentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListGenaiAgentsResponse](../../Models/Requests/ListGenaiAgentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchGenaiAgent

Updates the GenaiAgent identified by `id`. Provide the unified GenaiAgent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchGenaiAgent" method="patch" path="/genai/{connection_id}/agent/{id}" example="genai_agent" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchGenaiAgentRequest req = new PatchGenaiAgentRequest() {
    GenaiAgent = new GenaiAgent() {
        CreatedAt = System.DateTime.Parse("2020-12-18T02:23:33.723Z").ToUniversalTime(),
        Description = "Assentator tero sequi.",
        Id = "92bfee4a-67a5-48da-90e6-1a07b716bef6",
        Instructions = "Delicate tabella addo vita ver auctus corrumpo. Conscendo auctus maiores astrum sulum aufero bis stella. Non varius sto solus admitto vado suggero theatrum.",
        IsActive = false,
        Name = "daughter with",
        UpdatedAt = System.DateTime.Parse("2025-10-18T17:42:22.186Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Agent.PatchGenaiAgentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchGenaiAgentRequest](../../Models/Requests/PatchGenaiAgentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchGenaiAgentResponse](../../Models/Requests/PatchGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiAgent

Deletes the GenaiAgent identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiAgent" method="delete" path="/genai/{connection_id}/agent/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Agent.RemoveGenaiAgentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Agent      |

### Response

**[RemoveGenaiAgentResponse](../../Models/Requests/RemoveGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateGenaiAgent

Updates the GenaiAgent identified by `id`. Provide the unified GenaiAgent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateGenaiAgent" method="put" path="/genai/{connection_id}/agent/{id}" example="genai_agent" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateGenaiAgentRequest req = new UpdateGenaiAgentRequest() {
    GenaiAgent = new GenaiAgent() {
        CreatedAt = System.DateTime.Parse("2020-12-18T02:23:33.723Z").ToUniversalTime(),
        Description = "Assentator tero sequi.",
        Id = "92bfee4a-67a5-48da-90e6-1a07b716bef6",
        Instructions = "Delicate tabella addo vita ver auctus corrumpo. Conscendo auctus maiores astrum sulum aufero bis stella. Non varius sto solus admitto vado suggero theatrum.",
        IsActive = false,
        Name = "daughter with",
        UpdatedAt = System.DateTime.Parse("2025-10-18T17:42:22.186Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Agent.UpdateGenaiAgentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateGenaiAgentRequest](../../Models/Requests/UpdateGenaiAgentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateGenaiAgentResponse](../../Models/Requests/UpdateGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |