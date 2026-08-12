# HrisBenefitFrequency

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisBenefitFrequency.OneTime;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisBenefitFrequency.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `OneTime` | ONE_TIME  |
| `Day`     | DAY       |
| `Quarter` | QUARTER   |
| `Year`    | YEAR      |
| `Hour`    | HOUR      |
| `Month`   | MONTH     |
| `Week`    | WEEK      |