# StorageFileType

Whether this is a file or a folder

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = StorageFileType.File;

// Open enum: use .Of() to create instances from custom string values
var custom = StorageFileType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `File`   | FILE     |
| `Folder` | FOLDER   |