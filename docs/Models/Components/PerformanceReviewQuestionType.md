# PerformanceReviewQuestionType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceReviewQuestionType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceReviewQuestionType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Text`         | TEXT           |
| `SingleSelect` | SINGLE_SELECT  |
| `MultiSelect`  | MULTI_SELECT   |
| `Rating`       | RATING         |
| `Other`        | OTHER          |