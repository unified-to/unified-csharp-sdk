# HealthcareSlotStatus

Availability of the slot

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareSlotStatus.Free;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareSlotStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Free`            | FREE              |
| `Busy`            | BUSY              |
| `BusyUnavailable` | BUSY_UNAVAILABLE  |
| `BusyTentative`   | BUSY_TENTATIVE    |
| `EnteredInError`  | ENTERED_IN_ERROR  |
| `Other`           | OTHER             |