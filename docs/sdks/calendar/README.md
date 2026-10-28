# Calendar

## Overview

### Available Operations

* [CreateCalendarCalendar](#createcalendarcalendar) - Create a calendar
* [CreateCalendarEvent](#createcalendarevent) - Create an event
* [CreateCalendarLink](#createcalendarlink) - Create a link
* [CreateCalendarWebinar](#createcalendarwebinar) - Create a webinar
* [GetCalendarCalendar](#getcalendarcalendar) - Retrieve a calendar
* [GetCalendarEvent](#getcalendarevent) - Retrieve an event
* [GetCalendarLink](#getcalendarlink) - Retrieve a link
* [GetCalendarLocation](#getcalendarlocation) - Retrieve a location
* [GetCalendarRecording](#getcalendarrecording) - Retrieve a recording
* [GetCalendarRoom](#getcalendarroom) - Retrieve a room
* [GetCalendarWebinar](#getcalendarwebinar) - Retrieve a webinar
* [ListCalendarBusies](#listcalendarbusies) - List all busies
* [ListCalendarCalendars](#listcalendarcalendars) - List all calendars
* [ListCalendarEvents](#listcalendarevents) - List all events
* [ListCalendarLinks](#listcalendarlinks) - List all links
* [ListCalendarLocations](#listcalendarlocations) - List all locations
* [ListCalendarRecordings](#listcalendarrecordings) - List all recordings
* [ListCalendarRooms](#listcalendarrooms) - List all rooms
* [ListCalendarWebinars](#listcalendarwebinars) - List all webinars
* [PatchCalendarCalendar](#patchcalendarcalendar) - Update a calendar
* [PatchCalendarEvent](#patchcalendarevent) - Update an event
* [PatchCalendarLink](#patchcalendarlink) - Update a link
* [PatchCalendarWebinar](#patchcalendarwebinar) - Update a webinar
* [RemoveCalendarCalendar](#removecalendarcalendar) - Remove a calendar
* [RemoveCalendarEvent](#removecalendarevent) - Remove an event
* [RemoveCalendarLink](#removecalendarlink) - Remove a link
* [RemoveCalendarWebinar](#removecalendarwebinar) - Remove a webinar
* [UpdateCalendarCalendar](#updatecalendarcalendar) - Update a calendar
* [UpdateCalendarEvent](#updatecalendarevent) - Update an event
* [UpdateCalendarLink](#updatecalendarlink) - Update a link
* [UpdateCalendarWebinar](#updatecalendarwebinar) - Update a webinar

## CreateCalendarCalendar

Creates a CalendarCalendar. Provide the unified CalendarCalendar fields in the request body; they are mapped to the provider's API. Returns the created CalendarCalendar.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarCalendar" method="post" path="/calendar/{connection_id}/calendar" example="calendar_calendar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.CreateCalendarCalendarAsync(
    calendarCalendar: new CalendarCalendar() {
        CreatedAt = System.DateTime.Parse("2020-01-09T23:11:34.147Z").ToUniversalTime(),
        Description = "Acer supra vallum suasoria thesaurus.",
        Id = "cbe08f68-0da2-4393-afb6-c17c12619648",
        IsPrimary = false,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Interviews",
        Timezone = "Asia/Kolkata",
        UpdatedAt = System.DateTime.Parse("2023-03-31T11:17:36.635Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CalendarCalendar`                                                                                                                               | [CalendarCalendar](../../Models/Components/CalendarCalendar.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCalendarCalendarQueryParamFields](../../Models/Requests/CreateCalendarCalendarQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCalendarCalendarResponse](../../Models/Requests/CreateCalendarCalendarResponse.md)**

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

var res = await sdk.Calendar.CreateCalendarEventAsync(
    calendarEvent: new CalendarEvent() {
        Attachments = new List<CalendarAttachment>() {},
        Conference = new List<CalendarConference>() {},
        CreatedAt = "2019-08-04T14:33:51.814Z",
        EndAt = "2020-05-25T01:48:21.956Z",
        HasConference = false,
        Id = "8e2d3019-b019-49b4-a628-502f37245a2a",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 4D,
                EndAt = System.DateTime.Parse("2025-03-30T03:24:01.957Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-02-07T03:52:23.197Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Yearly,
                IncludedDates = new List<string>() {
                    "2023-07-10T21:06:09.141Z",
                    "2025-01-29T05:34:02.786Z",
                    "2024-04-06T12:35:13.353Z",
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
        StartAt = "2020-05-24T16:33:16.192Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-07-01T02:32:43.597Z",
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

## CreateCalendarLink

Creates a CalendarLink. Provide the unified CalendarLink fields in the request body; they are mapped to the provider's API. Returns the created CalendarLink.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarLink" method="post" path="/calendar/{connection_id}/link" example="calendar_link" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.CreateCalendarLinkAsync(
    calendarLink: new CalendarLink() {
        CreatedAt = "2023-03-07T13:34:11.959Z",
        Description = "Vitium clibanus laboriosam uxor denuncio.",
        Duration = 74D,
        Id = "21d84e4b-8941-4a1d-8573-18e1596a14c4",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-17T12:39:12.939Z",
        Url = "https://annual-apricot.info/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CalendarLink`                                                                                                                                   | [CalendarLink](../../Models/Components/CalendarLink.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCalendarLinkQueryParamFields](../../Models/Requests/CreateCalendarLinkQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCalendarLinkResponse](../../Models/Requests/CreateCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCalendarWebinar

Creates a CalendarWebinar. Provide the unified CalendarWebinar fields in the request body; they are mapped to the provider's API. Returns the created CalendarWebinar.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarWebinar" method="post" path="/calendar/{connection_id}/webinar" example="calendar_webinar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.CreateCalendarWebinarAsync(
    calendarWebinar: new CalendarWebinar() {
        Conference = new List<CalendarConference>() {},
        CreatedAt = System.DateTime.Parse("2022-07-06T11:45:14.631Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-11-03T03:28:24.185Z").ToUniversalTime(),
        HasPolls = false,
        HasRecording = false,
        Id = "da2a0efa-e29f-4242-8348-7ad651107861",
        IsAutoApprove = false,
        IsEnabled = true,
        IsWebcast = false,
        JoinUrl = "https://nutritious-crocodile.com",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Curriculum ducimus assentator aspernatur ait.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 10D,
                EndAt = System.DateTime.Parse("2023-09-02T12:04:58.264Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-02-17T07:00:22.965Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2024-05-01T05:56:18.545Z",
                },
                Interval = 8D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                },
                OnMonthDays = new List<double>() {
                    -10D,
                },
                OnMonths = new List<double>() {
                    -9D,
                },
                OnWeeks = new List<double>() {
                    10D,
                    30D,
                    -38D,
                    30D,
                    -22D,
                    37D,
                    -12D,
                    27D,
                    2D,
                    15D,
                    26D,
                    18D,
                    -43D,
                    -33D,
                    -27D,
                    38D,
                    28D,
                    47D,
                    -8D,
                    24D,
                    35D,
                    -2D,
                    7D,
                    49D,
                    38D,
                    -41D,
                    46D,
                    -11D,
                    -45D,
                    0D,
                    48D,
                    34D,
                },
                OnYearDays = new List<double>() {
                    345D,
                    -207D,
                    230D,
                    -10D,
                    364D,
                    -256D,
                    -218D,
                    -295D,
                    290D,
                    -250D,
                    -315D,
                    60D,
                    205D,
                    -247D,
                    -318D,
                    -211D,
                    -13D,
                    256D,
                    -200D,
                    -313D,
                    336D,
                    -332D,
                    -90D,
                    287D,
                    -273D,
                    156D,
                    241D,
                    -138D,
                    -363D,
                    -37D,
                    -171D,
                    -62D,
                    -57D,
                    280D,
                    -322D,
                    -79D,
                    -364D,
                    -201D,
                    84D,
                    341D,
                    334D,
                    -75D,
                    332D,
                    207D,
                    337D,
                    -244D,
                    131D,
                    -191D,
                    164D,
                    -235D,
                    285D,
                    -309D,
                    -158D,
                    306D,
                    180D,
                    -130D,
                    -162D,
                    -155D,
                    3D,
                    198D,
                    26D,
                    -366D,
                    -191D,
                    127D,
                    -331D,
                    -11D,
                    -239D,
                    -189D,
                    243D,
                    118D,
                    346D,
                    -174D,
                    -146D,
                    -161D,
                    -330D,
                    327D,
                    192D,
                    310D,
                    316D,
                    313D,
                    -242D,
                    -51D,
                    -264D,
                    -180D,
                    -88D,
                    305D,
                    270D,
                    358D,
                    -173D,
                    -298D,
                    153D,
                    -89D,
                    155D,
                    -45D,
                    248D,
                    -46D,
                    -146D,
                    300D,
                    364D,
                    -335D,
                    356D,
                    -18D,
                    219D,
                    324D,
                    -239D,
                    -106D,
                    -298D,
                    328D,
                    362D,
                    344D,
                    -54D,
                    133D,
                    50D,
                    112D,
                    -212D,
                    -179D,
                    22D,
                    -201D,
                    -62D,
                    -293D,
                    9D,
                    30D,
                    -50D,
                    126D,
                    -72D,
                    264D,
                    28D,
                    -1D,
                    -207D,
                    160D,
                    -168D,
                    3D,
                    -176D,
                    -19D,
                    -157D,
                    349D,
                    100D,
                    -201D,
                    108D,
                    -180D,
                    51D,
                    -73D,
                    366D,
                    74D,
                    -226D,
                    238D,
                    121D,
                    -193D,
                    -125D,
                    -109D,
                    316D,
                    -177D,
                    -307D,
                    31D,
                    -76D,
                    217D,
                    -310D,
                    227D,
                    -360D,
                    71D,
                    255D,
                    -325D,
                    -214D,
                    40D,
                    42D,
                    17D,
                    -241D,
                    -84D,
                    -188D,
                    302D,
                    64D,
                    94D,
                    -362D,
                    23D,
                    166D,
                    85D,
                    71D,
                    -74D,
                    -47D,
                    -119D,
                    98D,
                    40D,
                    158D,
                    -64D,
                    175D,
                    269D,
                    127D,
                    -143D,
                    213D,
                    -196D,
                    121D,
                    81D,
                    -238D,
                    288D,
                    321D,
                    276D,
                    133D,
                    22D,
                    -213D,
                    -157D,
                    -280D,
                    -35D,
                    73D,
                    -194D,
                    65D,
                    -180D,
                    63D,
                    -242D,
                    -117D,
                    148D,
                    157D,
                    -320D,
                    318D,
                    8D,
                    210D,
                    -21D,
                    81D,
                    205D,
                    -258D,
                    -40D,
                    -114D,
                    -253D,
                    -263D,
                    65D,
                    185D,
                    -24D,
                    324D,
                    -172D,
                    25D,
                    260D,
                    211D,
                    342D,
                    -31D,
                    -288D,
                    -159D,
                    -4D,
                    -2D,
                    -107D,
                    -316D,
                    -276D,
                    331D,
                    -114D,
                    -20D,
                    -320D,
                    51D,
                    -176D,
                    -148D,
                    -50D,
                    -201D,
                    -104D,
                    153D,
                    -273D,
                    -189D,
                    67D,
                    209D,
                    149D,
                    49D,
                    -136D,
                    -125D,
                    -169D,
                    -324D,
                    309D,
                    -51D,
                    288D,
                    253D,
                    175D,
                    -146D,
                    171D,
                    -140D,
                    58D,
                    -212D,
                    164D,
                    270D,
                    102D,
                    70D,
                    299D,
                    89D,
                    -280D,
                    252D,
                    -342D,
                    240D,
                    226D,
                    68D,
                    -30D,
                    -232D,
                    -358D,
                    -166D,
                    60D,
                    140D,
                    275D,
                    13D,
                    250D,
                    -328D,
                    -189D,
                    -22D,
                    7D,
                    -235D,
                    -322D,
                    178D,
                    167D,
                    -104D,
                    -61D,
                    282D,
                    -80D,
                    -277D,
                    108D,
                    271D,
                    -237D,
                    297D,
                    -135D,
                    -135D,
                    -323D,
                    342D,
                    -267D,
                    -235D,
                    173D,
                    249D,
                    -288D,
                    257D,
                    139D,
                    -191D,
                    -217D,
                    10D,
                    -117D,
                    -297D,
                    -196D,
                    -206D,
                    341D,
                    166D,
                    181D,
                    129D,
                    -207D,
                    55D,
                    86D,
                },
                Timezone = "Africa/Abidjan",
                WeekStart = WeekStart.Mo,
            },
            new CalendarEventRecurrence() {
                Count = 3D,
                EndAt = System.DateTime.Parse("2022-10-01T01:29:36.409Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-09-05T06:51:03.648Z",
                    "2024-08-20T16:12:46.809Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2024-03-27T23:41:11.284Z",
                    "2026-01-19T04:02:15.848Z",
                    "2023-08-16T01:46:54.093Z",
                },
                Interval = 1D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                },
                OnMonthDays = new List<double>() {
                    -15D,
                },
                OnMonths = new List<double>() {
                    5D,
                    12D,
                    3D,
                    12D,
                    8D,
                },
                OnWeeks = new List<double>() {
                    -47D,
                    44D,
                },
                OnYearDays = new List<double>() {
                    -117D,
                    59D,
                    -6D,
                    187D,
                    45D,
                    70D,
                    15D,
                    255D,
                    44D,
                    -2D,
                    25D,
                    -175D,
                    -240D,
                    171D,
                    -294D,
                    19D,
                    38D,
                    -351D,
                    170D,
                    -10D,
                    -269D,
                    18D,
                    -65D,
                    -266D,
                    -31D,
                    328D,
                    -361D,
                    358D,
                    -256D,
                    -4D,
                    -312D,
                    82D,
                    -2D,
                    -75D,
                    -281D,
                    -304D,
                    53D,
                    -295D,
                    366D,
                    322D,
                    -191D,
                    26D,
                    97D,
                    53D,
                    75D,
                    -62D,
                    -109D,
                    66D,
                    177D,
                    -68D,
                    175D,
                    -280D,
                    70D,
                    -238D,
                    109D,
                    -304D,
                    326D,
                    -8D,
                    -71D,
                    -236D,
                    225D,
                    358D,
                    20D,
                    -5D,
                    -102D,
                    -134D,
                    -204D,
                    -116D,
                    -353D,
                    -273D,
                    106D,
                    284D,
                    -137D,
                    -324D,
                    301D,
                    -42D,
                    -229D,
                    271D,
                    -293D,
                    -343D,
                    211D,
                    47D,
                    -254D,
                    -154D,
                    -182D,
                    264D,
                    120D,
                    -11D,
                    -307D,
                    99D,
                    227D,
                    190D,
                    -17D,
                    -77D,
                    -255D,
                    -61D,
                    -249D,
                    -102D,
                    70D,
                    345D,
                    -187D,
                    -308D,
                    194D,
                    221D,
                    268D,
                    -169D,
                    -190D,
                    88D,
                    10D,
                    262D,
                    177D,
                    -314D,
                    -151D,
                    -295D,
                },
                Timezone = "Asia/Choibalsan",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2026-08-02T04:02:57.626Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-06-20T03:48:34.204Z",
                    "2023-06-09T03:28:19.422Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-04-05T01:25:20.508Z",
                    "2023-08-21T21:50:00.237Z",
                    "2024-09-30T14:20:32.627Z",
                },
                Interval = 8D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                },
                OnMonthDays = new List<double>() {
                    -23D,
                },
                OnMonths = new List<double>() {
                    11D,
                    8D,
                    9D,
                    5D,
                    -12D,
                    -7D,
                    -5D,
                    10D,
                    10D,
                    -9D,
                    -10D,
                },
                OnWeeks = new List<double>() {
                    -49D,
                    46D,
                    35D,
                    -26D,
                    2D,
                    15D,
                    15D,
                    -26D,
                    24D,
                    -53D,
                    36D,
                    -43D,
                    51D,
                    -19D,
                    -7D,
                    -12D,
                    28D,
                    27D,
                    35D,
                    12D,
                    -28D,
                    -8D,
                    -4D,
                    -45D,
                },
                OnYearDays = new List<double>() {
                    84D,
                    -251D,
                    71D,
                    181D,
                    -163D,
                    158D,
                    301D,
                    -299D,
                    -184D,
                    -331D,
                    -152D,
                    -129D,
                    -237D,
                    -303D,
                    -24D,
                    126D,
                    -103D,
                    146D,
                    -346D,
                    86D,
                    -296D,
                    -337D,
                    -185D,
                    16D,
                    -270D,
                    -126D,
                    -295D,
                    -231D,
                    356D,
                    -293D,
                    115D,
                    -265D,
                    -293D,
                    -34D,
                    357D,
                    313D,
                    -343D,
                    180D,
                    -22D,
                    -161D,
                    350D,
                    177D,
                    190D,
                    223D,
                    -152D,
                    -360D,
                    -225D,
                    -60D,
                    -35D,
                    353D,
                    117D,
                    -171D,
                    -315D,
                    -321D,
                    -202D,
                    345D,
                    -1D,
                    -148D,
                    -168D,
                    181D,
                    -17D,
                    282D,
                    234D,
                    31D,
                    47D,
                    -236D,
                    366D,
                    -251D,
                    -232D,
                    -308D,
                    76D,
                    -199D,
                    184D,
                    198D,
                    225D,
                    75D,
                    6D,
                    227D,
                    -148D,
                    259D,
                    -146D,
                    49D,
                    -254D,
                    341D,
                    93D,
                    138D,
                    -164D,
                    237D,
                    4D,
                    -287D,
                    161D,
                },
                Timezone = "Asia/Krasnoyarsk",
                WeekStart = WeekStart.We,
            },
        },
        RegistrantPassword = "W7J6DhkM",
        RequireAddress = false,
        RequireJobTitle = false,
        StartAt = System.DateTime.Parse("2025-05-05T04:27:01.838Z").ToUniversalTime(),
        Status = CalendarWebinarStatus.Tentative,
        Subject = "Harum culpa decipio ex cubo ancilla cresco.",
        Timezone = "Europe/Kaliningrad",
        UpdatedAt = System.DateTime.Parse("2026-10-07T10:24:40.822Z").ToUniversalTime(),
        WebUrl = "https://quiet-permafrost.name",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CalendarWebinar`                                                                                                                                | [CalendarWebinar](../../Models/Components/CalendarWebinar.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCalendarWebinarQueryParamFields](../../Models/Requests/CreateCalendarWebinarQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCalendarWebinarResponse](../../Models/Requests/CreateCalendarWebinarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarCalendar

Retrieves a single CalendarCalendar by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarCalendar" method="get" path="/calendar/{connection_id}/calendar/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.GetCalendarCalendarAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Calendar                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetCalendarCalendarQueryParamFields](../../Models/Requests/GetCalendarCalendarQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarCalendarResponse](../../Models/Requests/GetCalendarCalendarResponse.md)**

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

var res = await sdk.Calendar.GetCalendarEventAsync(
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

## GetCalendarLink

Retrieves a single CalendarLink by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarLink" method="get" path="/calendar/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.GetCalendarLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Link                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCalendarLinkQueryParamFields](../../Models/Requests/GetCalendarLinkQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarLinkResponse](../../Models/Requests/GetCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarLocation

Retrieves a single CalendarLocation by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarLocation" method="get" path="/calendar/{connection_id}/location/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.GetCalendarLocationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Location                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetCalendarLocationQueryParamFields](../../Models/Requests/GetCalendarLocationQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarLocationResponse](../../Models/Requests/GetCalendarLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarRecording

Retrieves a single CalendarRecording by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarRecording" method="get" path="/calendar/{connection_id}/recording/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.GetCalendarRecordingAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Recording                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetCalendarRecordingQueryParamFields](../../Models/Requests/GetCalendarRecordingQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarRecordingResponse](../../Models/Requests/GetCalendarRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarRoom

Retrieves a single CalendarRoom by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarRoom" method="get" path="/calendar/{connection_id}/room/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.GetCalendarRoomAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Room                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCalendarRoomQueryParamFields](../../Models/Requests/GetCalendarRoomQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarRoomResponse](../../Models/Requests/GetCalendarRoomResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarWebinar

Retrieves a single CalendarWebinar by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarWebinar" method="get" path="/calendar/{connection_id}/webinar/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.GetCalendarWebinarAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Webinar                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetCalendarWebinarQueryParamFields](../../Models/Requests/GetCalendarWebinarQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarWebinarResponse](../../Models/Requests/GetCalendarWebinarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarBusies

Returns a list of CalendarBusies. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarBusies" method="get" path="/calendar/{connection_id}/busy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarBusiesRequest req = new ListCalendarBusiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarBusiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListCalendarBusiesRequest](../../Models/Requests/ListCalendarBusiesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListCalendarBusiesResponse](../../Models/Requests/ListCalendarBusiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarCalendars

Returns a list of CalendarCalendars. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarCalendars" method="get" path="/calendar/{connection_id}/calendar" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarCalendarsRequest req = new ListCalendarCalendarsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarCalendarsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCalendarCalendarsRequest](../../Models/Requests/ListCalendarCalendarsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListCalendarCalendarsResponse](../../Models/Requests/ListCalendarCalendarsResponse.md)**

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

var res = await sdk.Calendar.ListCalendarEventsAsync(req);

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

## ListCalendarLinks

Returns a list of CalendarLinks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarLinks" method="get" path="/calendar/{connection_id}/link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarLinksRequest req = new ListCalendarLinksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarLinksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCalendarLinksRequest](../../Models/Requests/ListCalendarLinksRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCalendarLinksResponse](../../Models/Requests/ListCalendarLinksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarLocations

Returns a list of CalendarLocations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarLocations" method="get" path="/calendar/{connection_id}/location" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarLocationsRequest req = new ListCalendarLocationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarLocationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCalendarLocationsRequest](../../Models/Requests/ListCalendarLocationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListCalendarLocationsResponse](../../Models/Requests/ListCalendarLocationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarRecordings

Returns a list of CalendarRecordings. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarRecordings" method="get" path="/calendar/{connection_id}/recording" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarRecordingsRequest req = new ListCalendarRecordingsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarRecordingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListCalendarRecordingsRequest](../../Models/Requests/ListCalendarRecordingsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListCalendarRecordingsResponse](../../Models/Requests/ListCalendarRecordingsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarRooms

Returns a list of CalendarRooms. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarRooms" method="get" path="/calendar/{connection_id}/room" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarRoomsRequest req = new ListCalendarRoomsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarRoomsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCalendarRoomsRequest](../../Models/Requests/ListCalendarRoomsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCalendarRoomsResponse](../../Models/Requests/ListCalendarRoomsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarWebinars

Returns a list of CalendarWebinars. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarWebinars" method="get" path="/calendar/{connection_id}/webinar" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarWebinarsRequest req = new ListCalendarWebinarsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Calendar.ListCalendarWebinarsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListCalendarWebinarsRequest](../../Models/Requests/ListCalendarWebinarsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListCalendarWebinarsResponse](../../Models/Requests/ListCalendarWebinarsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCalendarCalendar

Updates the CalendarCalendar identified by `id`. Provide the unified CalendarCalendar fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarCalendar" method="patch" path="/calendar/{connection_id}/calendar/{id}" example="calendar_calendar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarCalendarRequest req = new PatchCalendarCalendarRequest() {
    CalendarCalendar = new CalendarCalendar() {
        CreatedAt = System.DateTime.Parse("2020-01-09T23:11:34.147Z").ToUniversalTime(),
        Description = "Acer supra vallum suasoria thesaurus.",
        Id = "b08bbf16-40b9-4391-8dad-58223c50abc7",
        IsPrimary = false,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Interviews",
        Timezone = "Asia/Kolkata",
        UpdatedAt = System.DateTime.Parse("2023-03-31T11:17:36.642Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.PatchCalendarCalendarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchCalendarCalendarRequest](../../Models/Requests/PatchCalendarCalendarRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchCalendarCalendarResponse](../../Models/Requests/PatchCalendarCalendarResponse.md)**

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
        EndAt = "2020-05-25T01:48:21.962Z",
        HasConference = false,
        Id = "ed80a083-a82b-4f3a-a578-b05d864148b7",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 4D,
                EndAt = System.DateTime.Parse("2025-03-30T03:24:02.003Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-02-07T03:52:23.233Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Yearly,
                IncludedDates = new List<string>() {
                    "2023-07-10T21:06:09.173Z",
                    "2025-01-29T05:34:02.831Z",
                    "2024-04-06T12:35:13.391Z",
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
        StartAt = "2020-05-24T16:33:16.198Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-07-01T02:32:43.605Z",
        WebUrl = "https://another-pinstripe.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.PatchCalendarEventAsync(req);

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

## PatchCalendarLink

Updates the CalendarLink identified by `id`. Provide the unified CalendarLink fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarLink" method="patch" path="/calendar/{connection_id}/link/{id}" example="calendar_link" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarLinkRequest req = new PatchCalendarLinkRequest() {
    CalendarLink = new CalendarLink() {
        CreatedAt = "2023-03-07T13:34:11.959Z",
        Description = "Vitium clibanus laboriosam uxor denuncio.",
        Duration = 74D,
        Id = "baa61f2f-7fce-4c64-be3c-2175316b752e",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-17T12:39:12.944Z",
        Url = "https://annual-apricot.info/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.PatchCalendarLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchCalendarLinkRequest](../../Models/Requests/PatchCalendarLinkRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchCalendarLinkResponse](../../Models/Requests/PatchCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCalendarWebinar

Updates the CalendarWebinar identified by `id`. Provide the unified CalendarWebinar fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarWebinar" method="patch" path="/calendar/{connection_id}/webinar/{id}" example="calendar_webinar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarWebinarRequest req = new PatchCalendarWebinarRequest() {
    CalendarWebinar = new CalendarWebinar() {
        Conference = new List<CalendarConference>() {},
        CreatedAt = System.DateTime.Parse("2022-07-06T11:45:14.631Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-11-03T03:28:24.233Z").ToUniversalTime(),
        HasPolls = false,
        HasRecording = false,
        Id = "4763d673-7768-488d-8fd2-c030dc948bcb",
        IsAutoApprove = false,
        IsEnabled = true,
        IsWebcast = false,
        JoinUrl = "https://nutritious-crocodile.com",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Curriculum ducimus assentator aspernatur ait.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 10D,
                EndAt = System.DateTime.Parse("2023-09-02T12:04:58.281Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-02-17T07:00:23.004Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2024-05-01T05:56:18.571Z",
                },
                Interval = 8D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                },
                OnMonthDays = new List<double>() {
                    -10D,
                },
                OnMonths = new List<double>() {
                    -9D,
                },
                OnWeeks = new List<double>() {
                    10D,
                    30D,
                    -38D,
                    30D,
                    -22D,
                    37D,
                    -12D,
                    27D,
                    2D,
                    15D,
                    26D,
                    18D,
                    -43D,
                    -33D,
                    -27D,
                    38D,
                    28D,
                    47D,
                    -8D,
                    24D,
                    35D,
                    -2D,
                    7D,
                    49D,
                    38D,
                    -41D,
                    46D,
                    -11D,
                    -45D,
                    0D,
                    48D,
                    34D,
                },
                OnYearDays = new List<double>() {
                    345D,
                    -207D,
                    230D,
                    -10D,
                    364D,
                    -256D,
                    -218D,
                    -295D,
                    290D,
                    -250D,
                    -315D,
                    60D,
                    205D,
                    -247D,
                    -318D,
                    -211D,
                    -13D,
                    256D,
                    -200D,
                    -313D,
                    336D,
                    -332D,
                    -90D,
                    287D,
                    -273D,
                    156D,
                    241D,
                    -138D,
                    -363D,
                    -37D,
                    -171D,
                    -62D,
                    -57D,
                    280D,
                    -322D,
                    -79D,
                    -364D,
                    -201D,
                    84D,
                    341D,
                    334D,
                    -75D,
                    332D,
                    207D,
                    337D,
                    -244D,
                    131D,
                    -191D,
                    164D,
                    -235D,
                    285D,
                    -309D,
                    -158D,
                    306D,
                    180D,
                    -130D,
                    -162D,
                    -155D,
                    3D,
                    198D,
                    26D,
                    -366D,
                    -191D,
                    127D,
                    -331D,
                    -11D,
                    -239D,
                    -189D,
                    243D,
                    118D,
                    346D,
                    -174D,
                    -146D,
                    -161D,
                    -330D,
                    327D,
                    192D,
                    310D,
                    316D,
                    313D,
                    -242D,
                    -51D,
                    -264D,
                    -180D,
                    -88D,
                    305D,
                    270D,
                    358D,
                    -173D,
                    -298D,
                    153D,
                    -89D,
                    155D,
                    -45D,
                    248D,
                    -46D,
                    -146D,
                    300D,
                    364D,
                    -335D,
                    356D,
                    -18D,
                    219D,
                    324D,
                    -239D,
                    -106D,
                    -298D,
                    328D,
                    362D,
                    344D,
                    -54D,
                    133D,
                    50D,
                    112D,
                    -212D,
                    -179D,
                    22D,
                    -201D,
                    -62D,
                    -293D,
                    9D,
                    30D,
                    -50D,
                    126D,
                    -72D,
                    264D,
                    28D,
                    -1D,
                    -207D,
                    160D,
                    -168D,
                    3D,
                    -176D,
                    -19D,
                    -157D,
                    349D,
                    100D,
                    -201D,
                    108D,
                    -180D,
                    51D,
                    -73D,
                    366D,
                    74D,
                    -226D,
                    238D,
                    121D,
                    -193D,
                    -125D,
                    -109D,
                    316D,
                    -177D,
                    -307D,
                    31D,
                    -76D,
                    217D,
                    -310D,
                    227D,
                    -360D,
                    71D,
                    255D,
                    -325D,
                    -214D,
                    40D,
                    42D,
                    17D,
                    -241D,
                    -84D,
                    -188D,
                    302D,
                    64D,
                    94D,
                    -362D,
                    23D,
                    166D,
                    85D,
                    71D,
                    -74D,
                    -47D,
                    -119D,
                    98D,
                    40D,
                    158D,
                    -64D,
                    175D,
                    269D,
                    127D,
                    -143D,
                    213D,
                    -196D,
                    121D,
                    81D,
                    -238D,
                    288D,
                    321D,
                    276D,
                    133D,
                    22D,
                    -213D,
                    -157D,
                    -280D,
                    -35D,
                    73D,
                    -194D,
                    65D,
                    -180D,
                    63D,
                    -242D,
                    -117D,
                    148D,
                    157D,
                    -320D,
                    318D,
                    8D,
                    210D,
                    -21D,
                    81D,
                    205D,
                    -258D,
                    -40D,
                    -114D,
                    -253D,
                    -263D,
                    65D,
                    185D,
                    -24D,
                    324D,
                    -172D,
                    25D,
                    260D,
                    211D,
                    342D,
                    -31D,
                    -288D,
                    -159D,
                    -4D,
                    -2D,
                    -107D,
                    -316D,
                    -276D,
                    331D,
                    -114D,
                    -20D,
                    -320D,
                    51D,
                    -176D,
                    -148D,
                    -50D,
                    -201D,
                    -104D,
                    153D,
                    -273D,
                    -189D,
                    67D,
                    209D,
                    149D,
                    49D,
                    -136D,
                    -125D,
                    -169D,
                    -324D,
                    309D,
                    -51D,
                    288D,
                    253D,
                    175D,
                    -146D,
                    171D,
                    -140D,
                    58D,
                    -212D,
                    164D,
                    270D,
                    102D,
                    70D,
                    299D,
                    89D,
                    -280D,
                    252D,
                    -342D,
                    240D,
                    226D,
                    68D,
                    -30D,
                    -232D,
                    -358D,
                    -166D,
                    60D,
                    140D,
                    275D,
                    13D,
                    250D,
                    -328D,
                    -189D,
                    -22D,
                    7D,
                    -235D,
                    -322D,
                    178D,
                    167D,
                    -104D,
                    -61D,
                    282D,
                    -80D,
                    -277D,
                    108D,
                    271D,
                    -237D,
                    297D,
                    -135D,
                    -135D,
                    -323D,
                    342D,
                    -267D,
                    -235D,
                    173D,
                    249D,
                    -288D,
                    257D,
                    139D,
                    -191D,
                    -217D,
                    10D,
                    -117D,
                    -297D,
                    -196D,
                    -206D,
                    341D,
                    166D,
                    181D,
                    129D,
                    -207D,
                    55D,
                    86D,
                },
                Timezone = "Africa/Abidjan",
                WeekStart = WeekStart.Mo,
            },
            new CalendarEventRecurrence() {
                Count = 3D,
                EndAt = System.DateTime.Parse("2022-10-01T01:29:36.413Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-09-05T06:51:03.679Z",
                    "2024-08-20T16:12:46.840Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2024-03-27T23:41:11.309Z",
                    "2026-01-19T04:02:15.899Z",
                    "2023-08-16T01:46:54.110Z",
                },
                Interval = 1D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                },
                OnMonthDays = new List<double>() {
                    -15D,
                },
                OnMonths = new List<double>() {
                    5D,
                    12D,
                    3D,
                    12D,
                    8D,
                },
                OnWeeks = new List<double>() {
                    -47D,
                    44D,
                },
                OnYearDays = new List<double>() {
                    -117D,
                    59D,
                    -6D,
                    187D,
                    45D,
                    70D,
                    15D,
                    255D,
                    44D,
                    -2D,
                    25D,
                    -175D,
                    -240D,
                    171D,
                    -294D,
                    19D,
                    38D,
                    -351D,
                    170D,
                    -10D,
                    -269D,
                    18D,
                    -65D,
                    -266D,
                    -31D,
                    328D,
                    -361D,
                    358D,
                    -256D,
                    -4D,
                    -312D,
                    82D,
                    -2D,
                    -75D,
                    -281D,
                    -304D,
                    53D,
                    -295D,
                    366D,
                    322D,
                    -191D,
                    26D,
                    97D,
                    53D,
                    75D,
                    -62D,
                    -109D,
                    66D,
                    177D,
                    -68D,
                    175D,
                    -280D,
                    70D,
                    -238D,
                    109D,
                    -304D,
                    326D,
                    -8D,
                    -71D,
                    -236D,
                    225D,
                    358D,
                    20D,
                    -5D,
                    -102D,
                    -134D,
                    -204D,
                    -116D,
                    -353D,
                    -273D,
                    106D,
                    284D,
                    -137D,
                    -324D,
                    301D,
                    -42D,
                    -229D,
                    271D,
                    -293D,
                    -343D,
                    211D,
                    47D,
                    -254D,
                    -154D,
                    -182D,
                    264D,
                    120D,
                    -11D,
                    -307D,
                    99D,
                    227D,
                    190D,
                    -17D,
                    -77D,
                    -255D,
                    -61D,
                    -249D,
                    -102D,
                    70D,
                    345D,
                    -187D,
                    -308D,
                    194D,
                    221D,
                    268D,
                    -169D,
                    -190D,
                    88D,
                    10D,
                    262D,
                    177D,
                    -314D,
                    -151D,
                    -295D,
                },
                Timezone = "Asia/Choibalsan",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2026-08-02T04:02:57.686Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-06-20T03:48:34.218Z",
                    "2023-06-09T03:28:19.436Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-04-05T01:25:20.533Z",
                    "2023-08-21T21:50:00.254Z",
                    "2024-09-30T14:20:32.660Z",
                },
                Interval = 8D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                },
                OnMonthDays = new List<double>() {
                    -23D,
                },
                OnMonths = new List<double>() {
                    11D,
                    8D,
                    9D,
                    5D,
                    -12D,
                    -7D,
                    -5D,
                    10D,
                    10D,
                    -9D,
                    -10D,
                },
                OnWeeks = new List<double>() {
                    -49D,
                    46D,
                    35D,
                    -26D,
                    2D,
                    15D,
                    15D,
                    -26D,
                    24D,
                    -53D,
                    36D,
                    -43D,
                    51D,
                    -19D,
                    -7D,
                    -12D,
                    28D,
                    27D,
                    35D,
                    12D,
                    -28D,
                    -8D,
                    -4D,
                    -45D,
                },
                OnYearDays = new List<double>() {
                    84D,
                    -251D,
                    71D,
                    181D,
                    -163D,
                    158D,
                    301D,
                    -299D,
                    -184D,
                    -331D,
                    -152D,
                    -129D,
                    -237D,
                    -303D,
                    -24D,
                    126D,
                    -103D,
                    146D,
                    -346D,
                    86D,
                    -296D,
                    -337D,
                    -185D,
                    16D,
                    -270D,
                    -126D,
                    -295D,
                    -231D,
                    356D,
                    -293D,
                    115D,
                    -265D,
                    -293D,
                    -34D,
                    357D,
                    313D,
                    -343D,
                    180D,
                    -22D,
                    -161D,
                    350D,
                    177D,
                    190D,
                    223D,
                    -152D,
                    -360D,
                    -225D,
                    -60D,
                    -35D,
                    353D,
                    117D,
                    -171D,
                    -315D,
                    -321D,
                    -202D,
                    345D,
                    -1D,
                    -148D,
                    -168D,
                    181D,
                    -17D,
                    282D,
                    234D,
                    31D,
                    47D,
                    -236D,
                    366D,
                    -251D,
                    -232D,
                    -308D,
                    76D,
                    -199D,
                    184D,
                    198D,
                    225D,
                    75D,
                    6D,
                    227D,
                    -148D,
                    259D,
                    -146D,
                    49D,
                    -254D,
                    341D,
                    93D,
                    138D,
                    -164D,
                    237D,
                    4D,
                    -287D,
                    161D,
                },
                Timezone = "Asia/Krasnoyarsk",
                WeekStart = WeekStart.We,
            },
        },
        RegistrantPassword = "W7J6DhkM",
        RequireAddress = false,
        RequireJobTitle = false,
        StartAt = System.DateTime.Parse("2025-05-05T04:27:01.879Z").ToUniversalTime(),
        Status = CalendarWebinarStatus.Tentative,
        Subject = "Harum culpa decipio ex cubo ancilla cresco.",
        Timezone = "Europe/Kaliningrad",
        UpdatedAt = System.DateTime.Parse("2026-10-07T10:24:40.884Z").ToUniversalTime(),
        WebUrl = "https://quiet-permafrost.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.PatchCalendarWebinarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchCalendarWebinarRequest](../../Models/Requests/PatchCalendarWebinarRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchCalendarWebinarResponse](../../Models/Requests/PatchCalendarWebinarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCalendarCalendar

Deletes the CalendarCalendar identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCalendarCalendar" method="delete" path="/calendar/{connection_id}/calendar/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.RemoveCalendarCalendarAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Calendar   |

### Response

**[RemoveCalendarCalendarResponse](../../Models/Requests/RemoveCalendarCalendarResponse.md)**

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

var res = await sdk.Calendar.RemoveCalendarEventAsync(
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

## RemoveCalendarLink

Deletes the CalendarLink identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCalendarLink" method="delete" path="/calendar/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.RemoveCalendarLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Link       |

### Response

**[RemoveCalendarLinkResponse](../../Models/Requests/RemoveCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCalendarWebinar

Deletes the CalendarWebinar identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCalendarWebinar" method="delete" path="/calendar/{connection_id}/webinar/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.RemoveCalendarWebinarAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Webinar    |

### Response

**[RemoveCalendarWebinarResponse](../../Models/Requests/RemoveCalendarWebinarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCalendarCalendar

Updates the CalendarCalendar identified by `id`. Provide the unified CalendarCalendar fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarCalendar" method="put" path="/calendar/{connection_id}/calendar/{id}" example="calendar_calendar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarCalendarRequest req = new UpdateCalendarCalendarRequest() {
    CalendarCalendar = new CalendarCalendar() {
        CreatedAt = System.DateTime.Parse("2020-01-09T23:11:34.147Z").ToUniversalTime(),
        Description = "Acer supra vallum suasoria thesaurus.",
        Id = "b08bbf16-40b9-4391-8dad-58223c50abc7",
        IsPrimary = false,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Interviews",
        Timezone = "Asia/Kolkata",
        UpdatedAt = System.DateTime.Parse("2023-03-31T11:17:36.642Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.UpdateCalendarCalendarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateCalendarCalendarRequest](../../Models/Requests/UpdateCalendarCalendarRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateCalendarCalendarResponse](../../Models/Requests/UpdateCalendarCalendarResponse.md)**

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
        EndAt = "2020-05-25T01:48:21.962Z",
        HasConference = false,
        Id = "ed80a083-a82b-4f3a-a578-b05d864148b7",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 4D,
                EndAt = System.DateTime.Parse("2025-03-30T03:24:02.003Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-02-07T03:52:23.233Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Yearly,
                IncludedDates = new List<string>() {
                    "2023-07-10T21:06:09.173Z",
                    "2025-01-29T05:34:02.831Z",
                    "2024-04-06T12:35:13.391Z",
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
        StartAt = "2020-05-24T16:33:16.198Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-07-01T02:32:43.605Z",
        WebUrl = "https://another-pinstripe.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.UpdateCalendarEventAsync(req);

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

## UpdateCalendarLink

Updates the CalendarLink identified by `id`. Provide the unified CalendarLink fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarLink" method="put" path="/calendar/{connection_id}/link/{id}" example="calendar_link" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarLinkRequest req = new UpdateCalendarLinkRequest() {
    CalendarLink = new CalendarLink() {
        CreatedAt = "2023-03-07T13:34:11.959Z",
        Description = "Vitium clibanus laboriosam uxor denuncio.",
        Duration = 74D,
        Id = "baa61f2f-7fce-4c64-be3c-2175316b752e",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-17T12:39:12.944Z",
        Url = "https://annual-apricot.info/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.UpdateCalendarLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateCalendarLinkRequest](../../Models/Requests/UpdateCalendarLinkRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateCalendarLinkResponse](../../Models/Requests/UpdateCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCalendarWebinar

Updates the CalendarWebinar identified by `id`. Provide the unified CalendarWebinar fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarWebinar" method="put" path="/calendar/{connection_id}/webinar/{id}" example="calendar_webinar" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarWebinarRequest req = new UpdateCalendarWebinarRequest() {
    CalendarWebinar = new CalendarWebinar() {
        Conference = new List<CalendarConference>() {},
        CreatedAt = System.DateTime.Parse("2022-07-06T11:45:14.631Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-11-03T03:28:24.233Z").ToUniversalTime(),
        HasPolls = false,
        HasRecording = false,
        Id = "4763d673-7768-488d-8fd2-c030dc948bcb",
        IsAutoApprove = false,
        IsEnabled = true,
        IsWebcast = false,
        JoinUrl = "https://nutritious-crocodile.com",
        Metadata = new List<CalendarMetadata>() {},
        Notes = "Curriculum ducimus assentator aspernatur ait.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 10D,
                EndAt = System.DateTime.Parse("2023-09-02T12:04:58.281Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-02-17T07:00:23.004Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2024-05-01T05:56:18.571Z",
                },
                Interval = 8D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                },
                OnMonthDays = new List<double>() {
                    -10D,
                },
                OnMonths = new List<double>() {
                    -9D,
                },
                OnWeeks = new List<double>() {
                    10D,
                    30D,
                    -38D,
                    30D,
                    -22D,
                    37D,
                    -12D,
                    27D,
                    2D,
                    15D,
                    26D,
                    18D,
                    -43D,
                    -33D,
                    -27D,
                    38D,
                    28D,
                    47D,
                    -8D,
                    24D,
                    35D,
                    -2D,
                    7D,
                    49D,
                    38D,
                    -41D,
                    46D,
                    -11D,
                    -45D,
                    0D,
                    48D,
                    34D,
                },
                OnYearDays = new List<double>() {
                    345D,
                    -207D,
                    230D,
                    -10D,
                    364D,
                    -256D,
                    -218D,
                    -295D,
                    290D,
                    -250D,
                    -315D,
                    60D,
                    205D,
                    -247D,
                    -318D,
                    -211D,
                    -13D,
                    256D,
                    -200D,
                    -313D,
                    336D,
                    -332D,
                    -90D,
                    287D,
                    -273D,
                    156D,
                    241D,
                    -138D,
                    -363D,
                    -37D,
                    -171D,
                    -62D,
                    -57D,
                    280D,
                    -322D,
                    -79D,
                    -364D,
                    -201D,
                    84D,
                    341D,
                    334D,
                    -75D,
                    332D,
                    207D,
                    337D,
                    -244D,
                    131D,
                    -191D,
                    164D,
                    -235D,
                    285D,
                    -309D,
                    -158D,
                    306D,
                    180D,
                    -130D,
                    -162D,
                    -155D,
                    3D,
                    198D,
                    26D,
                    -366D,
                    -191D,
                    127D,
                    -331D,
                    -11D,
                    -239D,
                    -189D,
                    243D,
                    118D,
                    346D,
                    -174D,
                    -146D,
                    -161D,
                    -330D,
                    327D,
                    192D,
                    310D,
                    316D,
                    313D,
                    -242D,
                    -51D,
                    -264D,
                    -180D,
                    -88D,
                    305D,
                    270D,
                    358D,
                    -173D,
                    -298D,
                    153D,
                    -89D,
                    155D,
                    -45D,
                    248D,
                    -46D,
                    -146D,
                    300D,
                    364D,
                    -335D,
                    356D,
                    -18D,
                    219D,
                    324D,
                    -239D,
                    -106D,
                    -298D,
                    328D,
                    362D,
                    344D,
                    -54D,
                    133D,
                    50D,
                    112D,
                    -212D,
                    -179D,
                    22D,
                    -201D,
                    -62D,
                    -293D,
                    9D,
                    30D,
                    -50D,
                    126D,
                    -72D,
                    264D,
                    28D,
                    -1D,
                    -207D,
                    160D,
                    -168D,
                    3D,
                    -176D,
                    -19D,
                    -157D,
                    349D,
                    100D,
                    -201D,
                    108D,
                    -180D,
                    51D,
                    -73D,
                    366D,
                    74D,
                    -226D,
                    238D,
                    121D,
                    -193D,
                    -125D,
                    -109D,
                    316D,
                    -177D,
                    -307D,
                    31D,
                    -76D,
                    217D,
                    -310D,
                    227D,
                    -360D,
                    71D,
                    255D,
                    -325D,
                    -214D,
                    40D,
                    42D,
                    17D,
                    -241D,
                    -84D,
                    -188D,
                    302D,
                    64D,
                    94D,
                    -362D,
                    23D,
                    166D,
                    85D,
                    71D,
                    -74D,
                    -47D,
                    -119D,
                    98D,
                    40D,
                    158D,
                    -64D,
                    175D,
                    269D,
                    127D,
                    -143D,
                    213D,
                    -196D,
                    121D,
                    81D,
                    -238D,
                    288D,
                    321D,
                    276D,
                    133D,
                    22D,
                    -213D,
                    -157D,
                    -280D,
                    -35D,
                    73D,
                    -194D,
                    65D,
                    -180D,
                    63D,
                    -242D,
                    -117D,
                    148D,
                    157D,
                    -320D,
                    318D,
                    8D,
                    210D,
                    -21D,
                    81D,
                    205D,
                    -258D,
                    -40D,
                    -114D,
                    -253D,
                    -263D,
                    65D,
                    185D,
                    -24D,
                    324D,
                    -172D,
                    25D,
                    260D,
                    211D,
                    342D,
                    -31D,
                    -288D,
                    -159D,
                    -4D,
                    -2D,
                    -107D,
                    -316D,
                    -276D,
                    331D,
                    -114D,
                    -20D,
                    -320D,
                    51D,
                    -176D,
                    -148D,
                    -50D,
                    -201D,
                    -104D,
                    153D,
                    -273D,
                    -189D,
                    67D,
                    209D,
                    149D,
                    49D,
                    -136D,
                    -125D,
                    -169D,
                    -324D,
                    309D,
                    -51D,
                    288D,
                    253D,
                    175D,
                    -146D,
                    171D,
                    -140D,
                    58D,
                    -212D,
                    164D,
                    270D,
                    102D,
                    70D,
                    299D,
                    89D,
                    -280D,
                    252D,
                    -342D,
                    240D,
                    226D,
                    68D,
                    -30D,
                    -232D,
                    -358D,
                    -166D,
                    60D,
                    140D,
                    275D,
                    13D,
                    250D,
                    -328D,
                    -189D,
                    -22D,
                    7D,
                    -235D,
                    -322D,
                    178D,
                    167D,
                    -104D,
                    -61D,
                    282D,
                    -80D,
                    -277D,
                    108D,
                    271D,
                    -237D,
                    297D,
                    -135D,
                    -135D,
                    -323D,
                    342D,
                    -267D,
                    -235D,
                    173D,
                    249D,
                    -288D,
                    257D,
                    139D,
                    -191D,
                    -217D,
                    10D,
                    -117D,
                    -297D,
                    -196D,
                    -206D,
                    341D,
                    166D,
                    181D,
                    129D,
                    -207D,
                    55D,
                    86D,
                },
                Timezone = "Africa/Abidjan",
                WeekStart = WeekStart.Mo,
            },
            new CalendarEventRecurrence() {
                Count = 3D,
                EndAt = System.DateTime.Parse("2022-10-01T01:29:36.413Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-09-05T06:51:03.679Z",
                    "2024-08-20T16:12:46.840Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2024-03-27T23:41:11.309Z",
                    "2026-01-19T04:02:15.899Z",
                    "2023-08-16T01:46:54.110Z",
                },
                Interval = 1D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                },
                OnMonthDays = new List<double>() {
                    -15D,
                },
                OnMonths = new List<double>() {
                    5D,
                    12D,
                    3D,
                    12D,
                    8D,
                },
                OnWeeks = new List<double>() {
                    -47D,
                    44D,
                },
                OnYearDays = new List<double>() {
                    -117D,
                    59D,
                    -6D,
                    187D,
                    45D,
                    70D,
                    15D,
                    255D,
                    44D,
                    -2D,
                    25D,
                    -175D,
                    -240D,
                    171D,
                    -294D,
                    19D,
                    38D,
                    -351D,
                    170D,
                    -10D,
                    -269D,
                    18D,
                    -65D,
                    -266D,
                    -31D,
                    328D,
                    -361D,
                    358D,
                    -256D,
                    -4D,
                    -312D,
                    82D,
                    -2D,
                    -75D,
                    -281D,
                    -304D,
                    53D,
                    -295D,
                    366D,
                    322D,
                    -191D,
                    26D,
                    97D,
                    53D,
                    75D,
                    -62D,
                    -109D,
                    66D,
                    177D,
                    -68D,
                    175D,
                    -280D,
                    70D,
                    -238D,
                    109D,
                    -304D,
                    326D,
                    -8D,
                    -71D,
                    -236D,
                    225D,
                    358D,
                    20D,
                    -5D,
                    -102D,
                    -134D,
                    -204D,
                    -116D,
                    -353D,
                    -273D,
                    106D,
                    284D,
                    -137D,
                    -324D,
                    301D,
                    -42D,
                    -229D,
                    271D,
                    -293D,
                    -343D,
                    211D,
                    47D,
                    -254D,
                    -154D,
                    -182D,
                    264D,
                    120D,
                    -11D,
                    -307D,
                    99D,
                    227D,
                    190D,
                    -17D,
                    -77D,
                    -255D,
                    -61D,
                    -249D,
                    -102D,
                    70D,
                    345D,
                    -187D,
                    -308D,
                    194D,
                    221D,
                    268D,
                    -169D,
                    -190D,
                    88D,
                    10D,
                    262D,
                    177D,
                    -314D,
                    -151D,
                    -295D,
                },
                Timezone = "Asia/Choibalsan",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2026-08-02T04:02:57.686Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-06-20T03:48:34.218Z",
                    "2023-06-09T03:28:19.436Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-04-05T01:25:20.533Z",
                    "2023-08-21T21:50:00.254Z",
                    "2024-09-30T14:20:32.660Z",
                },
                Interval = 8D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Su,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Fr,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                },
                OnMonthDays = new List<double>() {
                    -23D,
                },
                OnMonths = new List<double>() {
                    11D,
                    8D,
                    9D,
                    5D,
                    -12D,
                    -7D,
                    -5D,
                    10D,
                    10D,
                    -9D,
                    -10D,
                },
                OnWeeks = new List<double>() {
                    -49D,
                    46D,
                    35D,
                    -26D,
                    2D,
                    15D,
                    15D,
                    -26D,
                    24D,
                    -53D,
                    36D,
                    -43D,
                    51D,
                    -19D,
                    -7D,
                    -12D,
                    28D,
                    27D,
                    35D,
                    12D,
                    -28D,
                    -8D,
                    -4D,
                    -45D,
                },
                OnYearDays = new List<double>() {
                    84D,
                    -251D,
                    71D,
                    181D,
                    -163D,
                    158D,
                    301D,
                    -299D,
                    -184D,
                    -331D,
                    -152D,
                    -129D,
                    -237D,
                    -303D,
                    -24D,
                    126D,
                    -103D,
                    146D,
                    -346D,
                    86D,
                    -296D,
                    -337D,
                    -185D,
                    16D,
                    -270D,
                    -126D,
                    -295D,
                    -231D,
                    356D,
                    -293D,
                    115D,
                    -265D,
                    -293D,
                    -34D,
                    357D,
                    313D,
                    -343D,
                    180D,
                    -22D,
                    -161D,
                    350D,
                    177D,
                    190D,
                    223D,
                    -152D,
                    -360D,
                    -225D,
                    -60D,
                    -35D,
                    353D,
                    117D,
                    -171D,
                    -315D,
                    -321D,
                    -202D,
                    345D,
                    -1D,
                    -148D,
                    -168D,
                    181D,
                    -17D,
                    282D,
                    234D,
                    31D,
                    47D,
                    -236D,
                    366D,
                    -251D,
                    -232D,
                    -308D,
                    76D,
                    -199D,
                    184D,
                    198D,
                    225D,
                    75D,
                    6D,
                    227D,
                    -148D,
                    259D,
                    -146D,
                    49D,
                    -254D,
                    341D,
                    93D,
                    138D,
                    -164D,
                    237D,
                    4D,
                    -287D,
                    161D,
                },
                Timezone = "Asia/Krasnoyarsk",
                WeekStart = WeekStart.We,
            },
        },
        RegistrantPassword = "W7J6DhkM",
        RequireAddress = false,
        RequireJobTitle = false,
        StartAt = System.DateTime.Parse("2025-05-05T04:27:01.879Z").ToUniversalTime(),
        Status = CalendarWebinarStatus.Tentative,
        Subject = "Harum culpa decipio ex cubo ancilla cresco.",
        Timezone = "Europe/Kaliningrad",
        UpdatedAt = System.DateTime.Parse("2026-10-07T10:24:40.884Z").ToUniversalTime(),
        WebUrl = "https://quiet-permafrost.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Calendar.UpdateCalendarWebinarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateCalendarWebinarRequest](../../Models/Requests/UpdateCalendarWebinarRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateCalendarWebinarResponse](../../Models/Requests/UpdateCalendarWebinarResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |