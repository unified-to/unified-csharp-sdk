# AccountingCategoryType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingCategoryType.Class;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingCategoryType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Class`      | CLASS        |
| `Department` | DEPARTMENT   |
| `Location`   | LOCATION     |
| `Project`    | PROJECT      |
| `Task`       | TASK         |
| `Custom`     | CUSTOM       |
| `Expense`    | EXPENSE      |
| `Income`     | INCOME       |