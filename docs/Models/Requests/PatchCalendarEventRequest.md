# PatchCalendarEventRequest


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `CalendarEvent`                                           | [CalendarEvent](../../Models/Components/CalendarEvent.md) | :heavy_check_mark:                                        | N/A                                                       |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `Id`                                                      | *string*                                                  | :heavy_check_mark:                                        | ID of the Event                                           |
| `Fields`                                                  | List<*string*>                                            | :heavy_minus_sign:                                        | Comma-delimited fields to return                          |