# HealthcareReportType

Category of the report

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareReportType.Laboratory;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareReportType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Laboratory` | LABORATORY   |
| `Imaging`    | IMAGING      |
| `Pathology`  | PATHOLOGY    |
| `Cardiology` | CARDIOLOGY   |
| `Other`      | OTHER        |