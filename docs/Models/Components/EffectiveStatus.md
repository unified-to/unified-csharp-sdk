# EffectiveStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = EffectiveStatus.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = EffectiveStatus.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Unspecified`   | UNSPECIFIED     |
| `Serving`       | SERVING         |
| `Limited`       | LIMITED         |
| `Learning`      | LEARNING        |
| `Paused`        | PAUSED          |
| `Pending`       | PENDING         |
| `Ended`         | ENDED           |
| `Misconfigured` | MISCONFIGURED   |
| `NotEligible`   | NOT_ELIGIBLE    |
| `Archived`      | ARCHIVED        |
| `Removed`       | REMOVED         |