# SigningSignatoryStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SigningSignatoryStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = SigningSignatoryStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | PENDING     |
| `Sent`      | SENT        |
| `Delivered` | DELIVERED   |
| `Signed`    | SIGNED      |
| `Declined`  | DECLINED    |
| `Error`     | ERROR       |