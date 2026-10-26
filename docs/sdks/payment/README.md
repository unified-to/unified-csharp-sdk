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

Creates a PaymentLink. Provide the unified PaymentLink fields in the request body; they are mapped to the provider's API. Returns the created PaymentLink.

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
        Amount = 17001.68D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Savor the tender essence in our Ball, designed for dim culinary adventures",
        Id = "6a9e70b0-fc6c-4ae3-a046-ce9a6c9bb46a",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "c876fed5-f460-4c84-ab6f-75b3a799383a",
                ItemDescription = "Discover the worst new Computer with an exciting mix of Steel ingredients",
                ItemName = "Soft Marble Cheese",
                TaxAmount = 0D,
                TotalAmount = 9342D,
                UnitAmount = 519D,
                UnitQuantity = 18D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                DiscountAmount = 424.32D,
                Id = "330b7f2b-13d3-4db5-a341-818a6f98783e",
                ItemDescription = "Innovative Shoes featuring utilized technology and Cotton construction",
                ItemName = "Sleek Aluminum Shoes",
                Notes = "Cervus decretum viridis doloremque.",
                TaxAmount = 0D,
                TotalAmount = 6647.68D,
                UnitAmount = 884D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "9a62957a-4ada-4798-ad7f-1d50c30a0b04",
                ItemDescription = "Featuring Osmium-enhanced technology, our Soap offers unparalleled major performance",
                ItemName = "Elegant Concrete Gloves",
                Notes = "Desipio usque vacuus currus cetera testimonium.",
                TaxAmount = 0D,
                TotalAmount = 1012D,
                UnitAmount = 506D,
                UnitQuantity = 2D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
        },
        Metadata = new List<PaymentMetadata>() {},
        SuccessUrl = "https://tinted-jet.info",
        UpdatedAt = System.DateTime.Parse("2024-04-14T15:30:23.024Z").ToUniversalTime(),
        Url = "https://pay.example.com/6a9e70b0-fc6c-4ae3-a046-ce9a6c9bb46a",
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

Creates a PaymentPayment. Provide the unified PaymentPayment fields in the request body; they are mapped to the provider's API. Returns the created PaymentPayment.

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
        CardBrand = "MASTERCARD",
        CardLast4 = "1529",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "EUR",
        FeeAmount = 2055.82D,
        Id = "6c8fb380-3527-46da-99b5-9e1f8587aea6",
        Metadata = new List<PaymentMetadata>() {},
        NetAmount = 68824.18D,
        Notes = "Bibo tactus vilicus.",
        PaidAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        PaymentMethod = "CASH",
        Reference = "PMT-119080",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Cash,
        TipAmount = 0D,
        TotalAmount = 70880D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-10-11T20:06:48.537Z").ToUniversalTime(),
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

Creates a PaymentSubscription. Provide the unified PaymentSubscription fields in the request body; they are mapped to the provider's API. Returns the created PaymentSubscription.

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
        Currency = "USD",
        CurrentPeriodEndAt = System.DateTime.Parse("2024-02-08T10:05:22.912Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        DayOfMonth = 8D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        Id = "e3e8b6d4-76e2-415d-83c6-05bc8b8bdf25",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Year,
        Lineitems = new List<PaymentLineitem>() {},
        Metadata = new List<PaymentMetadata>() {},
        Month = 5D,
        StartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-05T02:49:27.422Z").ToUniversalTime(),
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

Retrieves a single PaymentLink by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single PaymentPayment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single PaymentPayout by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single PaymentRefund by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single PaymentSubscription by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of PaymentLinks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of PaymentPayments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of PaymentPayouts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of PaymentRefunds. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of PaymentSubscriptions. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the PaymentLink identified by `id`. Provide the unified PaymentLink fields to change in the request body.

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
        Amount = 17001.68D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Savor the tender essence in our Ball, designed for dim culinary adventures",
        Id = "9fd381ff-7303-495b-8788-83bcee676ffe",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "197f3c36-d168-4816-b5ed-3497fce06a81",
                ItemDescription = "Discover the worst new Computer with an exciting mix of Steel ingredients",
                ItemName = "Soft Marble Cheese",
                TaxAmount = 0D,
                TotalAmount = 9342D,
                UnitAmount = 519D,
                UnitQuantity = 18D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                DiscountAmount = 424.32D,
                Id = "1fbac44b-ad58-4076-a095-be5633359b45",
                ItemDescription = "Innovative Shoes featuring utilized technology and Cotton construction",
                ItemName = "Sleek Aluminum Shoes",
                Notes = "Cervus decretum viridis doloremque.",
                TaxAmount = 0D,
                TotalAmount = 6647.68D,
                UnitAmount = 884D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "5b1f565d-1dd7-419b-94dc-f9fa498dcac4",
                ItemDescription = "Featuring Osmium-enhanced technology, our Soap offers unparalleled major performance",
                ItemName = "Elegant Concrete Gloves",
                Notes = "Desipio usque vacuus currus cetera testimonium.",
                TaxAmount = 0D,
                TotalAmount = 1012D,
                UnitAmount = 506D,
                UnitQuantity = 2D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
        },
        Metadata = new List<PaymentMetadata>() {},
        SuccessUrl = "https://tinted-jet.info",
        UpdatedAt = System.DateTime.Parse("2024-04-14T15:30:23.036Z").ToUniversalTime(),
        Url = "https://pay.example.com/9fd381ff-7303-495b-8788-83bcee676ffe",
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

Updates the PaymentPayment identified by `id`. Provide the unified PaymentPayment fields to change in the request body.

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
        CardBrand = "MASTERCARD",
        CardLast4 = "1529",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "EUR",
        FeeAmount = 2055.82D,
        Id = "a0dd602f-6ebd-4f3a-ad3b-e116e4dfb4ef",
        Metadata = new List<PaymentMetadata>() {},
        NetAmount = 68824.18D,
        Notes = "Bibo tactus vilicus.",
        PaidAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        PaymentMethod = "CASH",
        Reference = "PMT-119080",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Cash,
        TipAmount = 0D,
        TotalAmount = 70880D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-10-11T20:06:48.586Z").ToUniversalTime(),
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

Updates the PaymentSubscription identified by `id`. Provide the unified PaymentSubscription fields to change in the request body.

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
        Currency = "USD",
        CurrentPeriodEndAt = System.DateTime.Parse("2024-02-08T10:05:22.912Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        DayOfMonth = 8D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        Id = "5de82c92-97d1-4df1-9298-8d596ef217e0",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Year,
        Lineitems = new List<PaymentLineitem>() {},
        Metadata = new List<PaymentMetadata>() {},
        Month = 5D,
        StartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-05T02:49:27.426Z").ToUniversalTime(),
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

Deletes the PaymentLink identified by `id`.

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

Deletes the PaymentPayment identified by `id`.

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

Deletes the PaymentSubscription identified by `id`.

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

Updates the PaymentLink identified by `id`. Provide the unified PaymentLink fields to change in the request body.

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
        Amount = 17001.68D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Savor the tender essence in our Ball, designed for dim culinary adventures",
        Id = "9fd381ff-7303-495b-8788-83bcee676ffe",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "197f3c36-d168-4816-b5ed-3497fce06a81",
                ItemDescription = "Discover the worst new Computer with an exciting mix of Steel ingredients",
                ItemName = "Soft Marble Cheese",
                TaxAmount = 0D,
                TotalAmount = 9342D,
                UnitAmount = 519D,
                UnitQuantity = 18D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                DiscountAmount = 424.32D,
                Id = "1fbac44b-ad58-4076-a095-be5633359b45",
                ItemDescription = "Innovative Shoes featuring utilized technology and Cotton construction",
                ItemName = "Sleek Aluminum Shoes",
                Notes = "Cervus decretum viridis doloremque.",
                TaxAmount = 0D,
                TotalAmount = 6647.68D,
                UnitAmount = 884D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "5b1f565d-1dd7-419b-94dc-f9fa498dcac4",
                ItemDescription = "Featuring Osmium-enhanced technology, our Soap offers unparalleled major performance",
                ItemName = "Elegant Concrete Gloves",
                Notes = "Desipio usque vacuus currus cetera testimonium.",
                TaxAmount = 0D,
                TotalAmount = 1012D,
                UnitAmount = 506D,
                UnitQuantity = 2D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
        },
        Metadata = new List<PaymentMetadata>() {},
        SuccessUrl = "https://tinted-jet.info",
        UpdatedAt = System.DateTime.Parse("2024-04-14T15:30:23.036Z").ToUniversalTime(),
        Url = "https://pay.example.com/9fd381ff-7303-495b-8788-83bcee676ffe",
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

Updates the PaymentPayment identified by `id`. Provide the unified PaymentPayment fields to change in the request body.

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
        CardBrand = "MASTERCARD",
        CardLast4 = "1529",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        Currency = "EUR",
        FeeAmount = 2055.82D,
        Id = "a0dd602f-6ebd-4f3a-ad3b-e116e4dfb4ef",
        Metadata = new List<PaymentMetadata>() {},
        NetAmount = 68824.18D,
        Notes = "Bibo tactus vilicus.",
        PaidAt = System.DateTime.Parse("2022-03-10T00:19:42.086Z").ToUniversalTime(),
        PaymentMethod = "CASH",
        Reference = "PMT-119080",
        Status = PaymentPaymentStatus.Succeeded,
        TenderType = TenderType.Cash,
        TipAmount = 0D,
        TotalAmount = 70880D,
        Type = PaymentPaymentType.Invoice,
        UpdatedAt = System.DateTime.Parse("2025-10-11T20:06:48.586Z").ToUniversalTime(),
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

Updates the PaymentSubscription identified by `id`. Provide the unified PaymentSubscription fields to change in the request body.

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
        Currency = "USD",
        CurrentPeriodEndAt = System.DateTime.Parse("2024-02-08T10:05:22.912Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        DayOfMonth = 8D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        Id = "5de82c92-97d1-4df1-9298-8d596ef217e0",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Year,
        Lineitems = new List<PaymentLineitem>() {},
        Metadata = new List<PaymentMetadata>() {},
        Month = 5D,
        StartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-05T02:49:27.426Z").ToUniversalTime(),
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