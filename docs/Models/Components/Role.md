# Role

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Role.System;

// Open enum: use .Of() to create instances from custom string values
var custom = Role.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `System`    | SYSTEM      |
| `User`      | USER        |
| `Assistant` | ASSISTANT   |