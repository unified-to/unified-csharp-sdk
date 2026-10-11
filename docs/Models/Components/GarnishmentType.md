# GarnishmentType

set when this deduction is a court-ordered garnishment

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = GarnishmentType.ChildSupport;

// Open enum: use .Of() to create instances from custom string values
var custom = GarnishmentType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `ChildSupport` | CHILD_SUPPORT  |
| `TaxLevy`      | TAX_LEVY       |
| `StudentLoan`  | STUDENT_LOAN   |
| `Creditor`     | CREDITOR       |
| `Bankruptcy`   | BANKRUPTCY     |
| `Other`        | OTHER          |