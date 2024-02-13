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
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Refund.GetAccountingRefundAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
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

**[GetAccountingRefundResponse](../../Models/Requests/GetAccountingRefundResponse.md)**


## ListAccountingRefunds

List all refunds

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingRefundsRequest req = new ListAccountingRefundsRequest() {
    ConnectionId = "string",
};

var res = await sdk.Refund.ListAccountingRefundsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListAccountingRefundsRequest](../../Models/Requests/ListAccountingRefundsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListAccountingRefundsResponse](../../Models/Requests/ListAccountingRefundsResponse.md)**

