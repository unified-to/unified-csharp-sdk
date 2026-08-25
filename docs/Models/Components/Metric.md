# Metric

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Metric.Followers;

// Open enum: use .Of() to create instances from custom string values
var custom = Metric.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Followers`    | FOLLOWERS      |
| `Following`    | FOLLOWING      |
| `Posts`        | POSTS          |
| `Impressions`  | IMPRESSIONS    |
| `Reach`        | REACH          |
| `Engagement`   | ENGAGEMENT     |
| `ProfileViews` | PROFILE_VIEWS  |
| `Clicks`       | CLICKS         |
| `VideoViews`   | VIDEO_VIEWS    |
| `Likes`        | LIKES          |
| `Comments`     | COMMENTS       |
| `Shares`       | SHARES         |
| `Saves`        | SAVES          |
| `Other`        | OTHER          |