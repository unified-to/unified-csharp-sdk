# PerformanceReviewType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceReviewType.Self;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceReviewType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Self`    | SELF      |
| `Manager` | MANAGER   |
| `Peer`    | PEER      |
| `Upward`  | UPWARD    |
| `Other`   | OTHER     |