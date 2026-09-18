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
* [GetCalendarRecording](#getcalendarrecording) - Retrieve a recording
* [GetCalendarWebinar](#getcalendarwebinar) - Retrieve a webinar
* [ListCalendarBusies](#listcalendarbusies) - List all busies
* [ListCalendarCalendars](#listcalendarcalendars) - List all calendars
* [ListCalendarEvents](#listcalendarevents) - List all events
* [ListCalendarLinks](#listcalendarlinks) - List all links
* [ListCalendarRecordings](#listcalendarrecordings) - List all recordings
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

Create a calendar

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarCalendar" method="post" path="/calendar/{connection_id}/calendar" example="calendar_calendar" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Calendar.CreateCalendarCalendarAsync(
    calendarCalendar: new CalendarCalendar() {
        CreatedAt = System.DateTime.Parse("2020-01-09T23:11:34.147Z").ToUniversalTime(),
        Description = "Socius catena auxilium.",
        Id = "8da7640a-4bac-41a5-b416-7df2bb90e3ad",
        IsPrimary = false,
        Name = "Acer supra vallum suasoria thesaurus omnis condico cognomen accendo vehemens.",
        Timezone = "America/Dawson_Creek",
        UpdatedAt = System.DateTime.Parse("2023-03-12T12:09:26.347Z").ToUniversalTime(),
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

Create an event

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
        EndAt = "2020-05-20T14:43:09.217Z",
        Id = "b29abc0a-b7f1-41c1-822c-51120a83b026",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2025-12-25T10:31:27.175Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-09-30T03:23:46.574Z",
                    "2023-10-08T23:07:17.101Z",
                    "2024-02-14T23:07:11.050Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2021-02-16T17:14:18.564Z",
                },
                Interval = 4D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                },
                OnMonthDays = new List<double>() {
                    -26D,
                },
                OnMonths = new List<double>() {
                    12D,
                    9D,
                    -1D,
                    0D,
                    1D,
                    6D,
                    -10D,
                    9D,
                    0D,
                    4D,
                    -2D,
                },
                OnWeeks = new List<double>() {
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
                },
                OnYearDays = new List<double>() {
                    -35D,
                    14D,
                    -338D,
                    175D,
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
                },
                Timezone = "Asia/Ho_Chi_Minh",
                WeekStart = WeekStart.Su,
            },
            new CalendarEventRecurrence() {
                Count = 9D,
                EndAt = System.DateTime.Parse("2025-04-29T11:52:53.213Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2020-04-28T22:25:03.237Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2020-09-10T23:06:23.703Z",
                    "2021-11-28T18:11:14.189Z",
                    "2019-12-22T16:53:52.903Z",
                },
                Interval = 1D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    1D,
                },
                OnMonths = new List<double>() {
                    4D,
                    0D,
                    -3D,
                },
                OnWeeks = new List<double>() {
                    -7D,
                    -19D,
                    50D,
                    -37D,
                    43D,
                    -48D,
                    -30D,
                    34D,
                    36D,
                    -33D,
                    24D,
                    -4D,
                },
                OnYearDays = new List<double>() {
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
                    -35D,
                    -121D,
                    262D,
                    32D,
                    190D,
                    107D,
                    -145D,
                    91D,
                    313D,
                    -48D,
                    277D,
                    104D,
                    342D,
                    297D,
                    -216D,
                    346D,
                    -257D,
                    307D,
                    -44D,
                    264D,
                    -153D,
                    -268D,
                    92D,
                    152D,
                    -182D,
                    -334D,
                    89D,
                    343D,
                    -320D,
                    -36D,
                    84D,
                    340D,
                    -88D,
                    -278D,
                    202D,
                    291D,
                    95D,
                    -234D,
                    -304D,
                    -157D,
                    -82D,
                    -339D,
                    83D,
                    2D,
                    -238D,
                    -204D,
                    206D,
                    -273D,
                    -78D,
                    -21D,
                    270D,
                    -266D,
                    -276D,
                    154D,
                    -97D,
                    -43D,
                    -3D,
                    191D,
                    -302D,
                    290D,
                    -118D,
                    -125D,
                    -294D,
                    115D,
                    -73D,
                    -244D,
                    127D,
                    26D,
                    251D,
                    47D,
                    -157D,
                    22D,
                    -361D,
                    318D,
                    352D,
                    358D,
                    167D,
                    210D,
                    -185D,
                    327D,
                    117D,
                    350D,
                    -170D,
                    -144D,
                    -14D,
                    -37D,
                    318D,
                    243D,
                    33D,
                    90D,
                    319D,
                    -270D,
                    229D,
                    122D,
                    287D,
                    -90D,
                    -69D,
                    -134D,
                    -184D,
                    25D,
                    -178D,
                    -89D,
                    -273D,
                    -49D,
                    -362D,
                    -9D,
                    -71D,
                    -347D,
                    353D,
                    342D,
                    133D,
                    -116D,
                    231D,
                    -231D,
                    51D,
                    288D,
                    186D,
                    -328D,
                    275D,
                    81D,
                    94D,
                    -263D,
                    114D,
                    13D,
                    -357D,
                    171D,
                    -242D,
                    -85D,
                    -362D,
                    108D,
                    164D,
                    69D,
                    15D,
                    57D,
                    -287D,
                    100D,
                    165D,
                    205D,
                    204D,
                    -78D,
                    360D,
                    -80D,
                    -120D,
                    -255D,
                    -77D,
                    110D,
                    -26D,
                    -149D,
                    -254D,
                    95D,
                    32D,
                    -57D,
                    -195D,
                    100D,
                    221D,
                    74D,
                    274D,
                    15D,
                    353D,
                    204D,
                    -365D,
                    315D,
                    344D,
                    199D,
                    -59D,
                    272D,
                    173D,
                    -40D,
                    -318D,
                    -330D,
                    -365D,
                    -272D,
                    -149D,
                    -27D,
                    -334D,
                    -277D,
                    344D,
                    351D,
                    -310D,
                    264D,
                    281D,
                    176D,
                    191D,
                    -183D,
                    288D,
                    -112D,
                    -55D,
                    -166D,
                    258D,
                    194D,
                    59D,
                },
                Timezone = "America/Guadeloupe",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 1D,
                EndAt = System.DateTime.Parse("2020-11-04T13:57:53.150Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-01-11T10:47:19.279Z",
                    "2021-09-07T06:47:33.698Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-08-30T19:03:32.348Z",
                },
                Interval = 9D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    -2D,
                },
                OnMonths = new List<double>() {
                    -4D,
                    8D,
                    0D,
                    9D,
                    4D,
                    -11D,
                    7D,
                    1D,
                    -5D,
                },
                OnWeeks = new List<double>() {
                    -36D,
                    -31D,
                    -16D,
                    -6D,
                    44D,
                    -37D,
                    14D,
                    38D,
                    -27D,
                    -22D,
                    -2D,
                    24D,
                    7D,
                    50D,
                    46D,
                    52D,
                    20D,
                    37D,
                    31D,
                    48D,
                    35D,
                    -46D,
                    13D,
                    22D,
                    53D,
                    20D,
                    -28D,
                    -2D,
                    39D,
                    13D,
                    4D,
                    0D,
                    7D,
                    -38D,
                    -35D,
                    41D,
                    49D,
                    12D,
                    17D,
                    8D,
                    49D,
                    -47D,
                    46D,
                    25D,
                    14D,
                    -26D,
                    -37D,
                    -25D,
                    -41D,
                    27D,
                    28D,
                    -19D,
                },
                OnYearDays = new List<double>() {
                    -256D,
                    -328D,
                    -312D,
                    50D,
                    -251D,
                    -338D,
                    -315D,
                    214D,
                    129D,
                    -263D,
                    -108D,
                    -11D,
                    206D,
                    -29D,
                    -159D,
                    -29D,
                    -264D,
                    295D,
                    -231D,
                    53D,
                    34D,
                    -366D,
                    326D,
                    -202D,
                    151D,
                    79D,
                    -66D,
                    11D,
                    -42D,
                    73D,
                    338D,
                    -155D,
                    197D,
                    260D,
                    356D,
                    -323D,
                    -213D,
                    -332D,
                    -305D,
                    -182D,
                    -253D,
                    -276D,
                    -285D,
                    96D,
                    -336D,
                    269D,
                    -233D,
                    250D,
                    -112D,
                    -307D,
                    -96D,
                    54D,
                    267D,
                    318D,
                    -66D,
                    11D,
                    -303D,
                    231D,
                    165D,
                    -297D,
                    -348D,
                    -355D,
                    364D,
                    312D,
                    -26D,
                    111D,
                    162D,
                    280D,
                    312D,
                    337D,
                    235D,
                    68D,
                    -282D,
                    363D,
                    212D,
                    -328D,
                    9D,
                    -24D,
                    -163D,
                    -101D,
                    -79D,
                    -264D,
                    -157D,
                    188D,
                    290D,
                    51D,
                    -213D,
                    216D,
                    230D,
                    -270D,
                    -211D,
                    -156D,
                    -165D,
                    -305D,
                    -45D,
                    224D,
                    -248D,
                    65D,
                    9D,
                    274D,
                    -299D,
                    -228D,
                    33D,
                    -42D,
                    356D,
                    -311D,
                    241D,
                    261D,
                    -136D,
                    -252D,
                    166D,
                    208D,
                    -126D,
                    64D,
                    323D,
                    -104D,
                    -106D,
                    -248D,
                    -41D,
                    -109D,
                    245D,
                    47D,
                    205D,
                    358D,
                    -296D,
                    214D,
                    -157D,
                    -313D,
                    -303D,
                    -54D,
                    -229D,
                    231D,
                    -94D,
                    -198D,
                    338D,
                    199D,
                    5D,
                    42D,
                    309D,
                    73D,
                    56D,
                    -120D,
                    351D,
                    6D,
                    -193D,
                    21D,
                    78D,
                    57D,
                    -269D,
                    -76D,
                    -299D,
                    295D,
                    -278D,
                    11D,
                    121D,
                    -323D,
                    156D,
                    67D,
                    152D,
                    284D,
                    108D,
                    -7D,
                    329D,
                    -32D,
                    333D,
                    -338D,
                    148D,
                    -42D,
                    151D,
                    145D,
                    -34D,
                    -36D,
                    296D,
                    -198D,
                    -317D,
                    -161D,
                    -253D,
                    328D,
                    -57D,
                    134D,
                    -289D,
                    229D,
                    44D,
                    16D,
                    -256D,
                    289D,
                    -234D,
                    197D,
                    333D,
                    228D,
                    -143D,
                    -202D,
                    -172D,
                    -262D,
                    -203D,
                    -83D,
                    -242D,
                    -173D,
                    336D,
                    298D,
                    -319D,
                    66D,
                    254D,
                    214D,
                    -118D,
                    -216D,
                    -168D,
                    44D,
                    -243D,
                    207D,
                    -28D,
                    -4D,
                    -272D,
                    79D,
                },
                Timezone = "Atlantic/Reykjavik",
                WeekStart = WeekStart.Tu,
            },
        },
        RecurringEventId = "fce1cdc1-9034-4021-af8d-a5ce3079a860",
        SendNotifications = false,
        StartAt = "2020-05-20T05:36:28.121Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-06-26T01:59:30.793Z",
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

Create a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarLink" method="post" path="/calendar/{connection_id}/link" example="calendar_link" -->
```csharp
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
        Id = "47ed2366-68b3-49ca-bd9b-2dcf05eb2965",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-06T05:12:36.154Z",
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

Create a webinar

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
        EndAt = System.DateTime.Parse("2025-10-03T05:49:51.521Z").ToUniversalTime(),
        HasPolls = false,
        HasRecording = false,
        Id = "c792c6a7-1449-4f10-a71f-0f5edcc168a0",
        IsAutoApprove = false,
        IsEnabled = true,
        IsWebcast = false,
        JoinUrl = "https://robust-bathhouse.biz",
        Notes = "Curriculum ducimus assentator aspernatur ait.",
        Organizer = new PropertyCalendarWebinarOrganizer() {
            Email = "Kelton_Dicki@yahoo.com",
            Name = "Walter Greenfelder",
        },
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 10D,
                EndAt = System.DateTime.Parse("2023-08-22T18:00:43.837Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-01-23T23:17:02.226Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2024-04-14T08:23:07.840Z",
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
                Timezone = "Asia/Ust-Nera",
                WeekStart = WeekStart.Mo,
            },
            new CalendarEventRecurrence() {
                Count = 3D,
                EndAt = System.DateTime.Parse("2022-09-28T20:40:39.446Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-08-16T03:47:42.507Z",
                    "2024-07-31T22:40:49.340Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2024-03-11T23:02:06.061Z",
                    "2025-12-17T07:24:18.363Z",
                    "2023-08-05T18:20:39.016Z",
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
                Timezone = "Pacific/Wake",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2026-06-25T08:27:05.448Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-06-11T07:05:41.236Z",
                    "2023-05-31T13:28:36.359Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-03-19T19:50:46.230Z",
                    "2023-08-11T10:50:08.824Z",
                    "2024-09-09T19:50:39.063Z",
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
                Timezone = "Africa/Bissau",
                WeekStart = WeekStart.We,
            },
        },
        RegistrantPassword = "OxwWzr0C",
        RequireAddress = false,
        RequireJobTitle = false,
        StartAt = System.DateTime.Parse("2025-04-08T21:49:01.812Z").ToUniversalTime(),
        Status = CalendarWebinarStatus.Tentative,
        Subject = "Harum culpa decipio ex cubo ancilla cresco.",
        Timezone = "Europe/Kaliningrad",
        UpdatedAt = System.DateTime.Parse("2026-08-28T22:23:12.295Z").ToUniversalTime(),
        WebUrl = "https://classic-recovery.biz",
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

Retrieve a calendar

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

Retrieve an event

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

Retrieve a link

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

## GetCalendarRecording

Retrieve a recording

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

## GetCalendarWebinar

Retrieve a webinar

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

List all busies

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

List all calendars

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

List all links

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

## ListCalendarRecordings

List all recordings

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

## ListCalendarWebinars

List all webinars

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

Update a calendar

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarCalendar" method="patch" path="/calendar/{connection_id}/calendar/{id}" example="calendar_calendar" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarCalendarRequest req = new PatchCalendarCalendarRequest() {
    CalendarCalendar = new CalendarCalendar() {
        CreatedAt = System.DateTime.Parse("2020-01-09T23:11:34.147Z").ToUniversalTime(),
        Description = "Socius catena auxilium.",
        Id = "faad3860-d656-460f-bff9-34a175df1da3",
        IsPrimary = false,
        Name = "Acer supra vallum suasoria thesaurus omnis condico cognomen accendo vehemens.",
        Timezone = "America/Dawson_Creek",
        UpdatedAt = System.DateTime.Parse("2023-03-12T12:09:26.350Z").ToUniversalTime(),
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

Update an event

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
        EndAt = "2020-05-20T14:43:09.220Z",
        Id = "793d9c3d-e03c-46a1-9b51-f3dc255713ac",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2025-12-25T10:31:27.201Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-09-30T03:23:46.599Z",
                    "2023-10-08T23:07:17.118Z",
                    "2024-02-14T23:07:11.069Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2021-02-16T17:14:18.571Z",
                },
                Interval = 4D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                },
                OnMonthDays = new List<double>() {
                    -26D,
                },
                OnMonths = new List<double>() {
                    12D,
                    9D,
                    -1D,
                    0D,
                    1D,
                    6D,
                    -10D,
                    9D,
                    0D,
                    4D,
                    -2D,
                },
                OnWeeks = new List<double>() {
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
                },
                OnYearDays = new List<double>() {
                    -35D,
                    14D,
                    -338D,
                    175D,
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
                },
                Timezone = "Asia/Ho_Chi_Minh",
                WeekStart = WeekStart.Su,
            },
            new CalendarEventRecurrence() {
                Count = 9D,
                EndAt = System.DateTime.Parse("2025-04-29T11:52:53.237Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2020-04-28T22:25:03.240Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2020-09-10T23:06:23.707Z",
                    "2021-11-28T18:11:14.199Z",
                    "2019-12-22T16:53:52.904Z",
                },
                Interval = 1D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    1D,
                },
                OnMonths = new List<double>() {
                    4D,
                    0D,
                    -3D,
                },
                OnWeeks = new List<double>() {
                    -7D,
                    -19D,
                    50D,
                    -37D,
                    43D,
                    -48D,
                    -30D,
                    34D,
                    36D,
                    -33D,
                    24D,
                    -4D,
                },
                OnYearDays = new List<double>() {
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
                    -35D,
                    -121D,
                    262D,
                    32D,
                    190D,
                    107D,
                    -145D,
                    91D,
                    313D,
                    -48D,
                    277D,
                    104D,
                    342D,
                    297D,
                    -216D,
                    346D,
                    -257D,
                    307D,
                    -44D,
                    264D,
                    -153D,
                    -268D,
                    92D,
                    152D,
                    -182D,
                    -334D,
                    89D,
                    343D,
                    -320D,
                    -36D,
                    84D,
                    340D,
                    -88D,
                    -278D,
                    202D,
                    291D,
                    95D,
                    -234D,
                    -304D,
                    -157D,
                    -82D,
                    -339D,
                    83D,
                    2D,
                    -238D,
                    -204D,
                    206D,
                    -273D,
                    -78D,
                    -21D,
                    270D,
                    -266D,
                    -276D,
                    154D,
                    -97D,
                    -43D,
                    -3D,
                    191D,
                    -302D,
                    290D,
                    -118D,
                    -125D,
                    -294D,
                    115D,
                    -73D,
                    -244D,
                    127D,
                    26D,
                    251D,
                    47D,
                    -157D,
                    22D,
                    -361D,
                    318D,
                    352D,
                    358D,
                    167D,
                    210D,
                    -185D,
                    327D,
                    117D,
                    350D,
                    -170D,
                    -144D,
                    -14D,
                    -37D,
                    318D,
                    243D,
                    33D,
                    90D,
                    319D,
                    -270D,
                    229D,
                    122D,
                    287D,
                    -90D,
                    -69D,
                    -134D,
                    -184D,
                    25D,
                    -178D,
                    -89D,
                    -273D,
                    -49D,
                    -362D,
                    -9D,
                    -71D,
                    -347D,
                    353D,
                    342D,
                    133D,
                    -116D,
                    231D,
                    -231D,
                    51D,
                    288D,
                    186D,
                    -328D,
                    275D,
                    81D,
                    94D,
                    -263D,
                    114D,
                    13D,
                    -357D,
                    171D,
                    -242D,
                    -85D,
                    -362D,
                    108D,
                    164D,
                    69D,
                    15D,
                    57D,
                    -287D,
                    100D,
                    165D,
                    205D,
                    204D,
                    -78D,
                    360D,
                    -80D,
                    -120D,
                    -255D,
                    -77D,
                    110D,
                    -26D,
                    -149D,
                    -254D,
                    95D,
                    32D,
                    -57D,
                    -195D,
                    100D,
                    221D,
                    74D,
                    274D,
                    15D,
                    353D,
                    204D,
                    -365D,
                    315D,
                    344D,
                    199D,
                    -59D,
                    272D,
                    173D,
                    -40D,
                    -318D,
                    -330D,
                    -365D,
                    -272D,
                    -149D,
                    -27D,
                    -334D,
                    -277D,
                    344D,
                    351D,
                    -310D,
                    264D,
                    281D,
                    176D,
                    191D,
                    -183D,
                    288D,
                    -112D,
                    -55D,
                    -166D,
                    258D,
                    194D,
                    59D,
                },
                Timezone = "America/Guadeloupe",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 1D,
                EndAt = System.DateTime.Parse("2020-11-04T13:57:53.155Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-01-11T10:47:19.293Z",
                    "2021-09-07T06:47:33.707Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-08-30T19:03:32.369Z",
                },
                Interval = 9D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    -2D,
                },
                OnMonths = new List<double>() {
                    -4D,
                    8D,
                    0D,
                    9D,
                    4D,
                    -11D,
                    7D,
                    1D,
                    -5D,
                },
                OnWeeks = new List<double>() {
                    -36D,
                    -31D,
                    -16D,
                    -6D,
                    44D,
                    -37D,
                    14D,
                    38D,
                    -27D,
                    -22D,
                    -2D,
                    24D,
                    7D,
                    50D,
                    46D,
                    52D,
                    20D,
                    37D,
                    31D,
                    48D,
                    35D,
                    -46D,
                    13D,
                    22D,
                    53D,
                    20D,
                    -28D,
                    -2D,
                    39D,
                    13D,
                    4D,
                    0D,
                    7D,
                    -38D,
                    -35D,
                    41D,
                    49D,
                    12D,
                    17D,
                    8D,
                    49D,
                    -47D,
                    46D,
                    25D,
                    14D,
                    -26D,
                    -37D,
                    -25D,
                    -41D,
                    27D,
                    28D,
                    -19D,
                },
                OnYearDays = new List<double>() {
                    -256D,
                    -328D,
                    -312D,
                    50D,
                    -251D,
                    -338D,
                    -315D,
                    214D,
                    129D,
                    -263D,
                    -108D,
                    -11D,
                    206D,
                    -29D,
                    -159D,
                    -29D,
                    -264D,
                    295D,
                    -231D,
                    53D,
                    34D,
                    -366D,
                    326D,
                    -202D,
                    151D,
                    79D,
                    -66D,
                    11D,
                    -42D,
                    73D,
                    338D,
                    -155D,
                    197D,
                    260D,
                    356D,
                    -323D,
                    -213D,
                    -332D,
                    -305D,
                    -182D,
                    -253D,
                    -276D,
                    -285D,
                    96D,
                    -336D,
                    269D,
                    -233D,
                    250D,
                    -112D,
                    -307D,
                    -96D,
                    54D,
                    267D,
                    318D,
                    -66D,
                    11D,
                    -303D,
                    231D,
                    165D,
                    -297D,
                    -348D,
                    -355D,
                    364D,
                    312D,
                    -26D,
                    111D,
                    162D,
                    280D,
                    312D,
                    337D,
                    235D,
                    68D,
                    -282D,
                    363D,
                    212D,
                    -328D,
                    9D,
                    -24D,
                    -163D,
                    -101D,
                    -79D,
                    -264D,
                    -157D,
                    188D,
                    290D,
                    51D,
                    -213D,
                    216D,
                    230D,
                    -270D,
                    -211D,
                    -156D,
                    -165D,
                    -305D,
                    -45D,
                    224D,
                    -248D,
                    65D,
                    9D,
                    274D,
                    -299D,
                    -228D,
                    33D,
                    -42D,
                    356D,
                    -311D,
                    241D,
                    261D,
                    -136D,
                    -252D,
                    166D,
                    208D,
                    -126D,
                    64D,
                    323D,
                    -104D,
                    -106D,
                    -248D,
                    -41D,
                    -109D,
                    245D,
                    47D,
                    205D,
                    358D,
                    -296D,
                    214D,
                    -157D,
                    -313D,
                    -303D,
                    -54D,
                    -229D,
                    231D,
                    -94D,
                    -198D,
                    338D,
                    199D,
                    5D,
                    42D,
                    309D,
                    73D,
                    56D,
                    -120D,
                    351D,
                    6D,
                    -193D,
                    21D,
                    78D,
                    57D,
                    -269D,
                    -76D,
                    -299D,
                    295D,
                    -278D,
                    11D,
                    121D,
                    -323D,
                    156D,
                    67D,
                    152D,
                    284D,
                    108D,
                    -7D,
                    329D,
                    -32D,
                    333D,
                    -338D,
                    148D,
                    -42D,
                    151D,
                    145D,
                    -34D,
                    -36D,
                    296D,
                    -198D,
                    -317D,
                    -161D,
                    -253D,
                    328D,
                    -57D,
                    134D,
                    -289D,
                    229D,
                    44D,
                    16D,
                    -256D,
                    289D,
                    -234D,
                    197D,
                    333D,
                    228D,
                    -143D,
                    -202D,
                    -172D,
                    -262D,
                    -203D,
                    -83D,
                    -242D,
                    -173D,
                    336D,
                    298D,
                    -319D,
                    66D,
                    254D,
                    214D,
                    -118D,
                    -216D,
                    -168D,
                    44D,
                    -243D,
                    207D,
                    -28D,
                    -4D,
                    -272D,
                    79D,
                },
                Timezone = "Atlantic/Reykjavik",
                WeekStart = WeekStart.Tu,
            },
        },
        RecurringEventId = "6b8656fb-cf1f-40a5-b627-0da8fd959995",
        SendNotifications = false,
        StartAt = "2020-05-20T05:36:28.124Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-06-26T01:59:30.797Z",
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

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarLink" method="patch" path="/calendar/{connection_id}/link/{id}" example="calendar_link" -->
```csharp
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
        Id = "c3d15abd-61d3-47f1-afba-077bd7c28cb5",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-06T05:12:36.156Z",
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

Update a webinar

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
        EndAt = System.DateTime.Parse("2025-10-03T05:49:51.559Z").ToUniversalTime(),
        HasPolls = false,
        HasRecording = false,
        Id = "fa0c43f3-d5cc-4ab7-a219-e6b1583dd5d0",
        IsAutoApprove = false,
        IsEnabled = true,
        IsWebcast = false,
        JoinUrl = "https://robust-bathhouse.biz",
        Notes = "Curriculum ducimus assentator aspernatur ait.",
        Organizer = new PropertyCalendarWebinarOrganizer() {
            Email = "Kelton_Dicki@yahoo.com",
            Name = "Walter Greenfelder",
        },
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 10D,
                EndAt = System.DateTime.Parse("2023-08-22T18:00:43.850Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-01-23T23:17:02.256Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2024-04-14T08:23:07.860Z",
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
                Timezone = "Asia/Ust-Nera",
                WeekStart = WeekStart.Mo,
            },
            new CalendarEventRecurrence() {
                Count = 3D,
                EndAt = System.DateTime.Parse("2022-09-28T20:40:39.448Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-08-16T03:47:42.531Z",
                    "2024-07-31T22:40:49.363Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2024-03-11T23:02:06.081Z",
                    "2025-12-17T07:24:18.402Z",
                    "2023-08-05T18:20:39.029Z",
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
                Timezone = "Pacific/Wake",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2026-06-25T08:27:05.493Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-06-11T07:05:41.247Z",
                    "2023-05-31T13:28:36.370Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-03-19T19:50:46.250Z",
                    "2023-08-11T10:50:08.837Z",
                    "2024-09-09T19:50:39.088Z",
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
                Timezone = "Africa/Bissau",
                WeekStart = WeekStart.We,
            },
        },
        RegistrantPassword = "OxwWzr0C",
        RequireAddress = false,
        RequireJobTitle = false,
        StartAt = System.DateTime.Parse("2025-04-08T21:49:01.844Z").ToUniversalTime(),
        Status = CalendarWebinarStatus.Tentative,
        Subject = "Harum culpa decipio ex cubo ancilla cresco.",
        Timezone = "Europe/Kaliningrad",
        UpdatedAt = System.DateTime.Parse("2026-08-28T22:23:12.342Z").ToUniversalTime(),
        WebUrl = "https://classic-recovery.biz",
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

Remove a calendar

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

Remove an event

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

Remove a link

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

Remove a webinar

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

Update a calendar

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarCalendar" method="put" path="/calendar/{connection_id}/calendar/{id}" example="calendar_calendar" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarCalendarRequest req = new UpdateCalendarCalendarRequest() {
    CalendarCalendar = new CalendarCalendar() {
        CreatedAt = System.DateTime.Parse("2020-01-09T23:11:34.147Z").ToUniversalTime(),
        Description = "Socius catena auxilium.",
        Id = "faad3860-d656-460f-bff9-34a175df1da3",
        IsPrimary = false,
        Name = "Acer supra vallum suasoria thesaurus omnis condico cognomen accendo vehemens.",
        Timezone = "America/Dawson_Creek",
        UpdatedAt = System.DateTime.Parse("2023-03-12T12:09:26.350Z").ToUniversalTime(),
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

Update an event

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
        EndAt = "2020-05-20T14:43:09.220Z",
        Id = "793d9c3d-e03c-46a1-9b51-f3dc255713ac",
        IsAllDay = false,
        IsFree = false,
        IsPrivate = false,
        Location = "621 Boehm Prairie",
        Notes = "Aegre traho.",
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2025-12-25T10:31:27.201Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-09-30T03:23:46.599Z",
                    "2023-10-08T23:07:17.118Z",
                    "2024-02-14T23:07:11.069Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2021-02-16T17:14:18.571Z",
                },
                Interval = 4D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Th,
                    PropertyCalendarEventRecurrenceOnDays.Mo,
                    PropertyCalendarEventRecurrenceOnDays.Th,
                },
                OnMonthDays = new List<double>() {
                    -26D,
                },
                OnMonths = new List<double>() {
                    12D,
                    9D,
                    -1D,
                    0D,
                    1D,
                    6D,
                    -10D,
                    9D,
                    0D,
                    4D,
                    -2D,
                },
                OnWeeks = new List<double>() {
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
                },
                OnYearDays = new List<double>() {
                    -35D,
                    14D,
                    -338D,
                    175D,
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
                },
                Timezone = "Asia/Ho_Chi_Minh",
                WeekStart = WeekStart.Su,
            },
            new CalendarEventRecurrence() {
                Count = 9D,
                EndAt = System.DateTime.Parse("2025-04-29T11:52:53.237Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2020-04-28T22:25:03.240Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2020-09-10T23:06:23.707Z",
                    "2021-11-28T18:11:14.199Z",
                    "2019-12-22T16:53:52.904Z",
                },
                Interval = 1D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.We,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    1D,
                },
                OnMonths = new List<double>() {
                    4D,
                    0D,
                    -3D,
                },
                OnWeeks = new List<double>() {
                    -7D,
                    -19D,
                    50D,
                    -37D,
                    43D,
                    -48D,
                    -30D,
                    34D,
                    36D,
                    -33D,
                    24D,
                    -4D,
                },
                OnYearDays = new List<double>() {
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
                    -35D,
                    -121D,
                    262D,
                    32D,
                    190D,
                    107D,
                    -145D,
                    91D,
                    313D,
                    -48D,
                    277D,
                    104D,
                    342D,
                    297D,
                    -216D,
                    346D,
                    -257D,
                    307D,
                    -44D,
                    264D,
                    -153D,
                    -268D,
                    92D,
                    152D,
                    -182D,
                    -334D,
                    89D,
                    343D,
                    -320D,
                    -36D,
                    84D,
                    340D,
                    -88D,
                    -278D,
                    202D,
                    291D,
                    95D,
                    -234D,
                    -304D,
                    -157D,
                    -82D,
                    -339D,
                    83D,
                    2D,
                    -238D,
                    -204D,
                    206D,
                    -273D,
                    -78D,
                    -21D,
                    270D,
                    -266D,
                    -276D,
                    154D,
                    -97D,
                    -43D,
                    -3D,
                    191D,
                    -302D,
                    290D,
                    -118D,
                    -125D,
                    -294D,
                    115D,
                    -73D,
                    -244D,
                    127D,
                    26D,
                    251D,
                    47D,
                    -157D,
                    22D,
                    -361D,
                    318D,
                    352D,
                    358D,
                    167D,
                    210D,
                    -185D,
                    327D,
                    117D,
                    350D,
                    -170D,
                    -144D,
                    -14D,
                    -37D,
                    318D,
                    243D,
                    33D,
                    90D,
                    319D,
                    -270D,
                    229D,
                    122D,
                    287D,
                    -90D,
                    -69D,
                    -134D,
                    -184D,
                    25D,
                    -178D,
                    -89D,
                    -273D,
                    -49D,
                    -362D,
                    -9D,
                    -71D,
                    -347D,
                    353D,
                    342D,
                    133D,
                    -116D,
                    231D,
                    -231D,
                    51D,
                    288D,
                    186D,
                    -328D,
                    275D,
                    81D,
                    94D,
                    -263D,
                    114D,
                    13D,
                    -357D,
                    171D,
                    -242D,
                    -85D,
                    -362D,
                    108D,
                    164D,
                    69D,
                    15D,
                    57D,
                    -287D,
                    100D,
                    165D,
                    205D,
                    204D,
                    -78D,
                    360D,
                    -80D,
                    -120D,
                    -255D,
                    -77D,
                    110D,
                    -26D,
                    -149D,
                    -254D,
                    95D,
                    32D,
                    -57D,
                    -195D,
                    100D,
                    221D,
                    74D,
                    274D,
                    15D,
                    353D,
                    204D,
                    -365D,
                    315D,
                    344D,
                    199D,
                    -59D,
                    272D,
                    173D,
                    -40D,
                    -318D,
                    -330D,
                    -365D,
                    -272D,
                    -149D,
                    -27D,
                    -334D,
                    -277D,
                    344D,
                    351D,
                    -310D,
                    264D,
                    281D,
                    176D,
                    191D,
                    -183D,
                    288D,
                    -112D,
                    -55D,
                    -166D,
                    258D,
                    194D,
                    59D,
                },
                Timezone = "America/Guadeloupe",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 1D,
                EndAt = System.DateTime.Parse("2020-11-04T13:57:53.155Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-01-11T10:47:19.293Z",
                    "2021-09-07T06:47:33.707Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-08-30T19:03:32.369Z",
                },
                Interval = 9D,
                OnDays = new List<PropertyCalendarEventRecurrenceOnDays>() {
                    PropertyCalendarEventRecurrenceOnDays.Tu,
                    PropertyCalendarEventRecurrenceOnDays.Sa,
                },
                OnMonthDays = new List<double>() {
                    -2D,
                },
                OnMonths = new List<double>() {
                    -4D,
                    8D,
                    0D,
                    9D,
                    4D,
                    -11D,
                    7D,
                    1D,
                    -5D,
                },
                OnWeeks = new List<double>() {
                    -36D,
                    -31D,
                    -16D,
                    -6D,
                    44D,
                    -37D,
                    14D,
                    38D,
                    -27D,
                    -22D,
                    -2D,
                    24D,
                    7D,
                    50D,
                    46D,
                    52D,
                    20D,
                    37D,
                    31D,
                    48D,
                    35D,
                    -46D,
                    13D,
                    22D,
                    53D,
                    20D,
                    -28D,
                    -2D,
                    39D,
                    13D,
                    4D,
                    0D,
                    7D,
                    -38D,
                    -35D,
                    41D,
                    49D,
                    12D,
                    17D,
                    8D,
                    49D,
                    -47D,
                    46D,
                    25D,
                    14D,
                    -26D,
                    -37D,
                    -25D,
                    -41D,
                    27D,
                    28D,
                    -19D,
                },
                OnYearDays = new List<double>() {
                    -256D,
                    -328D,
                    -312D,
                    50D,
                    -251D,
                    -338D,
                    -315D,
                    214D,
                    129D,
                    -263D,
                    -108D,
                    -11D,
                    206D,
                    -29D,
                    -159D,
                    -29D,
                    -264D,
                    295D,
                    -231D,
                    53D,
                    34D,
                    -366D,
                    326D,
                    -202D,
                    151D,
                    79D,
                    -66D,
                    11D,
                    -42D,
                    73D,
                    338D,
                    -155D,
                    197D,
                    260D,
                    356D,
                    -323D,
                    -213D,
                    -332D,
                    -305D,
                    -182D,
                    -253D,
                    -276D,
                    -285D,
                    96D,
                    -336D,
                    269D,
                    -233D,
                    250D,
                    -112D,
                    -307D,
                    -96D,
                    54D,
                    267D,
                    318D,
                    -66D,
                    11D,
                    -303D,
                    231D,
                    165D,
                    -297D,
                    -348D,
                    -355D,
                    364D,
                    312D,
                    -26D,
                    111D,
                    162D,
                    280D,
                    312D,
                    337D,
                    235D,
                    68D,
                    -282D,
                    363D,
                    212D,
                    -328D,
                    9D,
                    -24D,
                    -163D,
                    -101D,
                    -79D,
                    -264D,
                    -157D,
                    188D,
                    290D,
                    51D,
                    -213D,
                    216D,
                    230D,
                    -270D,
                    -211D,
                    -156D,
                    -165D,
                    -305D,
                    -45D,
                    224D,
                    -248D,
                    65D,
                    9D,
                    274D,
                    -299D,
                    -228D,
                    33D,
                    -42D,
                    356D,
                    -311D,
                    241D,
                    261D,
                    -136D,
                    -252D,
                    166D,
                    208D,
                    -126D,
                    64D,
                    323D,
                    -104D,
                    -106D,
                    -248D,
                    -41D,
                    -109D,
                    245D,
                    47D,
                    205D,
                    358D,
                    -296D,
                    214D,
                    -157D,
                    -313D,
                    -303D,
                    -54D,
                    -229D,
                    231D,
                    -94D,
                    -198D,
                    338D,
                    199D,
                    5D,
                    42D,
                    309D,
                    73D,
                    56D,
                    -120D,
                    351D,
                    6D,
                    -193D,
                    21D,
                    78D,
                    57D,
                    -269D,
                    -76D,
                    -299D,
                    295D,
                    -278D,
                    11D,
                    121D,
                    -323D,
                    156D,
                    67D,
                    152D,
                    284D,
                    108D,
                    -7D,
                    329D,
                    -32D,
                    333D,
                    -338D,
                    148D,
                    -42D,
                    151D,
                    145D,
                    -34D,
                    -36D,
                    296D,
                    -198D,
                    -317D,
                    -161D,
                    -253D,
                    328D,
                    -57D,
                    134D,
                    -289D,
                    229D,
                    44D,
                    16D,
                    -256D,
                    289D,
                    -234D,
                    197D,
                    333D,
                    228D,
                    -143D,
                    -202D,
                    -172D,
                    -262D,
                    -203D,
                    -83D,
                    -242D,
                    -173D,
                    336D,
                    298D,
                    -319D,
                    66D,
                    254D,
                    214D,
                    -118D,
                    -216D,
                    -168D,
                    44D,
                    -243D,
                    207D,
                    -28D,
                    -4D,
                    -272D,
                    79D,
                },
                Timezone = "Atlantic/Reykjavik",
                WeekStart = WeekStart.Tu,
            },
        },
        RecurringEventId = "6b8656fb-cf1f-40a5-b627-0da8fd959995",
        SendNotifications = false,
        StartAt = "2020-05-20T05:36:28.124Z",
        Status = CalendarEventStatus.Confirmed,
        Subject = "Sunt spargo tepidus bestia vigor credo coadunatio appello.",
        Timezone = "Asia/Bangkok",
        UpdatedAt = "2020-06-26T01:59:30.797Z",
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

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarLink" method="put" path="/calendar/{connection_id}/link/{id}" example="calendar_link" -->
```csharp
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
        Id = "c3d15abd-61d3-47f1-afba-077bd7c28cb5",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-06T05:12:36.156Z",
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

Update a webinar

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
        EndAt = System.DateTime.Parse("2025-10-03T05:49:51.559Z").ToUniversalTime(),
        HasPolls = false,
        HasRecording = false,
        Id = "fa0c43f3-d5cc-4ab7-a219-e6b1583dd5d0",
        IsAutoApprove = false,
        IsEnabled = true,
        IsWebcast = false,
        JoinUrl = "https://robust-bathhouse.biz",
        Notes = "Curriculum ducimus assentator aspernatur ait.",
        Organizer = new PropertyCalendarWebinarOrganizer() {
            Email = "Kelton_Dicki@yahoo.com",
            Name = "Walter Greenfelder",
        },
        Recurrence = new List<CalendarEventRecurrence>() {
            new CalendarEventRecurrence() {
                Count = 10D,
                EndAt = System.DateTime.Parse("2023-08-22T18:00:43.850Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2025-01-23T23:17:02.256Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Monthly,
                IncludedDates = new List<string>() {
                    "2024-04-14T08:23:07.860Z",
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
                Timezone = "Asia/Ust-Nera",
                WeekStart = WeekStart.Mo,
            },
            new CalendarEventRecurrence() {
                Count = 3D,
                EndAt = System.DateTime.Parse("2022-09-28T20:40:39.448Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2024-08-16T03:47:42.531Z",
                    "2024-07-31T22:40:49.363Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Daily,
                IncludedDates = new List<string>() {
                    "2024-03-11T23:02:06.081Z",
                    "2025-12-17T07:24:18.402Z",
                    "2023-08-05T18:20:39.029Z",
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
                Timezone = "Pacific/Wake",
                WeekStart = WeekStart.Tu,
            },
            new CalendarEventRecurrence() {
                Count = 8D,
                EndAt = System.DateTime.Parse("2026-06-25T08:27:05.493Z").ToUniversalTime(),
                ExcludedDates = new List<string>() {
                    "2023-06-11T07:05:41.247Z",
                    "2023-05-31T13:28:36.370Z",
                },
                Frequency = CalendarEventRecurrenceFrequency.Weekly,
                IncludedDates = new List<string>() {
                    "2024-03-19T19:50:46.250Z",
                    "2023-08-11T10:50:08.837Z",
                    "2024-09-09T19:50:39.088Z",
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
                Timezone = "Africa/Bissau",
                WeekStart = WeekStart.We,
            },
        },
        RegistrantPassword = "OxwWzr0C",
        RequireAddress = false,
        RequireJobTitle = false,
        StartAt = System.DateTime.Parse("2025-04-08T21:49:01.844Z").ToUniversalTime(),
        Status = CalendarWebinarStatus.Tentative,
        Subject = "Harum culpa decipio ex cubo ancilla cresco.",
        Timezone = "Europe/Kaliningrad",
        UpdatedAt = System.DateTime.Parse("2026-08-28T22:23:12.342Z").ToUniversalTime(),
        WebUrl = "https://classic-recovery.biz",
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