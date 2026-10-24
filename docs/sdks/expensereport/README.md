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
        ApprovedAt = System.DateTime.Parse("2021-04-19T21:01:01.716Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "ER-31240",
        Id = "a71d7009-b241-434e-97f7-6cbb8069b27e",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "c171bd7a-6440-4ad8-be94-2fa5a4600571",
                ItemName = "Conference ticket",
                TaxAmount = 0D,
                TotalAmount = 39.9D,
                UnitAmount = 39.9D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "05081e05-93aa-49cc-9a3d-421f65bf97ca",
                ItemName = "Flight",
                Notes = "Soluta omnis dolor.",
                TaxAmount = 0D,
                TotalAmount = 193.17D,
                UnitAmount = 193.17D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "6b94bdb6-bd25-4273-b0c5-5f8fd54adcef",
                ItemName = "Client dinner",
                Notes = "Altus caveo capio.",
                TaxAmount = 0D,
                TotalAmount = 230.12D,
                UnitAmount = 230.12D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "532f97a0-54f4-4461-b8e3-18318982d38a",
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
        ReimbursedAt = System.DateTime.Parse("2021-04-19T21:01:01.716Z").ToUniversalTime(),
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 908.46D,
        UpdatedAt = System.DateTime.Parse("2021-04-19T21:01:01.716Z").ToUniversalTime(),
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
        ApprovedAt = System.DateTime.Parse("2021-04-19T21:01:01.723Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "ER-31240",
        Id = "7a205867-a286-40c2-bdfc-7534b4e9bf22",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "cb508106-b001-4f0a-a7b8-56e8619ca80b",
                ItemName = "Conference ticket",
                TaxAmount = 0D,
                TotalAmount = 39.9D,
                UnitAmount = 39.9D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "23bf67ad-51ec-4f4a-bddd-0d74ef1a1326",
                ItemName = "Flight",
                Notes = "Soluta omnis dolor.",
                TaxAmount = 0D,
                TotalAmount = 193.17D,
                UnitAmount = 193.17D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "7a42889b-cfea-4d3e-b609-dfdbe3e1b8dc",
                ItemName = "Client dinner",
                Notes = "Altus caveo capio.",
                TaxAmount = 0D,
                TotalAmount = 230.12D,
                UnitAmount = 230.12D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "ac035aef-05e9-48cc-8d2d-fff1a6a361d1",
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
        ReimbursedAt = System.DateTime.Parse("2021-04-19T21:01:01.723Z").ToUniversalTime(),
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 908.46D,
        UpdatedAt = System.DateTime.Parse("2021-04-19T21:01:01.723Z").ToUniversalTime(),
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
        ApprovedAt = System.DateTime.Parse("2021-04-19T21:01:01.723Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "GBP",
        ExternalNumber = "ER-31240",
        Id = "7a205867-a286-40c2-bdfc-7534b4e9bf22",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "cb508106-b001-4f0a-a7b8-56e8619ca80b",
                ItemName = "Conference ticket",
                TaxAmount = 0D,
                TotalAmount = 39.9D,
                UnitAmount = 39.9D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "23bf67ad-51ec-4f4a-bddd-0d74ef1a1326",
                ItemName = "Flight",
                Notes = "Soluta omnis dolor.",
                TaxAmount = 0D,
                TotalAmount = 193.17D,
                UnitAmount = 193.17D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "7a42889b-cfea-4d3e-b609-dfdbe3e1b8dc",
                ItemName = "Client dinner",
                Notes = "Altus caveo capio.",
                TaxAmount = 0D,
                TotalAmount = 230.12D,
                UnitAmount = 230.12D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "ac035aef-05e9-48cc-8d2d-fff1a6a361d1",
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
        ReimbursedAt = System.DateTime.Parse("2021-04-19T21:01:01.723Z").ToUniversalTime(),
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 908.46D,
        UpdatedAt = System.DateTime.Parse("2021-04-19T21:01:01.723Z").ToUniversalTime(),
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