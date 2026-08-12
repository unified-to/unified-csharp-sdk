# KmsPageType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = KmsPageType.Html;

// Open enum: use .Of() to create instances from custom string values
var custom = KmsPageType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Html`     | HTML       |
| `Markdown` | MARKDOWN   |
| `Text`     | TEXT       |
| `Other`    | OTHER      |