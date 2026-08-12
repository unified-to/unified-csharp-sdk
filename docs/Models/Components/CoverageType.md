# CoverageType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CoverageType.Standard;

// Open enum: use .Of() to create instances from custom string values
var custom = CoverageType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Standard` | STANDARD   |
| `Premium`  | PREMIUM    |
| `Custom`   | CUSTOM     |