# BudgetUnit

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = BudgetUnit.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = BudgetUnit.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Unspecified` | UNSPECIFIED   |
| `Currency`    | CURRENCY      |
| `Impressions` | IMPRESSIONS   |