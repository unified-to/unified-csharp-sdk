# PropertyHrisPayslipDeductionCoverageLevel

Level selected by employee (e.g. "FAMILY", "EMPLOYEE_ONLY", or other)

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PropertyHrisPayslipDeductionCoverageLevel.EmployeeOnly;

// Open enum: use .Of() to create instances from custom string values
var custom = PropertyHrisPayslipDeductionCoverageLevel.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `EmployeeOnly`     | EMPLOYEE_ONLY      |
| `EmployeeSpouse`   | EMPLOYEE_SPOUSE    |
| `EmployeeChild`    | EMPLOYEE_CHILD     |
| `EmployeeChildren` | EMPLOYEE_CHILDREN  |
| `EmployeeFamily`   | EMPLOYEE_FAMILY    |
| `Family`           | FAMILY             |
| `Other`            | OTHER              |