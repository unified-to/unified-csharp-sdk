# AdsGroupEffectiveStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AdsGroupEffectiveStatus.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = AdsGroupEffectiveStatus.Of("custom_value");
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