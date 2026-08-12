# Tax

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Tax.PreTax;

// Open enum: use .Of() to create instances from custom string values
var custom = Tax.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `PreTax`     | PRE_TAX      |
| `PostTax`    | POST_TAX     |
| `Taxable`    | TAXABLE      |
| `NonTaxable` | NON_TAXABLE  |
| `TaxValue`   | TAX          |