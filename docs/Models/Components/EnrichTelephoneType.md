# EnrichTelephoneType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = EnrichTelephoneType.Work;

// Open enum: use .Of() to create instances from custom string values
var custom = EnrichTelephoneType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Work`   | WORK     |
| `Home`   | HOME     |
| `Other`  | OTHER    |
| `Fax`    | FAX      |
| `Mobile` | MOBILE   |