# BudgetPeriod

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = BudgetPeriod.Daily;

// Open enum: use .Of() to create instances from custom string values
var custom = BudgetPeriod.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Daily`    | DAILY      |
| `Monthly`  | MONTHLY    |
| `Total`    | TOTAL      |
| `Lifetime` | LIFETIME   |