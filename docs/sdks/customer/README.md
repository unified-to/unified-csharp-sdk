# Customer

## Overview

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

<!-- UsageSnippet language="csharp" operationID="createTicketingCustomer" method="post" path="/ticketing/{connection_id}/customer" example="ticketing_customer" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Customer.CreateTicketingCustomerAsync(
    ticketingCustomer: new TicketingCustomer() {
        CreatedAt = System.DateTime.Parse("2021-03-15T12:33:14.875Z").ToUniversalTime(),
        Emails = new List<TicketingEmail>() {
            new TicketingEmail() {
                Email = "Christian_Windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "e4eda98a-50de-46a3-969f-b9ed09d9be62",
        Name = "Christian Windler",
        Tags = new List<string>() {
            "casso",
            "peccatus",
        },
        Telephones = new List<TicketingTelephone>() {
            new TicketingTelephone() {
                Telephone = "(532) 242-0482",
                Type = TicketingTelephoneType.Other,
            },
            new TicketingTelephone() {
                Telephone = "(826) 283-7431",
                Type = TicketingTelephoneType.Mobile,
            },
            new TicketingTelephone() {
                Telephone = "(483) 314-6826",
                Type = TicketingTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-05-04T07:40:10.066Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TicketingCustomer`                                                                                                                              | [TicketingCustomer](../../Models/Components/TicketingCustomer.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTicketingCustomerQueryParamFields](../../Models/Requests/CreateTicketingCustomerQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTicketingCustomerResponse](../../Models/Requests/CreateTicketingCustomerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTicketingCustomer

Retrieve a customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTicketingCustomer" method="get" path="/ticketing/{connection_id}/customer/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Customer.GetTicketingCustomerAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Customer                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetTicketingCustomerQueryParamFields](../../Models/Requests/GetTicketingCustomerQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTicketingCustomerResponse](../../Models/Requests/GetTicketingCustomerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTicketingCustomers

List all customers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTicketingCustomers" method="get" path="/ticketing/{connection_id}/customer" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTicketingCustomersRequest req = new ListTicketingCustomersRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchTicketingCustomer

Update a customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTicketingCustomer" method="patch" path="/ticketing/{connection_id}/customer/{id}" example="ticketing_customer" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTicketingCustomerRequest req = new PatchTicketingCustomerRequest() {
    TicketingCustomer = new TicketingCustomer() {
        CreatedAt = System.DateTime.Parse("2021-03-15T12:33:14.875Z").ToUniversalTime(),
        Emails = new List<TicketingEmail>() {
            new TicketingEmail() {
                Email = "Christian_Windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "9693c0c0-2580-43e7-b5e8-50ed01af5e16",
        Name = "Christian Windler",
        Tags = new List<string>() {
            "casso",
            "peccatus",
        },
        Telephones = new List<TicketingTelephone>() {
            new TicketingTelephone() {
                Telephone = "(532) 242-0482",
                Type = TicketingTelephoneType.Other,
            },
            new TicketingTelephone() {
                Telephone = "(826) 283-7431",
                Type = TicketingTelephoneType.Mobile,
            },
            new TicketingTelephone() {
                Telephone = "(483) 314-6826",
                Type = TicketingTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-05-04T07:40:10.076Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Customer.PatchTicketingCustomerAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchTicketingCustomerRequest](../../Models/Requests/PatchTicketingCustomerRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchTicketingCustomerResponse](../../Models/Requests/PatchTicketingCustomerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveTicketingCustomer

Remove a customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTicketingCustomer" method="delete" path="/ticketing/{connection_id}/customer/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Customer.RemoveTicketingCustomerAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Customer   |

### Response

**[RemoveTicketingCustomerResponse](../../Models/Requests/RemoveTicketingCustomerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateTicketingCustomer

Update a customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTicketingCustomer" method="put" path="/ticketing/{connection_id}/customer/{id}" example="ticketing_customer" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTicketingCustomerRequest req = new UpdateTicketingCustomerRequest() {
    TicketingCustomer = new TicketingCustomer() {
        CreatedAt = System.DateTime.Parse("2021-03-15T12:33:14.875Z").ToUniversalTime(),
        Emails = new List<TicketingEmail>() {
            new TicketingEmail() {
                Email = "Christian_Windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "9693c0c0-2580-43e7-b5e8-50ed01af5e16",
        Name = "Christian Windler",
        Tags = new List<string>() {
            "casso",
            "peccatus",
        },
        Telephones = new List<TicketingTelephone>() {
            new TicketingTelephone() {
                Telephone = "(532) 242-0482",
                Type = TicketingTelephoneType.Other,
            },
            new TicketingTelephone() {
                Telephone = "(826) 283-7431",
                Type = TicketingTelephoneType.Mobile,
            },
            new TicketingTelephone() {
                Telephone = "(483) 314-6826",
                Type = TicketingTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-05-04T07:40:10.076Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Customer.UpdateTicketingCustomerAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateTicketingCustomerRequest](../../Models/Requests/UpdateTicketingCustomerRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateTicketingCustomerResponse](../../Models/Requests/UpdateTicketingCustomerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |