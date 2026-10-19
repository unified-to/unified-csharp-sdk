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

Create a branch

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoBranch" method="post" path="/repo/{connection_id}/branch" example="repo_branch" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.CreateRepoBranchAsync(
    repoBranch: new RepoBranch() {
        CreatedAt = System.DateTime.Parse("2019-02-24T09:33:48.540Z").ToUniversalTime(),
        Id = "444c1bd7-acdc-41ca-a793-8bdfa3edc225",
        Name = "voluptas",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2020-01-07T02:24:18.420Z").ToUniversalTime(),
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

Create a commit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoCommit" method="post" path="/repo/{connection_id}/commit" example="repo_commit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.CreateRepoCommitAsync(
    repoCommit: new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "7d962e38-c661-4520-991c-b90f8c9c81e6",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "Auctus ascisco esse attollo clarus odio tum bis rerum.",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-05-30T07:59:18.572Z").ToUniversalTime(),
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

Create an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoOrganization" method="post" path="/repo/{connection_id}/organization" example="repo_organization" -->
```csharp
using System;
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
        Id = "b6b7a06b-b475-4e15-8143-1a2e201d1f58",
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-21T02:05:36.958Z").ToUniversalTime(),
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

Create a pullrequest

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
        ClosedAt = System.DateTime.Parse("2025-04-30T08:11:30.604Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "5347ba03-7f8a-4376-9621-44dae4512352",
        Labels = new List<string>() {
            "adhuc",
            "quaerat",
        },
        Notes = "Coadunatio turbo curtus ceno consuasor aggero. Suggero adeo creptio tutamen vulnus aqua delicate adopto derelinquo caritas. Maiores vulgivagus succurro temporibus.",
        SourceBranchId = "microchip-navigate",
        Status = RepoPullrequestStatus.Rejected,
        TargetBranchId = "feed-reboot",
        Title = "Cunae aegrus averto texo advoco bibo amet asporto.",
        UpdatedAt = System.DateTime.Parse("2025-01-16T00:10:29.888Z").ToUniversalTime(),
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

Create a repository

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoRepository" method="post" path="/repo/{connection_id}/repository" example="repo_repository" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Repo.CreateRepoRepositoryAsync(
    repoRepository: new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Tribuo torqueo aetas ustulo illum.",
        Id = "6dab57e8-6299-4bec-ab99-a9d412258619",
        IsPrivate = false,
        Name = "suggero",
        Owner = "Marcella Kuhic",
        UpdatedAt = System.DateTime.Parse("2024-02-29T15:25:25.678Z").ToUniversalTime(),
        WebUrl = "https://brown-phrase.info",
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

Retrieve a branch

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

Retrieve a commit

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

Retrieve an organization

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

Retrieve a pullrequest

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

Retrieve a repository

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

List all branches

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

List all commits

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

List all organizations

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

List all pullrequests

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

List all repositories

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

Update a branch

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoBranch" method="patch" path="/repo/{connection_id}/branch/{id}" example="repo_branch" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoBranchRequest req = new PatchRepoBranchRequest() {
    RepoBranch = new RepoBranch() {
        CreatedAt = System.DateTime.Parse("2019-02-24T09:33:48.540Z").ToUniversalTime(),
        Id = "a056cb26-2176-48ec-af7e-96275f891762",
        Name = "voluptas",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2020-01-07T02:24:18.420Z").ToUniversalTime(),
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

Update a commit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoCommit" method="patch" path="/repo/{connection_id}/commit/{id}" example="repo_commit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoCommitRequest req = new PatchRepoCommitRequest() {
    RepoCommit = new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "d4a3f21b-0be3-494f-9705-a454b9d5df97",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "Auctus ascisco esse attollo clarus odio tum bis rerum.",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-05-30T07:59:18.576Z").ToUniversalTime(),
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

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoOrganization" method="patch" path="/repo/{connection_id}/organization/{id}" example="repo_organization" -->
```csharp
using System;
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
        Id = "e9fe0aab-da73-4ff6-8be0-329f1b91b31c",
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-21T02:05:36.960Z").ToUniversalTime(),
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

Update a pullrequest

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
        ClosedAt = System.DateTime.Parse("2025-04-30T08:11:30.611Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "103f5c8e-e08e-44f8-b607-57c3fdffa02a",
        Labels = new List<string>() {
            "adhuc",
            "quaerat",
        },
        Notes = "Coadunatio turbo curtus ceno consuasor aggero. Suggero adeo creptio tutamen vulnus aqua delicate adopto derelinquo caritas. Maiores vulgivagus succurro temporibus.",
        SourceBranchId = "microchip-navigate",
        Status = RepoPullrequestStatus.Rejected,
        TargetBranchId = "feed-reboot",
        Title = "Cunae aegrus averto texo advoco bibo amet asporto.",
        UpdatedAt = System.DateTime.Parse("2025-01-16T00:10:29.894Z").ToUniversalTime(),
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

Update a repository

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoRepository" method="patch" path="/repo/{connection_id}/repository/{id}" example="repo_repository" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoRepositoryRequest req = new PatchRepoRepositoryRequest() {
    RepoRepository = new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Tribuo torqueo aetas ustulo illum.",
        Id = "151a9e17-bad0-42c5-81bb-7b845ac7008b",
        IsPrivate = false,
        Name = "suggero",
        Owner = "Marcella Kuhic",
        UpdatedAt = System.DateTime.Parse("2024-02-29T15:25:25.681Z").ToUniversalTime(),
        WebUrl = "https://brown-phrase.info",
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

Remove a branch

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

Remove a commit

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

Remove an organization

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

Remove a pullrequest

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

Remove a repository

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

Update a branch

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoBranch" method="put" path="/repo/{connection_id}/branch/{id}" example="repo_branch" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoBranchRequest req = new UpdateRepoBranchRequest() {
    RepoBranch = new RepoBranch() {
        CreatedAt = System.DateTime.Parse("2019-02-24T09:33:48.540Z").ToUniversalTime(),
        Id = "a056cb26-2176-48ec-af7e-96275f891762",
        Name = "voluptas",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2020-01-07T02:24:18.420Z").ToUniversalTime(),
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

Update a commit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoCommit" method="put" path="/repo/{connection_id}/commit/{id}" example="repo_commit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoCommitRequest req = new UpdateRepoCommitRequest() {
    RepoCommit = new RepoCommit() {
        CreatedAt = System.DateTime.Parse("2020-07-12T16:20:42.520Z").ToUniversalTime(),
        Id = "d4a3f21b-0be3-494f-9705-a454b9d5df97",
        LinesAdded = 313D,
        LinesChanged = 659D,
        LinesDeleted = 482D,
        Message = "Auctus ascisco esse attollo clarus odio tum bis rerum.",
        RepoId = "<id>",
        UpdatedAt = System.DateTime.Parse("2023-05-30T07:59:18.576Z").ToUniversalTime(),
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

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoOrganization" method="put" path="/repo/{connection_id}/organization/{id}" example="repo_organization" -->
```csharp
using System;
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
        Id = "e9fe0aab-da73-4ff6-8be0-329f1b91b31c",
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-21T02:05:36.960Z").ToUniversalTime(),
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

Update a pullrequest

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
        ClosedAt = System.DateTime.Parse("2025-04-30T08:11:30.611Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "103f5c8e-e08e-44f8-b607-57c3fdffa02a",
        Labels = new List<string>() {
            "adhuc",
            "quaerat",
        },
        Notes = "Coadunatio turbo curtus ceno consuasor aggero. Suggero adeo creptio tutamen vulnus aqua delicate adopto derelinquo caritas. Maiores vulgivagus succurro temporibus.",
        SourceBranchId = "microchip-navigate",
        Status = RepoPullrequestStatus.Rejected,
        TargetBranchId = "feed-reboot",
        Title = "Cunae aegrus averto texo advoco bibo amet asporto.",
        UpdatedAt = System.DateTime.Parse("2025-01-16T00:10:29.894Z").ToUniversalTime(),
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

Update a repository

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoRepository" method="put" path="/repo/{connection_id}/repository/{id}" example="repo_repository" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoRepositoryRequest req = new UpdateRepoRepositoryRequest() {
    RepoRepository = new RepoRepository() {
        CreatedAt = System.DateTime.Parse("2023-06-12T09:42:00.080Z").ToUniversalTime(),
        Description = "Tribuo torqueo aetas ustulo illum.",
        Id = "151a9e17-bad0-42c5-81bb-7b845ac7008b",
        IsPrivate = false,
        Name = "suggero",
        Owner = "Marcella Kuhic",
        UpdatedAt = System.DateTime.Parse("2024-02-29T15:25:25.681Z").ToUniversalTime(),
        WebUrl = "https://brown-phrase.info",
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