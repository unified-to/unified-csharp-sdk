# ComputeVolumeType

The kind of volume

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeVolumeType.Standard;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeVolumeType.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Standard`        | STANDARD          |
| `HighPerformance` | HIGH_PERFORMANCE  |
| `Shared`          | SHARED            |
| `Local`           | LOCAL             |
| `Other`           | OTHER             |