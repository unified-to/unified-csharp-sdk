# CommerceReservationStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CommerceReservationStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = CommerceReservationStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | PENDING     |
| `Confirmed` | CONFIRMED   |
| `Cancelled` | CANCELLED   |
| `NoShow`    | NO_SHOW     |
| `Completed` | COMPLETED   |