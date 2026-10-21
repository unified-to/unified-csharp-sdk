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

Create an attendance

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
        ApprovedAt = System.DateTime.Parse("2021-09-19T14:06:51.248Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-14T13:23:56.511Z").ToUniversalTime(),
                Id = "d165eaae-9fd5-461a-95a0-93c3cf23a66c",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-29T23:10:00.577Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-23T07:56:43.487Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "060ca073-ae6c-45a3-a0e5-e853f40bd85c",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-11T00:56:49.662Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-19T21:05:58.859Z").ToUniversalTime(),
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

Retrieve an attendance

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

List all attendances

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

Update an attendance

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
        ApprovedAt = System.DateTime.Parse("2021-09-19T14:06:51.249Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-14T13:23:56.519Z").ToUniversalTime(),
                Id = "45757800-6e4e-4c42-af1d-9aa34203f259",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-29T23:10:00.584Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-23T07:56:43.496Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "378e6e19-e1d1-4d41-954f-df34d6c0edbc",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-11T00:56:49.663Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-19T21:05:58.860Z").ToUniversalTime(),
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

Remove an attendance

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

Update an attendance

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
        ApprovedAt = System.DateTime.Parse("2021-09-19T14:06:51.249Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-14T13:23:56.519Z").ToUniversalTime(),
                Id = "45757800-6e4e-4c42-af1d-9aa34203f259",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-29T23:10:00.584Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-23T07:56:43.496Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "378e6e19-e1d1-4d41-954f-df34d6c0edbc",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-11T00:56:49.663Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-19T21:05:58.860Z").ToUniversalTime(),
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