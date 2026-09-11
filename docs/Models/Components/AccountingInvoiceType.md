# AccountingInvoiceType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingInvoiceType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingInvoiceType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Invoice`    | INVOICE      |
| `Creditmemo` | CREDITMEMO   |