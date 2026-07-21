# BillingEvent

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = BillingEvent.Impressions;

// Open enum: use .Of() to create instances from custom string values
var custom = BillingEvent.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Impressions`    | IMPRESSIONS      |
| `LinkClicks`     | LINK_CLICKS      |
| `VideoViews`     | VIDEO_VIEWS      |
| `AppInstalls`    | APP_INSTALLS     |
| `Engagement`     | ENGAGEMENT       |
| `PageLikes`      | PAGE_LIKES       |
| `Messages`       | MESSAGES         |
| `PostEngagement` | POST_ENGAGEMENT  |
| `Purchase`       | PURCHASE         |
| `None`           | NONE             |