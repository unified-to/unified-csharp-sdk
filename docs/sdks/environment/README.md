# Environment
(*Environment*)

## Overview

### Available Operations

* [CreateUnifiedEnvironment](#createunifiedenvironment)
* [ListUnifiedEnvironments](#listunifiedenvironments)
* [RemoveUnifiedEnvironment](#removeunifiedenvironment)

## CreateUnifiedEnvironment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

List<string> req = new List<string>() {};

var res = await sdk.Environment.CreateUnifiedEnvironmentAsync(req);

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

## ListUnifiedEnvironments

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Environment.ListUnifiedEnvironmentsAsync();

// handle response
```

### Response

**[ListUnifiedEnvironmentsResponse](../../Models/Requests/ListUnifiedEnvironmentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUnifiedEnvironment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Environment.RemoveUnifiedEnvironmentAsync(env: "<value>");

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