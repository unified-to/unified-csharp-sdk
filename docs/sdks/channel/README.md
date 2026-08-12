# Channel

## Overview

### Available Operations

* [CreateMessagingChannel](#createmessagingchannel) - Create a channel
* [GetMessagingChannel](#getmessagingchannel) - Retrieve a channel
* [ListMessagingChannels](#listmessagingchannels) - List all channels
* [PatchMessagingChannel](#patchmessagingchannel) - Update a channel
* [RemoveMessagingChannel](#removemessagingchannel) - Remove a channel
* [UpdateMessagingChannel](#updatemessagingchannel) - Update a channel

## CreateMessagingChannel

Create a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMessagingChannel" method="post" path="/messaging/{connection_id}/channel" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Channel.CreateMessagingChannelAsync(
    messagingChannel: new MessagingChannel() {},
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

var res = await sdk.Channel.GetMessagingChannelAsync(
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

var res = await sdk.Channel.ListMessagingChannelsAsync(req);

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

## PatchMessagingChannel

Update a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMessagingChannel" method="patch" path="/messaging/{connection_id}/channel/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMessagingChannelRequest req = new PatchMessagingChannelRequest() {
    MessagingChannel = new MessagingChannel() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Channel.PatchMessagingChannelAsync(req);

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

var res = await sdk.Channel.RemoveMessagingChannelAsync(
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

## UpdateMessagingChannel

Update a channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMessagingChannel" method="put" path="/messaging/{connection_id}/channel/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMessagingChannelRequest req = new UpdateMessagingChannelRequest() {
    MessagingChannel = new MessagingChannel() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Channel.UpdateMessagingChannelAsync(req);

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