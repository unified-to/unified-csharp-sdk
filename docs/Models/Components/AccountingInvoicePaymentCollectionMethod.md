# AccountingInvoicePaymentCollectionMethod

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingInvoicePaymentCollectionMethod.SendInvoice;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingInvoicePaymentCollectionMethod.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `SendInvoice`         | send_invoice          |
| `ChargeAutomatically` | charge_automatically  |