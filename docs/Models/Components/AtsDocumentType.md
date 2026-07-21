# AtsDocumentType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsDocumentType.Resume;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsDocumentType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Resume`       | RESUME         |
| `CoverLetter`  | COVER_LETTER   |
| `OfferPacket`  | OFFER_PACKET   |
| `OfferLetter`  | OFFER_LETTER   |
| `TakeHomeTest` | TAKE_HOME_TEST |
| `Other`        | OTHER          |