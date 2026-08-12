# AssessmentPackageType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AssessmentPackageType.SkillsTest;

// Open enum: use .Of() to create instances from custom string values
var custom = AssessmentPackageType.Of("custom_value");
```


## Values

| Name                   | Value                  |
| ---------------------- | ---------------------- |
| `SkillsTest`           | SKILLS_TEST            |
| `BehavioralAssessment` | BEHAVIORAL_ASSESSMENT  |
| `VideoInterview`       | VIDEO_INTERVIEW        |
| `BackgroundCheck`      | BACKGROUND_CHECK       |
| `ReferenceCheck`       | REFERENCE_CHECK        |
| `Other`                | OTHER                  |