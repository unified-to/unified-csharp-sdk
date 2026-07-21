# PaymentPaymentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentPaymentType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentPaymentType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Invoice` | INVOICE   |
| `Bill`    | BILL      |