# Goal

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Goal.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = Goal.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Unspecified`    | UNSPECIFIED      |
| `BrandAwareness` | BRAND_AWARENESS  |
| `Engagement`     | ENGAGEMENT       |
| `Reach`          | REACH            |
| `WebsiteTraffic` | WEBSITE_TRAFFIC  |
| `Leads`          | LEADS            |
| `Sales`          | SALES            |
| `AppPromotion`   | APP_PROMOTION    |