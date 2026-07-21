# PerformanceGoalType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceGoalType.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceGoalType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Unspecified` | UNSPECIFIED   |
| `Cpa`         | CPA           |
| `Cpc`         | CPC           |
| `ViewableCpm` | VIEWABLE_CPM  |
| `CustomAlgo`  | CUSTOM_ALGO   |
| `Civa`        | CIVA          |
| `IvoTen`      | IVO_TEN       |
| `AvViewed`    | AV_VIEWED     |
| `Reach`       | REACH         |