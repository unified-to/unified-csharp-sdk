# UcCallInstructionType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = UcCallInstructionType.Say;

// Open enum: use .Of() to create instances from custom string values
var custom = UcCallInstructionType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Say`    | SAY      |
| `Play`   | PLAY     |
| `Pause`  | PAUSE    |
| `Dial`   | DIAL     |
| `Hangup` | HANGUP   |