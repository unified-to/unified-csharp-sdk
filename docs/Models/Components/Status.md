# Status

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Status.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = Status.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | ACTIVE     |
| `Archived` | ARCHIVED   |