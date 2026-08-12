# BillingType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = BillingType.FixedPrice;

// Open enum: use .Of() to create instances from custom string values
var custom = BillingType.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `FixedPrice`       | FIXED_PRICE        |
| `TimeAndMaterials` | TIME_AND_MATERIALS |
| `Milestone`        | MILESTONE          |
| `NonBillable`      | NON_BILLABLE       |