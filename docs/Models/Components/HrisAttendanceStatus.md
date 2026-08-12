# HrisAttendanceStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisAttendanceStatus.Open;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisAttendanceStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Open`     | OPEN       |
| `Closed`   | CLOSED     |
| `Approved` | APPROVED   |