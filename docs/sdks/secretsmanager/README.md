# Secretsmanager

## Overview

### Available Operations

* [CreateUnifiedSecretsmanager](#createunifiedsecretsmanager) - Create secrets manager
* [GetUnifiedSecretsmanager](#getunifiedsecretsmanager) - Retrieve secrets manager
* [ListUnifiedSecretsmanagerInstructions](#listunifiedsecretsmanagerinstructions) - List secrets manager setup instructions
* [ListUnifiedSecretsmanagerSecrets](#listunifiedsecretsmanagersecrets) - List secrets in a secrets manager
* [ListUnifiedSecretsmanagers](#listunifiedsecretsmanagers) - List secrets managers
* [RemoveUnifiedSecretsmanager](#removeunifiedsecretsmanager) - Remove secrets manager

## CreateUnifiedSecretsmanager

Create secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUnifiedSecretsmanager" method="post" path="/unified/secretsmanager" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

SecretsManager req = new SecretsManager() {
    Auth = new Dictionary<string, string>() {
        { "key", "<value>" },
        { "key1", "<value>" },
    },
    Name = "<value>",
    Type = SecretsManagerType.Akeyless,
};

var res = await sdk.Secretsmanager.CreateUnifiedSecretsmanagerAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [SecretsManager](../../Models/Components/SecretsManager.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[CreateUnifiedSecretsmanagerResponse](../../Models/Requests/CreateUnifiedSecretsmanagerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedSecretsmanager

Retrieve secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnifiedSecretsmanager" method="get" path="/unified/secretsmanager/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Secretsmanager.GetUnifiedSecretsmanagerAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `Id`                     | *string*                 | :heavy_check_mark:       | ID of the Secretsmanager |

### Response

**[GetUnifiedSecretsmanagerResponse](../../Models/Requests/GetUnifiedSecretsmanagerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedSecretsmanagerInstructions

List secrets manager setup instructions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedSecretsmanagerInstructions" method="get" path="/unified/secretsmanager/instructions" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Secretsmanager.ListUnifiedSecretsmanagerInstructionsAsync();

// handle response
```

### Response

**[ListUnifiedSecretsmanagerInstructionsResponse](../../Models/Requests/ListUnifiedSecretsmanagerInstructionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedSecretsmanagerSecrets

List secrets in a secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedSecretsmanagerSecrets" method="get" path="/unified/secretsmanager/secrets" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Secretsmanager.ListUnifiedSecretsmanagerSecretsAsync(secretsmanagerId: "<id>");

// handle response
```

### Parameters

| Parameter                                | Type                                     | Required                                 | Description                              |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `SecretsmanagerId`                       | *string*                                 | :heavy_check_mark:                       | The secrets manager to list secrets from |
| `Limit`                                  | *double*                                 | :heavy_minus_sign:                       | Maximum number of secrets to return      |
| `Offset`                                 | *double*                                 | :heavy_minus_sign:                       | Number of secrets to skip                |
| `Query`                                  | *string*                                 | :heavy_minus_sign:                       | Filter secrets by name                   |

### Response

**[ListUnifiedSecretsmanagerSecretsResponse](../../Models/Requests/ListUnifiedSecretsmanagerSecretsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedSecretsmanagers

List secrets managers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedSecretsmanagers" method="get" path="/unified/secretsmanager" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedSecretsmanagersRequest? req = null;

var res = await sdk.Secretsmanager.ListUnifiedSecretsmanagersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListUnifiedSecretsmanagersRequest](../../Models/Requests/ListUnifiedSecretsmanagersRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListUnifiedSecretsmanagersResponse](../../Models/Requests/ListUnifiedSecretsmanagersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUnifiedSecretsmanager

Remove secrets manager

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUnifiedSecretsmanager" method="delete" path="/unified/secretsmanager/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Secretsmanager.RemoveUnifiedSecretsmanagerAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `Id`                     | *string*                 | :heavy_check_mark:       | ID of the Secretsmanager |

### Response

**[RemoveUnifiedSecretsmanagerResponse](../../Models/Requests/RemoveUnifiedSecretsmanagerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |