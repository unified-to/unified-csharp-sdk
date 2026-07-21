# ContentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ContentType.Html;

// Open enum: use .Of() to create instances from custom string values
var custom = ContentType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Html`     | HTML       |
| `Markdown` | MARKDOWN   |
| `Text`     | TEXT       |
| `Other`    | OTHER      |