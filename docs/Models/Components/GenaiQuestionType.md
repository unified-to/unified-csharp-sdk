# GenaiQuestionType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = GenaiQuestionType.Boolean;

// Open enum: use .Of() to create instances from custom string values
var custom = GenaiQuestionType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Boolean` | BOOLEAN   |
| `Choice`  | CHOICE    |
| `Score`   | SCORE     |