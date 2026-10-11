# AccountingJournalStatus

Posting state of the journal entry

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingJournalStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingJournalStatus.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Draft`  | DRAFT    |
| `Posted` | POSTED   |
| `Void`   | VOID     |
| `Other`  | OTHER    |