# Frequency

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Frequency.OneTime;

// Open enum: use .Of() to create instances from custom string values
var custom = Frequency.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `OneTime` | ONE_TIME  |
| `Day`     | DAY       |
| `Quarter` | QUARTER   |
| `Year`    | YEAR      |
| `Hour`    | HOUR      |
| `Month`   | MONTH     |
| `Week`    | WEEK      |