# Bill

## Overview

### Available Operations

* [CreateAccountingBill](#createaccountingbill) - Create a bill
* [GetAccountingBill](#getaccountingbill) - Retrieve a bill
* [ListAccountingBills](#listaccountingbills) - List all bills
* [PatchAccountingBill](#patchaccountingbill) - Update a bill
* [RemoveAccountingBill](#removeaccountingbill) - Remove a bill
* [UpdateAccountingBill](#updateaccountingbill) - Update a bill

## CreateAccountingBill

Creates a AccountingBill. Provide the unified AccountingBill fields in the request body; they are mapped to the provider's API. Returns the created AccountingBill.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingBill" method="post" path="/accounting/{connection_id}/bill" example="accounting_bill" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bill.CreateAccountingBillAsync(
    accountingBill: new AccountingBill() {
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://puny-foodstuffs.name",
                Id = "9771cf67-998b-4c89-afc8-179118421bee",
                MimeType = "application/pdf",
                Name = "BILL-2466.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://grimy-characterization.net",
                Id = "ed2c2e45-5b8d-40f6-b9b4-2df8afcaa9ea",
                MimeType = "application/pdf",
                Name = "BILL-2466-1.pdf",
            },
        },
        BalanceAmount = 0D,
        BillNumber = "BILL-2466",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        Currency = "USD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2019-09-07T23:03:14.104Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "12450d6f-7695-4153-9be9-6ca9d6f03f19",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Admiratio deporto tutamen cilicium infit amissio ante demulceo.",
        PaidAmount = 0D,
        PaidAt = System.DateTime.Parse("2019-08-15T17:24:28.313Z").ToUniversalTime(),
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        PurchaseorderIds = new List<string>() {},
        Send = true,
        Status = AccountingBillStatus.PartiallyPaid,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = Term.Net90,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2020-06-01T21:48:32.340Z").ToUniversalTime(),
        Url = "https://cluttered-importance.org/bills/BILL-2466",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingBill`                                                                                                                                 | [AccountingBill](../../Models/Components/AccountingBill.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingBillQueryParamFields](../../Models/Requests/CreateAccountingBillQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingBillResponse](../../Models/Requests/CreateAccountingBillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingBill

Retrieves a single AccountingBill by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingBill" method="get" path="/accounting/{connection_id}/bill/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bill.GetAccountingBillAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Bill                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetAccountingBillQueryParamFields](../../Models/Requests/GetAccountingBillQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingBillResponse](../../Models/Requests/GetAccountingBillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingBills

Returns a list of AccountingBills. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingBills" method="get" path="/accounting/{connection_id}/bill" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingBillsRequest req = new ListAccountingBillsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Bill.ListAccountingBillsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAccountingBillsRequest](../../Models/Requests/ListAccountingBillsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListAccountingBillsResponse](../../Models/Requests/ListAccountingBillsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingBill

Updates the AccountingBill identified by `id`. Provide the unified AccountingBill fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingBill" method="patch" path="/accounting/{connection_id}/bill/{id}" example="accounting_bill" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingBillRequest req = new PatchAccountingBillRequest() {
    AccountingBill = new AccountingBill() {
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://puny-foodstuffs.name",
                Id = "f222bf53-12f4-4b3e-9b63-c7dae525b4ef",
                MimeType = "application/pdf",
                Name = "BILL-2466.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://grimy-characterization.net",
                Id = "9551e4d6-cac7-4596-8ea5-6ad169b78f6b",
                MimeType = "application/pdf",
                Name = "BILL-2466-1.pdf",
            },
        },
        BalanceAmount = 0D,
        BillNumber = "BILL-2466",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        Currency = "USD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2019-09-07T23:03:14.104Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "b8a0ba3b-fb5d-4212-a61c-435e9259e166",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Admiratio deporto tutamen cilicium infit amissio ante demulceo.",
        PaidAmount = 0D,
        PaidAt = System.DateTime.Parse("2019-08-15T17:24:28.313Z").ToUniversalTime(),
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        PurchaseorderIds = new List<string>() {},
        Send = true,
        Status = AccountingBillStatus.PartiallyPaid,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = Term.Net90,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2020-06-01T21:48:32.347Z").ToUniversalTime(),
        Url = "https://cluttered-importance.org/bills/BILL-2466",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bill.PatchAccountingBillAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchAccountingBillRequest](../../Models/Requests/PatchAccountingBillRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchAccountingBillResponse](../../Models/Requests/PatchAccountingBillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingBill

Deletes the AccountingBill identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingBill" method="delete" path="/accounting/{connection_id}/bill/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bill.RemoveAccountingBillAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Bill       |

### Response

**[RemoveAccountingBillResponse](../../Models/Requests/RemoveAccountingBillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingBill

Updates the AccountingBill identified by `id`. Provide the unified AccountingBill fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingBill" method="put" path="/accounting/{connection_id}/bill/{id}" example="accounting_bill" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingBillRequest req = new UpdateAccountingBillRequest() {
    AccountingBill = new AccountingBill() {
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://puny-foodstuffs.name",
                Id = "f222bf53-12f4-4b3e-9b63-c7dae525b4ef",
                MimeType = "application/pdf",
                Name = "BILL-2466.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://grimy-characterization.net",
                Id = "9551e4d6-cac7-4596-8ea5-6ad169b78f6b",
                MimeType = "application/pdf",
                Name = "BILL-2466-1.pdf",
            },
        },
        BalanceAmount = 0D,
        BillNumber = "BILL-2466",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        Currency = "USD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2019-09-07T23:03:14.104Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "b8a0ba3b-fb5d-4212-a61c-435e9259e166",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Admiratio deporto tutamen cilicium infit amissio ante demulceo.",
        PaidAmount = 0D,
        PaidAt = System.DateTime.Parse("2019-08-15T17:24:28.313Z").ToUniversalTime(),
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        PurchaseorderIds = new List<string>() {},
        Send = true,
        Status = AccountingBillStatus.PartiallyPaid,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = Term.Net90,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2020-06-01T21:48:32.347Z").ToUniversalTime(),
        Url = "https://cluttered-importance.org/bills/BILL-2466",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bill.UpdateAccountingBillAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateAccountingBillRequest](../../Models/Requests/UpdateAccountingBillRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateAccountingBillResponse](../../Models/Requests/UpdateAccountingBillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |