# ClubsMemberMembershipStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ClubsMemberMembershipStatus.Member;

// Open enum: use .Of() to create instances from custom string values
var custom = ClubsMemberMembershipStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Member`  | MEMBER    |
| `Pending` | PENDING   |
| `None`    | NONE      |