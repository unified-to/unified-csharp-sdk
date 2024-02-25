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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Transaction.CreateAccountingTransactionAsync(
    security: new CreateAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingTransaction: new AccountingTransaction() {
    Id = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.CreateAccountingTransactionSecurity](../../Models/Requests/CreateAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `ConnectionId`                                                                                                                | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the connection                                                                                                          |
| `AccountingTransaction`                                                                                                       | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                     | :heavy_minus_sign:                                                                                                            | N/A                                                                                                                           |


### Response

**[CreateAccountingTransactionResponse](../../Models/Requests/CreateAccountingTransactionResponse.md)**


## GetAccountingTransaction

Retrieve a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Transaction.GetAccountingTransactionAsync(
    security: new GetAccountingTransactionSecurity() {
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

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                              | [UnifiedTo.Models.Requests.GetAccountingTransactionSecurity](../../Models/Requests/GetAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                      | The security requirements to use for the request.                                                                       |
| `ConnectionId`                                                                                                          | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the connection                                                                                                    |
| `Id`                                                                                                                    | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the Transaction                                                                                                   |
| `Fields`                                                                                                                | List<*string*>                                                                                                          | :heavy_minus_sign:                                                                                                      | Comma-delimited fields to return                                                                                        |


### Response

**[GetAccountingTransactionResponse](../../Models/Requests/GetAccountingTransactionResponse.md)**


## ListAccountingTransactions

List all transactions

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingTransactionsRequest req = new ListAccountingTransactionsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Transaction.ListAccountingTransactionsAsync(
    security: new ListAccountingTransactionsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [ListAccountingTransactionsRequest](../../Models/Requests/ListAccountingTransactionsRequest.md)                             | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |
| `security`                                                                                                                  | [UnifiedTo.Models.Requests.ListAccountingTransactionsSecurity](../../Models/Requests/ListAccountingTransactionsSecurity.md) | :heavy_check_mark:                                                                                                          | The security requirements to use for the request.                                                                           |


### Response

**[ListAccountingTransactionsResponse](../../Models/Requests/ListAccountingTransactionsResponse.md)**


## PatchAccountingTransaction

Update a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Transaction.PatchAccountingTransactionAsync(
    security: new PatchAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTransaction: new AccountingTransaction() {
    Id = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                  | [UnifiedTo.Models.Requests.PatchAccountingTransactionSecurity](../../Models/Requests/PatchAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                          | The security requirements to use for the request.                                                                           |
| `ConnectionId`                                                                                                              | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | ID of the connection                                                                                                        |
| `Id`                                                                                                                        | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | ID of the Transaction                                                                                                       |
| `AccountingTransaction`                                                                                                     | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                   | :heavy_minus_sign:                                                                                                          | N/A                                                                                                                         |


### Response

**[PatchAccountingTransactionResponse](../../Models/Requests/PatchAccountingTransactionResponse.md)**


## RemoveAccountingTransaction

Remove a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Transaction.RemoveAccountingTransactionAsync(
    security: new RemoveAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.RemoveAccountingTransactionSecurity](../../Models/Requests/RemoveAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `ConnectionId`                                                                                                                | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the connection                                                                                                          |
| `Id`                                                                                                                          | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the Transaction                                                                                                         |


### Response

**[RemoveAccountingTransactionResponse](../../Models/Requests/RemoveAccountingTransactionResponse.md)**


## UpdateAccountingTransaction

Update a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Transaction.UpdateAccountingTransactionAsync(
    security: new UpdateAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTransaction: new AccountingTransaction() {
    Id = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.UpdateAccountingTransactionSecurity](../../Models/Requests/UpdateAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `ConnectionId`                                                                                                                | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the connection                                                                                                          |
| `Id`                                                                                                                          | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the Transaction                                                                                                         |
| `AccountingTransaction`                                                                                                       | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                     | :heavy_minus_sign:                                                                                                            | N/A                                                                                                                           |


### Response

**[UpdateAccountingTransactionResponse](../../Models/Requests/UpdateAccountingTransactionResponse.md)**

