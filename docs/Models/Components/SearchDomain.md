# SearchDomain

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SearchDomain.SupportedRequired;

// Open enum: use .Of() to create instances from custom string values
var custom = SearchDomain.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `SupportedRequired` | supported-required  |
| `Supported`         | supported           |
| `NotSupported`      | not-supported       |