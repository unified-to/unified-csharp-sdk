# ComputeKeyType

The kind of credential

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeKeyType.Ssh;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeKeyType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Ssh`      | SSH        |
| `Registry` | REGISTRY   |
| `Secret`   | SECRET     |
| `Other`    | OTHER      |