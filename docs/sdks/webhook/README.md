# Webhook
(*Webhook*)

### Available Operations

* [CreateUnifiedWebhook](#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedWebhook](#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedWebhooks](#listunifiedwebhooks) - Returns all registered webhooks
* [PatchUnifiedWebhookTrigger](#patchunifiedwebhooktrigger) - Trigger webhook
* [RemoveUnifiedWebhook](#removeunifiedwebhook) - Remove webhook subscription
* [UpdateUnifiedWebhookTrigger](#updateunifiedwebhooktrigger) - Trigger webhook

## CreateUnifiedWebhook

The data payload received by your server is described at https://docs.unified.to/unified/overview.  The `interval` field can be set as low as 15 minutes for paid accounts, and 60 minutes for free accounts.

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Webhook.CreateUnifiedWebhookAsync(
    security: new CreateUnifiedWebhookSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    webhook: new Models.Components.Webhook() {
    ConnectionId = "<value>",
    Event = Models.Components.Event.Created,
    HookUrl = "<value>",
    ObjectType = ObjectType.AccountingAccount,
},
    includeAll: false);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.CreateUnifiedWebhookSecurity](../../Models/Requests/CreateUnifiedWebhookSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `Webhook`                                                                                                       | [Models.Components.Webhook](../../Models/Components/Webhook.md)                                                 | :heavy_minus_sign:                                                                                              | N/A                                                                                                             |
| `IncludeAll`                                                                                                    | *bool*                                                                                                          | :heavy_minus_sign:                                                                                              | When set, all of the existing data will sent back to your server.                                               |


### Response

**[CreateUnifiedWebhookResponse](../../Models/Requests/CreateUnifiedWebhookResponse.md)**


## GetUnifiedWebhook

Retrieve webhook by its ID

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Webhook.GetUnifiedWebhookAsync(
    security: new GetUnifiedWebhookSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.GetUnifiedWebhookSecurity](../../Models/Requests/GetUnifiedWebhookSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Webhook                                                                                         |


### Response

**[GetUnifiedWebhookResponse](../../Models/Requests/GetUnifiedWebhookResponse.md)**


## ListUnifiedWebhooks

Returns all registered webhooks

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

ListUnifiedWebhooksRequest req = new ListUnifiedWebhooksRequest() {};

var res = await sdk.Webhook.ListUnifiedWebhooksAsync(
    security: new ListUnifiedWebhooksSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [ListUnifiedWebhooksRequest](../../Models/Requests/ListUnifiedWebhooksRequest.md)                             | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.ListUnifiedWebhooksSecurity](../../Models/Requests/ListUnifiedWebhooksSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |


### Response

**[ListUnifiedWebhooksResponse](../../Models/Requests/ListUnifiedWebhooksResponse.md)**


## PatchUnifiedWebhookTrigger

Trigger webhook

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Webhook.PatchUnifiedWebhookTriggerAsync(
    security: new PatchUnifiedWebhookTriggerSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                  | [UnifiedTo.Models.Requests.PatchUnifiedWebhookTriggerSecurity](../../Models/Requests/PatchUnifiedWebhookTriggerSecurity.md) | :heavy_check_mark:                                                                                                          | The security requirements to use for the request.                                                                           |
| `Id`                                                                                                                        | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | ID of the Webhook                                                                                                           |


### Response

**[PatchUnifiedWebhookTriggerResponse](../../Models/Requests/PatchUnifiedWebhookTriggerResponse.md)**


## RemoveUnifiedWebhook

Remove webhook subscription

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Webhook.RemoveUnifiedWebhookAsync(
    security: new RemoveUnifiedWebhookSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.RemoveUnifiedWebhookSecurity](../../Models/Requests/RemoveUnifiedWebhookSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Webhook                                                                                               |


### Response

**[RemoveUnifiedWebhookResponse](../../Models/Requests/RemoveUnifiedWebhookResponse.md)**


## UpdateUnifiedWebhookTrigger

Trigger webhook

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Webhook.UpdateUnifiedWebhookTriggerAsync(
    security: new UpdateUnifiedWebhookTriggerSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.UpdateUnifiedWebhookTriggerSecurity](../../Models/Requests/UpdateUnifiedWebhookTriggerSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |
| `Id`                                                                                                                          | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | ID of the Webhook                                                                                                             |


### Response

**[UpdateUnifiedWebhookTriggerResponse](../../Models/Requests/UpdateUnifiedWebhookTriggerResponse.md)**

