# HealthcareAppointmentStatus

Status of the appointment

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HealthcareAppointmentStatus.Proposed;

// Open enum: use .Of() to create instances from custom string values
var custom = HealthcareAppointmentStatus.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Proposed`       | PROPOSED         |
| `Pending`        | PENDING          |
| `Booked`         | BOOKED           |
| `Arrived`        | ARRIVED          |
| `CheckedIn`      | CHECKED_IN       |
| `Fulfilled`      | FULFILLED        |
| `Cancelled`      | CANCELLED        |
| `Noshow`         | NOSHOW           |
| `Waitlist`       | WAITLIST         |
| `EnteredInError` | ENTERED_IN_ERROR |
| `Other`          | OTHER            |