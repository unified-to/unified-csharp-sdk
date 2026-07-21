# EmploymentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = EmploymentType.FullTime;

// Open enum: use .Of() to create instances from custom string values
var custom = EmploymentType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `FullTime`   | FULL_TIME    |
| `PartTime`   | PART_TIME    |
| `Contractor` | CONTRACTOR   |
| `Intern`     | INTERN       |
| `Consultant` | CONSULTANT   |
| `Volunteer`  | VOLUNTEER    |
| `Casual`     | CASUAL       |
| `Seasonal`   | SEASONAL     |
| `Freelance`  | FREELANCE    |
| `Other`      | OTHER        |