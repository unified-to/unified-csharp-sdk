# AchievementStatus

Progress towards the goal

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AchievementStatus.InProgress;

// Open enum: use .Of() to create instances from custom string values
var custom = AchievementStatus.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `InProgress`    | IN_PROGRESS     |
| `Improving`     | IMPROVING       |
| `Worsening`     | WORSENING       |
| `NoChange`      | NO_CHANGE       |
| `Achieved`      | ACHIEVED        |
| `Sustaining`    | SUSTAINING      |
| `NotAchieved`   | NOT_ACHIEVED    |
| `NoProgress`    | NO_PROGRESS     |
| `NotAttainable` | NOT_ATTAINABLE  |
| `Other`         | OTHER           |