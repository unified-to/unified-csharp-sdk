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

Create an event

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
        Id = "2b637adf-8f0f-4471-bb62-420f1a3df3ff",
        Metadata = new Dictionary<string, PropertyAnalyticsEventMetadata>() {
            { "key", new PropertyAnalyticsEventMetadata() {} },
        },
        Name = "Xk707ttsb51v",
        UpdatedAt = System.DateTime.Parse("2023-09-22T02:14:32.504Z").ToUniversalTime(),
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

var res = await sdk.Event.CreateCalendarEventAsync(
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

## CreateCdpEvent

Create an event

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

Create an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmEvent" method="post" path="/crm/{connection_id}/event" example="crm_event" -->
```csharp
using System;
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
            StartAt = System.DateTime.Parse("2024-11-17T19:36:18.647Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "bc6b1939-6879-4e6a-a90b-2a4f3acae555",
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-09-08T16:08:26.484Z").ToUniversalTime(),
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

## GetCdpEvent

Retrieve an event

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

## ListCdpEvents

List all events

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

Update an event

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

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmEvent" method="patch" path="/crm/{connection_id}/event/{id}" example="crm_event" -->
```csharp
using System;
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
            StartAt = System.DateTime.Parse("2024-11-17T19:36:18.679Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "17e150e0-763c-4553-8b13-2eb74d8d88fb",
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-09-08T16:08:26.529Z").ToUniversalTime(),
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

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingEvent" method="patch" path="/messaging/{connection_id}/event/{id}" example="messaging_event" -->
```csharp
using System;
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
        Id = "edcbbf0d-0281-47f1-a49d-9cf2a55c7d48",
        IsReplacingOriginal = false,
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

## RemoveCdpEvent

Remove an event

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

Update an event

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

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmEvent" method="put" path="/crm/{connection_id}/event/{id}" example="crm_event" -->
```csharp
using System;
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
            StartAt = System.DateTime.Parse("2024-11-17T19:36:18.679Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "17e150e0-763c-4553-8b13-2eb74d8d88fb",
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-09-08T16:08:26.529Z").ToUniversalTime(),
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

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingEvent" method="put" path="/messaging/{connection_id}/event/{id}" example="messaging_event" -->
```csharp
using System;
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
        Id = "edcbbf0d-0281-47f1-a49d-9cf2a55c7d48",
        IsReplacingOriginal = false,
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