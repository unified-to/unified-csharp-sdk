# CalendarAttendeeStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CalendarAttendeeStatus.Accepted;

// Open enum: use .Of() to create instances from custom string values
var custom = CalendarAttendeeStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Accepted`  | ACCEPTED    |
| `Rejected`  | REJECTED    |
| `Tentative` | TENTATIVE   |