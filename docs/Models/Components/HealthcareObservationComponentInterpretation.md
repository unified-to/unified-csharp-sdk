# HealthcareObservationComponentInterpretation

Interpretation of the component value

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareObservationComponentInterpretation.Normal;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareObservationComponentInterpretation.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Normal`       | NORMAL         |
| `Abnormal`     | ABNORMAL       |
| `Low`          | LOW            |
| `High`         | HIGH           |
| `CriticalLow`  | CRITICAL_LOW   |
| `CriticalHigh` | CRITICAL_HIGH  |
| `Other`        | OTHER          |