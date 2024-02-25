# Job
(*Job*)

### Available Operations

* [CreateAtsJob](#createatsjob) - Create a job
* [GetAtsJob](#getatsjob) - Retrieve a job
* [ListAtsJobs](#listatsjobs) - List all jobs
* [PatchAtsJob](#patchatsjob) - Update a job
* [RemoveAtsJob](#removeatsjob) - Remove a job
* [UpdateAtsJob](#updateatsjob) - Update a job

## CreateAtsJob

Create a job

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Job.CreateAtsJobAsync(
    security: new CreateAtsJobSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    atsJob: new AtsJob() {});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.CreateAtsJobSecurity](../../Models/Requests/CreateAtsJobSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `AtsJob`                                                                                        | [AtsJob](../../Models/Components/AtsJob.md)                                                     | :heavy_minus_sign:                                                                              | N/A                                                                                             |


### Response

**[CreateAtsJobResponse](../../Models/Requests/CreateAtsJobResponse.md)**


## GetAtsJob

Retrieve a job

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Job.GetAtsJobAsync(
    security: new GetAtsJobSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [UnifiedTo.Models.Requests.GetAtsJobSecurity](../../Models/Requests/GetAtsJobSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |
| `ConnectionId`                                                                            | *string*                                                                                  | :heavy_check_mark:                                                                        | ID of the connection                                                                      |
| `Id`                                                                                      | *string*                                                                                  | :heavy_check_mark:                                                                        | ID of the Job                                                                             |
| `Fields`                                                                                  | List<*string*>                                                                            | :heavy_minus_sign:                                                                        | Comma-delimited fields to return                                                          |


### Response

**[GetAtsJobResponse](../../Models/Requests/GetAtsJobResponse.md)**


## ListAtsJobs

List all jobs

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAtsJobsRequest req = new ListAtsJobsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Job.ListAtsJobsAsync(
    security: new ListAtsJobsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListAtsJobsRequest](../../Models/Requests/ListAtsJobsRequest.md)                             | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [UnifiedTo.Models.Requests.ListAtsJobsSecurity](../../Models/Requests/ListAtsJobsSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |


### Response

**[ListAtsJobsResponse](../../Models/Requests/ListAtsJobsResponse.md)**


## PatchAtsJob

Update a job

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Job.PatchAtsJobAsync(
    security: new PatchAtsJobSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsJob: new AtsJob() {});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [UnifiedTo.Models.Requests.PatchAtsJobSecurity](../../Models/Requests/PatchAtsJobSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ConnectionId`                                                                                | *string*                                                                                      | :heavy_check_mark:                                                                            | ID of the connection                                                                          |
| `Id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | ID of the Job                                                                                 |
| `AtsJob`                                                                                      | [AtsJob](../../Models/Components/AtsJob.md)                                                   | :heavy_minus_sign:                                                                            | N/A                                                                                           |


### Response

**[PatchAtsJobResponse](../../Models/Requests/PatchAtsJobResponse.md)**


## RemoveAtsJob

Remove a job

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Job.RemoveAtsJobAsync(
    security: new RemoveAtsJobSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.RemoveAtsJobSecurity](../../Models/Requests/RemoveAtsJobSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Job                                                                                   |


### Response

**[RemoveAtsJobResponse](../../Models/Requests/RemoveAtsJobResponse.md)**


## UpdateAtsJob

Update a job

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Job.UpdateAtsJobAsync(
    security: new UpdateAtsJobSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsJob: new AtsJob() {});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.UpdateAtsJobSecurity](../../Models/Requests/UpdateAtsJobSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Job                                                                                   |
| `AtsJob`                                                                                        | [AtsJob](../../Models/Components/AtsJob.md)                                                     | :heavy_minus_sign:                                                                              | N/A                                                                                             |


### Response

**[UpdateAtsJobResponse](../../Models/Requests/UpdateAtsJobResponse.md)**

