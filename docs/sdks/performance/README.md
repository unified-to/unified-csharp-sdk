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

Create a feedback

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
        Id = "f5fce0fb-e6d4-4627-b15e-106baf0e1fee",
        IsVisible = true,
        Message = "Tabernus corpus voluptate aestus.",
        Tags = new List<string>() {
            "well-to-do",
            "hexagon",
        },
        Type = PerformanceFeedbackType.Praise,
        UpdatedAt = System.DateTime.Parse("2025-08-12T15:38:19.904Z").ToUniversalTime(),
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

var res = await sdk.Performance.CreatePerformanceGoalAsync(
    performanceGoal: new PerformanceGoal() {
        CreatedAt = System.DateTime.Parse("2020-01-09T20:43:07.380Z").ToUniversalTime(),
        Description = "Suscipit suspendo vulnero vel facere valeo vallum degero.",
        DueAt = System.DateTime.Parse("2026-06-27T20:58:33.713Z").ToUniversalTime(),
        Id = "acafe340-8dc1-489e-8f54-8a8085a9ded3",
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-05-03T17:33:02.180Z").ToUniversalTime(),
                Id = "ec90d3e3-23bd-4d9f-a5d7-e388979f90d9",
                IsCompleted = true,
                Name = "Front-line asynchronous hub",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-07-07T10:43:09.591Z").ToUniversalTime(),
                Id = "09e04b09-7197-4fc4-9c32-077230408c26",
                IsCompleted = true,
                Name = "Organized encompassing archive",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Nobis tremo debitis.",
                DueAt = System.DateTime.Parse("2026-09-07T13:24:57.437Z").ToUniversalTime(),
                Id = "bbe63683-c1d0-4932-89ac-ef81e73ae6f1",
                IsCompleted = true,
                Name = "Devolved directional middleware",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-06-26T10:33:31.577Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-08-31T00:54:02.388Z").ToUniversalTime(),
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

Retrieve a cycle

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

Retrieve a feedback

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

Retrieve a goal

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

Retrieve a review

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

List all cycles

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

List all feedbacks

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

List all reviews

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
        DueAt = System.DateTime.Parse("2026-06-27T20:58:33.727Z").ToUniversalTime(),
        Id = "a48153d9-a081-46df-92f7-0287d23ec5db",
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-05-03T17:33:02.194Z").ToUniversalTime(),
                Id = "ec90d3e3-23bd-4d9f-a5d7-e388979f90d9",
                IsCompleted = true,
                Name = "Front-line asynchronous hub",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-07-07T10:43:09.604Z").ToUniversalTime(),
                Id = "09e04b09-7197-4fc4-9c32-077230408c26",
                IsCompleted = true,
                Name = "Organized encompassing archive",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Nobis tremo debitis.",
                DueAt = System.DateTime.Parse("2026-09-07T13:24:57.451Z").ToUniversalTime(),
                Id = "bbe63683-c1d0-4932-89ac-ef81e73ae6f1",
                IsCompleted = true,
                Name = "Devolved directional middleware",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-06-26T10:33:31.589Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-08-31T00:54:02.393Z").ToUniversalTime(),
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

Remove a goal

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
        DueAt = System.DateTime.Parse("2026-06-27T20:58:33.727Z").ToUniversalTime(),
        Id = "a48153d9-a081-46df-92f7-0287d23ec5db",
        Milestones = new List<PerformanceGoalMilestone>() {
            new PerformanceGoalMilestone() {
                CurrentValue = 10D,
                DueAt = System.DateTime.Parse("2026-05-03T17:33:02.194Z").ToUniversalTime(),
                Id = "ec90d3e3-23bd-4d9f-a5d7-e388979f90d9",
                IsCompleted = true,
                Name = "Front-line asynchronous hub",
                TargetValue = 32D,
                Unit = "%",
                Weight = 7D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 0D,
                DueAt = System.DateTime.Parse("2026-07-07T10:43:09.604Z").ToUniversalTime(),
                Id = "09e04b09-7197-4fc4-9c32-077230408c26",
                IsCompleted = true,
                Name = "Organized encompassing archive",
                TargetValue = 32D,
                Weight = 5D,
            },
            new PerformanceGoalMilestone() {
                CurrentValue = 31D,
                Description = "Nobis tremo debitis.",
                DueAt = System.DateTime.Parse("2026-09-07T13:24:57.451Z").ToUniversalTime(),
                Id = "bbe63683-c1d0-4932-89ac-ef81e73ae6f1",
                IsCompleted = true,
                Name = "Devolved directional middleware",
                TargetValue = 32D,
                Weight = 5D,
            },
        },
        Name = "Proactive national protocol",
        Progress = 3D,
        StartAt = System.DateTime.Parse("2025-06-26T10:33:31.589Z").ToUniversalTime(),
        Status = PerformanceGoalStatus.Closed,
        Type = PerformanceGoalSchemasType.Company,
        UpdatedAt = System.DateTime.Parse("2022-08-31T00:54:02.393Z").ToUniversalTime(),
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