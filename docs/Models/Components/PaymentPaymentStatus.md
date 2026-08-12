# PaymentPaymentStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentPaymentStatus.Succeeded;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentPaymentStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Succeeded`  | SUCCEEDED    |
| `Pending`    | PENDING      |
| `Authorized` | AUTHORIZED   |
| `Failed`     | FAILED       |
| `Canceled`   | CANCELED     |