# Level

Normalized stock level

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Level.None;

// Open enum: use .Of() to create instances from custom string values
var custom = Level.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `None`   | NONE     |
| `Low`    | LOW      |
| `Medium` | MEDIUM   |
| `High`   | HIGH     |
| `Other`  | OTHER    |