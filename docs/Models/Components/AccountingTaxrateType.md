# AccountingTaxrateType

Whether the rate applies to sales, purchases, or both

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingTaxrateType.Sales;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingTaxrateType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Sales`    | SALES      |
| `Purchase` | PURCHASE   |
| `Both`     | BOTH       |
| `Other`    | OTHER      |