# Invoice
(*Invoice*)

### Available Operations

* [CreateAccountingInvoice](#createaccountinginvoice) - Create a invoice
* [GetAccountingInvoice](#getaccountinginvoice) - Retrieve a invoice
* [ListAccountingInvoices](#listaccountinginvoices) - List all invoices
* [PatchAccountingInvoice](#patchaccountinginvoice) - Update a invoice
* [RemoveAccountingInvoice](#removeaccountinginvoice) - Remove a invoice
* [UpdateAccountingInvoice](#updateaccountinginvoice) - Update a invoice

## CreateAccountingInvoice

Create a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Invoice.CreateAccountingInvoiceAsync(
    security: new CreateAccountingInvoiceSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingInvoice: new AccountingInvoice() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingInvoiceSecurity](../../Models/Requests/CreateAccountingInvoiceSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingInvoice`                                                                                                   | [AccountingInvoice](../../Models/Components/AccountingInvoice.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingInvoiceResponse](../../Models/Requests/CreateAccountingInvoiceResponse.md)**


## GetAccountingInvoice

Retrieve a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Invoice.GetAccountingInvoiceAsync(
    security: new GetAccountingInvoiceSecurity() {
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
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingInvoiceSecurity](../../Models/Requests/GetAccountingInvoiceSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Invoice                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingInvoiceResponse](../../Models/Requests/GetAccountingInvoiceResponse.md)**


## ListAccountingInvoices

List all invoices

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Invoice.ListAccountingInvoicesAsync(
    security: new ListAccountingInvoicesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingInvoicesRequest](../../Models/Requests/ListAccountingInvoicesRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingInvoicesSecurity](../../Models/Requests/ListAccountingInvoicesSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingInvoicesResponse](../../Models/Requests/ListAccountingInvoicesResponse.md)**


## PatchAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Invoice.PatchAccountingInvoiceAsync(
    security: new PatchAccountingInvoiceSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingInvoice: new AccountingInvoice() {});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingInvoiceSecurity](../../Models/Requests/PatchAccountingInvoiceSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Invoice                                                                                                   |
| `AccountingInvoice`                                                                                                 | [AccountingInvoice](../../Models/Components/AccountingInvoice.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingInvoiceResponse](../../Models/Requests/PatchAccountingInvoiceResponse.md)**


## RemoveAccountingInvoice

Remove a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Invoice.RemoveAccountingInvoiceAsync(
    security: new RemoveAccountingInvoiceSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingInvoiceSecurity](../../Models/Requests/RemoveAccountingInvoiceSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Invoice                                                                                                     |


### Response

**[RemoveAccountingInvoiceResponse](../../Models/Requests/RemoveAccountingInvoiceResponse.md)**


## UpdateAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Invoice.UpdateAccountingInvoiceAsync(
    security: new UpdateAccountingInvoiceSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingInvoice: new AccountingInvoice() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingInvoiceSecurity](../../Models/Requests/UpdateAccountingInvoiceSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Invoice                                                                                                     |
| `AccountingInvoice`                                                                                                   | [AccountingInvoice](../../Models/Components/AccountingInvoice.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingInvoiceResponse](../../Models/Requests/UpdateAccountingInvoiceResponse.md)**

