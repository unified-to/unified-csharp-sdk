# Repository
(*Repository*)

## Overview

### Available Operations

* [CreateRepoRepository](#createreporepository) - Create a repository
* [GetRepoRepository](#getreporepository) - Retrieve a repository
* [ListRepoRepositories](#listreporepositories) - List all repositories
* [PatchRepoRepository](#patchreporepository) - Update a repository
* [RemoveRepoRepository](#removereporepository) - Remove a repository
* [UpdateRepoRepository](#updatereporepository) - Update a repository

## CreateRepoRepository

Create a repository

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.CreateRepoRepositoryAsync(
    connectionId: "<id>",
    repoRepository: new RepoRepository() {
        Name = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `RepoRepository`                                            | [RepoRepository](../../Models/Components/RepoRepository.md) | :heavy_minus_sign:                                          | N/A                                                         |
| `Fields`                                                    | List<*string*>                                              | :heavy_minus_sign:                                          | Comma-delimited fields to return                            |

### Response

**[CreateRepoRepositoryResponse](../../Models/Requests/CreateRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoRepository

Retrieve a repository

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.GetRepoRepositoryAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Repository             |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetRepoRepositoryResponse](../../Models/Requests/GetRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoRepositories

List all repositories

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoRepositoriesRequest req = new ListRepoRepositoriesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Repository.ListRepoRepositoriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListRepoRepositoriesRequest](../../Models/Requests/ListRepoRepositoriesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListRepoRepositoriesResponse](../../Models/Requests/ListRepoRepositoriesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoRepository

Update a repository

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.PatchRepoRepositoryAsync(
    connectionId: "<id>",
    id: "<id>",
    repoRepository: new RepoRepository() {
        Name = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Repository                                        |
| `RepoRepository`                                            | [RepoRepository](../../Models/Components/RepoRepository.md) | :heavy_minus_sign:                                          | N/A                                                         |
| `Fields`                                                    | List<*string*>                                              | :heavy_minus_sign:                                          | Comma-delimited fields to return                            |

### Response

**[PatchRepoRepositoryResponse](../../Models/Requests/PatchRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoRepository

Remove a repository

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.RemoveRepoRepositoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Repository |

### Response

**[RemoveRepoRepositoryResponse](../../Models/Requests/RemoveRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoRepository

Update a repository

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.UpdateRepoRepositoryAsync(
    connectionId: "<id>",
    id: "<id>",
    repoRepository: new RepoRepository() {
        Name = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Repository                                        |
| `RepoRepository`                                            | [RepoRepository](../../Models/Components/RepoRepository.md) | :heavy_minus_sign:                                          | N/A                                                         |
| `Fields`                                                    | List<*string*>                                              | :heavy_minus_sign:                                          | Comma-delimited fields to return                            |

### Response

**[UpdateRepoRepositoryResponse](../../Models/Requests/UpdateRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |