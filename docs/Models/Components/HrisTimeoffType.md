# HrisTimeoffType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisTimeoffType.Vacation;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisTimeoffType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Vacation`    | VACATION      |
| `Sick`        | SICK          |
| `Holiday`     | HOLIDAY       |
| `Bereavement` | BEREAVEMENT   |
| `Parental`    | PARENTAL      |
| `Unpaid`      | UNPAID        |
| `InLieu`      | IN_LIEU       |
| `Other`       | OTHER         |