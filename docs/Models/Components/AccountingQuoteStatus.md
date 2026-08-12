# AccountingQuoteStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingQuoteStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingQuoteStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Draft`    | DRAFT      |
| `Sent`     | SENT       |
| `Accepted` | ACCEPTED   |
| `Declined` | DECLINED   |
| `Invoiced` | INVOICED   |
| `Expired`  | EXPIRED    |
| `Voided`   | VOIDED     |
| `Deleted`  | DELETED    |