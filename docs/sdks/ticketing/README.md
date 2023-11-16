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
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.CreateTicketingCustomerAsync("string", new TicketingCustomer() {
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


## CreateTicketingNote

Create a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.CreateTicketingNoteAsync("string", new TicketingNote() {
    Raw = new PropertyTicketingNoteRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `TicketingNote`                                           | [TicketingNote](../../Models/Components/TicketingNote.md) | :heavy_minus_sign:                                        | N/A                                                       |


### Response

**[CreateTicketingNoteResponse](../../Models/Requests/CreateTicketingNoteResponse.md)**


## CreateTicketingTicket

Create a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.CreateTicketingTicketAsync("string", new TicketingTicket() {
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


## GetTicketingCustomer

Retrieve a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.GetTicketingCustomerAsync("string", "string", new List<string>() {
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


## GetTicketingNote

Retrieve a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.GetTicketingNoteAsync("string", "string", new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Note                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetTicketingNoteResponse](../../Models/Requests/GetTicketingNoteResponse.md)**


## GetTicketingTicket

Retrieve a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.GetTicketingTicketAsync("string", "string", new List<string>() {
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


## ListTicketingCustomers

List all customers

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.ListTicketingCustomersAsync(new ListTicketingCustomersRequest() {
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


## ListTicketingNotes

List all notes

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.ListTicketingNotesAsync(new ListTicketingNotesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListTicketingNotesRequest](../../Models/Requests/ListTicketingNotesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[ListTicketingNotesResponse](../../Models/Requests/ListTicketingNotesResponse.md)**


## ListTicketingTickets

List all tickets

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.ListTicketingTicketsAsync(new ListTicketingTicketsRequest() {
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


## PatchTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.PatchTicketingCustomerAsync("string", "string", new TicketingCustomer() {
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


## PatchTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.PatchTicketingNoteAsync("string", "string", new TicketingNote() {
    Raw = new PropertyTicketingNoteRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `Id`                                                      | *string*                                                  | :heavy_check_mark:                                        | ID of the Note                                            |
| `TicketingNote`                                           | [TicketingNote](../../Models/Components/TicketingNote.md) | :heavy_minus_sign:                                        | N/A                                                       |


### Response

**[PatchTicketingNoteResponse](../../Models/Requests/PatchTicketingNoteResponse.md)**


## PatchTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.PatchTicketingTicketAsync("string", "string", new TicketingTicket() {
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


## RemoveTicketingCustomer

Remove a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.RemoveTicketingCustomerAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Customer   |


### Response

**[RemoveTicketingCustomerResponse](../../Models/Requests/RemoveTicketingCustomerResponse.md)**


## RemoveTicketingNote

Remove a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.RemoveTicketingNoteAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Note       |


### Response

**[RemoveTicketingNoteResponse](../../Models/Requests/RemoveTicketingNoteResponse.md)**


## RemoveTicketingTicket

Remove a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.RemoveTicketingTicketAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Ticket     |


### Response

**[RemoveTicketingTicketResponse](../../Models/Requests/RemoveTicketingTicketResponse.md)**


## UpdateTicketingCustomer

Update a customer

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.UpdateTicketingCustomerAsync("string", "string", new TicketingCustomer() {
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


## UpdateTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.UpdateTicketingNoteAsync("string", "string", new TicketingNote() {
    Raw = new PropertyTicketingNoteRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `Id`                                                      | *string*                                                  | :heavy_check_mark:                                        | ID of the Note                                            |
| `TicketingNote`                                           | [TicketingNote](../../Models/Components/TicketingNote.md) | :heavy_minus_sign:                                        | N/A                                                       |


### Response

**[UpdateTicketingNoteResponse](../../Models/Requests/UpdateTicketingNoteResponse.md)**


## UpdateTicketingTicket

Update a ticket

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Ticketing.UpdateTicketingTicketAsync("string", "string", new TicketingTicket() {
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

