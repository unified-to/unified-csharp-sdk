# HrisEarningStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisEarningStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisEarningStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | PENDING     |
| `Active`    | ACTIVE      |
| `Processed` | PROCESSED   |
| `Ended`     | ENDED       |
| `Cancelled` | CANCELLED   |
| `Failed`    | FAILED      |