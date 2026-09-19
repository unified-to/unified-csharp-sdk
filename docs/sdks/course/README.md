# Course

## Overview

### Available Operations

* [CreateLmsCourse](#createlmscourse) - Create a course
* [GetLmsCourse](#getlmscourse) - Retrieve a course
* [ListLmsCourses](#listlmscourses) - List all courses
* [PatchLmsCourse](#patchlmscourse) - Update a course
* [RemoveLmsCourse](#removelmscourse) - Remove a course
* [UpdateLmsCourse](#updatelmscourse) - Update a course

## CreateLmsCourse

Create a course

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsCourse" method="post" path="/lms/{connection_id}/course" example="lms_course" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Course.CreateLmsCourseAsync(
    lmsCourse: new LmsCourse() {
        Categories = new List<string>() {
            "tergiversatio",
            "tumultus",
        },
        CreatedAt = System.DateTime.Parse("2022-10-06T09:58:53.559Z").ToUniversalTime(),
        Currency = "FJD",
        Description = "Vinco alias aut capitulus.",
        DurationMinutes = 148D,
        Id = "56d511b0-c87a-49f7-aca5-3b63b3355fee",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        IsPrivate = false,
        Languages = new List<string>() {
            "desparatus",
            "earum",
            "deripio",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adeptio crudelis ipsum utrimque quae architecto. Cum eius conitor anser abutor error adsuesco abeo. Denego nihil caries aveho.",
                Description = "Adipiscor.",
                Languages = new List<string>() {
                    "ms",
                    "te",
                },
                Name = "tandem",
                ThumbnailUrl = "https://picsum.photos/seed/syTatRhK03/928/273",
                Type = LmsMediaType.Other,
                Url = "https://picsum.photos/seed/fQAbsk/2472/1671",
            },
        },
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2023-12-30T03:35:03.902Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-07T00:33:01.953Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsCourse`                                                                                                                                      | [LmsCourse](../../Models/Components/LmsCourse.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsCourseQueryParamFields](../../Models/Requests/CreateLmsCourseQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsCourseResponse](../../Models/Requests/CreateLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsCourse

Retrieve a course

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsCourse" method="get" path="/lms/{connection_id}/course/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Course.GetLmsCourseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Course                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetLmsCourseQueryParamFields](../../Models/Requests/GetLmsCourseQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsCourseResponse](../../Models/Requests/GetLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsCourses

List all courses

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsCourses" method="get" path="/lms/{connection_id}/course" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsCoursesRequest req = new ListLmsCoursesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Course.ListLmsCoursesAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListLmsCoursesRequest](../../Models/Requests/ListLmsCoursesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListLmsCoursesResponse](../../Models/Requests/ListLmsCoursesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsCourse

Update a course

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsCourse" method="patch" path="/lms/{connection_id}/course/{id}" example="lms_course" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsCourseRequest req = new PatchLmsCourseRequest() {
    LmsCourse = new LmsCourse() {
        Categories = new List<string>() {
            "tergiversatio",
            "tumultus",
        },
        CreatedAt = System.DateTime.Parse("2022-10-06T09:58:53.559Z").ToUniversalTime(),
        Currency = "FJD",
        Description = "Vinco alias aut capitulus.",
        DurationMinutes = 148D,
        Id = "bb0d159d-d506-4563-821d-50fc62b63b2a",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        IsPrivate = false,
        Languages = new List<string>() {
            "desparatus",
            "earum",
            "deripio",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adeptio crudelis ipsum utrimque quae architecto. Cum eius conitor anser abutor error adsuesco abeo. Denego nihil caries aveho.",
                Description = "Adipiscor.",
                Languages = new List<string>() {
                    "ms",
                    "te",
                },
                Name = "tandem",
                ThumbnailUrl = "https://picsum.photos/seed/syTatRhK03/928/273",
                Type = LmsMediaType.Other,
                Url = "https://picsum.photos/seed/fQAbsk/2472/1671",
            },
        },
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2023-12-30T03:35:03.902Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-07T00:33:01.954Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Course.PatchLmsCourseAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchLmsCourseRequest](../../Models/Requests/PatchLmsCourseRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchLmsCourseResponse](../../Models/Requests/PatchLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsCourse

Remove a course

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsCourse" method="delete" path="/lms/{connection_id}/course/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Course.RemoveLmsCourseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Course     |

### Response

**[RemoveLmsCourseResponse](../../Models/Requests/RemoveLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsCourse

Update a course

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsCourse" method="put" path="/lms/{connection_id}/course/{id}" example="lms_course" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsCourseRequest req = new UpdateLmsCourseRequest() {
    LmsCourse = new LmsCourse() {
        Categories = new List<string>() {
            "tergiversatio",
            "tumultus",
        },
        CreatedAt = System.DateTime.Parse("2022-10-06T09:58:53.559Z").ToUniversalTime(),
        Currency = "FJD",
        Description = "Vinco alias aut capitulus.",
        DurationMinutes = 148D,
        Id = "bb0d159d-d506-4563-821d-50fc62b63b2a",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        IsPrivate = false,
        Languages = new List<string>() {
            "desparatus",
            "earum",
            "deripio",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adeptio crudelis ipsum utrimque quae architecto. Cum eius conitor anser abutor error adsuesco abeo. Denego nihil caries aveho.",
                Description = "Adipiscor.",
                Languages = new List<string>() {
                    "ms",
                    "te",
                },
                Name = "tandem",
                ThumbnailUrl = "https://picsum.photos/seed/syTatRhK03/928/273",
                Type = LmsMediaType.Other,
                Url = "https://picsum.photos/seed/fQAbsk/2472/1671",
            },
        },
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2023-12-30T03:35:03.902Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-07T00:33:01.954Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Course.UpdateLmsCourseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateLmsCourseRequest](../../Models/Requests/UpdateLmsCourseRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateLmsCourseResponse](../../Models/Requests/UpdateLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |