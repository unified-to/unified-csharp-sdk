# OnIdle

What happens when the instance is idle

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = OnIdle.Terminate;

// Open enum: use .Of() to create instances from custom string values
var custom = OnIdle.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Terminate` | TERMINATE   |
| `Pause`     | PAUSE       |
| `Stop`      | STOP        |
| `Other`     | OTHER       |