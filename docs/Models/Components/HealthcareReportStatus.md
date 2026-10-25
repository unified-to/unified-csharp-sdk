# HealthcareReportStatus

Status of the report

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareReportStatus.Registered;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareReportStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Registered`     | REGISTERED       |
| `Partial`        | PARTIAL          |
| `Preliminary`    | PRELIMINARY      |
| `Final`          | FINAL            |
| `Amended`        | AMENDED          |
| `Corrected`      | CORRECTED        |
| `Appended`       | APPENDED         |
| `Cancelled`      | CANCELLED        |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Unknown`        | UNKNOWN          |
| `Other`          | OTHER            |