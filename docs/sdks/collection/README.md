# Collection
(*Collection*)

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Collection.CreateCommerceCollectionAsync(
    connectionId: "string",
    commerceCollection: new CommerceCollection() {
    Id = "<ID>",
    Name = "string",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_minus_sign:                                                  | A collection of items/products/services                             |


### Response

**[CreateCommerceCollectionResponse](../../Models/Requests/CreateCommerceCollectionResponse.md)**


## GetCommerceCollection

Retrieve a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Collection.GetCommerceCollectionAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

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


## ListCommerceCollections

List all collections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCommerceCollectionsRequest req = new ListCommerceCollectionsRequest() {
    ConnectionId = "string",
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


## PatchCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Collection.PatchCommerceCollectionAsync(
    connectionId: "string",
    id: "string",
    commerceCollection: new CommerceCollection() {
    Id = "<ID>",
    Name = "string",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Collection                                                |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_minus_sign:                                                  | A collection of items/products/services                             |


### Response

**[PatchCommerceCollectionResponse](../../Models/Requests/PatchCommerceCollectionResponse.md)**


## RemoveCommerceCollection

Remove a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Collection.RemoveCommerceCollectionAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Collection |


### Response

**[RemoveCommerceCollectionResponse](../../Models/Requests/RemoveCommerceCollectionResponse.md)**


## UpdateCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Collection.UpdateCommerceCollectionAsync(
    connectionId: "string",
    id: "string",
    commerceCollection: new CommerceCollection() {
    Id = "<ID>",
    Name = "string",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Collection                                                |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_minus_sign:                                                  | A collection of items/products/services                             |


### Response

**[UpdateCommerceCollectionResponse](../../Models/Requests/UpdateCommerceCollectionResponse.md)**

