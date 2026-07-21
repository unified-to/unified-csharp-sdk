# Event

## Overview

### Available Operations

* [CreateAnalyticsEvent](#createanalyticsevent) - Create an event
* [CreateCalendarEvent](#createcalendarevent) - Create an event
* [CreateCrmEvent](#createcrmevent) - Create an event
* [GetAnalyticsEvent](#getanalyticsevent) - Retrieve an event
* [GetCalendarEvent](#getcalendarevent) - Retrieve an event
* [GetClubsEvent](#getclubsevent) - Retrieve an event
* [GetCrmEvent](#getcrmevent) - Retrieve an event
* [ListAnalyticsEvents](#listanalyticsevents) - List all events
* [ListCalendarEvents](#listcalendarevents) - List all events
* [ListClubsEvents](#listclubsevents) - List all events
* [ListCrmEvents](#listcrmevents) - List all events
* [PatchCalendarEvent](#patchcalendarevent) - Update an event
* [PatchCrmEvent](#patchcrmevent) - Update an event
* [PatchMessagingEvent](#patchmessagingevent) - Update an event
* [RemoveCalendarEvent](#removecalendarevent) - Remove an event
* [RemoveCrmEvent](#removecrmevent) - Remove an event
* [UpdateCalendarEvent](#updatecalendarevent) - Update an event
* [UpdateCrmEvent](#updatecrmevent) - Update an event
* [UpdateMessagingEvent](#updatemessagingevent) - Update an event

## CreateAnalyticsEvent

Create an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAnalyticsEvent" method="post" path="/analytics/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateAnalyticsEventAsync(
    analyticsEvent: new AnalyticsEvent() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AnalyticsEvent`                                                                                                                                 | [AnalyticsEvent](../../Models/Components/AnalyticsEvent.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAnalyticsEventQueryParamFields](../../Models/Requests/CreateAnalyticsEventQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAnalyticsEventResponse](../../Models/Requests/CreateAnalyticsEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCalendarEvent

Create an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarEvent" method="post" path="/calendar/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateCalendarEventAsync(
    calendarEvent: new CalendarEvent() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CalendarEvent`                                                                                                                                  | [CalendarEvent](../../Models/Components/CalendarEvent.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCalendarEventQueryParamFields](../../Models/Requests/CreateCalendarEventQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCalendarEventResponse](../../Models/Requests/CreateCalendarEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmEvent

Create an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmEvent" method="post" path="/crm/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateCrmEventAsync(
    crmEvent: new CrmEvent() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmEvent`                                                                                                                                       | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company                                  |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmEventQueryParamFields](../../Models/Requests/CreateCrmEventQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmEventResponse](../../Models/Requests/CreateCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAnalyticsEvent

Retrieve an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAnalyticsEvent" method="get" path="/analytics/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.GetAnalyticsEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Event                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAnalyticsEventQueryParamFields](../../Models/Requests/GetAnalyticsEventQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAnalyticsEventResponse](../../Models/Requests/GetAnalyticsEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarEvent

Retrieve an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarEvent" method="get" path="/calendar/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.GetCalendarEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Event                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetCalendarEventQueryParamFields](../../Models/Requests/GetCalendarEventQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarEventResponse](../../Models/Requests/GetCalendarEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetClubsEvent

Retrieve an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClubsEvent" method="get" path="/clubs/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.GetClubsEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Event                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetClubsEventQueryParamFields](../../Models/Requests/GetClubsEventQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetClubsEventResponse](../../Models/Requests/GetClubsEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmEvent

Retrieve an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmEvent" method="get" path="/crm/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.GetCrmEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Event                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetCrmEventQueryParamFields](../../Models/Requests/GetCrmEventQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmEventResponse](../../Models/Requests/GetCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAnalyticsEvents

List all events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAnalyticsEvents" method="get" path="/analytics/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsEventsRequest req = new ListAnalyticsEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Event.ListAnalyticsEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAnalyticsEventsRequest](../../Models/Requests/ListAnalyticsEventsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListAnalyticsEventsResponse](../../Models/Requests/ListAnalyticsEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarEvents

List all events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarEvents" method="get" path="/calendar/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarEventsRequest req = new ListCalendarEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Event.ListCalendarEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListCalendarEventsRequest](../../Models/Requests/ListCalendarEventsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListCalendarEventsResponse](../../Models/Requests/ListCalendarEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListClubsEvents

List all events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClubsEvents" method="get" path="/clubs/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListClubsEventsRequest req = new ListClubsEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Event.ListClubsEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListClubsEventsRequest](../../Models/Requests/ListClubsEventsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListClubsEventsResponse](../../Models/Requests/ListClubsEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmEvents

List all events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmEvents" method="get" path="/crm/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmEventsRequest req = new ListCrmEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Event.ListCrmEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCrmEventsRequest](../../Models/Requests/ListCrmEventsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListCrmEventsResponse](../../Models/Requests/ListCrmEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCalendarEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarEvent" method="patch" path="/calendar/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarEventRequest req = new PatchCalendarEventRequest() {
    CalendarEvent = new CalendarEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.PatchCalendarEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchCalendarEventRequest](../../Models/Requests/PatchCalendarEventRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchCalendarEventResponse](../../Models/Requests/PatchCalendarEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmEvent" method="patch" path="/crm/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmEventRequest req = new PatchCrmEventRequest() {
    CrmEvent = new CrmEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.PatchCrmEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchCrmEventRequest](../../Models/Requests/PatchCrmEventRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchCrmEventResponse](../../Models/Requests/PatchCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMessagingEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingEvent" method="patch" path="/messaging/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMessagingEventRequest req = new PatchMessagingEventRequest() {
    MessagingEvent = new MessagingEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.PatchMessagingEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchMessagingEventRequest](../../Models/Requests/PatchMessagingEventRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchMessagingEventResponse](../../Models/Requests/PatchMessagingEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCalendarEvent

Remove an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCalendarEvent" method="delete" path="/calendar/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.RemoveCalendarEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Event      |

### Response

**[RemoveCalendarEventResponse](../../Models/Requests/RemoveCalendarEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmEvent

Remove an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmEvent" method="delete" path="/crm/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.RemoveCrmEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Event      |

### Response

**[RemoveCrmEventResponse](../../Models/Requests/RemoveCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCalendarEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarEvent" method="put" path="/calendar/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarEventRequest req = new UpdateCalendarEventRequest() {
    CalendarEvent = new CalendarEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.UpdateCalendarEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateCalendarEventRequest](../../Models/Requests/UpdateCalendarEventRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateCalendarEventResponse](../../Models/Requests/UpdateCalendarEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmEvent" method="put" path="/crm/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmEventRequest req = new UpdateCrmEventRequest() {
    CrmEvent = new CrmEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.UpdateCrmEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCrmEventRequest](../../Models/Requests/UpdateCrmEventRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateCrmEventResponse](../../Models/Requests/UpdateCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMessagingEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingEvent" method="put" path="/messaging/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMessagingEventRequest req = new UpdateMessagingEventRequest() {
    MessagingEvent = new MessagingEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.UpdateMessagingEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateMessagingEventRequest](../../Models/Requests/UpdateMessagingEventRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateMessagingEventResponse](../../Models/Requests/UpdateMessagingEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |