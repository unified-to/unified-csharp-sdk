# Relationship

Relationship of the patient to the policy holder

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Relationship.Self;

// Open enum: use .Of() to create instances from custom string values
var custom = Relationship.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Self`   | SELF     |
| `Spouse` | SPOUSE   |
| `Child`  | CHILD    |
| `Other`  | OTHER    |