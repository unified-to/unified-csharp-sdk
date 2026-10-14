# Messaging

## Overview

### Available Operations

* [CreateMessagingChannel](#createmessagingchannel) - Create a channel
* [CreateMessagingMessage](#createmessagingmessage) - Create a message
* [GetMessagingChannel](#getmessagingchannel) - Retrieve a channel
* [GetMessagingMessage](#getmessagingmessage) - Retrieve a message
* [ListMessagingChannels](#listmessagingchannels) - List all channels
* [ListMessagingMessages](#listmessagingmessages) - List all messages
* [PatchMessagingChannel](#patchmessagingchannel) - Update a channel
* [PatchMessagingEvent](#patchmessagingevent) - Update an event
* [PatchMessagingMessage](#patchmessagingmessage) - Update a message
* [RemoveMessagingChannel](#removemessagingchannel) - Remove a channel
* [RemoveMessagingMessage](#removemessagingmessage) - Remove a message
* [UpdateMessagingChannel](#updatemessagingchannel) - Update a channel
* [UpdateMessagingEvent](#updatemessagingevent) - Update an event
* [UpdateMessagingMessage](#updatemessagingmessage) - Update a message

## CreateMessagingChannel

Create a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMessagingChannel" method="post" path="/messaging/{connection_id}/channel" example="messaging_channel" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Messaging.CreateMessagingChannelAsync(
    messagingChannel: new MessagingChannel() {
        CreatedAt = System.DateTime.Parse("2023-10-05T02:09:22.795Z").ToUniversalTime(),
        Description = "Dolores tutis.",
        HasSubchannels = true,
        Id = "0c41e502-c8f1-4bde-b870-fbcc6d7d38bf",
        IsActive = false,
        IsPrivate = true,
        Members = new List<MessagingMember>() {},
        Name = "tego",
        UpdatedAt = System.DateTime.Parse("2026-05-15T10:14:59.745Z").ToUniversalTime(),
        WebUrl = "https://svelte-rule.name/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MessagingChannel`                                                                                                                               | [MessagingChannel](../../Models/Components/MessagingChannel.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMessagingChannelQueryParamFields](../../Models/Requests/CreateMessagingChannelQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMessagingChannelResponse](../../Models/Requests/CreateMessagingChannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateMessagingMessage

Create a message

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMessagingMessage" method="post" path="/messaging/{connection_id}/message" example="messaging_message" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Messaging.CreateMessagingMessageAsync(
    messagingMessage: new MessagingMessage() {
        Attachments = new List<MessagingAttachment>() {
            new MessagingAttachment() {
                ContentIdentifier = "547872f6-61b3-4e24-a426-9235562a36b6",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "8c221744-9d27-4871-92e8-da4d3bfaa373",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "13ed7545-8621-44e6-b5c8-f3cf7586896f",
                Text = "denuo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "8c221744-9d27-4871-92e8-da4d3bfaa373",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Reactions = new List<MessagingReaction>() {},
        Reference = "571483f2-d95b-4f06-8b78-d35e7046bb74",
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-15T02:45:39.045Z").ToUniversalTime(),
        WebUrl = "https://grumpy-kit.net",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MessagingMessage`                                                                                                                               | [MessagingMessage](../../Models/Components/MessagingMessage.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMessagingMessageQueryParamFields](../../Models/Requests/CreateMessagingMessageQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMessagingMessageResponse](../../Models/Requests/CreateMessagingMessageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMessagingChannel

Retrieve a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMessagingChannel" method="get" path="/messaging/{connection_id}/channel/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Messaging.GetMessagingChannelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Channel                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetMessagingChannelQueryParamFields](../../Models/Requests/GetMessagingChannelQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMessagingChannelResponse](../../Models/Requests/GetMessagingChannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMessagingMessage

Retrieve a message

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMessagingMessage" method="get" path="/messaging/{connection_id}/message/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Messaging.GetMessagingMessageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Message                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetMessagingMessageQueryParamFields](../../Models/Requests/GetMessagingMessageQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMessagingMessageResponse](../../Models/Requests/GetMessagingMessageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMessagingChannels

List all channels

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMessagingChannels" method="get" path="/messaging/{connection_id}/channel" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMessagingChannelsRequest req = new ListMessagingChannelsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Messaging.ListMessagingChannelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListMessagingChannelsRequest](../../Models/Requests/ListMessagingChannelsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListMessagingChannelsResponse](../../Models/Requests/ListMessagingChannelsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMessagingMessages

List all messages

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMessagingMessages" method="get" path="/messaging/{connection_id}/message" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMessagingMessagesRequest req = new ListMessagingMessagesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Messaging.ListMessagingMessagesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListMessagingMessagesRequest](../../Models/Requests/ListMessagingMessagesRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListMessagingMessagesResponse](../../Models/Requests/ListMessagingMessagesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMessagingChannel

Update a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingChannel" method="patch" path="/messaging/{connection_id}/channel/{id}" example="messaging_channel" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMessagingChannelRequest req = new PatchMessagingChannelRequest() {
    MessagingChannel = new MessagingChannel() {
        CreatedAt = System.DateTime.Parse("2023-10-05T02:09:22.795Z").ToUniversalTime(),
        Description = "Dolores tutis.",
        HasSubchannels = true,
        Id = "eb8633c7-5b5e-4d4b-a5a6-2ba403d96bf3",
        IsActive = false,
        IsPrivate = true,
        Members = new List<MessagingMember>() {},
        Name = "tego",
        UpdatedAt = System.DateTime.Parse("2026-05-15T10:14:59.755Z").ToUniversalTime(),
        WebUrl = "https://svelte-rule.name/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Messaging.PatchMessagingChannelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchMessagingChannelRequest](../../Models/Requests/PatchMessagingChannelRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchMessagingChannelResponse](../../Models/Requests/PatchMessagingChannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMessagingEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingEvent" method="patch" path="/messaging/{connection_id}/event/{id}" example="messaging_event" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMessagingEventRequest req = new PatchMessagingEventRequest() {
    MessagingEvent = new MessagingEvent() {
        Channel = new PropertyMessagingEventChannel() {
            Id = "",
            Name = "",
        },
        CreatedAt = System.DateTime.Parse("2019-05-30T19:44:46.461Z").ToUniversalTime(),
        Id = "5fed2715-bca9-40c9-9c1f-76d029854001",
        IsReplacingOriginal = false,
        Type = MessagingEventType.ButtonClick,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Messaging.PatchMessagingEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchMessagingEventRequest](../../Models/Requests/PatchMessagingEventRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchMessagingEventResponse](../../Models/Requests/PatchMessagingEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMessagingMessage

Update a message

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingMessage" method="patch" path="/messaging/{connection_id}/message/{id}" example="messaging_message" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMessagingMessageRequest req = new PatchMessagingMessageRequest() {
    MessagingMessage = new MessagingMessage() {
        Attachments = new List<MessagingAttachment>() {
            new MessagingAttachment() {
                ContentIdentifier = "06ac7d73-5235-43d1-84d2-39729d545be6",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "9640b9a0-51e4-4ccb-b03b-d4a39659013d",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "72f8430e-fb1d-4b10-975c-d9b35a4b18b2",
                Text = "denuo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "9640b9a0-51e4-4ccb-b03b-d4a39659013d",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Reactions = new List<MessagingReaction>() {},
        Reference = "571483f2-d95b-4f06-8b78-d35e7046bb74",
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-15T02:45:39.059Z").ToUniversalTime(),
        WebUrl = "https://grumpy-kit.net",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Messaging.PatchMessagingMessageAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchMessagingMessageRequest](../../Models/Requests/PatchMessagingMessageRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchMessagingMessageResponse](../../Models/Requests/PatchMessagingMessageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMessagingChannel

Remove a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMessagingChannel" method="delete" path="/messaging/{connection_id}/channel/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Messaging.RemoveMessagingChannelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Channel    |

### Response

**[RemoveMessagingChannelResponse](../../Models/Requests/RemoveMessagingChannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMessagingMessage

Remove a message

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMessagingMessage" method="delete" path="/messaging/{connection_id}/message/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Messaging.RemoveMessagingMessageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Message    |

### Response

**[RemoveMessagingMessageResponse](../../Models/Requests/RemoveMessagingMessageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMessagingChannel

Update a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingChannel" method="put" path="/messaging/{connection_id}/channel/{id}" example="messaging_channel" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMessagingChannelRequest req = new UpdateMessagingChannelRequest() {
    MessagingChannel = new MessagingChannel() {
        CreatedAt = System.DateTime.Parse("2023-10-05T02:09:22.795Z").ToUniversalTime(),
        Description = "Dolores tutis.",
        HasSubchannels = true,
        Id = "eb8633c7-5b5e-4d4b-a5a6-2ba403d96bf3",
        IsActive = false,
        IsPrivate = true,
        Members = new List<MessagingMember>() {},
        Name = "tego",
        UpdatedAt = System.DateTime.Parse("2026-05-15T10:14:59.755Z").ToUniversalTime(),
        WebUrl = "https://svelte-rule.name/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Messaging.UpdateMessagingChannelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateMessagingChannelRequest](../../Models/Requests/UpdateMessagingChannelRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateMessagingChannelResponse](../../Models/Requests/UpdateMessagingChannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMessagingEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingEvent" method="put" path="/messaging/{connection_id}/event/{id}" example="messaging_event" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMessagingEventRequest req = new UpdateMessagingEventRequest() {
    MessagingEvent = new MessagingEvent() {
        Channel = new PropertyMessagingEventChannel() {
            Id = "",
            Name = "",
        },
        CreatedAt = System.DateTime.Parse("2019-05-30T19:44:46.461Z").ToUniversalTime(),
        Id = "5fed2715-bca9-40c9-9c1f-76d029854001",
        IsReplacingOriginal = false,
        Type = MessagingEventType.ButtonClick,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Messaging.UpdateMessagingEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateMessagingEventRequest](../../Models/Requests/UpdateMessagingEventRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateMessagingEventResponse](../../Models/Requests/UpdateMessagingEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMessagingMessage

Update a message

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingMessage" method="put" path="/messaging/{connection_id}/message/{id}" example="messaging_message" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMessagingMessageRequest req = new UpdateMessagingMessageRequest() {
    MessagingMessage = new MessagingMessage() {
        Attachments = new List<MessagingAttachment>() {
            new MessagingAttachment() {
                ContentIdentifier = "06ac7d73-5235-43d1-84d2-39729d545be6",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "9640b9a0-51e4-4ccb-b03b-d4a39659013d",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "72f8430e-fb1d-4b10-975c-d9b35a4b18b2",
                Text = "denuo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "9640b9a0-51e4-4ccb-b03b-d4a39659013d",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Reactions = new List<MessagingReaction>() {},
        Reference = "571483f2-d95b-4f06-8b78-d35e7046bb74",
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-15T02:45:39.059Z").ToUniversalTime(),
        WebUrl = "https://grumpy-kit.net",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Messaging.UpdateMessagingMessageAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateMessagingMessageRequest](../../Models/Requests/UpdateMessagingMessageRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateMessagingMessageResponse](../../Models/Requests/UpdateMessagingMessageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |