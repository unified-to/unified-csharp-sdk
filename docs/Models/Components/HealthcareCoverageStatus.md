# HealthcareCoverageStatus

Status of the coverage

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareCoverageStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareCoverageStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Active`         | ACTIVE           |
| `Cancelled`      | CANCELLED        |
| `Draft`          | DRAFT            |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Other`          | OTHER            |