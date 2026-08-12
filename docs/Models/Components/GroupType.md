# GroupType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = GroupType.CasualClub;

// Open enum: use .Of() to create instances from custom string values
var custom = GroupType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `CasualClub` | CASUAL_CLUB  |
| `RacingTeam` | RACING_TEAM  |
| `Shop`       | SHOP         |
| `Company`    | COMPANY      |
| `Other`      | OTHER        |