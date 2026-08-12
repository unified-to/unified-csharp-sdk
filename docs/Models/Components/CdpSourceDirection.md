# CdpSourceDirection

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpSourceDirection.Source;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpSourceDirection.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Source`        | SOURCE          |
| `Destination`   | DESTINATION     |
| `Bidirectional` | BIDIRECTIONAL   |