# Activity

## Overview

### Available Operations

* [CreateAtsActivity](#createatsactivity) - Create an activity
* [CreateLmsActivity](#createlmsactivity) - Create an activity
* [GetAtsActivity](#getatsactivity) - Retrieve an activity
* [GetClubsActivity](#getclubsactivity) - Retrieve an activity
* [GetLmsActivity](#getlmsactivity) - Retrieve an activity
* [ListAtsActivities](#listatsactivities) - List all activities
* [ListClubsActivities](#listclubsactivities) - List all activities
* [ListLmsActivities](#listlmsactivities) - List all activities
* [PatchAtsActivity](#patchatsactivity) - Update an activity
* [PatchLmsActivity](#patchlmsactivity) - Update an activity
* [RemoveAtsActivity](#removeatsactivity) - Remove an activity
* [RemoveLmsActivity](#removelmsactivity) - Remove an activity
* [UpdateAtsActivity](#updateatsactivity) - Update an activity
* [UpdateLmsActivity](#updatelmsactivity) - Update an activity

## CreateAtsActivity

Creates a AtsActivity. Provide the unified AtsActivity fields in the request body; they are mapped to the provider's API. Returns the created AtsActivity.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsActivity" method="post" path="/ats/{connection_id}/activity" example="ats_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.CreateAtsActivityAsync(
    atsActivity: new AtsActivity() {
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Sapiente.",
        Id = "bb98a3a5-f80a-4fa2-8d4b-fd8af04b83db",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "0949435a-237b-4d35-b21e-a185d0a1de7b",
                Namespace = "activity",
                Slug = "cimentarius",
                Value = AtsMetadataValue.CreateStr(
                    "Reprehenderit verto."
                ),
            },
        },
        SubType = "TASK",
        Title = "Venio blandior aureus.",
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-04-07T17:43:09.912Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsActivity`                                                                                                                                    | [AtsActivity](../../Models/Components/AtsActivity.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsActivityQueryParamFields](../../Models/Requests/CreateAtsActivityQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsActivityResponse](../../Models/Requests/CreateAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsActivity

Creates a LmsActivity. Provide the unified LmsActivity fields in the request body; they are mapped to the provider's API. Returns the created LmsActivity.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsActivity" method="post" path="/lms/{connection_id}/activity" example="lms_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.CreateLmsActivityAsync(
    lmsActivity: new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2023-12-08T01:29:35.088Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "748268dd-c721-4f46-8243-3fc6df2b9037",
        IsCompleted = true,
        Metadata = new List<LmsMetadata>() {},
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2021-04-25T12:39:52.602Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-31T20:10:44.518Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsActivity`                                                                                                                                    | [LmsActivity](../../Models/Components/LmsActivity.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsActivityQueryParamFields](../../Models/Requests/CreateLmsActivityQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsActivityResponse](../../Models/Requests/CreateLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsActivity

Retrieves a single AtsActivity by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsActivity" method="get" path="/ats/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.GetAtsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Activity                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAtsActivityQueryParamFields](../../Models/Requests/GetAtsActivityQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsActivityResponse](../../Models/Requests/GetAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetClubsActivity

Retrieves a single ClubsActivity by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClubsActivity" method="get" path="/clubs/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.GetClubsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Activity                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetClubsActivityQueryParamFields](../../Models/Requests/GetClubsActivityQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetClubsActivityResponse](../../Models/Requests/GetClubsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsActivity

Retrieves a single LmsActivity by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsActivity" method="get" path="/lms/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.GetLmsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Activity                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetLmsActivityQueryParamFields](../../Models/Requests/GetLmsActivityQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsActivityResponse](../../Models/Requests/GetLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsActivities

Returns a list of AtsActivities. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsActivities" method="get" path="/ats/{connection_id}/activity" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsActivitiesRequest req = new ListAtsActivitiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Activity.ListAtsActivitiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsActivitiesRequest](../../Models/Requests/ListAtsActivitiesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsActivitiesResponse](../../Models/Requests/ListAtsActivitiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListClubsActivities

Returns a list of ClubsActivities. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClubsActivities" method="get" path="/clubs/{connection_id}/activity" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListClubsActivitiesRequest req = new ListClubsActivitiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Activity.ListClubsActivitiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListClubsActivitiesRequest](../../Models/Requests/ListClubsActivitiesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListClubsActivitiesResponse](../../Models/Requests/ListClubsActivitiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsActivities

Returns a list of LmsActivities. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsActivities" method="get" path="/lms/{connection_id}/activity" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsActivitiesRequest req = new ListLmsActivitiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Activity.ListLmsActivitiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListLmsActivitiesRequest](../../Models/Requests/ListLmsActivitiesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListLmsActivitiesResponse](../../Models/Requests/ListLmsActivitiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsActivity

Updates the AtsActivity identified by `id`. Provide the unified AtsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsActivity" method="patch" path="/ats/{connection_id}/activity/{id}" example="ats_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsActivityRequest req = new PatchAtsActivityRequest() {
    AtsActivity = new AtsActivity() {
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Sapiente.",
        Id = "f6e08afb-ea94-43bc-ac06-102c170ac74d",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "cb4a1cb9-b532-492c-88d9-7d9cb9eec617",
                Namespace = "activity",
                Slug = "cimentarius",
                Value = AtsMetadataValue.CreateStr(
                    "Reprehenderit verto."
                ),
            },
        },
        SubType = "TASK",
        Title = "Venio blandior aureus.",
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-04-07T17:43:09.946Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Activity.PatchAtsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchAtsActivityRequest](../../Models/Requests/PatchAtsActivityRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchAtsActivityResponse](../../Models/Requests/PatchAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsActivity

Updates the LmsActivity identified by `id`. Provide the unified LmsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsActivity" method="patch" path="/lms/{connection_id}/activity/{id}" example="lms_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsActivityRequest req = new PatchLmsActivityRequest() {
    LmsActivity = new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2023-12-08T01:29:35.094Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "94de8da3-e3d6-4eb4-8f0a-ad57b79f0838",
        IsCompleted = true,
        Metadata = new List<LmsMetadata>() {},
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2021-04-25T12:39:52.603Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-31T20:10:44.521Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Activity.PatchLmsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchLmsActivityRequest](../../Models/Requests/PatchLmsActivityRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchLmsActivityResponse](../../Models/Requests/PatchLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsActivity

Deletes the AtsActivity identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsActivity" method="delete" path="/ats/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.RemoveAtsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Activity   |

### Response

**[RemoveAtsActivityResponse](../../Models/Requests/RemoveAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsActivity

Deletes the LmsActivity identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsActivity" method="delete" path="/lms/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.RemoveLmsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Activity   |

### Response

**[RemoveLmsActivityResponse](../../Models/Requests/RemoveLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsActivity

Updates the AtsActivity identified by `id`. Provide the unified AtsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsActivity" method="put" path="/ats/{connection_id}/activity/{id}" example="ats_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsActivityRequest req = new UpdateAtsActivityRequest() {
    AtsActivity = new AtsActivity() {
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Sapiente.",
        Id = "f6e08afb-ea94-43bc-ac06-102c170ac74d",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "cb4a1cb9-b532-492c-88d9-7d9cb9eec617",
                Namespace = "activity",
                Slug = "cimentarius",
                Value = AtsMetadataValue.CreateStr(
                    "Reprehenderit verto."
                ),
            },
        },
        SubType = "TASK",
        Title = "Venio blandior aureus.",
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-04-07T17:43:09.946Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Activity.UpdateAtsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateAtsActivityRequest](../../Models/Requests/UpdateAtsActivityRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateAtsActivityResponse](../../Models/Requests/UpdateAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsActivity

Updates the LmsActivity identified by `id`. Provide the unified LmsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsActivity" method="put" path="/lms/{connection_id}/activity/{id}" example="lms_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsActivityRequest req = new UpdateLmsActivityRequest() {
    LmsActivity = new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2023-12-08T01:29:35.094Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "94de8da3-e3d6-4eb4-8f0a-ad57b79f0838",
        IsCompleted = true,
        Metadata = new List<LmsMetadata>() {},
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2021-04-25T12:39:52.603Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-31T20:10:44.521Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Activity.UpdateLmsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateLmsActivityRequest](../../Models/Requests/UpdateLmsActivityRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateLmsActivityResponse](../../Models/Requests/UpdateLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |