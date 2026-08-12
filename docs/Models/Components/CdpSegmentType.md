# CdpSegmentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpSegmentType.Users;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpSegmentType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Users`    | USERS      |
| `Accounts` | ACCOUNTS   |
| `Linked`   | LINKED     |