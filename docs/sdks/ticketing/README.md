# Ticketing

## Overview

### Available Operations

* [CreateTicketingCategory](#createticketingcategory) - Create a category
* [CreateTicketingCustomer](#createticketingcustomer) - Create a customer
* [CreateTicketingNote](#createticketingnote) - Create a note
* [CreateTicketingTicket](#createticketingticket) - Create a ticket
* [GetTicketingCategory](#getticketingcategory) - Retrieve a category
* [GetTicketingCustomer](#getticketingcustomer) - Retrieve a customer
* [GetTicketingNote](#getticketingnote) - Retrieve a note
* [GetTicketingTicket](#getticketingticket) - Retrieve a ticket
* [ListTicketingCategories](#listticketingcategories) - List all categories
* [ListTicketingCustomers](#listticketingcustomers) - List all customers
* [ListTicketingNotes](#listticketingnotes) - List all notes
* [ListTicketingTickets](#listticketingtickets) - List all tickets
* [PatchTicketingCategory](#patchticketingcategory) - Update a category
* [PatchTicketingCustomer](#patchticketingcustomer) - Update a customer
* [PatchTicketingNote](#patchticketingnote) - Update a note
* [PatchTicketingTicket](#patchticketingticket) - Update a ticket
* [RemoveTicketingCategory](#removeticketingcategory) - Remove a category
* [RemoveTicketingCustomer](#removeticketingcustomer) - Remove a customer
* [RemoveTicketingNote](#removeticketingnote) - Remove a note
* [RemoveTicketingTicket](#removeticketingticket) - Remove a ticket
* [UpdateTicketingCategory](#updateticketingcategory) - Update a category
* [UpdateTicketingCustomer](#updateticketingcustomer) - Update a customer
* [UpdateTicketingNote](#updateticketingnote) - Update a note
* [UpdateTicketingTicket](#updateticketingticket) - Update a ticket

## CreateTicketingCategory

Create a category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTicketingCategory" method="post" path="/ticketing/{connection_id}/category" example="ticketing_category" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.CreateTicketingCategoryAsync(
    ticketingCategory: new TicketingCategory() {
        CreatedAt = System.DateTime.Parse("2019-10-19T22:02:51.067Z").ToUniversalTime(),
        Description = "Tempus umbra cibus carpo depulso torqueo. Curtus aperiam nam optio tendo. Bardus tumultus delectus arbitro amplus tollo coerceo clam comprehendo vulnero.",
        Id = "607f6dab-6d4d-4433-a507-31192e92a2b0",
        IsActive = true,
        Name = "amicitia",
        UpdatedAt = System.DateTime.Parse("2025-12-17T10:11:09.269Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TicketingCategory`                                                                                                                              | [TicketingCategory](../../Models/Components/TicketingCategory.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTicketingCategoryQueryParamFields](../../Models/Requests/CreateTicketingCategoryQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTicketingCategoryResponse](../../Models/Requests/CreateTicketingCategoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ticketing.CreateTicketingCustomerAsync(
    ticketingCustomer: new TicketingCustomer() {
        CreatedAt = System.DateTime.Parse("2021-03-15T12:33:14.875Z").ToUniversalTime(),
        Emails = new List<TicketingEmail>() {
            new TicketingEmail() {
                Email = "Christian_Windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "e8de2ac7-0e2a-415c-97f2-1e553380ae64",
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
        UpdatedAt = System.DateTime.Parse("2026-05-06T04:39:52.036Z").ToUniversalTime(),
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

## CreateTicketingNote

Create a note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTicketingNote" method="post" path="/ticketing/{connection_id}/note" example="ticketing_note" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.CreateTicketingNoteAsync(
    ticketingNote: new TicketingNote() {
        CreatedAt = System.DateTime.Parse("2019-07-23T15:05:03.241Z").ToUniversalTime(),
        Description = "Civitas absum adipisci vitiosus recusandae tristis dedico libero comminor cena. Spes virgo absorbeo defluo nostrum.",
        Id = "443d0358-4355-4551-81ec-1746e660c448",
        UpdatedAt = System.DateTime.Parse("2024-09-07T02:12:47.203Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TicketingNote`                                                                                                                                  | [TicketingNote](../../Models/Components/TicketingNote.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTicketingNoteQueryParamFields](../../Models/Requests/CreateTicketingNoteQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTicketingNoteResponse](../../Models/Requests/CreateTicketingNoteResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateTicketingTicket

Create a ticket

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTicketingTicket" method="post" path="/ticketing/{connection_id}/ticket" example="ticketing_ticket" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.CreateTicketingTicketAsync(
    ticketingTicket: new TicketingTicket() {
        AttachmentIds = new List<string>() {
            "fdeb8be8-1e3c-4d25-8f48-1dbaedb9804a",
            "a878a98b-62c8-4b6a-a675-01022fbf83eb",
        },
        CategoryId = "vilicus",
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2025-07-21T17:30:16.712Z").ToUniversalTime(),
        Id = "c172878f-6d63-4de4-a840-47582d6077f6",
        Priority = "LOW",
        Source = "atavus",
        SourceRef = "c5d01715-5fd2-495a-8573-bce558976238",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "tamen",
            "vitae",
            "torrens",
        },
        UpdatedAt = System.DateTime.Parse("2023-05-29T01:09:30.858Z").ToUniversalTime(),
        Url = "https://yellowish-testimonial.biz",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TicketingTicket`                                                                                                                                | [TicketingTicket](../../Models/Components/TicketingTicket.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTicketingTicketQueryParamFields](../../Models/Requests/CreateTicketingTicketQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTicketingTicketResponse](../../Models/Requests/CreateTicketingTicketResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTicketingCategory

Retrieve a category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTicketingCategory" method="get" path="/ticketing/{connection_id}/category/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.GetTicketingCategoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Category                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetTicketingCategoryQueryParamFields](../../Models/Requests/GetTicketingCategoryQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTicketingCategoryResponse](../../Models/Requests/GetTicketingCategoryResponse.md)**

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

var res = await sdk.Ticketing.GetTicketingCustomerAsync(
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

## GetTicketingNote

Retrieve a note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTicketingNote" method="get" path="/ticketing/{connection_id}/note/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.GetTicketingNoteAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Note                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetTicketingNoteQueryParamFields](../../Models/Requests/GetTicketingNoteQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTicketingNoteResponse](../../Models/Requests/GetTicketingNoteResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTicketingTicket

Retrieve a ticket

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTicketingTicket" method="get" path="/ticketing/{connection_id}/ticket/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.GetTicketingTicketAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Ticket                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetTicketingTicketQueryParamFields](../../Models/Requests/GetTicketingTicketQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTicketingTicketResponse](../../Models/Requests/GetTicketingTicketResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTicketingCategories

List all categories

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTicketingCategories" method="get" path="/ticketing/{connection_id}/category" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTicketingCategoriesRequest req = new ListTicketingCategoriesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ticketing.ListTicketingCategoriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListTicketingCategoriesRequest](../../Models/Requests/ListTicketingCategoriesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ListTicketingCategoriesResponse](../../Models/Requests/ListTicketingCategoriesResponse.md)**

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

var res = await sdk.Ticketing.ListTicketingCustomersAsync(req);

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

## ListTicketingNotes

List all notes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTicketingNotes" method="get" path="/ticketing/{connection_id}/note" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTicketingNotesRequest req = new ListTicketingNotesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ticketing.ListTicketingNotesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListTicketingNotesRequest](../../Models/Requests/ListTicketingNotesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListTicketingNotesResponse](../../Models/Requests/ListTicketingNotesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTicketingTickets

List all tickets

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTicketingTickets" method="get" path="/ticketing/{connection_id}/ticket" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTicketingTicketsRequest req = new ListTicketingTicketsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ticketing.ListTicketingTicketsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListTicketingTicketsRequest](../../Models/Requests/ListTicketingTicketsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListTicketingTicketsResponse](../../Models/Requests/ListTicketingTicketsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchTicketingCategory

Update a category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTicketingCategory" method="patch" path="/ticketing/{connection_id}/category/{id}" example="ticketing_category" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTicketingCategoryRequest req = new PatchTicketingCategoryRequest() {
    TicketingCategory = new TicketingCategory() {
        CreatedAt = System.DateTime.Parse("2019-10-19T22:02:51.067Z").ToUniversalTime(),
        Description = "Tempus umbra cibus carpo depulso torqueo. Curtus aperiam nam optio tendo. Bardus tumultus delectus arbitro amplus tollo coerceo clam comprehendo vulnero.",
        Id = "e9881ca4-91c5-4a07-a22d-cf926954ec48",
        IsActive = true,
        Name = "amicitia",
        UpdatedAt = System.DateTime.Parse("2025-12-17T10:11:09.273Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.PatchTicketingCategoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchTicketingCategoryRequest](../../Models/Requests/PatchTicketingCategoryRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchTicketingCategoryResponse](../../Models/Requests/PatchTicketingCategoryResponse.md)**

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
        Id = "9604da45-6416-4d5e-a628-c70174f34149",
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
        UpdatedAt = System.DateTime.Parse("2026-05-06T04:39:52.044Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.PatchTicketingCustomerAsync(req);

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

## PatchTicketingNote

Update a note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTicketingNote" method="patch" path="/ticketing/{connection_id}/note/{id}" example="ticketing_note" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTicketingNoteRequest req = new PatchTicketingNoteRequest() {
    TicketingNote = new TicketingNote() {
        CreatedAt = System.DateTime.Parse("2019-07-23T15:05:03.241Z").ToUniversalTime(),
        Description = "Civitas absum adipisci vitiosus recusandae tristis dedico libero comminor cena. Spes virgo absorbeo defluo nostrum.",
        Id = "a30491e9-69d0-4452-8ef1-525ff4335da2",
        UpdatedAt = System.DateTime.Parse("2024-09-07T02:12:47.206Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.PatchTicketingNoteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchTicketingNoteRequest](../../Models/Requests/PatchTicketingNoteRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchTicketingNoteResponse](../../Models/Requests/PatchTicketingNoteResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchTicketingTicket

Update a ticket

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTicketingTicket" method="patch" path="/ticketing/{connection_id}/ticket/{id}" example="ticketing_ticket" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTicketingTicketRequest req = new PatchTicketingTicketRequest() {
    TicketingTicket = new TicketingTicket() {
        AttachmentIds = new List<string>() {
            "9833ad4d-c5ac-4f8c-8126-77c612322a45",
            "9313669c-1e89-4324-9253-d632005f1da1",
        },
        CategoryId = "vilicus",
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2025-07-21T17:30:16.721Z").ToUniversalTime(),
        Id = "5a357501-fde9-472d-8dcb-48161b32d041",
        Priority = "LOW",
        Source = "atavus",
        SourceRef = "c4d3013d-c9f0-4560-83e7-495c3de7e22e",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "tamen",
            "vitae",
            "torrens",
        },
        UpdatedAt = System.DateTime.Parse("2023-05-29T01:09:30.862Z").ToUniversalTime(),
        Url = "https://yellowish-testimonial.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.PatchTicketingTicketAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchTicketingTicketRequest](../../Models/Requests/PatchTicketingTicketRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchTicketingTicketResponse](../../Models/Requests/PatchTicketingTicketResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveTicketingCategory

Remove a category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTicketingCategory" method="delete" path="/ticketing/{connection_id}/category/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.RemoveTicketingCategoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Category   |

### Response

**[RemoveTicketingCategoryResponse](../../Models/Requests/RemoveTicketingCategoryResponse.md)**

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

var res = await sdk.Ticketing.RemoveTicketingCustomerAsync(
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

## RemoveTicketingNote

Remove a note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTicketingNote" method="delete" path="/ticketing/{connection_id}/note/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.RemoveTicketingNoteAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Note       |

### Response

**[RemoveTicketingNoteResponse](../../Models/Requests/RemoveTicketingNoteResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveTicketingTicket

Remove a ticket

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTicketingTicket" method="delete" path="/ticketing/{connection_id}/ticket/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.RemoveTicketingTicketAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Ticket     |

### Response

**[RemoveTicketingTicketResponse](../../Models/Requests/RemoveTicketingTicketResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateTicketingCategory

Update a category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTicketingCategory" method="put" path="/ticketing/{connection_id}/category/{id}" example="ticketing_category" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTicketingCategoryRequest req = new UpdateTicketingCategoryRequest() {
    TicketingCategory = new TicketingCategory() {
        CreatedAt = System.DateTime.Parse("2019-10-19T22:02:51.067Z").ToUniversalTime(),
        Description = "Tempus umbra cibus carpo depulso torqueo. Curtus aperiam nam optio tendo. Bardus tumultus delectus arbitro amplus tollo coerceo clam comprehendo vulnero.",
        Id = "e9881ca4-91c5-4a07-a22d-cf926954ec48",
        IsActive = true,
        Name = "amicitia",
        UpdatedAt = System.DateTime.Parse("2025-12-17T10:11:09.273Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.UpdateTicketingCategoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateTicketingCategoryRequest](../../Models/Requests/UpdateTicketingCategoryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateTicketingCategoryResponse](../../Models/Requests/UpdateTicketingCategoryResponse.md)**

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
        Id = "9604da45-6416-4d5e-a628-c70174f34149",
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
        UpdatedAt = System.DateTime.Parse("2026-05-06T04:39:52.044Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.UpdateTicketingCustomerAsync(req);

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

## UpdateTicketingNote

Update a note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTicketingNote" method="put" path="/ticketing/{connection_id}/note/{id}" example="ticketing_note" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTicketingNoteRequest req = new UpdateTicketingNoteRequest() {
    TicketingNote = new TicketingNote() {
        CreatedAt = System.DateTime.Parse("2019-07-23T15:05:03.241Z").ToUniversalTime(),
        Description = "Civitas absum adipisci vitiosus recusandae tristis dedico libero comminor cena. Spes virgo absorbeo defluo nostrum.",
        Id = "a30491e9-69d0-4452-8ef1-525ff4335da2",
        UpdatedAt = System.DateTime.Parse("2024-09-07T02:12:47.206Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.UpdateTicketingNoteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateTicketingNoteRequest](../../Models/Requests/UpdateTicketingNoteRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateTicketingNoteResponse](../../Models/Requests/UpdateTicketingNoteResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateTicketingTicket

Update a ticket

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTicketingTicket" method="put" path="/ticketing/{connection_id}/ticket/{id}" example="ticketing_ticket" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTicketingTicketRequest req = new UpdateTicketingTicketRequest() {
    TicketingTicket = new TicketingTicket() {
        AttachmentIds = new List<string>() {
            "9833ad4d-c5ac-4f8c-8126-77c612322a45",
            "9313669c-1e89-4324-9253-d632005f1da1",
        },
        CategoryId = "vilicus",
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2025-07-21T17:30:16.721Z").ToUniversalTime(),
        Id = "5a357501-fde9-472d-8dcb-48161b32d041",
        Priority = "LOW",
        Source = "atavus",
        SourceRef = "c4d3013d-c9f0-4560-83e7-495c3de7e22e",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "tamen",
            "vitae",
            "torrens",
        },
        UpdatedAt = System.DateTime.Parse("2023-05-29T01:09:30.862Z").ToUniversalTime(),
        Url = "https://yellowish-testimonial.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticketing.UpdateTicketingTicketAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateTicketingTicketRequest](../../Models/Requests/UpdateTicketingTicketRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateTicketingTicketResponse](../../Models/Requests/UpdateTicketingTicketResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |