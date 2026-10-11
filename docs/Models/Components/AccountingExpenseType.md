# AccountingExpenseType

USER = employee spend; COMPANY = books/purchase expense

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingExpenseType.User;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingExpenseType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `User`    | USER      |
| `Company` | COMPANY   |