# WebhookEvent

The event to subscribe to. "deleted" is supported on native webhooks, and on virtual webhooks where the integration supports it. Check the integration's Feature Support tab.

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = WebhookEvent.Updated;

// Open enum: use .Of() to create instances from custom string values
var custom = WebhookEvent.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Updated` | updated   |
| `Created` | created   |
| `Deleted` | deleted   |