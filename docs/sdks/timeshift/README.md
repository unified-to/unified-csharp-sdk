# Timeshift

## Overview

### Available Operations

* [CreateHrisTimeshift](#createhristimeshift) - Create a timeshift
* [GetHrisTimeshift](#gethristimeshift) - Retrieve a timeshift
* [ListHrisTimeshifts](#listhristimeshifts) - List all timeshifts
* [PatchHrisTimeshift](#patchhristimeshift) - Update a timeshift
* [RemoveHrisTimeshift](#removehristimeshift) - Remove a timeshift
* [UpdateHrisTimeshift](#updatehristimeshift) - Update a timeshift

## CreateHrisTimeshift

Create a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisTimeshift" method="post" path="/hris/{connection_id}/timeshift" example="hris_timeshift" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeshift.CreateHrisTimeshiftAsync(
    hrisTimeshift: new HrisTimeshift() {
        ApprovedAt = System.DateTime.Parse("2023-06-05T14:32:23.860Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "JPY",
                Frequency = HrisCompensationFrequency.Hour,
                Notes = "Annus adficio suasoria architecto aggero.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-08-25T08:29:34.504Z").ToUniversalTime(),
        Hours = 8D,
        Id = "edb7e65d-ee9c-4de9-bf02-4dccb2d29377",
        IsApproved = true,
        StartAt = System.DateTime.Parse("2023-06-24T19:30:14.691Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-06-22T20:53:37.144Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTimeshift`                                                                                                                                  | [HrisTimeshift](../../Models/Components/HrisTimeshift.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTimeshiftQueryParamFields](../../Models/Requests/CreateHrisTimeshiftQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTimeshiftResponse](../../Models/Requests/CreateHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTimeshift

Retrieve a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisTimeshift" method="get" path="/hris/{connection_id}/timeshift/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeshift.GetHrisTimeshiftAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Timeshift                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHrisTimeshiftQueryParamFields](../../Models/Requests/GetHrisTimeshiftQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTimeshiftResponse](../../Models/Requests/GetHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTimeshifts

List all timeshifts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisTimeshifts" method="get" path="/hris/{connection_id}/timeshift" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTimeshiftsRequest req = new ListHrisTimeshiftsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Timeshift.ListHrisTimeshiftsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListHrisTimeshiftsRequest](../../Models/Requests/ListHrisTimeshiftsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListHrisTimeshiftsResponse](../../Models/Requests/ListHrisTimeshiftsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisTimeshift

Update a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisTimeshift" method="patch" path="/hris/{connection_id}/timeshift/{id}" example="hris_timeshift" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisTimeshiftRequest req = new PatchHrisTimeshiftRequest() {
    HrisTimeshift = new HrisTimeshift() {
        ApprovedAt = System.DateTime.Parse("2023-06-05T14:32:23.868Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "JPY",
                Frequency = HrisCompensationFrequency.Hour,
                Notes = "Annus adficio suasoria architecto aggero.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-08-25T08:29:34.519Z").ToUniversalTime(),
        Hours = 8D,
        Id = "c51bdd14-5147-4def-afb6-882c8f97c0df",
        IsApproved = true,
        StartAt = System.DateTime.Parse("2023-06-24T19:30:14.699Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-06-22T20:53:37.148Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeshift.PatchHrisTimeshiftAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchHrisTimeshiftRequest](../../Models/Requests/PatchHrisTimeshiftRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchHrisTimeshiftResponse](../../Models/Requests/PatchHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisTimeshift

Remove a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisTimeshift" method="delete" path="/hris/{connection_id}/timeshift/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeshift.RemoveHrisTimeshiftAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Timeshift  |

### Response

**[RemoveHrisTimeshiftResponse](../../Models/Requests/RemoveHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisTimeshift

Update a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisTimeshift" method="put" path="/hris/{connection_id}/timeshift/{id}" example="hris_timeshift" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisTimeshiftRequest req = new UpdateHrisTimeshiftRequest() {
    HrisTimeshift = new HrisTimeshift() {
        ApprovedAt = System.DateTime.Parse("2023-06-05T14:32:23.868Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "JPY",
                Frequency = HrisCompensationFrequency.Hour,
                Notes = "Annus adficio suasoria architecto aggero.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-08-25T08:29:34.519Z").ToUniversalTime(),
        Hours = 8D,
        Id = "c51bdd14-5147-4def-afb6-882c8f97c0df",
        IsApproved = true,
        StartAt = System.DateTime.Parse("2023-06-24T19:30:14.699Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-06-22T20:53:37.148Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeshift.UpdateHrisTimeshiftAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateHrisTimeshiftRequest](../../Models/Requests/UpdateHrisTimeshiftRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateHrisTimeshiftResponse](../../Models/Requests/UpdateHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |