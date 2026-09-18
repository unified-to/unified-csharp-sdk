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
        Id = "100144ed-c290-4ba0-8c70-172d5b231a02",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Tutamen cilicium infit.",
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2024-04-04T07:23:49.049Z").ToUniversalTime(),
        Send = true,
        Status = AccountingBillStatus.Deleted,
        TaxAmount = 0D,
        Term = Term.Net10,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-01-29T00:58:28.612Z").ToUniversalTime(),
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
        Id = "6150e708-f7e3-4cf9-8e91-303495e24cc3",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Tutamen cilicium infit.",
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2024-04-04T07:23:49.078Z").ToUniversalTime(),
        Send = true,
        Status = AccountingBillStatus.Deleted,
        TaxAmount = 0D,
        Term = Term.Net10,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-01-29T00:58:28.647Z").ToUniversalTime(),
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
        Id = "6150e708-f7e3-4cf9-8e91-303495e24cc3",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Tutamen cilicium infit.",
        PaymentCollectionMethod = PaymentCollectionMethod.ChargeAutomatically,
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2024-04-04T07:23:49.078Z").ToUniversalTime(),
        Send = true,
        Status = AccountingBillStatus.Deleted,
        TaxAmount = 0D,
        Term = Term.Net10,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-01-29T00:58:28.647Z").ToUniversalTime(),
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