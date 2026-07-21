# AccountingOrderStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingOrderStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingOrderStatus.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Draft`             | DRAFT               |
| `Voided`            | VOIDED              |
| `Authorized`        | AUTHORIZED          |
| `Paid`              | PAID                |
| `PartiallyPaid`     | PARTIALLY_PAID      |
| `PartiallyRefunded` | PARTIALLY_REFUNDED  |
| `Refunded`          | REFUNDED            |
| `Submitted`         | SUBMITTED           |
| `Deleted`           | DELETED             |