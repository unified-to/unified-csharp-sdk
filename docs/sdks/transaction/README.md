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

Creates a AccountingTransaction. Provide the unified AccountingTransaction fields in the request body; they are mapped to the provider's API. Returns the created AccountingTransaction.

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
        Id = "3ddb8fb8-7d1e-4fcb-b723-b4ccab8a1ec9",
        Lineitems = new List<AccountingTransactionLineItem>() {
            new AccountingTransactionLineItem() {
                CategoryIds = new List<string>() {},
                Description = "The turquoise Hat combines Wallis and Futuna aesthetics with Potassium-based durability",
                Id = "e8a1d9f2-c253-4279-8ee8-a04efb9f8d81",
                Name = "Shirt",
                TotalAmount = 10184D,
                UnitAmount = 536D,
                UnitQuantity = 19D,
            },
        },
        Memo = "deposit of ISK 792.81 at Fritsch - Dooley charged to account ending in 7879 using card ending in ****3230.",
        Status = AccountingTransactionStatus.Pending,
        TaxAmount = 0D,
        TotalAmount = 10184D,
        TransactionAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2019-10-14T07:21:58.609Z").ToUniversalTime(),
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

Retrieves a single AccountingTransaction by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AccountingTransactions. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the AccountingTransaction identified by `id`. Provide the unified AccountingTransaction fields to change in the request body.

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
        Id = "457ce95e-c76a-4ae2-8396-a143d508d89a",
        Lineitems = new List<AccountingTransactionLineItem>() {
            new AccountingTransactionLineItem() {
                CategoryIds = new List<string>() {},
                Description = "The turquoise Hat combines Wallis and Futuna aesthetics with Potassium-based durability",
                Id = "3e6f2203-3da6-489e-970e-a95c1aa58afd",
                Name = "Shirt",
                TotalAmount = 10184D,
                UnitAmount = 536D,
                UnitQuantity = 19D,
            },
        },
        Memo = "deposit of ISK 792.81 at Fritsch - Dooley charged to account ending in 7879 using card ending in ****3230.",
        Status = AccountingTransactionStatus.Pending,
        TaxAmount = 0D,
        TotalAmount = 10184D,
        TransactionAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2019-10-14T07:21:58.609Z").ToUniversalTime(),
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

Deletes the AccountingTransaction identified by `id`.

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

Updates the AccountingTransaction identified by `id`. Provide the unified AccountingTransaction fields to change in the request body.

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
        Id = "457ce95e-c76a-4ae2-8396-a143d508d89a",
        Lineitems = new List<AccountingTransactionLineItem>() {
            new AccountingTransactionLineItem() {
                CategoryIds = new List<string>() {},
                Description = "The turquoise Hat combines Wallis and Futuna aesthetics with Potassium-based durability",
                Id = "3e6f2203-3da6-489e-970e-a95c1aa58afd",
                Name = "Shirt",
                TotalAmount = 10184D,
                UnitAmount = 536D,
                UnitQuantity = 19D,
            },
        },
        Memo = "deposit of ISK 792.81 at Fritsch - Dooley charged to account ending in 7879 using card ending in ****3230.",
        Status = AccountingTransactionStatus.Pending,
        TaxAmount = 0D,
        TotalAmount = 10184D,
        TransactionAt = System.DateTime.Parse("2019-09-25T11:40:42.574Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2019-10-14T07:21:58.609Z").ToUniversalTime(),
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