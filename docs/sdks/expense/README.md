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

Creates a AccountingExpense. Provide the unified AccountingExpense fields in the request body; they are mapped to the provider's API. Returns the created AccountingExpense.

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
                Id = "f8d11138-8d55-4d4a-b73b-37edd7d95087",
                MimeType = "application/pdf",
                Name = "receipt-9696.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://appropriate-smog.biz/",
                Id = "32089fa4-7f77-4c2d-b12f-18eed9ed8ab2",
                MimeType = "application/pdf",
                Name = "receipt-9696-1.pdf",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "EXP-38303",
        Id = "89753e08-1355-4048-ab7e-95e42e2b5ca9",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "ce6e1dc0-72a1-4419-82d7-9949ed39c774",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 364.74D,
                UnitAmount = 364.74D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3dd8e649-8cd3-4b6a-a24f-eb7bccf41bf8",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 258.35D,
                UnitAmount = 258.35D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "f5f7b083-882f-41a8-8249-c2fa396ccc13",
                ItemName = "Conference ticket",
                Notes = "Casus umquam conicio cinis demitto sint.",
                TaxAmount = 0D,
                TotalAmount = 28.14D,
                UnitAmount = 28.14D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "e0f738b6-6ea4-4ac5-9819-6ad22a484a56",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 157.04D,
                UnitAmount = 157.04D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "4d3b7b23-0969-4fb9-b31f-b145f6a7e239",
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
        UpdatedAt = System.DateTime.Parse("2020-09-02T10:42:19.226Z").ToUniversalTime(),
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

Creates a LegalExpense. Provide the unified LegalExpense fields in the request body; they are mapped to the provider's API. Returns the created LegalExpense.

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
        Id = "ade21f48-65c6-46ae-acc7-0f42d68d2d7c",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-04-02T05:48:15.626Z").ToUniversalTime(),
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

Retrieves a single AccountingExpense by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single LegalExpense by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AccountingExpenses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of LegalExpenses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the AccountingExpense identified by `id`. Provide the unified AccountingExpense fields to change in the request body.

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
                Id = "99748fd4-f8ec-4312-9186-1ba69b63635f",
                MimeType = "application/pdf",
                Name = "receipt-9696.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://appropriate-smog.biz/",
                Id = "21f4a72d-5d16-4b3b-a539-a824ef5dcaad",
                MimeType = "application/pdf",
                Name = "receipt-9696-1.pdf",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "EXP-38303",
        Id = "c5fc6834-f2a8-409f-8ffd-ba80d0e61d4e",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "1af2e7ae-c128-41f0-a991-ba45126a6bc7",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 364.74D,
                UnitAmount = 364.74D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3b175678-9479-470e-b3b6-1ce3d4c4b2f9",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 258.35D,
                UnitAmount = 258.35D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3c68b7b8-47ae-4bd1-bcdc-70e063e40894",
                ItemName = "Conference ticket",
                Notes = "Casus umquam conicio cinis demitto sint.",
                TaxAmount = 0D,
                TotalAmount = 28.14D,
                UnitAmount = 28.14D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "ef767cb3-905e-4040-b014-5ee6819d4fc7",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 157.04D,
                UnitAmount = 157.04D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "03649691-d516-4e7e-9362-43556c23946c",
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
        UpdatedAt = System.DateTime.Parse("2020-09-02T10:42:19.227Z").ToUniversalTime(),
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

Updates the LegalExpense identified by `id`. Provide the unified LegalExpense fields to change in the request body.

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
        Id = "f551c17f-52f3-4295-adaa-bf42a49520ad",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-04-02T05:48:15.633Z").ToUniversalTime(),
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

Deletes the AccountingExpense identified by `id`.

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

Deletes the LegalExpense identified by `id`.

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

Updates the AccountingExpense identified by `id`. Provide the unified AccountingExpense fields to change in the request body.

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
                Id = "99748fd4-f8ec-4312-9186-1ba69b63635f",
                MimeType = "application/pdf",
                Name = "receipt-9696.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://appropriate-smog.biz/",
                Id = "21f4a72d-5d16-4b3b-a539-a824ef5dcaad",
                MimeType = "application/pdf",
                Name = "receipt-9696-1.pdf",
            },
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-06-11T03:39:37.305Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "EXP-38303",
        Id = "c5fc6834-f2a8-409f-8ffd-ba80d0e61d4e",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "1af2e7ae-c128-41f0-a991-ba45126a6bc7",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 364.74D,
                UnitAmount = 364.74D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3b175678-9479-470e-b3b6-1ce3d4c4b2f9",
                ItemName = "Client dinner",
                TaxAmount = 0D,
                TotalAmount = 258.35D,
                UnitAmount = 258.35D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3c68b7b8-47ae-4bd1-bcdc-70e063e40894",
                ItemName = "Conference ticket",
                Notes = "Casus umquam conicio cinis demitto sint.",
                TaxAmount = 0D,
                TotalAmount = 28.14D,
                UnitAmount = 28.14D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "ef767cb3-905e-4040-b014-5ee6819d4fc7",
                ItemName = "Hotel",
                TaxAmount = 0D,
                TotalAmount = 157.04D,
                UnitAmount = 157.04D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "03649691-d516-4e7e-9362-43556c23946c",
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
        UpdatedAt = System.DateTime.Parse("2020-09-02T10:42:19.227Z").ToUniversalTime(),
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

Updates the LegalExpense identified by `id`. Provide the unified LegalExpense fields to change in the request body.

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
        Id = "f551c17f-52f3-4295-adaa-bf42a49520ad",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-04-02T05:48:15.633Z").ToUniversalTime(),
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