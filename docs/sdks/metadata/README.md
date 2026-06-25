# Metadata
(*Metadata*)

## Overview

### Available Operations

* [CreateMetadataMetadata2](#createmetadatametadata2) - Create a metadata
* [GetMetadataMetadata2](#getmetadatametadata2) - Retrieve a metadata
* [ListMetadataMetadatas2](#listmetadatametadatas2) - List all metadatas
* [PatchMetadataMetadata2](#patchmetadatametadata2) - Update a metadata
* [RemoveMetadataMetadata2](#removemetadatametadata2) - Remove a metadata
* [UpdateMetadataMetadata2](#updatemetadatametadata2) - Update a metadata

## CreateMetadataMetadata2

Create a metadata

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.CreateMetadataMetadata2Async(
    metadataMetadata: new MetadataMetadata() {
        Name = "<value>",
        ObjectType = "<value>",
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
| `Fields`                                                                                                                                         | List<[CreateMetadataMetadata2QueryParamFields](../../Models/Requests/CreateMetadataMetadata2QueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMetadataMetadata2Response](../../Models/Requests/CreateMetadataMetadata2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMetadataMetadata2

Retrieve a metadata

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.GetMetadataMetadata2Async(
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
| `Fields`                                                                                                                                         | List<[GetMetadataMetadata2QueryParamFields](../../Models/Requests/GetMetadataMetadata2QueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMetadataMetadata2Response](../../Models/Requests/GetMetadataMetadata2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMetadataMetadatas2

List all metadatas

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMetadataMetadatas2Request req = new ListMetadataMetadatas2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Metadata.ListMetadataMetadatas2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListMetadataMetadatas2Request](../../Models/Requests/ListMetadataMetadatas2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListMetadataMetadatas2Response](../../Models/Requests/ListMetadataMetadatas2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMetadataMetadata2

Update a metadata

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMetadataMetadata2Request req = new PatchMetadataMetadata2Request() {
    MetadataMetadata = new MetadataMetadata() {
        Name = "<value>",
        ObjectType = "<value>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Metadata.PatchMetadataMetadata2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchMetadataMetadata2Request](../../Models/Requests/PatchMetadataMetadata2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchMetadataMetadata2Response](../../Models/Requests/PatchMetadataMetadata2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMetadataMetadata2

Remove a metadata

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.RemoveMetadataMetadata2Async(
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

**[RemoveMetadataMetadata2Response](../../Models/Requests/RemoveMetadataMetadata2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMetadataMetadata2

Update a metadata

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMetadataMetadata2Request req = new UpdateMetadataMetadata2Request() {
    MetadataMetadata = new MetadataMetadata() {
        Name = "<value>",
        ObjectType = "<value>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Metadata.UpdateMetadataMetadata2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateMetadataMetadata2Request](../../Models/Requests/UpdateMetadataMetadata2Request.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateMetadataMetadata2Response](../../Models/Requests/UpdateMetadataMetadata2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |