# Ticket
(*Ticket*)

### Available Operations

* [CreateTicketingTicket](#createticketingticket) - Create a ticket
* [GetTicketingTicket](#getticketingticket) - Retrieve a ticket
* [ListTicketingTickets](#listticketingtickets) - List all tickets
* [PatchTicketingTicket](#patchticketingticket) - Update a ticket
* [RemoveTicketingTicket](#removeticketingticket) - Remove a ticket
* [UpdateTicketingTicket](#updateticketingticket) - Update a ticket

## CreateTicketingTicket

Create a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticket.CreateTicketingTicketAsync(
    security: new CreateTicketingTicketSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    ticketingTicket: new TicketingTicket() {});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.CreateTicketingTicketSecurity](../../Models/Requests/CreateTicketingTicketSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ConnectionId`                                                                                                    | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the connection                                                                                              |
| `TicketingTicket`                                                                                                 | [TicketingTicket](../../Models/Components/TicketingTicket.md)                                                     | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |


### Response

**[CreateTicketingTicketResponse](../../Models/Requests/CreateTicketingTicketResponse.md)**


## GetTicketingTicket

Retrieve a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticket.GetTicketingTicketAsync(
    security: new GetTicketingTicketSecurity() {
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

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.GetTicketingTicketSecurity](../../Models/Requests/GetTicketingTicketSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Ticket                                                                                            |
| `Fields`                                                                                                    | List<*string*>                                                                                              | :heavy_minus_sign:                                                                                          | Comma-delimited fields to return                                                                            |


### Response

**[GetTicketingTicketResponse](../../Models/Requests/GetTicketingTicketResponse.md)**


## ListTicketingTickets

List all tickets

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListTicketingTicketsRequest req = new ListTicketingTicketsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Ticket.ListTicketingTicketsAsync(
    security: new ListTicketingTicketsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [ListTicketingTicketsRequest](../../Models/Requests/ListTicketingTicketsRequest.md)                             | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.ListTicketingTicketsSecurity](../../Models/Requests/ListTicketingTicketsSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |


### Response

**[ListTicketingTicketsResponse](../../Models/Requests/ListTicketingTicketsResponse.md)**


## PatchTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticket.PatchTicketingTicketAsync(
    security: new PatchTicketingTicketSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ticketingTicket: new TicketingTicket() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.PatchTicketingTicketSecurity](../../Models/Requests/PatchTicketingTicketSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Ticket                                                                                                |
| `TicketingTicket`                                                                                               | [TicketingTicket](../../Models/Components/TicketingTicket.md)                                                   | :heavy_minus_sign:                                                                                              | N/A                                                                                                             |


### Response

**[PatchTicketingTicketResponse](../../Models/Requests/PatchTicketingTicketResponse.md)**


## RemoveTicketingTicket

Remove a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticket.RemoveTicketingTicketAsync(
    security: new RemoveTicketingTicketSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.RemoveTicketingTicketSecurity](../../Models/Requests/RemoveTicketingTicketSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ConnectionId`                                                                                                    | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the connection                                                                                              |
| `Id`                                                                                                              | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the Ticket                                                                                                  |


### Response

**[RemoveTicketingTicketResponse](../../Models/Requests/RemoveTicketingTicketResponse.md)**


## UpdateTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticket.UpdateTicketingTicketAsync(
    security: new UpdateTicketingTicketSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ticketingTicket: new TicketingTicket() {});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.UpdateTicketingTicketSecurity](../../Models/Requests/UpdateTicketingTicketSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ConnectionId`                                                                                                    | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the connection                                                                                              |
| `Id`                                                                                                              | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the Ticket                                                                                                  |
| `TicketingTicket`                                                                                                 | [TicketingTicket](../../Models/Components/TicketingTicket.md)                                                     | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |


### Response

**[UpdateTicketingTicketResponse](../../Models/Requests/UpdateTicketingTicketResponse.md)**

