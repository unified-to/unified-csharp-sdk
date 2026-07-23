# CdpConsentStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpConsentStatus.Granted;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpConsentStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Granted` | GRANTED   |
| `Denied`  | DENIED    |
| `Pending` | PENDING   |