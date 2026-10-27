# Commit

## Overview

### Available Operations

* [CreateRepoCommit](#createrepocommit) - Create a commit
* [GetRepoCommit](#getrepocommit) - Retrieve a commit
* [ListRepoCommits](#listrepocommits) - List all commits
* [PatchRepoCommit](#patchrepocommit) - Update a commit
* [RemoveRepoCommit](#removerepocommit) - Remove a commit
* [UpdateRepoCommit](#updaterepocommit) - Update a commit

## CreateRepoCommit

Creates a RepoCommit. Provide the unified RepoCommit fields in the request body; they are mapped to the provider's API. Returns the created RepoCommit.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoCommit" method="post" path="/repo/{connection_id}/commit" example="repo_commit" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commit.CreateRepoCommitAsync(
    repoCommit: new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "53cc9878-b38b-486f-bff6-70a1203466ef",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "quantify bluetooth bandwidth",
        Metadata = new List<RepoMetadata>() {},
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-06-03T01:15:11.153Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoCommit`                                                                                                                                     | [RepoCommit](../../Models/Components/RepoCommit.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoCommitQueryParamFields](../../Models/Requests/CreateRepoCommitQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoCommitResponse](../../Models/Requests/CreateRepoCommitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoCommit

Retrieves a single RepoCommit by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoCommit" method="get" path="/repo/{connection_id}/commit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commit.GetRepoCommitAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Commit                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetRepoCommitQueryParamFields](../../Models/Requests/GetRepoCommitQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoCommitResponse](../../Models/Requests/GetRepoCommitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoCommits

Returns a list of RepoCommits. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoCommits" method="get" path="/repo/{connection_id}/commit" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoCommitsRequest req = new ListRepoCommitsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Commit.ListRepoCommitsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListRepoCommitsRequest](../../Models/Requests/ListRepoCommitsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListRepoCommitsResponse](../../Models/Requests/ListRepoCommitsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoCommit

Updates the RepoCommit identified by `id`. Provide the unified RepoCommit fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoCommit" method="patch" path="/repo/{connection_id}/commit/{id}" example="repo_commit" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoCommitRequest req = new PatchRepoCommitRequest() {
    RepoCommit = new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "9092854c-d361-44ed-bfae-6397b8b3dc21",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "quantify bluetooth bandwidth",
        Metadata = new List<RepoMetadata>() {},
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-06-03T01:15:11.161Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commit.PatchRepoCommitAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchRepoCommitRequest](../../Models/Requests/PatchRepoCommitRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchRepoCommitResponse](../../Models/Requests/PatchRepoCommitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoCommit

Deletes the RepoCommit identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoCommit" method="delete" path="/repo/{connection_id}/commit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commit.RemoveRepoCommitAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Commit     |

### Response

**[RemoveRepoCommitResponse](../../Models/Requests/RemoveRepoCommitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoCommit

Updates the RepoCommit identified by `id`. Provide the unified RepoCommit fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoCommit" method="put" path="/repo/{connection_id}/commit/{id}" example="repo_commit" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoCommitRequest req = new UpdateRepoCommitRequest() {
    RepoCommit = new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "9092854c-d361-44ed-bfae-6397b8b3dc21",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "quantify bluetooth bandwidth",
        Metadata = new List<RepoMetadata>() {},
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-06-03T01:15:11.161Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commit.UpdateRepoCommitAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateRepoCommitRequest](../../Models/Requests/UpdateRepoCommitRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateRepoCommitResponse](../../Models/Requests/UpdateRepoCommitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |