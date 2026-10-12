# ComputePricePriceUnit

Unit that price_amount is quoted in

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputePricePriceUnit.PerGpuHour;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputePricePriceUnit.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `PerGpuHour`      | PER_GPU_HOUR      |
| `PerInstanceHour` | PER_INSTANCE_HOUR |
| `Other`           | OTHER             |