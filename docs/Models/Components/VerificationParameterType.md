# VerificationParameterType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = VerificationParameterType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = VerificationParameterType.Of("custom_value");
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