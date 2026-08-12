# AccountType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountType.Checking;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Checking` | CHECKING   |
| `Savings`  | SAVINGS    |