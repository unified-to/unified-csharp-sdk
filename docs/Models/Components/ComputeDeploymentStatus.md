# ComputeDeploymentStatus

Normalized deployment status; set to CANCELED on update to cancel

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeDeploymentStatus.Queued;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeDeploymentStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Queued`     | QUEUED       |
| `Building`   | BUILDING     |
| `Deploying`  | DEPLOYING    |
| `Live`       | LIVE         |
| `Failed`     | FAILED       |
| `Canceled`   | CANCELED     |
| `Superseded` | SUPERSEDED   |
| `Other`      | OTHER        |