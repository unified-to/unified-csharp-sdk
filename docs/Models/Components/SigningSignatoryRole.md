# SigningSignatoryRole

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SigningSignatoryRole.Signer;

// Open enum: use .Of() to create instances from custom string values
var custom = SigningSignatoryRole.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Signer`         | SIGNER           |
| `Cc`             | CC               |
| `Approver`       | APPROVER         |
| `InPersonSigner` | IN_PERSON_SIGNER |
| `Viewer`         | VIEWER           |