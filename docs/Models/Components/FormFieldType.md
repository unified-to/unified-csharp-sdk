# FormFieldType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = FormFieldType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = FormFieldType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Text`           | TEXT             |
| `Textarea`       | TEXTAREA         |
| `Number`         | NUMBER           |
| `Email`          | EMAIL            |
| `Url`            | URL              |
| `Date`           | DATE             |
| `Time`           | TIME             |
| `Datetime`       | DATETIME         |
| `Phone`          | PHONE            |
| `Boolean`        | BOOLEAN          |
| `SingleSelect`   | SINGLE_SELECT    |
| `MultipleSelect` | MULTIPLE_SELECT  |
| `FileUpload`     | FILE_UPLOAD      |
| `Rating`         | RATING           |
| `Scale`          | SCALE            |
| `Matrix`         | MATRIX           |
| `SectionHeader`  | SECTION_HEADER   |
| `Other`          | OTHER            |