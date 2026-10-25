# HealthcareDocumentType

Unified, normalized kind of clinical document (OTHER when unmappable)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareDocumentType.ProgressNote;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareDocumentType.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `ProgressNote`       | PROGRESS_NOTE        |
| `ConsultationNote`   | CONSULTATION_NOTE    |
| `HistoryAndPhysical` | HISTORY_AND_PHYSICAL |
| `DischargeSummary`   | DISCHARGE_SUMMARY    |
| `ProcedureNote`      | PROCEDURE_NOTE       |
| `ReferralNote`       | REFERRAL_NOTE        |
| `Summary`            | SUMMARY              |
| `LaboratoryReport`   | LABORATORY_REPORT    |
| `ImagingReport`      | IMAGING_REPORT       |
| `Consent`            | CONSENT              |
| `Other`              | OTHER                |