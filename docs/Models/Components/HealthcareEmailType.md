# HealthcareEmailType

The kind of email address (work, home or other)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareEmailType.Work;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareEmailType.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Work`  | WORK    |
| `Home`  | HOME    |
| `Other` | OTHER   |