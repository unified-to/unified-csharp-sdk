# AccountingProjectStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingProjectStatus.NotStarted;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingProjectStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `NotStarted` | NOT_STARTED  |
| `InProgress` | IN_PROGRESS  |
| `OnHold`     | ON_HOLD      |
| `Completed`  | COMPLETED    |
| `Cancelled`  | CANCELLED    |
| `Closed`     | CLOSED       |