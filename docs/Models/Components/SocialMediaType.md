# SocialMediaType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SocialMediaType.Photo;

// Open enum: use .Of() to create instances from custom string values
var custom = SocialMediaType.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Photo` | PHOTO   |
| `Video` | VIDEO   |
| `Gif`   | GIF     |
| `Other` | OTHER   |