# GpuManufacturer

GPU manufacturer

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = GpuManufacturer.Nvidia;

// Open enum: use .Of() to create instances from custom string values
var custom = GpuManufacturer.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Nvidia` | NVIDIA   |
| `Amd`    | AMD      |
| `Intel`  | INTEL    |
| `Other`  | OTHER    |