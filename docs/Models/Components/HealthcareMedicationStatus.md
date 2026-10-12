# HealthcareMedicationStatus

Status of the medication order

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareMedicationStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareMedicationStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Draft`          | DRAFT            |
| `Active`         | ACTIVE           |
| `OnHold`         | ON_HOLD          |
| `Completed`      | COMPLETED        |
| `Stopped`        | STOPPED          |
| `Cancelled`      | CANCELLED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Unknown`        | UNKNOWN          |
| `Other`          | OTHER            |