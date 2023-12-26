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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.CreateAccountingCustomerAsync(ConnectionId: "string", AccountingCustomer: new AccountingCustomer() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.CreateTicketingCustomerAsync(ConnectionId: "string", TicketingCustomer: new TicketingCustomer() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.GetAccountingCustomerAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.GetTicketingCustomerAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
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

var res = await sdk.Customer.ListAccountingCustomersAsync(req);

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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListTicketingCustomersRequest req = new ListTicketingCustomersRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Customer.ListTicketingCustomersAsync(req);

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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.PatchAccountingCustomerAsync(ConnectionId: "string", Id: "string", AccountingCustomer: new AccountingCustomer() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.PatchTicketingCustomerAsync(ConnectionId: "string", Id: "string", TicketingCustomer: new TicketingCustomer() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.RemoveAccountingCustomerAsync(ConnectionId: "string", Id: "string");

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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.RemoveTicketingCustomerAsync(ConnectionId: "string", Id: "string");

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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.UpdateAccountingCustomerAsync(ConnectionId: "string", Id: "string", AccountingCustomer: new AccountingCustomer() {
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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Customer.UpdateTicketingCustomerAsync(ConnectionId: "string", Id: "string", TicketingCustomer: new TicketingCustomer() {
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

