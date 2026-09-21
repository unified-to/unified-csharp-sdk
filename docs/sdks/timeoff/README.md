# Timeoff

## Overview

### Available Operations

* [CreateHrisTimeoff](#createhristimeoff) - Create a timeoff
* [GetHrisTimeoff](#gethristimeoff) - Retrieve a timeoff
* [ListHrisTimeoffs](#listhristimeoffs) - List all timeoffs
* [PatchHrisTimeoff](#patchhristimeoff) - Update a timeoff
* [RemoveHrisTimeoff](#removehristimeoff) - Remove a timeoff
* [UpdateHrisTimeoff](#updatehristimeoff) - Update a timeoff

## CreateHrisTimeoff

Create a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisTimeoff" method="post" path="/hris/{connection_id}/timeoff" example="hris_timeoff" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeoff.CreateHrisTimeoffAsync(
    hrisTimeoff: new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-21T02:08:20.330Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-09T08:52:11.281Z").ToUniversalTime(),
        Id = "3766cf5c-9dcb-4419-9212-a74a979cf1ee",
        IsPaid = true,
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-08-24T08:25:05.389Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-08T05:45:54.437Z").ToUniversalTime(),
        UserId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTimeoff`                                                                                                                                    | [HrisTimeoff](../../Models/Components/HrisTimeoff.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTimeoffQueryParamFields](../../Models/Requests/CreateHrisTimeoffQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTimeoffResponse](../../Models/Requests/CreateHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTimeoff

Retrieve a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisTimeoff" method="get" path="/hris/{connection_id}/timeoff/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeoff.GetHrisTimeoffAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Timeoff                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisTimeoffQueryParamFields](../../Models/Requests/GetHrisTimeoffQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTimeoffResponse](../../Models/Requests/GetHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTimeoffs

List all timeoffs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisTimeoffs" method="get" path="/hris/{connection_id}/timeoff" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTimeoffsRequest req = new ListHrisTimeoffsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Timeoff.ListHrisTimeoffsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisTimeoffsRequest](../../Models/Requests/ListHrisTimeoffsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisTimeoffsResponse](../../Models/Requests/ListHrisTimeoffsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisTimeoff

Update a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisTimeoff" method="patch" path="/hris/{connection_id}/timeoff/{id}" example="hris_timeoff" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisTimeoffRequest req = new PatchHrisTimeoffRequest() {
    HrisTimeoff = new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-21T02:08:20.331Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-09T08:52:11.290Z").ToUniversalTime(),
        Id = "1b90647f-5bb3-4551-b5f1-77cbcbbc655e",
        IsPaid = true,
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-08-24T08:25:05.395Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-08T05:45:54.439Z").ToUniversalTime(),
        UserId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeoff.PatchHrisTimeoffAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisTimeoffRequest](../../Models/Requests/PatchHrisTimeoffRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisTimeoffResponse](../../Models/Requests/PatchHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisTimeoff

Remove a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisTimeoff" method="delete" path="/hris/{connection_id}/timeoff/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeoff.RemoveHrisTimeoffAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Timeoff    |

### Response

**[RemoveHrisTimeoffResponse](../../Models/Requests/RemoveHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisTimeoff

Update a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisTimeoff" method="put" path="/hris/{connection_id}/timeoff/{id}" example="hris_timeoff" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisTimeoffRequest req = new UpdateHrisTimeoffRequest() {
    HrisTimeoff = new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-21T02:08:20.331Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-09T08:52:11.290Z").ToUniversalTime(),
        Id = "1b90647f-5bb3-4551-b5f1-77cbcbbc655e",
        IsPaid = true,
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-08-24T08:25:05.395Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-08T05:45:54.439Z").ToUniversalTime(),
        UserId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeoff.UpdateHrisTimeoffAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisTimeoffRequest](../../Models/Requests/UpdateHrisTimeoffRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisTimeoffResponse](../../Models/Requests/UpdateHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |