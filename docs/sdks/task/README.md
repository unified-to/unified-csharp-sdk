# Task

## Overview

### Available Operations

* [CreateGenaiTask](#creategenaitask) - Create a task
* [CreateTaskComment](#createtaskcomment) - Create a comment
* [CreateTaskProject](#createtaskproject) - Create a project
* [CreateTaskTask](#createtasktask) - Create a task
* [GetGenaiTask](#getgenaitask) - Retrieve a task
* [GetTaskChange](#gettaskchange) - Retrieve a change
* [GetTaskComment](#gettaskcomment) - Retrieve a comment
* [GetTaskProject](#gettaskproject) - Retrieve a project
* [GetTaskTask](#gettasktask) - Retrieve a task
* [ListGenaiTasks](#listgenaitasks) - List all tasks
* [ListTaskChanges](#listtaskchanges) - List all changes
* [ListTaskComments](#listtaskcomments) - List all comments
* [ListTaskProjects](#listtaskprojects) - List all projects
* [ListTaskTasks](#listtasktasks) - List all tasks
* [PatchGenaiTask](#patchgenaitask) - Update a task
* [PatchTaskComment](#patchtaskcomment) - Update a comment
* [PatchTaskProject](#patchtaskproject) - Update a project
* [PatchTaskTask](#patchtasktask) - Update a task
* [RemoveGenaiTask](#removegenaitask) - Remove a task
* [RemoveTaskComment](#removetaskcomment) - Remove a comment
* [RemoveTaskProject](#removetaskproject) - Remove a project
* [RemoveTaskTask](#removetasktask) - Remove a task
* [UpdateGenaiTask](#updategenaitask) - Update a task
* [UpdateTaskComment](#updatetaskcomment) - Update a comment
* [UpdateTaskProject](#updatetaskproject) - Update a project
* [UpdateTaskTask](#updatetasktask) - Update a task

## CreateGenaiTask

Create a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiTask" method="post" path="/genai/{connection_id}/task" example="genai_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.CreateGenaiTaskAsync(
    genaiTask: new GenaiTask() {
        CompletedAt = System.DateTime.Parse("2025-09-30T06:45:33.960Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "6599ee62-f68d-4af4-9401-9a20fa767411",
        Instructions = "Benigne canonicus officiis solvo adsidue deleo angustus.",
        LinesAdded = 244D,
        LinesDeleted = 118D,
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Stultus esse cursim stabilis tenetur amet contigo tristis.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
        },
        Name = "connect multi-byte port",
        PullrequestUrl = "https://github.com/berenice.satterfield/joshingly-ignorance/pull/383",
        RepoUrl = "https://github.com/berenice.satterfield/joshingly-ignorance",
        SourceBranchIdentifier = "main",
        StartedAt = System.DateTime.Parse("2024-05-20T17:11:38.714Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-25T19:55:26.296Z").ToUniversalTime(),
        WebUrl = "https://inexperienced-adrenalin.biz/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiTask`                                                                                                                                      | [GenaiTask](../../Models/Components/GenaiTask.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiTaskQueryParamFields](../../Models/Requests/CreateGenaiTaskQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiTaskResponse](../../Models/Requests/CreateGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateTaskComment

Create a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTaskComment" method="post" path="/task/{connection_id}/comment" example="task_comment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.CreateTaskCommentAsync(
    taskComment: new TaskComment() {
        CreatedAt = System.DateTime.Parse("2019-10-12T20:33:37.879Z").ToUniversalTime(),
        HasChildren = true,
        Id = "ecc84e47-8776-4c9e-a58e-6bfaa0a2250b",
        Metadata = new List<TaskMetadata>() {},
        Text = "Colo ulciscor sublime tabernus.",
        UpdatedAt = System.DateTime.Parse("2021-10-02T23:49:51.413Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TaskComment`                                                                                                                                    | [TaskComment](../../Models/Components/TaskComment.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTaskCommentQueryParamFields](../../Models/Requests/CreateTaskCommentQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTaskCommentResponse](../../Models/Requests/CreateTaskCommentResponse.md)**

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

var res = await sdk.Task.CreateTaskProjectAsync(
    taskProject: new TaskProject() {
        CreatedAt = System.DateTime.Parse("2023-06-23T16:39:40.446Z").ToUniversalTime(),
        Description = "Valetudo aggredior accommodo curiositas vox.",
        HasChildren = false,
        HasTasks = false,
        Id = "dbd65bef-f72b-43ca-8f34-e4d6093e4d78",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "327cf0c8-3a7d-4c8c-8712-ee2f6290f006",
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
                Id = "f6b10d61-197b-457e-bb81-5407f859f664",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-11T11:53:04.761Z").ToUniversalTime(),
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

## CreateTaskTask

Create a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTaskTask" method="post" path="/task/{connection_id}/task" example="task_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.CreateTaskTaskAsync(
    taskTask: new TaskTask() {
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-01-31T08:34:55.626Z").ToUniversalTime(),
        DueAt = System.DateTime.Parse("2025-09-10T17:33:46.629Z").ToUniversalTime(),
        HasChildren = true,
        Id = "b50f5468-93fe-4660-9d3a-6e4f27c22fde",
        Metadata = new List<TaskMetadata>() {},
        Name = "I'll compress the optical IB interface, that should capacitor the JBOD system!",
        Notes = "Argentum ventosus rem talis neque thymbra. Absconditus peccatus crustulum tollo cometes volva vacuus eos cedo. Somnus utpote coadunatio denuncio adopto autus sono atrocitas. Concido rerum cura aveho torqueo tempore tubineus vomer tempore suscipit. Clibanus valetudo vulnero pauper caput absorbeo correptius vir deduco.",
        Priority = "MEDIUM",
        Progress = 33D,
        StartAt = System.DateTime.Parse("2025-08-13T07:42:17.667Z").ToUniversalTime(),
        Status = TaskTaskStatus.Opened,
        StoryPoints = 0D,
        Tags = new List<string>() {
            "curis",
            "crinis",
        },
        TimeSpent = 5359D,
        TimeSpentUnit = "SECONDS",
        Type = "magni",
        UpdatedAt = System.DateTime.Parse("2022-04-06T14:14:34.369Z").ToUniversalTime(),
        Url = "https://elementary-utilization.net/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TaskTask`                                                                                                                                       | [TaskTask](../../Models/Components/TaskTask.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateTaskTaskQueryParamFields](../../Models/Requests/CreateTaskTaskQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateTaskTaskResponse](../../Models/Requests/CreateTaskTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiTask

Retrieve a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiTask" method="get" path="/genai/{connection_id}/task/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.GetGenaiTaskAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Task                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetGenaiTaskQueryParamFields](../../Models/Requests/GetGenaiTaskQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiTaskResponse](../../Models/Requests/GetGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTaskChange

Retrieve a change

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTaskChange" method="get" path="/task/{connection_id}/change/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.GetTaskChangeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Change                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetTaskChangeQueryParamFields](../../Models/Requests/GetTaskChangeQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTaskChangeResponse](../../Models/Requests/GetTaskChangeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTaskComment

Retrieve a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTaskComment" method="get" path="/task/{connection_id}/comment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.GetTaskCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Comment                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetTaskCommentQueryParamFields](../../Models/Requests/GetTaskCommentQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTaskCommentResponse](../../Models/Requests/GetTaskCommentResponse.md)**

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

var res = await sdk.Task.GetTaskProjectAsync(
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

## GetTaskTask

Retrieve a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTaskTask" method="get" path="/task/{connection_id}/task/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.GetTaskTaskAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Task                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetTaskTaskQueryParamFields](../../Models/Requests/GetTaskTaskQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetTaskTaskResponse](../../Models/Requests/GetTaskTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiTasks

List all tasks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiTasks" method="get" path="/genai/{connection_id}/task" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiTasksRequest req = new ListGenaiTasksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Task.ListGenaiTasksAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListGenaiTasksRequest](../../Models/Requests/ListGenaiTasksRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListGenaiTasksResponse](../../Models/Requests/ListGenaiTasksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTaskChanges

List all changes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTaskChanges" method="get" path="/task/{connection_id}/change" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTaskChangesRequest req = new ListTaskChangesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Task.ListTaskChangesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListTaskChangesRequest](../../Models/Requests/ListTaskChangesRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListTaskChangesResponse](../../Models/Requests/ListTaskChangesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTaskComments

List all comments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTaskComments" method="get" path="/task/{connection_id}/comment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTaskCommentsRequest req = new ListTaskCommentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Task.ListTaskCommentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListTaskCommentsRequest](../../Models/Requests/ListTaskCommentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListTaskCommentsResponse](../../Models/Requests/ListTaskCommentsResponse.md)**

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

var res = await sdk.Task.ListTaskProjectsAsync(req);

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

## ListTaskTasks

List all tasks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTaskTasks" method="get" path="/task/{connection_id}/task" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTaskTasksRequest req = new ListTaskTasksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Task.ListTaskTasksAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListTaskTasksRequest](../../Models/Requests/ListTaskTasksRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListTaskTasksResponse](../../Models/Requests/ListTaskTasksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchGenaiTask

Update a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchGenaiTask" method="patch" path="/genai/{connection_id}/task/{id}" example="genai_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchGenaiTaskRequest req = new PatchGenaiTaskRequest() {
    GenaiTask = new GenaiTask() {
        CompletedAt = System.DateTime.Parse("2025-09-30T06:45:33.974Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "cebad502-b835-4187-9429-67df7a8dfee7",
        Instructions = "Benigne canonicus officiis solvo adsidue deleo angustus.",
        LinesAdded = 244D,
        LinesDeleted = 118D,
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Stultus esse cursim stabilis tenetur amet contigo tristis.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
        },
        Name = "connect multi-byte port",
        PullrequestUrl = "https://github.com/berenice.satterfield/joshingly-ignorance/pull/383",
        RepoUrl = "https://github.com/berenice.satterfield/joshingly-ignorance",
        SourceBranchIdentifier = "main",
        StartedAt = System.DateTime.Parse("2024-05-20T17:11:38.722Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-25T19:55:26.303Z").ToUniversalTime(),
        WebUrl = "https://inexperienced-adrenalin.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.PatchGenaiTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchGenaiTaskRequest](../../Models/Requests/PatchGenaiTaskRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchGenaiTaskResponse](../../Models/Requests/PatchGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchTaskComment

Update a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTaskComment" method="patch" path="/task/{connection_id}/comment/{id}" example="task_comment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTaskCommentRequest req = new PatchTaskCommentRequest() {
    TaskComment = new TaskComment() {
        CreatedAt = System.DateTime.Parse("2019-10-12T20:33:37.879Z").ToUniversalTime(),
        HasChildren = true,
        Id = "1a5cbd95-43ee-4bf6-bbe1-99303f86baa8",
        Metadata = new List<TaskMetadata>() {},
        Text = "Colo ulciscor sublime tabernus.",
        UpdatedAt = System.DateTime.Parse("2021-10-02T23:49:51.417Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.PatchTaskCommentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchTaskCommentRequest](../../Models/Requests/PatchTaskCommentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchTaskCommentResponse](../../Models/Requests/PatchTaskCommentResponse.md)**

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
        Id = "3aa80d34-516c-48fc-954f-d3df544cc6e8",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "df846ced-db32-4d22-91bd-08b852afb3a3",
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
                Id = "850ed326-d08d-46e8-9e1f-8875a1a1c7b6",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-11T11:53:04.762Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.PatchTaskProjectAsync(req);

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

## PatchTaskTask

Update a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchTaskTask" method="patch" path="/task/{connection_id}/task/{id}" example="task_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchTaskTaskRequest req = new PatchTaskTaskRequest() {
    TaskTask = new TaskTask() {
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-01-31T08:34:55.626Z").ToUniversalTime(),
        DueAt = System.DateTime.Parse("2025-09-10T17:33:46.644Z").ToUniversalTime(),
        HasChildren = true,
        Id = "538e9231-67e0-4089-a8f5-39bb35dac520",
        Metadata = new List<TaskMetadata>() {},
        Name = "I'll compress the optical IB interface, that should capacitor the JBOD system!",
        Notes = "Argentum ventosus rem talis neque thymbra. Absconditus peccatus crustulum tollo cometes volva vacuus eos cedo. Somnus utpote coadunatio denuncio adopto autus sono atrocitas. Concido rerum cura aveho torqueo tempore tubineus vomer tempore suscipit. Clibanus valetudo vulnero pauper caput absorbeo correptius vir deduco.",
        Priority = "MEDIUM",
        Progress = 33D,
        StartAt = System.DateTime.Parse("2025-08-13T07:42:17.682Z").ToUniversalTime(),
        Status = TaskTaskStatus.Opened,
        StoryPoints = 0D,
        Tags = new List<string>() {
            "curis",
            "crinis",
        },
        TimeSpent = 5359D,
        TimeSpentUnit = "SECONDS",
        Type = "magni",
        UpdatedAt = System.DateTime.Parse("2022-04-06T14:14:34.376Z").ToUniversalTime(),
        Url = "https://elementary-utilization.net/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.PatchTaskTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchTaskTaskRequest](../../Models/Requests/PatchTaskTaskRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchTaskTaskResponse](../../Models/Requests/PatchTaskTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiTask

Remove a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiTask" method="delete" path="/genai/{connection_id}/task/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.RemoveGenaiTaskAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Task       |

### Response

**[RemoveGenaiTaskResponse](../../Models/Requests/RemoveGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveTaskComment

Remove a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTaskComment" method="delete" path="/task/{connection_id}/comment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.RemoveTaskCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Comment    |

### Response

**[RemoveTaskCommentResponse](../../Models/Requests/RemoveTaskCommentResponse.md)**

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

var res = await sdk.Task.RemoveTaskProjectAsync(
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

## RemoveTaskTask

Remove a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTaskTask" method="delete" path="/task/{connection_id}/task/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Task.RemoveTaskTaskAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Task       |

### Response

**[RemoveTaskTaskResponse](../../Models/Requests/RemoveTaskTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateGenaiTask

Update a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateGenaiTask" method="put" path="/genai/{connection_id}/task/{id}" example="genai_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateGenaiTaskRequest req = new UpdateGenaiTaskRequest() {
    GenaiTask = new GenaiTask() {
        CompletedAt = System.DateTime.Parse("2025-09-30T06:45:33.974Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "cebad502-b835-4187-9429-67df7a8dfee7",
        Instructions = "Benigne canonicus officiis solvo adsidue deleo angustus.",
        LinesAdded = 244D,
        LinesDeleted = 118D,
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Stultus esse cursim stabilis tenetur amet contigo tristis.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
        },
        Name = "connect multi-byte port",
        PullrequestUrl = "https://github.com/berenice.satterfield/joshingly-ignorance/pull/383",
        RepoUrl = "https://github.com/berenice.satterfield/joshingly-ignorance",
        SourceBranchIdentifier = "main",
        StartedAt = System.DateTime.Parse("2024-05-20T17:11:38.722Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-25T19:55:26.303Z").ToUniversalTime(),
        WebUrl = "https://inexperienced-adrenalin.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.UpdateGenaiTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateGenaiTaskRequest](../../Models/Requests/UpdateGenaiTaskRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateGenaiTaskResponse](../../Models/Requests/UpdateGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateTaskComment

Update a comment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTaskComment" method="put" path="/task/{connection_id}/comment/{id}" example="task_comment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTaskCommentRequest req = new UpdateTaskCommentRequest() {
    TaskComment = new TaskComment() {
        CreatedAt = System.DateTime.Parse("2019-10-12T20:33:37.879Z").ToUniversalTime(),
        HasChildren = true,
        Id = "1a5cbd95-43ee-4bf6-bbe1-99303f86baa8",
        Metadata = new List<TaskMetadata>() {},
        Text = "Colo ulciscor sublime tabernus.",
        UpdatedAt = System.DateTime.Parse("2021-10-02T23:49:51.417Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.UpdateTaskCommentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateTaskCommentRequest](../../Models/Requests/UpdateTaskCommentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateTaskCommentResponse](../../Models/Requests/UpdateTaskCommentResponse.md)**

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
        Id = "3aa80d34-516c-48fc-954f-d3df544cc6e8",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "df846ced-db32-4d22-91bd-08b852afb3a3",
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
                Id = "850ed326-d08d-46e8-9e1f-8875a1a1c7b6",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-11T11:53:04.762Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.UpdateTaskProjectAsync(req);

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

## UpdateTaskTask

Update a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTaskTask" method="put" path="/task/{connection_id}/task/{id}" example="task_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateTaskTaskRequest req = new UpdateTaskTaskRequest() {
    TaskTask = new TaskTask() {
        AttachmentIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2019-01-31T08:34:55.626Z").ToUniversalTime(),
        DueAt = System.DateTime.Parse("2025-09-10T17:33:46.644Z").ToUniversalTime(),
        HasChildren = true,
        Id = "538e9231-67e0-4089-a8f5-39bb35dac520",
        Metadata = new List<TaskMetadata>() {},
        Name = "I'll compress the optical IB interface, that should capacitor the JBOD system!",
        Notes = "Argentum ventosus rem talis neque thymbra. Absconditus peccatus crustulum tollo cometes volva vacuus eos cedo. Somnus utpote coadunatio denuncio adopto autus sono atrocitas. Concido rerum cura aveho torqueo tempore tubineus vomer tempore suscipit. Clibanus valetudo vulnero pauper caput absorbeo correptius vir deduco.",
        Priority = "MEDIUM",
        Progress = 33D,
        StartAt = System.DateTime.Parse("2025-08-13T07:42:17.682Z").ToUniversalTime(),
        Status = TaskTaskStatus.Opened,
        StoryPoints = 0D,
        Tags = new List<string>() {
            "curis",
            "crinis",
        },
        TimeSpent = 5359D,
        TimeSpentUnit = "SECONDS",
        Type = "magni",
        UpdatedAt = System.DateTime.Parse("2022-04-06T14:14:34.376Z").ToUniversalTime(),
        Url = "https://elementary-utilization.net/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Task.UpdateTaskTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateTaskTaskRequest](../../Models/Requests/UpdateTaskTaskRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateTaskTaskResponse](../../Models/Requests/UpdateTaskTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |