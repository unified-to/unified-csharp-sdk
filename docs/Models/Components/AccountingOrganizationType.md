# AccountingOrganizationType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingOrganizationType.Company;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingOrganizationType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Company`    | COMPANY      |
| `Subsidiary` | SUBSIDIARY   |
| `Division`   | DIVISION     |
| `Location`   | LOCATION     |