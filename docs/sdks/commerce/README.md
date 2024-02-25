# Commerce
(*Commerce*)

### Available Operations

* [CreateCommerceCollection](#createcommercecollection) - Create a collection
* [CreateCommerceInventory](#createcommerceinventory) - Create an inventory
* [CreateCommerceItem](#createcommerceitem) - Create an item
* [CreateCommerceLocation](#createcommercelocation) - Create a location
* [GetCommerceCollection](#getcommercecollection) - Retrieve a collection
* [GetCommerceInventory](#getcommerceinventory) - Retrieve an inventory
* [GetCommerceItem](#getcommerceitem) - Retrieve an item
* [GetCommerceLocation](#getcommercelocation) - Retrieve a location
* [ListCommerceCollections](#listcommercecollections) - List all collections
* [ListCommerceInventories](#listcommerceinventories) - List all inventories
* [ListCommerceItems](#listcommerceitems) - List all items
* [ListCommerceLocations](#listcommercelocations) - List all locations
* [PatchCommerceCollection](#patchcommercecollection) - Update a collection
* [PatchCommerceInventory](#patchcommerceinventory) - Update an inventory
* [PatchCommerceItem](#patchcommerceitem) - Update an item
* [PatchCommerceLocation](#patchcommercelocation) - Update a location
* [RemoveCommerceCollection](#removecommercecollection) - Remove a collection
* [RemoveCommerceInventory](#removecommerceinventory) - Remove an inventory
* [RemoveCommerceItem](#removecommerceitem) - Remove an item
* [RemoveCommerceLocation](#removecommercelocation) - Remove a location
* [UpdateCommerceCollection](#updatecommercecollection) - Update a collection
* [UpdateCommerceInventory](#updatecommerceinventory) - Update an inventory
* [UpdateCommerceItem](#updatecommerceitem) - Update an item
* [UpdateCommerceLocation](#updatecommercelocation) - Update a location

## CreateCommerceCollection

Create a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.CreateCommerceCollectionAsync(
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


## CreateCommerceInventory

Create an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.CreateCommerceInventoryAsync(
    security: new CreateCommerceInventorySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    commerceInventory: new CommerceInventory() {
    Available = 5165.08D,
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateCommerceInventorySecurity](../../Models/Requests/CreateCommerceInventorySecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `CommerceInventory`                                                                                                   | [CommerceInventory](../../Models/Components/CommerceInventory.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateCommerceInventoryResponse](../../Models/Requests/CreateCommerceInventoryResponse.md)**


## CreateCommerceItem

Create an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.CreateCommerceItemAsync(
    security: new CreateCommerceItemSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    commerceItem: new CommerceItem() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.CreateCommerceItemSecurity](../../Models/Requests/CreateCommerceItemSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `CommerceItem`                                                                                              | [CommerceItem](../../Models/Components/CommerceItem.md)                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[CreateCommerceItemResponse](../../Models/Requests/CreateCommerceItemResponse.md)**


## CreateCommerceLocation

Create a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.CreateCommerceLocationAsync(
    security: new CreateCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    commerceLocation: new CommerceLocation() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.CreateCommerceLocationSecurity](../../Models/Requests/CreateCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `CommerceLocation`                                                                                                  | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                     | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[CreateCommerceLocationResponse](../../Models/Requests/CreateCommerceLocationResponse.md)**


## GetCommerceCollection

Retrieve a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.GetCommerceCollectionAsync(
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


## GetCommerceInventory

Retrieve an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.GetCommerceInventoryAsync(
    security: new GetCommerceInventorySecurity() {
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

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetCommerceInventorySecurity](../../Models/Requests/GetCommerceInventorySecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Inventory                                                                                             |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetCommerceInventoryResponse](../../Models/Requests/GetCommerceInventoryResponse.md)**


## GetCommerceItem

Retrieve an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.GetCommerceItemAsync(
    security: new GetCommerceItemSecurity() {
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

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.GetCommerceItemSecurity](../../Models/Requests/GetCommerceItemSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Item                                                                                        |
| `Fields`                                                                                              | List<*string*>                                                                                        | :heavy_minus_sign:                                                                                    | Comma-delimited fields to return                                                                      |


### Response

**[GetCommerceItemResponse](../../Models/Requests/GetCommerceItemResponse.md)**


## GetCommerceLocation

Retrieve a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.GetCommerceLocationAsync(
    security: new GetCommerceLocationSecurity() {
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

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.GetCommerceLocationSecurity](../../Models/Requests/GetCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Location                                                                                            |
| `Fields`                                                                                                      | List<*string*>                                                                                                | :heavy_minus_sign:                                                                                            | Comma-delimited fields to return                                                                              |


### Response

**[GetCommerceLocationResponse](../../Models/Requests/GetCommerceLocationResponse.md)**


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

var res = await sdk.Commerce.ListCommerceCollectionsAsync(
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


## ListCommerceInventories

List all inventories

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCommerceInventoriesRequest req = new ListCommerceInventoriesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Commerce.ListCommerceInventoriesAsync(
    security: new ListCommerceInventoriesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [ListCommerceInventoriesRequest](../../Models/Requests/ListCommerceInventoriesRequest.md)                             | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.ListCommerceInventoriesSecurity](../../Models/Requests/ListCommerceInventoriesSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |


### Response

**[ListCommerceInventoriesResponse](../../Models/Requests/ListCommerceInventoriesResponse.md)**


## ListCommerceItems

List all items

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCommerceItemsRequest req = new ListCommerceItemsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Commerce.ListCommerceItemsAsync(
    security: new ListCommerceItemsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ListCommerceItemsRequest](../../Models/Requests/ListCommerceItemsRequest.md)                             | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |
| `security`                                                                                                | [UnifiedTo.Models.Requests.ListCommerceItemsSecurity](../../Models/Requests/ListCommerceItemsSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |


### Response

**[ListCommerceItemsResponse](../../Models/Requests/ListCommerceItemsResponse.md)**


## ListCommerceLocations

List all locations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCommerceLocationsRequest req = new ListCommerceLocationsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Commerce.ListCommerceLocationsAsync(
    security: new ListCommerceLocationsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [ListCommerceLocationsRequest](../../Models/Requests/ListCommerceLocationsRequest.md)                             | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.ListCommerceLocationsSecurity](../../Models/Requests/ListCommerceLocationsSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |


### Response

**[ListCommerceLocationsResponse](../../Models/Requests/ListCommerceLocationsResponse.md)**


## PatchCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.PatchCommerceCollectionAsync(
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


## PatchCommerceInventory

Update an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.PatchCommerceInventoryAsync(
    security: new PatchCommerceInventorySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceInventory: new CommerceInventory() {
    Available = 615.23D,
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchCommerceInventorySecurity](../../Models/Requests/PatchCommerceInventorySecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Inventory                                                                                                 |
| `CommerceInventory`                                                                                                 | [CommerceInventory](../../Models/Components/CommerceInventory.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchCommerceInventoryResponse](../../Models/Requests/PatchCommerceInventoryResponse.md)**


## PatchCommerceItem

Update an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.PatchCommerceItemAsync(
    security: new PatchCommerceItemSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceItem: new CommerceItem() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.PatchCommerceItemSecurity](../../Models/Requests/PatchCommerceItemSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Item                                                                                            |
| `CommerceItem`                                                                                            | [CommerceItem](../../Models/Components/CommerceItem.md)                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[PatchCommerceItemResponse](../../Models/Requests/PatchCommerceItemResponse.md)**


## PatchCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.PatchCommerceLocationAsync(
    security: new PatchCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceLocation: new CommerceLocation() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.PatchCommerceLocationSecurity](../../Models/Requests/PatchCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ConnectionId`                                                                                                    | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the connection                                                                                              |
| `Id`                                                                                                              | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the Location                                                                                                |
| `CommerceLocation`                                                                                                | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |


### Response

**[PatchCommerceLocationResponse](../../Models/Requests/PatchCommerceLocationResponse.md)**


## RemoveCommerceCollection

Remove a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.RemoveCommerceCollectionAsync(
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


## RemoveCommerceInventory

Remove an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.RemoveCommerceInventoryAsync(
    security: new RemoveCommerceInventorySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveCommerceInventorySecurity](../../Models/Requests/RemoveCommerceInventorySecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Inventory                                                                                                   |


### Response

**[RemoveCommerceInventoryResponse](../../Models/Requests/RemoveCommerceInventoryResponse.md)**


## RemoveCommerceItem

Remove an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.RemoveCommerceItemAsync(
    security: new RemoveCommerceItemSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.RemoveCommerceItemSecurity](../../Models/Requests/RemoveCommerceItemSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Item                                                                                              |


### Response

**[RemoveCommerceItemResponse](../../Models/Requests/RemoveCommerceItemResponse.md)**


## RemoveCommerceLocation

Remove a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.RemoveCommerceLocationAsync(
    security: new RemoveCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.RemoveCommerceLocationSecurity](../../Models/Requests/RemoveCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Location                                                                                                  |


### Response

**[RemoveCommerceLocationResponse](../../Models/Requests/RemoveCommerceLocationResponse.md)**


## UpdateCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.UpdateCommerceCollectionAsync(
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


## UpdateCommerceInventory

Update an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.UpdateCommerceInventoryAsync(
    security: new UpdateCommerceInventorySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceInventory: new CommerceInventory() {
    Available = 9360.02D,
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateCommerceInventorySecurity](../../Models/Requests/UpdateCommerceInventorySecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Inventory                                                                                                   |
| `CommerceInventory`                                                                                                   | [CommerceInventory](../../Models/Components/CommerceInventory.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateCommerceInventoryResponse](../../Models/Requests/UpdateCommerceInventoryResponse.md)**


## UpdateCommerceItem

Update an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.UpdateCommerceItemAsync(
    security: new UpdateCommerceItemSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceItem: new CommerceItem() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.UpdateCommerceItemSecurity](../../Models/Requests/UpdateCommerceItemSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Item                                                                                              |
| `CommerceItem`                                                                                              | [CommerceItem](../../Models/Components/CommerceItem.md)                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[UpdateCommerceItemResponse](../../Models/Requests/UpdateCommerceItemResponse.md)**


## UpdateCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Commerce.UpdateCommerceLocationAsync(
    security: new UpdateCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceLocation: new CommerceLocation() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.UpdateCommerceLocationSecurity](../../Models/Requests/UpdateCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Location                                                                                                  |
| `CommerceLocation`                                                                                                  | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                     | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[UpdateCommerceLocationResponse](../../Models/Requests/UpdateCommerceLocationResponse.md)**

