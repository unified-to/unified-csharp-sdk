# Transaction
(*Transaction*)

### Available Operations

* [CreateAccountingTransaction](#createaccountingtransaction) - Create a transaction
* [GetAccountingTransaction](#getaccountingtransaction) - Retrieve a transaction
* [ListAccountingTransactions](#listaccountingtransactions) - List all transactions
* [PatchAccountingTransaction](#patchaccountingtransaction) - Update a transaction
* [RemoveAccountingTransaction](#removeaccountingtransaction) - Remove a transaction
* [UpdateAccountingTransaction](#updateaccountingtransaction) - Update a transaction

## CreateAccountingTransaction

Create a transaction

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

var res = await sdk.Transaction.CreateAccountingTransactionAsync(ConnectionId: "string", AccountingTransaction: new AccountingTransaction() {
    Id = "<ID>",
    LineItems = new List<AccountingTransactionLineitem>() {
        new AccountingTransactionLineitem() {
            AccountId = "string",
            TotalAmount = 4969.62D,
        },
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | ID of the connection                                                      |
| `AccountingTransaction`                                                   | [AccountingTransaction](../../Models/Components/AccountingTransaction.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[CreateAccountingTransactionResponse](../../Models/Requests/CreateAccountingTransactionResponse.md)**


## GetAccountingTransaction

Retrieve a transaction

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

var res = await sdk.Transaction.GetAccountingTransactionAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Transaction            |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingTransactionResponse](../../Models/Requests/GetAccountingTransactionResponse.md)**


## ListAccountingTransactions

List all transactions

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

ListAccountingTransactionsRequest req = new ListAccountingTransactionsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Transaction.ListAccountingTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingTransactionsRequest](../../Models/Requests/ListAccountingTransactionsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ListAccountingTransactionsResponse](../../Models/Requests/ListAccountingTransactionsResponse.md)**


## PatchAccountingTransaction

Update a transaction

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

var res = await sdk.Transaction.PatchAccountingTransactionAsync(ConnectionId: "string", Id: "string", AccountingTransaction: new AccountingTransaction() {
    Id = "<ID>",
    LineItems = new List<AccountingTransactionLineitem>() {
        new AccountingTransactionLineitem() {
            AccountId = "string",
            TotalAmount = 5633.69D,
        },
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | ID of the connection                                                      |
| `Id`                                                                      | *string*                                                                  | :heavy_check_mark:                                                        | ID of the Transaction                                                     |
| `AccountingTransaction`                                                   | [AccountingTransaction](../../Models/Components/AccountingTransaction.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[PatchAccountingTransactionResponse](../../Models/Requests/PatchAccountingTransactionResponse.md)**


## RemoveAccountingTransaction

Remove a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Transaction.RemoveAccountingTransactionAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Transaction |


### Response

**[RemoveAccountingTransactionResponse](../../Models/Requests/RemoveAccountingTransactionResponse.md)**


## UpdateAccountingTransaction

Update a transaction

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

var res = await sdk.Transaction.UpdateAccountingTransactionAsync(ConnectionId: "string", Id: "string", AccountingTransaction: new AccountingTransaction() {
    Id = "<ID>",
    LineItems = new List<AccountingTransactionLineitem>() {
        new AccountingTransactionLineitem() {
            AccountId = "string",
            TotalAmount = 6498.37D,
        },
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | ID of the connection                                                      |
| `Id`                                                                      | *string*                                                                  | :heavy_check_mark:                                                        | ID of the Transaction                                                     |
| `AccountingTransaction`                                                   | [AccountingTransaction](../../Models/Components/AccountingTransaction.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[UpdateAccountingTransactionResponse](../../Models/Requests/UpdateAccountingTransactionResponse.md)**

