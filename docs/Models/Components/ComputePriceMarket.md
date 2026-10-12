# ComputePriceMarket

Pricing market

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputePriceMarket.OnDemand;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputePriceMarket.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `OnDemand`  | ON_DEMAND   |
| `Spot`      | SPOT        |
| `Reserved`  | RESERVED    |
| `Community` | COMMUNITY   |
| `Other`     | OTHER       |