# CdpEventType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpEventType.Track;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpEventType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Track`    | TRACK      |
| `Page`     | PAGE       |
| `Screen`   | SCREEN     |
| `Identify` | IDENTIFY   |
| `Group`    | GROUP      |
| `Alias`    | ALIAS      |