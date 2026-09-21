# Reason

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Reason.Duplicate;

// Open enum: use .Of() to create instances from custom string values
var custom = Reason.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Duplicate`           | DUPLICATE             |
| `Fraudulent`          | FRAUDULENT            |
| `RequestedByCustomer` | REQUESTED_BY_CUSTOMER |
| `Other`               | OTHER                 |