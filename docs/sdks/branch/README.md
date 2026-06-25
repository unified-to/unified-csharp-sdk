# Branch
(*Branch*)

## Overview

### Available Operations

* [CreateRepoBranch2](#createrepobranch2) - Create a branch
* [GetRepoBranch2](#getrepobranch2) - Retrieve a branch
* [ListRepoBranches2](#listrepobranches2) - List all branches
* [PatchRepoBranch2](#patchrepobranch2) - Update a branch
* [RemoveRepoBranch2](#removerepobranch2) - Remove a branch
* [UpdateRepoBranch2](#updaterepobranch2) - Update a branch

## CreateRepoBranch2

Create a branch

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.CreateRepoBranch2Async(
    repoBranch: new RepoBranch() {
        Name = "<value>",
        RepoId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoBranch`                                                                                                                                     | [RepoBranch](../../Models/Components/RepoBranch.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoBranch2QueryParamFields](../../Models/Requests/CreateRepoBranch2QueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoBranch2Response](../../Models/Requests/CreateRepoBranch2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoBranch2

Retrieve a branch

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.GetRepoBranch2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Branch                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetRepoBranch2QueryParamFields](../../Models/Requests/GetRepoBranch2QueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoBranch2Response](../../Models/Requests/GetRepoBranch2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoBranches2

List all branches

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoBranches2Request req = new ListRepoBranches2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Branch.ListRepoBranches2Async(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListRepoBranches2Request](../../Models/Requests/ListRepoBranches2Request.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListRepoBranches2Response](../../Models/Requests/ListRepoBranches2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoBranch2

Update a branch

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoBranch2Request req = new PatchRepoBranch2Request() {
    RepoBranch = new RepoBranch() {
        Name = "<value>",
        RepoId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Branch.PatchRepoBranch2Async(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchRepoBranch2Request](../../Models/Requests/PatchRepoBranch2Request.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchRepoBranch2Response](../../Models/Requests/PatchRepoBranch2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoBranch2

Remove a branch

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.RemoveRepoBranch2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Branch     |

### Response

**[RemoveRepoBranch2Response](../../Models/Requests/RemoveRepoBranch2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoBranch2

Update a branch

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoBranch2Request req = new UpdateRepoBranch2Request() {
    RepoBranch = new RepoBranch() {
        Name = "<value>",
        RepoId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Branch.UpdateRepoBranch2Async(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateRepoBranch2Request](../../Models/Requests/UpdateRepoBranch2Request.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateRepoBranch2Response](../../Models/Requests/UpdateRepoBranch2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |