# SportType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SportType.Running;

// Open enum: use .Of() to create instances from custom string values
var custom = SportType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Running`   | RUNNING     |
| `Cycling`   | CYCLING     |
| `Swimming`  | SWIMMING    |
| `Triathlon` | TRIATHLON   |
| `Walking`   | WALKING     |
| `Hiking`    | HIKING      |
| `Other`     | OTHER       |