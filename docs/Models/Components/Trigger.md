# Trigger

What started the deployment

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Trigger.Git;

// Open enum: use .Of() to create instances from custom string values
var custom = Trigger.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Git`      | GIT        |
| `Manual`   | MANUAL     |
| `Api`      | API        |
| `Rollback` | ROLLBACK   |
| `Other`    | OTHER      |