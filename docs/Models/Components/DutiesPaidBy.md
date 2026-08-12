# DutiesPaidBy

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = DutiesPaidBy.Sender;

// Open enum: use .Of() to create instances from custom string values
var custom = DutiesPaidBy.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Sender`     | SENDER       |
| `Recipient`  | RECIPIENT    |
| `ThirdParty` | THIRD_PARTY  |