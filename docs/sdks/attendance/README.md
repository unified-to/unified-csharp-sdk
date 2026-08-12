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

<!-- UsageSnippet language="csharp" operationID="createHrisAttendance" method="post" path="/hris/{connection_id}/attendance" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Attendance.CreateHrisAttendanceAsync(
    hrisAttendance: new HrisAttendance() {
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-07-01T14:10:09.942Z").ToUniversalTime(),
        StartAt = System.DateTime.Parse("2026-03-31T03:51:43.280Z").ToUniversalTime(),
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

<!-- UsageSnippet language="csharp" operationID="patchHrisAttendance" method="patch" path="/hris/{connection_id}/attendance/{id}" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisAttendanceRequest req = new PatchHrisAttendanceRequest() {
    HrisAttendance = new HrisAttendance() {
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-09-28T22:23:28.906Z").ToUniversalTime(),
        StartAt = System.DateTime.Parse("2025-01-18T09:17:09.936Z").ToUniversalTime(),
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

<!-- UsageSnippet language="csharp" operationID="updateHrisAttendance" method="put" path="/hris/{connection_id}/attendance/{id}" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisAttendanceRequest req = new UpdateHrisAttendanceRequest() {
    HrisAttendance = new HrisAttendance() {
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-07-06T19:51:15.352Z").ToUniversalTime(),
        StartAt = System.DateTime.Parse("2024-05-22T08:12:53.996Z").ToUniversalTime(),
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