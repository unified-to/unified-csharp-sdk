# Expense

## Overview

### Available Operations

* [CreateAccountingExpense](#createaccountingexpense) - Create an expense
* [GetAccountingExpense](#getaccountingexpense) - Retrieve an expense
* [ListAccountingExpenses](#listaccountingexpenses) - List all expenses
* [PatchAccountingExpense](#patchaccountingexpense) - Update an expense
* [RemoveAccountingExpense](#removeaccountingexpense) - Remove an expense
* [UpdateAccountingExpense](#updateaccountingexpense) - Update an expense

## CreateAccountingExpense

Create an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingExpense" method="post" path="/accounting/{connection_id}/expense" example="accounting_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expense.CreateAccountingExpenseAsync(
    accountingExpense: new AccountingExpense() {
        ApprovedAt = System.DateTime.Parse("2026-05-12T09:40:54.236Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://ripe-napkin.biz/",
                Id = "fef67b87-0957-42c3-adcf-43c0c46d6107",
                MimeType = "annus",
                Name = "cohibeo",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "SSP",
        ExternalNumber = "necessitatibus",
        Id = "ffa6e9c7-9193-4696-85f6-b19d35be2a3b",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "271f95a7-bbfc-403d-919c-785e59b3c427",
                ItemDescription = "Innovative Table featuring left technology and Rubber construction",
                ItemName = "Luxurious Cotton Pizza",
                ItemSku = "978-0-8324-6620-5",
                Notes = "Degusto conventus defendo valetudo.",
                TaxAmount = 2501D,
                TotalAmount = 168D,
                UnitAmount = 3059D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Refined Steel Shoes",
        PaymentMethod = "CASH",
        PostedAt = System.DateTime.Parse("2021-06-04T15:33:50.453Z").ToUniversalTime(),
        ReimbursedAmount = 1833D,
        Status = AccountingExpenseStatus.Submitted,
        TaxAmount = 2602D,
        TotalAmount = 3580D,
        UpdatedAt = System.DateTime.Parse("2026-05-12T09:40:54.236Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingExpense`                                                                                                                              | [AccountingExpense](../../Models/Components/AccountingExpense.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingExpenseQueryParamFields](../../Models/Requests/CreateAccountingExpenseQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingExpenseResponse](../../Models/Requests/CreateAccountingExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingExpense

Retrieve an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingExpense" method="get" path="/accounting/{connection_id}/expense/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expense.GetAccountingExpenseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Expense                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAccountingExpenseQueryParamFields](../../Models/Requests/GetAccountingExpenseQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingExpenseResponse](../../Models/Requests/GetAccountingExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingExpenses

List all expenses

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingExpenses" method="get" path="/accounting/{connection_id}/expense" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingExpensesRequest req = new ListAccountingExpensesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Expense.ListAccountingExpensesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingExpensesRequest](../../Models/Requests/ListAccountingExpensesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingExpensesResponse](../../Models/Requests/ListAccountingExpensesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingExpense

Update an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingExpense" method="patch" path="/accounting/{connection_id}/expense/{id}" example="accounting_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingExpenseRequest req = new PatchAccountingExpenseRequest() {
    AccountingExpense = new AccountingExpense() {
        ApprovedAt = System.DateTime.Parse("2026-05-12T09:40:54.291Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://ripe-napkin.biz/",
                Id = "952638a5-c054-405a-9014-96aef0753c77",
                MimeType = "annus",
                Name = "cohibeo",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "SSP",
        ExternalNumber = "necessitatibus",
        Id = "fa30c86b-1dc7-447f-99a5-bb2137a4e4c2",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "8b534c2b-fe41-4494-86df-02ef8117de50",
                ItemDescription = "Innovative Table featuring left technology and Rubber construction",
                ItemName = "Luxurious Cotton Pizza",
                ItemSku = "978-0-8324-6620-5",
                Notes = "Degusto conventus defendo valetudo.",
                TaxAmount = 2501D,
                TotalAmount = 168D,
                UnitAmount = 3059D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Refined Steel Shoes",
        PaymentMethod = "CASH",
        PostedAt = System.DateTime.Parse("2021-06-04T15:33:50.462Z").ToUniversalTime(),
        ReimbursedAmount = 1833D,
        Status = AccountingExpenseStatus.Submitted,
        TaxAmount = 2602D,
        TotalAmount = 3580D,
        UpdatedAt = System.DateTime.Parse("2026-05-12T09:40:54.291Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expense.PatchAccountingExpenseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingExpenseRequest](../../Models/Requests/PatchAccountingExpenseRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingExpenseResponse](../../Models/Requests/PatchAccountingExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingExpense

Remove an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingExpense" method="delete" path="/accounting/{connection_id}/expense/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expense.RemoveAccountingExpenseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Expense    |

### Response

**[RemoveAccountingExpenseResponse](../../Models/Requests/RemoveAccountingExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingExpense

Update an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingExpense" method="put" path="/accounting/{connection_id}/expense/{id}" example="accounting_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingExpenseRequest req = new UpdateAccountingExpenseRequest() {
    AccountingExpense = new AccountingExpense() {
        ApprovedAt = System.DateTime.Parse("2026-05-12T09:40:54.291Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://ripe-napkin.biz/",
                Id = "952638a5-c054-405a-9014-96aef0753c77",
                MimeType = "annus",
                Name = "cohibeo",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "SSP",
        ExternalNumber = "necessitatibus",
        Id = "fa30c86b-1dc7-447f-99a5-bb2137a4e4c2",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "8b534c2b-fe41-4494-86df-02ef8117de50",
                ItemDescription = "Innovative Table featuring left technology and Rubber construction",
                ItemName = "Luxurious Cotton Pizza",
                ItemSku = "978-0-8324-6620-5",
                Notes = "Degusto conventus defendo valetudo.",
                TaxAmount = 2501D,
                TotalAmount = 168D,
                UnitAmount = 3059D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Refined Steel Shoes",
        PaymentMethod = "CASH",
        PostedAt = System.DateTime.Parse("2021-06-04T15:33:50.462Z").ToUniversalTime(),
        ReimbursedAmount = 1833D,
        Status = AccountingExpenseStatus.Submitted,
        TaxAmount = 2602D,
        TotalAmount = 3580D,
        UpdatedAt = System.DateTime.Parse("2026-05-12T09:40:54.291Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expense.UpdateAccountingExpenseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingExpenseRequest](../../Models/Requests/UpdateAccountingExpenseRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingExpenseResponse](../../Models/Requests/UpdateAccountingExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |