# Refund
(*Refund*)

### Available Operations

* [GetPaymentRefund](#getpaymentrefund) - Retrieve a refund
* [ListPaymentRefunds](#listpaymentrefunds) - List all refunds

## GetPaymentRefund

Retrieve a refund

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Refund.GetPaymentRefundAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Refund                 |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetPaymentRefundResponse](../../Models/Requests/GetPaymentRefundResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListPaymentRefunds

List all refunds

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListPaymentRefundsRequest req = new ListPaymentRefundsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Refund.ListPaymentRefundsAsync(req);

// handle response
```



### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListPaymentRefundsRequest](../../Models/Requests/ListPaymentRefundsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[ListPaymentRefundsResponse](../../Models/Requests/ListPaymentRefundsResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
