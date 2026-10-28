# Instructor

## Overview

### Available Operations

* [CreateLmsInstructor](#createlmsinstructor) - Create an instructor
* [GetLmsInstructor](#getlmsinstructor) - Retrieve an instructor
* [ListLmsInstructors](#listlmsinstructors) - List all instructors
* [PatchLmsInstructor](#patchlmsinstructor) - Update an instructor
* [RemoveLmsInstructor](#removelmsinstructor) - Remove an instructor
* [UpdateLmsInstructor](#updatelmsinstructor) - Update an instructor

## CreateLmsInstructor

Creates a LmsInstructor. Provide the unified LmsInstructor fields in the request body; they are mapped to the provider's API. Returns the created LmsInstructor.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsInstructor" method="post" path="/lms/{connection_id}/instructor" example="lms_instructor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Instructor.CreateLmsInstructorAsync(
    lmsInstructor: new LmsInstructor() {
        CreatedAt = System.DateTime.Parse("2021-10-12T16:38:54.979Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Deangelo",
        Id = "97eb8d7d-8cca-49aa-bb87-dedf0c42f268",
        ImageUrl = "https://avatars.githubusercontent.com/u/95131132",
        LastName = "Ritchie",
        Metadata = new List<LmsMetadata>() {},
        Name = "Deangelo Ritchie",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(605) 752-8163",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(430) 415-2451",
                Type = LmsTelephoneType.Home,
            },
        },
        Title = "Regional Security Agent",
        UpdatedAt = System.DateTime.Parse("2025-07-29T17:10:52.181Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsInstructor`                                                                                                                                  | [LmsInstructor](../../Models/Components/LmsInstructor.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsInstructorQueryParamFields](../../Models/Requests/CreateLmsInstructorQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsInstructorResponse](../../Models/Requests/CreateLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsInstructor

Retrieves a single LmsInstructor by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsInstructor" method="get" path="/lms/{connection_id}/instructor/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Instructor.GetLmsInstructorAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Instructor                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetLmsInstructorQueryParamFields](../../Models/Requests/GetLmsInstructorQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsInstructorResponse](../../Models/Requests/GetLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsInstructors

Returns a list of LmsInstructors. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsInstructors" method="get" path="/lms/{connection_id}/instructor" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsInstructorsRequest req = new ListLmsInstructorsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Instructor.ListLmsInstructorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListLmsInstructorsRequest](../../Models/Requests/ListLmsInstructorsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListLmsInstructorsResponse](../../Models/Requests/ListLmsInstructorsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsInstructor

Updates the LmsInstructor identified by `id`. Provide the unified LmsInstructor fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsInstructor" method="patch" path="/lms/{connection_id}/instructor/{id}" example="lms_instructor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsInstructorRequest req = new PatchLmsInstructorRequest() {
    LmsInstructor = new LmsInstructor() {
        CreatedAt = System.DateTime.Parse("2021-10-12T16:38:54.979Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Deangelo",
        Id = "7c21821f-205f-4360-b702-a7a64ba7760f",
        ImageUrl = "https://avatars.githubusercontent.com/u/95131132",
        LastName = "Ritchie",
        Metadata = new List<LmsMetadata>() {},
        Name = "Deangelo Ritchie",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(605) 752-8163",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(430) 415-2451",
                Type = LmsTelephoneType.Home,
            },
        },
        Title = "Regional Security Agent",
        UpdatedAt = System.DateTime.Parse("2025-07-29T17:10:52.208Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Instructor.PatchLmsInstructorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchLmsInstructorRequest](../../Models/Requests/PatchLmsInstructorRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchLmsInstructorResponse](../../Models/Requests/PatchLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsInstructor

Deletes the LmsInstructor identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsInstructor" method="delete" path="/lms/{connection_id}/instructor/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Instructor.RemoveLmsInstructorAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Instructor |

### Response

**[RemoveLmsInstructorResponse](../../Models/Requests/RemoveLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsInstructor

Updates the LmsInstructor identified by `id`. Provide the unified LmsInstructor fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsInstructor" method="put" path="/lms/{connection_id}/instructor/{id}" example="lms_instructor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsInstructorRequest req = new UpdateLmsInstructorRequest() {
    LmsInstructor = new LmsInstructor() {
        CreatedAt = System.DateTime.Parse("2021-10-12T16:38:54.979Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Deangelo",
        Id = "7c21821f-205f-4360-b702-a7a64ba7760f",
        ImageUrl = "https://avatars.githubusercontent.com/u/95131132",
        LastName = "Ritchie",
        Metadata = new List<LmsMetadata>() {},
        Name = "Deangelo Ritchie",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(605) 752-8163",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(430) 415-2451",
                Type = LmsTelephoneType.Home,
            },
        },
        Title = "Regional Security Agent",
        UpdatedAt = System.DateTime.Parse("2025-07-29T17:10:52.208Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Instructor.UpdateLmsInstructorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateLmsInstructorRequest](../../Models/Requests/UpdateLmsInstructorRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateLmsInstructorResponse](../../Models/Requests/UpdateLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |