# AtsActivityType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsActivityType.Note;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsActivityType.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Note`  | NOTE    |
| `Task`  | TASK    |
| `Email` | EMAIL   |