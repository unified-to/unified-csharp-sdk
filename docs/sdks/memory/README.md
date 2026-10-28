# Memory

## Overview

### Available Operations

* [CreateGenaiMemory](#creategenaimemory) - Create a memory
* [GetGenaiMemory](#getgenaimemory) - Retrieve a memory
* [ListGenaiMemories](#listgenaimemories) - List all memories
* [PatchGenaiMemory](#patchgenaimemory) - Update a memory
* [RemoveGenaiMemory](#removegenaimemory) - Remove a memory
* [UpdateGenaiMemory](#updategenaimemory) - Update a memory

## CreateGenaiMemory

Creates a GenaiMemory. Provide the unified GenaiMemory fields in the request body; they are mapped to the provider's API. Returns the created GenaiMemory.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiMemory" method="post" path="/genai/{connection_id}/memory" example="genai_memory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Memory.CreateGenaiMemoryAsync(
    genaiMemory: new GenaiMemory() {
        Content = "Tabella rem approbo spiculum deserunt comitatus despecto. Aveho utroque accedo vinitor repellendus tam curis corona eos vobis. Ullus ager degero deporto cicuta vulgivagus.",
        CreatedAt = System.DateTime.Parse("2021-10-22T04:14:41.668Z").ToUniversalTime(),
        Id = "e63ef9cd-686b-4225-a823-a2c256d0d61c",
        Metadata = new List<GenaiMetadata>() {
            new GenaiMetadata() {
                ExtraData = GenaiMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = GenaiMetadataFormat.Text,
                Id = "7a8ad62d-ba0e-4ce3-8330-56a2647b5b3e",
                Namespace = "memory",
                Slug = "cribro",
                Value = GenaiMetadataValue.CreateStr(
                    "aiunt"
                ),
            },
        },
        Name = "sponte.md",
        Type = GenaiMemoryType.Memory,
        UpdatedAt = System.DateTime.Parse("2023-04-28T00:20:27.275Z").ToUniversalTime(),
        UserIdentifier = "9d170613-4338-447d-bdb6-8ea96a2d7513",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiMemory`                                                                                                                                    | [GenaiMemory](../../Models/Components/GenaiMemory.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiMemoryQueryParamFields](../../Models/Requests/CreateGenaiMemoryQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiMemoryResponse](../../Models/Requests/CreateGenaiMemoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiMemory

Retrieves a single GenaiMemory by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiMemory" method="get" path="/genai/{connection_id}/memory/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Memory.GetGenaiMemoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Memory                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetGenaiMemoryQueryParamFields](../../Models/Requests/GetGenaiMemoryQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiMemoryResponse](../../Models/Requests/GetGenaiMemoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiMemories

Returns a list of GenaiMemories. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiMemories" method="get" path="/genai/{connection_id}/memory" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiMemoriesRequest req = new ListGenaiMemoriesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Memory.ListGenaiMemoriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListGenaiMemoriesRequest](../../Models/Requests/ListGenaiMemoriesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListGenaiMemoriesResponse](../../Models/Requests/ListGenaiMemoriesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchGenaiMemory

Updates the GenaiMemory identified by `id`. Provide the unified GenaiMemory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchGenaiMemory" method="patch" path="/genai/{connection_id}/memory/{id}" example="genai_memory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchGenaiMemoryRequest req = new PatchGenaiMemoryRequest() {
    GenaiMemory = new GenaiMemory() {
        Content = "Tabella rem approbo spiculum deserunt comitatus despecto. Aveho utroque accedo vinitor repellendus tam curis corona eos vobis. Ullus ager degero deporto cicuta vulgivagus.",
        CreatedAt = System.DateTime.Parse("2021-10-22T04:14:41.668Z").ToUniversalTime(),
        Id = "db6c88eb-60a2-4d56-a433-48e66b8cb1e2",
        Metadata = new List<GenaiMetadata>() {
            new GenaiMetadata() {
                ExtraData = GenaiMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = GenaiMetadataFormat.Text,
                Id = "7a8ad62d-ba0e-4ce3-8330-56a2647b5b3e",
                Namespace = "memory",
                Slug = "cribro",
                Value = GenaiMetadataValue.CreateStr(
                    "aiunt"
                ),
            },
        },
        Name = "sponte.md",
        Type = GenaiMemoryType.Memory,
        UpdatedAt = System.DateTime.Parse("2023-04-28T00:20:27.280Z").ToUniversalTime(),
        UserIdentifier = "9d170613-4338-447d-bdb6-8ea96a2d7513",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Memory.PatchGenaiMemoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchGenaiMemoryRequest](../../Models/Requests/PatchGenaiMemoryRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchGenaiMemoryResponse](../../Models/Requests/PatchGenaiMemoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiMemory

Deletes the GenaiMemory identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiMemory" method="delete" path="/genai/{connection_id}/memory/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Memory.RemoveGenaiMemoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Memory     |

### Response

**[RemoveGenaiMemoryResponse](../../Models/Requests/RemoveGenaiMemoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateGenaiMemory

Updates the GenaiMemory identified by `id`. Provide the unified GenaiMemory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateGenaiMemory" method="put" path="/genai/{connection_id}/memory/{id}" example="genai_memory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateGenaiMemoryRequest req = new UpdateGenaiMemoryRequest() {
    GenaiMemory = new GenaiMemory() {
        Content = "Tabella rem approbo spiculum deserunt comitatus despecto. Aveho utroque accedo vinitor repellendus tam curis corona eos vobis. Ullus ager degero deporto cicuta vulgivagus.",
        CreatedAt = System.DateTime.Parse("2021-10-22T04:14:41.668Z").ToUniversalTime(),
        Id = "db6c88eb-60a2-4d56-a433-48e66b8cb1e2",
        Metadata = new List<GenaiMetadata>() {
            new GenaiMetadata() {
                ExtraData = GenaiMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = GenaiMetadataFormat.Text,
                Id = "7a8ad62d-ba0e-4ce3-8330-56a2647b5b3e",
                Namespace = "memory",
                Slug = "cribro",
                Value = GenaiMetadataValue.CreateStr(
                    "aiunt"
                ),
            },
        },
        Name = "sponte.md",
        Type = GenaiMemoryType.Memory,
        UpdatedAt = System.DateTime.Parse("2023-04-28T00:20:27.280Z").ToUniversalTime(),
        UserIdentifier = "9d170613-4338-447d-bdb6-8ea96a2d7513",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Memory.UpdateGenaiMemoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateGenaiMemoryRequest](../../Models/Requests/UpdateGenaiMemoryRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateGenaiMemoryResponse](../../Models/Requests/UpdateGenaiMemoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |