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
        Attachments = new List<AccountingAttachment>() {},
        BillNumber = "vitae",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        Currency = "AUD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2019-08-11T20:52:55.321Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "339a5fd3-7fbe-4871-95ba-b75769001fca",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Tutamen cilicium infit.",
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2024-04-19T08:55:21.037Z").ToUniversalTime(),
        PurchaseorderIds = new List<string>() {},
        Send = true,
        Status = AccountingBillStatus.Deleted,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = Term.Net10,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-02-15T18:13:43.875Z").ToUniversalTime(),
        Url = "https://coarse-interviewer.biz/",
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
        Attachments = new List<AccountingAttachment>() {},
        BillNumber = "vitae",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        Currency = "AUD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2019-08-11T20:52:55.321Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "687c6fa9-67b0-43b9-b80f-ee40f2bcb790",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Tutamen cilicium infit.",
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2024-04-19T08:55:21.062Z").ToUniversalTime(),
        PurchaseorderIds = new List<string>() {},
        Send = true,
        Status = AccountingBillStatus.Deleted,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = Term.Net10,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-02-15T18:13:43.905Z").ToUniversalTime(),
        Url = "https://coarse-interviewer.biz/",
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
        Attachments = new List<AccountingAttachment>() {},
        BillNumber = "vitae",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-08-08T23:03:14.104Z").ToUniversalTime(),
        Currency = "AUD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2019-08-11T20:52:55.321Z").ToUniversalTime(),
        ExtendedNotes = new List<AccountingExtendedNote>() {},
        Id = "687c6fa9-67b0-43b9-b80f-ee40f2bcb790",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Tutamen cilicium infit.",
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2024-04-19T08:55:21.062Z").ToUniversalTime(),
        PurchaseorderIds = new List<string>() {},
        Send = true,
        Status = AccountingBillStatus.Deleted,
        SubTotalAmount = 0D,
        TaxAmount = 0D,
        Term = Term.Net10,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-02-15T18:13:43.905Z").ToUniversalTime(),
        Url = "https://coarse-interviewer.biz/",
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