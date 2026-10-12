# Interpretation

Interpretation of the result (e.g. high, low)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Interpretation.Normal;

// Open enum: use .Of() to create instances from custom string values
var custom = Interpretation.Of("custom_value");
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