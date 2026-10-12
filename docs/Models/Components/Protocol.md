# Protocol

The protocol served on this port

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Protocol.Http;

// Open enum: use .Of() to create instances from custom string values
var custom = Protocol.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Http`  | HTTP    |
| `Https` | HTTPS   |
| `Tcp`   | TCP     |
| `Udp`   | UDP     |
| `Other` | OTHER   |