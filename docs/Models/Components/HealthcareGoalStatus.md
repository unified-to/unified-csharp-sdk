# HealthcareGoalStatus

Lifecycle status of the goal

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareGoalStatus.Proposed;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareGoalStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Proposed`       | PROPOSED         |
| `Planned`        | PLANNED          |
| `Accepted`       | ACCEPTED         |
| `Active`         | ACTIVE           |
| `OnHold`         | ON_HOLD          |
| `Completed`      | COMPLETED        |
| `Cancelled`      | CANCELLED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Rejected`       | REJECTED         |
| `Other`          | OTHER            |