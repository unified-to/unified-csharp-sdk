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

Creates a LmsCourse. Provide the unified LmsCourse fields in the request body; they are mapped to the provider's API. Returns the created LmsCourse.

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
        Id = "504f519d-2f36-49b3-9867-ccbe2ffcb06d",
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
        Metadata = new List<LmsMetadata>() {},
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2022-11-05T18:38:06.816Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-09T20:12:37.394Z").ToUniversalTime(),
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

Retrieves a single LmsCourse by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of LmsCourses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the LmsCourse identified by `id`. Provide the unified LmsCourse fields to change in the request body.

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
        Id = "7e348666-faea-437c-9637-9fda9368a2be",
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
        Metadata = new List<LmsMetadata>() {},
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2022-11-05T18:38:06.817Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-09T20:12:37.396Z").ToUniversalTime(),
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

Deletes the LmsCourse identified by `id`.

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

Updates the LmsCourse identified by `id`. Provide the unified LmsCourse fields to change in the request body.

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
        Id = "7e348666-faea-437c-9637-9fda9368a2be",
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
        Metadata = new List<LmsMetadata>() {},
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2022-11-05T18:38:06.817Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-09T20:12:37.396Z").ToUniversalTime(),
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