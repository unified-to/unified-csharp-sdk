# BillingMethod

how the matter is billed

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = BillingMethod.Hourly;

// Open enum: use .Of() to create instances from custom string values
var custom = BillingMethod.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Hourly`      | HOURLY        |
| `FlatFee`     | FLAT_FEE      |
| `Contingency` | CONTINGENCY   |
| `Other`       | OTHER         |