# IssueStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = IssueStatus.Completed;

// Open enum: use .Of() to create instances from custom string values
var custom = IssueStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Completed`  | COMPLETED    |
| `New`        | NEW          |
| `Roadmap`    | ROADMAP      |
| `InProgress` | IN_PROGRESS  |
| `OnHold`     | ON_HOLD      |
| `Validating` | VALIDATING   |
| `Rejected`   | REJECTED     |