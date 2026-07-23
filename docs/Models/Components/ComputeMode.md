# ComputeMode

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeMode.Realtime;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeMode.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Realtime` | REALTIME   |
| `Batch`    | BATCH      |