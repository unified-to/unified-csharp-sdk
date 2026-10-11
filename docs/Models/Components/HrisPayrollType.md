# HrisPayrollType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisPayrollType.Regular;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisPayrollType.Of("custom_value");
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