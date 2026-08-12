# ObjectType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ObjectType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = ObjectType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Invoice` | INVOICE   |
| `Bill`    | BILL      |