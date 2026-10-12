# ComputeUsageCategory

What was consumed

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeUsageCategory.Gpu;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeUsageCategory.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Gpu`     | GPU       |
| `Cpu`     | CPU       |
| `Memory`  | MEMORY    |
| `Storage` | STORAGE   |
| `Network` | NETWORK   |
| `Other`   | OTHER     |