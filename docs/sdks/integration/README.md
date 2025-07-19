# Integration
(*Integration*)

## Overview

### Available Operations

* [GetUnifiedIntegrationAuth](#getunifiedintegrationauth) - Authorize new connection
* [ListUnifiedIntegrationWorkspaces](#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](#listunifiedintegrations) - Returns all integrations

## GetUnifiedIntegrationAuth

Returns an authorization URL for the specified integration.  Once a successful authorization occurs, a new connection is created.

### Example Usage

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

var res = await sdk.Integration.GetUnifiedIntegrationAuthAsync(req);

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

## ListUnifiedIntegrationWorkspaces

No authentication required as this is to be used by front-end interface

### Example Usage

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

var res = await sdk.Integration.ListUnifiedIntegrationWorkspacesAsync(req);

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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedIntegrationsRequest req = ;

var res = await sdk.Integration.ListUnifiedIntegrationsAsync(req);

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