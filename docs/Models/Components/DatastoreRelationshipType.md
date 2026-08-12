# DatastoreRelationshipType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = DatastoreRelationshipType.One;

// Open enum: use .Of() to create instances from custom string values
var custom = DatastoreRelationshipType.Of("custom_value");
```


## Values

| Name   | Value  |
| ------ | ------ |
| `One`  | ONE    |
| `Many` | MANY   |