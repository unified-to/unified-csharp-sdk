# Message

## Overview

### Available Operations

* [CreateMessagingMessage](#createmessagingmessage) - Create a message
* [GetMessagingMessage](#getmessagingmessage) - Retrieve a message
* [ListMessagingMessages](#listmessagingmessages) - List all messages
* [PatchMessagingMessage](#patchmessagingmessage) - Update a message
* [RemoveMessagingMessage](#removemessagingmessage) - Remove a message
* [UpdateMessagingMessage](#updatemessagingmessage) - Update a message

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

var res = await sdk.Message.CreateMessagingMessageAsync(
    messagingMessage: new MessagingMessage() {
        Attachments = new List<MessagingAttachment>() {
            new MessagingAttachment() {
                ContentIdentifier = "ef3f64ac-140c-41e3-94c9-1c6604f60a5f",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "e13c69ad-a43f-4b9c-a7cd-0631dacd0498",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "8d6c57d3-f091-4711-8d8e-e59039084998",
                Text = "denuo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "e13c69ad-a43f-4b9c-a7cd-0631dacd0498",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Reactions = new List<MessagingReaction>() {},
        Reference = "571483f2-d95b-4f06-8b78-d35e7046bb74",
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-14T17:08:23.000Z").ToUniversalTime(),
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

var res = await sdk.Message.GetMessagingMessageAsync(
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

var res = await sdk.Message.ListMessagingMessagesAsync(req);

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
                ContentIdentifier = "a7457040-f645-4e83-92c4-ce4e57fd6015",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "6288c40e-281e-4f58-9dcb-d0a9757b1347",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "2a2499ea-2cc7-4609-89fa-1c34c2c8f841",
                Text = "denuo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "6288c40e-281e-4f58-9dcb-d0a9757b1347",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Reactions = new List<MessagingReaction>() {},
        Reference = "571483f2-d95b-4f06-8b78-d35e7046bb74",
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-14T17:08:23.015Z").ToUniversalTime(),
        WebUrl = "https://grumpy-kit.net",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Message.PatchMessagingMessageAsync(req);

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

var res = await sdk.Message.RemoveMessagingMessageAsync(
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
                ContentIdentifier = "a7457040-f645-4e83-92c4-ce4e57fd6015",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "6288c40e-281e-4f58-9dcb-d0a9757b1347",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "2a2499ea-2cc7-4609-89fa-1c34c2c8f841",
                Text = "denuo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "6288c40e-281e-4f58-9dcb-d0a9757b1347",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Reactions = new List<MessagingReaction>() {},
        Reference = "571483f2-d95b-4f06-8b78-d35e7046bb74",
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-14T17:08:23.015Z").ToUniversalTime(),
        WebUrl = "https://grumpy-kit.net",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Message.UpdateMessagingMessageAsync(req);

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