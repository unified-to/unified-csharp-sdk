# Item
(*Item*)

### Available Operations

* [CreateAccountingItem](#createaccountingitem) - Create an item
* [GetAccountingItem](#getaccountingitem) - Retrieve an item
* [ListAccountingItems](#listaccountingitems) - List all items
* [PatchAccountingItem](#patchaccountingitem) - Update an item
* [RemoveAccountingItem](#removeaccountingitem) - Remove an item
* [UpdateAccountingItem](#updateaccountingitem) - Update an item

## CreateAccountingItem

Create an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Item.CreateAccountingItemAsync(ConnectionId: "string", AccountingItem: new AccountingItem() {
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `AccountingItem`                                            | [AccountingItem](../../Models/Components/AccountingItem.md) | :heavy_minus_sign:                                          | An item or product                                          |


### Response

**[CreateAccountingItemResponse](../../Models/Requests/CreateAccountingItemResponse.md)**


## GetAccountingItem

Retrieve an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Item.GetAccountingItemAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Item                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingItemResponse](../../Models/Requests/GetAccountingItemResponse.md)**


## ListAccountingItems

List all items

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingItemsRequest req = new ListAccountingItemsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Item.ListAccountingItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAccountingItemsRequest](../../Models/Requests/ListAccountingItemsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListAccountingItemsResponse](../../Models/Requests/ListAccountingItemsResponse.md)**


## PatchAccountingItem

Update an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Item.PatchAccountingItemAsync(ConnectionId: "string", Id: "string", AccountingItem: new AccountingItem() {
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Item                                              |
| `AccountingItem`                                            | [AccountingItem](../../Models/Components/AccountingItem.md) | :heavy_minus_sign:                                          | An item or product                                          |


### Response

**[PatchAccountingItemResponse](../../Models/Requests/PatchAccountingItemResponse.md)**


## RemoveAccountingItem

Remove an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Item.RemoveAccountingItemAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Item       |


### Response

**[RemoveAccountingItemResponse](../../Models/Requests/RemoveAccountingItemResponse.md)**


## UpdateAccountingItem

Update an item

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Item.UpdateAccountingItemAsync(ConnectionId: "string", Id: "string", AccountingItem: new AccountingItem() {
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Item                                              |
| `AccountingItem`                                            | [AccountingItem](../../Models/Components/AccountingItem.md) | :heavy_minus_sign:                                          | An item or product                                          |


### Response

**[UpdateAccountingItemResponse](../../Models/Requests/UpdateAccountingItemResponse.md)**

