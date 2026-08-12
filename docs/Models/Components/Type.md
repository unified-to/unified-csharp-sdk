# Type

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Type.AccountsPayable;

// Open enum: use .Of() to create instances from custom string values
var custom = Type.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `AccountsPayable`    | ACCOUNTS_PAYABLE     |
| `AccountsReceivable` | ACCOUNTS_RECEIVABLE  |
| `Bank`               | BANK                 |
| `CreditCard`         | CREDIT_CARD          |
| `FixedAsset`         | FIXED_ASSET          |
| `Liability`          | LIABILITY            |
| `Equity`             | EQUITY               |
| `Expense`            | EXPENSE              |
| `Revenue`            | REVENUE              |
| `Other`              | OTHER                |