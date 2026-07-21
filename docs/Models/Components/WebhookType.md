# WebhookType

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