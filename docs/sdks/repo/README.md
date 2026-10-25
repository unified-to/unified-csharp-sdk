# Repo

## Overview

### Available Operations

* [CreateRepoBranch](#createrepobranch) - Create a branch
* [CreateRepoCommit](#createrepocommit) - Create a commit
* [CreateRepoOrganization](#createrepoorganization) - Create an organization
* [CreateRepoPullrequest](#createrepopullrequest) - Create a pullrequest
* [CreateRepoRepository](#createreporepository) - Create a repository
* [GetRepoBranch](#getrepobranch) - Retrieve a branch
* [GetRepoCommit](#getrepocommit) - Retrieve a commit
* [GetRepoOrganization](#getrepoorganization) - Retrieve an organization
* [GetRepoPullrequest](#getrepopullrequest) - Retrieve a pullrequest
* [GetRepoRepository](#getreporepository) - Retrieve a repository
* [ListRepoBranches](#listrepobranches) - List all branches
* [ListRepoCommits](#listrepocommits) - List all commits
* [ListRepoOrganizations](#listrepoorganizations) - List all organizations
* [ListRepoPullrequests](#listrepopullrequests) - List all pullrequests
* [ListRepoRepositories](#listreporepositories) - List all repositories
* [PatchRepoBranch](#patchrepobranch) - Update a branch
* [PatchRepoCommit](#patchrepocommit) - Update a commit
* [PatchRepoOrganization](#patchrepoorganization) - Update an organization
* [PatchRepoPullrequest](#patchrepopullrequest) - Update a pullrequest
* [PatchRepoRepository](#patchreporepository) - Update a repository
* [RemoveRepoBranch](#removerepobranch) - Remove a branch
* [RemoveRepoCommit](#removerepocommit) - Remove a commit
* [RemoveRepoOrganization](#removerepoorganization) - Remove an organization
* [RemoveRepoPullrequest](#removerepopullrequest) - Remove a pullrequest
* [RemoveRepoRepository](#removereporepository) - Remove a repository
* [UpdateRepoBranch](#updaterepobranch) - Update a branch
* [UpdateRepoCommit](#updaterepocommit) - Update a commit
* [UpdateRepoOrganization](#updaterepoorganization) - Update an organization
* [UpdateRepoPullrequest](#updaterepopullrequest) - Update a pullrequest
* [UpdateRepoRepository](#updatereporepository) - Update a repository

## CreateRepoBranch

Creates a RepoBranch. Provide the unified RepoBranch fields in the request body; they are mapped to the provider's API. Returns the created RepoBranch.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoBranch" method="post" path="/repo/{connection_id}/branch" example="repo_branch" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.CreateRepoBranchAsync(
    repoBranch: new RepoBranch() {
        CreatedAt = System.DateTime.Parse("2019-02-24T09:33:48.540Z").ToUniversalTime(),
        Id = "7c1073f9-8841-4088-813e-42f69aa604dd",
        Metadata = new List<RepoMetadata>() {},
        Name = "transmitter-calculate",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2020-01-07T18:52:32.716Z").ToUniversalTime(),
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
| `Fields`                                                                                                                                         | List<[CreateRepoBranchQueryParamFields](../../Models/Requests/CreateRepoBranchQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoBranchResponse](../../Models/Requests/CreateRepoBranchResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Repo.CreateRepoCommitAsync(
    repoCommit: new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "907f59e7-370e-4355-8632-8400a95e1146",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "quantify bluetooth bandwidth",
        Metadata = new List<RepoMetadata>() {},
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-06-02T02:43:46.404Z").ToUniversalTime(),
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

## CreateRepoOrganization

Creates a RepoOrganization. Provide the unified RepoOrganization fields in the request body; they are mapped to the provider's API. Returns the created RepoOrganization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoOrganization" method="post" path="/repo/{connection_id}/organization" example="repo_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.CreateRepoOrganizationAsync(
    repoOrganization: new RepoOrganization() {
        AvatarUrl = "https://picsum.photos/seed/fGl6Lb/3157/3173",
        CreatedAt = System.DateTime.Parse("2022-07-07T00:18:40.748Z").ToUniversalTime(),
        Description = "Trepide defendo supra testimonium ager.",
        Id = "7e366971-68d5-4c14-8f4d-edc0c9ba2850",
        Metadata = new List<RepoMetadata>() {},
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-22T16:09:50.238Z").ToUniversalTime(),
        WebUrl = "https://turbulent-overheard.biz",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoOrganization`                                                                                                                               | [RepoOrganization](../../Models/Components/RepoOrganization.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoOrganizationQueryParamFields](../../Models/Requests/CreateRepoOrganizationQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoOrganizationResponse](../../Models/Requests/CreateRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateRepoPullrequest

Creates a RepoPullrequest. Provide the unified RepoPullrequest fields in the request body; they are mapped to the provider's API. Returns the created RepoPullrequest.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoPullrequest" method="post" path="/repo/{connection_id}/pullrequest" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.CreateRepoPullrequestAsync(
    repoPullrequest: new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-05-03T22:50:24.002Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "0c25a8d5-f690-4482-a73d-0ac55f97da97",
        Labels = new List<string>() {
            "creptio",
            "tutamen",
        },
        Metadata = new List<RepoMetadata>() {},
        Notes = "Texo advoco bibo amet. Defero coadunatio turbo curtus. Consuasor aggero veritatis suggero adeo.",
        Status = RepoPullrequestStatus.Approved,
        Title = "reboot mobile application",
        UpdatedAt = System.DateTime.Parse("2026-01-20T10:45:25.946Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoPullrequest`                                                                                                                                | [RepoPullrequest](../../Models/Components/RepoPullrequest.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoPullrequestQueryParamFields](../../Models/Requests/CreateRepoPullrequestQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoPullrequestResponse](../../Models/Requests/CreateRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Repo.CreateRepoRepositoryAsync(
    repoRepository: new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Sed somnus crastinus armarium.",
        Id = "b0f13b34-361c-4030-be69-7eb00428102d",
        IsPrivate = false,
        Metadata = new List<RepoMetadata>() {},
        Name = "bah-bogus",
        UpdatedAt = System.DateTime.Parse("2024-03-01T22:32:13.442Z").ToUniversalTime(),
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

## GetRepoBranch

Retrieves a single RepoBranch by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoBranch" method="get" path="/repo/{connection_id}/branch/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.GetRepoBranchAsync(
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
| `Fields`                                                                                                                                         | List<[GetRepoBranchQueryParamFields](../../Models/Requests/GetRepoBranchQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoBranchResponse](../../Models/Requests/GetRepoBranchResponse.md)**

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

var res = await sdk.Repo.GetRepoCommitAsync(
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

## GetRepoOrganization

Retrieves a single RepoOrganization by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoOrganization" method="get" path="/repo/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.GetRepoOrganizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Organization                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetRepoOrganizationQueryParamFields](../../Models/Requests/GetRepoOrganizationQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoOrganizationResponse](../../Models/Requests/GetRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoPullrequest

Retrieves a single RepoPullrequest by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoPullrequest" method="get" path="/repo/{connection_id}/pullrequest/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.GetRepoPullrequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Pullrequest                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetRepoPullrequestQueryParamFields](../../Models/Requests/GetRepoPullrequestQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoPullrequestResponse](../../Models/Requests/GetRepoPullrequestResponse.md)**

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

var res = await sdk.Repo.GetRepoRepositoryAsync(
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

## ListRepoBranches

Returns a list of RepoBranches. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoBranches" method="get" path="/repo/{connection_id}/branch" -->
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

var res = await sdk.Repo.ListRepoBranchesAsync(req);

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

var res = await sdk.Repo.ListRepoCommitsAsync(req);

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

## ListRepoOrganizations

Returns a list of RepoOrganizations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoOrganizations" method="get" path="/repo/{connection_id}/organization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoOrganizationsRequest req = new ListRepoOrganizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Repo.ListRepoOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListRepoOrganizationsRequest](../../Models/Requests/ListRepoOrganizationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListRepoOrganizationsResponse](../../Models/Requests/ListRepoOrganizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoPullrequests

Returns a list of RepoPullrequests. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoPullrequests" method="get" path="/repo/{connection_id}/pullrequest" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoPullrequestsRequest req = new ListRepoPullrequestsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Repo.ListRepoPullrequestsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListRepoPullrequestsRequest](../../Models/Requests/ListRepoPullrequestsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListRepoPullrequestsResponse](../../Models/Requests/ListRepoPullrequestsResponse.md)**

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

var res = await sdk.Repo.ListRepoRepositoriesAsync(req);

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

## PatchRepoBranch

Updates the RepoBranch identified by `id`. Provide the unified RepoBranch fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoBranch" method="patch" path="/repo/{connection_id}/branch/{id}" example="repo_branch" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoBranchRequest req = new PatchRepoBranchRequest() {
    RepoBranch = new RepoBranch() {
        CreatedAt = System.DateTime.Parse("2019-02-24T09:33:48.540Z").ToUniversalTime(),
        Id = "ded63fc9-1155-4210-b927-cb74fbd22be3",
        Metadata = new List<RepoMetadata>() {},
        Name = "transmitter-calculate",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2020-01-07T18:52:32.717Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.PatchRepoBranchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchRepoBranchRequest](../../Models/Requests/PatchRepoBranchRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchRepoBranchResponse](../../Models/Requests/PatchRepoBranchResponse.md)**

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
        Id = "c8e59e0d-a523-452a-bd90-d90e685ba294",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "quantify bluetooth bandwidth",
        Metadata = new List<RepoMetadata>() {},
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-06-02T02:43:46.409Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.PatchRepoCommitAsync(req);

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

## PatchRepoOrganization

Updates the RepoOrganization identified by `id`. Provide the unified RepoOrganization fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoOrganization" method="patch" path="/repo/{connection_id}/organization/{id}" example="repo_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoOrganizationRequest req = new PatchRepoOrganizationRequest() {
    RepoOrganization = new RepoOrganization() {
        AvatarUrl = "https://picsum.photos/seed/fGl6Lb/3157/3173",
        CreatedAt = System.DateTime.Parse("2022-07-07T00:18:40.748Z").ToUniversalTime(),
        Description = "Trepide defendo supra testimonium ager.",
        Id = "2194376c-3105-43d7-9605-677aa2e784f0",
        Metadata = new List<RepoMetadata>() {},
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-22T16:09:50.242Z").ToUniversalTime(),
        WebUrl = "https://turbulent-overheard.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.PatchRepoOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchRepoOrganizationRequest](../../Models/Requests/PatchRepoOrganizationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchRepoOrganizationResponse](../../Models/Requests/PatchRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoPullrequest

Updates the RepoPullrequest identified by `id`. Provide the unified RepoPullrequest fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoPullrequest" method="patch" path="/repo/{connection_id}/pullrequest/{id}" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoPullrequestRequest req = new PatchRepoPullrequestRequest() {
    RepoPullrequest = new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-05-03T22:50:24.009Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "03983bd6-eb79-426b-9553-e89bf1c78940",
        Labels = new List<string>() {
            "creptio",
            "tutamen",
        },
        Metadata = new List<RepoMetadata>() {},
        Notes = "Texo advoco bibo amet. Defero coadunatio turbo curtus. Consuasor aggero veritatis suggero adeo.",
        Status = RepoPullrequestStatus.Approved,
        Title = "reboot mobile application",
        UpdatedAt = System.DateTime.Parse("2026-01-20T10:45:25.956Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.PatchRepoPullrequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchRepoPullrequestRequest](../../Models/Requests/PatchRepoPullrequestRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchRepoPullrequestResponse](../../Models/Requests/PatchRepoPullrequestResponse.md)**

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
        Id = "05fc0f9a-9b3b-42a5-8e3f-57e8e6f31f13",
        IsPrivate = false,
        Metadata = new List<RepoMetadata>() {},
        Name = "bah-bogus",
        UpdatedAt = System.DateTime.Parse("2024-03-01T22:32:13.445Z").ToUniversalTime(),
        WebUrl = "https://neat-birdbath.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.PatchRepoRepositoryAsync(req);

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

## RemoveRepoBranch

Deletes the RepoBranch identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoBranch" method="delete" path="/repo/{connection_id}/branch/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.RemoveRepoBranchAsync(
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

var res = await sdk.Repo.RemoveRepoCommitAsync(
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

## RemoveRepoOrganization

Deletes the RepoOrganization identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoOrganization" method="delete" path="/repo/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.RemoveRepoOrganizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Organization |

### Response

**[RemoveRepoOrganizationResponse](../../Models/Requests/RemoveRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoPullrequest

Deletes the RepoPullrequest identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoPullrequest" method="delete" path="/repo/{connection_id}/pullrequest/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.RemoveRepoPullrequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Pullrequest |

### Response

**[RemoveRepoPullrequestResponse](../../Models/Requests/RemoveRepoPullrequestResponse.md)**

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

var res = await sdk.Repo.RemoveRepoRepositoryAsync(
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

## UpdateRepoBranch

Updates the RepoBranch identified by `id`. Provide the unified RepoBranch fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoBranch" method="put" path="/repo/{connection_id}/branch/{id}" example="repo_branch" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoBranchRequest req = new UpdateRepoBranchRequest() {
    RepoBranch = new RepoBranch() {
        CreatedAt = System.DateTime.Parse("2019-02-24T09:33:48.540Z").ToUniversalTime(),
        Id = "ded63fc9-1155-4210-b927-cb74fbd22be3",
        Metadata = new List<RepoMetadata>() {},
        Name = "transmitter-calculate",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2020-01-07T18:52:32.717Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.UpdateRepoBranchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateRepoBranchRequest](../../Models/Requests/UpdateRepoBranchRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateRepoBranchResponse](../../Models/Requests/UpdateRepoBranchResponse.md)**

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
        Id = "c8e59e0d-a523-452a-bd90-d90e685ba294",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "quantify bluetooth bandwidth",
        Metadata = new List<RepoMetadata>() {},
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-06-02T02:43:46.409Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.UpdateRepoCommitAsync(req);

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

## UpdateRepoOrganization

Updates the RepoOrganization identified by `id`. Provide the unified RepoOrganization fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoOrganization" method="put" path="/repo/{connection_id}/organization/{id}" example="repo_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoOrganizationRequest req = new UpdateRepoOrganizationRequest() {
    RepoOrganization = new RepoOrganization() {
        AvatarUrl = "https://picsum.photos/seed/fGl6Lb/3157/3173",
        CreatedAt = System.DateTime.Parse("2022-07-07T00:18:40.748Z").ToUniversalTime(),
        Description = "Trepide defendo supra testimonium ager.",
        Id = "2194376c-3105-43d7-9605-677aa2e784f0",
        Metadata = new List<RepoMetadata>() {},
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-22T16:09:50.242Z").ToUniversalTime(),
        WebUrl = "https://turbulent-overheard.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.UpdateRepoOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateRepoOrganizationRequest](../../Models/Requests/UpdateRepoOrganizationRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateRepoOrganizationResponse](../../Models/Requests/UpdateRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoPullrequest

Updates the RepoPullrequest identified by `id`. Provide the unified RepoPullrequest fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoPullrequest" method="put" path="/repo/{connection_id}/pullrequest/{id}" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoPullrequestRequest req = new UpdateRepoPullrequestRequest() {
    RepoPullrequest = new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-05-03T22:50:24.009Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "03983bd6-eb79-426b-9553-e89bf1c78940",
        Labels = new List<string>() {
            "creptio",
            "tutamen",
        },
        Metadata = new List<RepoMetadata>() {},
        Notes = "Texo advoco bibo amet. Defero coadunatio turbo curtus. Consuasor aggero veritatis suggero adeo.",
        Status = RepoPullrequestStatus.Approved,
        Title = "reboot mobile application",
        UpdatedAt = System.DateTime.Parse("2026-01-20T10:45:25.956Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.UpdateRepoPullrequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateRepoPullrequestRequest](../../Models/Requests/UpdateRepoPullrequestRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateRepoPullrequestResponse](../../Models/Requests/UpdateRepoPullrequestResponse.md)**

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
        Id = "05fc0f9a-9b3b-42a5-8e3f-57e8e6f31f13",
        IsPrivate = false,
        Metadata = new List<RepoMetadata>() {},
        Name = "bah-bogus",
        UpdatedAt = System.DateTime.Parse("2024-03-01T22:32:13.445Z").ToUniversalTime(),
        WebUrl = "https://neat-birdbath.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Repo.UpdateRepoRepositoryAsync(req);

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