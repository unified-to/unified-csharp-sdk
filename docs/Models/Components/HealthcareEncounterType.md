# HealthcareEncounterType

Class of the encounter (e.g. ambulatory, inpatient)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareEncounterType.Ambulatory;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareEncounterType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Ambulatory`  | AMBULATORY    |
| `Emergency`   | EMERGENCY     |
| `Inpatient`   | INPATIENT     |
| `Observation` | OBSERVATION   |
| `HomeHealth`  | HOME_HEALTH   |
| `Virtual`     | VIRTUAL       |
| `Other`       | OTHER         |