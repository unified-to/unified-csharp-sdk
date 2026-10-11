# HrisEarningFrequency

ONE_TIME for a single addition to the next unprocessed pay run, otherwise recurring

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisEarningFrequency.OneTime;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisEarningFrequency.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `OneTime`     | ONE_TIME      |
| `Day`         | DAY           |
| `Quarter`     | QUARTER       |
| `Year`        | YEAR          |
| `Hour`        | HOUR          |
| `Month`       | MONTH         |
| `Week`        | WEEK          |
| `Biweekly`    | BIWEEKLY      |
| `Semimonthly` | SEMIMONTHLY   |