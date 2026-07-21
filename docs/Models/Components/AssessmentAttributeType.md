# AssessmentAttributeType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AssessmentAttributeType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = AssessmentAttributeType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Text`      | TEXT        |
| `Number`    | NUMBER      |
| `SubResult` | SUB_RESULT  |