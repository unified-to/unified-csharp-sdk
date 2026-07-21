# CalendarWebinarStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CalendarWebinarStatus.Canceled;

// Open enum: use .Of() to create instances from custom string values
var custom = CalendarWebinarStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Canceled`  | CANCELED    |
| `Confirmed` | CONFIRMED   |
| `Tentative` | TENTATIVE   |