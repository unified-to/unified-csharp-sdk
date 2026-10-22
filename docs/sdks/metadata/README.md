# Metadata

## Overview

### Available Operations

* [CreateMetadataMetadata](#createmetadatametadata) - Create a metadata
* [GetMetadataMetadata](#getmetadatametadata) - Retrieve a metadata
* [ListMetadataMetadatas](#listmetadatametadatas) - List all metadatas
* [PatchMetadataMetadata](#patchmetadatametadata) - Update a metadata
* [RemoveMetadataMetadata](#removemetadatametadata) - Remove a metadata
* [UpdateMetadataMetadata](#updatemetadatametadata) - Update a metadata

## CreateMetadataMetadata

Creates a MetadataMetadata. Provide the unified MetadataMetadata fields in the request body; they are mapped to the provider's API. Returns the created MetadataMetadata.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMetadataMetadata" method="post" path="/metadata/{connection_id}/metadata" example="metadata_metadata" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.CreateMetadataMetadataAsync(
    metadataMetadata: new MetadataMetadata() {
        CreatedAt = System.DateTime.Parse("2021-03-25T03:02:17.656Z").ToUniversalTime(),
        Format = MetadataMetadataFormat.Price,
        Id = "f9725264-5936-452d-b24e-9be74f31e263",
        IsRequired = false,
        Name = "autem",
        ObjectType = "social_review",
        Objects = new Dictionary<string, string>() {

        },
        Options = new List<string>() {},
        OriginalFormat = "advoco",
        Slug = "arbustum",
        UpdatedAt = System.DateTime.Parse("2025-03-22T14:52:15.769Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MetadataMetadata`                                                                                                                               | [MetadataMetadata](../../Models/Components/MetadataMetadata.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMetadataMetadataQueryParamFields](../../Models/Requests/CreateMetadataMetadataQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMetadataMetadataResponse](../../Models/Requests/CreateMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMetadataMetadata

Retrieves a single MetadataMetadata by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMetadataMetadata" method="get" path="/metadata/{connection_id}/metadata/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.GetMetadataMetadataAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Metadata                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetMetadataMetadataQueryParamFields](../../Models/Requests/GetMetadataMetadataQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMetadataMetadataResponse](../../Models/Requests/GetMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMetadataMetadatas

Returns a list of MetadataMetadatas. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMetadataMetadatas" method="get" path="/metadata/{connection_id}/metadata" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMetadataMetadatasRequest req = new ListMetadataMetadatasRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Metadata.ListMetadataMetadatasAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListMetadataMetadatasRequest](../../Models/Requests/ListMetadataMetadatasRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListMetadataMetadatasResponse](../../Models/Requests/ListMetadataMetadatasResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMetadataMetadata

Updates the MetadataMetadata identified by `id`. Provide the unified MetadataMetadata fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMetadataMetadata" method="patch" path="/metadata/{connection_id}/metadata/{id}" example="metadata_metadata" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMetadataMetadataRequest req = new PatchMetadataMetadataRequest() {
    MetadataMetadata = new MetadataMetadata() {
        CreatedAt = System.DateTime.Parse("2021-03-25T03:02:17.656Z").ToUniversalTime(),
        Format = MetadataMetadataFormat.Price,
        Id = "c9497d49-de74-45bd-a62e-267efddff071",
        IsRequired = false,
        Name = "autem",
        ObjectType = "social_review",
        Objects = new Dictionary<string, string>() {

        },
        Options = new List<string>() {},
        OriginalFormat = "advoco",
        Slug = "arbustum",
        UpdatedAt = System.DateTime.Parse("2025-03-22T14:52:15.775Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Metadata.PatchMetadataMetadataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchMetadataMetadataRequest](../../Models/Requests/PatchMetadataMetadataRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchMetadataMetadataResponse](../../Models/Requests/PatchMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMetadataMetadata

Deletes the MetadataMetadata identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMetadataMetadata" method="delete" path="/metadata/{connection_id}/metadata/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.RemoveMetadataMetadataAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Metadata   |

### Response

**[RemoveMetadataMetadataResponse](../../Models/Requests/RemoveMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMetadataMetadata

Updates the MetadataMetadata identified by `id`. Provide the unified MetadataMetadata fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMetadataMetadata" method="put" path="/metadata/{connection_id}/metadata/{id}" example="metadata_metadata" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMetadataMetadataRequest req = new UpdateMetadataMetadataRequest() {
    MetadataMetadata = new MetadataMetadata() {
        CreatedAt = System.DateTime.Parse("2021-03-25T03:02:17.656Z").ToUniversalTime(),
        Format = MetadataMetadataFormat.Price,
        Id = "c9497d49-de74-45bd-a62e-267efddff071",
        IsRequired = false,
        Name = "autem",
        ObjectType = "social_review",
        Objects = new Dictionary<string, string>() {

        },
        Options = new List<string>() {},
        OriginalFormat = "advoco",
        Slug = "arbustum",
        UpdatedAt = System.DateTime.Parse("2025-03-22T14:52:15.775Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Metadata.UpdateMetadataMetadataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateMetadataMetadataRequest](../../Models/Requests/UpdateMetadataMetadataRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateMetadataMetadataResponse](../../Models/Requests/UpdateMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |