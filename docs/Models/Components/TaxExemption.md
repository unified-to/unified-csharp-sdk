# TaxExemption

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TaxExemption.FederalGov;

// Open enum: use .Of() to create instances from custom string values
var custom = TaxExemption.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `FederalGov`     | FEDERAL_GOV      |
| `RegionGov`      | REGION_GOV       |
| `LocalGov`       | LOCAL_GOV        |
| `TribalGov`      | TRIBAL_GOV       |
| `CharitableOrg`  | CHARITABLE_ORG   |
| `ReligiousOrg`   | RELIGIOUS_ORG    |
| `EducationalOrg` | EDUCATIONAL_ORG  |
| `MedicalOrg`     | MEDICAL_ORG      |
| `Resale`         | RESALE           |
| `Foreign`        | FOREIGN          |
| `Other`          | OTHER            |