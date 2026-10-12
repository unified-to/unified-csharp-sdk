# ComputeVolumeStatus

Normalized volume status

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeVolumeStatus.Creating;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeVolumeStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Creating`  | CREATING    |
| `Available` | AVAILABLE   |
| `InUse`     | IN_USE      |
| `Deleting`  | DELETING    |
| `Error`     | ERROR       |
| `Other`     | OTHER       |