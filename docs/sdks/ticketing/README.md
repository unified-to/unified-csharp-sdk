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

Creates a TicketingCategory. Provide the unified TicketingCategory fields in the request body; they are mapped to the provider's API. Returns the created TicketingCategory.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTicketingCategory" method="post" path="/ticketing/{connection_id}/category" example="ticketing_category" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.CreateTicketingCategoryAsync(
    ticketingCategory: new TicketingCategory() {
        CreatedAt = System.DateTime.Parse("2019-10-19T22:02:51.067Z").ToUniversalTime(),
        Description = "Tempus umbra cibus carpo depulso torqueo. Curtus aperiam nam optio tendo. Bardus tumultus delectus arbitro amplus tollo coerceo clam comprehendo vulnero.",
        Id = "4db7a644-086c-467a-a811-544a0ae1d94b",
        IsActive = true,
        Metadata = new List<TicketingMetadata>() {},
        Name = "amicitia",
        UpdatedAt = System.DateTime.Parse("2026-01-19T09:16:42.338Z").ToUniversalTime(),
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

Creates a TicketingCustomer. Provide the unified TicketingCustomer fields in the request body; they are mapped to the provider's API. Returns the created TicketingCustomer.

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
                Email = "christian.windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "46db1521-524f-49b0-bca2-8d820c98ec82",
        Metadata = new List<TicketingMetadata>() {},
        Name = "Christian Windler",
        Tags = new List<string>() {
            "quidem",
            "una",
        },
        Telephones = new List<TicketingTelephone>() {
            new TicketingTelephone() {
                Telephone = "(299) 843-2042",
                Type = TicketingTelephoneType.Other,
            },
            new TicketingTelephone() {
                Telephone = "(248) 482-6083",
                Type = TicketingTelephoneType.Mobile,
            },
            new TicketingTelephone() {
                Telephone = "(743) 328-3214",
                Type = TicketingTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-09T16:39:07.470Z").ToUniversalTime(),
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

Creates a TicketingNote. Provide the unified TicketingNote fields in the request body; they are mapped to the provider's API. Returns the created TicketingNote.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTicketingNote" method="post" path="/ticketing/{connection_id}/note" example="ticketing_note" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ticketing.CreateTicketingNoteAsync(
    ticketingNote: new TicketingNote() {
        CreatedAt = System.DateTime.Parse("2019-07-23T15:05:03.241Z").ToUniversalTime(),
        Description = "Civitas absum adipisci vitiosus recusandae tristis dedico libero comminor cena. Spes virgo absorbeo defluo nostrum.",
        Id = "b982a7db-6f6e-4c98-94ac-5dfde3075611",
        Metadata = new List<TicketingMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2024-10-03T14:11:50.517Z").ToUniversalTime(),
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

Creates a TicketingTicket. Provide the unified TicketingTicket fields in the request body; they are mapped to the provider's API. Returns the created TicketingTicket.

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
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2021-07-07T17:39:49.813Z").ToUniversalTime(),
        Id = "85f9cc01-e8e4-4979-a14f-95a640800905",
        Metadata = new List<TicketingMetadata>() {},
        Priority = "MEDIUM",
        Source = "email",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "vilicus",
        },
        UpdatedAt = System.DateTime.Parse("2021-07-03T19:04:29.422Z").ToUniversalTime(),
        Url = "https://similar-velocity.net/",
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

Retrieves a single TicketingCategory by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TicketingCustomer by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TicketingNote by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TicketingTicket by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of TicketingCategories. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TicketingCustomers. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TicketingNotes. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TicketingTickets. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the TicketingCategory identified by `id`. Provide the unified TicketingCategory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTicketingCategory" method="patch" path="/ticketing/{connection_id}/category/{id}" example="ticketing_category" -->
```csharp
using System;
using System.Collections.Generic;
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
        Id = "1909ce82-565c-443f-8742-68c9021c65b1",
        IsActive = true,
        Metadata = new List<TicketingMetadata>() {},
        Name = "amicitia",
        UpdatedAt = System.DateTime.Parse("2026-01-19T09:16:42.361Z").ToUniversalTime(),
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

Updates the TicketingCustomer identified by `id`. Provide the unified TicketingCustomer fields to change in the request body.

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
                Email = "christian.windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "f728466f-bc70-4f9f-890e-510006d2f805",
        Metadata = new List<TicketingMetadata>() {},
        Name = "Christian Windler",
        Tags = new List<string>() {
            "quidem",
            "una",
        },
        Telephones = new List<TicketingTelephone>() {
            new TicketingTelephone() {
                Telephone = "(299) 843-2042",
                Type = TicketingTelephoneType.Other,
            },
            new TicketingTelephone() {
                Telephone = "(248) 482-6083",
                Type = TicketingTelephoneType.Mobile,
            },
            new TicketingTelephone() {
                Telephone = "(743) 328-3214",
                Type = TicketingTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-09T16:39:07.486Z").ToUniversalTime(),
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

Updates the TicketingNote identified by `id`. Provide the unified TicketingNote fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTicketingNote" method="patch" path="/ticketing/{connection_id}/note/{id}" example="ticketing_note" -->
```csharp
using System;
using System.Collections.Generic;
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
        Id = "1a338d81-f4ba-455f-b2ff-0901e3cfc3fb",
        Metadata = new List<TicketingMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2024-10-03T14:11:50.527Z").ToUniversalTime(),
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

Updates the TicketingTicket identified by `id`. Provide the unified TicketingTicket fields to change in the request body.

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
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2021-07-07T17:39:49.813Z").ToUniversalTime(),
        Id = "d036a12c-ee43-4b0a-bf1a-c7328b9e10f3",
        Metadata = new List<TicketingMetadata>() {},
        Priority = "MEDIUM",
        Source = "email",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "vilicus",
        },
        UpdatedAt = System.DateTime.Parse("2021-07-03T19:04:29.422Z").ToUniversalTime(),
        Url = "https://similar-velocity.net/",
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

Deletes the TicketingCategory identified by `id`.

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

Deletes the TicketingCustomer identified by `id`.

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

Deletes the TicketingNote identified by `id`.

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

Deletes the TicketingTicket identified by `id`.

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

Updates the TicketingCategory identified by `id`. Provide the unified TicketingCategory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTicketingCategory" method="put" path="/ticketing/{connection_id}/category/{id}" example="ticketing_category" -->
```csharp
using System;
using System.Collections.Generic;
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
        Id = "1909ce82-565c-443f-8742-68c9021c65b1",
        IsActive = true,
        Metadata = new List<TicketingMetadata>() {},
        Name = "amicitia",
        UpdatedAt = System.DateTime.Parse("2026-01-19T09:16:42.361Z").ToUniversalTime(),
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

Updates the TicketingCustomer identified by `id`. Provide the unified TicketingCustomer fields to change in the request body.

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
                Email = "christian.windler@gmail.com",
                Type = TicketingEmailType.Home,
            },
        },
        Id = "f728466f-bc70-4f9f-890e-510006d2f805",
        Metadata = new List<TicketingMetadata>() {},
        Name = "Christian Windler",
        Tags = new List<string>() {
            "quidem",
            "una",
        },
        Telephones = new List<TicketingTelephone>() {
            new TicketingTelephone() {
                Telephone = "(299) 843-2042",
                Type = TicketingTelephoneType.Other,
            },
            new TicketingTelephone() {
                Telephone = "(248) 482-6083",
                Type = TicketingTelephoneType.Mobile,
            },
            new TicketingTelephone() {
                Telephone = "(743) 328-3214",
                Type = TicketingTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-09T16:39:07.486Z").ToUniversalTime(),
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

Updates the TicketingNote identified by `id`. Provide the unified TicketingNote fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTicketingNote" method="put" path="/ticketing/{connection_id}/note/{id}" example="ticketing_note" -->
```csharp
using System;
using System.Collections.Generic;
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
        Id = "1a338d81-f4ba-455f-b2ff-0901e3cfc3fb",
        Metadata = new List<TicketingMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2024-10-03T14:11:50.527Z").ToUniversalTime(),
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

Updates the TicketingTicket identified by `id`. Provide the unified TicketingTicket fields to change in the request body.

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
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2021-07-07T17:39:49.813Z").ToUniversalTime(),
        Id = "d036a12c-ee43-4b0a-bf1a-c7328b9e10f3",
        Metadata = new List<TicketingMetadata>() {},
        Priority = "MEDIUM",
        Source = "email",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "vilicus",
        },
        UpdatedAt = System.DateTime.Parse("2021-07-03T19:04:29.422Z").ToUniversalTime(),
        Url = "https://similar-velocity.net/",
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