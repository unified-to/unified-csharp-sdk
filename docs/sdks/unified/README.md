# Unified
(*Unified*)

### Available Operations

* [CreateUnifiedConnection](#createunifiedconnection) - Create connection
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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

Models.Components.Connection req = new Models.Components.Connection() {
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
    CursorsCache = new List<Undefined>() {
        new Undefined() {},
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.AtsJobRead,
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


## GetUnifiedApicall

Retrieve specific API Call by its ID

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.GetUnifiedApicallAsync(Id: "string");

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.GetUnifiedConnectionAsync(Id: "string");

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.GetUnifiedIntegrationAsync(IntegrationType: "string");

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

GetUnifiedIntegrationAuthRequest req = new GetUnifiedIntegrationAuthRequest() {
    IntegrationType = "string",
    Scopes = new List<Scopes>() {
        Scopes.HrisEmployeeRead,
    },
    WorkspaceId = "string",
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


## GetUnifiedWebhook

Retrieve webhook by its ID

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.GetUnifiedWebhookAsync(Id: "string");

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedConnectionsRequest req = new ListUnifiedConnectionsRequest() {
    Categories = new List<Categories>() {
        Categories.Enrich,
    },
};

var res = await sdk.Unified.ListUnifiedConnectionsAsync(req);

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedIntegrationWorkspacesRequest req = new ListUnifiedIntegrationWorkspacesRequest() {
    Categories = new List<QueryParamCategories>() {
        QueryParamCategories.Ticketing,
    },
    WorkspaceId = "string",
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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedIntegrationsRequest req = new ListUnifiedIntegrationsRequest() {
    Categories = new List<ListUnifiedIntegrationsQueryParamCategories>() {
        ListUnifiedIntegrationsQueryParamCategories.Auth,
    },
};

var res = await sdk.Unified.ListUnifiedIntegrationsAsync(req);

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.PatchUnifiedConnectionAsync(Id: "string", Connection: new Models.Components.Connection() {
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
    CursorsCache = new List<Undefined>() {
        new Undefined() {},
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.CrmPipelineRead,
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


## RemoveUnifiedConnection

Remove connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.RemoveUnifiedConnectionAsync(Id: "string");

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.RemoveUnifiedWebhookAsync(Id: "string");

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
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Unified.UpdateUnifiedConnectionAsync(Id: "string", Connection: new Models.Components.Connection() {
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
    CursorsCache = new List<Undefined>() {
        new Undefined() {},
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.CrmCompanyWrite,
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

