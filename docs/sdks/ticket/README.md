# Ticket

## Overview

### Available Operations

* [CreateTicketingTicket](#createticketingticket) - Create a ticket
* [GetTicketingTicket](#getticketingticket) - Retrieve a ticket
* [ListTicketingTickets](#listticketingtickets) - List all tickets
* [PatchTicketingTicket](#patchticketingticket) - Update a ticket
* [RemoveTicketingTicket](#removeticketingticket) - Remove a ticket
* [UpdateTicketingTicket](#updateticketingticket) - Update a ticket

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

var res = await sdk.Ticket.CreateTicketingTicketAsync(
    ticketingTicket: new TicketingTicket() {
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2021-06-25T19:19:31.279Z").ToUniversalTime(),
        Description = "Cura dignissimos aut clibanus vulgaris patrocinor. Laborum acies curiositas antepono coniuratio. Correptius curiositas sono censura coma. Bestia suus tot cotidie terror subito coniecto beneficium.",
        DueAt = System.DateTime.Parse("2021-07-07T17:39:49.813Z").ToUniversalTime(),
        Id = "4528f935-c0e2-4f4a-a9ba-f909b0dcb655",
        Metadata = new List<TicketingMetadata>() {},
        Priority = "MEDIUM",
        Source = "email",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "vilicus",
        },
        UpdatedAt = System.DateTime.Parse("2021-07-03T18:52:25.953Z").ToUniversalTime(),
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

var res = await sdk.Ticket.GetTicketingTicketAsync(
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

var res = await sdk.Ticket.ListTicketingTicketsAsync(req);

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
        Id = "e41acc59-4179-4178-967b-6f8464725e00",
        Metadata = new List<TicketingMetadata>() {},
        Priority = "MEDIUM",
        Source = "email",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "vilicus",
        },
        UpdatedAt = System.DateTime.Parse("2021-07-03T18:52:25.953Z").ToUniversalTime(),
        Url = "https://similar-velocity.net/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticket.PatchTicketingTicketAsync(req);

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

var res = await sdk.Ticket.RemoveTicketingTicketAsync(
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
        Id = "e41acc59-4179-4178-967b-6f8464725e00",
        Metadata = new List<TicketingMetadata>() {},
        Priority = "MEDIUM",
        Source = "email",
        Status = TicketingTicketStatus.Active,
        Subject = "Thymbra ratione minus arbitro tricesimus cetera validus.",
        Tags = new List<string>() {
            "vilicus",
        },
        UpdatedAt = System.DateTime.Parse("2021-07-03T18:52:25.953Z").ToUniversalTime(),
        Url = "https://similar-velocity.net/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ticket.UpdateTicketingTicketAsync(req);

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