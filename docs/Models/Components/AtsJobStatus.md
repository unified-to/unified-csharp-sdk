# AtsJobStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsJobStatus.Archived;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsJobStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Archived` | ARCHIVED   |
| `Pending`  | PENDING    |
| `Draft`    | DRAFT      |
| `Open`     | OPEN       |
| `Closed`   | CLOSED     |