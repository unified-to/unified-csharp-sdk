# AssessmentParameterType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AssessmentParameterType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = AssessmentParameterType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Text`           | TEXT             |
| `Number`         | NUMBER           |
| `MultipleChoice` | MULTIPLE_CHOICE  |
| `MultipleSelect` | MULTIPLE_SELECT  |
| `Date`           | DATE             |
| `File`           | FILE             |