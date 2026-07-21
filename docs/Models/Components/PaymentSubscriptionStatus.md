# PaymentSubscriptionStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentSubscriptionStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentSubscriptionStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | ACTIVE     |
| `Inactive` | INACTIVE   |
| `Canceled` | CANCELED   |
| `Paused`   | PAUSED     |