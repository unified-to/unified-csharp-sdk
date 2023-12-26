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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Job.CreateAtsJobAsync(ConnectionId: "string", AtsJob: new AtsJob() {
    Addresses = new List<AtsAddress>() {
        new AtsAddress() {},
    },
    Compensation = new List<AtsCompensation>() {
        new AtsCompensation() {
            Type = AtsCompensationType.Salary,
        },
    },
    Departments = new List<string>() {
        "string",
    },
    HiringManagerIds = new List<string>() {
        "string",
    },
    PublicJobUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsJobRaw() {},
    RecruiterIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ConnectionId`                              | *string*                                    | :heavy_check_mark:                          | ID of the connection                        |
| `AtsJob`                                    | [AtsJob](../../Models/Components/AtsJob.md) | :heavy_minus_sign:                          | N/A                                         |


### Response

**[CreateAtsJobResponse](../../Models/Requests/CreateAtsJobResponse.md)**


## GetAtsJob

Retrieve a job

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Job.GetAtsJobAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Job                    |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsJobResponse](../../Models/Requests/GetAtsJobResponse.md)**


## ListAtsJobs

List all jobs

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsJobsRequest req = new ListAtsJobsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Job.ListAtsJobsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListAtsJobsRequest](../../Models/Requests/ListAtsJobsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[ListAtsJobsResponse](../../Models/Requests/ListAtsJobsResponse.md)**


## PatchAtsJob

Update a job

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Job.PatchAtsJobAsync(ConnectionId: "string", Id: "string", AtsJob: new AtsJob() {
    Addresses = new List<AtsAddress>() {
        new AtsAddress() {},
    },
    Compensation = new List<AtsCompensation>() {
        new AtsCompensation() {
            Type = AtsCompensationType.Bonus,
        },
    },
    Departments = new List<string>() {
        "string",
    },
    HiringManagerIds = new List<string>() {
        "string",
    },
    PublicJobUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsJobRaw() {},
    RecruiterIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ConnectionId`                              | *string*                                    | :heavy_check_mark:                          | ID of the connection                        |
| `Id`                                        | *string*                                    | :heavy_check_mark:                          | ID of the Job                               |
| `AtsJob`                                    | [AtsJob](../../Models/Components/AtsJob.md) | :heavy_minus_sign:                          | N/A                                         |


### Response

**[PatchAtsJobResponse](../../Models/Requests/PatchAtsJobResponse.md)**


## RemoveAtsJob

Remove a job

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Job.RemoveAtsJobAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Job        |


### Response

**[RemoveAtsJobResponse](../../Models/Requests/RemoveAtsJobResponse.md)**


## UpdateAtsJob

Update a job

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Job.UpdateAtsJobAsync(ConnectionId: "string", Id: "string", AtsJob: new AtsJob() {
    Addresses = new List<AtsAddress>() {
        new AtsAddress() {},
    },
    Compensation = new List<AtsCompensation>() {
        new AtsCompensation() {
            Type = AtsCompensationType.Equity,
        },
    },
    Departments = new List<string>() {
        "string",
    },
    HiringManagerIds = new List<string>() {
        "string",
    },
    PublicJobUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsJobRaw() {},
    RecruiterIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ConnectionId`                              | *string*                                    | :heavy_check_mark:                          | ID of the connection                        |
| `Id`                                        | *string*                                    | :heavy_check_mark:                          | ID of the Job                               |
| `AtsJob`                                    | [AtsJob](../../Models/Components/AtsJob.md) | :heavy_minus_sign:                          | N/A                                         |


### Response

**[UpdateAtsJobResponse](../../Models/Requests/UpdateAtsJobResponse.md)**

