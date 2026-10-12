# HealthcareConditionType

Category of the condition

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareConditionType.Problem;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareConditionType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Problem`       | PROBLEM         |
| `Diagnosis`     | DIAGNOSIS       |
| `HealthConcern` | HEALTH_CONCERN  |
| `Other`         | OTHER           |