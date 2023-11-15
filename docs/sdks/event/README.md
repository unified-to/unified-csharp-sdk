# Event
(*Event*)

### Available Operations

* [CreateCrmEvent](#createcrmevent) - Create a event
* [GetCrmEvent](#getcrmevent) - Retrieve a event
* [ListCrmEvents](#listcrmevents) - List all events
* [PatchCrmEvent](#patchcrmevent) - Update a event
* [RemoveCrmEvent](#removecrmevent) - Remove a event
* [UpdateCrmEvent](#updatecrmevent) - Update a event

## CreateCrmEvent

Create a event

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Event.CreateCrmEventAsync("string", new CrmEvent() {
    Call = new PropertyCrmEventCall() {},
    CompanyIds = new List<string>() {
        "string",
    },
    ContactIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Email = new PropertyCrmEventEmail() {
        Cc = new List<string>() {
            "string",
        },
        To = new List<string>() {
            "string",
        },
    },
    Meeting = new PropertyCrmEventMeeting() {},
    Note = new PropertyCrmEventNote() {},
    Raw = new PropertyCrmEventRaw() {},
    Task = new PropertyCrmEventTask() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[CreateCrmEventResponse](../../Models/Requests/CreateCrmEventResponse.md)**


## GetCrmEvent

Retrieve a event

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Event.GetCrmEventAsync("string", "string", new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Event                  |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmEventResponse](../../Models/Requests/GetCrmEventResponse.md)**


## ListCrmEvents

List all events

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Event.ListCrmEventsAsync(new ListCrmEventsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCrmEventsRequest](../../Models/Requests/ListCrmEventsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListCrmEventsResponse](../../Models/Requests/ListCrmEventsResponse.md)**


## PatchCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Event.PatchCrmEventAsync("string", "string", new CrmEvent() {
    Call = new PropertyCrmEventCall() {},
    CompanyIds = new List<string>() {
        "string",
    },
    ContactIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Email = new PropertyCrmEventEmail() {
        Cc = new List<string>() {
            "string",
        },
        To = new List<string>() {
            "string",
        },
    },
    Meeting = new PropertyCrmEventMeeting() {},
    Note = new PropertyCrmEventNote() {},
    Raw = new PropertyCrmEventRaw() {},
    Task = new PropertyCrmEventTask() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[PatchCrmEventResponse](../../Models/Requests/PatchCrmEventResponse.md)**


## RemoveCrmEvent

Remove a event

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Event.RemoveCrmEventAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Event      |


### Response

**[RemoveCrmEventResponse](../../Models/Requests/RemoveCrmEventResponse.md)**


## UpdateCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.Event.UpdateCrmEventAsync("string", "string", new CrmEvent() {
    Call = new PropertyCrmEventCall() {},
    CompanyIds = new List<string>() {
        "string",
    },
    ContactIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Email = new PropertyCrmEventEmail() {
        Cc = new List<string>() {
            "string",
        },
        To = new List<string>() {
            "string",
        },
    },
    Meeting = new PropertyCrmEventMeeting() {},
    Note = new PropertyCrmEventNote() {},
    Raw = new PropertyCrmEventRaw() {},
    Task = new PropertyCrmEventTask() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[UpdateCrmEventResponse](../../Models/Requests/UpdateCrmEventResponse.md)**

