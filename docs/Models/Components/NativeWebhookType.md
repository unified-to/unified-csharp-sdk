# NativeWebhookType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = NativeWebhookType.SupportedRequired;

// Open enum: use .Of() to create instances from custom string values
var custom = NativeWebhookType.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `SupportedRequired` | supported-required  |
| `Supported`         | supported           |
| `NotSupported`      | not-supported       |