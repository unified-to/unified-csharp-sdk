# Webhook
(*Webhook*)

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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.CreateUnifiedWebhookAsync(
    webhook: new Models.Components.Webhook() {
        ConnectionId = "<id>",
        Event = UnifiedTo.Models.Components.Event.Created,
        HookUrl = "https://blind-platypus.org/",
        ObjectType = UnifiedTo.Models.Components.ObjectType.AtsScorecard,
    },
    includeAll: false
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_minus_sign:                                                | A webhook is used to POST new/updated information to your server. |
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedWebhooksRequest req = new ListUnifiedWebhooksRequest() {};

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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.PatchUnifiedWebhookAsync(
    id: "<id>",
    webhook: new Models.Components.Webhook() {
        ConnectionId = "<id>",
        Event = UnifiedTo.Models.Components.Event.Deleted,
        HookUrl = "https://calculating-habit.name/",
        ObjectType = UnifiedTo.Models.Components.ObjectType.CommerceItem,
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Webhook                                                 |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_minus_sign:                                                | A webhook is used to POST new/updated information to your server. |

### Response

**[PatchUnifiedWebhookResponse](../../Models/Requests/PatchUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUnifiedWebhookTrigger

Trigger webhook

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webhook.UpdateUnifiedWebhookAsync(
    id: "<id>",
    webhook: new Models.Components.Webhook() {
        ConnectionId = "<id>",
        Event = UnifiedTo.Models.Components.Event.Created,
        HookUrl = "https://glaring-postbox.info/",
        ObjectType = UnifiedTo.Models.Components.ObjectType.GenaiModel,
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Webhook                                                 |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_minus_sign:                                                | A webhook is used to POST new/updated information to your server. |

### Response

**[UpdateUnifiedWebhookResponse](../../Models/Requests/UpdateUnifiedWebhookResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUnifiedWebhookTrigger

Trigger webhook

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
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