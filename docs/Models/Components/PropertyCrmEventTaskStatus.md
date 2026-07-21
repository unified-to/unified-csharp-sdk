# PropertyCrmEventTaskStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PropertyCrmEventTaskStatus.Completed;

// Open enum: use .Of() to create instances from custom string values
var custom = PropertyCrmEventTaskStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Completed`      | COMPLETED        |
| `NotStarted`     | NOT_STARTED      |
| `WorkInProgress` | WORK_IN_PROGRESS |
| `Deferred`       | DEFERRED         |