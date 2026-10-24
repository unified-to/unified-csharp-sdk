# Repository

## Overview

### Available Operations

* [CreateRepoRepository](#createreporepository) - Create a repository
* [GetRepoRepository](#getreporepository) - Retrieve a repository
* [ListRepoRepositories](#listreporepositories) - List all repositories
* [PatchRepoRepository](#patchreporepository) - Update a repository
* [RemoveRepoRepository](#removereporepository) - Remove a repository
* [UpdateRepoRepository](#updatereporepository) - Update a repository

## CreateRepoRepository

Creates a RepoRepository. Provide the unified RepoRepository fields in the request body; they are mapped to the provider's API. Returns the created RepoRepository.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoRepository" method="post" path="/repo/{connection_id}/repository" example="repo_repository" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.CreateRepoRepositoryAsync(
    repoRepository: new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Sed somnus crastinus armarium.",
        Id = "1113380e-dc84-4f22-9e96-610cdd69ee10",
        IsPrivate = false,
        Metadata = new List<RepoMetadata>() {},
        Name = "bah-bogus",
        UpdatedAt = System.DateTime.Parse("2024-03-01T16:44:10.413Z").ToUniversalTime(),
        WebUrl = "https://neat-birdbath.org",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoRepository`                                                                                                                                 | [RepoRepository](../../Models/Components/RepoRepository.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoRepositoryQueryParamFields](../../Models/Requests/CreateRepoRepositoryQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoRepositoryResponse](../../Models/Requests/CreateRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoRepository

Retrieves a single RepoRepository by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoRepository" method="get" path="/repo/{connection_id}/repository/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repository.GetRepoRepositoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Repository                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetRepoRepositoryQueryParamFields](../../Models/Requests/GetRepoRepositoryQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoRepositoryResponse](../../Models/Requests/GetRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoRepositories

Returns a list of RepoRepositories. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoRepositories" method="get" path="/repo/{connection_id}/repository" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

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

Updates the RepoRepository identified by `id`. Provide the unified RepoRepository fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoRepository" method="patch" path="/repo/{connection_id}/repository/{id}" example="repo_repository" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoRepositoryRequest req = new PatchRepoRepositoryRequest() {
    RepoRepository = new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Sed somnus crastinus armarium.",
        Id = "090acb24-e2c0-4ac4-898e-b2dba1812a38",
        IsPrivate = false,
        Metadata = new List<RepoMetadata>() {},
        Name = "bah-bogus",
        UpdatedAt = System.DateTime.Parse("2024-03-01T16:44:10.416Z").ToUniversalTime(),
        WebUrl = "https://neat-birdbath.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repository.PatchRepoRepositoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchRepoRepositoryRequest](../../Models/Requests/PatchRepoRepositoryRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchRepoRepositoryResponse](../../Models/Requests/PatchRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoRepository

Deletes the RepoRepository identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoRepository" method="delete" path="/repo/{connection_id}/repository/{id}" -->
```csharp
using UnifiedTo;
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

Updates the RepoRepository identified by `id`. Provide the unified RepoRepository fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoRepository" method="put" path="/repo/{connection_id}/repository/{id}" example="repo_repository" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoRepositoryRequest req = new UpdateRepoRepositoryRequest() {
    RepoRepository = new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Sed somnus crastinus armarium.",
        Id = "090acb24-e2c0-4ac4-898e-b2dba1812a38",
        IsPrivate = false,
        Metadata = new List<RepoMetadata>() {},
        Name = "bah-bogus",
        UpdatedAt = System.DateTime.Parse("2024-03-01T16:44:10.416Z").ToUniversalTime(),
        WebUrl = "https://neat-birdbath.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repository.UpdateRepoRepositoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateRepoRepositoryRequest](../../Models/Requests/UpdateRepoRepositoryRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateRepoRepositoryResponse](../../Models/Requests/UpdateRepoRepositoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |