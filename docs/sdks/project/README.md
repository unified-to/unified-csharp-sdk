# Project
(*Project*)

### Available Operations

* [CreateTaskProject](#createtaskproject) - Create a project
* [GetTaskProject](#gettaskproject) - Retrieve a project
* [ListTaskProjects](#listtaskprojects) - List all projects
* [PatchTaskProject](#patchtaskproject) - Update a project
* [RemoveTaskProject](#removetaskproject) - Remove a project
* [UpdateTaskProject](#updatetaskproject) - Update a project

## CreateTaskProject

Create a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Project.CreateTaskProjectAsync(
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

## GetTaskProject

Retrieve a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Project.GetTaskProjectAsync(
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

## ListTaskProjects

List all projects

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListTaskProjectsRequest req = new ListTaskProjectsRequest() {
    ConnectionId = "<value>",
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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchTaskProject

Update a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Project.PatchTaskProjectAsync(
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

## RemoveTaskProject

Remove a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Project.RemoveTaskProjectAsync(
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

## UpdateTaskProject

Update a project

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Project.UpdateTaskProjectAsync(
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
