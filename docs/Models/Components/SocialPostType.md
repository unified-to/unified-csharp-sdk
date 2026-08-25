# SocialPostType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = SocialPostType.Post;

// Open enum: use .Of() to create instances from custom string values
var custom = SocialPostType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Post`   | POST     |
| `Reply`  | REPLY    |
| `Repost` | REPOST   |
| `Quote`  | QUOTE    |
| `Event`  | EVENT    |
| `Offer`  | OFFER    |
| `Alert`  | ALERT    |
| `Story`  | STORY    |
| `Other`  | OTHER    |