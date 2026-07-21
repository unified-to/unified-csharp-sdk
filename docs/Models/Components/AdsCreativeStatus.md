# AdsCreativeStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AdsCreativeStatus.Unspecified;

// Open enum: use .Of() to create instances from custom string values
var custom = AdsCreativeStatus.Of("custom_value");
```


## Values

| Name                   | Value                  |
| ---------------------- | ---------------------- |
| `Unspecified`          | UNSPECIFIED            |
| `Active`               | ACTIVE                 |
| `Paused`               | PAUSED                 |
| `Archived`             | ARCHIVED               |
| `Draft`                | DRAFT                  |
| `ScheduledForDeletion` | SCHEDULED_FOR_DELETION |
| `Processing`           | PROCESSING             |
| `ProcessingFailed`     | PROCESSING_FAILED      |