# Event

## Overview

### Available Operations

* [CreateAnalyticsEvent](#createanalyticsevent) - Create an event
* [CreateCalendarEvent](#createcalendarevent) - Create an event
* [CreateCdpEvent](#createcdpevent) - Create an event
* [CreateCrmEvent](#createcrmevent) - Create an event
* [GetAnalyticsEvent](#getanalyticsevent) - Retrieve an event
* [GetCalendarEvent](#getcalendarevent) - Retrieve an event
* [GetCdpEvent](#getcdpevent) - Retrieve an event
* [GetClubsEvent](#getclubsevent) - Retrieve an event
* [GetCrmEvent](#getcrmevent) - Retrieve an event
* [ListAnalyticsEvents](#listanalyticsevents) - List all events
* [ListCalendarEvents](#listcalendarevents) - List all events
* [ListCdpEvents](#listcdpevents) - List all events
* [ListClubsEvents](#listclubsevents) - List all events
* [ListCrmEvents](#listcrmevents) - List all events
* [PatchCalendarEvent](#patchcalendarevent) - Update an event
* [PatchCdpEvent](#patchcdpevent) - Update an event
* [PatchCrmEvent](#patchcrmevent) - Update an event
* [PatchMessagingEvent](#patchmessagingevent) - Update an event
* [RemoveCalendarEvent](#removecalendarevent) - Remove an event
* [RemoveCdpEvent](#removecdpevent) - Remove an event
* [RemoveCrmEvent](#removecrmevent) - Remove an event
* [UpdateCalendarEvent](#updatecalendarevent) - Update an event
* [UpdateCdpEvent](#updatecdpevent) - Update an event
* [UpdateCrmEvent](#updatecrmevent) - Update an event
* [UpdateMessagingEvent](#updatemessagingevent) - Update an event

## CreateAnalyticsEvent

Creates a AnalyticsEvent. Provide the unified AnalyticsEvent fields in the request body; they are mapped to the provider's API. Returns the created AnalyticsEvent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAnalyticsEvent" method="post" path="/analytics/{connection_id}/event" example="analytics_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateAnalyticsEventAsync(
    analyticsEvent: new AnalyticsEvent() {
        CreatedAt = System.DateTime.Parse("2023-06-21T03:13:22.954Z").ToUniversalTime(),
        EventType = EventType.ScreenView,
        Id = "0227c3f6-b8ec-4f42-ac59-3162994acc52",
        Metadata = new Dictionary<string, PropertyAnalyticsEventMetadata>() {
            { "key", new PropertyAnalyticsEventMetadata() {} },
        },
        Name = "page_view",
        PageUrl = "https://golden-carboxyl.biz",
        UpdatedAt = System.DateTime.Parse("2023-09-24T18:06:07.304Z").ToUniversalTime(),
    },
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

Creates a CalendarEvent. Provide the unified CalendarEvent fields in the request body; they are mapped to the provider's API. Returns the created CalendarEvent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarEvent" method="post" path="/calendar/{connection_id}/event" example="calendar_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateCalendarEventAsync(
    calendarEvent: new CalendarEvent() {
        Attachments = new List<CalendarAttachment>() {},
        Conference = new List<CalendarConference>() {},
        CreatedAt = "2019-08-04T14:33:51.814Z",
        EndAt = "2020-05-24T09:27:35.704Z",
        HasConference = false,
        Id = "867d2a4d-54e6-4368-9b84-20aa3e2512b4",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 4D,
                EndAt = System.DateTime.Parse("2025-03-25T08:47:47.514Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-02-03T08:24:57.655Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Yearly,
                IncludedDates = new List<string>() {
                    "2023-07-07T13:22:25.990Z",
                    "2025-01-24T14:17:20.637Z",
                    "2024-04-02T13:50:04.757Z",
                },
                Interval = 7D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    -3D,
                },
                OnMonths = new List<double>() {
                    0D,
                    1D,
                    6D,
                    -10D,
                    9D,
                    0D,
                },
                OnWeeks = new List<double>() {
                    -8D,
                    3D,
                    -7D,
                    51D,
                    -3D,
                    -41D,
                    15D,
                    46D,
                    -1D,
                    46D,
                    42D,
                    11D,
                    12D,
                    -35D,
                    -15D,
                    -3D,
                    -42D,
                    50D,
                    3D,
                    -15D,
                    -10D,
                    6D,
                    -53D,
                    5D,
                    -32D,
                    -22D,
                    43D,
                    -44D,
                    -23D,
                    -21D,
                    -18D,
                    13D,
                    -5D,
                    2D,
                    -49D,
                },
                OnYearDays = new List<double>() {
                    -87D,
                    339D,
                    341D,
                    287D,
                    -17D,
                    319D,
                    -3D,
                    238D,
                    -115D,
                    -116D,
                    283D,
                    -61D,
                    -254D,
                    86D,
                    -163D,
                    5D,
                    -171D,
                    -99D,
                    279D,
                    19D,
                    303D,
                    -106D,
                    90D,
                    109D,
                    -185D,
                    -285D,
                    -83D,
                    -236D,
                    66D,
                    -215D,
                    178D,
                    64D,
                    78D,
                    5D,
                    -251D,
                    -79D,
                    -271D,
                    33D,
                    320D,
                    67D,
                    -84D,
                    -355D,
                    -364D,
                    348D,
                    271D,
                    -304D,
                    -199D,
                    106D,
                    -345D,
                    24D,
                    -89D,
                    -109D,
                    -314D,
                    365D,
                    38D,
                    -42D,
                    123D,
                    56D,
                    -3D,
                    31D,
                    101D,
                    326D,
                    -160D,
                    -101D,
                    -267D,
                    -309D,
                    -363D,
                    125D,
                    -182D,
                    363D,
                    324D,
                    36D,
                    -269D,
                    -79D,
                    -60D,
                    272D,
                    -254D,
                    -160D,
                    -82D,
                    19D,
                    42D,
                    69D,
                    -104D,
                    333D,
                    236D,
                    -287D,
                    296D,
                    261D,
                    241D,
                    348D,
                    -72D,
                    159D,
                    -127D,
                    229D,
                    -158D,
                    190D,
                    -173D,
                    -84D,
                    -96D,
                    176D,
                    339D,
                    -48D,
                    287D,
                    -46D,
                    -101D,
                    246D,
                    -8D,
                    -74D,
                    338D,
                    -51D,
                    -42D,
                    -128D,
                    -169D,
                    -174D,
                    168D,
                    -85D,
                    37D,
                    169D,
                    -105D,
                    231D,
                    -250D,
                    -286D,
                    -7D,
                    -121D,
                    321D,
                    278D,
                    -120D,
                    -96D,
                    360D,
                    337D,
                    -258D,
                    -179D,
                    324D,
                    -204D,
                    327D,
                    15D,
                    365D,
                    191D,
                    -345D,
                    -345D,
                    56D,
                    217D,
                    60D,
                    -264D,
                    -248D,
                    -316D,
                    191D,
                    -189D,
                    -152D,
                    -296D,
                    194D,
                    -42D,
                    -21D,
                    -218D,
                    171D,
                    -15D,
                    301D,
                    37D,
                    -167D,
                    18D,
                    248D,
                    -263D,
                    27D,
                    14D,
                    59D,
                    219D,
                    -284D,
                    221D,
                    -76D,
                    277D,
                    183D,
                    200D,
                    -12D,
                    -28D,
                    -79D,
                    150D,
                    320D,
                    -152D,
                    -15D,
                    -42D,
                    -125D,
                    -4D,
                    269D,
                    290D,
                    52D,
                    320D,
                    344D,
                    13D,
                    -69D,
                    255D,
                    -154D,
                    -281D,
                    158D,
                    25D,
                    240D,
                    -339D,
                    96D,
                    204D,
                    324D,
                    221D,
                    37D,
                    -333D,
                    87D,
                    354D,
                    -365D,
                    -203D,
                    -341D,
                    -79D,
                    -208D,
                    135D,
                    132D,
                    -351D,
                    39D,
                    -87D,
                    -297D,
                    -66D,
                    346D,
                    69D,
                    -177D,
                    235D,
                    295D,
                    -366D,
                    -55D,
                    -297D,
                    -308D,
                    -294D,
                    -208D,
                    141D,
                    267D,
                    64D,
                    100D,
                    -355D,
                    -335D,
                    280D,
                    224D,
                    259D,
                    1D,
                    -146D,
                    48D,
                    335D,
                    363D,
                    308D,
                    -224D,
                    109D,
                    -10D,
                    -89D,
                    -211D,
                    -47D,
                    -130D,
                    341D,
                    -250D,
                    295D,
                    -329D,
                    -205D,
                    231D,
                    247D,
                    -228D,
                    166D,
                    -28D,
                    36D,
                    277D,
                    -115D,
                    100D,
                    2D,
                    81D,
                    -66D,
                    31D,
                    -39D,
                    -319D,
                    -251D,
                    -254D,
                },
                Timezone = "Asia/Ho_Chi_Minh",
                WeekStart = WeekStart.Tu,
            },
        },
        StartAt = "2020-05-24T00:13:46.974Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-06-30T08:08:37.148Z",
        WebUrl = "https://another-pinstripe.com",
    },
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

## CreateCdpEvent

Creates a CdpEvent. Provide the unified CdpEvent fields in the request body; they are mapped to the provider's API. Returns the created CdpEvent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCdpEvent" method="post" path="/cdp/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateCdpEventAsync(
    cdpEvent: new CdpEvent() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CdpEvent`                                                                                                                                       | [CdpEvent](../../Models/Components/CdpEvent.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCdpEventQueryParamFields](../../Models/Requests/CreateCdpEventQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCdpEventResponse](../../Models/Requests/CreateCdpEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmEvent

Creates a CrmEvent. Provide the unified CrmEvent fields in the request body; they are mapped to the provider's API. Returns the created CrmEvent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmEvent" method="post" path="/crm/{connection_id}/event" example="crm_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.CreateCrmEventAsync(
    crmEvent: new CrmEvent() {
        Call = new PropertyCrmEventCall() {
            Description = "Arbitro aptus.",
            Duration = 64D,
            StartAt = System.DateTime.Parse("2024-12-11T16:12:26.598Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "539ad616-e6dc-4089-acf9-2d25041d5d7d",
        Metadata = new List<CrmMetadata>() {},
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-12T10:43:55.601Z").ToUniversalTime(),
    },
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

Retrieves a single AnalyticsEvent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CalendarEvent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

## GetCdpEvent

Retrieves a single CdpEvent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCdpEvent" method="get" path="/cdp/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.GetCdpEventAsync(
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
| `Fields`                                                                                                                                         | List<[GetCdpEventQueryParamFields](../../Models/Requests/GetCdpEventQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCdpEventResponse](../../Models/Requests/GetCdpEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetClubsEvent

Retrieves a single ClubsEvent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CrmEvent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AnalyticsEvents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CalendarEvents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

## ListCdpEvents

Returns a list of CdpEvents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCdpEvents" method="get" path="/cdp/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCdpEventsRequest req = new ListCdpEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Event.ListCdpEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCdpEventsRequest](../../Models/Requests/ListCdpEventsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListCdpEventsResponse](../../Models/Requests/ListCdpEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListClubsEvents

Returns a list of ClubsEvents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CrmEvents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the CalendarEvent identified by `id`. Provide the unified CalendarEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarEvent" method="patch" path="/calendar/{connection_id}/event/{id}" example="calendar_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarEventRequest req = new PatchCalendarEventRequest() {
    CalendarEvent = new CalendarEvent() {
        Attachments = new List<CalendarAttachment>() {},
        Conference = new List<CalendarConference>() {},
        CreatedAt = "2019-08-04T14:33:51.814Z",
        EndAt = "2020-05-24T09:27:35.710Z",
        HasConference = false,
        Id = "be2e4527-6277-4c21-aa57-40084d360912",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 4D,
                EndAt = System.DateTime.Parse("2025-03-25T08:47:47.554Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-02-03T08:24:57.687Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Yearly,
                IncludedDates = new List<string>() {
                    "2023-07-07T13:22:26.018Z",
                    "2025-01-24T14:17:20.676Z",
                    "2024-04-02T13:50:04.790Z",
                },
                Interval = 7D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    -3D,
                },
                OnMonths = new List<double>() {
                    0D,
                    1D,
                    6D,
                    -10D,
                    9D,
                    0D,
                },
                OnWeeks = new List<double>() {
                    -8D,
                    3D,
                    -7D,
                    51D,
                    -3D,
                    -41D,
                    15D,
                    46D,
                    -1D,
                    46D,
                    42D,
                    11D,
                    12D,
                    -35D,
                    -15D,
                    -3D,
                    -42D,
                    50D,
                    3D,
                    -15D,
                    -10D,
                    6D,
                    -53D,
                    5D,
                    -32D,
                    -22D,
                    43D,
                    -44D,
                    -23D,
                    -21D,
                    -18D,
                    13D,
                    -5D,
                    2D,
                    -49D,
                },
                OnYearDays = new List<double>() {
                    -87D,
                    339D,
                    341D,
                    287D,
                    -17D,
                    319D,
                    -3D,
                    238D,
                    -115D,
                    -116D,
                    283D,
                    -61D,
                    -254D,
                    86D,
                    -163D,
                    5D,
                    -171D,
                    -99D,
                    279D,
                    19D,
                    303D,
                    -106D,
                    90D,
                    109D,
                    -185D,
                    -285D,
                    -83D,
                    -236D,
                    66D,
                    -215D,
                    178D,
                    64D,
                    78D,
                    5D,
                    -251D,
                    -79D,
                    -271D,
                    33D,
                    320D,
                    67D,
                    -84D,
                    -355D,
                    -364D,
                    348D,
                    271D,
                    -304D,
                    -199D,
                    106D,
                    -345D,
                    24D,
                    -89D,
                    -109D,
                    -314D,
                    365D,
                    38D,
                    -42D,
                    123D,
                    56D,
                    -3D,
                    31D,
                    101D,
                    326D,
                    -160D,
                    -101D,
                    -267D,
                    -309D,
                    -363D,
                    125D,
                    -182D,
                    363D,
                    324D,
                    36D,
                    -269D,
                    -79D,
                    -60D,
                    272D,
                    -254D,
                    -160D,
                    -82D,
                    19D,
                    42D,
                    69D,
                    -104D,
                    333D,
                    236D,
                    -287D,
                    296D,
                    261D,
                    241D,
                    348D,
                    -72D,
                    159D,
                    -127D,
                    229D,
                    -158D,
                    190D,
                    -173D,
                    -84D,
                    -96D,
                    176D,
                    339D,
                    -48D,
                    287D,
                    -46D,
                    -101D,
                    246D,
                    -8D,
                    -74D,
                    338D,
                    -51D,
                    -42D,
                    -128D,
                    -169D,
                    -174D,
                    168D,
                    -85D,
                    37D,
                    169D,
                    -105D,
                    231D,
                    -250D,
                    -286D,
                    -7D,
                    -121D,
                    321D,
                    278D,
                    -120D,
                    -96D,
                    360D,
                    337D,
                    -258D,
                    -179D,
                    324D,
                    -204D,
                    327D,
                    15D,
                    365D,
                    191D,
                    -345D,
                    -345D,
                    56D,
                    217D,
                    60D,
                    -264D,
                    -248D,
                    -316D,
                    191D,
                    -189D,
                    -152D,
                    -296D,
                    194D,
                    -42D,
                    -21D,
                    -218D,
                    171D,
                    -15D,
                    301D,
                    37D,
                    -167D,
                    18D,
                    248D,
                    -263D,
                    27D,
                    14D,
                    59D,
                    219D,
                    -284D,
                    221D,
                    -76D,
                    277D,
                    183D,
                    200D,
                    -12D,
                    -28D,
                    -79D,
                    150D,
                    320D,
                    -152D,
                    -15D,
                    -42D,
                    -125D,
                    -4D,
                    269D,
                    290D,
                    52D,
                    320D,
                    344D,
                    13D,
                    -69D,
                    255D,
                    -154D,
                    -281D,
                    158D,
                    25D,
                    240D,
                    -339D,
                    96D,
                    204D,
                    324D,
                    221D,
                    37D,
                    -333D,
                    87D,
                    354D,
                    -365D,
                    -203D,
                    -341D,
                    -79D,
                    -208D,
                    135D,
                    132D,
                    -351D,
                    39D,
                    -87D,
                    -297D,
                    -66D,
                    346D,
                    69D,
                    -177D,
                    235D,
                    295D,
                    -366D,
                    -55D,
                    -297D,
                    -308D,
                    -294D,
                    -208D,
                    141D,
                    267D,
                    64D,
                    100D,
                    -355D,
                    -335D,
                    280D,
                    224D,
                    259D,
                    1D,
                    -146D,
                    48D,
                    335D,
                    363D,
                    308D,
                    -224D,
                    109D,
                    -10D,
                    -89D,
                    -211D,
                    -47D,
                    -130D,
                    341D,
                    -250D,
                    295D,
                    -329D,
                    -205D,
                    231D,
                    247D,
                    -228D,
                    166D,
                    -28D,
                    36D,
                    277D,
                    -115D,
                    100D,
                    2D,
                    81D,
                    -66D,
                    31D,
                    -39D,
                    -319D,
                    -251D,
                    -254D,
                },
                Timezone = "Asia/Ho_Chi_Minh",
                WeekStart = WeekStart.Tu,
            },
        },
        StartAt = "2020-05-24T00:13:46.980Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-06-30T08:08:37.155Z",
        WebUrl = "https://another-pinstripe.com",
    },
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

## PatchCdpEvent

Updates the CdpEvent identified by `id`. Provide the unified CdpEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCdpEvent" method="patch" path="/cdp/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCdpEventRequest req = new PatchCdpEventRequest() {
    CdpEvent = new CdpEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.PatchCdpEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchCdpEventRequest](../../Models/Requests/PatchCdpEventRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchCdpEventResponse](../../Models/Requests/PatchCdpEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmEvent

Updates the CrmEvent identified by `id`. Provide the unified CrmEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmEvent" method="patch" path="/crm/{connection_id}/event/{id}" example="crm_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmEventRequest req = new PatchCrmEventRequest() {
    CrmEvent = new CrmEvent() {
        Call = new PropertyCrmEventCall() {
            Description = "Arbitro aptus.",
            Duration = 64D,
            StartAt = System.DateTime.Parse("2024-12-11T16:12:26.625Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "606fdccd-fbf1-4444-b5a8-d3ab3cbd498a",
        Metadata = new List<CrmMetadata>() {},
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-12T10:43:55.640Z").ToUniversalTime(),
    },
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

Updates the MessagingEvent identified by `id`. Provide the unified MessagingEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingEvent" method="patch" path="/messaging/{connection_id}/event/{id}" example="messaging_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMessagingEventRequest req = new PatchMessagingEventRequest() {
    MessagingEvent = new MessagingEvent() {
        Channel = new PropertyMessagingEventChannel() {
            Id = "",
            Name = "",
        },
        CreatedAt = System.DateTime.Parse("2019-05-30T19:44:46.461Z").ToUniversalTime(),
        Id = "660e2307-d1e2-4036-9528-704bb83bb610",
        IsReplacingOriginal = false,
        Metadata = new List<MessagingMetadata>() {},
        Type = MessagingEventType.ButtonClick,
    },
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

Deletes the CalendarEvent identified by `id`.

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

## RemoveCdpEvent

Deletes the CdpEvent identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCdpEvent" method="delete" path="/cdp/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Event.RemoveCdpEventAsync(
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

**[RemoveCdpEventResponse](../../Models/Requests/RemoveCdpEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmEvent

Deletes the CrmEvent identified by `id`.

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

Updates the CalendarEvent identified by `id`. Provide the unified CalendarEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarEvent" method="put" path="/calendar/{connection_id}/event/{id}" example="calendar_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarEventRequest req = new UpdateCalendarEventRequest() {
    CalendarEvent = new CalendarEvent() {
        Attachments = new List<CalendarAttachment>() {},
        Conference = new List<CalendarConference>() {},
        CreatedAt = "2019-08-04T14:33:51.814Z",
        EndAt = "2020-05-24T09:27:35.710Z",
        HasConference = false,
        Id = "be2e4527-6277-4c21-aa57-40084d360912",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 4D,
                EndAt = System.DateTime.Parse("2025-03-25T08:47:47.554Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-02-03T08:24:57.687Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Yearly,
                IncludedDates = new List<string>() {
                    "2023-07-07T13:22:26.018Z",
                    "2025-01-24T14:17:20.676Z",
                    "2024-04-02T13:50:04.790Z",
                },
                Interval = 7D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    -3D,
                },
                OnMonths = new List<double>() {
                    0D,
                    1D,
                    6D,
                    -10D,
                    9D,
                    0D,
                },
                OnWeeks = new List<double>() {
                    -8D,
                    3D,
                    -7D,
                    51D,
                    -3D,
                    -41D,
                    15D,
                    46D,
                    -1D,
                    46D,
                    42D,
                    11D,
                    12D,
                    -35D,
                    -15D,
                    -3D,
                    -42D,
                    50D,
                    3D,
                    -15D,
                    -10D,
                    6D,
                    -53D,
                    5D,
                    -32D,
                    -22D,
                    43D,
                    -44D,
                    -23D,
                    -21D,
                    -18D,
                    13D,
                    -5D,
                    2D,
                    -49D,
                },
                OnYearDays = new List<double>() {
                    -87D,
                    339D,
                    341D,
                    287D,
                    -17D,
                    319D,
                    -3D,
                    238D,
                    -115D,
                    -116D,
                    283D,
                    -61D,
                    -254D,
                    86D,
                    -163D,
                    5D,
                    -171D,
                    -99D,
                    279D,
                    19D,
                    303D,
                    -106D,
                    90D,
                    109D,
                    -185D,
                    -285D,
                    -83D,
                    -236D,
                    66D,
                    -215D,
                    178D,
                    64D,
                    78D,
                    5D,
                    -251D,
                    -79D,
                    -271D,
                    33D,
                    320D,
                    67D,
                    -84D,
                    -355D,
                    -364D,
                    348D,
                    271D,
                    -304D,
                    -199D,
                    106D,
                    -345D,
                    24D,
                    -89D,
                    -109D,
                    -314D,
                    365D,
                    38D,
                    -42D,
                    123D,
                    56D,
                    -3D,
                    31D,
                    101D,
                    326D,
                    -160D,
                    -101D,
                    -267D,
                    -309D,
                    -363D,
                    125D,
                    -182D,
                    363D,
                    324D,
                    36D,
                    -269D,
                    -79D,
                    -60D,
                    272D,
                    -254D,
                    -160D,
                    -82D,
                    19D,
                    42D,
                    69D,
                    -104D,
                    333D,
                    236D,
                    -287D,
                    296D,
                    261D,
                    241D,
                    348D,
                    -72D,
                    159D,
                    -127D,
                    229D,
                    -158D,
                    190D,
                    -173D,
                    -84D,
                    -96D,
                    176D,
                    339D,
                    -48D,
                    287D,
                    -46D,
                    -101D,
                    246D,
                    -8D,
                    -74D,
                    338D,
                    -51D,
                    -42D,
                    -128D,
                    -169D,
                    -174D,
                    168D,
                    -85D,
                    37D,
                    169D,
                    -105D,
                    231D,
                    -250D,
                    -286D,
                    -7D,
                    -121D,
                    321D,
                    278D,
                    -120D,
                    -96D,
                    360D,
                    337D,
                    -258D,
                    -179D,
                    324D,
                    -204D,
                    327D,
                    15D,
                    365D,
                    191D,
                    -345D,
                    -345D,
                    56D,
                    217D,
                    60D,
                    -264D,
                    -248D,
                    -316D,
                    191D,
                    -189D,
                    -152D,
                    -296D,
                    194D,
                    -42D,
                    -21D,
                    -218D,
                    171D,
                    -15D,
                    301D,
                    37D,
                    -167D,
                    18D,
                    248D,
                    -263D,
                    27D,
                    14D,
                    59D,
                    219D,
                    -284D,
                    221D,
                    -76D,
                    277D,
                    183D,
                    200D,
                    -12D,
                    -28D,
                    -79D,
                    150D,
                    320D,
                    -152D,
                    -15D,
                    -42D,
                    -125D,
                    -4D,
                    269D,
                    290D,
                    52D,
                    320D,
                    344D,
                    13D,
                    -69D,
                    255D,
                    -154D,
                    -281D,
                    158D,
                    25D,
                    240D,
                    -339D,
                    96D,
                    204D,
                    324D,
                    221D,
                    37D,
                    -333D,
                    87D,
                    354D,
                    -365D,
                    -203D,
                    -341D,
                    -79D,
                    -208D,
                    135D,
                    132D,
                    -351D,
                    39D,
                    -87D,
                    -297D,
                    -66D,
                    346D,
                    69D,
                    -177D,
                    235D,
                    295D,
                    -366D,
                    -55D,
                    -297D,
                    -308D,
                    -294D,
                    -208D,
                    141D,
                    267D,
                    64D,
                    100D,
                    -355D,
                    -335D,
                    280D,
                    224D,
                    259D,
                    1D,
                    -146D,
                    48D,
                    335D,
                    363D,
                    308D,
                    -224D,
                    109D,
                    -10D,
                    -89D,
                    -211D,
                    -47D,
                    -130D,
                    341D,
                    -250D,
                    295D,
                    -329D,
                    -205D,
                    231D,
                    247D,
                    -228D,
                    166D,
                    -28D,
                    36D,
                    277D,
                    -115D,
                    100D,
                    2D,
                    81D,
                    -66D,
                    31D,
                    -39D,
                    -319D,
                    -251D,
                    -254D,
                },
                Timezone = "Asia/Ho_Chi_Minh",
                WeekStart = WeekStart.Tu,
            },
        },
        StartAt = "2020-05-24T00:13:46.980Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-06-30T08:08:37.155Z",
        WebUrl = "https://another-pinstripe.com",
    },
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

## UpdateCdpEvent

Updates the CdpEvent identified by `id`. Provide the unified CdpEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCdpEvent" method="put" path="/cdp/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCdpEventRequest req = new UpdateCdpEventRequest() {
    CdpEvent = new CdpEvent() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Event.UpdateCdpEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCdpEventRequest](../../Models/Requests/UpdateCdpEventRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateCdpEventResponse](../../Models/Requests/UpdateCdpEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmEvent

Updates the CrmEvent identified by `id`. Provide the unified CrmEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmEvent" method="put" path="/crm/{connection_id}/event/{id}" example="crm_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmEventRequest req = new UpdateCrmEventRequest() {
    CrmEvent = new CrmEvent() {
        Call = new PropertyCrmEventCall() {
            Description = "Arbitro aptus.",
            Duration = 64D,
            StartAt = System.DateTime.Parse("2024-12-11T16:12:26.625Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "606fdccd-fbf1-4444-b5a8-d3ab3cbd498a",
        Metadata = new List<CrmMetadata>() {},
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-12T10:43:55.640Z").ToUniversalTime(),
    },
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

Updates the MessagingEvent identified by `id`. Provide the unified MessagingEvent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingEvent" method="put" path="/messaging/{connection_id}/event/{id}" example="messaging_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMessagingEventRequest req = new UpdateMessagingEventRequest() {
    MessagingEvent = new MessagingEvent() {
        Channel = new PropertyMessagingEventChannel() {
            Id = "",
            Name = "",
        },
        CreatedAt = System.DateTime.Parse("2019-05-30T19:44:46.461Z").ToUniversalTime(),
        Id = "660e2307-d1e2-4036-9528-704bb83bb610",
        IsReplacingOriginal = false,
        Metadata = new List<MessagingMetadata>() {},
        Type = MessagingEventType.ButtonClick,
    },
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