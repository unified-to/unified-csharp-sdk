# Dimension

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Dimension.Date;

// Open enum: use .Of() to create instances from custom string values
var custom = Dimension.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Date`        | DATE          |
| `Hour`        | HOUR          |
| `DayOfWeek`   | DAY_OF_WEEK   |
| `Week`        | WEEK          |
| `Month`       | MONTH         |
| `Year`        | YEAR          |
| `Page`        | PAGE          |
| `PageTitle`   | PAGE_TITLE    |
| `EventName`   | EVENT_NAME    |
| `Source`      | SOURCE        |
| `Medium`      | MEDIUM        |
| `Campaign`    | CAMPAIGN      |
| `Country`     | COUNTRY       |
| `City`        | CITY          |
| `DeviceType`  | DEVICE_TYPE   |
| `Browser`     | BROWSER       |
| `Os`          | OS            |
| `UserType`    | USER_TYPE     |
| `LandingPage` | LANDING_PAGE  |
| `Video`       | VIDEO         |