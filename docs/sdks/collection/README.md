# Collection
(*Collection*)

## Overview

### Available Operations

* [CreateCommerceCollection](#createcommercecollection) - Create a collection
* [GetCommerceCollection](#getcommercecollection) - Retrieve a collection
* [ListCommerceCollections](#listcommercecollections) - List all collections
* [PatchCommerceCollection](#patchcommercecollection) - Update a collection
* [RemoveCommerceCollection](#removecommercecollection) - Remove a collection
* [UpdateCommerceCollection](#updatecommercecollection) - Update a collection

## CreateCommerceCollection

Create a collection

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Collection.CreateCommerceCollectionAsync(
    commerceCollection: new CommerceCollection() {
        Name = "<value>",
    },
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_check_mark:                                                  | A collection of items/products/services                             |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Fields`                                                            | List<*string*>                                                      | :heavy_minus_sign:                                                  | Comma-delimited fields to return                                    |

### Response

**[CreateCommerceCollectionResponse](../../Models/Requests/CreateCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceCollection

Retrieve a collection

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Collection.GetCommerceCollectionAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Collection             |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetCommerceCollectionResponse](../../Models/Requests/GetCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceCollections

List all collections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceCollectionsRequest req = new ListCommerceCollectionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Collection.ListCommerceCollectionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListCommerceCollectionsRequest](../../Models/Requests/ListCommerceCollectionsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ListCommerceCollectionsResponse](../../Models/Requests/ListCommerceCollectionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceCollection

Update a collection

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Collection.PatchCommerceCollectionAsync(
    commerceCollection: new CommerceCollection() {
        Name = "<value>",
    },
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_check_mark:                                                  | A collection of items/products/services                             |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Collection                                                |
| `Fields`                                                            | List<*string*>                                                      | :heavy_minus_sign:                                                  | Comma-delimited fields to return                                    |

### Response

**[PatchCommerceCollectionResponse](../../Models/Requests/PatchCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceCollection

Remove a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Collection.RemoveCommerceCollectionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Collection |

### Response

**[RemoveCommerceCollectionResponse](../../Models/Requests/RemoveCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceCollection

Update a collection

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Collection.UpdateCommerceCollectionAsync(
    commerceCollection: new CommerceCollection() {
        Name = "<value>",
    },
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_check_mark:                                                  | A collection of items/products/services                             |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Collection                                                |
| `Fields`                                                            | List<*string*>                                                      | :heavy_minus_sign:                                                  | Comma-delimited fields to return                                    |

### Response

**[UpdateCommerceCollectionResponse](../../Models/Requests/UpdateCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |