# Subscription

## Overview

### Available Operations

* [CreatePaymentSubscription](#createpaymentsubscription) - Create a subscription
* [GetPaymentSubscription](#getpaymentsubscription) - Retrieve a subscription
* [ListPaymentSubscriptions](#listpaymentsubscriptions) - List all subscriptions
* [PatchPaymentSubscription](#patchpaymentsubscription) - Update a subscription
* [RemovePaymentSubscription](#removepaymentsubscription) - Remove a subscription
* [UpdatePaymentSubscription](#updatepaymentsubscription) - Update a subscription

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

var res = await sdk.Subscription.CreatePaymentSubscriptionAsync(
    paymentSubscription: new PaymentSubscription() {
        CreatedAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Currency = "USD",
        CurrentPeriodEndAt = System.DateTime.Parse("2024-02-08T10:05:22.912Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        DayOfMonth = 8D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        Id = "f14da343-454d-46a9-bb8c-00f75a48a8a3",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Year,
        Lineitems = new List<PaymentLineitem>() {},
        Metadata = new List<PaymentMetadata>() {},
        Month = 5D,
        StartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-04T12:54:49.598Z").ToUniversalTime(),
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

var res = await sdk.Subscription.GetPaymentSubscriptionAsync(
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

var res = await sdk.Subscription.ListPaymentSubscriptionsAsync(req);

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
        Currency = "USD",
        CurrentPeriodEndAt = System.DateTime.Parse("2024-02-08T10:05:22.912Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        DayOfMonth = 8D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        Id = "1d5f56eb-9d66-494d-b53f-22c2103a9147",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Year,
        Lineitems = new List<PaymentLineitem>() {},
        Metadata = new List<PaymentMetadata>() {},
        Month = 5D,
        StartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-04T12:54:49.601Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Subscription.PatchPaymentSubscriptionAsync(req);

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

var res = await sdk.Subscription.RemovePaymentSubscriptionAsync(
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
        Currency = "USD",
        CurrentPeriodEndAt = System.DateTime.Parse("2024-02-08T10:05:22.912Z").ToUniversalTime(),
        CurrentPeriodStartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        DayOfMonth = 8D,
        Description = "Innovative Mouse featuring important technology and Bamboo construction",
        Id = "1d5f56eb-9d66-494d-b53f-22c2103a9147",
        Interval = 1D,
        IntervalUnit = IntervalUnit.Year,
        Lineitems = new List<PaymentLineitem>() {},
        Metadata = new List<PaymentMetadata>() {},
        Month = 5D,
        StartAt = System.DateTime.Parse("2023-05-08T10:11:03.414Z").ToUniversalTime(),
        Status = PaymentSubscriptionStatus.Active,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-04T12:54:49.601Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Subscription.UpdatePaymentSubscriptionAsync(req);

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