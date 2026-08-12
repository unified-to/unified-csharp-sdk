# ApiCallType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ApiCallType.Login;

// Open enum: use .Of() to create instances from custom string values
var custom = ApiCallType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Login`   | login     |
| `Webhook` | webhook   |
| `Inbound` | inbound   |
| `Mcp`     | mcp       |