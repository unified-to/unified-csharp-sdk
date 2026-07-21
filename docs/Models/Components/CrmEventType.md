# CrmEventType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CrmEventType.Note;

// Open enum: use .Of() to create instances from custom string values
var custom = CrmEventType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Note`           | NOTE             |
| `Email`          | EMAIL            |
| `Task`           | TASK             |
| `Meeting`        | MEETING          |
| `Call`           | CALL             |
| `MarketingEmail` | MARKETING_EMAIL  |
| `Form`           | FORM             |
| `PageView`       | PAGE_VIEW        |