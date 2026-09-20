# Project

## Overview

### Available Operations

* [CreateAccountingProject](#createaccountingproject) - Create a project
* [CreateTaskProject](#createtaskproject) - Create a project
* [GetAccountingProject](#getaccountingproject) - Retrieve a project
* [GetTaskProject](#gettaskproject) - Retrieve a project
* [ListAccountingProjects](#listaccountingprojects) - List all projects
* [ListTaskProjects](#listtaskprojects) - List all projects
* [PatchAccountingProject](#patchaccountingproject) - Update a project
* [PatchTaskProject](#patchtaskproject) - Update a project
* [RemoveAccountingProject](#removeaccountingproject) - Remove a project
* [RemoveTaskProject](#removetaskproject) - Remove a project
* [UpdateAccountingProject](#updateaccountingproject) - Update a project
* [UpdateTaskProject](#updatetaskproject) - Update a project

## CreateAccountingProject

Create a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingProject" method="post" path="/accounting/{connection_id}/project" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Project.CreateAccountingProjectAsync(
    accountingProject: new AccountingProject() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingProject`                                                                                                                              | [AccountingProject](../../Models/Components/AccountingProject.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingProjectQueryParamFields](../../Models/Requests/CreateAccountingProjectQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingProjectResponse](../../Models/Requests/CreateAccountingProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateTaskProject

Create a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTaskProject" method="post" path="/task/{connection_id}/project" example="task_project" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Project.CreateTaskProjectAsync(
    taskProject: new TaskProject() {
        CreatedAt = System.DateTime.Parse("2023-06-23T16:39:40.446Z").ToUniversalTime(),
        Description = "Valetudo aggredior accommodo curiositas vox.",
        HasChildren = false,
        HasTasks = false,
        Id = "17d0c2b2-c535-419c-b342-86aa616c6c00",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "01668141-d239-403c-b6b8-f22cb2317e34",
                Namespace = "custom",
                Slug = "decens",
                Value = TaskMetadataValue.CreateStr(
                    "uterque"
                ),
            },
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "39873a04-1aee-4122-8c33-15219054714c",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-08T19:14:30.589Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TaskProject`                                                                                                                                    | [TaskProject](../../Models/Components/TaskProject.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTaskProjectQueryParamFields](../../Models/Requests/CreateTaskProjectQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTaskProjectResponse](../../Models/Requests/CreateTaskProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingProject

Retrieve a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingProject" method="get" path="/accounting/{connection_id}/project/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Project.GetAccountingProjectAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Project                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAccountingProjectQueryParamFields](../../Models/Requests/GetAccountingProjectQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingProjectResponse](../../Models/Requests/GetAccountingProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTaskProject

Retrieve a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTaskProject" method="get" path="/task/{connection_id}/project/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Project.GetTaskProjectAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Project                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetTaskProjectQueryParamFields](../../Models/Requests/GetTaskProjectQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTaskProjectResponse](../../Models/Requests/GetTaskProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingProjects

List all projects

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingProjects" method="get" path="/accounting/{connection_id}/project" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingProjectsRequest req = new ListAccountingProjectsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Project.ListAccountingProjectsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingProjectsRequest](../../Models/Requests/ListAccountingProjectsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingProjectsResponse](../../Models/Requests/ListAccountingProjectsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTaskProjects

List all projects

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTaskProjects" method="get" path="/task/{connection_id}/project" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTaskProjectsRequest req = new ListTaskProjectsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Project.ListTaskProjectsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListTaskProjectsRequest](../../Models/Requests/ListTaskProjectsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListTaskProjectsResponse](../../Models/Requests/ListTaskProjectsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingProject

Update a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingProject" method="patch" path="/accounting/{connection_id}/project/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingProjectRequest req = new PatchAccountingProjectRequest() {
    AccountingProject = new AccountingProject() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Project.PatchAccountingProjectAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingProjectRequest](../../Models/Requests/PatchAccountingProjectRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingProjectResponse](../../Models/Requests/PatchAccountingProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchTaskProject

Update a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTaskProject" method="patch" path="/task/{connection_id}/project/{id}" example="task_project" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTaskProjectRequest req = new PatchTaskProjectRequest() {
    TaskProject = new TaskProject() {
        CreatedAt = System.DateTime.Parse("2023-06-23T16:39:40.446Z").ToUniversalTime(),
        Description = "Valetudo aggredior accommodo curiositas vox.",
        HasChildren = false,
        HasTasks = false,
        Id = "006fce6c-5db2-4c17-8ac0-7f5b4cdfab1a",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "40029eae-269a-4739-8af4-e758cb9913d6",
                Namespace = "custom",
                Slug = "decens",
                Value = TaskMetadataValue.CreateStr(
                    "uterque"
                ),
            },
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "d964c58d-9ac3-4e09-8ecb-676d313cc29f",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-08T19:14:30.590Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Project.PatchTaskProjectAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchTaskProjectRequest](../../Models/Requests/PatchTaskProjectRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchTaskProjectResponse](../../Models/Requests/PatchTaskProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingProject

Remove a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingProject" method="delete" path="/accounting/{connection_id}/project/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Project.RemoveAccountingProjectAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Project    |

### Response

**[RemoveAccountingProjectResponse](../../Models/Requests/RemoveAccountingProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveTaskProject

Remove a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTaskProject" method="delete" path="/task/{connection_id}/project/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Project.RemoveTaskProjectAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Project    |

### Response

**[RemoveTaskProjectResponse](../../Models/Requests/RemoveTaskProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingProject

Update a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingProject" method="put" path="/accounting/{connection_id}/project/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingProjectRequest req = new UpdateAccountingProjectRequest() {
    AccountingProject = new AccountingProject() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Project.UpdateAccountingProjectAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingProjectRequest](../../Models/Requests/UpdateAccountingProjectRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingProjectResponse](../../Models/Requests/UpdateAccountingProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateTaskProject

Update a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTaskProject" method="put" path="/task/{connection_id}/project/{id}" example="task_project" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTaskProjectRequest req = new UpdateTaskProjectRequest() {
    TaskProject = new TaskProject() {
        CreatedAt = System.DateTime.Parse("2023-06-23T16:39:40.446Z").ToUniversalTime(),
        Description = "Valetudo aggredior accommodo curiositas vox.",
        HasChildren = false,
        HasTasks = false,
        Id = "006fce6c-5db2-4c17-8ac0-7f5b4cdfab1a",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "40029eae-269a-4739-8af4-e758cb9913d6",
                Namespace = "custom",
                Slug = "decens",
                Value = TaskMetadataValue.CreateStr(
                    "uterque"
                ),
            },
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "d964c58d-9ac3-4e09-8ecb-676d313cc29f",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-08T19:14:30.590Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Project.UpdateTaskProjectAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateTaskProjectRequest](../../Models/Requests/UpdateTaskProjectRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateTaskProjectResponse](../../Models/Requests/UpdateTaskProjectResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |