# Event

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Event.Updated;

// Open enum: use .Of() to create instances from custom string values
var custom = Event.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Updated` | updated   |
| `Created` | created   |
| `Deleted` | deleted   |