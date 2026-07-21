# Webhook

## Overview

### Available Operations

* [CreateUnifiedWebhook](#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedWebhook](#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedWebhooks](#listunifiedwebhooks) - Returns all registered webhooks
* [PatchUnifiedWebhook](#patchunifiedwebhook) - Update webhook subscription
* [PatchUnifiedWebhookTrigger](#patchunifiedwebhooktrigger) - Trigger webhook
* [RemoveUnifiedWebhook](#removeunifiedwebhook) - Remove webhook subscription
* [UpdateUnifiedWebhook](#updateunifiedwebhook) - Update webhook subscription
* [UpdateUnifiedWebhookTrigger](#updateunifiedwebhooktrigger) - Trigger webhook

## CreateUnifiedWebhook

The data payload received by your server is described at https://docs.unified.to/unified/overview. The `interval` field can be set as low as 1 minute for paid accounts, and 60 minutes for free accounts.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUnifiedWebhook" method="post" path="/unified/webhook" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.CreateUnifiedWebhookAsync(webhook: new UnifiedTo.Models.Components.Webhook() {
    ConnectionId = "<id>",
    Event = UnifiedTo.Models.Components.Event.Created,
    ObjectType = ObjectType.AtsScorecard,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_check_mark:                                                | A webhook is used to POST new/updated information to your server. |
| `IncludeAll`                                                      | *bool*                                                            | :heavy_minus_sign:                                                | When set, all of the existing data will sent back to your server. |

### Response

**[CreateUnifiedWebhookResponse](../../Models/Requests/CreateUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedWebhook

Retrieve webhook by its ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedWebhook" method="get" path="/unified/webhook/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.GetUnifiedWebhookAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |

### Response

**[GetUnifiedWebhookResponse](../../Models/Requests/GetUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedWebhooks

Returns all registered webhooks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedWebhooks" method="get" path="/unified/webhook" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedWebhooksRequest? req = null;

var res = await sdk.Webhook.ListUnifiedWebhooksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedWebhooksRequest](../../Models/Requests/ListUnifiedWebhooksRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListUnifiedWebhooksResponse](../../Models/Requests/ListUnifiedWebhooksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUnifiedWebhook

Update webhook subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUnifiedWebhook" method="patch" path="/unified/webhook/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.PatchUnifiedWebhookAsync(
    webhook: new UnifiedTo.Models.Components.Webhook() {
        ConnectionId = "<id>",
        Event = UnifiedTo.Models.Components.Event.Updated,
        ObjectType = ObjectType.TicketingCustomer,
    },
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_check_mark:                                                | A webhook is used to POST new/updated information to your server. |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Webhook                                                 |

### Response

**[PatchUnifiedWebhookResponse](../../Models/Requests/PatchUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUnifiedWebhookTrigger

Trigger webhook

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUnifiedWebhookTrigger" method="patch" path="/unified/webhook/{id}/trigger" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.PatchUnifiedWebhookTriggerAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |

### Response

**[PatchUnifiedWebhookTriggerResponse](../../Models/Requests/PatchUnifiedWebhookTriggerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUnifiedWebhook

Remove webhook subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUnifiedWebhook" method="delete" path="/unified/webhook/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.RemoveUnifiedWebhookAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |

### Response

**[RemoveUnifiedWebhookResponse](../../Models/Requests/RemoveUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUnifiedWebhook

Update webhook subscription

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUnifiedWebhook" method="put" path="/unified/webhook/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.UpdateUnifiedWebhookAsync(
    webhook: new UnifiedTo.Models.Components.Webhook() {
        ConnectionId = "<id>",
        Event = UnifiedTo.Models.Components.Event.Deleted,
        ObjectType = ObjectType.MessagingChannel,
    },
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_check_mark:                                                | A webhook is used to POST new/updated information to your server. |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Webhook                                                 |

### Response

**[UpdateUnifiedWebhookResponse](../../Models/Requests/UpdateUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUnifiedWebhookTrigger

Trigger webhook

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUnifiedWebhookTrigger" method="put" path="/unified/webhook/{id}/trigger" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.UpdateUnifiedWebhookTriggerAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |

### Response

**[UpdateUnifiedWebhookTriggerResponse](../../Models/Requests/UpdateUnifiedWebhookTriggerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |