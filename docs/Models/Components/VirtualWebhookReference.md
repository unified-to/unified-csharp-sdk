# VirtualWebhookReference

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = VirtualWebhookReference.SupportedRequired;

// Open enum: use .Of() to create instances from custom string values
var custom = VirtualWebhookReference.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `SupportedRequired` | supported-required  |
| `Supported`         | supported           |
| `NotSupported`      | not-supported       |