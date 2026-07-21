# AccountingOrderType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingOrderType.Sales;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingOrderType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Sales`    | SALES      |
| `Purchase` | PURCHASE   |