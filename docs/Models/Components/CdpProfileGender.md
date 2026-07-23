# CdpProfileGender

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpProfileGender.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpProfileGender.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Male`      | MALE        |
| `Female`    | FEMALE      |
| `Intersex`  | INTERSEX    |
| `Trans`     | TRANS       |
| `NonBinary` | NON_BINARY  |