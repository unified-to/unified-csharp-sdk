# PaymentCollectionMethod

When set to charging_automatically, an automated attempt will occur to pay this invoice using the default payment source attached to the contactcustomer. When set to send_invoice, an will email will be sent with this invoice to the contact/customer with payment instructions.

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