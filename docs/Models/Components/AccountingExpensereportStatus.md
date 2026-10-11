# AccountingExpensereportStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingExpensereportStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingExpensereportStatus.Of("custom_value");
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