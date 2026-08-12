# SigningDocumentStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SigningDocumentStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = SigningDocumentStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Draft`      | DRAFT        |
| `Sent`       | SENT         |
| `Delivered`  | DELIVERED    |
| `InProgress` | IN_PROGRESS  |
| `Completed`  | COMPLETED    |
| `Declined`   | DECLINED     |
| `Voided`     | VOIDED       |
| `Expired`    | EXPIRED      |