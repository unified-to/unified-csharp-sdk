# HealthcareConditionStatus

Clinical status of the condition

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareConditionStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareConditionStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Active`     | ACTIVE       |
| `Recurrence` | RECURRENCE   |
| `Relapse`    | RELAPSE      |
| `Inactive`   | INACTIVE     |
| `Remission`  | REMISSION    |
| `Resolved`   | RESOLVED     |
| `Other`      | OTHER        |