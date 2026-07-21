# ClubsEventType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ClubsEventType.Game;

// Open enum: use .Of() to create instances from custom string values
var custom = ClubsEventType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Game`     | GAME       |
| `Practice` | PRACTICE   |
| `Other`    | OTHER      |