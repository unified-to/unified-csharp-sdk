# AdsAssetType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AdsAssetType.Image;

// Open enum: use .Of() to create instances from custom string values
var custom = AdsAssetType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Image`        | IMAGE          |
| `Video`        | VIDEO          |
| `YoutubeVideo` | YOUTUBE_VIDEO  |
| `MediaBundle`  | MEDIA_BUNDLE   |
| `Text`         | TEXT           |