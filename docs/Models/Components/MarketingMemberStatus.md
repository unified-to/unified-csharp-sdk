# MarketingMemberStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = MarketingMemberStatus.Subscribed;

// Open enum: use .Of() to create instances from custom string values
var custom = MarketingMemberStatus.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Subscribed`    | SUBSCRIBED      |
| `Unsubscribed`  | UNSUBSCRIBED    |
| `Cleaned`       | CLEANED         |
| `Pending`       | PENDING         |
| `Transactional` | TRANSACTIONAL   |