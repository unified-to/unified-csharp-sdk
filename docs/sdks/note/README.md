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
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Note.CreateTicketingNoteAsync(ConnectionId: "string", TicketingNote: new TicketingNote() {
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


## GetTicketingNote

Retrieve a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Note.GetTicketingNoteAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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


## ListTicketingNotes

List all notes

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListTicketingNotesRequest req = new ListTicketingNotesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Note.ListTicketingNotesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListTicketingNotesRequest](../../Models/Requests/ListTicketingNotesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[ListTicketingNotesResponse](../../Models/Requests/ListTicketingNotesResponse.md)**


## PatchTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Note.PatchTicketingNoteAsync(ConnectionId: "string", Id: "string", TicketingNote: new TicketingNote() {
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


## RemoveTicketingNote

Remove a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Note.RemoveTicketingNoteAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Note       |


### Response

**[RemoveTicketingNoteResponse](../../Models/Requests/RemoveTicketingNoteResponse.md)**


## UpdateTicketingNote

Update a note

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Note.UpdateTicketingNoteAsync(ConnectionId: "string", Id: "string", TicketingNote: new TicketingNote() {
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

