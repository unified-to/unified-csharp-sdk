# HealthcarePractitionerGender

Administrative gender of the practitioner

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcarePractitionerGender.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcarePractitionerGender.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Male`    | MALE      |
| `Female`  | FEMALE    |
| `Other`   | OTHER     |
| `Unknown` | UNKNOWN   |