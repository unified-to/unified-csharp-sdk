# PaymentCollectionMethod

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentCollectionMethod.SendInvoice;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentCollectionMethod.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `SendInvoice`         | send_invoice          |
| `ChargeAutomatically` | charge_automatically  |