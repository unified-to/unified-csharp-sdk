# ReturnType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ReturnType.Customer;

// Open enum: use .Of() to create instances from custom string values
var custom = ReturnType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Customer`  | CUSTOMER    |
| `Vendor`    | VENDOR      |
| `Warranty`  | WARRANTY    |
| `Defective` | DEFECTIVE   |
| `Other`     | OTHER       |