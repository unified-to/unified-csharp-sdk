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
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Invoice.CreateAccountingInvoiceAsync(
    connectionId: "<value>",
    accountingInvoice: new AccountingInvoice() {});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `AccountingInvoice`                                               | [AccountingInvoice](../../Models/Components/AccountingInvoice.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[CreateAccountingInvoiceResponse](../../Models/Requests/CreateAccountingInvoiceResponse.md)**


## GetAccountingInvoice

Retrieve a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Invoice.GetAccountingInvoiceAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Invoice                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingInvoiceResponse](../../Models/Requests/GetAccountingInvoiceResponse.md)**


## ListAccountingInvoices

List all invoices

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Invoice.ListAccountingInvoicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingInvoicesRequest](../../Models/Requests/ListAccountingInvoicesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListAccountingInvoicesResponse](../../Models/Requests/ListAccountingInvoicesResponse.md)**


## PatchAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Invoice.PatchAccountingInvoiceAsync(
    connectionId: "<value>",
    id: "<value>",
    accountingInvoice: new AccountingInvoice() {});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Invoice                                                 |
| `AccountingInvoice`                                               | [AccountingInvoice](../../Models/Components/AccountingInvoice.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[PatchAccountingInvoiceResponse](../../Models/Requests/PatchAccountingInvoiceResponse.md)**


## RemoveAccountingInvoice

Remove a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Invoice.RemoveAccountingInvoiceAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Invoice    |


### Response

**[RemoveAccountingInvoiceResponse](../../Models/Requests/RemoveAccountingInvoiceResponse.md)**


## UpdateAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Invoice.UpdateAccountingInvoiceAsync(
    connectionId: "<value>",
    id: "<value>",
    accountingInvoice: new AccountingInvoice() {});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Invoice                                                 |
| `AccountingInvoice`                                               | [AccountingInvoice](../../Models/Components/AccountingInvoice.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[UpdateAccountingInvoiceResponse](../../Models/Requests/UpdateAccountingInvoiceResponse.md)**

