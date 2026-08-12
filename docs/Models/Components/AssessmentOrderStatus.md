# AssessmentOrderStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AssessmentOrderStatus.Open;

// Open enum: use .Of() to create instances from custom string values
var custom = AssessmentOrderStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Open`       | OPEN         |
| `InProgress` | IN_PROGRESS  |
| `Completed`  | COMPLETED    |
| `Failed`     | FAILED       |
| `Rejected`   | REJECTED     |