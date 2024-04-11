# Invoice
(*Invoice*)

### Available Operations

* [CreateAccountingInvoice](#createaccountinginvoice) - Create an invoice
* [GetAccountingInvoice](#getaccountinginvoice) - Retrieve an invoice
* [ListAccountingInvoices](#listaccountinginvoices) - List all invoices
* [PatchAccountingInvoice](#patchaccountinginvoice) - Update an invoice
* [RemoveAccountingInvoice](#removeaccountinginvoice) - Remove an invoice
* [UpdateAccountingInvoice](#updateaccountinginvoice) - Update an invoice

## CreateAccountingInvoice

Create an invoice

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetAccountingInvoice

Retrieve an invoice

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchAccountingInvoice

Update an invoice

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveAccountingInvoice

Remove an invoice

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateAccountingInvoice

Update an invoice

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
