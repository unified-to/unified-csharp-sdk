# NonDeliveryOption

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = NonDeliveryOption.Return;

// Open enum: use .Of() to create instances from custom string values
var custom = NonDeliveryOption.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Return`  | RETURN    |
| `Abandon` | ABANDON   |