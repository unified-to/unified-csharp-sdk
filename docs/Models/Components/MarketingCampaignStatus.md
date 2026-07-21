# MarketingCampaignStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = MarketingCampaignStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = MarketingCampaignStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Draft`     | DRAFT       |
| `Scheduled` | SCHEDULED   |
| `Sending`   | SENDING     |
| `Sent`      | SENT        |
| `Cancelled` | CANCELLED   |
| `Paused`    | PAUSED      |
| `Archived`  | ARCHIVED    |
| `Other`     | OTHER       |