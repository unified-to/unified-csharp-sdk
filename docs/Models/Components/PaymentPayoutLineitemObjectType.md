# PaymentPayoutLineitemObjectType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentPayoutLineitemObjectType.Payment;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentPayoutLineitemObjectType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Payment`    | PAYMENT      |
| `Refund`     | REFUND       |
| `Fee`        | FEE          |
| `Adjustment` | ADJUSTMENT   |
| `Transfer`   | TRANSFER     |
| `Other`      | OTHER        |