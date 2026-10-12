# LegalMatterStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = LegalMatterStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = LegalMatterStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Pending` | PENDING   |
| `Open`    | OPEN      |
| `Closed`  | CLOSED    |
| `Other`   | OTHER     |