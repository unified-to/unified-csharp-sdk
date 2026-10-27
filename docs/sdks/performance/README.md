# Performance

## Overview

### Available Operations

* [CreatePerformanceFeedback](#createperformancefeedback) - Create a feedback
* [CreatePerformanceGoal](#createperformancegoal) - Create a goal
* [GetPerformanceCycle](#getperformancecycle) - Retrieve a cycle
* [GetPerformanceFeedback](#getperformancefeedback) - Retrieve a feedback
* [GetPerformanceGoal](#getperformancegoal) - Retrieve a goal
* [GetPerformanceReview](#getperformancereview) - Retrieve a review
* [ListPerformanceCycles](#listperformancecycles) - List all cycles
* [ListPerformanceFeedbacks](#listperformancefeedbacks) - List all feedbacks
* [ListPerformanceGoals](#listperformancegoals) - List all goals
* [ListPerformanceReviews](#listperformancereviews) - List all reviews
* [PatchPerformanceGoal](#patchperformancegoal) - Update a goal
* [RemovePerformanceGoal](#removeperformancegoal) - Remove a goal
* [UpdatePerformanceGoal](#updateperformancegoal) - Update a goal

## CreatePerformanceFeedback

Creates a PerformanceFeedback. Provide the unified PerformanceFeedback fields in the request body; they are mapped to the provider's API. Returns the created PerformanceFeedback.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPerformanceFeedback" method="post" path="/performance/{connection_id}/feedback" example="performance_feedback" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Performance.CreatePerformanceFeedbackAsync(
    performanceFeedback: new PerformanceFeedback() {
        CreatedAt = System.DateTime.Parse("2023-04-11T16:21:53.862Z").ToUniversalTime(),
        Id = "2250cb47-d645-420b-9f30-1f12037f1700",
        IsVisible = true,
        Message = "Tabernus corpus voluptate aestus.",
        Metadata = new List<PerformanceMetadata>() {},
        Tags = new List<string>() {
            "well-to-do",
            "hexagon",
        },
        Type = PerformanceFeedbackType.Praise,
        UpdatedAt = System.DateTime.Parse("2025-09-08T04:47:21.710Z").ToUniversalTime(),
        UserId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PerformanceFeedback`                                                                                                                            | [PerformanceFeedback](../../Models/Components/PerformanceFeedback.md)                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreatePerformanceFeedbackQueryParamFields](../../Models/Requests/CreatePerformanceFeedbackQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreatePerformanceFeedbackResponse](../../Models/Requests/CreatePerformanceFeedbackResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Performance.CreatePerformanceGoalAsync(
    performanceGoal: new PerformanceGoal() {
        CreatedAt = System.DateTime.Parse("2020-01-09T20:43:07.380Z").ToUniversalTime(),
        Description = "Suscipit suspendo vulnero vel facere valeo vallum degero.",
        DueAt = System.DateTime.Parse("2026-08-04T14:05:05.577Z").ToUniversalTime(),
        Id = "eb5a5952-17c2-4fa3-897e-6d29a02b9887",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-09T13:31:12.480Z").ToUniversalTime(),
                Id = "a2b482eb-0db0-48f1-ac04-3d681c4dfc1f",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-14T07:29:52.494Z").ToUniversalTime(),
                Id = "e4673cad-d5c9-4f12-b58f-89cda612cbd1",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-16T10:00:20.580Z").ToUniversalTime(),
                Id = "caca3009-39be-4c7d-9ac2-a67dd94dca23",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-28T07:11:33.863Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-15T10:31:23.327Z").ToUniversalTime(),
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

## GetPerformanceCycle

Retrieves a single PerformanceCycle by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPerformanceCycle" method="get" path="/performance/{connection_id}/cycle/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Performance.GetPerformanceCycleAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Cycle                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetPerformanceCycleQueryParamFields](../../Models/Requests/GetPerformanceCycleQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPerformanceCycleResponse](../../Models/Requests/GetPerformanceCycleResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPerformanceFeedback

Retrieves a single PerformanceFeedback by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPerformanceFeedback" method="get" path="/performance/{connection_id}/feedback/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Performance.GetPerformanceFeedbackAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Feedback                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetPerformanceFeedbackQueryParamFields](../../Models/Requests/GetPerformanceFeedbackQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPerformanceFeedbackResponse](../../Models/Requests/GetPerformanceFeedbackResponse.md)**

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

var res = await sdk.Performance.GetPerformanceGoalAsync(
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

## GetPerformanceReview

Retrieves a single PerformanceReview by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPerformanceReview" method="get" path="/performance/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Performance.GetPerformanceReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Review                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetPerformanceReviewQueryParamFields](../../Models/Requests/GetPerformanceReviewQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPerformanceReviewResponse](../../Models/Requests/GetPerformanceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPerformanceCycles

Returns a list of PerformanceCycles. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPerformanceCycles" method="get" path="/performance/{connection_id}/cycle" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPerformanceCyclesRequest req = new ListPerformanceCyclesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Performance.ListPerformanceCyclesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListPerformanceCyclesRequest](../../Models/Requests/ListPerformanceCyclesRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListPerformanceCyclesResponse](../../Models/Requests/ListPerformanceCyclesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPerformanceFeedbacks

Returns a list of PerformanceFeedbacks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPerformanceFeedbacks" method="get" path="/performance/{connection_id}/feedback" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPerformanceFeedbacksRequest req = new ListPerformanceFeedbacksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Performance.ListPerformanceFeedbacksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListPerformanceFeedbacksRequest](../../Models/Requests/ListPerformanceFeedbacksRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListPerformanceFeedbacksResponse](../../Models/Requests/ListPerformanceFeedbacksResponse.md)**

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

var res = await sdk.Performance.ListPerformanceGoalsAsync(req);

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

## ListPerformanceReviews

Returns a list of PerformanceReviews. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPerformanceReviews" method="get" path="/performance/{connection_id}/review" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPerformanceReviewsRequest req = new ListPerformanceReviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Performance.ListPerformanceReviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListPerformanceReviewsRequest](../../Models/Requests/ListPerformanceReviewsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListPerformanceReviewsResponse](../../Models/Requests/ListPerformanceReviewsResponse.md)**

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
        DueAt = System.DateTime.Parse("2026-08-04T14:05:05.603Z").ToUniversalTime(),
        Id = "71341b54-dc0a-479c-b996-0b482bb4c928",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-09T13:31:12.505Z").ToUniversalTime(),
                Id = "3fe5cabe-1cbc-4cfa-9d09-a241c74f2549",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-14T07:29:52.520Z").ToUniversalTime(),
                Id = "b16584ea-428d-4a48-912e-3c3a514abefb",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-16T10:00:20.607Z").ToUniversalTime(),
                Id = "f48ced87-f153-4865-89be-ff9a2d68a1f0",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-28T07:11:33.885Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-15T10:31:23.338Z").ToUniversalTime(),
        Weight = 5D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Performance.PatchPerformanceGoalAsync(req);

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

var res = await sdk.Performance.RemovePerformanceGoalAsync(
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
        DueAt = System.DateTime.Parse("2026-08-04T14:05:05.603Z").ToUniversalTime(),
        Id = "71341b54-dc0a-479c-b996-0b482bb4c928",
        Metadata = new List<PerformanceMetadata>() {},
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-06-09T13:31:12.505Z").ToUniversalTime(),
                Id = "3fe5cabe-1cbc-4cfa-9d09-a241c74f2549",
                IsCompleted = true,
                Name = "Team-oriented secondary matrix",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-08-14T07:29:52.520Z").ToUniversalTime(),
                Id = "b16584ea-428d-4a48-912e-3c3a514abefb",
                IsCompleted = true,
                Name = "Exclusive client-server conglomeration",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Hic explicabo odit.",
                DueAt = System.DateTime.Parse("2026-10-16T10:00:20.607Z").ToUniversalTime(),
                Id = "f48ced87-f153-4865-89be-ff9a2d68a1f0",
                IsCompleted = true,
                Name = "Synchronised immersive success",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-07-28T07:11:33.885Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-09-15T10:31:23.338Z").ToUniversalTime(),
        Weight = 5D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Performance.UpdatePerformanceGoalAsync(req);

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