# Dimension

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Dimension.Date;

// Open enum: use .Of() to create instances from custom string values
var custom = Dimension.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `Date`             | DATE               |
| `Platform`         | PLATFORM           |
| `PlatformPosition` | PLATFORM_POSITION  |
| `Device`           | DEVICE             |