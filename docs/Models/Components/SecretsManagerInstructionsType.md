# SecretsManagerInstructionsType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SecretsManagerInstructionsType.Aws;

// Open enum: use .Of() to create instances from custom string values
var custom = SecretsManagerInstructionsType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Aws`          | aws            |
| `Azure`        | azure          |
| `Gcp`          | gcp            |
| `Hashicorp`    | hashicorp      |
| `Composio`     | composio       |
| `Onepassword`  | 1password      |
| `Bitwarden`    | bitwarden      |
| `Doppler`      | doppler        |
| `Akeyless`     | akeyless       |
| `Pipedream`    | pipedream      |
| `Alibabacloud` | alibabacloud   |