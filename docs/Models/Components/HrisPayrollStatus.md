# HrisPayrollStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisPayrollStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisPayrollStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Draft`      | DRAFT        |
| `Pending`    | PENDING      |
| `Approved`   | APPROVED     |
| `Processing` | PROCESSING   |
| `Paid`       | PAID         |
| `Failed`     | FAILED       |
| `Cancelled`  | CANCELLED    |