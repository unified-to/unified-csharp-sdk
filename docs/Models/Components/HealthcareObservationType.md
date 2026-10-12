# HealthcareObservationType

Category of the observation

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareObservationType.Laboratory;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareObservationType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Laboratory`    | LABORATORY      |
| `VitalSigns`    | VITAL_SIGNS     |
| `SocialHistory` | SOCIAL_HISTORY  |
| `Imaging`       | IMAGING         |
| `Survey`        | SURVEY          |
| `Exam`          | EXAM            |
| `Procedure`     | PROCEDURE       |
| `Therapy`       | THERAPY         |
| `Activity`      | ACTIVITY        |
| `Other`         | OTHER           |