# Environment

Target environment

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Environment.Production;

// Open enum: use .Of() to create instances from custom string values
var custom = Environment.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Production`  | PRODUCTION    |
| `Preview`     | PREVIEW       |
| `Development` | DEVELOPMENT   |
| `Other`       | OTHER         |