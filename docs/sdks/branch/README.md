# Branch
(*Branch*)

## Overview

### Available Operations

* [CreateRepoBranch](#createrepobranch) - Create a branch
* [GetRepoBranch](#getrepobranch) - Retrieve a branch
* [ListRepoBranches](#listrepobranches) - List all branches
* [PatchRepoBranch](#patchrepobranch) - Update a branch
* [RemoveRepoBranch](#removerepobranch) - Remove a branch
* [UpdateRepoBranch](#updaterepobranch) - Update a branch

## CreateRepoBranch

Create a branch

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.CreateRepoBranchAsync(
    repoBranch: new RepoBranch() {
        Name = "<value>",
        RepoId = "<id>",
    },
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `RepoBranch`                                        | [RepoBranch](../../Models/Components/RepoBranch.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |

### Response

**[CreateRepoBranchResponse](../../Models/Requests/CreateRepoBranchResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoBranch

Retrieve a branch

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.GetRepoBranchAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Branch                 |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetRepoBranchResponse](../../Models/Requests/GetRepoBranchResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoBranches

List all branches

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoBranchesRequest req = new ListRepoBranchesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Branch.ListRepoBranchesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListRepoBranchesRequest](../../Models/Requests/ListRepoBranchesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListRepoBranchesResponse](../../Models/Requests/ListRepoBranchesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoBranch

Update a branch

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.PatchRepoBranchAsync(
    repoBranch: new RepoBranch() {
        Name = "<value>",
        RepoId = "<id>",
    },
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `RepoBranch`                                        | [RepoBranch](../../Models/Components/RepoBranch.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | ID of the Branch                                    |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |

### Response

**[PatchRepoBranchResponse](../../Models/Requests/PatchRepoBranchResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoBranch

Remove a branch

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.RemoveRepoBranchAsync(
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

**[RemoveRepoBranchResponse](../../Models/Requests/RemoveRepoBranchResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoBranch

Update a branch

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Branch.UpdateRepoBranchAsync(
    repoBranch: new RepoBranch() {
        Name = "<value>",
        RepoId = "<id>",
    },
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `RepoBranch`                                        | [RepoBranch](../../Models/Components/RepoBranch.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | ID of the Branch                                    |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |

### Response

**[UpdateRepoBranchResponse](../../Models/Requests/UpdateRepoBranchResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |