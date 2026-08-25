# Period

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Period.Day;

// Open enum: use .Of() to create instances from custom string values
var custom = Period.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Day`      | DAY        |
| `Week`     | WEEK       |
| `Month`    | MONTH      |
| `Lifetime` | LIFETIME   |
| `Total`    | TOTAL      |
| `Other`    | OTHER      |