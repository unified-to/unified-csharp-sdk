# ComputeMetadataFormat

The data type of the value

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeMetadataFormat.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeMetadataFormat.Of("custom_value");
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