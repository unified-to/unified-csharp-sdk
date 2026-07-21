# ClubsEventStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ClubsEventStatus.Scheduled;

// Open enum: use .Of() to create instances from custom string values
var custom = ClubsEventStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Scheduled` | SCHEDULED   |
| `Canceled`  | CANCELED    |
| `Tbd`       | TBD         |
| `Final`     | FINAL       |