# AtsJobQuestionType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsJobQuestionType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsJobQuestionType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Text`           | TEXT             |
| `Number`         | NUMBER           |
| `Date`           | DATE             |
| `Boolean`        | BOOLEAN          |
| `MultipleChoice` | MULTIPLE_CHOICE  |
| `File`           | FILE             |
| `Textarea`       | TEXTAREA         |
| `MultipleSelect` | MULTIPLE_SELECT  |
| `University`     | UNIVERSITY       |
| `YesNo`          | YES_NO           |
| `Currency`       | CURRENCY         |
| `Url`            | URL              |