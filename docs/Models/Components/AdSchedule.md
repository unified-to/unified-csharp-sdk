# AdSchedule


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `BidModifier`                                     | *double*                                          | :heavy_minus_sign:                                | 0.1-10.0                                          |
| `DayOfWeek`                                       | [DayOfWeek](../../Models/Components/DayOfWeek.md) | :heavy_check_mark:                                | N/A                                               |
| `EndHour`                                         | *double*                                          | :heavy_check_mark:                                | 0-24 (24 = end of day)                            |
| `EndMinute`                                       | *double*                                          | :heavy_minus_sign:                                | 0, 15, 30, 45                                     |
| `StartHour`                                       | *double*                                          | :heavy_check_mark:                                | 0-23                                              |
| `StartMinute`                                     | *double*                                          | :heavy_minus_sign:                                | 0, 15, 30, 45                                     |