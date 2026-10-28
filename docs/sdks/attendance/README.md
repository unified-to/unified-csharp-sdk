# Attendance

## Overview

### Available Operations

* [CreateHrisAttendance](#createhrisattendance) - Create an attendance
* [GetHrisAttendance](#gethrisattendance) - Retrieve an attendance
* [ListHrisAttendances](#listhrisattendances) - List all attendances
* [PatchHrisAttendance](#patchhrisattendance) - Update an attendance
* [RemoveHrisAttendance](#removehrisattendance) - Remove an attendance
* [UpdateHrisAttendance](#updatehrisattendance) - Update an attendance

## CreateHrisAttendance

Creates a HrisAttendance. Provide the unified HrisAttendance fields in the request body; they are mapped to the provider's API. Returns the created HrisAttendance.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisAttendance" method="post" path="/hris/{connection_id}/attendance" example="hris_attendance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Attendance.CreateHrisAttendanceAsync(
    hrisAttendance: new HrisAttendance() {
        Address = new PropertyHrisAttendanceAddress() {
            Address1 = "14108 Allie Flats",
            City = "Kearaborough",
            CountryCode = "US",
            PostalCode = "23844-2344",
            Region = "Tennessee",
            RegionCode = "CA",
        },
        ApprovedAt = System.DateTime.Parse("2021-09-19T17:38:26.905Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-17T22:47:09.635Z").ToUniversalTime(),
                Id = "863745bc-ca0d-41d1-957f-8e510422bff2",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-11-01T23:00:43.961Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-26T23:25:52.746Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "90cf4eb7-53e4-4e02-a48a-968d45ee89e3",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-11T09:07:30.746Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-20T11:28:16.699Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisAttendance`                                                                                                                                 | [HrisAttendance](../../Models/Components/HrisAttendance.md)                                                                                      | :heavy_check_mark:                                                                                                                               | Also called timesheets                                                                                                                           |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisAttendanceQueryParamFields](../../Models/Requests/CreateHrisAttendanceQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisAttendanceResponse](../../Models/Requests/CreateHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisAttendance

Retrieves a single HrisAttendance by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisAttendance" method="get" path="/hris/{connection_id}/attendance/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Attendance.GetHrisAttendanceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Attendance                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetHrisAttendanceQueryParamFields](../../Models/Requests/GetHrisAttendanceQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisAttendanceResponse](../../Models/Requests/GetHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisAttendances

Returns a list of HrisAttendances. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisAttendances" method="get" path="/hris/{connection_id}/attendance" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisAttendancesRequest req = new ListHrisAttendancesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Attendance.ListHrisAttendancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListHrisAttendancesRequest](../../Models/Requests/ListHrisAttendancesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListHrisAttendancesResponse](../../Models/Requests/ListHrisAttendancesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisAttendance

Updates the HrisAttendance identified by `id`. Provide the unified HrisAttendance fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisAttendance" method="patch" path="/hris/{connection_id}/attendance/{id}" example="hris_attendance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisAttendanceRequest req = new PatchHrisAttendanceRequest() {
    HrisAttendance = new HrisAttendance() {
        Address = new PropertyHrisAttendanceAddress() {
            Address1 = "14108 Allie Flats",
            City = "Kearaborough",
            CountryCode = "US",
            PostalCode = "23844-2344",
            Region = "Tennessee",
            RegionCode = "CA",
        },
        ApprovedAt = System.DateTime.Parse("2021-09-19T17:38:26.905Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-17T22:47:09.647Z").ToUniversalTime(),
                Id = "93ca78a2-bb5c-429c-b3ad-aaa769aaee1b",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-11-01T23:00:43.972Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-26T23:25:52.759Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "516a08c9-fe7c-484d-95ed-607fca92446b",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-11T09:07:30.747Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-20T11:28:16.701Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Attendance.PatchHrisAttendanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchHrisAttendanceRequest](../../Models/Requests/PatchHrisAttendanceRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchHrisAttendanceResponse](../../Models/Requests/PatchHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisAttendance

Deletes the HrisAttendance identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisAttendance" method="delete" path="/hris/{connection_id}/attendance/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Attendance.RemoveHrisAttendanceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Attendance |

### Response

**[RemoveHrisAttendanceResponse](../../Models/Requests/RemoveHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisAttendance

Updates the HrisAttendance identified by `id`. Provide the unified HrisAttendance fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisAttendance" method="put" path="/hris/{connection_id}/attendance/{id}" example="hris_attendance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisAttendanceRequest req = new UpdateHrisAttendanceRequest() {
    HrisAttendance = new HrisAttendance() {
        Address = new PropertyHrisAttendanceAddress() {
            Address1 = "14108 Allie Flats",
            City = "Kearaborough",
            CountryCode = "US",
            PostalCode = "23844-2344",
            Region = "Tennessee",
            RegionCode = "CA",
        },
        ApprovedAt = System.DateTime.Parse("2021-09-19T17:38:26.905Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-17T22:47:09.647Z").ToUniversalTime(),
                Id = "93ca78a2-bb5c-429c-b3ad-aaa769aaee1b",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-11-01T23:00:43.972Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-26T23:25:52.759Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "516a08c9-fe7c-484d-95ed-607fca92446b",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-11T09:07:30.747Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-20T11:28:16.701Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Attendance.UpdateHrisAttendanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateHrisAttendanceRequest](../../Models/Requests/UpdateHrisAttendanceRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateHrisAttendanceResponse](../../Models/Requests/UpdateHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |