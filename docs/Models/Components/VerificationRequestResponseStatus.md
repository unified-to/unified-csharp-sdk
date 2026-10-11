# VerificationRequestResponseStatus

Background checks and compliance checks return CLEARFLAGGED or PASS/FAIL or YES/NO

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = VerificationRequestResponseStatus.Completed;

// Open enum: use .Of() to create instances from custom string values
var custom = VerificationRequestResponseStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Completed` | COMPLETED   |
| `Failed`    | FAILED      |
| `Passed`    | PASSED      |
| `Pending`   | PENDING     |