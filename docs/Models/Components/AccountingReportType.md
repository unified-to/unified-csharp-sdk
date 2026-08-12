# AccountingReportType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingReportType.TrialBalance;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingReportType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `TrialBalance`  | TRIAL_BALANCE   |
| `BalanceSheet`  | BALANCE_SHEET   |
| `ProfitAndLoss` | PROFIT_AND_LOSS |