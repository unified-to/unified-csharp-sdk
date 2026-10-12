# HealthcareImmunizationStatus

Status of the immunization

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareImmunizationStatus.Completed;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareImmunizationStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Completed`      | COMPLETED        |
| `NotDone`        | NOT_DONE         |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Other`          | OTHER            |