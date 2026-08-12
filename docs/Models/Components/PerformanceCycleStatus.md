# PerformanceCycleStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceCycleStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceCycleStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Draft`     | DRAFT       |
| `Scheduled` | SCHEDULED   |
| `Active`    | ACTIVE      |
| `Closed`    | CLOSED      |
| `Other`     | OTHER       |