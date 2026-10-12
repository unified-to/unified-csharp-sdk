# ComputeServiceType

The kind of service

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeServiceType.Web;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeServiceType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Web`     | WEB       |
| `Worker`  | WORKER    |
| `Cron`    | CRON      |
| `Static`  | STATIC    |
| `Private` | PRIVATE   |
| `Other`   | OTHER     |