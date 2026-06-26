# Secretsmanager
(*Secretsmanager*)

## Overview

### Available Operations

* [CreateUnifiedWorkspaceSecretsmanager](#createunifiedworkspacesecretsmanager) - Create secrets manager
* [GetUnifiedWorkspaceSecretsmanager](#getunifiedworkspacesecretsmanager) - Retrieve secrets manager
* [ListUnifiedWorkspaceSecretsmanagers](#listunifiedworkspacesecretsmanagers) - List secrets managers
* [RemoveUnifiedWorkspaceSecretsmanager](#removeunifiedworkspacesecretsmanager) - Remove secrets manager

## CreateUnifiedWorkspaceSecretsmanager

Create secrets manager

### Example Usage

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

var res = await sdk.Secretsmanager.CreateUnifiedWorkspaceSecretsmanagerAsync(req);

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

## GetUnifiedWorkspaceSecretsmanager

Retrieve secrets manager

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Secretsmanager.GetUnifiedWorkspaceSecretsmanagerAsync(id: "<id>");

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

## ListUnifiedWorkspaceSecretsmanagers

List secrets managers

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedWorkspaceSecretsmanagersRequest req = ;

var res = await sdk.Secretsmanager.ListUnifiedWorkspaceSecretsmanagersAsync(req);

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

## RemoveUnifiedWorkspaceSecretsmanager

Remove secrets manager

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Secretsmanager.RemoveUnifiedWorkspaceSecretsmanagerAsync(id: "<id>");

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