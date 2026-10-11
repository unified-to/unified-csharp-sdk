# HrisPayslipType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisPayslipType.Regular;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisPayslipType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Regular`     | REGULAR       |
| `OffCycle`    | OFF_CYCLE     |
| `Bonus`       | BONUS         |
| `Correction`  | CORRECTION    |
| `Termination` | TERMINATION   |
| `Contractor`  | CONTRACTOR    |