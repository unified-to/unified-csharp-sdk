# AtsGroupType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsGroupType.Team;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsGroupType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Team`          | TEAM            |
| `Group`         | GROUP           |
| `Department`    | DEPARTMENT      |
| `Division`      | DIVISION        |
| `BusinessUnit`  | BUSINESS_UNIT   |
| `Branch`        | BRANCH          |
| `SubDepartment` | SUB_DEPARTMENT  |