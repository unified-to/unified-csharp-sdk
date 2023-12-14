# Accounting
(*Accounting*)

### Available Operations

* [CreateAccountingAccount](#createaccountingaccount) - Create an account
* [CreateAccountingCustomer](#createaccountingcustomer) - Create a customer
* [CreateAccountingInvoice](#createaccountinginvoice) - Create a invoice
* [CreateAccountingPayment](#createaccountingpayment) - Create a payment
* [CreateAccountingTransaction](#createaccountingtransaction) - Create a transaction
* [GetAccountingAccount](#getaccountingaccount) - Retrieve an account
* [GetAccountingCustomer](#getaccountingcustomer) - Retrieve a customer
* [GetAccountingInvoice](#getaccountinginvoice) - Retrieve a invoice
* [GetAccountingPayment](#getaccountingpayment) - Retrieve a payment
* [GetAccountingTransaction](#getaccountingtransaction) - Retrieve a transaction
* [ListAccountingAccounts](#listaccountingaccounts) - List all accounts
* [ListAccountingCustomers](#listaccountingcustomers) - List all customers
* [ListAccountingInvoices](#listaccountinginvoices) - List all invoices
* [ListAccountingPayments](#listaccountingpayments) - List all payments
* [ListAccountingTransactions](#listaccountingtransactions) - List all transactions
* [PatchAccountingAccount](#patchaccountingaccount) - Update an account
* [PatchAccountingCustomer](#patchaccountingcustomer) - Update a customer
* [PatchAccountingInvoice](#patchaccountinginvoice) - Update a invoice
* [PatchAccountingPayment](#patchaccountingpayment) - Update a payment
* [PatchAccountingTransaction](#patchaccountingtransaction) - Update a transaction
* [RemoveAccountingAccount](#removeaccountingaccount) - Remove an account
* [RemoveAccountingCustomer](#removeaccountingcustomer) - Remove a customer
* [RemoveAccountingInvoice](#removeaccountinginvoice) - Remove a invoice
* [RemoveAccountingPayment](#removeaccountingpayment) - Remove a payment
* [RemoveAccountingTransaction](#removeaccountingtransaction) - Remove a transaction
* [UpdateAccountingAccount](#updateaccountingaccount) - Update an account
* [UpdateAccountingCustomer](#updateaccountingcustomer) - Update a customer
* [UpdateAccountingInvoice](#updateaccountinginvoice) - Update a invoice
* [UpdateAccountingPayment](#updateaccountingpayment) - Update a payment
* [UpdateAccountingTransaction](#updateaccountingtransaction) - Update a transaction

## CreateAccountingAccount

Create an account

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingAccountAsync(ConnectionId: "string", AccountingAccount: new AccountingAccount() {
    Name = "string",
    Raw = new PropertyAccountingAccountRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `AccountingAccount`                                               | [AccountingAccount](../../Models/Components/AccountingAccount.md) | :heavy_minus_sign:                                                | A user's bank account                                             |


### Response

**[CreateAccountingAccountResponse](../../Models/Requests/CreateAccountingAccountResponse.md)**


## CreateAccountingCustomer

Create a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingCustomerAsync(ConnectionId: "string", AccountingCustomer: new AccountingCustomer() {
    BillingAddress = new PropertyAccountingCustomerBillingAddress() {},
    Emails = new List<AccountingEmail>() {
        new AccountingEmail() {
            Email = "Kevon_Schultz42@gmail.com",
        },
    },
    Raw = new PropertyAccountingCustomerRaw() {},
    ShippingAddress = new PropertyAccountingCustomerShippingAddress() {},
    Telephones = new List<AccountingTelephone>() {
        new AccountingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `AccountingCustomer`                                                | [AccountingCustomer](../../Models/Components/AccountingCustomer.md) | :heavy_minus_sign:                                                  | N/A                                                                 |


### Response

**[CreateAccountingCustomerResponse](../../Models/Requests/CreateAccountingCustomerResponse.md)**


## CreateAccountingInvoice

Create a invoice

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingInvoiceAsync(ConnectionId: "string", AccountingInvoice: new AccountingInvoice() {
    Lineitems = new List<AccountingLineitem>() {
        new AccountingLineitem() {
            TotalAmount = 6736.06D,
        },
    },
    Raw = new PropertyAccountingInvoiceRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `AccountingInvoice`                                               | [AccountingInvoice](../../Models/Components/AccountingInvoice.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[CreateAccountingInvoiceResponse](../../Models/Requests/CreateAccountingInvoiceResponse.md)**


## CreateAccountingPayment

Create a payment

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingPaymentAsync(ConnectionId: "string", AccountingPayment: new AccountingPayment() {
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


## CreateAccountingTransaction

Create a transaction

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingTransactionAsync(ConnectionId: "string", AccountingTransaction: new AccountingTransaction() {
    AccountId = "string",
    Id = "<ID>",
    LineItems = new List<AccountingTransactionLineitem>() {
        new AccountingTransactionLineitem() {
            TotalAmount = 4969.62D,
        },
    },
    Raw = new PropertyAccountingTransactionRaw() {},
    TotalAmount = 6267.93D,
    Type = AccountingTransactionType.Spend,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | ID of the connection                                                      |
| `AccountingTransaction`                                                   | [AccountingTransaction](../../Models/Components/AccountingTransaction.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[CreateAccountingTransactionResponse](../../Models/Requests/CreateAccountingTransactionResponse.md)**


## GetAccountingAccount

Retrieve an account

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.GetAccountingAccountAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Account                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingAccountResponse](../../Models/Requests/GetAccountingAccountResponse.md)**


## GetAccountingCustomer

Retrieve a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.GetAccountingCustomerAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Customer               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingCustomerResponse](../../Models/Requests/GetAccountingCustomerResponse.md)**


## GetAccountingInvoice

Retrieve a invoice

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.GetAccountingInvoiceAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
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


## GetAccountingPayment

Retrieve a payment

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.GetAccountingPaymentAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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


## GetAccountingTransaction

Retrieve a transaction

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.GetAccountingTransactionAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Transaction            |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingTransactionResponse](../../Models/Requests/GetAccountingTransactionResponse.md)**


## ListAccountingAccounts

List all accounts

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Accounting.ListAccountingAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingAccountsRequest](../../Models/Requests/ListAccountingAccountsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListAccountingAccountsResponse](../../Models/Requests/ListAccountingAccountsResponse.md)**


## ListAccountingCustomers

List all customers

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingCustomersRequest req = new ListAccountingCustomersRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Accounting.ListAccountingCustomersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountingCustomersRequest](../../Models/Requests/ListAccountingCustomersRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountingCustomersResponse](../../Models/Requests/ListAccountingCustomersResponse.md)**


## ListAccountingInvoices

List all invoices

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Accounting.ListAccountingInvoicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingInvoicesRequest](../../Models/Requests/ListAccountingInvoicesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListAccountingInvoicesResponse](../../Models/Requests/ListAccountingInvoicesResponse.md)**


## ListAccountingPayments

List all payments

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
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

var res = await sdk.Accounting.ListAccountingPaymentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingPaymentsRequest](../../Models/Requests/ListAccountingPaymentsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListAccountingPaymentsResponse](../../Models/Requests/ListAccountingPaymentsResponse.md)**


## ListAccountingTransactions

List all transactions

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingTransactionsRequest req = new ListAccountingTransactionsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Accounting.ListAccountingTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingTransactionsRequest](../../Models/Requests/ListAccountingTransactionsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ListAccountingTransactionsResponse](../../Models/Requests/ListAccountingTransactionsResponse.md)**


## PatchAccountingAccount

Update an account

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.PatchAccountingAccountAsync(ConnectionId: "string", Id: "string", AccountingAccount: new AccountingAccount() {
    Name = "string",
    Raw = new PropertyAccountingAccountRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Account                                                 |
| `AccountingAccount`                                               | [AccountingAccount](../../Models/Components/AccountingAccount.md) | :heavy_minus_sign:                                                | A user's bank account                                             |


### Response

**[PatchAccountingAccountResponse](../../Models/Requests/PatchAccountingAccountResponse.md)**


## PatchAccountingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.PatchAccountingCustomerAsync(ConnectionId: "string", Id: "string", AccountingCustomer: new AccountingCustomer() {
    BillingAddress = new PropertyAccountingCustomerBillingAddress() {},
    Emails = new List<AccountingEmail>() {
        new AccountingEmail() {
            Email = "Trever_Orn@hotmail.com",
        },
    },
    Raw = new PropertyAccountingCustomerRaw() {},
    ShippingAddress = new PropertyAccountingCustomerShippingAddress() {},
    Telephones = new List<AccountingTelephone>() {
        new AccountingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Customer                                                  |
| `AccountingCustomer`                                                | [AccountingCustomer](../../Models/Components/AccountingCustomer.md) | :heavy_minus_sign:                                                  | N/A                                                                 |


### Response

**[PatchAccountingCustomerResponse](../../Models/Requests/PatchAccountingCustomerResponse.md)**


## PatchAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.PatchAccountingInvoiceAsync(ConnectionId: "string", Id: "string", AccountingInvoice: new AccountingInvoice() {
    Lineitems = new List<AccountingLineitem>() {
        new AccountingLineitem() {
            TotalAmount = 7374.1D,
        },
    },
    Raw = new PropertyAccountingInvoiceRaw() {},
});

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


## PatchAccountingPayment

Update a payment

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.PatchAccountingPaymentAsync(ConnectionId: "string", Id: "string", AccountingPayment: new AccountingPayment() {
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


## PatchAccountingTransaction

Update a transaction

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.PatchAccountingTransactionAsync(ConnectionId: "string", Id: "string", AccountingTransaction: new AccountingTransaction() {
    AccountId = "string",
    Id = "<ID>",
    LineItems = new List<AccountingTransactionLineitem>() {
        new AccountingTransactionLineitem() {
            TotalAmount = 5633.69D,
        },
    },
    Raw = new PropertyAccountingTransactionRaw() {},
    TotalAmount = 4558.63D,
    Type = AccountingTransactionType.Spend,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | ID of the connection                                                      |
| `Id`                                                                      | *string*                                                                  | :heavy_check_mark:                                                        | ID of the Transaction                                                     |
| `AccountingTransaction`                                                   | [AccountingTransaction](../../Models/Components/AccountingTransaction.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[PatchAccountingTransactionResponse](../../Models/Requests/PatchAccountingTransactionResponse.md)**


## RemoveAccountingAccount

Remove an account

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.RemoveAccountingAccountAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Account    |


### Response

**[RemoveAccountingAccountResponse](../../Models/Requests/RemoveAccountingAccountResponse.md)**


## RemoveAccountingCustomer

Remove a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.RemoveAccountingCustomerAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Customer   |


### Response

**[RemoveAccountingCustomerResponse](../../Models/Requests/RemoveAccountingCustomerResponse.md)**


## RemoveAccountingInvoice

Remove a invoice

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.RemoveAccountingInvoiceAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Invoice    |


### Response

**[RemoveAccountingInvoiceResponse](../../Models/Requests/RemoveAccountingInvoiceResponse.md)**


## RemoveAccountingPayment

Remove a payment

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.RemoveAccountingPaymentAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Payment    |


### Response

**[RemoveAccountingPaymentResponse](../../Models/Requests/RemoveAccountingPaymentResponse.md)**


## RemoveAccountingTransaction

Remove a transaction

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.RemoveAccountingTransactionAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Transaction |


### Response

**[RemoveAccountingTransactionResponse](../../Models/Requests/RemoveAccountingTransactionResponse.md)**


## UpdateAccountingAccount

Update an account

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.UpdateAccountingAccountAsync(ConnectionId: "string", Id: "string", AccountingAccount: new AccountingAccount() {
    Name = "string",
    Raw = new PropertyAccountingAccountRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Account                                                 |
| `AccountingAccount`                                               | [AccountingAccount](../../Models/Components/AccountingAccount.md) | :heavy_minus_sign:                                                | A user's bank account                                             |


### Response

**[UpdateAccountingAccountResponse](../../Models/Requests/UpdateAccountingAccountResponse.md)**


## UpdateAccountingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.UpdateAccountingCustomerAsync(ConnectionId: "string", Id: "string", AccountingCustomer: new AccountingCustomer() {
    BillingAddress = new PropertyAccountingCustomerBillingAddress() {},
    Emails = new List<AccountingEmail>() {
        new AccountingEmail() {
            Email = "Myrtice_Jacobi77@hotmail.com",
        },
    },
    Raw = new PropertyAccountingCustomerRaw() {},
    ShippingAddress = new PropertyAccountingCustomerShippingAddress() {},
    Telephones = new List<AccountingTelephone>() {
        new AccountingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Customer                                                  |
| `AccountingCustomer`                                                | [AccountingCustomer](../../Models/Components/AccountingCustomer.md) | :heavy_minus_sign:                                                  | N/A                                                                 |


### Response

**[UpdateAccountingCustomerResponse](../../Models/Requests/UpdateAccountingCustomerResponse.md)**


## UpdateAccountingInvoice

Update a invoice

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.UpdateAccountingInvoiceAsync(ConnectionId: "string", Id: "string", AccountingInvoice: new AccountingInvoice() {
    Lineitems = new List<AccountingLineitem>() {
        new AccountingLineitem() {
            TotalAmount = 6974.28D,
        },
    },
    Raw = new PropertyAccountingInvoiceRaw() {},
});

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


## UpdateAccountingPayment

Update a payment

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.UpdateAccountingPaymentAsync(ConnectionId: "string", Id: "string", AccountingPayment: new AccountingPayment() {
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


## UpdateAccountingTransaction

Update a transaction

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.UpdateAccountingTransactionAsync(ConnectionId: "string", Id: "string", AccountingTransaction: new AccountingTransaction() {
    AccountId = "string",
    Id = "<ID>",
    LineItems = new List<AccountingTransactionLineitem>() {
        new AccountingTransactionLineitem() {
            TotalAmount = 6498.37D,
        },
    },
    Raw = new PropertyAccountingTransactionRaw() {},
    TotalAmount = 5659.17D,
    Type = AccountingTransactionType.Spend,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | ID of the connection                                                      |
| `Id`                                                                      | *string*                                                                  | :heavy_check_mark:                                                        | ID of the Transaction                                                     |
| `AccountingTransaction`                                                   | [AccountingTransaction](../../Models/Components/AccountingTransaction.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[UpdateAccountingTransactionResponse](../../Models/Requests/UpdateAccountingTransactionResponse.md)**

