# Customer
(*Customer*)

### Available Operations

* [CreateTicketingCustomer](#createticketingcustomer) - Create a customer
* [GetTicketingCustomer](#getticketingcustomer) - Retrieve a customer
* [ListTicketingCustomers](#listticketingcustomers) - List all customers
* [PatchTicketingCustomer](#patchticketingcustomer) - Update a customer
* [RemoveTicketingCustomer](#removeticketingcustomer) - Remove a customer
* [UpdateTicketingCustomer](#updateticketingcustomer) - Update a customer

## CreateTicketingCustomer

Create a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
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


## GetTicketingCustomer

Retrieve a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
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


## ListTicketingCustomers

List all customers

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
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


## PatchTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
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


## RemoveTicketingCustomer

Remove a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
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


## UpdateTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
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

