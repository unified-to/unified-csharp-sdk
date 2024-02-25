# Ticketing
(*Ticketing*)

### Available Operations

* [CreateTicketingCustomer](#createticketingcustomer) - Create a customer
* [CreateTicketingNote](#createticketingnote) - Create a note
* [CreateTicketingTicket](#createticketingticket) - Create a ticket
* [GetTicketingCustomer](#getticketingcustomer) - Retrieve a customer
* [GetTicketingNote](#getticketingnote) - Retrieve a note
* [GetTicketingTicket](#getticketingticket) - Retrieve a ticket
* [ListTicketingCustomers](#listticketingcustomers) - List all customers
* [ListTicketingNotes](#listticketingnotes) - List all notes
* [ListTicketingTickets](#listticketingtickets) - List all tickets
* [PatchTicketingCustomer](#patchticketingcustomer) - Update a customer
* [PatchTicketingNote](#patchticketingnote) - Update a note
* [PatchTicketingTicket](#patchticketingticket) - Update a ticket
* [RemoveTicketingCustomer](#removeticketingcustomer) - Remove a customer
* [RemoveTicketingNote](#removeticketingnote) - Remove a note
* [RemoveTicketingTicket](#removeticketingticket) - Remove a ticket
* [UpdateTicketingCustomer](#updateticketingcustomer) - Update a customer
* [UpdateTicketingNote](#updateticketingnote) - Update a note
* [UpdateTicketingTicket](#updateticketingticket) - Update a ticket

## CreateTicketingCustomer

Create a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.CreateTicketingCustomerAsync(
    security: new CreateTicketingCustomerSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    ticketingCustomer: new TicketingCustomer() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateTicketingCustomerSecurity](../../Models/Requests/CreateTicketingCustomerSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `TicketingCustomer`                                                                                                   | [TicketingCustomer](../../Models/Components/TicketingCustomer.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateTicketingCustomerResponse](../../Models/Requests/CreateTicketingCustomerResponse.md)**


## CreateTicketingNote

Create a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.CreateTicketingNoteAsync(
    security: new CreateTicketingNoteSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    ticketingNote: new TicketingNote() {});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.CreateTicketingNoteSecurity](../../Models/Requests/CreateTicketingNoteSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `TicketingNote`                                                                                               | [TicketingNote](../../Models/Components/TicketingNote.md)                                                     | :heavy_minus_sign:                                                                                            | N/A                                                                                                           |


### Response

**[CreateTicketingNoteResponse](../../Models/Requests/CreateTicketingNoteResponse.md)**


## CreateTicketingTicket

Create a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.CreateTicketingTicketAsync(
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


## GetTicketingCustomer

Retrieve a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.GetTicketingCustomerAsync(
    security: new GetTicketingCustomerSecurity() {
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

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetTicketingCustomerSecurity](../../Models/Requests/GetTicketingCustomerSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Customer                                                                                              |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetTicketingCustomerResponse](../../Models/Requests/GetTicketingCustomerResponse.md)**


## GetTicketingNote

Retrieve a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.GetTicketingNoteAsync(
    security: new GetTicketingNoteSecurity() {
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

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.GetTicketingNoteSecurity](../../Models/Requests/GetTicketingNoteSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Note                                                                                          |
| `Fields`                                                                                                | List<*string*>                                                                                          | :heavy_minus_sign:                                                                                      | Comma-delimited fields to return                                                                        |


### Response

**[GetTicketingNoteResponse](../../Models/Requests/GetTicketingNoteResponse.md)**


## GetTicketingTicket

Retrieve a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.GetTicketingTicketAsync(
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


## ListTicketingCustomers

List all customers

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListTicketingCustomersRequest req = new ListTicketingCustomersRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Ticketing.ListTicketingCustomersAsync(
    security: new ListTicketingCustomersSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListTicketingCustomersRequest](../../Models/Requests/ListTicketingCustomersRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListTicketingCustomersSecurity](../../Models/Requests/ListTicketingCustomersSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListTicketingCustomersResponse](../../Models/Requests/ListTicketingCustomersResponse.md)**


## ListTicketingNotes

List all notes

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListTicketingNotesRequest req = new ListTicketingNotesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Ticketing.ListTicketingNotesAsync(
    security: new ListTicketingNotesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [ListTicketingNotesRequest](../../Models/Requests/ListTicketingNotesRequest.md)                             | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.ListTicketingNotesSecurity](../../Models/Requests/ListTicketingNotesSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |


### Response

**[ListTicketingNotesResponse](../../Models/Requests/ListTicketingNotesResponse.md)**


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

var res = await sdk.Ticketing.ListTicketingTicketsAsync(
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


## PatchTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.PatchTicketingCustomerAsync(
    security: new PatchTicketingCustomerSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ticketingCustomer: new TicketingCustomer() {});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchTicketingCustomerSecurity](../../Models/Requests/PatchTicketingCustomerSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Customer                                                                                                  |
| `TicketingCustomer`                                                                                                 | [TicketingCustomer](../../Models/Components/TicketingCustomer.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchTicketingCustomerResponse](../../Models/Requests/PatchTicketingCustomerResponse.md)**


## PatchTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.PatchTicketingNoteAsync(
    security: new PatchTicketingNoteSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ticketingNote: new TicketingNote() {});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.PatchTicketingNoteSecurity](../../Models/Requests/PatchTicketingNoteSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Note                                                                                              |
| `TicketingNote`                                                                                             | [TicketingNote](../../Models/Components/TicketingNote.md)                                                   | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[PatchTicketingNoteResponse](../../Models/Requests/PatchTicketingNoteResponse.md)**


## PatchTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.PatchTicketingTicketAsync(
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


## RemoveTicketingCustomer

Remove a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.RemoveTicketingCustomerAsync(
    security: new RemoveTicketingCustomerSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveTicketingCustomerSecurity](../../Models/Requests/RemoveTicketingCustomerSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Customer                                                                                                    |


### Response

**[RemoveTicketingCustomerResponse](../../Models/Requests/RemoveTicketingCustomerResponse.md)**


## RemoveTicketingNote

Remove a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.RemoveTicketingNoteAsync(
    security: new RemoveTicketingNoteSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.RemoveTicketingNoteSecurity](../../Models/Requests/RemoveTicketingNoteSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Note                                                                                                |


### Response

**[RemoveTicketingNoteResponse](../../Models/Requests/RemoveTicketingNoteResponse.md)**


## RemoveTicketingTicket

Remove a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.RemoveTicketingTicketAsync(
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


## UpdateTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.UpdateTicketingCustomerAsync(
    security: new UpdateTicketingCustomerSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ticketingCustomer: new TicketingCustomer() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateTicketingCustomerSecurity](../../Models/Requests/UpdateTicketingCustomerSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Customer                                                                                                    |
| `TicketingCustomer`                                                                                                   | [TicketingCustomer](../../Models/Components/TicketingCustomer.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateTicketingCustomerResponse](../../Models/Requests/UpdateTicketingCustomerResponse.md)**


## UpdateTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.UpdateTicketingNoteAsync(
    security: new UpdateTicketingNoteSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ticketingNote: new TicketingNote() {});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.UpdateTicketingNoteSecurity](../../Models/Requests/UpdateTicketingNoteSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Note                                                                                                |
| `TicketingNote`                                                                                               | [TicketingNote](../../Models/Components/TicketingNote.md)                                                     | :heavy_minus_sign:                                                                                            | N/A                                                                                                           |


### Response

**[UpdateTicketingNoteResponse](../../Models/Requests/UpdateTicketingNoteResponse.md)**


## UpdateTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Ticketing.UpdateTicketingTicketAsync(
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

