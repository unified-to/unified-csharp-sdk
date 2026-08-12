# Direction

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Direction.Source;

// Open enum: use .Of() to create instances from custom string values
var custom = Direction.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Source`        | SOURCE          |
| `Destination`   | DESTINATION     |
| `Bidirectional` | BIDIRECTIONAL   |