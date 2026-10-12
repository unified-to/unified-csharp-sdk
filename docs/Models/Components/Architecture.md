# Architecture

CPU architecture

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Architecture.X8664;

// Open enum: use .Of() to create instances from custom string values
var custom = Architecture.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `X8664` | X86_64  |
| `Arm64` | ARM64   |
| `Other` | OTHER   |