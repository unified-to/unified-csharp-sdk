# AccountingAccountTaxonomyType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingAccountTaxonomyType.Classification;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingAccountTaxonomyType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Classification` | CLASSIFICATION   |
| `Group`          | GROUP            |
| `Subgroup`       | SUBGROUP         |
| `SystemRole`     | SYSTEM_ROLE      |
| `Other`          | OTHER            |