# Expense

## Overview

### Available Operations

* [CreateAccountingExpense](#createaccountingexpense) - Create an expense
* [CreateLegalExpense](#createlegalexpense) - Create an expense
* [GetAccountingExpense](#getaccountingexpense) - Retrieve an expense
* [GetLegalExpense](#getlegalexpense) - Retrieve an expense
* [ListAccountingExpenses](#listaccountingexpenses) - List all expenses
* [ListLegalExpenses](#listlegalexpenses) - List all expenses
* [PatchAccountingExpense](#patchaccountingexpense) - Update an expense
* [PatchLegalExpense](#patchlegalexpense) - Update an expense
* [RemoveAccountingExpense](#removeaccountingexpense) - Remove an expense
* [RemoveLegalExpense](#removelegalexpense) - Remove an expense
* [UpdateAccountingExpense](#updateaccountingexpense) - Update an expense
* [UpdateLegalExpense](#updatelegalexpense) - Update an expense

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
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://rubbery-couch.biz/",
                Id = "6bfcf576-add7-458b-b613-19d5d6cd35cc",
                MimeType = "application/pdf",
                Name = "receipt-9696.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://appropriate-smog.biz/",
                Id = "292d1c7f-b917-4bf6-8cf6-50dd87b58abd",
                MimeType = "application/pdf",
                Name = "receipt-9696-1.pdf",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "EXP-38303",
        Id = "a029e98e-b8c5-4cf6-acb0-d8b8a558da1c",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "c78595fd-a880-4d5a-beb7-d5a883cf778b",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 364.74D,
                UnitAmount = 364.74D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "9d7f8487-c0fe-4dfe-92a0-1de1eb0afe4a",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 258.35D,
                UnitAmount = 258.35D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "6cb1d4be-ce47-4944-ad2f-f0232cbc0b64",
                ItemName = "Conference ticket",
                Notes = "Casus umquam conicio cinis demitto sint.",
                TaxAmount = 0D,
                TotalAmount = 28.14D,
                UnitAmount = 28.14D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "00b18a0c-7338-4861-98c3-c560b1fbffce",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 157.04D,
                UnitAmount = 157.04D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "0580d0b1-5320-4b56-8927-edb50f7597df",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 164.02D,
                UnitAmount = 164.02D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "A payment of XPF 714.84 occurred at Bins, Barrows and Koch using a card ending in ****8422 for account ***4614.",
        PaymentMethod = "CASH",
        PostedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Status = AccountingExpenseStatus.Submitted,
        TaxAmount = 0D,
        TotalAmount = 972.29D,
        Type = AccountingExpenseType.Company,
        UpdatedAt = System.DateTime.Parse("2020-09-02T07:17:47.342Z").ToUniversalTime(),
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

## CreateLegalExpense

Create an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLegalExpense" method="post" path="/legal/{connection_id}/expense" example="legal_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expense.CreateLegalExpenseAsync(
    legalExpense: new LegalExpense() {
        Category = "Kids",
        CreatedAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        Currency = "MVR",
        Description = "Temporibus agnitio sui.",
        Id = "97aef49d-e6ae-4f42-b72f-0f4640914372",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-03-30T23:30:33.179Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LegalExpense`                                                                                                                                   | [LegalExpense](../../Models/Components/LegalExpense.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLegalExpenseQueryParamFields](../../Models/Requests/CreateLegalExpenseQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLegalExpenseResponse](../../Models/Requests/CreateLegalExpenseResponse.md)**

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

## GetLegalExpense

Retrieve an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLegalExpense" method="get" path="/legal/{connection_id}/expense/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expense.GetLegalExpenseAsync(
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
| `Fields`                                                                                                                                         | List<[GetLegalExpenseQueryParamFields](../../Models/Requests/GetLegalExpenseQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLegalExpenseResponse](../../Models/Requests/GetLegalExpenseResponse.md)**

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

## ListLegalExpenses

List all expenses

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLegalExpenses" method="get" path="/legal/{connection_id}/expense" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLegalExpensesRequest req = new ListLegalExpensesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Expense.ListLegalExpensesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListLegalExpensesRequest](../../Models/Requests/ListLegalExpensesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListLegalExpensesResponse](../../Models/Requests/ListLegalExpensesResponse.md)**

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
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://rubbery-couch.biz/",
                Id = "f4777b7a-4b23-4c2e-acdf-f7f8251f8575",
                MimeType = "application/pdf",
                Name = "receipt-9696.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://appropriate-smog.biz/",
                Id = "724ceb69-0018-4d7b-80c7-41fed5941d97",
                MimeType = "application/pdf",
                Name = "receipt-9696-1.pdf",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "EXP-38303",
        Id = "3fded96f-7b44-45db-907c-71d797647361",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "1bd6c341-8dd4-4a91-976a-5575888b82fc",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 364.74D,
                UnitAmount = 364.74D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "718f3795-b0b0-455a-832c-ab6856a0e478",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 258.35D,
                UnitAmount = 258.35D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "96a5ec63-7756-4361-b496-1c8eff2c0fa8",
                ItemName = "Conference ticket",
                Notes = "Casus umquam conicio cinis demitto sint.",
                TaxAmount = 0D,
                TotalAmount = 28.14D,
                UnitAmount = 28.14D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "c64853b3-6bdc-41c6-a22b-31238ebc78b1",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 157.04D,
                UnitAmount = 157.04D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3ecac429-4a0f-4147-891b-21d4242a32c0",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 164.02D,
                UnitAmount = 164.02D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "A payment of XPF 714.84 occurred at Bins, Barrows and Koch using a card ending in ****8422 for account ***4614.",
        PaymentMethod = "CASH",
        PostedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Status = AccountingExpenseStatus.Submitted,
        TaxAmount = 0D,
        TotalAmount = 972.29D,
        Type = AccountingExpenseType.Company,
        UpdatedAt = System.DateTime.Parse("2020-09-02T07:17:47.343Z").ToUniversalTime(),
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

## PatchLegalExpense

Update an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLegalExpense" method="patch" path="/legal/{connection_id}/expense/{id}" example="legal_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLegalExpenseRequest req = new PatchLegalExpenseRequest() {
    LegalExpense = new LegalExpense() {
        Category = "Kids",
        CreatedAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        Currency = "MVR",
        Description = "Temporibus agnitio sui.",
        Id = "c4beccdb-3c40-4539-9db2-e9bd2eb61f84",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-03-30T23:30:33.185Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expense.PatchLegalExpenseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchLegalExpenseRequest](../../Models/Requests/PatchLegalExpenseRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchLegalExpenseResponse](../../Models/Requests/PatchLegalExpenseResponse.md)**

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

## RemoveLegalExpense

Remove an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLegalExpense" method="delete" path="/legal/{connection_id}/expense/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expense.RemoveLegalExpenseAsync(
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

**[RemoveLegalExpenseResponse](../../Models/Requests/RemoveLegalExpenseResponse.md)**

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
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://rubbery-couch.biz/",
                Id = "f4777b7a-4b23-4c2e-acdf-f7f8251f8575",
                MimeType = "application/pdf",
                Name = "receipt-9696.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://appropriate-smog.biz/",
                Id = "724ceb69-0018-4d7b-80c7-41fed5941d97",
                MimeType = "application/pdf",
                Name = "receipt-9696-1.pdf",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "EXP-38303",
        Id = "3fded96f-7b44-45db-907c-71d797647361",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "1bd6c341-8dd4-4a91-976a-5575888b82fc",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 364.74D,
                UnitAmount = 364.74D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "718f3795-b0b0-455a-832c-ab6856a0e478",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 258.35D,
                UnitAmount = 258.35D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "96a5ec63-7756-4361-b496-1c8eff2c0fa8",
                ItemName = "Conference ticket",
                Notes = "Casus umquam conicio cinis demitto sint.",
                TaxAmount = 0D,
                TotalAmount = 28.14D,
                UnitAmount = 28.14D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "c64853b3-6bdc-41c6-a22b-31238ebc78b1",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 157.04D,
                UnitAmount = 157.04D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3ecac429-4a0f-4147-891b-21d4242a32c0",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 164.02D,
                UnitAmount = 164.02D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "A payment of XPF 714.84 occurred at Bins, Barrows and Koch using a card ending in ****8422 for account ***4614.",
        PaymentMethod = "CASH",
        PostedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Status = AccountingExpenseStatus.Submitted,
        TaxAmount = 0D,
        TotalAmount = 972.29D,
        Type = AccountingExpenseType.Company,
        UpdatedAt = System.DateTime.Parse("2020-09-02T07:17:47.343Z").ToUniversalTime(),
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

## UpdateLegalExpense

Update an expense

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLegalExpense" method="put" path="/legal/{connection_id}/expense/{id}" example="legal_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLegalExpenseRequest req = new UpdateLegalExpenseRequest() {
    LegalExpense = new LegalExpense() {
        Category = "Kids",
        CreatedAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        Currency = "MVR",
        Description = "Temporibus agnitio sui.",
        Id = "c4beccdb-3c40-4539-9db2-e9bd2eb61f84",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-03-30T23:30:33.185Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expense.UpdateLegalExpenseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateLegalExpenseRequest](../../Models/Requests/UpdateLegalExpenseRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateLegalExpenseResponse](../../Models/Requests/UpdateLegalExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |