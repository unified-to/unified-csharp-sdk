# MembershipStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = MembershipStatus.Member;

// Open enum: use .Of() to create instances from custom string values
var custom = MembershipStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Member`  | MEMBER    |
| `Pending` | PENDING   |
| `None`    | NONE      |