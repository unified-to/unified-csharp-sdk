# HealthcareAllergyType

Category of the substance

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareAllergyType.Food;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareAllergyType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Food`        | FOOD          |
| `Medication`  | MEDICATION    |
| `Environment` | ENVIRONMENT   |
| `Biologic`    | BIOLOGIC      |
| `Other`       | OTHER         |