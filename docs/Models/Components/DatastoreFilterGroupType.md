# DatastoreFilterGroupType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = DatastoreFilterGroupType.Filter;

// Open enum: use .Of() to create instances from custom string values
var custom = DatastoreFilterGroupType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Filter` | FILTER   |
| `And`    | AND      |
| `Or`     | OR       |