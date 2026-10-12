# ComputeInstanceType

The kind of compute unit

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeInstanceType.Container;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeInstanceType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Container` | CONTAINER   |
| `Vm`        | VM          |
| `Baremetal` | BAREMETAL   |
| `Sandbox`   | SANDBOX     |
| `Other`     | OTHER       |