# FlsaStatus

US Fair Labor Standards Act classification

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = FlsaStatus.Exempt;

// Open enum: use .Of() to create instances from custom string values
var custom = FlsaStatus.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Exempt`            | EXEMPT              |
| `NonExempt`         | NON_EXEMPT          |
| `SalariedNonexempt` | SALARIED_NONEXEMPT  |
| `Owner`             | OWNER               |