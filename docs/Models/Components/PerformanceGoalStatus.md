# PerformanceGoalStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceGoalStatus.NotStarted;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceGoalStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `NotStarted` | NOT_STARTED  |
| `InProgress` | IN_PROGRESS  |
| `Completed`  | COMPLETED    |
| `Closed`     | CLOSED       |
| `Other`      | OTHER        |