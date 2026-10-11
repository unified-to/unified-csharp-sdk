# PayFrequency

how often the employee is paid (eg. BIWEEKLY)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PayFrequency.OneTime;

// Open enum: use .Of() to create instances from custom string values
var custom = PayFrequency.Of("custom_value");
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