# TimeUnit

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TimeUnit.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = TimeUnit.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Unspecified` | UNSPECIFIED   |
| `Lifetime`    | LIFETIME      |
| `Months`      | MONTHS        |
| `Weeks`       | WEEKS         |
| `Days`        | DAYS          |
| `Hours`       | HOURS         |
| `Minutes`     | MINUTES       |