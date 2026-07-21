# ProfileGender

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ProfileGender.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = ProfileGender.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Male`      | MALE        |
| `Female`    | FEMALE      |
| `Intersex`  | INTERSEX    |
| `Trans`     | TRANS       |
| `NonBinary` | NON_BINARY  |