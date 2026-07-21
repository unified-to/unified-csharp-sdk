# TaskTaskStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TaskTaskStatus.Opened;

// Open enum: use .Of() to create instances from custom string values
var custom = TaskTaskStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Opened`     | OPENED       |
| `InProgress` | IN_PROGRESS  |
| `Completed`  | COMPLETED    |