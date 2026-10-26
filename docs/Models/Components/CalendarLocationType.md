# CalendarLocationType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CalendarLocationType.Building;

// Open enum: use .Of() to create instances from custom string values
var custom = CalendarLocationType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Building` | BUILDING   |
| `Floor`    | FLOOR      |
| `Campus`   | CAMPUS     |
| `City`     | CITY       |
| `Region`   | REGION     |
| `Country`  | COUNTRY    |
| `Other`    | OTHER      |