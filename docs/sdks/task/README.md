# Task
(*Task*)

### Available Operations

* [CreateTaskProject](#createtaskproject) - Create a project
* [CreateTaskTask](#createtasktask) - Create a task
* [GetTaskProject](#gettaskproject) - Retrieve a project
* [GetTaskTask](#gettasktask) - Retrieve a task
* [ListTaskProjects](#listtaskprojects) - List all projects
* [ListTaskTasks](#listtasktasks) - List all tasks
* [PatchTaskProject](#patchtaskproject) - Update a project
* [PatchTaskTask](#patchtasktask) - Update a task
* [RemoveTaskProject](#removetaskproject) - Remove a project
* [RemoveTaskTask](#removetasktask) - Remove a task
* [UpdateTaskProject](#updatetaskproject) - Update a project
* [UpdateTaskTask](#updatetasktask) - Update a task

## CreateTaskProject

Create a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.CreateTaskProjectAsync(
    connectionId: "<value>",
    taskProject: new TaskProject() {});

// handle response
```



### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `TaskProject`                                         | [TaskProject](../../Models/Components/TaskProject.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreateTaskProjectResponse](../../Models/Requests/CreateTaskProjectResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## CreateTaskTask

Create a task

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.CreateTaskTaskAsync(
    connectionId: "<value>",
    taskTask: new TaskTask() {});

// handle response
```



### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `TaskTask`                                      | [TaskTask](../../Models/Components/TaskTask.md) | :heavy_minus_sign:                              | N/A                                             |


### Response

**[CreateTaskTaskResponse](../../Models/Requests/CreateTaskTaskResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetTaskProject

Retrieve a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.GetTaskProjectAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```



### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Project                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetTaskProjectResponse](../../Models/Requests/GetTaskProjectResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetTaskTask

Retrieve a task

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.GetTaskTaskAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```



### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Task                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetTaskTaskResponse](../../Models/Requests/GetTaskTaskResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListTaskProjects

List all projects

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListTaskProjectsRequest req = new ListTaskProjectsRequest() {
    ConnectionId = "<value>",
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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListTaskTasks

List all tasks

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListTaskTasksRequest req = new ListTaskTasksRequest() {
    ConnectionId = "<value>",
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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchTaskProject

Update a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.PatchTaskProjectAsync(
    connectionId: "<value>",
    id: "<value>",
    taskProject: new TaskProject() {});

// handle response
```



### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Project                                     |
| `TaskProject`                                         | [TaskProject](../../Models/Components/TaskProject.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchTaskProjectResponse](../../Models/Requests/PatchTaskProjectResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchTaskTask

Update a task

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.PatchTaskTaskAsync(
    connectionId: "<value>",
    id: "<value>",
    taskTask: new TaskTask() {});

// handle response
```



### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Id`                                            | *string*                                        | :heavy_check_mark:                              | ID of the Task                                  |
| `TaskTask`                                      | [TaskTask](../../Models/Components/TaskTask.md) | :heavy_minus_sign:                              | N/A                                             |


### Response

**[PatchTaskTaskResponse](../../Models/Requests/PatchTaskTaskResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveTaskProject

Remove a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.RemoveTaskProjectAsync(
    connectionId: "<value>",
    id: "<value>");

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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveTaskTask

Remove a task

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.RemoveTaskTaskAsync(
    connectionId: "<value>",
    id: "<value>");

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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateTaskProject

Update a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.UpdateTaskProjectAsync(
    connectionId: "<value>",
    id: "<value>",
    taskProject: new TaskProject() {});

// handle response
```



### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Project                                     |
| `TaskProject`                                         | [TaskProject](../../Models/Components/TaskProject.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdateTaskProjectResponse](../../Models/Requests/UpdateTaskProjectResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateTaskTask

Update a task

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Task.UpdateTaskTaskAsync(
    connectionId: "<value>",
    id: "<value>",
    taskTask: new TaskTask() {});

// handle response
```



### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Id`                                            | *string*                                        | :heavy_check_mark:                              | ID of the Task                                  |
| `TaskTask`                                      | [TaskTask](../../Models/Components/TaskTask.md) | :heavy_minus_sign:                              | N/A                                             |


### Response

**[UpdateTaskTaskResponse](../../Models/Requests/UpdateTaskTaskResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
