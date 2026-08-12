# LocationType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = LocationType.Restaurant;

// Open enum: use .Of() to create instances from custom string values
var custom = LocationType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Restaurant` | RESTAURANT   |
| `Salon`      | SALON        |
| `Warehouse`  | WAREHOUSE    |
| `Store`      | STORE        |
| `Other`      | OTHER        |