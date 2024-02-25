# Refund
(*Refund*)

### Available Operations

* [GetAccountingRefund](#getaccountingrefund) - Retrieve a refund
* [ListAccountingRefunds](#listaccountingrefunds) - List all refunds

## GetAccountingRefund

Retrieve a refund

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Refund.GetAccountingRefundAsync(
    security: new GetAccountingRefundSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.GetAccountingRefundSecurity](../../Models/Requests/GetAccountingRefundSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Refund                                                                                              |
| `Fields`                                                                                                      | List<*string*>                                                                                                | :heavy_minus_sign:                                                                                            | Comma-delimited fields to return                                                                              |


### Response

**[GetAccountingRefundResponse](../../Models/Requests/GetAccountingRefundResponse.md)**


## ListAccountingRefunds

List all refunds

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingRefundsRequest req = new ListAccountingRefundsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Refund.ListAccountingRefundsAsync(
    security: new ListAccountingRefundsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [ListAccountingRefundsRequest](../../Models/Requests/ListAccountingRefundsRequest.md)                             | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.ListAccountingRefundsSecurity](../../Models/Requests/ListAccountingRefundsSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |


### Response

**[ListAccountingRefundsResponse](../../Models/Requests/ListAccountingRefundsResponse.md)**

