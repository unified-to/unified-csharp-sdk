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
                Id = "d6caff66-6267-4d2a-bd73-deb4b6f6f453",
                MimeType = "benevolentia",
                Name = "vespillo",
            },
        },
        BalanceAmount = -1D,
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Currency = "RWF",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2022-11-27T21:25:37.363Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "ff5adbbe-a59f-4a18-a948-7ccf2ffe5114",
        InvoiceNumber = "vinco",
        IsInclusiveOfTax = true,
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Auctus comburo clarus ubi.",
        PaidAmount = 0D,
        PaidAt = System.DateTime.Parse("2022-11-25T15:00:28.871Z").ToUniversalTime(),
        PaymentCollectionMethod = AccountingInvoicePaymentCollectionMethod.SendInvoice,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2026-04-19T11:36:46.352Z").ToUniversalTime(),
        Reference = "adinventitias",
        SalesorderIds = new List<string>() {},
        Send = true,
        Status = AccountingInvoiceStatus.Deleted,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = AccountingInvoiceTerm.Net45,
        TotalAmount = 0D,
        Type = AccountingInvoiceType.Creditmemo,
        UpdatedAt = System.DateTime.Parse("2023-02-08T00:16:38.699Z").ToUniversalTime(),
        Url = "https://gifted-yarmulke.info/",
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
                Id = "6206e73f-6f66-4c49-bd03-5286ff984141",
                MimeType = "benevolentia",
                Name = "vespillo",
            },
        },
        BalanceAmount = -1D,
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Currency = "RWF",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2022-11-27T21:25:37.363Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "9799d7f5-7335-46bb-8bfd-d233ea09773a",
        InvoiceNumber = "vinco",
        IsInclusiveOfTax = true,
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Auctus comburo clarus ubi.",
        PaidAmount = 0D,
        PaidAt = System.DateTime.Parse("2022-11-25T15:00:28.871Z").ToUniversalTime(),
        PaymentCollectionMethod = AccountingInvoicePaymentCollectionMethod.SendInvoice,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2026-04-19T11:36:46.407Z").ToUniversalTime(),
        Reference = "adinventitias",
        SalesorderIds = new List<string>() {},
        Send = true,
        Status = AccountingInvoiceStatus.Deleted,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = AccountingInvoiceTerm.Net45,
        TotalAmount = 0D,
        Type = AccountingInvoiceType.Creditmemo,
        UpdatedAt = System.DateTime.Parse("2023-02-08T00:16:38.703Z").ToUniversalTime(),
        Url = "https://gifted-yarmulke.info/",
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
                Id = "6206e73f-6f66-4c49-bd03-5286ff984141",
                MimeType = "benevolentia",
                Name = "vespillo",
            },
        },
        BalanceAmount = -1D,
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-11-07T14:17:29.587Z").ToUniversalTime(),
        Currency = "RWF",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2022-11-27T21:25:37.363Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "9799d7f5-7335-46bb-8bfd-d233ea09773a",
        InvoiceNumber = "vinco",
        IsInclusiveOfTax = true,
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Auctus comburo clarus ubi.",
        PaidAmount = 0D,
        PaidAt = System.DateTime.Parse("2022-11-25T15:00:28.871Z").ToUniversalTime(),
        PaymentCollectionMethod = AccountingInvoicePaymentCollectionMethod.SendInvoice,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2026-04-19T11:36:46.407Z").ToUniversalTime(),
        Reference = "adinventitias",
        SalesorderIds = new List<string>() {},
        Send = true,
        Status = AccountingInvoiceStatus.Deleted,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = AccountingInvoiceTerm.Net45,
        TotalAmount = 0D,
        Type = AccountingInvoiceType.Creditmemo,
        UpdatedAt = System.DateTime.Parse("2023-02-08T00:16:38.703Z").ToUniversalTime(),
        Url = "https://gifted-yarmulke.info/",
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