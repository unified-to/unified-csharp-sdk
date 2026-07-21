# LabelFormat

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = LabelFormat.Pdf;

// Open enum: use .Of() to create instances from custom string values
var custom = LabelFormat.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Pdf`    | PDF      |
| `Png`    | PNG      |
| `Zpl`    | ZPL      |
| `Epl2`   | EPL2     |
| `Pdf4X6` | PDF_4X6  |
| `Pdf4X8` | PDF_4X8  |
| `Png4X6` | PNG_4X6  |
| `Png4X8` | PNG_4X8  |