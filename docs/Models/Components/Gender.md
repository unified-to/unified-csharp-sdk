# Gender

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Gender.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = Gender.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Male`      | MALE        |
| `Female`    | FEMALE      |
| `Intersex`  | INTERSEX    |
| `Trans`     | TRANS       |
| `NonBinary` | NON_BINARY  |