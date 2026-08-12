# RegistrationStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = RegistrationStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = RegistrationStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | PENDING     |
| `Approved`  | APPROVED    |
| `Rejected`  | REJECTED    |
| `Cancelled` | CANCELLED   |