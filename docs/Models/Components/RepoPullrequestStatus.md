# RepoPullrequestStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = RepoPullrequestStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = RepoPullrequestStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | PENDING    |
| `Approved` | APPROVED   |
| `Rejected` | REJECTED   |