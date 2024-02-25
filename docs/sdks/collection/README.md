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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Collection.CreateCommerceCollectionAsync(
    security: new CreateCommerceCollectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    commerceCollection: new CommerceCollection() {
    Id = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                              | [UnifiedTo.Models.Requests.CreateCommerceCollectionSecurity](../../Models/Requests/CreateCommerceCollectionSecurity.md) | :heavy_check_mark:                                                                                                      | The security requirements to use for the request.                                                                       |
| `ConnectionId`                                                                                                          | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the connection                                                                                                    |
| `CommerceCollection`                                                                                                    | [CommerceCollection](../../Models/Components/CommerceCollection.md)                                                     | :heavy_minus_sign:                                                                                                      | A collection of items/products/services                                                                                 |


### Response

**[CreateCommerceCollectionResponse](../../Models/Requests/CreateCommerceCollectionResponse.md)**


## GetCommerceCollection

Retrieve a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Collection.GetCommerceCollectionAsync(
    security: new GetCommerceCollectionSecurity() {
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

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.GetCommerceCollectionSecurity](../../Models/Requests/GetCommerceCollectionSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ConnectionId`                                                                                                    | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the connection                                                                                              |
| `Id`                                                                                                              | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the Collection                                                                                              |
| `Fields`                                                                                                          | List<*string*>                                                                                                    | :heavy_minus_sign:                                                                                                | Comma-delimited fields to return                                                                                  |


### Response

**[GetCommerceCollectionResponse](../../Models/Requests/GetCommerceCollectionResponse.md)**


## ListCommerceCollections

List all collections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCommerceCollectionsRequest req = new ListCommerceCollectionsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Collection.ListCommerceCollectionsAsync(
    security: new ListCommerceCollectionsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [ListCommerceCollectionsRequest](../../Models/Requests/ListCommerceCollectionsRequest.md)                             | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.ListCommerceCollectionsSecurity](../../Models/Requests/ListCommerceCollectionsSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |


### Response

**[ListCommerceCollectionsResponse](../../Models/Requests/ListCommerceCollectionsResponse.md)**


## PatchCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Collection.PatchCommerceCollectionAsync(
    security: new PatchCommerceCollectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceCollection: new CommerceCollection() {
    Id = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.PatchCommerceCollectionSecurity](../../Models/Requests/PatchCommerceCollectionSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Collection                                                                                                  |
| `CommerceCollection`                                                                                                  | [CommerceCollection](../../Models/Components/CommerceCollection.md)                                                   | :heavy_minus_sign:                                                                                                    | A collection of items/products/services                                                                               |


### Response

**[PatchCommerceCollectionResponse](../../Models/Requests/PatchCommerceCollectionResponse.md)**


## RemoveCommerceCollection

Remove a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Collection.RemoveCommerceCollectionAsync(
    security: new RemoveCommerceCollectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                              | [UnifiedTo.Models.Requests.RemoveCommerceCollectionSecurity](../../Models/Requests/RemoveCommerceCollectionSecurity.md) | :heavy_check_mark:                                                                                                      | The security requirements to use for the request.                                                                       |
| `ConnectionId`                                                                                                          | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the connection                                                                                                    |
| `Id`                                                                                                                    | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the Collection                                                                                                    |


### Response

**[RemoveCommerceCollectionResponse](../../Models/Requests/RemoveCommerceCollectionResponse.md)**


## UpdateCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Collection.UpdateCommerceCollectionAsync(
    security: new UpdateCommerceCollectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceCollection: new CommerceCollection() {
    Id = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                              | [UnifiedTo.Models.Requests.UpdateCommerceCollectionSecurity](../../Models/Requests/UpdateCommerceCollectionSecurity.md) | :heavy_check_mark:                                                                                                      | The security requirements to use for the request.                                                                       |
| `ConnectionId`                                                                                                          | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the connection                                                                                                    |
| `Id`                                                                                                                    | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the Collection                                                                                                    |
| `CommerceCollection`                                                                                                    | [CommerceCollection](../../Models/Components/CommerceCollection.md)                                                     | :heavy_minus_sign:                                                                                                      | A collection of items/products/services                                                                                 |


### Response

**[UpdateCommerceCollectionResponse](../../Models/Requests/UpdateCommerceCollectionResponse.md)**

