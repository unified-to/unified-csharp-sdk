# HostingSource

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HostingSource.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = HostingSource.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Unspecified`     | UNSPECIFIED       |
| `Cm`              | CM                |
| `ThirdParty`      | THIRD_PARTY       |
| `Hosted`          | HOSTED            |
| `RichMedia`       | RICH_MEDIA        |
| `PublisherHosted` | PUBLISHER_HOSTED  |