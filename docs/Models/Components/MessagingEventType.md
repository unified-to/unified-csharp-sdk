# MessagingEventType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = MessagingEventType.MessageReceived;

// Open enum: use .Of() to create instances from custom string values
var custom = MessagingEventType.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `MessageReceived` | MESSAGE_RECEIVED  |
| `ReactionAdded`   | REACTION_ADDED    |
| `ReactionRemoved` | REACTION_REMOVED  |
| `ButtonClick`     | BUTTON_CLICK      |
| `AppMention`      | APP_MENTION       |
| `ChannelJoined`   | CHANNEL_JOINED    |
| `ChannelLeft`     | CHANNEL_LEFT      |
| `ChannelCreated`  | CHANNEL_CREATED   |
| `ChannelDeleted`  | CHANNEL_DELETED   |
| `ChannelRenamed`  | CHANNEL_RENAMED   |
| `UserCreated`     | USER_CREATED      |
| `UserDeleted`     | USER_DELETED      |
| `UserUpdated`     | USER_UPDATED      |