# CreativeSelection

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CreativeSelection.Optimized;

// Open enum: use .Of() to create instances from custom string values
var custom = CreativeSelection.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Optimized`  | OPTIMIZED    |
| `RoundRobin` | ROUND_ROBIN  |