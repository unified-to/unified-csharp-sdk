# Recommendation

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Recommendation.DefinitelyNo;

// Open enum: use .Of() to create instances from custom string values
var custom = Recommendation.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `DefinitelyNo` | DEFINITELY_NO  |
| `No`           | NO             |
| `Yes`          | YES            |
| `StrongYes`    | STRONG_YES     |