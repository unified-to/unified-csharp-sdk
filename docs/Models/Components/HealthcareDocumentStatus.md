# HealthcareDocumentStatus

Status of the document

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareDocumentStatus.Current;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareDocumentStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Current`        | CURRENT          |
| `Superseded`     | SUPERSEDED       |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Other`          | OTHER            |