# HealthcareIdentifierType

The kind of identifier

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareIdentifierType.Mrn;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareIdentifierType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Mrn`            | MRN              |
| `Npi`            | NPI              |
| `Ssn`            | SSN              |
| `DriversLicense` | DRIVERS_LICENSE  |
| `Passport`       | PASSPORT         |
| `Insurance`      | INSURANCE        |
| `Other`          | OTHER            |