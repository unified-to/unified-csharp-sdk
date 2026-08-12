# PaymentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PaymentType.Direct;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Direct` | DIRECT   |
| `Cheque` | CHEQUE   |
| `Cash`   | CASH     |