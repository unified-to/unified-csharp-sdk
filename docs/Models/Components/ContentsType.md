# ContentsType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ContentsType.Merchandise;

// Open enum: use .Of() to create instances from custom string values
var custom = ContentsType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Merchandise`   | MERCHANDISE     |
| `Documents`     | DOCUMENTS       |
| `Gift`          | GIFT            |
| `ReturnedGoods` | RETURNED_GOODS  |
| `Sample`        | SAMPLE          |
| `Other`         | OTHER           |