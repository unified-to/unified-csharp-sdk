# ScimAddressType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ScimAddressType.Work;

// Open enum: use .Of() to create instances from custom string values
var custom = ScimAddressType.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Work`  | work    |
| `Home`  | home    |
| `Other` | other   |