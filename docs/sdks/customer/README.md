# Customer
(*Customer*)

### Available Operations

* [CreateAccountingCustomer](#createaccountingcustomer) - Create a customer
* [CreateTicketingCustomer](#createticketingcustomer) - Create a customer
* [GetAccountingCustomer](#getaccountingcustomer) - Retrieve a customer
* [GetTicketingCustomer](#getticketingcustomer) - Retrieve a customer
* [ListAccountingCustomers](#listaccountingcustomers) - List all customers
* [ListTicketingCustomers](#listticketingcustomers) - List all customers
* [PatchAccountingCustomer](#patchaccountingcustomer) - Update a customer
* [PatchTicketingCustomer](#patchticketingcustomer) - Update a customer
* [RemoveAccountingCustomer](#removeaccountingcustomer) - Remove a customer
* [RemoveTicketingCustomer](#removeticketingcustomer) - Remove a customer
* [UpdateAccountingCustomer](#updateaccountingcustomer) - Update a customer
* [UpdateTicketingCustomer](#updateticketingcustomer) - Update a customer

## CreateAccountingCustomer

Create a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.CreateAccountingCustomerAsync("string", new AccountingCustomer() {
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


## CreateTicketingCustomer

Create a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.CreateTicketingCustomerAsync("string", new TicketingCustomer() {
    Emails = new List<TicketingEmail>() {
        new TicketingEmail() {
            Email = "Guadalupe78@yahoo.com",
        },
    },
    Raw = new PropertyTicketingCustomerRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<TicketingTelephone>() {
        new TicketingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `TicketingCustomer`                                               | [TicketingCustomer](../../Models/Components/TicketingCustomer.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[CreateTicketingCustomerResponse](../../Models/Requests/CreateTicketingCustomerResponse.md)**


## GetAccountingCustomer

Retrieve a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.GetAccountingCustomerAsync("string", "string", new List<string>() {
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


## GetTicketingCustomer

Retrieve a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.GetTicketingCustomerAsync("string", "string", new List<string>() {
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

**[GetTicketingCustomerResponse](../../Models/Requests/GetTicketingCustomerResponse.md)**


## ListAccountingCustomers

List all customers

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.ListAccountingCustomersAsync(new ListAccountingCustomersRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountingCustomersRequest](../../Models/Requests/ListAccountingCustomersRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountingCustomersResponse](../../Models/Requests/ListAccountingCustomersResponse.md)**


## ListTicketingCustomers

List all customers

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.ListTicketingCustomersAsync(new ListTicketingCustomersRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListTicketingCustomersRequest](../../Models/Requests/ListTicketingCustomersRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListTicketingCustomersResponse](../../Models/Requests/ListTicketingCustomersResponse.md)**


## PatchAccountingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.PatchAccountingCustomerAsync("string", "string", new AccountingCustomer() {
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


## PatchTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.PatchTicketingCustomerAsync("string", "string", new TicketingCustomer() {
    Emails = new List<TicketingEmail>() {
        new TicketingEmail() {
            Email = "Raymundo93@hotmail.com",
        },
    },
    Raw = new PropertyTicketingCustomerRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<TicketingTelephone>() {
        new TicketingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Customer                                                |
| `TicketingCustomer`                                               | [TicketingCustomer](../../Models/Components/TicketingCustomer.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[PatchTicketingCustomerResponse](../../Models/Requests/PatchTicketingCustomerResponse.md)**


## RemoveAccountingCustomer

Remove a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Customer.RemoveAccountingCustomerAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Customer   |


### Response

**[RemoveAccountingCustomerResponse](../../Models/Requests/RemoveAccountingCustomerResponse.md)**


## RemoveTicketingCustomer

Remove a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Customer.RemoveTicketingCustomerAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Customer   |


### Response

**[RemoveTicketingCustomerResponse](../../Models/Requests/RemoveTicketingCustomerResponse.md)**


## UpdateAccountingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.UpdateAccountingCustomerAsync("string", "string", new AccountingCustomer() {
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


## UpdateTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Customer.UpdateTicketingCustomerAsync("string", "string", new TicketingCustomer() {
    Emails = new List<TicketingEmail>() {
        new TicketingEmail() {
            Email = "Mohamed.Friesen@hotmail.com",
        },
    },
    Raw = new PropertyTicketingCustomerRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<TicketingTelephone>() {
        new TicketingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Customer                                                |
| `TicketingCustomer`                                               | [TicketingCustomer](../../Models/Components/TicketingCustomer.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[UpdateTicketingCustomerResponse](../../Models/Requests/UpdateTicketingCustomerResponse.md)**

