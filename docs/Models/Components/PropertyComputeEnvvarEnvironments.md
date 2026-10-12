# PropertyComputeEnvvarEnvironments

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = PropertyComputeEnvvarEnvironments.Production;

// Open enum: use .Of() to create instances from custom string values
var custom = PropertyComputeEnvvarEnvironments.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Production`  | PRODUCTION    |
| `Preview`     | PREVIEW       |
| `Development` | DEVELOPMENT   |
| `Other`       | OTHER         |