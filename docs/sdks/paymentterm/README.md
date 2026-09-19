# Paymentterm

## Overview

### Available Operations

* [CreateAccountingPaymentterm](#createaccountingpaymentterm) - Create a paymentterm
* [GetAccountingPaymentterm](#getaccountingpaymentterm) - Retrieve a paymentterm
* [ListAccountingPaymentterms](#listaccountingpaymentterms) - List all paymentterms
* [PatchAccountingPaymentterm](#patchaccountingpaymentterm) - Update a paymentterm
* [RemoveAccountingPaymentterm](#removeaccountingpaymentterm) - Remove a paymentterm
* [UpdateAccountingPaymentterm](#updateaccountingpaymentterm) - Update a paymentterm

## CreateAccountingPaymentterm

Create a paymentterm

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingPaymentterm" method="post" path="/accounting/{connection_id}/paymentterm" example="accounting_paymentterm" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Paymentterm.CreateAccountingPaymenttermAsync(
    accountingPaymentterm: new AccountingPaymentterm() {
        Category = UnifiedTo.Models.Components.Category.Standard,
        CreatedAt = System.DateTime.Parse("2021-08-22T22:42:42.265Z").ToUniversalTime(),
        DayOfMonthDue = 4D,
        Description = "Cogito pecco eos cultura.",
        DiscountDayOfMonth = 13D,
        DiscountDays = 4D,
        DiscountPercent = 5D,
        DueDays = 57D,
        DueNextMonthDays = 9D,
        Id = "06734b3d-0b06-494e-86a0-fa4f90472d08",
        IsActive = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Net 30",
        Type = AccountingPaymenttermType.Net15,
        UpdatedAt = System.DateTime.Parse("2025-12-12T07:18:03.363Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingPaymentterm`                                                                                                                          | [AccountingPaymentterm](../../Models/Components/AccountingPaymentterm.md)                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingPaymenttermQueryParamFields](../../Models/Requests/CreateAccountingPaymenttermQueryParamFields.md)>                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingPaymenttermResponse](../../Models/Requests/CreateAccountingPaymenttermResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingPaymentterm

Retrieve a paymentterm

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingPaymentterm" method="get" path="/accounting/{connection_id}/paymentterm/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Paymentterm.GetAccountingPaymenttermAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Paymentterm                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetAccountingPaymenttermQueryParamFields](../../Models/Requests/GetAccountingPaymenttermQueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingPaymenttermResponse](../../Models/Requests/GetAccountingPaymenttermResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingPaymentterms

List all paymentterms

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingPaymentterms" method="get" path="/accounting/{connection_id}/paymentterm" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingPaymenttermsRequest req = new ListAccountingPaymenttermsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Paymentterm.ListAccountingPaymenttermsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingPaymenttermsRequest](../../Models/Requests/ListAccountingPaymenttermsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListAccountingPaymenttermsResponse](../../Models/Requests/ListAccountingPaymenttermsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingPaymentterm

Update a paymentterm

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingPaymentterm" method="patch" path="/accounting/{connection_id}/paymentterm/{id}" example="accounting_paymentterm" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingPaymenttermRequest req = new PatchAccountingPaymenttermRequest() {
    AccountingPaymentterm = new AccountingPaymentterm() {
        Category = UnifiedTo.Models.Components.Category.Standard,
        CreatedAt = System.DateTime.Parse("2021-08-22T22:42:42.265Z").ToUniversalTime(),
        DayOfMonthDue = 4D,
        Description = "Cogito pecco eos cultura.",
        DiscountDayOfMonth = 13D,
        DiscountDays = 4D,
        DiscountPercent = 5D,
        DueDays = 57D,
        DueNextMonthDays = 9D,
        Id = "ab5a0f1f-8d4f-4a8a-a1f0-75ed662cd192",
        IsActive = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Net 30",
        Type = AccountingPaymenttermType.Net15,
        UpdatedAt = System.DateTime.Parse("2025-12-12T07:18:03.378Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Paymentterm.PatchAccountingPaymenttermAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [PatchAccountingPaymenttermRequest](../../Models/Requests/PatchAccountingPaymenttermRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[PatchAccountingPaymenttermResponse](../../Models/Requests/PatchAccountingPaymenttermResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingPaymentterm

Remove a paymentterm

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingPaymentterm" method="delete" path="/accounting/{connection_id}/paymentterm/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Paymentterm.RemoveAccountingPaymenttermAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Paymentterm |

### Response

**[RemoveAccountingPaymenttermResponse](../../Models/Requests/RemoveAccountingPaymenttermResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingPaymentterm

Update a paymentterm

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingPaymentterm" method="put" path="/accounting/{connection_id}/paymentterm/{id}" example="accounting_paymentterm" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingPaymenttermRequest req = new UpdateAccountingPaymenttermRequest() {
    AccountingPaymentterm = new AccountingPaymentterm() {
        Category = UnifiedTo.Models.Components.Category.Standard,
        CreatedAt = System.DateTime.Parse("2021-08-22T22:42:42.265Z").ToUniversalTime(),
        DayOfMonthDue = 4D,
        Description = "Cogito pecco eos cultura.",
        DiscountDayOfMonth = 13D,
        DiscountDays = 4D,
        DiscountPercent = 5D,
        DueDays = 57D,
        DueNextMonthDays = 9D,
        Id = "ab5a0f1f-8d4f-4a8a-a1f0-75ed662cd192",
        IsActive = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Net 30",
        Type = AccountingPaymenttermType.Net15,
        UpdatedAt = System.DateTime.Parse("2025-12-12T07:18:03.378Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Paymentterm.UpdateAccountingPaymenttermAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [UpdateAccountingPaymenttermRequest](../../Models/Requests/UpdateAccountingPaymenttermRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[UpdateAccountingPaymenttermResponse](../../Models/Requests/UpdateAccountingPaymenttermResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |