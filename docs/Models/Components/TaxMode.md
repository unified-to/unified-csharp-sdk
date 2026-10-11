# TaxMode

INCLUSIVE / EXCLUSIVE / NONE; maps Xero LineAmountTypes (a boolean cannot represent NoTax)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TaxMode.Inclusive;

// Open enum: use .Of() to create instances from custom string values
var custom = TaxMode.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Inclusive` | INCLUSIVE   |
| `Exclusive` | EXCLUSIVE   |
| `None`      | NONE        |