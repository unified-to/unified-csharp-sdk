# AnalyticsReportMetricsType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AnalyticsReportMetricsType.Users;

// Open enum: use .Of() to create instances from custom string values
var custom = AnalyticsReportMetricsType.Of("custom_value");
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `Users`                   | USERS                     |
| `NewUsers`                | NEW_USERS                 |
| `Sessions`                | SESSIONS                  |
| `PageViews`               | PAGE_VIEWS                |
| `UniquePageViews`         | UNIQUE_PAGE_VIEWS         |
| `Screens`                 | SCREENS                   |
| `Events`                  | EVENTS                    |
| `AverageSessionDuration`  | AVERAGE_SESSION_DURATION  |
| `PagesPerSession`         | PAGES_PER_SESSION         |
| `BounceRate`              | BOUNCE_RATE               |
| `EngagementRate`          | ENGAGEMENT_RATE           |
| `EventsPerSession`        | EVENTS_PER_SESSION        |
| `Conversions`             | CONVERSIONS               |
| `ConversionRate`          | CONVERSION_RATE           |
| `GoalCompletions`         | GOAL_COMPLETIONS          |
| `GoalValue`               | GOAL_VALUE                |
| `Transactions`            | TRANSACTIONS              |
| `Revenue`                 | REVENUE                   |
| `AverageOrderValue`       | AVERAGE_ORDER_VALUE       |
| `EcommerceConversionRate` | ECOMMERCE_CONVERSION_RATE |
| `SessionsBySource`        | SESSIONS_BY_SOURCE        |
| `UsersBySource`           | USERS_BY_SOURCE           |
| `ConversionsBySource`     | CONVERSIONS_BY_SOURCE     |
| `VideoViews`              | VIDEO_VIEWS               |
| `WatchTime`               | WATCH_TIME                |
| `AverageViewDuration`     | AVERAGE_VIEW_DURATION     |
| `AverageViewPercentage`   | AVERAGE_VIEW_PERCENTAGE   |
| `Likes`                   | LIKES                     |
| `Dislikes`                | DISLIKES                  |
| `Comments`                | COMMENTS                  |
| `Shares`                  | SHARES                    |
| `SubscribersGained`       | SUBSCRIBERS_GAINED        |
| `SubscribersLost`         | SUBSCRIBERS_LOST          |