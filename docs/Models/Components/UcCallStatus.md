# UcCallStatus

The current or final status of the call

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = UcCallStatus.Queued;

// Open enum: use .Of() to create instances from custom string values
var custom = UcCallStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Queued`     | QUEUED       |
| `Ringing`    | RINGING      |
| `InProgress` | IN_PROGRESS  |
| `Completed`  | COMPLETED    |
| `Busy`       | BUSY         |
| `NoAnswer`   | NO_ANSWER    |
| `Failed`     | FAILED       |
| `Canceled`   | CANCELED     |
| `Other`      | OTHER        |