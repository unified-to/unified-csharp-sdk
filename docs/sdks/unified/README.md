# Unified
(*Unified*)

### Available Operations

* [CreateUnifiedConnection](#createunifiedconnection) - Create connection
* [CreateUnifiedWebhook](#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedApicall](#getunifiedapicall) - Retrieve specific API Call by its ID
* [GetUnifiedConnection](#getunifiedconnection) - Retrieve connection
* [GetUnifiedIntegration](#getunifiedintegration) - Retrieve an integration
* [GetUnifiedIntegrationAuth](#getunifiedintegrationauth) - Create connection indirectly
* [GetUnifiedWebhook](#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedApicalls](#listunifiedapicalls) - Returns API Calls
* [ListUnifiedConnections](#listunifiedconnections) - List all connections
* [ListUnifiedIntegrationWorkspaces](#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](#listunifiedintegrations) - Returns all integrations
* [ListUnifiedWebhooks](#listunifiedwebhooks) - Returns all registered webhooks
* [PatchUnifiedConnection](#patchunifiedconnection) - Update connection
* [RemoveUnifiedConnection](#removeunifiedconnection) - Remove connection
* [RemoveUnifiedWebhook](#removeunifiedwebhook) - Remove webhook subscription
* [UpdateUnifiedConnection](#updateunifiedconnection) - Update connection

## CreateUnifiedConnection

Create connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Unified.CreateUnifiedConnectionAsync(new Connection() {
    Auth = new PropertyConnectionAuth() {
        Emails = new List<string>() {
            "string",
        },
        Meta = new PropertyPropertyConnectionAuthMeta() {},
        OtherAuthInfo = new List<string>() {
            "string",
        },
    },
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Accounting,
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.AtsDocumentWrite,
    },
});

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                  | The request object to use for the request.          |


### Response

**[CreateUnifiedConnectionResponse](../../Models/Requests/CreateUnifiedConnectionResponse.md)**


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

var res = await sdk.Unified.CreateUnifiedWebhookAsync("string", "string", new Webhook() {
    ConnectionId = "string",
    Events = new List<PropertyWebhookEvents>() {
        PropertyWebhookEvents.Created,
    },
    HookUrl = "string",
    IntegrationType = "string",
    Interval = 188.12D,
    ObjectType = ObjectType.CrmDeal,
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


## GetUnifiedApicall

Retrieve specific API Call by its ID

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

var res = await sdk.Unified.GetUnifiedApicallAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Apicall  |


### Response

**[GetUnifiedApicallResponse](../../Models/Requests/GetUnifiedApicallResponse.md)**


## GetUnifiedConnection

Retrieve connection

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

var res = await sdk.Unified.GetUnifiedConnectionAsync("string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |


### Response

**[GetUnifiedConnectionResponse](../../Models/Requests/GetUnifiedConnectionResponse.md)**


## GetUnifiedIntegration

Retrieve an integration

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

var res = await sdk.Unified.GetUnifiedIntegrationAsync("string");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IntegrationType`                 | *string*                          | :heavy_check_mark:                | Type of the supported integration |


### Response

**[GetUnifiedIntegrationResponse](../../Models/Requests/GetUnifiedIntegrationResponse.md)**


## GetUnifiedIntegrationAuth

Returns an authorization URL for the specified integration.  Once a successful authorization occurs, a new connection is created.

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

var res = await sdk.Unified.GetUnifiedIntegrationAuthAsync(new GetUnifiedIntegrationAuthRequest() {
    IntegrationType = "string",
    Scopes = new List<Scopes>() {
        Scopes.HrisEmployeeWrite,
    },
    WorkspaceId = "string",
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetUnifiedIntegrationAuthRequest](../../Models/Requests/GetUnifiedIntegrationAuthRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetUnifiedIntegrationAuthResponse](../../Models/Requests/GetUnifiedIntegrationAuthResponse.md)**


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

var res = await sdk.Unified.GetUnifiedWebhookAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[GetUnifiedWebhookResponse](../../Models/Requests/GetUnifiedWebhookResponse.md)**


## ListUnifiedApicalls

Returns API Calls

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

var res = await sdk.Unified.ListUnifiedApicallsAsync(new ListUnifiedApicallsRequest() {});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedApicallsRequest](../../Models/Requests/ListUnifiedApicallsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListUnifiedApicallsResponse](../../Models/Requests/ListUnifiedApicallsResponse.md)**


## ListUnifiedConnections

List all connections

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

var res = await sdk.Unified.ListUnifiedConnectionsAsync(new ListUnifiedConnectionsRequest() {
    Categories = new List<Categories>() {
        Categories.Enrich,
    },
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListUnifiedConnectionsRequest](../../Models/Requests/ListUnifiedConnectionsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListUnifiedConnectionsResponse](../../Models/Requests/ListUnifiedConnectionsResponse.md)**


## ListUnifiedIntegrationWorkspaces

No authentication required as this is to be used by front-end interface

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

var res = await sdk.Unified.ListUnifiedIntegrationWorkspacesAsync(new ListUnifiedIntegrationWorkspacesRequest() {
    Categories = new List<QueryParamCategories>() {
        QueryParamCategories.Ticketing,
    },
    WorkspaceId = "string",
});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [ListUnifiedIntegrationWorkspacesRequest](../../Models/Requests/ListUnifiedIntegrationWorkspacesRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |


### Response

**[ListUnifiedIntegrationWorkspacesResponse](../../Models/Requests/ListUnifiedIntegrationWorkspacesResponse.md)**


## ListUnifiedIntegrations

Returns all integrations

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

var res = await sdk.Unified.ListUnifiedIntegrationsAsync(new ListUnifiedIntegrationsRequest() {
    Categories = new List<ListUnifiedIntegrationsQueryParamCategories>() {
        ListUnifiedIntegrationsQueryParamCategories.Auth,
    },
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListUnifiedIntegrationsRequest](../../Models/Requests/ListUnifiedIntegrationsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListUnifiedIntegrationsResponse](../../Models/Requests/ListUnifiedIntegrationsResponse.md)**


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

var res = await sdk.Unified.ListUnifiedWebhooksAsync(new ListUnifiedWebhooksRequest() {});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedWebhooksRequest](../../Models/Requests/ListUnifiedWebhooksRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListUnifiedWebhooksResponse](../../Models/Requests/ListUnifiedWebhooksResponse.md)**


## PatchUnifiedConnection

Update connection

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

var res = await sdk.Unified.PatchUnifiedConnectionAsync("string", new Connection() {
    Auth = new PropertyConnectionAuth() {
        Emails = new List<string>() {
            "string",
        },
        Meta = new PropertyPropertyConnectionAuthMeta() {},
        OtherAuthInfo = new List<string>() {
            "string",
        },
    },
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Martech,
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.MartechListRead,
    },
});

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Id`                                                                 | *string*                                                             | :heavy_check_mark:                                                   | ID of the Connection                                                 |
| `Connection`                                                         | [Connection](../../Models/Components/Connection.md)                  | :heavy_minus_sign:                                                   | A connection represents a specific authentication of an integration. |


### Response

**[PatchUnifiedConnectionResponse](../../Models/Requests/PatchUnifiedConnectionResponse.md)**


## RemoveUnifiedConnection

Remove connection

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

var res = await sdk.Unified.RemoveUnifiedConnectionAsync("string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |


### Response

**[RemoveUnifiedConnectionResponse](../../Models/Requests/RemoveUnifiedConnectionResponse.md)**


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

var res = await sdk.Unified.RemoveUnifiedWebhookAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Webhook  |


### Response

**[RemoveUnifiedWebhookResponse](../../Models/Requests/RemoveUnifiedWebhookResponse.md)**


## UpdateUnifiedConnection

Update connection

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

var res = await sdk.Unified.UpdateUnifiedConnectionAsync("string", new Connection() {
    Auth = new PropertyConnectionAuth() {
        Emails = new List<string>() {
            "string",
        },
        Meta = new PropertyPropertyConnectionAuthMeta() {},
        OtherAuthInfo = new List<string>() {
            "string",
        },
    },
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Ticketing,
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.CrmDealRead,
    },
});

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Id`                                                                 | *string*                                                             | :heavy_check_mark:                                                   | ID of the Connection                                                 |
| `Connection`                                                         | [Connection](../../Models/Components/Connection.md)                  | :heavy_minus_sign:                                                   | A connection represents a specific authentication of an integration. |


### Response

**[UpdateUnifiedConnectionResponse](../../Models/Requests/UpdateUnifiedConnectionResponse.md)**

