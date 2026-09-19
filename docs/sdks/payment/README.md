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
        Id = "70bc5079-2e66-41cf-99bd-0c6aef7a88ef",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "9f3becea-9674-4502-8007-9f15fe3bdd42",
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
                Id = "b2feb4d6-71d1-4bb7-b9ab-9ac8e3007c98",
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
                Id = "2169bc69-970b-4c89-a66b-f4d2335ed518",
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
                Id = "12479c68-97ba-4ee2-87c4-2321160024e0",
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
                Id = "efb93adf-a716-419b-b16d-b232c17efde7",
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
        UpdatedAt = System.DateTime.Parse("2025-12-11T13:15:15.976Z").ToUniversalTime(),
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
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "BIF",
        FeeAmount = 3D,
        Id = "f5874cf0-e456-4475-b7ee-ddf81d594451",
        LocationId = "94f7c68e-07de-40d1-9d6f-a0896363913f",
        Notes = "Tactus vilicus.",
        PaymentMethod = "BANK_TRANSFER",
        Reference = "auctus",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Check,
        TipAmount = 2D,
        TotalAmount = 44219D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-05-25T08:02:13.685Z").ToUniversalTime(),
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
        Id = "fbbb3361-7b46-47fd-b4ca-c73bc54aa0a4",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Month,
        Lineitems = new List<PaymentLineitem>() {},
        StartAt = System.DateTime.Parse("2023-05-29T06:04:51.030Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 75616D,
        UpdatedAt = System.DateTime.Parse("2023-12-16T02:50:40.559Z").ToUniversalTime(),
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
        Id = "09417c80-f7ac-4a65-9d32-b61549c8b82e",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "712338e3-c3fd-4a47-a5eb-2987db86a5bc",
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
                Id = "26f2336f-7663-4939-8e13-464e2d830150",
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
                Id = "49bb1687-b5f7-4651-b41f-1a2853701222",
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
                Id = "c52f4cd3-5e0e-415f-ac18-222eb5c5071a",
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
                Id = "051d8a82-b698-4974-a57d-93b9d5c12f3f",
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
        UpdatedAt = System.DateTime.Parse("2025-12-11T13:15:15.991Z").ToUniversalTime(),
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
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "BIF",
        FeeAmount = 3D,
        Id = "2fa36d89-ad78-4f67-a39e-af85ed082204",
        LocationId = "94f7c68e-07de-40d1-9d6f-a0896363913f",
        Notes = "Tactus vilicus.",
        PaymentMethod = "BANK_TRANSFER",
        Reference = "auctus",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Check,
        TipAmount = 2D,
        TotalAmount = 44219D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-05-25T08:02:13.702Z").ToUniversalTime(),
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
        Id = "42abb73b-a818-4346-82bb-4422b6f30b26",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Month,
        Lineitems = new List<PaymentLineitem>() {},
        StartAt = System.DateTime.Parse("2023-05-29T06:04:51.030Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 75616D,
        UpdatedAt = System.DateTime.Parse("2023-12-16T02:50:40.563Z").ToUniversalTime(),
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
        Id = "09417c80-f7ac-4a65-9d32-b61549c8b82e",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "712338e3-c3fd-4a47-a5eb-2987db86a5bc",
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
                Id = "26f2336f-7663-4939-8e13-464e2d830150",
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
                Id = "49bb1687-b5f7-4651-b41f-1a2853701222",
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
                Id = "c52f4cd3-5e0e-415f-ac18-222eb5c5071a",
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
                Id = "051d8a82-b698-4974-a57d-93b9d5c12f3f",
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
        UpdatedAt = System.DateTime.Parse("2025-12-11T13:15:15.991Z").ToUniversalTime(),
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
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "BIF",
        FeeAmount = 3D,
        Id = "2fa36d89-ad78-4f67-a39e-af85ed082204",
        LocationId = "94f7c68e-07de-40d1-9d6f-a0896363913f",
        Notes = "Tactus vilicus.",
        PaymentMethod = "BANK_TRANSFER",
        Reference = "auctus",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Check,
        TipAmount = 2D,
        TotalAmount = 44219D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-05-25T08:02:13.702Z").ToUniversalTime(),
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
        Id = "42abb73b-a818-4346-82bb-4422b6f30b26",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Month,
        Lineitems = new List<PaymentLineitem>() {},
        StartAt = System.DateTime.Parse("2023-05-29T06:04:51.030Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 75616D,
        UpdatedAt = System.DateTime.Parse("2023-12-16T02:50:40.563Z").ToUniversalTime(),
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