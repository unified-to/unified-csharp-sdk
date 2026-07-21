# TaskMetadataFormat

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TaskMetadataFormat.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = TaskMetadataFormat.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Text`           | TEXT             |
| `Number`         | NUMBER           |
| `Date`           | DATE             |
| `Boolean`        | BOOLEAN          |
| `File`           | FILE             |
| `Textarea`       | TEXTAREA         |
| `SingleSelect`   | SINGLE_SELECT    |
| `MultipleSelect` | MULTIPLE_SELECT  |
| `Measurement`    | MEASUREMENT      |
| `Price`          | PRICE            |
| `YesNo`          | YES_NO           |
| `Currency`       | CURRENCY         |
| `Url`            | URL              |