# ComputeSnapshotStatus

Normalized snapshot status

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeSnapshotStatus.Creating;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeSnapshotStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Creating` | CREATING   |
| `Ready`    | READY      |
| `Failed`   | FAILED     |
| `Deleting` | DELETING   |
| `Other`    | OTHER      |