# AccountingFeeType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingFeeType.Tax;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingFeeType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Tax`       | TAX         |
| `Discount`  | DISCOUNT    |
| `Promotion` | PROMOTION   |
| `Shipping`  | SHIPPING    |
| `GiftWrap`  | GIFT_WRAP   |
| `Cod`       | COD         |
| `Surcharge` | SURCHARGE   |
| `Other`     | OTHER       |