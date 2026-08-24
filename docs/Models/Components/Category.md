# Category

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Category.Standard;

// Open enum: use .Of() to create instances from custom string values
var custom = Category.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Standard`   | STANDARD     |
| `DateDriven` | DATE_DRIVEN  |
| `Other`      | OTHER        |