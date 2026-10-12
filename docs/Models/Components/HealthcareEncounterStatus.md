# HealthcareEncounterStatus

Status of the encounter

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareEncounterStatus.Planned;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareEncounterStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Planned`        | PLANNED          |
| `Arrived`        | ARRIVED          |
| `Triaged`        | TRIAGED          |
| `InProgress`     | IN_PROGRESS      |
| `Onleave`        | ONLEAVE          |
| `Finished`       | FINISHED         |
| `Cancelled`      | CANCELLED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Unknown`        | UNKNOWN          |
| `Other`          | OTHER            |