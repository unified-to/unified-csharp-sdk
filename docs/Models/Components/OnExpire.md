# OnExpire

What happens when the instance expires

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = OnExpire.Terminate;

// Open enum: use .Of() to create instances from custom string values
var custom = OnExpire.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Terminate` | TERMINATE   |
| `Pause`     | PAUSE       |
| `Stop`      | STOP        |
| `Other`     | OTHER       |