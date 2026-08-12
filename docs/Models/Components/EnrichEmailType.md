# EnrichEmailType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = EnrichEmailType.Work;

// Open enum: use .Of() to create instances from custom string values
var custom = EnrichEmailType.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Work`  | WORK    |
| `Home`  | HOME    |
| `Other` | OTHER   |