# Payment

## Overview

### Available Operations

* [CreatePaymentLink](#createpaymentlink) - Create a link
* [CreatePaymentPayment](#createpaymentpayment) - Create a payment
* [CreatePaymentSubscription](#createpaymentsubscription) - Create a subscription
* [GetPaymentLink](#getpaymentlink) - Retrieve a link
* [GetPaymentPayment](#getpaymentpayment) - Retrieve a payment
* [GetPaymentPayout](#getpaymentpayout) - Retrieve a payout
* [GetPaymentRefund](#getpaymentrefund) - Retrieve a refund
* [GetPaymentSubscription](#getpaymentsubscription) - Retrieve a subscription
* [ListPaymentLinks](#listpaymentlinks) - List all links
* [ListPaymentPayments](#listpaymentpayments) - List all payments
* [ListPaymentPayouts](#listpaymentpayouts) - List all payouts
* [ListPaymentRefunds](#listpaymentrefunds) - List all refunds
* [ListPaymentSubscriptions](#listpaymentsubscriptions) - List all subscriptions
* [PatchPaymentLink](#patchpaymentlink) - Update a link
* [PatchPaymentPayment](#patchpaymentpayment) - Update a payment
* [PatchPaymentSubscription](#patchpaymentsubscription) - Update a subscription
* [RemovePaymentLink](#removepaymentlink) - Remove a link
* [RemovePaymentPayment](#removepaymentpayment) - Remove a payment
* [RemovePaymentSubscription](#removepaymentsubscription) - Remove a subscription
* [UpdatePaymentLink](#updatepaymentlink) - Update a link
* [UpdatePaymentPayment](#updatepaymentpayment) - Update a payment
* [UpdatePaymentSubscription](#updatepaymentsubscription) - Update a subscription

## CreatePaymentLink

Create a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPaymentLink" method="post" path="/payment/{connection_id}/link" example="payment_link" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.CreatePaymentLinkAsync(
    paymentLink: new PaymentLink() {
        Amount = 81211D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "GYD",
        Description = "Adfero ipsa terreo benevolentia utrum.",
        Id = "6f37bbe4-204b-4f58-b32e-936f39ed256a",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "314fd23d-b6aa-4607-8ee2-06b9a0b3014e",
                ItemDescription = "Experience the white brilliance of our Hat, perfect for aggravating environments",
                ItemName = "Licensed Marble Mouse",
                ItemSku = "TAD4EYLVRI",
                Notes = "Charisma theca video verus conduco attollo cervus decretum viridis.",
                TaxAmount = 221D,
                TotalAmount = 1841D,
                UnitAmount = 270D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-02-12T17:31:25.507Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-09-30T05:29:29.258Z").ToUniversalTime(),
                DiscountAmount = 15D,
                Id = "d64b2b20-ee5a-49dc-aa11-074dec65f484",
                ItemDescription = "New Chicken model with 79 GB RAM, 846 GB storage, and lovely features",
                ItemName = "Intelligent Steel Table",
                ItemSku = "V8HQCDQYUZ",
                TaxAmount = 150D,
                TotalAmount = 2037D,
                UnitAmount = 317D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-05-31T11:10:09.190Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-12-16T13:52:52.341Z").ToUniversalTime(),
                Id = "e9825358-bb07-44b4-9012-02137c2d5cb6",
                ItemDescription = "Dach - Wolff's most advanced Car technology increases dense capabilities",
                ItemName = "Modern Gold Soap",
                ItemSku = "DYGKCTCLDJ",
                TaxAmount = 41D,
                TotalAmount = 281D,
                UnitAmount = 30D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-05-22T16:35:07.583Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-12T19:45:39.705Z").ToUniversalTime(),
                Id = "9050537a-2a70-45fd-b438-92c3b8ff6679",
                ItemDescription = "The sleek and unimportant Salad comes with salmon LED lighting for smart functionality",
                ItemName = "Generic Aluminum Ball",
                ItemSku = "BSBAXWAAFF",
                Notes = "Cubo adversus victus subito asperiores vereor cibo tabgo.",
                TaxAmount = 6D,
                TotalAmount = 78D,
                UnitAmount = 24D,
                UnitQuantity = 3D,
                UpdatedAt = System.DateTime.Parse("2023-11-13T12:39:15.951Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-02-14T06:21:13.641Z").ToUniversalTime(),
                DiscountAmount = 171D,
                Id = "a1ce5aab-43fd-4e2a-98bf-dd484290ed35",
                ItemDescription = "New Bike model with 29 GB RAM, 271 GB storage, and minty features",
                ItemName = "Incredible Aluminum Chicken",
                ItemSku = "6ERMJK20HE",
                TaxAmount = 263D,
                TotalAmount = 3708D,
                UnitAmount = 452D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-01-31T21:39:30.894Z").ToUniversalTime(),
            },
        },
        SuccessUrl = "https://parched-kettledrum.com/",
        UpdatedAt = System.DateTime.Parse("2026-01-02T18:39:47.530Z").ToUniversalTime(),
        Url = "https://forceful-laughter.biz/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentLink`                                                                                                                                    | [PaymentLink](../../Models/Components/PaymentLink.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreatePaymentLinkQueryParamFields](../../Models/Requests/CreatePaymentLinkQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreatePaymentLinkResponse](../../Models/Requests/CreatePaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreatePaymentPayment

Create a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPaymentPayment" method="post" path="/payment/{connection_id}/payment" example="payment_payment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.CreatePaymentPaymentAsync(
    paymentPayment: new PaymentPayment() {
        Allocations = new List<PaymentAllocation>() {},
        CardBrand = "AMEX",
        CardLast4 = "0819",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "BIF",
        ExchangeRate = 1.203D,
        FeeAmount = 3D,
        Id = "547254cd-5aa7-4a0f-b662-d6e2a73e1c2a",
        LocationId = "94f7c68e-07de-40d1-9d6f-a0896363913f",
        Notes = "Tactus vilicus.",
        PaidAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        PaymentMethod = "BANK_TRANSFER",
        Reference = "auctus",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Check,
        TipAmount = 2D,
        TotalAmount = 44219D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-06-14T21:39:24.448Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentPayment`                                                                                                                                 | [PaymentPayment](../../Models/Components/PaymentPayment.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreatePaymentPaymentQueryParamFields](../../Models/Requests/CreatePaymentPaymentQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreatePaymentPaymentResponse](../../Models/Requests/CreatePaymentPaymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreatePaymentSubscription

Create a subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPaymentSubscription" method="post" path="/payment/{connection_id}/subscription" example="payment_subscription" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.CreatePaymentSubscriptionAsync(
    paymentSubscription: new PaymentSubscription() {
        CreatedAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Currency = "WST",
        CurrentPeriodEndAt = System.DateTime.Parse("2023-06-03T04:20:29.157Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-21T03:55:58.846Z").ToUniversalTime(),
        DayOfMonth = 1D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        EndAt = System.DateTime.Parse("2023-05-21T12:36:09.234Z").ToUniversalTime(),
        Id = "8ae8ae37-bd57-4a13-bd4e-71c00b886e1b",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Month,
        Lineitems = new List<PaymentLineitem>() {},
        StartAt = System.DateTime.Parse("2023-05-29T06:04:51.030Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 75616D,
        UpdatedAt = System.DateTime.Parse("2023-12-21T08:24:45.472Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentSubscription`                                                                                                                            | [PaymentSubscription](../../Models/Components/PaymentSubscription.md)                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreatePaymentSubscriptionQueryParamFields](../../Models/Requests/CreatePaymentSubscriptionQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreatePaymentSubscriptionResponse](../../Models/Requests/CreatePaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentLink

Retrieve a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentLink" method="get" path="/payment/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.GetPaymentLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Link                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetPaymentLinkQueryParamFields](../../Models/Requests/GetPaymentLinkQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPaymentLinkResponse](../../Models/Requests/GetPaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentPayment

Retrieve a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentPayment" method="get" path="/payment/{connection_id}/payment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.GetPaymentPaymentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Payment                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetPaymentPaymentQueryParamFields](../../Models/Requests/GetPaymentPaymentQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPaymentPaymentResponse](../../Models/Requests/GetPaymentPaymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentPayout

Retrieve a payout

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentPayout" method="get" path="/payment/{connection_id}/payout/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.GetPaymentPayoutAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Payout                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetPaymentPayoutQueryParamFields](../../Models/Requests/GetPaymentPayoutQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPaymentPayoutResponse](../../Models/Requests/GetPaymentPayoutResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentRefund

Retrieve a refund

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentRefund" method="get" path="/payment/{connection_id}/refund/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.GetPaymentRefundAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Refund                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetPaymentRefundQueryParamFields](../../Models/Requests/GetPaymentRefundQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPaymentRefundResponse](../../Models/Requests/GetPaymentRefundResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentSubscription

Retrieve a subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentSubscription" method="get" path="/payment/{connection_id}/subscription/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.GetPaymentSubscriptionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Subscription                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetPaymentSubscriptionQueryParamFields](../../Models/Requests/GetPaymentSubscriptionQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPaymentSubscriptionResponse](../../Models/Requests/GetPaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentLinks

List all links

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentLinks" method="get" path="/payment/{connection_id}/link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPaymentLinksRequest req = new ListPaymentLinksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Payment.ListPaymentLinksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListPaymentLinksRequest](../../Models/Requests/ListPaymentLinksRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListPaymentLinksResponse](../../Models/Requests/ListPaymentLinksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentPayments

List all payments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentPayments" method="get" path="/payment/{connection_id}/payment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPaymentPaymentsRequest req = new ListPaymentPaymentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Payment.ListPaymentPaymentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPaymentPaymentsRequest](../../Models/Requests/ListPaymentPaymentsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListPaymentPaymentsResponse](../../Models/Requests/ListPaymentPaymentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentPayouts

List all payouts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentPayouts" method="get" path="/payment/{connection_id}/payout" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPaymentPayoutsRequest req = new ListPaymentPayoutsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Payment.ListPaymentPayoutsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListPaymentPayoutsRequest](../../Models/Requests/ListPaymentPayoutsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListPaymentPayoutsResponse](../../Models/Requests/ListPaymentPayoutsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentRefunds

List all refunds

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentRefunds" method="get" path="/payment/{connection_id}/refund" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPaymentRefundsRequest req = new ListPaymentRefundsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Payment.ListPaymentRefundsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListPaymentRefundsRequest](../../Models/Requests/ListPaymentRefundsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListPaymentRefundsResponse](../../Models/Requests/ListPaymentRefundsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentSubscriptions

List all subscriptions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentSubscriptions" method="get" path="/payment/{connection_id}/subscription" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPaymentSubscriptionsRequest req = new ListPaymentSubscriptionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Payment.ListPaymentSubscriptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListPaymentSubscriptionsRequest](../../Models/Requests/ListPaymentSubscriptionsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListPaymentSubscriptionsResponse](../../Models/Requests/ListPaymentSubscriptionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPaymentLink

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchPaymentLink" method="patch" path="/payment/{connection_id}/link/{id}" example="payment_link" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchPaymentLinkRequest req = new PatchPaymentLinkRequest() {
    PaymentLink = new PaymentLink() {
        Amount = 81211D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "GYD",
        Description = "Adfero ipsa terreo benevolentia utrum.",
        Id = "77b7c8d8-186b-4a18-ae27-87c561e26d7c",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "7b50ea32-b3f2-4d08-adf7-d8b2a6037831",
                ItemDescription = "Experience the white brilliance of our Hat, perfect for aggravating environments",
                ItemName = "Licensed Marble Mouse",
                ItemSku = "TAD4EYLVRI",
                Notes = "Charisma theca video verus conduco attollo cervus decretum viridis.",
                TaxAmount = 221D,
                TotalAmount = 1841D,
                UnitAmount = 270D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-02-12T17:31:25.507Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-09-30T05:29:29.258Z").ToUniversalTime(),
                DiscountAmount = 15D,
                Id = "24b78362-3a9a-4def-a8ef-ac561ca5019f",
                ItemDescription = "New Chicken model with 79 GB RAM, 846 GB storage, and lovely features",
                ItemName = "Intelligent Steel Table",
                ItemSku = "V8HQCDQYUZ",
                TaxAmount = 150D,
                TotalAmount = 2037D,
                UnitAmount = 317D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-05-31T11:10:09.190Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-12-16T13:52:52.341Z").ToUniversalTime(),
                Id = "14f0faef-bd31-4f0f-8a1f-738fa989ac86",
                ItemDescription = "Dach - Wolff's most advanced Car technology increases dense capabilities",
                ItemName = "Modern Gold Soap",
                ItemSku = "DYGKCTCLDJ",
                TaxAmount = 41D,
                TotalAmount = 281D,
                UnitAmount = 30D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-05-22T16:35:07.583Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-12T19:45:39.705Z").ToUniversalTime(),
                Id = "aaa66c53-6332-4778-b6d1-d3e43e74d735",
                ItemDescription = "The sleek and unimportant Salad comes with salmon LED lighting for smart functionality",
                ItemName = "Generic Aluminum Ball",
                ItemSku = "BSBAXWAAFF",
                Notes = "Cubo adversus victus subito asperiores vereor cibo tabgo.",
                TaxAmount = 6D,
                TotalAmount = 78D,
                UnitAmount = 24D,
                UnitQuantity = 3D,
                UpdatedAt = System.DateTime.Parse("2023-11-13T12:39:15.951Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-02-14T06:21:13.641Z").ToUniversalTime(),
                DiscountAmount = 171D,
                Id = "d59b2391-4649-4e66-85e5-d5a6f99e5be6",
                ItemDescription = "New Bike model with 29 GB RAM, 271 GB storage, and minty features",
                ItemName = "Incredible Aluminum Chicken",
                ItemSku = "6ERMJK20HE",
                TaxAmount = 263D,
                TotalAmount = 3708D,
                UnitAmount = 452D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-01-31T21:39:30.894Z").ToUniversalTime(),
            },
        },
        SuccessUrl = "https://parched-kettledrum.com/",
        UpdatedAt = System.DateTime.Parse("2026-01-02T18:39:47.543Z").ToUniversalTime(),
        Url = "https://forceful-laughter.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Payment.PatchPaymentLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchPaymentLinkRequest](../../Models/Requests/PatchPaymentLinkRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchPaymentLinkResponse](../../Models/Requests/PatchPaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPaymentPayment

Update a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchPaymentPayment" method="patch" path="/payment/{connection_id}/payment/{id}" example="payment_payment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchPaymentPaymentRequest req = new PatchPaymentPaymentRequest() {
    PaymentPayment = new PaymentPayment() {
        Allocations = new List<PaymentAllocation>() {},
        CardBrand = "AMEX",
        CardLast4 = "0819",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "BIF",
        ExchangeRate = 1.203D,
        FeeAmount = 3D,
        Id = "dbd5bbdd-d479-4dac-a2bb-0c7af44b136d",
        LocationId = "94f7c68e-07de-40d1-9d6f-a0896363913f",
        Notes = "Tactus vilicus.",
        PaidAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        PaymentMethod = "BANK_TRANSFER",
        Reference = "auctus",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Check,
        TipAmount = 2D,
        TotalAmount = 44219D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-06-14T21:39:24.470Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Payment.PatchPaymentPaymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchPaymentPaymentRequest](../../Models/Requests/PatchPaymentPaymentRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchPaymentPaymentResponse](../../Models/Requests/PatchPaymentPaymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPaymentSubscription

Update a subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchPaymentSubscription" method="patch" path="/payment/{connection_id}/subscription/{id}" example="payment_subscription" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchPaymentSubscriptionRequest req = new PatchPaymentSubscriptionRequest() {
    PaymentSubscription = new PaymentSubscription() {
        CreatedAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Currency = "WST",
        CurrentPeriodEndAt = System.DateTime.Parse("2023-06-03T04:20:29.157Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-21T03:55:58.846Z").ToUniversalTime(),
        DayOfMonth = 1D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        EndAt = System.DateTime.Parse("2023-05-21T12:36:09.234Z").ToUniversalTime(),
        Id = "61de0bd9-4e22-4677-8ec7-c7f0d1d45dc9",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Month,
        Lineitems = new List<PaymentLineitem>() {},
        StartAt = System.DateTime.Parse("2023-05-29T06:04:51.030Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 75616D,
        UpdatedAt = System.DateTime.Parse("2023-12-21T08:24:45.475Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Payment.PatchPaymentSubscriptionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [PatchPaymentSubscriptionRequest](../../Models/Requests/PatchPaymentSubscriptionRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[PatchPaymentSubscriptionResponse](../../Models/Requests/PatchPaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePaymentLink

Remove a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removePaymentLink" method="delete" path="/payment/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.RemovePaymentLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Link       |

### Response

**[RemovePaymentLinkResponse](../../Models/Requests/RemovePaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePaymentPayment

Remove a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removePaymentPayment" method="delete" path="/payment/{connection_id}/payment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.RemovePaymentPaymentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Payment    |

### Response

**[RemovePaymentPaymentResponse](../../Models/Requests/RemovePaymentPaymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePaymentSubscription

Remove a subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removePaymentSubscription" method="delete" path="/payment/{connection_id}/subscription/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Payment.RemovePaymentSubscriptionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Subscription |

### Response

**[RemovePaymentSubscriptionResponse](../../Models/Requests/RemovePaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePaymentLink

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePaymentLink" method="put" path="/payment/{connection_id}/link/{id}" example="payment_link" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdatePaymentLinkRequest req = new UpdatePaymentLinkRequest() {
    PaymentLink = new PaymentLink() {
        Amount = 81211D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "GYD",
        Description = "Adfero ipsa terreo benevolentia utrum.",
        Id = "77b7c8d8-186b-4a18-ae27-87c561e26d7c",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "7b50ea32-b3f2-4d08-adf7-d8b2a6037831",
                ItemDescription = "Experience the white brilliance of our Hat, perfect for aggravating environments",
                ItemName = "Licensed Marble Mouse",
                ItemSku = "TAD4EYLVRI",
                Notes = "Charisma theca video verus conduco attollo cervus decretum viridis.",
                TaxAmount = 221D,
                TotalAmount = 1841D,
                UnitAmount = 270D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-02-12T17:31:25.507Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-09-30T05:29:29.258Z").ToUniversalTime(),
                DiscountAmount = 15D,
                Id = "24b78362-3a9a-4def-a8ef-ac561ca5019f",
                ItemDescription = "New Chicken model with 79 GB RAM, 846 GB storage, and lovely features",
                ItemName = "Intelligent Steel Table",
                ItemSku = "V8HQCDQYUZ",
                TaxAmount = 150D,
                TotalAmount = 2037D,
                UnitAmount = 317D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-05-31T11:10:09.190Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-12-16T13:52:52.341Z").ToUniversalTime(),
                Id = "14f0faef-bd31-4f0f-8a1f-738fa989ac86",
                ItemDescription = "Dach - Wolff's most advanced Car technology increases dense capabilities",
                ItemName = "Modern Gold Soap",
                ItemSku = "DYGKCTCLDJ",
                TaxAmount = 41D,
                TotalAmount = 281D,
                UnitAmount = 30D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-05-22T16:35:07.583Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-12T19:45:39.705Z").ToUniversalTime(),
                Id = "aaa66c53-6332-4778-b6d1-d3e43e74d735",
                ItemDescription = "The sleek and unimportant Salad comes with salmon LED lighting for smart functionality",
                ItemName = "Generic Aluminum Ball",
                ItemSku = "BSBAXWAAFF",
                Notes = "Cubo adversus victus subito asperiores vereor cibo tabgo.",
                TaxAmount = 6D,
                TotalAmount = 78D,
                UnitAmount = 24D,
                UnitQuantity = 3D,
                UpdatedAt = System.DateTime.Parse("2023-11-13T12:39:15.951Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-02-14T06:21:13.641Z").ToUniversalTime(),
                DiscountAmount = 171D,
                Id = "d59b2391-4649-4e66-85e5-d5a6f99e5be6",
                ItemDescription = "New Bike model with 29 GB RAM, 271 GB storage, and minty features",
                ItemName = "Incredible Aluminum Chicken",
                ItemSku = "6ERMJK20HE",
                TaxAmount = 263D,
                TotalAmount = 3708D,
                UnitAmount = 452D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-01-31T21:39:30.894Z").ToUniversalTime(),
            },
        },
        SuccessUrl = "https://parched-kettledrum.com/",
        UpdatedAt = System.DateTime.Parse("2026-01-02T18:39:47.543Z").ToUniversalTime(),
        Url = "https://forceful-laughter.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Payment.UpdatePaymentLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdatePaymentLinkRequest](../../Models/Requests/UpdatePaymentLinkRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdatePaymentLinkResponse](../../Models/Requests/UpdatePaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePaymentPayment

Update a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePaymentPayment" method="put" path="/payment/{connection_id}/payment/{id}" example="payment_payment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdatePaymentPaymentRequest req = new UpdatePaymentPaymentRequest() {
    PaymentPayment = new PaymentPayment() {
        Allocations = new List<PaymentAllocation>() {},
        CardBrand = "AMEX",
        CardLast4 = "0819",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "BIF",
        ExchangeRate = 1.203D,
        FeeAmount = 3D,
        Id = "dbd5bbdd-d479-4dac-a2bb-0c7af44b136d",
        LocationId = "94f7c68e-07de-40d1-9d6f-a0896363913f",
        Notes = "Tactus vilicus.",
        PaidAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        PaymentMethod = "BANK_TRANSFER",
        Reference = "auctus",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Check,
        TipAmount = 2D,
        TotalAmount = 44219D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-06-14T21:39:24.470Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Payment.UpdatePaymentPaymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdatePaymentPaymentRequest](../../Models/Requests/UpdatePaymentPaymentRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdatePaymentPaymentResponse](../../Models/Requests/UpdatePaymentPaymentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePaymentSubscription

Update a subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePaymentSubscription" method="put" path="/payment/{connection_id}/subscription/{id}" example="payment_subscription" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdatePaymentSubscriptionRequest req = new UpdatePaymentSubscriptionRequest() {
    PaymentSubscription = new PaymentSubscription() {
        CreatedAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Currency = "WST",
        CurrentPeriodEndAt = System.DateTime.Parse("2023-06-03T04:20:29.157Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-21T03:55:58.846Z").ToUniversalTime(),
        DayOfMonth = 1D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        EndAt = System.DateTime.Parse("2023-05-21T12:36:09.234Z").ToUniversalTime(),
        Id = "61de0bd9-4e22-4677-8ec7-c7f0d1d45dc9",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Month,
        Lineitems = new List<PaymentLineitem>() {},
        StartAt = System.DateTime.Parse("2023-05-29T06:04:51.030Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 75616D,
        UpdatedAt = System.DateTime.Parse("2023-12-21T08:24:45.475Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Payment.UpdatePaymentSubscriptionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdatePaymentSubscriptionRequest](../../Models/Requests/UpdatePaymentSubscriptionRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[UpdatePaymentSubscriptionResponse](../../Models/Requests/UpdatePaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |