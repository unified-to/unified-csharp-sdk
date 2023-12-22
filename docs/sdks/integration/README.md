# Integration
(*Integration*)

### Available Operations

* [GetUnifiedIntegration](#getunifiedintegration) - Retrieve an integration
* [GetUnifiedIntegrationAuth](#getunifiedintegrationauth) - Create connection indirectly
* [ListUnifiedIntegrationWorkspaces](#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](#listunifiedintegrations) - Returns all integrations

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

var res = await sdk.Integration.GetUnifiedIntegrationAsync(IntegrationType: "string");

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
        Scopes.HrisGroupRead,
    },
    WorkspaceId = "string",
};

var res = await sdk.Integration.GetUnifiedIntegrationAuthAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetUnifiedIntegrationAuthRequest](../../Models/Requests/GetUnifiedIntegrationAuthRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetUnifiedIntegrationAuthResponse](../../Models/Requests/GetUnifiedIntegrationAuthResponse.md)**


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
        QueryParamCategories.Uc,
    },
    WorkspaceId = "string",
};

var res = await sdk.Integration.ListUnifiedIntegrationWorkspacesAsync(req);

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

var res = await sdk.Integration.ListUnifiedIntegrationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListUnifiedIntegrationsRequest](../../Models/Requests/ListUnifiedIntegrationsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListUnifiedIntegrationsResponse](../../Models/Requests/ListUnifiedIntegrationsResponse.md)**

