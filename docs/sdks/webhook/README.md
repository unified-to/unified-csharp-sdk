# Webhook
(*Webhook*)

### Available Operations

* [CreateUnifiedWebhook](#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedWebhook](#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedWebhooks](#listunifiedwebhooks) - Returns all registered webhooks
* [RemoveUnifiedWebhook](#removeunifiedwebhook) - Remove webhook subscription

## CreateUnifiedWebhook

To maintain compatibility with the webhooks specification and Zapier webhooks, only the hook_url field is required in the payload when creating a Webhook.  When updated/new objects are found, the array of objects will be POSTed to the hook_url with the paramater hookId=<hookId>.

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Webhook.CreateUnifiedWebhookAsync("string", "string", new Webhook() {
    ConnectionId = "string",
    Events = new List<PropertyWebhookEvents>() {
        PropertyWebhookEvents.Created,
    },
    HookUrl = "string",
    IntegrationType = "string",
    Interval = 188.12D,
    ObjectType = ObjectType.CrmEvent,
    Subscriptions = new List<string>() {
        "string",
    },
    WorkspaceId = "string",
}, new List<Events>() {
    Events.Created,
});

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Object`                                        | *string*                                        | :heavy_check_mark:                              | The object to subscribe to                      |
| `Webhook`                                       | [Webhook](../../Models/Components/Webhook.md)   | :heavy_minus_sign:                              | N/A                                             |
| `Events`                                        | List<[Events](../../Models/Requests/Events.md)> | :heavy_minus_sign:                              | Which events to subscribe to.                   |


### Response

**[CreateUnifiedWebhookResponse](../../Models/Requests/CreateUnifiedWebhookResponse.md)**


## GetUnifiedWebhook

Retrieve webhook by its ID

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Webhook.GetUnifiedWebhookAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[GetUnifiedWebhookResponse](../../Models/Requests/GetUnifiedWebhookResponse.md)**


## ListUnifiedWebhooks

Returns all registered webhooks

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Webhook.ListUnifiedWebhooksAsync(new ListUnifiedWebhooksRequest() {});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedWebhooksRequest](../../Models/Requests/ListUnifiedWebhooksRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListUnifiedWebhooksResponse](../../Models/Requests/ListUnifiedWebhooksResponse.md)**


## RemoveUnifiedWebhook

Remove webhook subscription

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Webhook.RemoveUnifiedWebhookAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[RemoveUnifiedWebhookResponse](../../Models/Requests/RemoveUnifiedWebhookResponse.md)**

