# ComputeTemplateStatus

Normalized build status

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeTemplateStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeTemplateStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | PENDING    |
| `Building` | BUILDING   |
| `Ready`    | READY      |
| `Failed`   | FAILED     |
| `Other`    | OTHER      |