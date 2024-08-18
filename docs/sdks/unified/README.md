# Unified
(*Unified*)

### Available Operations

* [CreateUnifiedConnection](#createunifiedconnection) - Create connection
* [CreateUnifiedWebhook](#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedApicall](#getunifiedapicall) - Retrieve specific API Call by its ID
* [GetUnifiedConnection](#getunifiedconnection) - Retrieve connection
* [GetUnifiedIntegrationAuth](#getunifiedintegrationauth) - Create connection indirectly
* [GetUnifiedWebhook](#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedApicalls](#listunifiedapicalls) - Returns API Calls
* [ListUnifiedConnections](#listunifiedconnections) - List all connections
* [ListUnifiedIntegrationWorkspaces](#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](#listunifiedintegrations) - Returns all integrations
* [ListUnifiedIssues](#listunifiedissues) - List support issues
* [ListUnifiedWebhooks](#listunifiedwebhooks) - Returns all registered webhooks
* [PatchUnifiedConnection](#patchunifiedconnection) - Update connection
* [PatchUnifiedWebhook](#patchunifiedwebhook) - Update webhook subscription
* [PatchUnifiedWebhookTrigger](#patchunifiedwebhooktrigger) - Trigger webhook
* [RemoveUnifiedConnection](#removeunifiedconnection) - Remove connection
* [RemoveUnifiedWebhook](#removeunifiedwebhook) - Remove webhook subscription
* [UpdateUnifiedConnection](#updateunifiedconnection) - Update connection
* [UpdateUnifiedWebhook](#updateunifiedwebhook) - Update webhook subscription
* [UpdateUnifiedWebhookTrigger](#updateunifiedwebhooktrigger) - Trigger webhook

## CreateUnifiedConnection

Create connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

Models.Components.Connection req = new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        UnifiedTo.Models.Components.PropertyConnectionCategories.Kms,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        UnifiedTo.Models.Components.PropertyConnectionPermissions.AtsDocumentWrite,
    },
};

var res = await sdk.Unified.CreateUnifiedConnectionAsync(req);

// handle response
```



### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[CreateUnifiedConnectionResponse](../../Models/Requests/CreateUnifiedConnectionResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.CreateUnifiedWebhookAsync(
    webhook: new Models.Components.Webhook() {
    ConnectionId = "<value>",
    Event = UnifiedTo.Models.Components.Event.Created,
    HookUrl = "<value>",
    ObjectType = UnifiedTo.Models.Components.ObjectType.AccountingTransaction,
},
    includeAll: false);

// handle response
```



### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Webhook`                                                         | [Models.Components.Webhook](../../Models/Components/Webhook.md)   | :heavy_minus_sign:                                                | N/A                                                               |
| `IncludeAll`                                                      | *bool*                                                            | :heavy_minus_sign:                                                | When set, all of the existing data will sent back to your server. |


### Response

**[CreateUnifiedWebhookResponse](../../Models/Requests/CreateUnifiedWebhookResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetUnifiedApicall

Retrieve specific API Call by its ID

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.GetUnifiedApicallAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Apicall  |


### Response

**[GetUnifiedApicallResponse](../../Models/Requests/GetUnifiedApicallResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetUnifiedConnection

Retrieve connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.GetUnifiedConnectionAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |


### Response

**[GetUnifiedConnectionResponse](../../Models/Requests/GetUnifiedConnectionResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetUnifiedIntegrationAuth

Returns an authorization URL for the specified integration.  Once a successful authorization occurs, a new connection is created.

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

GetUnifiedIntegrationAuthRequest req = new GetUnifiedIntegrationAuthRequest() {
    IntegrationType = "<value>",
    WorkspaceId = "<value>",
};

var res = await sdk.Unified.GetUnifiedIntegrationAuthAsync(req);

// handle response
```



### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetUnifiedIntegrationAuthRequest](../../Models/Requests/GetUnifiedIntegrationAuthRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetUnifiedIntegrationAuthResponse](../../Models/Requests/GetUnifiedIntegrationAuthResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.GetUnifiedWebhookAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[GetUnifiedWebhookResponse](../../Models/Requests/GetUnifiedWebhookResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListUnifiedApicalls

Returns API Calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedApicallsRequest req = new ListUnifiedApicallsRequest() {};

var res = await sdk.Unified.ListUnifiedApicallsAsync(req);

// handle response
```



### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedApicallsRequest](../../Models/Requests/ListUnifiedApicallsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListUnifiedApicallsResponse](../../Models/Requests/ListUnifiedApicallsResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListUnifiedConnections

List all connections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedConnectionsRequest req = new ListUnifiedConnectionsRequest() {};

var res = await sdk.Unified.ListUnifiedConnectionsAsync(req);

// handle response
```



### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListUnifiedConnectionsRequest](../../Models/Requests/ListUnifiedConnectionsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListUnifiedConnectionsResponse](../../Models/Requests/ListUnifiedConnectionsResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListUnifiedIntegrationWorkspaces

No authentication required as this is to be used by front-end interface

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedIntegrationWorkspacesRequest req = new ListUnifiedIntegrationWorkspacesRequest() {
    WorkspaceId = "<value>",
};

var res = await sdk.Unified.ListUnifiedIntegrationWorkspacesAsync(req);

// handle response
```



### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [ListUnifiedIntegrationWorkspacesRequest](../../Models/Requests/ListUnifiedIntegrationWorkspacesRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |


### Response

**[ListUnifiedIntegrationWorkspacesResponse](../../Models/Requests/ListUnifiedIntegrationWorkspacesResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListUnifiedIntegrations

Returns all integrations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedIntegrationsRequest req = new ListUnifiedIntegrationsRequest() {};

var res = await sdk.Unified.ListUnifiedIntegrationsAsync(req);

// handle response
```



### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListUnifiedIntegrationsRequest](../../Models/Requests/ListUnifiedIntegrationsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListUnifiedIntegrationsResponse](../../Models/Requests/ListUnifiedIntegrationsResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListUnifiedIssues

List support issues

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedIssuesRequest req = new ListUnifiedIssuesRequest() {};

var res = await sdk.Unified.ListUnifiedIssuesAsync(req);

// handle response
```



### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListUnifiedIssuesRequest](../../Models/Requests/ListUnifiedIssuesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListUnifiedIssuesResponse](../../Models/Requests/ListUnifiedIssuesResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.ListUnifiedWebhooksAsync(req);

// handle response
```



### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedWebhooksRequest](../../Models/Requests/ListUnifiedWebhooksRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListUnifiedWebhooksResponse](../../Models/Requests/ListUnifiedWebhooksResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchUnifiedConnection

Update connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.PatchUnifiedConnectionAsync(
    id: "<value>",
    connection: new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        UnifiedTo.Models.Components.PropertyConnectionCategories.Commerce,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        UnifiedTo.Models.Components.PropertyConnectionPermissions.HrisGroupRead,
    },
});

// handle response
```



### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_minus_sign:                                                    | A connection represents a specific authentication of an integration.  |


### Response

**[PatchUnifiedConnectionResponse](../../Models/Requests/PatchUnifiedConnectionResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.PatchUnifiedWebhookAsync(
    id: "<value>",
    webhook: new Models.Components.Webhook() {
    ConnectionId = "<value>",
    Event = UnifiedTo.Models.Components.Event.Deleted,
    HookUrl = "<value>",
    ObjectType = UnifiedTo.Models.Components.ObjectType.Passthrough,
});

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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.PatchUnifiedWebhookTriggerAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[PatchUnifiedWebhookTriggerResponse](../../Models/Requests/PatchUnifiedWebhookTriggerResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveUnifiedConnection

Remove connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.RemoveUnifiedConnectionAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |


### Response

**[RemoveUnifiedConnectionResponse](../../Models/Requests/RemoveUnifiedConnectionResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.RemoveUnifiedWebhookAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[RemoveUnifiedWebhookResponse](../../Models/Requests/RemoveUnifiedWebhookResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateUnifiedConnection

Update connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.UpdateUnifiedConnectionAsync(
    id: "<value>",
    connection: new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        UnifiedTo.Models.Components.PropertyConnectionCategories.Genai,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        UnifiedTo.Models.Components.PropertyConnectionPermissions.CrmDealWrite,
    },
});

// handle response
```



### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_minus_sign:                                                    | A connection represents a specific authentication of an integration.  |


### Response

**[UpdateUnifiedConnectionResponse](../../Models/Requests/UpdateUnifiedConnectionResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.UpdateUnifiedWebhookAsync(
    id: "<value>",
    webhook: new Models.Components.Webhook() {
    ConnectionId = "<value>",
    Event = UnifiedTo.Models.Components.Event.Created,
    HookUrl = "<value>",
    ObjectType = UnifiedTo.Models.Components.ObjectType.HrisGroup,
});

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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

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

var res = await sdk.Unified.UpdateUnifiedWebhookTriggerAsync(id: "<value>");

// handle response
```



### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[UpdateUnifiedWebhookTriggerResponse](../../Models/Requests/UpdateUnifiedWebhookTriggerResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
