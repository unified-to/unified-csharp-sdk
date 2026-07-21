# CreativeType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CreativeType.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = CreativeType.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Unspecified`     | UNSPECIFIED       |
| `Standard`        | STANDARD          |
| `Expandable`      | EXPANDABLE        |
| `Video`           | VIDEO             |
| `Native`          | NATIVE            |
| `Audio`           | AUDIO             |
| `PublisherHosted` | PUBLISHER_HOSTED  |
| `AssetBased`      | ASSET_BASED       |
| `Image`           | IMAGE             |
| `Document`        | DOCUMENT          |