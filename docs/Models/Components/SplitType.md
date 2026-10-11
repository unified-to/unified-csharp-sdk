# SplitType

how net pay is split into this account when an employee has several accounts

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SplitType.Percentage;

// Open enum: use .Of() to create instances from custom string values
var custom = SplitType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Percentage` | PERCENTAGE   |
| `Fixed`      | FIXED        |
| `Remainder`  | REMAINDER    |