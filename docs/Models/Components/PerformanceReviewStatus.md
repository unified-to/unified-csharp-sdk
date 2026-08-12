# PerformanceReviewStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PerformanceReviewStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = PerformanceReviewStatus.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Draft`        | DRAFT          |
| `InProgress`   | IN_PROGRESS    |
| `Submitted`    | SUBMITTED      |
| `Completed`    | COMPLETED      |
| `Shared`       | SHARED         |
| `Acknowledged` | ACKNOWLEDGED   |
| `Other`        | OTHER          |