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

Creates a MessagingMessage. Provide the unified MessagingMessage fields in the request body; they are mapped to the provider's API. Returns the created MessagingMessage.

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
                ContentIdentifier = "122d1178-bab0-446e-8334-54d24e73e7b9",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "91664b22-eec6-49a9-beb3-5411c259e2d8",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "b2e16619-41d7-43dc-bca1-670849e9ec0c",
                Text = "comparo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "91664b22-eec6-49a9-beb3-5411c259e2d8",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Metadata = new List<MessagingMetadata>() {},
        Reactions = new List<MessagingReaction>() {},
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-19T12:14:46.971Z").ToUniversalTime(),
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

Retrieves a single MessagingMessage by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of MessagingMessages. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the MessagingMessage identified by `id`. Provide the unified MessagingMessage fields to change in the request body.

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
                ContentIdentifier = "a433fece-5aa4-43a2-a298-effc3359e69c",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "cb272848-a463-465d-b383-9e2ddc690d46",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "25da63b5-0f29-49a0-b3ae-b8a960bb0b68",
                Text = "comparo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "cb272848-a463-465d-b383-9e2ddc690d46",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Metadata = new List<MessagingMetadata>() {},
        Reactions = new List<MessagingReaction>() {},
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-19T12:14:46.985Z").ToUniversalTime(),
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

Deletes the MessagingMessage identified by `id`.

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

Updates the MessagingMessage identified by `id`. Provide the unified MessagingMessage fields to change in the request body.

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
                ContentIdentifier = "a433fece-5aa4-43a2-a298-effc3359e69c",
                ContentType = "coaegresco",
                DownloadUrl = "https://rotating-advertisement.org",
                Filename = "super",
                MessageId = "cb272848-a463-465d-b383-9e2ddc690d46",
                Size = 327D,
            },
        },
        Buttons = new List<MessagingButton>() {
            new MessagingButton() {
                Id = "25da63b5-0f29-49a0-b3ae-b8a960bb0b68",
                Text = "comparo",
            },
        },
        CreatedAt = System.DateTime.Parse("2021-11-26T09:26:33.973Z").ToUniversalTime(),
        DestinationMembers = new List<MessagingMember>() {},
        HasChildren = true,
        HiddenMembers = new List<MessagingMember>() {},
        Id = "cb272848-a463-465d-b383-9e2ddc690d46",
        IsUnread = false,
        MentionedMembers = new List<MessagingMember>() {},
        Message = "Sum utique aliquid.",
        MessageHtml = "Articulus tardus tergiversatio.",
        MessageMarkdown = "Territo uterque tergo curiositas.",
        Metadata = new List<MessagingMetadata>() {},
        Reactions = new List<MessagingReaction>() {},
        Subject = "Cernuus optio cohaero summisse in.",
        UpdatedAt = System.DateTime.Parse("2023-07-19T12:14:46.985Z").ToUniversalTime(),
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