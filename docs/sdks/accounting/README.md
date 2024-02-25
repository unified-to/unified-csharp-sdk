# Accounting
(*Accounting*)

### Available Operations

* [CreateAccountingAccount](#createaccountingaccount) - Create an account
* [CreateAccountingContact](#createaccountingcontact) - Create a contact
* [CreateAccountingInvoice](#createaccountinginvoice) - Create a invoice
* [CreateAccountingPayment](#createaccountingpayment) - Create a payment
* [CreateAccountingTaxrate](#createaccountingtaxrate) - Create a taxrate
* [CreateAccountingTransaction](#createaccountingtransaction) - Create a transaction
* [GetAccountingAccount](#getaccountingaccount) - Retrieve an account
* [GetAccountingContact](#getaccountingcontact) - Retrieve a contact
* [GetAccountingInvoice](#getaccountinginvoice) - Retrieve a invoice
* [GetAccountingOrganization](#getaccountingorganization) - Retrieve an organization
* [GetAccountingPayment](#getaccountingpayment) - Retrieve a payment
* [GetAccountingPayout](#getaccountingpayout) - Retrieve a payout
* [GetAccountingRefund](#getaccountingrefund) - Retrieve a refund
* [GetAccountingTaxrate](#getaccountingtaxrate) - Retrieve a taxrate
* [GetAccountingTransaction](#getaccountingtransaction) - Retrieve a transaction
* [ListAccountingAccounts](#listaccountingaccounts) - List all accounts
* [ListAccountingContacts](#listaccountingcontacts) - List all contacts
* [ListAccountingInvoices](#listaccountinginvoices) - List all invoices
* [ListAccountingOrganizations](#listaccountingorganizations) - List all organizations
* [ListAccountingPayments](#listaccountingpayments) - List all payments
* [ListAccountingPayouts](#listaccountingpayouts) - List all payouts
* [ListAccountingRefunds](#listaccountingrefunds) - List all refunds
* [ListAccountingTaxrates](#listaccountingtaxrates) - List all taxrates
* [ListAccountingTransactions](#listaccountingtransactions) - List all transactions
* [PatchAccountingAccount](#patchaccountingaccount) - Update an account
* [PatchAccountingContact](#patchaccountingcontact) - Update a contact
* [PatchAccountingInvoice](#patchaccountinginvoice) - Update a invoice
* [PatchAccountingPayment](#patchaccountingpayment) - Update a payment
* [PatchAccountingTaxrate](#patchaccountingtaxrate) - Update a taxrate
* [PatchAccountingTransaction](#patchaccountingtransaction) - Update a transaction
* [RemoveAccountingAccount](#removeaccountingaccount) - Remove an account
* [RemoveAccountingContact](#removeaccountingcontact) - Remove a contact
* [RemoveAccountingInvoice](#removeaccountinginvoice) - Remove a invoice
* [RemoveAccountingPayment](#removeaccountingpayment) - Remove a payment
* [RemoveAccountingTaxrate](#removeaccountingtaxrate) - Remove a taxrate
* [RemoveAccountingTransaction](#removeaccountingtransaction) - Remove a transaction
* [UpdateAccountingAccount](#updateaccountingaccount) - Update an account
* [UpdateAccountingContact](#updateaccountingcontact) - Update a contact
* [UpdateAccountingInvoice](#updateaccountinginvoice) - Update a invoice
* [UpdateAccountingPayment](#updateaccountingpayment) - Update a payment
* [UpdateAccountingTaxrate](#updateaccountingtaxrate) - Update a taxrate
* [UpdateAccountingTransaction](#updateaccountingtransaction) - Update a transaction

## CreateAccountingAccount

Create an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    security: new CreateAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingAccountSecurity](../../Models/Requests/CreateAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingAccount`                                                                                                   | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingAccountResponse](../../Models/Requests/CreateAccountingAccountResponse.md)**


## CreateAccountingContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingContactAsync(
    security: new CreateAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingContact: new AccountingContact() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingContactSecurity](../../Models/Requests/CreateAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingContact`                                                                                                   | [AccountingContact](../../Models/Components/AccountingContact.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingContactResponse](../../Models/Requests/CreateAccountingContactResponse.md)**


## CreateAccountingInvoice

Create a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingInvoiceAsync(
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


## CreateAccountingPayment

Create a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingPaymentAsync(
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


## CreateAccountingTaxrate

Create a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingTaxrateAsync(
    security: new CreateAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingTaxrate: new AccountingTaxrate() {
    Name = "<value>",
    Rate = 1719.1D,
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingTaxrateSecurity](../../Models/Requests/CreateAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingTaxrate`                                                                                                   | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingTaxrateResponse](../../Models/Requests/CreateAccountingTaxrateResponse.md)**


## CreateAccountingTransaction

Create a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingTransactionAsync(
    security: new CreateAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingTransaction: new AccountingTransaction() {
    Id = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.CreateAccountingTransactionSecurity](../../Models/Requests/CreateAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `ConnectionId`                                                                                                                | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the connection                                                                                                          |
| `AccountingTransaction`                                                                                                       | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                     | :heavy_minus_sign:                                                                                                            | N/A                                                                                                                           |


### Response

**[CreateAccountingTransactionResponse](../../Models/Requests/CreateAccountingTransactionResponse.md)**


## GetAccountingAccount

Retrieve an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingAccountAsync(
    security: new GetAccountingAccountSecurity() {
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
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingAccountSecurity](../../Models/Requests/GetAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Account                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingAccountResponse](../../Models/Requests/GetAccountingAccountResponse.md)**


## GetAccountingContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingContactAsync(
    security: new GetAccountingContactSecurity() {
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
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingContactSecurity](../../Models/Requests/GetAccountingContactSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Contact                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingContactResponse](../../Models/Requests/GetAccountingContactResponse.md)**


## GetAccountingInvoice

Retrieve a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingInvoiceAsync(
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


## GetAccountingOrganization

Retrieve an organization

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingOrganizationAsync(
    security: new GetAccountingOrganizationSecurity() {
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

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                | [UnifiedTo.Models.Requests.GetAccountingOrganizationSecurity](../../Models/Requests/GetAccountingOrganizationSecurity.md) | :heavy_check_mark:                                                                                                        | The security requirements to use for the request.                                                                         |
| `ConnectionId`                                                                                                            | *string*                                                                                                                  | :heavy_check_mark:                                                                                                        | ID of the connection                                                                                                      |
| `Id`                                                                                                                      | *string*                                                                                                                  | :heavy_check_mark:                                                                                                        | ID of the Organization                                                                                                    |
| `Fields`                                                                                                                  | List<*string*>                                                                                                            | :heavy_minus_sign:                                                                                                        | Comma-delimited fields to return                                                                                          |


### Response

**[GetAccountingOrganizationResponse](../../Models/Requests/GetAccountingOrganizationResponse.md)**


## GetAccountingPayment

Retrieve a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingPaymentAsync(
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


## GetAccountingPayout

Retrieve a payout

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingPayoutAsync(
    security: new GetAccountingPayoutSecurity() {
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
| `security`                                                                                                    | [UnifiedTo.Models.Requests.GetAccountingPayoutSecurity](../../Models/Requests/GetAccountingPayoutSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Payout                                                                                              |
| `Fields`                                                                                                      | List<*string*>                                                                                                | :heavy_minus_sign:                                                                                            | Comma-delimited fields to return                                                                              |


### Response

**[GetAccountingPayoutResponse](../../Models/Requests/GetAccountingPayoutResponse.md)**


## GetAccountingRefund

Retrieve a refund

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingRefundAsync(
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


## GetAccountingTaxrate

Retrieve a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingTaxrateAsync(
    security: new GetAccountingTaxrateSecurity() {
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
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingTaxrateSecurity](../../Models/Requests/GetAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Taxrate                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingTaxrateResponse](../../Models/Requests/GetAccountingTaxrateResponse.md)**


## GetAccountingTransaction

Retrieve a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.GetAccountingTransactionAsync(
    security: new GetAccountingTransactionSecurity() {
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

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                              | [UnifiedTo.Models.Requests.GetAccountingTransactionSecurity](../../Models/Requests/GetAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                      | The security requirements to use for the request.                                                                       |
| `ConnectionId`                                                                                                          | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the connection                                                                                                    |
| `Id`                                                                                                                    | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | ID of the Transaction                                                                                                   |
| `Fields`                                                                                                                | List<*string*>                                                                                                          | :heavy_minus_sign:                                                                                                      | Comma-delimited fields to return                                                                                        |


### Response

**[GetAccountingTransactionResponse](../../Models/Requests/GetAccountingTransactionResponse.md)**


## ListAccountingAccounts

List all accounts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Accounting.ListAccountingAccountsAsync(
    security: new ListAccountingAccountsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingAccountsRequest](../../Models/Requests/ListAccountingAccountsRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingAccountsSecurity](../../Models/Requests/ListAccountingAccountsSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingAccountsResponse](../../Models/Requests/ListAccountingAccountsResponse.md)**


## ListAccountingContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingContactsRequest req = new ListAccountingContactsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Accounting.ListAccountingContactsAsync(
    security: new ListAccountingContactsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingContactsRequest](../../Models/Requests/ListAccountingContactsRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingContactsSecurity](../../Models/Requests/ListAccountingContactsSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingContactsResponse](../../Models/Requests/ListAccountingContactsResponse.md)**


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

var res = await sdk.Accounting.ListAccountingInvoicesAsync(
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


## ListAccountingOrganizations

List all organizations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingOrganizationsRequest req = new ListAccountingOrganizationsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Accounting.ListAccountingOrganizationsAsync(
    security: new ListAccountingOrganizationsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                     | [ListAccountingOrganizationsRequest](../../Models/Requests/ListAccountingOrganizationsRequest.md)                             | :heavy_check_mark:                                                                                                            | The request object to use for the request.                                                                                    |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.ListAccountingOrganizationsSecurity](../../Models/Requests/ListAccountingOrganizationsSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |


### Response

**[ListAccountingOrganizationsResponse](../../Models/Requests/ListAccountingOrganizationsResponse.md)**


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

var res = await sdk.Accounting.ListAccountingPaymentsAsync(
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


## ListAccountingPayouts

List all payouts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingPayoutsRequest req = new ListAccountingPayoutsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Accounting.ListAccountingPayoutsAsync(
    security: new ListAccountingPayoutsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [ListAccountingPayoutsRequest](../../Models/Requests/ListAccountingPayoutsRequest.md)                             | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.ListAccountingPayoutsSecurity](../../Models/Requests/ListAccountingPayoutsSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |


### Response

**[ListAccountingPayoutsResponse](../../Models/Requests/ListAccountingPayoutsResponse.md)**


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

var res = await sdk.Accounting.ListAccountingRefundsAsync(
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


## ListAccountingTaxrates

List all taxrates

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingTaxratesRequest req = new ListAccountingTaxratesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Accounting.ListAccountingTaxratesAsync(
    security: new ListAccountingTaxratesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingTaxratesRequest](../../Models/Requests/ListAccountingTaxratesRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingTaxratesSecurity](../../Models/Requests/ListAccountingTaxratesSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingTaxratesResponse](../../Models/Requests/ListAccountingTaxratesResponse.md)**


## ListAccountingTransactions

List all transactions

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingTransactionsRequest req = new ListAccountingTransactionsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Accounting.ListAccountingTransactionsAsync(
    security: new ListAccountingTransactionsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [ListAccountingTransactionsRequest](../../Models/Requests/ListAccountingTransactionsRequest.md)                             | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |
| `security`                                                                                                                  | [UnifiedTo.Models.Requests.ListAccountingTransactionsSecurity](../../Models/Requests/ListAccountingTransactionsSecurity.md) | :heavy_check_mark:                                                                                                          | The security requirements to use for the request.                                                                           |


### Response

**[ListAccountingTransactionsResponse](../../Models/Requests/ListAccountingTransactionsResponse.md)**


## PatchAccountingAccount

Update an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.PatchAccountingAccountAsync(
    security: new PatchAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingAccountSecurity](../../Models/Requests/PatchAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Account                                                                                                   |
| `AccountingAccount`                                                                                                 | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingAccountResponse](../../Models/Requests/PatchAccountingAccountResponse.md)**


## PatchAccountingContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.PatchAccountingContactAsync(
    security: new PatchAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingContact: new AccountingContact() {});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingContactSecurity](../../Models/Requests/PatchAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Contact                                                                                                   |
| `AccountingContact`                                                                                                 | [AccountingContact](../../Models/Components/AccountingContact.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingContactResponse](../../Models/Requests/PatchAccountingContactResponse.md)**


## PatchAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.PatchAccountingInvoiceAsync(
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


## PatchAccountingPayment

Update a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.PatchAccountingPaymentAsync(
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


## PatchAccountingTaxrate

Update a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.PatchAccountingTaxrateAsync(
    security: new PatchAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTaxrate: new AccountingTaxrate() {
    Name = "<value>",
    Rate = 5991.47D,
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingTaxrateSecurity](../../Models/Requests/PatchAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Taxrate                                                                                                   |
| `AccountingTaxrate`                                                                                                 | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingTaxrateResponse](../../Models/Requests/PatchAccountingTaxrateResponse.md)**


## PatchAccountingTransaction

Update a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.PatchAccountingTransactionAsync(
    security: new PatchAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTransaction: new AccountingTransaction() {
    Id = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                  | [UnifiedTo.Models.Requests.PatchAccountingTransactionSecurity](../../Models/Requests/PatchAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                          | The security requirements to use for the request.                                                                           |
| `ConnectionId`                                                                                                              | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | ID of the connection                                                                                                        |
| `Id`                                                                                                                        | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | ID of the Transaction                                                                                                       |
| `AccountingTransaction`                                                                                                     | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                   | :heavy_minus_sign:                                                                                                          | N/A                                                                                                                         |


### Response

**[PatchAccountingTransactionResponse](../../Models/Requests/PatchAccountingTransactionResponse.md)**


## RemoveAccountingAccount

Remove an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.RemoveAccountingAccountAsync(
    security: new RemoveAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingAccountSecurity](../../Models/Requests/RemoveAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Account                                                                                                     |


### Response

**[RemoveAccountingAccountResponse](../../Models/Requests/RemoveAccountingAccountResponse.md)**


## RemoveAccountingContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.RemoveAccountingContactAsync(
    security: new RemoveAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingContactSecurity](../../Models/Requests/RemoveAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Contact                                                                                                     |


### Response

**[RemoveAccountingContactResponse](../../Models/Requests/RemoveAccountingContactResponse.md)**


## RemoveAccountingInvoice

Remove a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.RemoveAccountingInvoiceAsync(
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


## RemoveAccountingPayment

Remove a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.RemoveAccountingPaymentAsync(
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


## RemoveAccountingTaxrate

Remove a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.RemoveAccountingTaxrateAsync(
    security: new RemoveAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingTaxrateSecurity](../../Models/Requests/RemoveAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Taxrate                                                                                                     |


### Response

**[RemoveAccountingTaxrateResponse](../../Models/Requests/RemoveAccountingTaxrateResponse.md)**


## RemoveAccountingTransaction

Remove a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.RemoveAccountingTransactionAsync(
    security: new RemoveAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.RemoveAccountingTransactionSecurity](../../Models/Requests/RemoveAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `ConnectionId`                                                                                                                | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the connection                                                                                                          |
| `Id`                                                                                                                          | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the Transaction                                                                                                         |


### Response

**[RemoveAccountingTransactionResponse](../../Models/Requests/RemoveAccountingTransactionResponse.md)**


## UpdateAccountingAccount

Update an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.UpdateAccountingAccountAsync(
    security: new UpdateAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingAccountSecurity](../../Models/Requests/UpdateAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Account                                                                                                     |
| `AccountingAccount`                                                                                                   | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingAccountResponse](../../Models/Requests/UpdateAccountingAccountResponse.md)**


## UpdateAccountingContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.UpdateAccountingContactAsync(
    security: new UpdateAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingContact: new AccountingContact() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingContactSecurity](../../Models/Requests/UpdateAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Contact                                                                                                     |
| `AccountingContact`                                                                                                   | [AccountingContact](../../Models/Components/AccountingContact.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingContactResponse](../../Models/Requests/UpdateAccountingContactResponse.md)**


## UpdateAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.UpdateAccountingInvoiceAsync(
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


## UpdateAccountingPayment

Update a payment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.UpdateAccountingPaymentAsync(
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


## UpdateAccountingTaxrate

Update a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.UpdateAccountingTaxrateAsync(
    security: new UpdateAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTaxrate: new AccountingTaxrate() {
    Name = "<value>",
    Rate = 3382.78D,
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingTaxrateSecurity](../../Models/Requests/UpdateAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Taxrate                                                                                                     |
| `AccountingTaxrate`                                                                                                   | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingTaxrateResponse](../../Models/Requests/UpdateAccountingTaxrateResponse.md)**


## UpdateAccountingTransaction

Update a transaction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.UpdateAccountingTransactionAsync(
    security: new UpdateAccountingTransactionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTransaction: new AccountingTransaction() {
    Id = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.UpdateAccountingTransactionSecurity](../../Models/Requests/UpdateAccountingTransactionSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `ConnectionId`                                                                                                                | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the connection                                                                                                          |
| `Id`                                                                                                                          | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the Transaction                                                                                                         |
| `AccountingTransaction`                                                                                                       | [AccountingTransaction](../../Models/Components/AccountingTransaction.md)                                                     | :heavy_minus_sign:                                                                                                            | N/A                                                                                                                           |


### Response

**[UpdateAccountingTransactionResponse](../../Models/Requests/UpdateAccountingTransactionResponse.md)**

