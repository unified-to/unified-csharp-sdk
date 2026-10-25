# HealthcareCareplanStatus

Status of the care plan

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareCareplanStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareCareplanStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Draft`          | DRAFT            |
| `Active`         | ACTIVE           |
| `OnHold`         | ON_HOLD          |
| `Revoked`        | REVOKED          |
| `Completed`      | COMPLETED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Unknown`        | UNKNOWN          |
| `Other`          | OTHER            |