# Note
(*Note*)

### Available Operations

* [CreateTicketingNote](#createticketingnote) - Create a note
* [GetTicketingNote](#getticketingnote) - Retrieve a note
* [ListTicketingNotes](#listticketingnotes) - List all notes
* [PatchTicketingNote](#patchticketingnote) - Update a note
* [RemoveTicketingNote](#removeticketingnote) - Remove a note
* [UpdateTicketingNote](#updateticketingnote) - Update a note

## CreateTicketingNote

Create a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Note.CreateTicketingNoteAsync(
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


## GetTicketingNote

Retrieve a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Note.GetTicketingNoteAsync(
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

var res = await sdk.Note.ListTicketingNotesAsync(
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


## PatchTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Note.PatchTicketingNoteAsync(
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


## RemoveTicketingNote

Remove a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Note.RemoveTicketingNoteAsync(
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


## UpdateTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Note.UpdateTicketingNoteAsync(
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

