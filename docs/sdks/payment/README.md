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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Payment.CreateAccountingPaymentAsync(ConnectionId: "string", AccountingPayment: new AccountingPayment() {
    InvoiceIds = new List<string>() {
        "string",
    },
    Raw = new PropertyAccountingPaymentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `AccountingPayment`                                               | [AccountingPayment](../../Models/Components/AccountingPayment.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[CreateAccountingPaymentResponse](../../Models/Requests/CreateAccountingPaymentResponse.md)**


## GetAccountingPayment

Retrieve a payment

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Payment.GetAccountingPaymentAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Payment                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingPaymentResponse](../../Models/Requests/GetAccountingPaymentResponse.md)**


## ListAccountingPayments

List all payments

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Payment.ListAccountingPaymentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingPaymentsRequest](../../Models/Requests/ListAccountingPaymentsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListAccountingPaymentsResponse](../../Models/Requests/ListAccountingPaymentsResponse.md)**


## PatchAccountingPayment

Update a payment

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Payment.PatchAccountingPaymentAsync(ConnectionId: "string", Id: "string", AccountingPayment: new AccountingPayment() {
    InvoiceIds = new List<string>() {
        "string",
    },
    Raw = new PropertyAccountingPaymentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Payment                                                 |
| `AccountingPayment`                                               | [AccountingPayment](../../Models/Components/AccountingPayment.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[PatchAccountingPaymentResponse](../../Models/Requests/PatchAccountingPaymentResponse.md)**


## RemoveAccountingPayment

Remove a payment

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Payment.RemoveAccountingPaymentAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Payment    |


### Response

**[RemoveAccountingPaymentResponse](../../Models/Requests/RemoveAccountingPaymentResponse.md)**


## UpdateAccountingPayment

Update a payment

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Payment.UpdateAccountingPaymentAsync(ConnectionId: "string", Id: "string", AccountingPayment: new AccountingPayment() {
    InvoiceIds = new List<string>() {
        "string",
    },
    Raw = new PropertyAccountingPaymentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Payment                                                 |
| `AccountingPayment`                                               | [AccountingPayment](../../Models/Components/AccountingPayment.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[UpdateAccountingPaymentResponse](../../Models/Requests/UpdateAccountingPaymentResponse.md)**

