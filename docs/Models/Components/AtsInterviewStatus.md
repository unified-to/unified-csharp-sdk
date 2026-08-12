# AtsInterviewStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsInterviewStatus.Scheduled;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsInterviewStatus.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `Scheduled`        | SCHEDULED          |
| `AwaitingFeedback` | AWAITING_FEEDBACK  |
| `Complete`         | COMPLETE           |
| `Canceled`         | CANCELED           |
| `NeedsScheduling`  | NEEDS_SCHEDULING   |