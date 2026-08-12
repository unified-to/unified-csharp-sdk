# CrmEventFormFieldType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CrmEventFormFieldType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = CrmEventFormFieldType.Of("custom_value");
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
| `SingleSelect`   | SINGLE_SELECT    |
| `MultipleSelect` | MULTIPLE_SELECT  |
| `Email`          | EMAIL            |
| `Phone`          | PHONE            |
| `YesNo`          | YES_NO           |
| `Currency`       | CURRENCY         |
| `Url`            | URL              |