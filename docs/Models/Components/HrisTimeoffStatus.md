# HrisTimeoffStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisTimeoffStatus.Approved;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisTimeoffStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Approved` | APPROVED   |
| `Pending`  | PENDING    |
| `Denied`   | DENIED     |