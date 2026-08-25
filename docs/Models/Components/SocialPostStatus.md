# SocialPostStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SocialPostStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = SocialPostStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Draft`      | DRAFT        |
| `Scheduled`  | SCHEDULED    |
| `Published`  | PUBLISHED    |
| `Rejected`   | REJECTED     |
| `Processing` | PROCESSING   |
| `Deleted`    | DELETED      |
| `Other`      | OTHER        |