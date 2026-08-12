# ListRawFields

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ListRawFields.SupportedRequired;

// Open enum: use .Of() to create instances from custom string values
var custom = ListRawFields.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `SupportedRequired` | supported-required  |
| `Supported`         | supported           |
| `NotSupported`      | not-supported       |