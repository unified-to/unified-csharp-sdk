# AtsCompensationType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsCompensationType.Salary;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsCompensationType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Salary`       | SALARY         |
| `Bonus`        | BONUS          |
| `StockOptions` | STOCK_OPTIONS  |
| `Equity`       | EQUITY         |
| `Other`        | OTHER          |