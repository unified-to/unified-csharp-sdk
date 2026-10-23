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

Creates a HrisTimeshift. Provide the unified HrisTimeshift fields in the request body; they are mapped to the provider's API. Returns the created HrisTimeshift.

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
        ApprovedAt = System.DateTime.Parse("2022-07-18T21:58:36.052Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "GBP",
                Frequency = HrisCompensationFrequency.Semimonthly,
                Notes = "Vehemens annus adficio.",
                Type = HrisCompensationType.Commission,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-09-29T01:17:42.727Z").ToUniversalTime(),
        Hours = 6D,
        Id = "056bc355-a79c-4683-91c1-66b016f32033",
        IsApproved = false,
        Metadata = new List<HrisMetadata>() {},
        StartAt = System.DateTime.Parse("2023-07-14T03:08:55.414Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-07-02T11:06:38.653Z").ToUniversalTime(),
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

Retrieves a single HrisTimeshift by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of HrisTimeshifts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the HrisTimeshift identified by `id`. Provide the unified HrisTimeshift fields to change in the request body.

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
        ApprovedAt = System.DateTime.Parse("2022-07-18T21:58:36.062Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "GBP",
                Frequency = HrisCompensationFrequency.Semimonthly,
                Notes = "Vehemens annus adficio.",
                Type = HrisCompensationType.Commission,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-09-29T01:17:42.749Z").ToUniversalTime(),
        Hours = 6D,
        Id = "f5d1640d-fc8a-45c0-b7dd-a0efe3d0c4f3",
        IsApproved = false,
        Metadata = new List<HrisMetadata>() {},
        StartAt = System.DateTime.Parse("2023-07-14T03:08:55.427Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-07-02T11:06:38.659Z").ToUniversalTime(),
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

Deletes the HrisTimeshift identified by `id`.

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

Updates the HrisTimeshift identified by `id`. Provide the unified HrisTimeshift fields to change in the request body.

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
        ApprovedAt = System.DateTime.Parse("2022-07-18T21:58:36.062Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "GBP",
                Frequency = HrisCompensationFrequency.Semimonthly,
                Notes = "Vehemens annus adficio.",
                Type = HrisCompensationType.Commission,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-09-29T01:17:42.749Z").ToUniversalTime(),
        Hours = 6D,
        Id = "f5d1640d-fc8a-45c0-b7dd-a0efe3d0c4f3",
        IsApproved = false,
        Metadata = new List<HrisMetadata>() {},
        StartAt = System.DateTime.Parse("2023-07-14T03:08:55.427Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-07-02T11:06:38.659Z").ToUniversalTime(),
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