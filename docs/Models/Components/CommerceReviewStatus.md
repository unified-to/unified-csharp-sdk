# CommerceReviewStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CommerceReviewStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = CommerceReviewStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | PENDING    |
| `Approved` | APPROVED   |
| `Rejected` | REJECTED   |
| `Spam`     | SPAM       |