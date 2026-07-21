# Unified

## Overview

### Available Operations

* [CreateUnifiedConnection](#createunifiedconnection) - Create connection
* [CreateUnifiedEnvironment](#createunifiedenvironment) - Create new environments
* [CreateUnifiedWebhook](#createunifiedwebhook) - Create webhook subscription
* [CreateUnifiedWorkspaceSecretsmanager](#createunifiedworkspacesecretsmanager) - Create secrets manager
* [GetUnifiedApicall](#getunifiedapicall) - Retrieve specific API Call by its ID
* [GetUnifiedConnection](#getunifiedconnection) - Retrieve connection
* [GetUnifiedIntegrationAuth](#getunifiedintegrationauth) - Authorize new connection
* [GetUnifiedIssue](#getunifiedissue) - Retrieve support issue
* [GetUnifiedWebhook](#getunifiedwebhook) - Retrieve webhook by its ID
* [GetUnifiedWorkspaceSecretsmanager](#getunifiedworkspacesecretsmanager) - Retrieve secrets manager
* [ListUnifiedApicalls](#listunifiedapicalls) - Returns API Calls
* [ListUnifiedConnections](#listunifiedconnections) - List all connections
* [ListUnifiedEnvironments](#listunifiedenvironments) - Returns all environments
* [ListUnifiedIntegrationWorkspaces](#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](#listunifiedintegrations) - Returns all integrations
* [ListUnifiedIssues](#listunifiedissues) - List support issues
* [ListUnifiedWebhooks](#listunifiedwebhooks) - Returns all registered webhooks
* [ListUnifiedWorkspaceSecretsmanagers](#listunifiedworkspacesecretsmanagers) - List secrets managers
* [PatchUnifiedConnection](#patchunifiedconnection) - Update connection
* [PatchUnifiedWebhook](#patchunifiedwebhook) - Update webhook subscription
* [PatchUnifiedWebhookTrigger](#patchunifiedwebhooktrigger) - Trigger webhook
* [RemoveUnifiedConnection](#removeunifiedconnection) - Remove connection
* [RemoveUnifiedEnvironment](#removeunifiedenvironment) - Remove an environment
* [RemoveUnifiedWebhook](#removeunifiedwebhook) - Remove webhook subscription
* [RemoveUnifiedWorkspaceSecretsmanager](#removeunifiedworkspacesecretsmanager) - Remove secrets manager
* [UpdateUnifiedConnection](#updateunifiedconnection) - Update connection
* [UpdateUnifiedWebhook](#updateunifiedwebhook) - Update webhook subscription
* [UpdateUnifiedWebhookTrigger](#updateunifiedwebhooktrigger) - Trigger webhook

## CreateUnifiedConnection

Used only to import existing customer credentials; use "Authorize new connection" instead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUnifiedConnection" method="post" path="/unified/connection" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

Models.Components.Connection req = new UnifiedTo.Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {},
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.EnrichCompanyRead,
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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateUnifiedEnvironment

Create new environments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUnifiedEnvironment" method="post" path="/unified/environment" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

List<string> req = new List<string>() {};

var res = await sdk.Unified.CreateUnifiedEnvironmentAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | List<*string*>                             | :heavy_check_mark:                         | The request object to use for the request. |

### Response

**[CreateUnifiedEnvironmentResponse](../../Models/Requests/CreateUnifiedEnvironmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Unified.CreateUnifiedWebhookAsync(webhook: new UnifiedTo.Models.Components.Webhook() {
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

## CreateUnifiedWorkspaceSecretsmanager

Create secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUnifiedWorkspaceSecretsmanager" method="post" path="/unified/workspace/secretsmanager" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

SecretsManager req = new SecretsManager() {
    Auth = new Dictionary<string, string>() {

    },
    Name = "<value>",
    Type = SecretsManagerType.Hashicorp,
};

var res = await sdk.Unified.CreateUnifiedWorkspaceSecretsmanagerAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [SecretsManager](../../Models/Components/SecretsManager.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[CreateUnifiedWorkspaceSecretsmanagerResponse](../../Models/Requests/CreateUnifiedWorkspaceSecretsmanagerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedApicall

Retrieve specific API Call by its ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedApicall" method="get" path="/unified/apicall/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.GetUnifiedApicallAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Apicall  |

### Response

**[GetUnifiedApicallResponse](../../Models/Requests/GetUnifiedApicallResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedConnection

Retrieve connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedConnection" method="get" path="/unified/connection/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.GetUnifiedConnectionAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |

### Response

**[GetUnifiedConnectionResponse](../../Models/Requests/GetUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedIntegrationAuth

Returns an authorization URL for the specified integration.  Once a successful authorization occurs, a new connection is created.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedIntegrationAuth" method="get" path="/unified/integration/auth/{workspace_id}/{integration_type}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

GetUnifiedIntegrationAuthRequest req = new GetUnifiedIntegrationAuthRequest() {
    IntegrationType = "<value>",
    WorkspaceId = "<id>",
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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedIssue

Retrieve support issue

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedIssue" method="get" path="/unified/issue/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.GetUnifiedIssueAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Issue    |

### Response

**[GetUnifiedIssueResponse](../../Models/Requests/GetUnifiedIssueResponse.md)**

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

var res = await sdk.Unified.GetUnifiedWebhookAsync(id: "<id>");

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

## GetUnifiedWorkspaceSecretsmanager

Retrieve secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedWorkspaceSecretsmanager" method="get" path="/unified/workspace/secretsmanager/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.GetUnifiedWorkspaceSecretsmanagerAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `Id`                     | *string*                 | :heavy_check_mark:       | ID of the Secretsmanager |

### Response

**[GetUnifiedWorkspaceSecretsmanagerResponse](../../Models/Requests/GetUnifiedWorkspaceSecretsmanagerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedApicalls

Returns API Calls

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedApicalls" method="get" path="/unified/apicall" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedApicallsRequest? req = null;

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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedConnections

List all connections

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedConnections" method="get" path="/unified/connection" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedConnectionsRequest? req = null;

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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedEnvironments

Returns all environments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedEnvironments" method="get" path="/unified/environment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.ListUnifiedEnvironmentsAsync();

// handle response
```

### Response

**[ListUnifiedEnvironmentsResponse](../../Models/Requests/ListUnifiedEnvironmentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedIntegrationWorkspaces

No authentication required as this is to be used by front-end interface

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedIntegrationWorkspaces" method="get" path="/unified/integration/workspace/{workspace_id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedIntegrationWorkspacesRequest req = new ListUnifiedIntegrationWorkspacesRequest() {
    WorkspaceId = "<id>",
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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedIntegrations

Returns all integrations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedIntegrations" method="get" path="/unified/integration" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedIntegrationsRequest? req = null;

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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedIssues

List support issues

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedIssues" method="get" path="/unified/issue" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedIssuesRequest? req = null;

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

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedWorkspaceSecretsmanagers

List secrets managers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedWorkspaceSecretsmanagers" method="get" path="/unified/workspace/secretsmanager" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedWorkspaceSecretsmanagersRequest? req = null;

var res = await sdk.Unified.ListUnifiedWorkspaceSecretsmanagersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [ListUnifiedWorkspaceSecretsmanagersRequest](../../Models/Requests/ListUnifiedWorkspaceSecretsmanagersRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[ListUnifiedWorkspaceSecretsmanagersResponse](../../Models/Requests/ListUnifiedWorkspaceSecretsmanagersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUnifiedConnection

Update connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUnifiedConnection" method="patch" path="/unified/connection/{id}" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.PatchUnifiedConnectionAsync(
    connection: new UnifiedTo.Models.Components.Connection() {
        Categories = new List<PropertyConnectionCategories>() {
            PropertyConnectionCategories.Storage,
        },
        IntegrationType = "<value>",
        Permissions = new List<PropertyConnectionPermissions>() {
            PropertyConnectionPermissions.UcContactWrite,
        },
    },
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                                    | A connection represents a specific authentication of an integration.  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |

### Response

**[PatchUnifiedConnectionResponse](../../Models/Requests/PatchUnifiedConnectionResponse.md)**

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

var res = await sdk.Unified.PatchUnifiedWebhookAsync(
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

var res = await sdk.Unified.PatchUnifiedWebhookTriggerAsync(id: "<id>");

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

## RemoveUnifiedConnection

Remove connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUnifiedConnection" method="delete" path="/unified/connection/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.RemoveUnifiedConnectionAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |

### Response

**[RemoveUnifiedConnectionResponse](../../Models/Requests/RemoveUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUnifiedEnvironment

Remove an environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUnifiedEnvironment" method="delete" path="/unified/environment/{env}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.RemoveUnifiedEnvironmentAsync(env: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Env`              | *string*           | :heavy_check_mark: | N/A                |

### Response

**[RemoveUnifiedEnvironmentResponse](../../Models/Requests/RemoveUnifiedEnvironmentResponse.md)**

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

var res = await sdk.Unified.RemoveUnifiedWebhookAsync(id: "<id>");

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

## RemoveUnifiedWorkspaceSecretsmanager

Remove secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUnifiedWorkspaceSecretsmanager" method="delete" path="/unified/workspace/secretsmanager/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.RemoveUnifiedWorkspaceSecretsmanagerAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `Id`                     | *string*                 | :heavy_check_mark:       | ID of the Secretsmanager |

### Response

**[RemoveUnifiedWorkspaceSecretsmanagerResponse](../../Models/Requests/RemoveUnifiedWorkspaceSecretsmanagerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUnifiedConnection

Update connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUnifiedConnection" method="put" path="/unified/connection/{id}" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Unified.UpdateUnifiedConnectionAsync(
    connection: new UnifiedTo.Models.Components.Connection() {
        Categories = new List<PropertyConnectionCategories>() {},
        IntegrationType = "<value>",
        Permissions = new List<PropertyConnectionPermissions>() {
            PropertyConnectionPermissions.CommerceReviewRead,
            PropertyConnectionPermissions.CalendarCalendarRead,
        },
    },
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                                    | A connection represents a specific authentication of an integration.  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |

### Response

**[UpdateUnifiedConnectionResponse](../../Models/Requests/UpdateUnifiedConnectionResponse.md)**

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

var res = await sdk.Unified.UpdateUnifiedWebhookAsync(
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

var res = await sdk.Unified.UpdateUnifiedWebhookTriggerAsync(id: "<id>");

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