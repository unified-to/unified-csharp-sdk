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

Create an activity

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
        Bcc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Mabel_Schuppe-Schowalter42@hotmail.com",
                Name = "Rochelle Franey-Bechtelar",
                Type = AtsEmailType.Home,
            },
        },
        Cc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sasha24@hotmail.com",
                Name = "Dr. Elbert Kuvalis",
                Type = AtsEmailType.Home,
            },
            new AtsEmail() {
                Email = "Rosetta_Donnelly@gmail.com",
                Name = "Ramon Daniel",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Kathryne_Jast@yahoo.com",
                Name = "Christian Jacobson",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Eldred95@yahoo.com",
                Name = "Edna Bogan",
                Type = AtsEmailType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Amplus.",
        From = new PropertyAtsActivityFrom() {
            Email = "Norwood.Wiza47@yahoo.com",
            Name = "Toby Grant",
            Type = PropertyAtsActivityFromType.Other,
        },
        Id = "a977827b-b121-44aa-b5fb-03d6e92712df",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "7de2060b-8067-42d9-ba3e-401db0c4a770",
                Namespace = "activity",
                Slug = "acer",
                Value = AtsMetadataValue.CreateStr(
                    "Pauci eius cena adamo summisse arguo pectus communis arcesso tergeo."
                ),
            },
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "00b15a32-2f6a-45ac-94fb-7a5ca45725dd",
                Namespace = "activity",
                Slug = "tremo",
                Value = AtsMetadataValue.CreateStr(
                    "Amita delectus dicta temptatio utroque ex."
                ),
            },
        },
        SubType = "TASK",
        Title = "Senior Interactions Manager",
        To = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sister91@hotmail.com",
                Name = "Eddie Nienow PhD",
                Type = AtsEmailType.Work,
            },
        },
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-03-29T22:34:14.655Z").ToUniversalTime(),
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

Create an activity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsActivity" method="post" path="/lms/{connection_id}/activity" example="lms_activity" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Activity.CreateLmsActivityAsync(
    lmsActivity: new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2025-04-25T16:15:30.389Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "166ea61c-4894-479c-b849-5a6eadff66ac",
        IsCompleted = true,
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2023-12-24T04:54:05.825Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-29T16:06:18.795Z").ToUniversalTime(),
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

Retrieve an activity

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

Retrieve an activity

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

Retrieve an activity

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

List all activities

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

List all activities

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

List all activities

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

Update an activity

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
        Bcc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Mabel_Schuppe-Schowalter42@hotmail.com",
                Name = "Rochelle Franey-Bechtelar",
                Type = AtsEmailType.Home,
            },
        },
        Cc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sasha24@hotmail.com",
                Name = "Dr. Elbert Kuvalis",
                Type = AtsEmailType.Home,
            },
            new AtsEmail() {
                Email = "Rosetta_Donnelly@gmail.com",
                Name = "Ramon Daniel",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Kathryne_Jast@yahoo.com",
                Name = "Christian Jacobson",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Eldred95@yahoo.com",
                Name = "Edna Bogan",
                Type = AtsEmailType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Amplus.",
        From = new PropertyAtsActivityFrom() {
            Email = "Norwood.Wiza47@yahoo.com",
            Name = "Toby Grant",
            Type = PropertyAtsActivityFromType.Other,
        },
        Id = "108ea3ca-903d-4c05-aeb0-6b0b0ae25996",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "c4c7bdae-7cd4-489b-b7e5-5caca3ef8d08",
                Namespace = "activity",
                Slug = "acer",
                Value = AtsMetadataValue.CreateStr(
                    "Pauci eius cena adamo summisse arguo pectus communis arcesso tergeo."
                ),
            },
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "b388f661-e2ea-4b96-b496-5af06fccbd04",
                Namespace = "activity",
                Slug = "tremo",
                Value = AtsMetadataValue.CreateStr(
                    "Amita delectus dicta temptatio utroque ex."
                ),
            },
        },
        SubType = "TASK",
        Title = "Senior Interactions Manager",
        To = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sister91@hotmail.com",
                Name = "Eddie Nienow PhD",
                Type = AtsEmailType.Work,
            },
        },
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-03-29T22:34:14.678Z").ToUniversalTime(),
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

Update an activity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsActivity" method="patch" path="/lms/{connection_id}/activity/{id}" example="lms_activity" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsActivityRequest req = new PatchLmsActivityRequest() {
    LmsActivity = new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2025-04-25T16:15:30.394Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "a7025c82-e356-4f86-aec8-abfcfd23c514",
        IsCompleted = true,
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2023-12-24T04:54:05.825Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-29T16:06:18.797Z").ToUniversalTime(),
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

Remove an activity

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

Remove an activity

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

Update an activity

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
        Bcc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Mabel_Schuppe-Schowalter42@hotmail.com",
                Name = "Rochelle Franey-Bechtelar",
                Type = AtsEmailType.Home,
            },
        },
        Cc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sasha24@hotmail.com",
                Name = "Dr. Elbert Kuvalis",
                Type = AtsEmailType.Home,
            },
            new AtsEmail() {
                Email = "Rosetta_Donnelly@gmail.com",
                Name = "Ramon Daniel",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Kathryne_Jast@yahoo.com",
                Name = "Christian Jacobson",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Eldred95@yahoo.com",
                Name = "Edna Bogan",
                Type = AtsEmailType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Amplus.",
        From = new PropertyAtsActivityFrom() {
            Email = "Norwood.Wiza47@yahoo.com",
            Name = "Toby Grant",
            Type = PropertyAtsActivityFromType.Other,
        },
        Id = "108ea3ca-903d-4c05-aeb0-6b0b0ae25996",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "c4c7bdae-7cd4-489b-b7e5-5caca3ef8d08",
                Namespace = "activity",
                Slug = "acer",
                Value = AtsMetadataValue.CreateStr(
                    "Pauci eius cena adamo summisse arguo pectus communis arcesso tergeo."
                ),
            },
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "b388f661-e2ea-4b96-b496-5af06fccbd04",
                Namespace = "activity",
                Slug = "tremo",
                Value = AtsMetadataValue.CreateStr(
                    "Amita delectus dicta temptatio utroque ex."
                ),
            },
        },
        SubType = "TASK",
        Title = "Senior Interactions Manager",
        To = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sister91@hotmail.com",
                Name = "Eddie Nienow PhD",
                Type = AtsEmailType.Work,
            },
        },
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-03-29T22:34:14.678Z").ToUniversalTime(),
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

Update an activity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsActivity" method="put" path="/lms/{connection_id}/activity/{id}" example="lms_activity" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsActivityRequest req = new UpdateLmsActivityRequest() {
    LmsActivity = new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2025-04-25T16:15:30.394Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "a7025c82-e356-4f86-aec8-abfcfd23c514",
        IsCompleted = true,
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2023-12-24T04:54:05.825Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-29T16:06:18.797Z").ToUniversalTime(),
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