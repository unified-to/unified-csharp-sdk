# GenaiAnswerType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = GenaiAnswerType.Boolean;

// Open enum: use .Of() to create instances from custom string values
var custom = GenaiAnswerType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Boolean` | BOOLEAN   |
| `Choice`  | CHOICE    |
| `Score`   | SCORE     |