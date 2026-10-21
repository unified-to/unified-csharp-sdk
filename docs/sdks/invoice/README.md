# Invoice

## Overview

### Available Operations

* [CreateAccountingInvoice](#createaccountinginvoice) - Create an invoice
* [GetAccountingInvoice](#getaccountinginvoice) - Retrieve an invoice
* [ListAccountingInvoices](#listaccountinginvoices) - List all invoices
* [PatchAccountingInvoice](#patchaccountinginvoice) - Update an invoice
* [RemoveAccountingInvoice](#removeaccountinginvoice) - Remove an invoice
* [UpdateAccountingInvoice](#updateaccountinginvoice) - Update an invoice

## CreateAccountingInvoice

Create an invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingInvoice" method="post" path="/accounting/{connection_id}/invoice" example="accounting_invoice" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Invoice.CreateAccountingInvoiceAsync(
    accountingInvoice: new AccountingInvoice() {
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://glossy-markup.net/",
                Id = "a9ebd48b-e09d-4ec0-9bef-38595f378fa8",
                MimeType = "application/pdf",
                Name = "INV-77705.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://earnest-giggle.net",
                Id = "c6974327-8f04-4f3a-ab72-ca6836768025",
                MimeType = "application/pdf",
                Name = "INV-77705-1.pdf",
            },
        },
        BalanceAmount = 0D,
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Currency = "GBP",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2022-12-07T14:17:29.587Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "0d30a2d0-38fb-4535-a59d-ebfbafcbec49",
        InvoiceNumber = "INV-77705",
        IsInclusiveOfTax = false,
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Adinventitias sursum temptatio auctus comburo clarus ubi deprimo.",
        PaymentCollectionMethod = AccountingInvoicePaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Reference = "PO-2331",
        SalesorderIds = new List<string>() {},
        Send = true,
        Status = AccountingInvoiceStatus.Overdue,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = AccountingInvoiceTerm.Net25,
        TotalAmount = 0D,
        Type = AccountingInvoiceType.Invoice,
        UpdatedAt = System.DateTime.Parse("2026-04-23T13:18:03.543Z").ToUniversalTime(),
        Url = "https://gifted-yarmulke.info/invoices/INV-77705",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingInvoice`                                                                                                                              | [AccountingInvoice](../../Models/Components/AccountingInvoice.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingInvoiceQueryParamFields](../../Models/Requests/CreateAccountingInvoiceQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingInvoiceResponse](../../Models/Requests/CreateAccountingInvoiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingInvoice

Retrieve an invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingInvoice" method="get" path="/accounting/{connection_id}/invoice/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Invoice.GetAccountingInvoiceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Invoice                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAccountingInvoiceQueryParamFields](../../Models/Requests/GetAccountingInvoiceQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingInvoiceResponse](../../Models/Requests/GetAccountingInvoiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingInvoices

List all invoices

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingInvoices" method="get" path="/accounting/{connection_id}/invoice" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Invoice.ListAccountingInvoicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingInvoicesRequest](../../Models/Requests/ListAccountingInvoicesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingInvoicesResponse](../../Models/Requests/ListAccountingInvoicesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingInvoice

Update an invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingInvoice" method="patch" path="/accounting/{connection_id}/invoice/{id}" example="accounting_invoice" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingInvoiceRequest req = new PatchAccountingInvoiceRequest() {
    AccountingInvoice = new AccountingInvoice() {
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://glossy-markup.net/",
                Id = "aa647b3d-4b70-40c0-8dce-d5b766aed94e",
                MimeType = "application/pdf",
                Name = "INV-77705.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://earnest-giggle.net",
                Id = "b96e3544-c6c2-4828-b0c3-29dfedeac592",
                MimeType = "application/pdf",
                Name = "INV-77705-1.pdf",
            },
        },
        BalanceAmount = 0D,
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Currency = "GBP",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2022-12-07T14:17:29.587Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "15765a96-e0d7-4c05-a327-99bb80ccd290",
        InvoiceNumber = "INV-77705",
        IsInclusiveOfTax = false,
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Adinventitias sursum temptatio auctus comburo clarus ubi deprimo.",
        PaymentCollectionMethod = AccountingInvoicePaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Reference = "PO-2331",
        SalesorderIds = new List<string>() {},
        Send = true,
        Status = AccountingInvoiceStatus.Overdue,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = AccountingInvoiceTerm.Net25,
        TotalAmount = 0D,
        Type = AccountingInvoiceType.Invoice,
        UpdatedAt = System.DateTime.Parse("2026-04-23T13:18:03.577Z").ToUniversalTime(),
        Url = "https://gifted-yarmulke.info/invoices/INV-77705",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Invoice.PatchAccountingInvoiceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingInvoiceRequest](../../Models/Requests/PatchAccountingInvoiceRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingInvoiceResponse](../../Models/Requests/PatchAccountingInvoiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingInvoice

Remove an invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingInvoice" method="delete" path="/accounting/{connection_id}/invoice/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Invoice.RemoveAccountingInvoiceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Invoice    |

### Response

**[RemoveAccountingInvoiceResponse](../../Models/Requests/RemoveAccountingInvoiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingInvoice

Update an invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingInvoice" method="put" path="/accounting/{connection_id}/invoice/{id}" example="accounting_invoice" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingInvoiceRequest req = new UpdateAccountingInvoiceRequest() {
    AccountingInvoice = new AccountingInvoice() {
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://glossy-markup.net/",
                Id = "aa647b3d-4b70-40c0-8dce-d5b766aed94e",
                MimeType = "application/pdf",
                Name = "INV-77705.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://earnest-giggle.net",
                Id = "b96e3544-c6c2-4828-b0c3-29dfedeac592",
                MimeType = "application/pdf",
                Name = "INV-77705-1.pdf",
            },
        },
        BalanceAmount = 0D,
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Currency = "GBP",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2022-12-07T14:17:29.587Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "15765a96-e0d7-4c05-a327-99bb80ccd290",
        InvoiceNumber = "INV-77705",
        IsInclusiveOfTax = false,
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Adinventitias sursum temptatio auctus comburo clarus ubi deprimo.",
        PaymentCollectionMethod = AccountingInvoicePaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Reference = "PO-2331",
        SalesorderIds = new List<string>() {},
        Send = true,
        Status = AccountingInvoiceStatus.Overdue,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = AccountingInvoiceTerm.Net25,
        TotalAmount = 0D,
        Type = AccountingInvoiceType.Invoice,
        UpdatedAt = System.DateTime.Parse("2026-04-23T13:18:03.577Z").ToUniversalTime(),
        Url = "https://gifted-yarmulke.info/invoices/INV-77705",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Invoice.UpdateAccountingInvoiceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingInvoiceRequest](../../Models/Requests/UpdateAccountingInvoiceRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingInvoiceResponse](../../Models/Requests/UpdateAccountingInvoiceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |