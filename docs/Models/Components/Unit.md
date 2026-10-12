# Unit

Unit of quantity

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Unit.GpuHour;

// Open enum: use .Of() to create instances from custom string values
var custom = Unit.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `GpuHour`    | GPU_HOUR     |
| `VcpuSecond` | VCPU_SECOND  |
| `GbSecond`   | GB_SECOND    |
| `GbMonth`    | GB_MONTH     |
| `Byte`       | BYTE         |
| `Second`     | SECOND       |
| `Other`      | OTHER        |