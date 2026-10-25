# HealthcareProcedureStatus

Status of the procedure

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareProcedureStatus.Preparation;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareProcedureStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Preparation`    | PREPARATION      |
| `InProgress`     | IN_PROGRESS      |
| `NotDone`        | NOT_DONE         |
| `OnHold`         | ON_HOLD          |
| `Stopped`        | STOPPED          |
| `Completed`      | COMPLETED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Unknown`        | UNKNOWN          |
| `Other`          | OTHER            |