# Link
(*Link*)

### Available Operations

* [CreatePaymentLink](#createpaymentlink) - Create a payment link
* [GetPaymentLink](#getpaymentlink) - Retrieve a payment link
* [ListPaymentLinks](#listpaymentlinks) - List all payment links
* [PatchPaymentLink](#patchpaymentlink) - Update a payment link
* [RemovePaymentLink](#removepaymentlink) - Remove a payment link
* [UpdatePaymentLink](#updatepaymentlink) - Update a payment link

## CreatePaymentLink

Create a payment link

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Link.CreatePaymentLinkAsync(
    connectionId: "<value>",
    paymentLink: new PaymentLink() {
    IsActive = false,
    Lineitems = new List<PaymenntLinkLineitem>() {
        new PaymenntLinkLineitem() {
            TotalAmount = 8711.36D,
        },
    },
    Url = "https://athletic-unemployment.org",
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `PaymentLink`                                         | [PaymentLink](../../Models/Components/PaymentLink.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreatePaymentLinkResponse](../../Models/Requests/CreatePaymentLinkResponse.md)**


## GetPaymentLink

Retrieve a payment link

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Link.GetPaymentLinkAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Link                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetPaymentLinkResponse](../../Models/Requests/GetPaymentLinkResponse.md)**


## ListPaymentLinks

List all payment links

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListPaymentLinksRequest req = new ListPaymentLinksRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Link.ListPaymentLinksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListPaymentLinksRequest](../../Models/Requests/ListPaymentLinksRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListPaymentLinksResponse](../../Models/Requests/ListPaymentLinksResponse.md)**


## PatchPaymentLink

Update a payment link

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Link.PatchPaymentLinkAsync(
    connectionId: "<value>",
    id: "<value>",
    paymentLink: new PaymentLink() {
    IsActive = false,
    Lineitems = new List<PaymenntLinkLineitem>() {
        new PaymenntLinkLineitem() {
            TotalAmount = 2219.73D,
        },
    },
    Url = "http://vicious-rank.info",
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Link                                        |
| `PaymentLink`                                         | [PaymentLink](../../Models/Components/PaymentLink.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchPaymentLinkResponse](../../Models/Requests/PatchPaymentLinkResponse.md)**


## RemovePaymentLink

Remove a payment link

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Link.RemovePaymentLinkAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Link       |


### Response

**[RemovePaymentLinkResponse](../../Models/Requests/RemovePaymentLinkResponse.md)**


## UpdatePaymentLink

Update a payment link

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Link.UpdatePaymentLinkAsync(
    connectionId: "<value>",
    id: "<value>",
    paymentLink: new PaymentLink() {
    IsActive = false,
    Lineitems = new List<PaymenntLinkLineitem>() {
        new PaymenntLinkLineitem() {
            TotalAmount = 6147.65D,
        },
    },
    Url = "http://flawed-publication.org",
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Link                                        |
| `PaymentLink`                                         | [PaymentLink](../../Models/Components/PaymentLink.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdatePaymentLinkResponse](../../Models/Requests/UpdatePaymentLinkResponse.md)**

