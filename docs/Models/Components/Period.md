# Period

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Period.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = Period.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Unspecified` | UNSPECIFIED   |
| `Daily`       | DAILY         |
| `Flight`      | FLIGHT        |