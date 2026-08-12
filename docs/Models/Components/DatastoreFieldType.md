# DatastoreFieldType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = DatastoreFieldType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = DatastoreFieldType.Of("custom_value");
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
| `Currency`       | CURRENCY         |
| `Url`            | URL              |
| `Email`          | EMAIL            |
| `Phone`          | PHONE            |
| `LinkedRecord`   | LINKED_RECORD    |
| `Relation`       | RELATION         |