# MatchType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = MatchType.Broad;

// Open enum: use .Of() to create instances from custom string values
var custom = MatchType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Broad`  | BROAD    |
| `Phrase` | PHRASE   |
| `Exact`  | EXACT    |