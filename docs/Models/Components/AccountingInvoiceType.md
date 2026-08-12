# AccountingInvoiceType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingInvoiceType.Bill;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingInvoiceType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Bill`       | BILL         |
| `Invoice`    | INVOICE      |
| `Creditmemo` | CREDITMEMO   |