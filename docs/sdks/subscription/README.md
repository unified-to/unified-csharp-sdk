# Subscription
(*Subscription*)

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

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Subscription.CreatePaymentSubscriptionAsync(
    connectionId: "<id>",
    paymentSubscription: new PaymentSubscription() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `ConnectionId`                                                        | *string*                                                              | :heavy_check_mark:                                                    | ID of the connection                                                  |
| `PaymentSubscription`                                                 | [PaymentSubscription](../../Models/Components/PaymentSubscription.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Fields`                                                              | List<*string*>                                                        | :heavy_minus_sign:                                                    | Comma-delimited fields to return                                      |

### Response

**[CreatePaymentSubscriptionResponse](../../Models/Requests/CreatePaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentSubscription

Retrieve a subscription

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Subscription.GetPaymentSubscriptionAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Subscription           |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetPaymentSubscriptionResponse](../../Models/Requests/GetPaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentSubscriptions

List all subscriptions

### Example Usage

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

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Subscription.PatchPaymentSubscriptionAsync(
    connectionId: "<id>",
    id: "<id>",
    paymentSubscription: new PaymentSubscription() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `ConnectionId`                                                        | *string*                                                              | :heavy_check_mark:                                                    | ID of the connection                                                  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Subscription                                                |
| `PaymentSubscription`                                                 | [PaymentSubscription](../../Models/Components/PaymentSubscription.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Fields`                                                              | List<*string*>                                                        | :heavy_minus_sign:                                                    | Comma-delimited fields to return                                      |

### Response

**[PatchPaymentSubscriptionResponse](../../Models/Requests/PatchPaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePaymentSubscription

Remove a subscription

### Example Usage

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

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Subscription.UpdatePaymentSubscriptionAsync(
    connectionId: "<id>",
    id: "<id>",
    paymentSubscription: new PaymentSubscription() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `ConnectionId`                                                        | *string*                                                              | :heavy_check_mark:                                                    | ID of the connection                                                  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Subscription                                                |
| `PaymentSubscription`                                                 | [PaymentSubscription](../../Models/Components/PaymentSubscription.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Fields`                                                              | List<*string*>                                                        | :heavy_minus_sign:                                                    | Comma-delimited fields to return                                      |

### Response

**[UpdatePaymentSubscriptionResponse](../../Models/Requests/UpdatePaymentSubscriptionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |