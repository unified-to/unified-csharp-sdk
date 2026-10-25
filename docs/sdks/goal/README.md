# Goal

## Overview

### Available Operations

* [CreatePerformanceGoal](#createperformancegoal) - Create a goal
* [GetHealthcareGoal](#gethealthcaregoal) - Retrieve a goal
* [GetPerformanceGoal](#getperformancegoal) - Retrieve a goal
* [ListHealthcareGoals](#listhealthcaregoals) - List all goals
* [ListPerformanceGoals](#listperformancegoals) - List all goals
* [PatchPerformanceGoal](#patchperformancegoal) - Update a goal
* [RemovePerformanceGoal](#removeperformancegoal) - Remove a goal
* [UpdatePerformanceGoal](#updateperformancegoal) - Update a goal

## CreatePerformanceGoal

Creates a PerformanceGoal. Provide the unified PerformanceGoal fields in the request body; they are mapped to the provider's API. Returns the created PerformanceGoal.

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
        DueAt = System.DateTime.Parse("2026-08-02T14:42:12.400Z").ToUniversalTime(),
        Id = "088a633f-e025-4e97-8eb8-dab3c30e4503",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-07T15:14:43.135Z").ToUniversalTime(),
                Id = "f9e5d851-48ba-4888-8e44-3ec4bfbe1bc8",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-12T07:55:27.734Z").ToUniversalTime(),
                Id = "b6a34a26-8735-4a07-9ff3-dd4e09850ca7",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-14T09:11:08.462Z").ToUniversalTime(),
                Id = "51e58d6e-e0dd-46c8-868d-1bd8994655a3",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-26T15:09:54.018Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-14T15:10:25.759Z").ToUniversalTime(),
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

## GetHealthcareGoal

Retrieves a single HealthcareGoal by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareGoal" method="get" path="/healthcare/{connection_id}/goal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Goal.GetHealthcareGoalAsync(
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
| `Fields`                                                                                                                                         | List<[GetHealthcareGoalQueryParamFields](../../Models/Requests/GetHealthcareGoalQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareGoalResponse](../../Models/Requests/GetHealthcareGoalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPerformanceGoal

Retrieves a single PerformanceGoal by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

## ListHealthcareGoals

Returns a list of HealthcareGoals. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareGoals" method="get" path="/healthcare/{connection_id}/goal" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareGoalsRequest req = new ListHealthcareGoalsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Goal.ListHealthcareGoalsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListHealthcareGoalsRequest](../../Models/Requests/ListHealthcareGoalsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListHealthcareGoalsResponse](../../Models/Requests/ListHealthcareGoalsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPerformanceGoals

Returns a list of PerformanceGoals. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the PerformanceGoal identified by `id`. Provide the unified PerformanceGoal fields to change in the request body.

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
        DueAt = System.DateTime.Parse("2026-08-02T14:42:12.427Z").ToUniversalTime(),
        Id = "06552868-9b9e-46f6-8193-9470fdad99f9",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-07T15:14:43.161Z").ToUniversalTime(),
                Id = "43b69d12-b18d-4e55-ad0c-7e29db752296",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-12T07:55:27.760Z").ToUniversalTime(),
                Id = "de9d6727-2a15-4cc0-a0fc-f29ac790c22b",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-14T09:11:08.489Z").ToUniversalTime(),
                Id = "7936ed50-84b9-46fd-81ea-72be6f0ae725",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-26T15:09:54.041Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-14T15:10:25.770Z").ToUniversalTime(),
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

Deletes the PerformanceGoal identified by `id`.

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

Updates the PerformanceGoal identified by `id`. Provide the unified PerformanceGoal fields to change in the request body.

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
        DueAt = System.DateTime.Parse("2026-08-02T14:42:12.427Z").ToUniversalTime(),
        Id = "06552868-9b9e-46f6-8193-9470fdad99f9",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-07T15:14:43.161Z").ToUniversalTime(),
                Id = "43b69d12-b18d-4e55-ad0c-7e29db752296",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-12T07:55:27.760Z").ToUniversalTime(),
                Id = "de9d6727-2a15-4cc0-a0fc-f29ac790c22b",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-14T09:11:08.489Z").ToUniversalTime(),
                Id = "7936ed50-84b9-46fd-81ea-72be6f0ae725",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-26T15:09:54.041Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-14T15:10:25.770Z").ToUniversalTime(),
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