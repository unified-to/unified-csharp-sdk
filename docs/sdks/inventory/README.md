# Inventory
(*Inventory*)

### Available Operations

* [CreateCommerceInventory](#createcommerceinventory) - Create an inventory
* [GetCommerceInventory](#getcommerceinventory) - Retrieve an inventory
* [ListCommerceInventories](#listcommerceinventories) - List all inventories
* [PatchCommerceInventory](#patchcommerceinventory) - Update an inventory
* [RemoveCommerceInventory](#removecommerceinventory) - Remove an inventory
* [UpdateCommerceInventory](#updatecommerceinventory) - Update an inventory

## CreateCommerceInventory

Create an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Inventory.CreateCommerceInventoryAsync(
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


## GetCommerceInventory

Retrieve an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Inventory.GetCommerceInventoryAsync(
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

var res = await sdk.Inventory.ListCommerceInventoriesAsync(
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


## PatchCommerceInventory

Update an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Inventory.PatchCommerceInventoryAsync(
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


## RemoveCommerceInventory

Remove an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Inventory.RemoveCommerceInventoryAsync(
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


## UpdateCommerceInventory

Update an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Inventory.UpdateCommerceInventoryAsync(
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

