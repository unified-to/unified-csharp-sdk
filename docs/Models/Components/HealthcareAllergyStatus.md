# HealthcareAllergyStatus

Clinical status of the allergy

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareAllergyStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareAllergyStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | ACTIVE     |
| `Inactive` | INACTIVE   |
| `Resolved` | RESOLVED   |
| `Other`    | OTHER      |