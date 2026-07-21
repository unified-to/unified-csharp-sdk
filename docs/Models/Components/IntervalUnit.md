# IntervalUnit

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = IntervalUnit.Year;

// Open enum: use .Of() to create instances from custom string values
var custom = IntervalUnit.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Year`  | YEAR    |
| `Month` | MONTH   |
| `Week`  | WEEK    |
| `Day`   | DAY     |