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
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Event.CreateCrmEventAsync(
    security: new CreateCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmEvent: new CrmEvent() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.CreateCrmEventSecurity](../../Models/Requests/CreateCrmEventSecurity.md)             | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[CreateCrmEventResponse](../../Models/Requests/CreateCrmEventResponse.md)**


## GetCrmEvent

Retrieve a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Event.GetCrmEventAsync(
    security: new GetCrmEventSecurity() {
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

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [UnifiedTo.Models.Requests.GetCrmEventSecurity](../../Models/Requests/GetCrmEventSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ConnectionId`                                                                                | *string*                                                                                      | :heavy_check_mark:                                                                            | ID of the connection                                                                          |
| `Id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | ID of the Event                                                                               |
| `Fields`                                                                                      | List<*string*>                                                                                | :heavy_minus_sign:                                                                            | Comma-delimited fields to return                                                              |


### Response

**[GetCrmEventResponse](../../Models/Requests/GetCrmEventResponse.md)**


## ListCrmEvents

List all events

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmEventsRequest req = new ListCrmEventsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Event.ListCrmEventsAsync(
    security: new ListCrmEventsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListCrmEventsRequest](../../Models/Requests/ListCrmEventsRequest.md)                             | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |
| `security`                                                                                        | [UnifiedTo.Models.Requests.ListCrmEventsSecurity](../../Models/Requests/ListCrmEventsSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |


### Response

**[ListCrmEventsResponse](../../Models/Requests/ListCrmEventsResponse.md)**


## PatchCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Event.PatchCrmEventAsync(
    security: new PatchCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmEvent: new CrmEvent() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.PatchCrmEventSecurity](../../Models/Requests/PatchCrmEventSecurity.md)               | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[PatchCrmEventResponse](../../Models/Requests/PatchCrmEventResponse.md)**


## RemoveCrmEvent

Remove a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Event.RemoveCrmEventAsync(
    security: new RemoveCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.RemoveCrmEventSecurity](../../Models/Requests/RemoveCrmEventSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Event                                                                                     |


### Response

**[RemoveCrmEventResponse](../../Models/Requests/RemoveCrmEventResponse.md)**


## UpdateCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Event.UpdateCrmEventAsync(
    security: new UpdateCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmEvent: new CrmEvent() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.UpdateCrmEventSecurity](../../Models/Requests/UpdateCrmEventSecurity.md)             | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[UpdateCrmEventResponse](../../Models/Requests/UpdateCrmEventResponse.md)**

