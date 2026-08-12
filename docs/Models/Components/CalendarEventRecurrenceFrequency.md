# CalendarEventRecurrenceFrequency

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CalendarEventRecurrenceFrequency.Daily;

// Open enum: use .Of() to create instances from custom string values
var custom = CalendarEventRecurrenceFrequency.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Daily`   | DAILY     |
| `Weekly`  | WEEKLY    |
| `Monthly` | MONTHLY   |
| `Yearly`  | YEARLY    |