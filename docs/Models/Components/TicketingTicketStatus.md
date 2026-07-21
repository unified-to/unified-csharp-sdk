# TicketingTicketStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TicketingTicketStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketingTicketStatus.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Active` | ACTIVE   |
| `Closed` | CLOSED   |