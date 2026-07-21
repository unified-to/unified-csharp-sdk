# AtsOfferStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsOfferStatus.Created;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsOfferStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Created`  | CREATED    |
| `Sent`     | SENT       |
| `Accepted` | ACCEPTED   |
| `Rejected` | REJECTED   |