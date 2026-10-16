# Key

## Overview

### Available Operations

* [CreateComputeKey](#createcomputekey) - Create a key
* [GetComputeKey](#getcomputekey) - Retrieve a key
* [ListComputeKeys](#listcomputekeys) - List all keys
* [PatchComputeKey](#patchcomputekey) - Update a key
* [RemoveComputeKey](#removecomputekey) - Remove a key
* [UpdateComputeKey](#updatecomputekey) - Update a key

## CreateComputeKey

Create a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeKey" method="post" path="/compute/{connection_id}/key" example="compute_key" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Key.CreateComputeKeyAsync(
    computeKey: new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "5a07b344-049c-4dc8-85ca-8e29f1ea114e",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T04:36:32.102Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeKey`                                                                                                                                     | [ComputeKey](../../Models/Components/ComputeKey.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeKeyQueryParamFields](../../Models/Requests/CreateComputeKeyQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeKeyResponse](../../Models/Requests/CreateComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeKey

Retrieve a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeKey" method="get" path="/compute/{connection_id}/key/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Key.GetComputeKeyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Key                                                                                                                                    |
| `Fields`                                                                                                                                         | List<[GetComputeKeyQueryParamFields](../../Models/Requests/GetComputeKeyQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeKeyResponse](../../Models/Requests/GetComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeKeys

List all keys

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeKeys" method="get" path="/compute/{connection_id}/key" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeKeysRequest req = new ListComputeKeysRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Key.ListComputeKeysAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListComputeKeysRequest](../../Models/Requests/ListComputeKeysRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListComputeKeysResponse](../../Models/Requests/ListComputeKeysResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeKey

Update a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeKey" method="patch" path="/compute/{connection_id}/key/{id}" example="compute_key" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeKeyRequest req = new PatchComputeKeyRequest() {
    ComputeKey = new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "afea9d64-045e-4466-bb67-9e5016ad12c8",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T04:36:32.107Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Key.PatchComputeKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchComputeKeyRequest](../../Models/Requests/PatchComputeKeyRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchComputeKeyResponse](../../Models/Requests/PatchComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeKey

Remove a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeKey" method="delete" path="/compute/{connection_id}/key/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Key.RemoveComputeKeyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Key        |

### Response

**[RemoveComputeKeyResponse](../../Models/Requests/RemoveComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeKey

Update a key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeKey" method="put" path="/compute/{connection_id}/key/{id}" example="compute_key" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeKeyRequest req = new UpdateComputeKeyRequest() {
    ComputeKey = new ComputeKey() {
        CreatedAt = System.DateTime.Parse("2023-08-19T14:31:46.492Z").ToUniversalTime(),
        Id = "afea9d64-045e-4466-bb67-9e5016ad12c8",
        Name = "nienow-secret",
        Type = ComputeKeyType.Secret,
        UpdatedAt = System.DateTime.Parse("2024-10-05T04:36:32.107Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Key.UpdateComputeKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateComputeKeyRequest](../../Models/Requests/UpdateComputeKeyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateComputeKeyResponse](../../Models/Requests/UpdateComputeKeyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |