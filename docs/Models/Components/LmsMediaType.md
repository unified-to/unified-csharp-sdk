# LmsMediaType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = LmsMediaType.Image;

// Open enum: use .Of() to create instances from custom string values
var custom = LmsMediaType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Image`    | IMAGE      |
| `Headshot` | HEADSHOT   |
| `Video`    | VIDEO      |
| `Web`      | WEB        |
| `Document` | DOCUMENT   |
| `Text`     | TEXT       |
| `Html`     | HTML       |
| `Other`    | OTHER      |