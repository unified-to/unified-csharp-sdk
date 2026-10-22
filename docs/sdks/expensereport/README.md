# Expensereport

## Overview

### Available Operations

* [CreateAccountingExpensereport](#createaccountingexpensereport) - Create an expensereport
* [GetAccountingExpensereport](#getaccountingexpensereport) - Retrieve an expensereport
* [ListAccountingExpensereports](#listaccountingexpensereports) - List all expensereports
* [PatchAccountingExpensereport](#patchaccountingexpensereport) - Update an expensereport
* [RemoveAccountingExpensereport](#removeaccountingexpensereport) - Remove an expensereport
* [UpdateAccountingExpensereport](#updateaccountingexpensereport) - Update an expensereport

## CreateAccountingExpensereport

Creates a AccountingExpensereport. Provide the unified AccountingExpensereport fields in the request body; they are mapped to the provider's API. Returns the created AccountingExpensereport.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingExpensereport" method="post" path="/accounting/{connection_id}/expensereport" example="accounting_expensereport" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expensereport.CreateAccountingExpensereportAsync(
    accountingExpensereport: new AccountingExpensereport() {
        ApprovedAt = System.DateTime.Parse("2021-04-19T14:32:12.741Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "ER-31240",
        Id = "238a1a44-7f7f-462b-b701-2f2e241db582",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "1404d37f-1948-4ba9-b14f-123b62fca880",
                ItemName = "Conference ticket",
                TaxAmount = 0D,
                TotalAmount = 39.9D,
                UnitAmount = 39.9D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "76703a5c-32ac-4782-92d5-99306fbf107f",
                ItemName = "Flight",
                Notes = "Soluta omnis dolor.",
                TaxAmount = 0D,
                TotalAmount = 193.17D,
                UnitAmount = 193.17D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "5146710a-23f8-47d8-a6b2-9d9678db401e",
                ItemName = "Client dinner",
                Notes = "Altus caveo capio.",
                TaxAmount = 0D,
                TotalAmount = 230.12D,
                UnitAmount = 230.12D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "d90b20f9-0e54-4bf2-81bb-29bd3fbddbcc",
                ItemName = "Flight",
                TaxAmount = 0D,
                TotalAmount = 445.27D,
                UnitAmount = 445.27D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Lolita Kunde - October expenses",
        PostedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        ReimbursedAmount = 908.46D,
        ReimbursedAt = System.DateTime.Parse("2021-04-19T14:32:12.741Z").ToUniversalTime(),
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 908.46D,
        UpdatedAt = System.DateTime.Parse("2021-04-19T14:32:12.741Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingExpensereport`                                                                                                                        | [AccountingExpensereport](../../Models/Components/AccountingExpensereport.md)                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingExpensereportQueryParamFields](../../Models/Requests/CreateAccountingExpensereportQueryParamFields.md)>                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingExpensereportResponse](../../Models/Requests/CreateAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingExpensereport

Retrieves a single AccountingExpensereport by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingExpensereport" method="get" path="/accounting/{connection_id}/expensereport/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expensereport.GetAccountingExpensereportAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Expensereport                                                                                                                          |
| `Fields`                                                                                                                                         | List<[GetAccountingExpensereportQueryParamFields](../../Models/Requests/GetAccountingExpensereportQueryParamFields.md)>                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingExpensereportResponse](../../Models/Requests/GetAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingExpensereports

Returns a list of AccountingExpensereports. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingExpensereports" method="get" path="/accounting/{connection_id}/expensereport" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingExpensereportsRequest req = new ListAccountingExpensereportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Expensereport.ListAccountingExpensereportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListAccountingExpensereportsRequest](../../Models/Requests/ListAccountingExpensereportsRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[ListAccountingExpensereportsResponse](../../Models/Requests/ListAccountingExpensereportsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingExpensereport

Updates the AccountingExpensereport identified by `id`. Provide the unified AccountingExpensereport fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingExpensereport" method="patch" path="/accounting/{connection_id}/expensereport/{id}" example="accounting_expensereport" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingExpensereportRequest req = new PatchAccountingExpensereportRequest() {
    AccountingExpensereport = new AccountingExpensereport() {
        ApprovedAt = System.DateTime.Parse("2021-04-19T14:32:12.745Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "ER-31240",
        Id = "a6e871ce-b3b3-4282-a867-47f688257392",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "ee7efd51-b0fa-4ad8-9f5e-f3117c432135",
                ItemName = "Conference ticket",
                TaxAmount = 0D,
                TotalAmount = 39.9D,
                UnitAmount = 39.9D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "efc7d06b-39f3-4b86-ae22-f7640401476a",
                ItemName = "Flight",
                Notes = "Soluta omnis dolor.",
                TaxAmount = 0D,
                TotalAmount = 193.17D,
                UnitAmount = 193.17D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "c7892a65-a617-439e-9f4a-3b1200aea1c8",
                ItemName = "Client dinner",
                Notes = "Altus caveo capio.",
                TaxAmount = 0D,
                TotalAmount = 230.12D,
                UnitAmount = 230.12D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3d289400-bff9-4f84-b3d7-094fc7dc67ad",
                ItemName = "Flight",
                TaxAmount = 0D,
                TotalAmount = 445.27D,
                UnitAmount = 445.27D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Lolita Kunde - October expenses",
        PostedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        ReimbursedAmount = 908.46D,
        ReimbursedAt = System.DateTime.Parse("2021-04-19T14:32:12.745Z").ToUniversalTime(),
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 908.46D,
        UpdatedAt = System.DateTime.Parse("2021-04-19T14:32:12.745Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expensereport.PatchAccountingExpensereportAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [PatchAccountingExpensereportRequest](../../Models/Requests/PatchAccountingExpensereportRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[PatchAccountingExpensereportResponse](../../Models/Requests/PatchAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingExpensereport

Deletes the AccountingExpensereport identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingExpensereport" method="delete" path="/accounting/{connection_id}/expensereport/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expensereport.RemoveAccountingExpensereportAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter               | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `ConnectionId`          | *string*                | :heavy_check_mark:      | ID of the connection    |
| `Id`                    | *string*                | :heavy_check_mark:      | ID of the Expensereport |

### Response

**[RemoveAccountingExpensereportResponse](../../Models/Requests/RemoveAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingExpensereport

Updates the AccountingExpensereport identified by `id`. Provide the unified AccountingExpensereport fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingExpensereport" method="put" path="/accounting/{connection_id}/expensereport/{id}" example="accounting_expensereport" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingExpensereportRequest req = new UpdateAccountingExpensereportRequest() {
    AccountingExpensereport = new AccountingExpensereport() {
        ApprovedAt = System.DateTime.Parse("2021-04-19T14:32:12.745Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "ER-31240",
        Id = "a6e871ce-b3b3-4282-a867-47f688257392",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "ee7efd51-b0fa-4ad8-9f5e-f3117c432135",
                ItemName = "Conference ticket",
                TaxAmount = 0D,
                TotalAmount = 39.9D,
                UnitAmount = 39.9D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "efc7d06b-39f3-4b86-ae22-f7640401476a",
                ItemName = "Flight",
                Notes = "Soluta omnis dolor.",
                TaxAmount = 0D,
                TotalAmount = 193.17D,
                UnitAmount = 193.17D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "c7892a65-a617-439e-9f4a-3b1200aea1c8",
                ItemName = "Client dinner",
                Notes = "Altus caveo capio.",
                TaxAmount = 0D,
                TotalAmount = 230.12D,
                UnitAmount = 230.12D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "3d289400-bff9-4f84-b3d7-094fc7dc67ad",
                ItemName = "Flight",
                TaxAmount = 0D,
                TotalAmount = 445.27D,
                UnitAmount = 445.27D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Lolita Kunde - October expenses",
        PostedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        ReimbursedAmount = 908.46D,
        ReimbursedAt = System.DateTime.Parse("2021-04-19T14:32:12.745Z").ToUniversalTime(),
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 908.46D,
        UpdatedAt = System.DateTime.Parse("2021-04-19T14:32:12.745Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expensereport.UpdateAccountingExpensereportAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [UpdateAccountingExpensereportRequest](../../Models/Requests/UpdateAccountingExpensereportRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[UpdateAccountingExpensereportResponse](../../Models/Requests/UpdateAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |