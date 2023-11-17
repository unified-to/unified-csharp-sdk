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
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Ticket.CreateTicketingTicketAsync("string", new TicketingTicket() {
    Raw = new PropertyTicketingTicketRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `TicketingTicket`                                             | [TicketingTicket](../../Models/Components/TicketingTicket.md) | :heavy_minus_sign:                                            | N/A                                                           |


### Response

**[CreateTicketingTicketResponse](../../Models/Requests/CreateTicketingTicketResponse.md)**


## GetTicketingTicket

Retrieve a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Ticket.GetTicketingTicketAsync("string", "string", new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Ticket                 |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetTicketingTicketResponse](../../Models/Requests/GetTicketingTicketResponse.md)**


## ListTicketingTickets

List all tickets

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Ticket.ListTicketingTicketsAsync(new ListTicketingTicketsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListTicketingTicketsRequest](../../Models/Requests/ListTicketingTicketsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ListTicketingTicketsResponse](../../Models/Requests/ListTicketingTicketsResponse.md)**


## PatchTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Ticket.PatchTicketingTicketAsync("string", "string", new TicketingTicket() {
    Raw = new PropertyTicketingTicketRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Ticket                                              |
| `TicketingTicket`                                             | [TicketingTicket](../../Models/Components/TicketingTicket.md) | :heavy_minus_sign:                                            | N/A                                                           |


### Response

**[PatchTicketingTicketResponse](../../Models/Requests/PatchTicketingTicketResponse.md)**


## RemoveTicketingTicket

Remove a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Ticket.RemoveTicketingTicketAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Ticket     |


### Response

**[RemoveTicketingTicketResponse](../../Models/Requests/RemoveTicketingTicketResponse.md)**


## UpdateTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Ticket.UpdateTicketingTicketAsync("string", "string", new TicketingTicket() {
    Raw = new PropertyTicketingTicketRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Ticket                                              |
| `TicketingTicket`                                             | [TicketingTicket](../../Models/Components/TicketingTicket.md) | :heavy_minus_sign:                                            | N/A                                                           |


### Response

**[UpdateTicketingTicketResponse](../../Models/Requests/UpdateTicketingTicketResponse.md)**

