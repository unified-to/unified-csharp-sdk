# Goal

## Overview

### Available Operations

* [CreatePerformanceGoal](#createperformancegoal) - Create a goal
* [GetPerformanceGoal](#getperformancegoal) - Retrieve a goal
* [ListPerformanceGoals](#listperformancegoals) - List all goals
* [PatchPerformanceGoal](#patchperformancegoal) - Update a goal
* [RemovePerformanceGoal](#removeperformancegoal) - Remove a goal
* [UpdatePerformanceGoal](#updateperformancegoal) - Update a goal

## CreatePerformanceGoal

Create a goal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPerformanceGoal" method="post" path="/performance/{connection_id}/goal" example="performance_goal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Goal.CreatePerformanceGoalAsync(
    performanceGoal: new PerformanceGoal() {
        CreatedAt = System.DateTime.Parse("2020-01-09T20:43:07.380Z").ToUniversalTime(),
        Description = "Suscipit suspendo vulnero vel facere valeo vallum degero.",
        DueAt = System.DateTime.Parse("2026-06-28T19:57:13.857Z").ToUniversalTime(),
        Id = "48e5456f-aae0-46b8-9586-f1cd44232d59",
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-05-04T15:59:30.349Z").ToUniversalTime(),
                Id = "ec90d3e3-23bd-4d9f-a5d7-e388979f90d9",
                IsCompleted = true,
                Name = "Front-line asynchronous hub",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-07-08T09:47:25.120Z").ToUniversalTime(),
                Id = "09e04b09-7197-4fc4-9c32-077230408c26",
                IsCompleted = true,
                Name = "Organized encompassing archive",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Nobis tremo debitis.",
                DueAt = System.DateTime.Parse("2026-09-08T13:05:29.129Z").ToUniversalTime(),
                Id = "bbe63683-c1d0-4932-89ac-ef81e73ae6f1",
                IsCompleted = true,
                Name = "Devolved directional middleware",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-06-27T05:58:13.373Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-08-31T10:17:03.104Z").ToUniversalTime(),
        Weight = 5D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PerformanceGoal`                                                                                                                                | [PerformanceGoal](../../Models/Components/PerformanceGoal.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreatePerformanceGoalQueryParamFields](../../Models/Requests/CreatePerformanceGoalQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreatePerformanceGoalResponse](../../Models/Requests/CreatePerformanceGoalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPerformanceGoal

Retrieve a goal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPerformanceGoal" method="get" path="/performance/{connection_id}/goal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Goal.GetPerformanceGoalAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Goal                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetPerformanceGoalQueryParamFields](../../Models/Requests/GetPerformanceGoalQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPerformanceGoalResponse](../../Models/Requests/GetPerformanceGoalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPerformanceGoals

List all goals

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPerformanceGoals" method="get" path="/performance/{connection_id}/goal" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPerformanceGoalsRequest req = new ListPerformanceGoalsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Goal.ListPerformanceGoalsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListPerformanceGoalsRequest](../../Models/Requests/ListPerformanceGoalsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListPerformanceGoalsResponse](../../Models/Requests/ListPerformanceGoalsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPerformanceGoal

Update a goal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchPerformanceGoal" method="patch" path="/performance/{connection_id}/goal/{id}" example="performance_goal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchPerformanceGoalRequest req = new PatchPerformanceGoalRequest() {
    PerformanceGoal = new PerformanceGoal() {
        CreatedAt = System.DateTime.Parse("2020-01-09T20:43:07.380Z").ToUniversalTime(),
        Description = "Suscipit suspendo vulnero vel facere valeo vallum degero.",
        DueAt = System.DateTime.Parse("2026-06-28T19:57:13.868Z").ToUniversalTime(),
        Id = "0ae9ef1b-fcb0-4c7f-a099-2650f7070660",
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-05-04T15:59:30.360Z").ToUniversalTime(),
                Id = "ec90d3e3-23bd-4d9f-a5d7-e388979f90d9",
                IsCompleted = true,
                Name = "Front-line asynchronous hub",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-07-08T09:47:25.132Z").ToUniversalTime(),
                Id = "09e04b09-7197-4fc4-9c32-077230408c26",
                IsCompleted = true,
                Name = "Organized encompassing archive",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Nobis tremo debitis.",
                DueAt = System.DateTime.Parse("2026-09-08T13:05:29.141Z").ToUniversalTime(),
                Id = "bbe63683-c1d0-4932-89ac-ef81e73ae6f1",
                IsCompleted = true,
                Name = "Devolved directional middleware",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-06-27T05:58:13.383Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-08-31T10:17:03.108Z").ToUniversalTime(),
        Weight = 5D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Goal.PatchPerformanceGoalAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchPerformanceGoalRequest](../../Models/Requests/PatchPerformanceGoalRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchPerformanceGoalResponse](../../Models/Requests/PatchPerformanceGoalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePerformanceGoal

Remove a goal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removePerformanceGoal" method="delete" path="/performance/{connection_id}/goal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Goal.RemovePerformanceGoalAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Goal       |

### Response

**[RemovePerformanceGoalResponse](../../Models/Requests/RemovePerformanceGoalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePerformanceGoal

Update a goal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePerformanceGoal" method="put" path="/performance/{connection_id}/goal/{id}" example="performance_goal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdatePerformanceGoalRequest req = new UpdatePerformanceGoalRequest() {
    PerformanceGoal = new PerformanceGoal() {
        CreatedAt = System.DateTime.Parse("2020-01-09T20:43:07.380Z").ToUniversalTime(),
        Description = "Suscipit suspendo vulnero vel facere valeo vallum degero.",
        DueAt = System.DateTime.Parse("2026-06-28T19:57:13.868Z").ToUniversalTime(),
        Id = "0ae9ef1b-fcb0-4c7f-a099-2650f7070660",
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-05-04T15:59:30.360Z").ToUniversalTime(),
                Id = "ec90d3e3-23bd-4d9f-a5d7-e388979f90d9",
                IsCompleted = true,
                Name = "Front-line asynchronous hub",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-07-08T09:47:25.132Z").ToUniversalTime(),
                Id = "09e04b09-7197-4fc4-9c32-077230408c26",
                IsCompleted = true,
                Name = "Organized encompassing archive",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Nobis tremo debitis.",
                DueAt = System.DateTime.Parse("2026-09-08T13:05:29.141Z").ToUniversalTime(),
                Id = "bbe63683-c1d0-4932-89ac-ef81e73ae6f1",
                IsCompleted = true,
                Name = "Devolved directional middleware",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-06-27T05:58:13.383Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-08-31T10:17:03.108Z").ToUniversalTime(),
        Weight = 5D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Goal.UpdatePerformanceGoalAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdatePerformanceGoalRequest](../../Models/Requests/UpdatePerformanceGoalRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdatePerformanceGoalResponse](../../Models/Requests/UpdatePerformanceGoalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |