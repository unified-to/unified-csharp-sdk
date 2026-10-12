# HealthcareObservationStatus

Status of the observation result

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareObservationStatus.Registered;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareObservationStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Registered`     | REGISTERED       |
| `Preliminary`    | PRELIMINARY      |
| `Final`          | FINAL            |
| `Amended`        | AMENDED          |
| `Corrected`      | CORRECTED        |
| `Cancelled`      | CANCELLED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Unknown`        | UNKNOWN          |
| `Other`          | OTHER            |