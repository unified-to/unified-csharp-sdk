# BudgetAllocationType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = BudgetAllocationType.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = BudgetAllocationType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Unspecified` | UNSPECIFIED   |
| `Automatic`   | AUTOMATIC     |
| `Fixed`       | FIXED         |
| `Unlimited`   | UNLIMITED     |