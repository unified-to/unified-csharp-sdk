# ComputeDomainStatus

DNS/ownership verification status

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeDomainStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeDomainStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | PENDING    |
| `Verified` | VERIFIED   |
| `Failed`   | FAILED     |
| `Other`    | OTHER      |