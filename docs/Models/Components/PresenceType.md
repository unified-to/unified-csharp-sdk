# PresenceType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PresenceType.Presence;

// Open enum: use .Of() to create instances from custom string values
var custom = PresenceType.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `Presence`           | PRESENCE             |
| `PresenceOrInterest` | PRESENCE_OR_INTEREST |