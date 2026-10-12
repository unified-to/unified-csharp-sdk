# Market

Pricing market the instance runs in

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Market.OnDemand;

// Open enum: use .Of() to create instances from custom string values
var custom = Market.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `OnDemand`  | ON_DEMAND   |
| `Spot`      | SPOT        |
| `Reserved`  | RESERVED    |
| `Community` | COMMUNITY   |
| `Other`     | OTHER       |