# Class

## Overview

### Available Operations

* [CreateLmsClass](#createlmsclass) - Create a class
* [GetLmsClass](#getlmsclass) - Retrieve a class
* [ListLmsClasses](#listlmsclasses) - List all classes
* [PatchLmsClass](#patchlmsclass) - Update a class
* [RemoveLmsClass](#removelmsclass) - Remove a class
* [UpdateLmsClass](#updatelmsclass) - Update a class

## CreateLmsClass

Creates a LmsClass. Provide the unified LmsClass fields in the request body; they are mapped to the provider's API. Returns the created LmsClass.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsClass" method="post" path="/lms/{connection_id}/class" example="lms_class" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Class.CreateLmsClassAsync(
    lmsClass: new LmsClass() {
        CreatedAt = System.DateTime.Parse("2020-02-20T14:48:51.845Z").ToUniversalTime(),
        Description = "Anser sperno decerno.",
        Id = "509301cc-ce37-42ff-8129-5779db077025",
        Instructors = new List<LmsReference>() {},
        Languages = new List<string>() {
            "in",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Defetiscor aetas acies benevolentia ulterius. Creta bis beneficium canis. Bonus valeo vulgo creator arca peior ceno earum culpa. Tabesco apostolus talis. Ultra accommodo deinde sono culpo arto cruciamentum triduana.",
                Description = "Esse confido.",
                Languages = new List<string>() {
                    "fa",
                    "da",
                },
                Name = "illo",
                ThumbnailUrl = "https://loremflickr.com/199/1934?lock=4323325966476891",
                Type = LmsMediaType.Video,
                Url = "https://loremflickr.com/487/921?lock=5127962071241632",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "virtus",
        Students = new List<LmsReference>() {},
        UpdatedAt = System.DateTime.Parse("2025-08-07T03:37:47.917Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsClass`                                                                                                                                       | [LmsClass](../../Models/Components/LmsClass.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsClassQueryParamFields](../../Models/Requests/CreateLmsClassQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsClassResponse](../../Models/Requests/CreateLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsClass

Retrieves a single LmsClass by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsClass" method="get" path="/lms/{connection_id}/class/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Class.GetLmsClassAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Class                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetLmsClassQueryParamFields](../../Models/Requests/GetLmsClassQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsClassResponse](../../Models/Requests/GetLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsClasses

Returns a list of LmsClasses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsClasses" method="get" path="/lms/{connection_id}/class" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsClassesRequest req = new ListLmsClassesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Class.ListLmsClassesAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListLmsClassesRequest](../../Models/Requests/ListLmsClassesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListLmsClassesResponse](../../Models/Requests/ListLmsClassesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsClass

Updates the LmsClass identified by `id`. Provide the unified LmsClass fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsClass" method="patch" path="/lms/{connection_id}/class/{id}" example="lms_class" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsClassRequest req = new PatchLmsClassRequest() {
    LmsClass = new LmsClass() {
        CreatedAt = System.DateTime.Parse("2020-02-20T14:48:51.845Z").ToUniversalTime(),
        Description = "Anser sperno decerno.",
        Id = "85569cfd-648c-46ac-a5ca-f02321d6e508",
        Instructors = new List<LmsReference>() {},
        Languages = new List<string>() {
            "in",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Defetiscor aetas acies benevolentia ulterius. Creta bis beneficium canis. Bonus valeo vulgo creator arca peior ceno earum culpa. Tabesco apostolus talis. Ultra accommodo deinde sono culpo arto cruciamentum triduana.",
                Description = "Esse confido.",
                Languages = new List<string>() {
                    "fa",
                    "da",
                },
                Name = "illo",
                ThumbnailUrl = "https://loremflickr.com/199/1934?lock=4323325966476891",
                Type = LmsMediaType.Video,
                Url = "https://loremflickr.com/487/921?lock=5127962071241632",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "virtus",
        Students = new List<LmsReference>() {},
        UpdatedAt = System.DateTime.Parse("2025-08-07T03:37:47.930Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Class.PatchLmsClassAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchLmsClassRequest](../../Models/Requests/PatchLmsClassRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchLmsClassResponse](../../Models/Requests/PatchLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsClass

Deletes the LmsClass identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsClass" method="delete" path="/lms/{connection_id}/class/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Class.RemoveLmsClassAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Class      |

### Response

**[RemoveLmsClassResponse](../../Models/Requests/RemoveLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsClass

Updates the LmsClass identified by `id`. Provide the unified LmsClass fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsClass" method="put" path="/lms/{connection_id}/class/{id}" example="lms_class" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsClassRequest req = new UpdateLmsClassRequest() {
    LmsClass = new LmsClass() {
        CreatedAt = System.DateTime.Parse("2020-02-20T14:48:51.845Z").ToUniversalTime(),
        Description = "Anser sperno decerno.",
        Id = "85569cfd-648c-46ac-a5ca-f02321d6e508",
        Instructors = new List<LmsReference>() {},
        Languages = new List<string>() {
            "in",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Defetiscor aetas acies benevolentia ulterius. Creta bis beneficium canis. Bonus valeo vulgo creator arca peior ceno earum culpa. Tabesco apostolus talis. Ultra accommodo deinde sono culpo arto cruciamentum triduana.",
                Description = "Esse confido.",
                Languages = new List<string>() {
                    "fa",
                    "da",
                },
                Name = "illo",
                ThumbnailUrl = "https://loremflickr.com/199/1934?lock=4323325966476891",
                Type = LmsMediaType.Video,
                Url = "https://loremflickr.com/487/921?lock=5127962071241632",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "virtus",
        Students = new List<LmsReference>() {},
        UpdatedAt = System.DateTime.Parse("2025-08-07T03:37:47.930Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Class.UpdateLmsClassAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateLmsClassRequest](../../Models/Requests/UpdateLmsClassRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateLmsClassResponse](../../Models/Requests/UpdateLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |