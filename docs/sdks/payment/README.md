# Payment
(*Payment*)

### Available Operations

* [CreateAccountingPayment](#createaccountingpayment) - Create a payment
* [GetAccountingPayment](#getaccountingpayment) - Retrieve a payment
* [ListAccountingPayments](#listaccountingpayments) - List all payments
* [PatchAccountingPayment](#patchaccountingpayment) - Update a payment
* [RemoveAccountingPayment](#removeaccountingpayment) - Remove a payment
* [UpdateAccountingPayment](#updateaccountingpayment) - Update a payment

## CreateAccountingPayment

Create a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Payment.CreateAccountingPaymentAsync(
    security: new CreateAccountingPaymentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingPayment: new AccountingPayment() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingPaymentSecurity](../../Models/Requests/CreateAccountingPaymentSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingPayment`                                                                                                   | [AccountingPayment](../../Models/Components/AccountingPayment.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingPaymentResponse](../../Models/Requests/CreateAccountingPaymentResponse.md)**


## GetAccountingPayment

Retrieve a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Payment.GetAccountingPaymentAsync(
    security: new GetAccountingPaymentSecurity() {
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

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingPaymentSecurity](../../Models/Requests/GetAccountingPaymentSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Payment                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingPaymentResponse](../../Models/Requests/GetAccountingPaymentResponse.md)**


## ListAccountingPayments

List all payments

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Payment.ListAccountingPaymentsAsync(
    security: new ListAccountingPaymentsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingPaymentsRequest](../../Models/Requests/ListAccountingPaymentsRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingPaymentsSecurity](../../Models/Requests/ListAccountingPaymentsSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingPaymentsResponse](../../Models/Requests/ListAccountingPaymentsResponse.md)**


## PatchAccountingPayment

Update a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Payment.PatchAccountingPaymentAsync(
    security: new PatchAccountingPaymentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingPayment: new AccountingPayment() {});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingPaymentSecurity](../../Models/Requests/PatchAccountingPaymentSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Payment                                                                                                   |
| `AccountingPayment`                                                                                                 | [AccountingPayment](../../Models/Components/AccountingPayment.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingPaymentResponse](../../Models/Requests/PatchAccountingPaymentResponse.md)**


## RemoveAccountingPayment

Remove a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Payment.RemoveAccountingPaymentAsync(
    security: new RemoveAccountingPaymentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingPaymentSecurity](../../Models/Requests/RemoveAccountingPaymentSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Payment                                                                                                     |


### Response

**[RemoveAccountingPaymentResponse](../../Models/Requests/RemoveAccountingPaymentResponse.md)**


## UpdateAccountingPayment

Update a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Payment.UpdateAccountingPaymentAsync(
    security: new UpdateAccountingPaymentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingPayment: new AccountingPayment() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingPaymentSecurity](../../Models/Requests/UpdateAccountingPaymentSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Payment                                                                                                     |
| `AccountingPayment`                                                                                                   | [AccountingPayment](../../Models/Components/AccountingPayment.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingPaymentResponse](../../Models/Requests/UpdateAccountingPaymentResponse.md)**

