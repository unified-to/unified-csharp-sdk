# LegalExpenseType

hard cost, soft cost or other

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = LegalExpenseType.HardCost;

// Open enum: use .Of() to create instances from custom string values
var custom = LegalExpenseType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `HardCost` | HARD_COST  |
| `SoftCost` | SOFT_COST  |
| `Other`    | OTHER      |