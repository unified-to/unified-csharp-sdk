# HealthcarePatientGender

Administrative gender of the patient

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcarePatientGender.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcarePatientGender.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Male`    | MALE      |
| `Female`  | FEMALE    |
| `Other`   | OTHER     |
| `Unknown` | UNKNOWN   |