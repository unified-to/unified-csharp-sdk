# PaymentRefundStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentRefundStatus.Succeeded;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentRefundStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Succeeded` | SUCCEEDED   |
| `Pending`   | PENDING     |
| `Failed`    | FAILED      |
| `Canceled`  | CANCELED    |