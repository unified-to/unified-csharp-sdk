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

Create a bill

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
                Id = "c1605439-f179-4b3b-a6d9-8587613faf73",
                MimeType = "application/pdf",
                Name = "BILL-2466.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://grimy-characterization.net",
                Id = "290d1f1a-3fa9-4564-be9d-4502bd742b86",
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
        Id = "d9cb1af0-bd77-4c74-b2a5-f03af0568090",
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
        UpdatedAt = System.DateTime.Parse("2020-06-01T05:49:59.569Z").ToUniversalTime(),
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

Retrieve a bill

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

List all bills

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

Update a bill

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
                Id = "51a75033-e2d6-49dd-ace9-a977d4ffdc6e",
                MimeType = "application/pdf",
                Name = "BILL-2466.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://grimy-characterization.net",
                Id = "e8f20ea6-5f59-4ba1-b28e-d2fe679e3bc0",
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
        Id = "08832535-f5cd-4ae9-bca0-79b5152b1867",
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
        UpdatedAt = System.DateTime.Parse("2020-06-01T05:49:59.573Z").ToUniversalTime(),
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

Remove a bill

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

Update a bill

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
                Id = "51a75033-e2d6-49dd-ace9-a977d4ffdc6e",
                MimeType = "application/pdf",
                Name = "BILL-2466.pdf",
            },
            new AccountingAttachment() {
                DownloadUrl = "https://grimy-characterization.net",
                Id = "e8f20ea6-5f59-4ba1-b28e-d2fe679e3bc0",
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
        Id = "08832535-f5cd-4ae9-bca0-79b5152b1867",
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
        UpdatedAt = System.DateTime.Parse("2020-06-01T05:49:59.573Z").ToUniversalTime(),
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