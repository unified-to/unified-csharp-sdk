# EncondingFormat

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = EncondingFormat.Float;

// Open enum: use .Of() to create instances from custom string values
var custom = EncondingFormat.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Float`   | FLOAT     |
| `Uint8`   | UINT8     |
| `Int8`    | INT8      |
| `Binary`  | BINARY    |
| `Ubinary` | UBINARY   |
| `Base64`  | BASE64    |