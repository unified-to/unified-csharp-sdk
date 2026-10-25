# MaritalStatus

Marital status of the patient

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = MaritalStatus.Married;

// Open enum: use .Of() to create instances from custom string values
var custom = MaritalStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Married`         | MARRIED           |
| `Single`          | SINGLE            |
| `DomesticPartner` | DOMESTIC_PARTNER  |
| `Separated`       | SEPARATED         |
| `Divorced`        | DIVORCED          |
| `Widowed`         | WIDOWED           |
| `Annulled`        | ANNULLED          |
| `Unknown`         | UNKNOWN           |
| `Other`           | OTHER             |