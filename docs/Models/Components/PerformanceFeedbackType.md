# PerformanceFeedbackType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceFeedbackType.Praise;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceFeedbackType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Praise`    | PRAISE      |
| `Feedback`  | FEEDBACK    |
| `Requested` | REQUESTED   |
| `Other`     | OTHER       |