# HealthcareMetadataFormat

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareMetadataFormat.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareMetadataFormat.Of("custom_value");
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