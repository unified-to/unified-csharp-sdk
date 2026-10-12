# Criticality

Potential severity of future reactions

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Criticality.Low;

// Open enum: use .Of() to create instances from custom string values
var custom = Criticality.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Low`            | LOW              |
| `High`           | HIGH             |
| `UnableToAssess` | UNABLE_TO_ASSESS |
| `Other`          | OTHER            |