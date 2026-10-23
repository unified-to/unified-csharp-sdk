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

Creates a GenaiTask. Provide the unified GenaiTask fields in the request body; they are mapped to the provider's API. Returns the created GenaiTask.

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
        CompletedAt = System.DateTime.Parse("2025-10-02T22:27:27.541Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "33c3198e-796d-4b2f-82ab-572a6cfdad4f",
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
        StartedAt = System.DateTime.Parse("2024-05-22T15:17:19.565Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-27T02:06:07.082Z").ToUniversalTime(),
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

Creates a TaskComment. Provide the unified TaskComment fields in the request body; they are mapped to the provider's API. Returns the created TaskComment.

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
        Id = "e4380750-e8ce-4255-9c1f-f23f124fc65f",
        Metadata = new List<TaskMetadata>() {},
        Text = "Colo ulciscor sublime tabernus.",
        UpdatedAt = System.DateTime.Parse("2021-10-03T21:34:22.755Z").ToUniversalTime(),
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

Creates a TaskProject. Provide the unified TaskProject fields in the request body; they are mapped to the provider's API. Returns the created TaskProject.

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
        Id = "df1d44cc-e96e-4b88-b0dd-61d9a3be50a7",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "4761d2e2-7c93-4249-9c8c-0ae8136bb136",
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
                Id = "7db055bc-15fc-41ba-9d06-a0cdb6e58a88",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-11T18:52:32.712Z").ToUniversalTime(),
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

Creates a TaskTask. Provide the unified TaskTask fields in the request body; they are mapped to the provider's API. Returns the created TaskTask.

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
        DueAt = System.DateTime.Parse("2025-09-13T11:00:11.892Z").ToUniversalTime(),
        HasChildren = true,
        Id = "2e3aa77b-f27e-43b1-a959-d28988e5c095",
        Metadata = new List<TaskMetadata>() {},
        Name = "I'll compress the optical IB interface, that should capacitor the JBOD system!",
        Notes = "Argentum ventosus rem talis neque thymbra. Absconditus peccatus crustulum tollo cometes volva vacuus eos cedo. Somnus utpote coadunatio denuncio adopto autus sono atrocitas. Concido rerum cura aveho torqueo tempore tubineus vomer tempore suscipit. Clibanus valetudo vulnero pauper caput absorbeo correptius vir deduco.",
        Priority = "MEDIUM",
        Progress = 33D,
        StartAt = System.DateTime.Parse("2025-08-16T01:08:42.930Z").ToUniversalTime(),
        Status = TaskTaskStatus.Opened,
        StoryPoints = 0D,
        Tags = new List<string>() {
            "curis",
            "crinis",
        },
        TimeSpent = 5359D,
        TimeSpentUnit = "SECONDS",
        Type = "magni",
        UpdatedAt = System.DateTime.Parse("2022-04-07T22:05:32.478Z").ToUniversalTime(),
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

Retrieves a single GenaiTask by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TaskChange by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TaskComment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TaskProject by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single TaskTask by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of GenaiTasks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TaskChanges. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TaskComments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TaskProjects. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of TaskTasks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the GenaiTask identified by `id`. Provide the unified GenaiTask fields to change in the request body.

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
        CompletedAt = System.DateTime.Parse("2025-10-02T22:27:27.550Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "4913d5c6-7707-4466-a433-a9f8b2b69bcd",
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
        StartedAt = System.DateTime.Parse("2024-05-22T15:17:19.572Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-27T02:06:07.087Z").ToUniversalTime(),
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

Updates the TaskComment identified by `id`. Provide the unified TaskComment fields to change in the request body.

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
        Id = "a0b9a773-daf9-471d-8b0b-2397f8a2da5d",
        Metadata = new List<TaskMetadata>() {},
        Text = "Colo ulciscor sublime tabernus.",
        UpdatedAt = System.DateTime.Parse("2021-10-03T21:34:22.757Z").ToUniversalTime(),
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

Updates the TaskProject identified by `id`. Provide the unified TaskProject fields to change in the request body.

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
        Id = "092e9439-4fdf-4f91-85be-bfa67a18db16",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "7738b176-d267-49fc-9ffc-8bf2701ced18",
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
                Id = "7b24d0ae-9c08-457f-af3e-733ce41b79cd",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-11T18:52:32.713Z").ToUniversalTime(),
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

Updates the TaskTask identified by `id`. Provide the unified TaskTask fields to change in the request body.

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
        DueAt = System.DateTime.Parse("2025-09-13T11:00:11.912Z").ToUniversalTime(),
        HasChildren = true,
        Id = "f709dd7e-934d-4ae7-a8d8-765816deb302",
        Metadata = new List<TaskMetadata>() {},
        Name = "I'll compress the optical IB interface, that should capacitor the JBOD system!",
        Notes = "Argentum ventosus rem talis neque thymbra. Absconditus peccatus crustulum tollo cometes volva vacuus eos cedo. Somnus utpote coadunatio denuncio adopto autus sono atrocitas. Concido rerum cura aveho torqueo tempore tubineus vomer tempore suscipit. Clibanus valetudo vulnero pauper caput absorbeo correptius vir deduco.",
        Priority = "MEDIUM",
        Progress = 33D,
        StartAt = System.DateTime.Parse("2025-08-16T01:08:42.950Z").ToUniversalTime(),
        Status = TaskTaskStatus.Opened,
        StoryPoints = 0D,
        Tags = new List<string>() {
            "curis",
            "crinis",
        },
        TimeSpent = 5359D,
        TimeSpentUnit = "SECONDS",
        Type = "magni",
        UpdatedAt = System.DateTime.Parse("2022-04-07T22:05:32.488Z").ToUniversalTime(),
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

Deletes the GenaiTask identified by `id`.

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

Deletes the TaskComment identified by `id`.

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

Deletes the TaskProject identified by `id`.

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

Deletes the TaskTask identified by `id`.

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

Updates the GenaiTask identified by `id`. Provide the unified GenaiTask fields to change in the request body.

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
        CompletedAt = System.DateTime.Parse("2025-10-02T22:27:27.550Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "4913d5c6-7707-4466-a433-a9f8b2b69bcd",
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
        StartedAt = System.DateTime.Parse("2024-05-22T15:17:19.572Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-27T02:06:07.087Z").ToUniversalTime(),
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

Updates the TaskComment identified by `id`. Provide the unified TaskComment fields to change in the request body.

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
        Id = "a0b9a773-daf9-471d-8b0b-2397f8a2da5d",
        Metadata = new List<TaskMetadata>() {},
        Text = "Colo ulciscor sublime tabernus.",
        UpdatedAt = System.DateTime.Parse("2021-10-03T21:34:22.757Z").ToUniversalTime(),
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

Updates the TaskProject identified by `id`. Provide the unified TaskProject fields to change in the request body.

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
        Id = "092e9439-4fdf-4f91-85be-bfa67a18db16",
        Metadata = new List<TaskMetadata>() {
            new TaskMetadata() {
                ExtraData = TaskMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = TaskMetadataFormat.Text,
                Id = "7738b176-d267-49fc-9ffc-8bf2701ced18",
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
                Id = "7b24d0ae-9c08-457f-af3e-733ce41b79cd",
                Namespace = "custom",
                Slug = "benevolentia",
                Value = TaskMetadataValue.CreateStr(
                    "pariatur"
                ),
            },
        },
        Name = "Garden",
        UpdatedAt = System.DateTime.Parse("2023-10-11T18:52:32.713Z").ToUniversalTime(),
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

Updates the TaskTask identified by `id`. Provide the unified TaskTask fields to change in the request body.

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
        DueAt = System.DateTime.Parse("2025-09-13T11:00:11.912Z").ToUniversalTime(),
        HasChildren = true,
        Id = "f709dd7e-934d-4ae7-a8d8-765816deb302",
        Metadata = new List<TaskMetadata>() {},
        Name = "I'll compress the optical IB interface, that should capacitor the JBOD system!",
        Notes = "Argentum ventosus rem talis neque thymbra. Absconditus peccatus crustulum tollo cometes volva vacuus eos cedo. Somnus utpote coadunatio denuncio adopto autus sono atrocitas. Concido rerum cura aveho torqueo tempore tubineus vomer tempore suscipit. Clibanus valetudo vulnero pauper caput absorbeo correptius vir deduco.",
        Priority = "MEDIUM",
        Progress = 33D,
        StartAt = System.DateTime.Parse("2025-08-16T01:08:42.950Z").ToUniversalTime(),
        Status = TaskTaskStatus.Opened,
        StoryPoints = 0D,
        Tags = new List<string>() {
            "curis",
            "crinis",
        },
        TimeSpent = 5359D,
        TimeSpentUnit = "SECONDS",
        Type = "magni",
        UpdatedAt = System.DateTime.Parse("2022-04-07T22:05:32.488Z").ToUniversalTime(),
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