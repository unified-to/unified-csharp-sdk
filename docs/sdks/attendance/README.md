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
        ApprovedAt = System.DateTime.Parse("2021-08-13T10:40:06.940Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 12D,
                EndAt = System.DateTime.Parse("2023-10-23T13:10:22.506Z").ToUniversalTime(),
                Id = "d60a1001-5a8a-4991-8c21-f4da6036cc87",
                IsPaid = true,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-16T17:26:06.449Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "UGX",
        DeclaredTipsAmount = 161D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-07T05:02:40.164Z").ToUniversalTime(),
        HourlyRate = 53D,
        Hours = 10D,
        Id = "2df223a7-8bee-49ef-bb08-506a62e8266a",
        JobName = "Global Creative Supervisor",
        NonCashTipsAmount = 54D,
        StartAt = System.DateTime.Parse("2021-11-09T12:46:48.318Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Closed,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-17T05:32:31.507Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisAttendance`                                                                                                                                 | [HrisAttendance](../../Models/Components/HrisAttendance.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
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
        ApprovedAt = System.DateTime.Parse("2021-08-13T10:40:06.940Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 12D,
                EndAt = System.DateTime.Parse("2023-10-23T13:10:22.519Z").ToUniversalTime(),
                Id = "d60a1001-5a8a-4991-8c21-f4da6036cc87",
                IsPaid = true,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-16T17:26:06.462Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "UGX",
        DeclaredTipsAmount = 161D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-07T05:02:40.180Z").ToUniversalTime(),
        HourlyRate = 53D,
        Hours = 10D,
        Id = "edeea80e-0f13-4c3c-960f-e81e0c904ef9",
        JobName = "Global Creative Supervisor",
        NonCashTipsAmount = 54D,
        StartAt = System.DateTime.Parse("2021-11-09T12:46:48.320Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Closed,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-17T05:32:31.509Z").ToUniversalTime(),
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
        ApprovedAt = System.DateTime.Parse("2021-08-13T10:40:06.940Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 12D,
                EndAt = System.DateTime.Parse("2023-10-23T13:10:22.519Z").ToUniversalTime(),
                Id = "d60a1001-5a8a-4991-8c21-f4da6036cc87",
                IsPaid = true,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-16T17:26:06.462Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "UGX",
        DeclaredTipsAmount = 161D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-07T05:02:40.180Z").ToUniversalTime(),
        HourlyRate = 53D,
        Hours = 10D,
        Id = "edeea80e-0f13-4c3c-960f-e81e0c904ef9",
        JobName = "Global Creative Supervisor",
        NonCashTipsAmount = 54D,
        StartAt = System.DateTime.Parse("2021-11-09T12:46:48.320Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Closed,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-17T05:32:31.509Z").ToUniversalTime(),
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