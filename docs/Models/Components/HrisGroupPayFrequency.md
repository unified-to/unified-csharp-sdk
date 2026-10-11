# HrisGroupPayFrequency

pay cycle when type is PAY_GROUP

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisGroupPayFrequency.OneTime;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisGroupPayFrequency.Of("custom_value");
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