# ComputeSnapshotType

Whether memory state is included

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeSnapshotType.Memory;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeSnapshotType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Memory` | MEMORY   |
| `Disk`   | DISK     |
| `Other`  | OTHER    |