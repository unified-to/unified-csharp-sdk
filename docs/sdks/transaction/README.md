# Transaction

## Overview

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

<!-- UsageSnippet language="csharp" operationID="createAccountingTransaction" method="post" path="/accounting/{connection_id}/transaction" example="accounting_transaction" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Transaction.CreateAccountingTransactionAsync(
    accountingTransaction: new AccountingTransaction() {
        CreatedAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        ExchangeRate = 0.5674D,
        Id = "7de0c454-3db6-4811-afb0-45b3bb174f8d",
        Lineitems = new List<AccountingTransactionLineItem>() {
            new AccountingTransactionLineItem() {
                CategoryIds = new List<string>() {},
                Description = "The Nikolas Table is the latest in a series of downright products from Beier and Sons",
                Id = "562d87be-d72d-46fc-b369-1a30ad47cb35",
                Name = "Salad",
                ObjectType = "delicate",
                TotalAmount = 58531D,
                UnitAmount = 536D,
                UnitQuantity = 91D,
            },
        },
        Memo = "withdrawal of USD 873.18 at Harber and Sons charged to account ending in 1804 using card ending in ****7022.",
        Status = AccountingTransactionStatus.Void,
        TaxAmount = 0D,
        TotalAmount = 94452D,
        TransactionAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-09-16T13:36:17.078Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingTransaction`                                                                                                                          | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingTransactionQueryParamFields](../../Models/Requests/CreateAccountingTransactionQueryParamFields.md)>                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingTransactionResponse](../../Models/Requests/CreateAccountingTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingTransaction

Retrieve a transaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingTransaction" method="get" path="/accounting/{connection_id}/transaction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Transaction.GetAccountingTransactionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Transaction                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetAccountingTransactionQueryParamFields](../../Models/Requests/GetAccountingTransactionQueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingTransactionResponse](../../Models/Requests/GetAccountingTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingTransactions

List all transactions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingTransactions" method="get" path="/accounting/{connection_id}/transaction" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingTransactionsRequest req = new ListAccountingTransactionsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingTransaction

Update a transaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingTransaction" method="patch" path="/accounting/{connection_id}/transaction/{id}" example="accounting_transaction" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingTransactionRequest req = new PatchAccountingTransactionRequest() {
    AccountingTransaction = new AccountingTransaction() {
        CreatedAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        ExchangeRate = 0.5674D,
        Id = "a54266f5-37f6-4957-849c-d6006068b45e",
        Lineitems = new List<AccountingTransactionLineItem>() {
            new AccountingTransactionLineItem() {
                CategoryIds = new List<string>() {},
                Description = "The Nikolas Table is the latest in a series of downright products from Beier and Sons",
                Id = "1bfb935d-3996-4971-befd-4c3ff7ca22ea",
                Name = "Salad",
                ObjectType = "delicate",
                TotalAmount = 58531D,
                UnitAmount = 536D,
                UnitQuantity = 91D,
            },
        },
        Memo = "withdrawal of USD 873.18 at Harber and Sons charged to account ending in 1804 using card ending in ****7022.",
        Status = AccountingTransactionStatus.Void,
        TaxAmount = 0D,
        TotalAmount = 94452D,
        TransactionAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-09-16T13:36:17.083Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Transaction.PatchAccountingTransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [PatchAccountingTransactionRequest](../../Models/Requests/PatchAccountingTransactionRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[PatchAccountingTransactionResponse](../../Models/Requests/PatchAccountingTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingTransaction

Remove a transaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingTransaction" method="delete" path="/accounting/{connection_id}/transaction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Transaction.RemoveAccountingTransactionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Transaction |

### Response

**[RemoveAccountingTransactionResponse](../../Models/Requests/RemoveAccountingTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingTransaction

Update a transaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingTransaction" method="put" path="/accounting/{connection_id}/transaction/{id}" example="accounting_transaction" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingTransactionRequest req = new UpdateAccountingTransactionRequest() {
    AccountingTransaction = new AccountingTransaction() {
        CreatedAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        ExchangeRate = 0.5674D,
        Id = "a54266f5-37f6-4957-849c-d6006068b45e",
        Lineitems = new List<AccountingTransactionLineItem>() {
            new AccountingTransactionLineItem() {
                CategoryIds = new List<string>() {},
                Description = "The Nikolas Table is the latest in a series of downright products from Beier and Sons",
                Id = "1bfb935d-3996-4971-befd-4c3ff7ca22ea",
                Name = "Salad",
                ObjectType = "delicate",
                TotalAmount = 58531D,
                UnitAmount = 536D,
                UnitQuantity = 91D,
            },
        },
        Memo = "withdrawal of USD 873.18 at Harber and Sons charged to account ending in 1804 using card ending in ****7022.",
        Status = AccountingTransactionStatus.Void,
        TaxAmount = 0D,
        TotalAmount = 94452D,
        TransactionAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-09-16T13:36:17.083Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Transaction.UpdateAccountingTransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [UpdateAccountingTransactionRequest](../../Models/Requests/UpdateAccountingTransactionRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[UpdateAccountingTransactionResponse](../../Models/Requests/UpdateAccountingTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |