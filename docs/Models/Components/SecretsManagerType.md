# SecretsManagerType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SecretsManagerType.Aws;

// Open enum: use .Of() to create instances from custom string values
var custom = SecretsManagerType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Aws`       | aws         |
| `Azure`     | azure       |
| `Gcp`       | gcp         |
| `Hashicorp` | hashicorp   |
| `Composio`  | composio    |