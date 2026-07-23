# CdpActivationStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpActivationStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpActivationStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Active`  | ACTIVE    |
| `Paused`  | PAUSED    |
| `Error`   | ERROR     |
| `Pending` | PENDING   |