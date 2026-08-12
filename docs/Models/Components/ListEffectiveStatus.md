# ListEffectiveStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ListEffectiveStatus.SupportedRequired;

// Open enum: use .Of() to create instances from custom string values
var custom = ListEffectiveStatus.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `SupportedRequired` | supported-required  |
| `Supported`         | supported           |
| `NotSupported`      | not-supported       |