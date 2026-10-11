# WebhookType

"native" registers with the integration, which sends events as they happen. "virtual" checks for changes on "interval". Optional on create; if omitted, Unified.to picks a supported type for the object. Requesting a type the integration doesn't support returns 400. Set on create only: changes sent on update are ignored without an error. Delete and recreate the webhook to change type.

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = WebhookType.Virtual;

// Open enum: use .Of() to create instances from custom string values
var custom = WebhookType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Virtual` | virtual   |
| `Native`  | native    |