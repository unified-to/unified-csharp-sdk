# GenaiTaskStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = GenaiTaskStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = GenaiTaskStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | PENDING     |
| `Running`   | RUNNING     |
| `Blocked`   | BLOCKED     |
| `Completed` | COMPLETED   |
| `Failed`    | FAILED      |
| `Cancelled` | CANCELLED   |
| `Expired`   | EXPIRED     |
| `Other`     | OTHER       |