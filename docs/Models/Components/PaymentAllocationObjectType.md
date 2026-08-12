# PaymentAllocationObjectType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentAllocationObjectType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentAllocationObjectType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Invoice`       | INVOICE         |
| `Bill`          | BILL            |
| `Creditmemo`    | CREDITMEMO      |
| `Vendorcredit`  | VENDORCREDIT    |
| `Salesorder`    | SALESORDER      |
| `Purchaseorder` | PURCHASEORDER   |