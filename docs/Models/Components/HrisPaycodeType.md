# HrisPaycodeType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisPaycodeType.Earning;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisPaycodeType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Earning`       | EARNING         |
| `Deduction`     | DEDUCTION       |
| `Tax`           | TAX             |
| `Contribution`  | CONTRIBUTION    |
| `Reimbursement` | REIMBURSEMENT   |