# FulfillmentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = FulfillmentType.DineIn;

// Open enum: use .Of() to create instances from custom string values
var custom = FulfillmentType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `DineIn`   | DINE_IN    |
| `Takeout`  | TAKEOUT    |
| `Delivery` | DELIVERY   |
| `Pickup`   | PICKUP     |
| `Curbside` | CURBSIDE   |
| `Shipping` | SHIPPING   |
| `Digital`  | DIGITAL    |
| `Other`    | OTHER      |