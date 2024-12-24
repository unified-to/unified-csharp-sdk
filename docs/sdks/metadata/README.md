# Metadata
(*Metadata*)

## Overview

### Available Operations

* [CreateMetadataMetadata](#createmetadatametadata) - Create a metadata
* [GetMetadataMetadata](#getmetadatametadata) - Retrieve a metadata
* [ListMetadataMetadatas](#listmetadatametadatas) - List all metadatas
* [PatchMetadataMetadata](#patchmetadatametadata) - Update a metadata
* [RemoveMetadataMetadata](#removemetadatametadata) - Remove a metadata
* [UpdateMetadataMetadata](#updatemetadatametadata) - Update a metadata

## CreateMetadataMetadata

Create a metadata

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.CreateMetadataMetadataAsync(
    connectionId: "<id>",
    metadataMetadata: new MetadataMetadata() {
        Name = "<value>",
        ObjectType = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `MetadataMetadata`                                              | [MetadataMetadata](../../Models/Components/MetadataMetadata.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |

### Response

**[CreateMetadataMetadataResponse](../../Models/Requests/CreateMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMetadataMetadata

Retrieve a metadata

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.GetMetadataMetadataAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Metadata               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetMetadataMetadataResponse](../../Models/Requests/GetMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMetadataMetadatas

List all metadatas

### Example Usage

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

Update a metadata

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.PatchMetadataMetadataAsync(
    connectionId: "<id>",
    id: "<id>",
    metadataMetadata: new MetadataMetadata() {
        Name = "<value>",
        ObjectType = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Metadata                                              |
| `MetadataMetadata`                                              | [MetadataMetadata](../../Models/Components/MetadataMetadata.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |

### Response

**[PatchMetadataMetadataResponse](../../Models/Requests/PatchMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMetadataMetadata

Remove a metadata

### Example Usage

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

Update a metadata

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Metadata.UpdateMetadataMetadataAsync(
    connectionId: "<id>",
    id: "<id>",
    metadataMetadata: new MetadataMetadata() {
        Name = "<value>",
        ObjectType = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Metadata                                              |
| `MetadataMetadata`                                              | [MetadataMetadata](../../Models/Components/MetadataMetadata.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |

### Response

**[UpdateMetadataMetadataResponse](../../Models/Requests/UpdateMetadataMetadataResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |