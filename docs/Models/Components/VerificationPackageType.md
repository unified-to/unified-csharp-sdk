# VerificationPackageType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = VerificationPackageType.IdentityVerification;

// Open enum: use .Of() to create instances from custom string values
var custom = VerificationPackageType.Of("custom_value");
```


## Values

| Name                     | Value                    |
| ------------------------ | ------------------------ |
| `IdentityVerification`   | IDENTITY_VERIFICATION    |
| `Screening`              | SCREENING                |
| `BackgroundCheck`        | BACKGROUND_CHECK         |
| `EmploymentVerification` | EMPLOYMENT_VERIFICATION  |
| `EducationVerification`  | EDUCATION_VERIFICATION   |
| `CreditCheck`            | CREDIT_CHECK             |
| `FraudPrevention`        | FRAUD_PREVENTION         |
| `Other`                  | OTHER                    |