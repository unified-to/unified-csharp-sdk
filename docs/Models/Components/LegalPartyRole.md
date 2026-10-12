# LegalPartyRole

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = LegalPartyRole.Client;

// Open enum: use .Of() to create instances from custom string values
var custom = LegalPartyRole.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Client`          | CLIENT            |
| `OpposingParty`   | OPPOSING_PARTY    |
| `OpposingCounsel` | OPPOSING_COUNSEL  |
| `CoCounsel`       | CO_COUNSEL        |
| `Witness`         | WITNESS           |
| `Expert`          | EXPERT            |
| `Judge`           | JUDGE             |
| `Referrer`        | REFERRER          |
| `Other`           | OTHER             |