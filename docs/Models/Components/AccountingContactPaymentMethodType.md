# AccountingContactPaymentMethodType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingContactPaymentMethodType.Ach;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingContactPaymentMethodType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Ach`     | ACH       |
| `Alipay`  | ALIPAY    |
| `Card`    | CARD      |
| `Giropay` | GIROPAY   |
| `Ideal`   | IDEAL     |
| `Other`   | OTHER     |
| `Paypal`  | PAYPAL    |
| `Wire`    | WIRE      |
| `Check`   | CHECK     |