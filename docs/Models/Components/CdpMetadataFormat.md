# CdpMetadataFormat

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpMetadataFormat.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpMetadataFormat.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Text`    | TEXT      |
| `Number`  | NUMBER    |
| `Date`    | DATE      |
| `Boolean` | BOOLEAN   |
| `Array`   | ARRAY     |
| `Object`  | OBJECT    |