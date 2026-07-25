# AccountingExpenseStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingExpenseStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingExpenseStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Draft`     | DRAFT       |
| `Submitted` | SUBMITTED   |
| `Pending`   | PENDING     |
| `Approved`  | APPROVED    |
| `Rejected`  | REJECTED    |
| `Paid`      | PAID        |