# VirtualWebhookCustomerId

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = VirtualWebhookCustomerId.SupportedRequired;

// Open enum: use .Of() to create instances from custom string values
var custom = VirtualWebhookCustomerId.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `SupportedRequired` | supported-required  |
| `Supported`         | supported           |
| `NotSupported`      | not-supported       |