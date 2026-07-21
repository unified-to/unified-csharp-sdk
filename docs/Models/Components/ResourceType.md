# ResourceType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ResourceType.User;

// Open enum: use .Of() to create instances from custom string values
var custom = ResourceType.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `User`  | User    |
| `Group` | Group   |