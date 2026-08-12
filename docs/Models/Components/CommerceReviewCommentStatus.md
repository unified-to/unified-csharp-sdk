# CommerceReviewCommentStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CommerceReviewCommentStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = CommerceReviewCommentStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | PENDING    |
| `Approved` | APPROVED   |
| `Rejected` | REJECTED   |
| `Spam`     | SPAM       |