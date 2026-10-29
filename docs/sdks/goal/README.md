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
        DueAt = System.DateTime.Parse("2026-08-06T04:05:43.525Z").ToUniversalTime(),
        Id = "4da7242b-223e-4e22-8b88-311a6937028b",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-11T02:38:34.501Z").ToUniversalTime(),
                Id = "138c3045-2c0b-4261-bc1d-bd2479b8e68b",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-15T21:39:45.246Z").ToUniversalTime(),
                Id = "c04e6a2f-a796-409c-9917-db62feaa6382",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-18T01:10:13.201Z").ToUniversalTime(),
                Id = "88ed2d2f-3321-4cee-bd12-57bb48d4cb56",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-29T15:18:14.261Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-16T02:02:44.321Z").ToUniversalTime(),
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
        DueAt = System.DateTime.Parse("2026-08-06T04:05:43.556Z").ToUniversalTime(),
        Id = "7ddf4887-3b19-4b77-81bd-319202550b84",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-11T02:38:34.531Z").ToUniversalTime(),
                Id = "e51af406-0ef8-46f7-912f-27500dbd5ba9",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-15T21:39:45.277Z").ToUniversalTime(),
                Id = "b1b7cfb7-076e-4947-8f46-41fb9a113a50",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-18T01:10:13.233Z").ToUniversalTime(),
                Id = "9b96c6ca-15b1-4d9a-9de6-c5c75cb5cc74",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-29T15:18:14.287Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-16T02:02:44.334Z").ToUniversalTime(),
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
        DueAt = System.DateTime.Parse("2026-08-06T04:05:43.556Z").ToUniversalTime(),
        Id = "7ddf4887-3b19-4b77-81bd-319202550b84",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-11T02:38:34.531Z").ToUniversalTime(),
                Id = "e51af406-0ef8-46f7-912f-27500dbd5ba9",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-15T21:39:45.277Z").ToUniversalTime(),
                Id = "b1b7cfb7-076e-4947-8f46-41fb9a113a50",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-18T01:10:13.233Z").ToUniversalTime(),
                Id = "9b96c6ca-15b1-4d9a-9de6-c5c75cb5cc74",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-29T15:18:14.287Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-16T02:02:44.334Z").ToUniversalTime(),
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