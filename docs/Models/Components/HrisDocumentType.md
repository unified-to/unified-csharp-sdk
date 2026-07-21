# HrisDocumentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisDocumentType.Contract;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisDocumentType.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Contract`          | CONTRACT            |
| `OfferLetter`       | OFFER_LETTER        |
| `Policy`            | POLICY              |
| `Tax`               | TAX                 |
| `Id`                | ID                  |
| `Visa`              | VISA                |
| `Payslip`           | PAYSLIP             |
| `Benefits`          | BENEFITS            |
| `Certification`     | CERTIFICATION       |
| `PerformanceReview` | PERFORMANCE_REVIEW  |
| `Onboarding`        | ONBOARDING          |
| `Termination`       | TERMINATION         |
| `Medical`           | MEDICAL             |
| `Other`             | OTHER               |