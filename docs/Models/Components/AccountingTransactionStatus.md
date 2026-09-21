# AccountingTransactionStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AccountingTransactionStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingTransactionStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Pending` | PENDING   |
| `Posted`  | POSTED    |
| `Void`    | VOID      |
| `Other`   | OTHER     |