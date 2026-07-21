# UcCallType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = UcCallType.Inbound;

// Open enum: use .Of() to create instances from custom string values
var custom = UcCallType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Inbound`  | INBOUND    |
| `Outbound` | OUTBOUND   |