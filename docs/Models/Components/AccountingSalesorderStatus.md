# AccountingSalesorderStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingSalesorderStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingSalesorderStatus.Of("custom_value");
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