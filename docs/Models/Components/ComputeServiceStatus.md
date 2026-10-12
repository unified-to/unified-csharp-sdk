# ComputeServiceStatus

Normalized status; set to SUSPENDED or LIVE on update to suspend or resume

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeServiceStatus.Creating;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeServiceStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Creating`  | CREATING    |
| `Deploying` | DEPLOYING   |
| `Live`      | LIVE        |
| `Suspended` | SUSPENDED   |
| `Failed`    | FAILED      |
| `Other`     | OTHER       |