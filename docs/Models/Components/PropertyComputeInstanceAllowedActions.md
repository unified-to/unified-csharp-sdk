# PropertyComputeInstanceAllowedActions

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PropertyComputeInstanceAllowedActions.Start;

// Open enum: use .Of() to create instances from custom string values
var custom = PropertyComputeInstanceAllowedActions.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Start`     | START       |
| `Stop`      | STOP        |
| `Restart`   | RESTART     |
| `Pause`     | PAUSE       |
| `Resume`    | RESUME      |
| `Terminate` | TERMINATE   |