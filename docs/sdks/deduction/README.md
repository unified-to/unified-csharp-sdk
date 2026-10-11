# Deduction

## Overview

### Available Operations

* [CreateHrisDeduction](#createhrisdeduction) - Create a deduction
* [GetHrisDeduction](#gethrisdeduction) - Retrieve a deduction
* [ListHrisDeductions](#listhrisdeductions) - List all deductions
* [PatchHrisDeduction](#patchhrisdeduction) - Update a deduction
* [RemoveHrisDeduction](#removehrisdeduction) - Remove a deduction
* [UpdateHrisDeduction](#updatehrisdeduction) - Update a deduction

## CreateHrisDeduction

Create a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisDeduction" method="post" path="/hris/{connection_id}/deduction" example="hris_deduction" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deduction.CreateHrisDeductionAsync(
    hrisDeduction: new HrisDeduction() {
        Amount = 139655D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeOnly,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EmployerAmount = 22611D,
        EmployerType = EmployerType.Fixed,
        EndAt = System.DateTime.Parse("2026-06-13T20:05:36.854Z").ToUniversalTime(),
        Frequency = HrisDeductionFrequency.Biweekly,
        GarnishmentType = GarnishmentType.Other,
        Id = "fac4b834-71a1-4778-83f4-0eb27f981968",
        IsActive = false,
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-03-07T17:02:44.736Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-16T03:24:52.301Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDeduction`                                                                                                                                  | [HrisDeduction](../../Models/Components/HrisDeduction.md)                                                                                        | :heavy_check_mark:                                                                                                                               | Employee-specific deduction/benefit enrolment.                                                                                                   |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDeductionQueryParamFields](../../Models/Requests/CreateHrisDeductionQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDeductionResponse](../../Models/Requests/CreateHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDeduction

Retrieve a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisDeduction" method="get" path="/hris/{connection_id}/deduction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deduction.GetHrisDeductionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Deduction                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHrisDeductionQueryParamFields](../../Models/Requests/GetHrisDeductionQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDeductionResponse](../../Models/Requests/GetHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDeductions

List all deductions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisDeductions" method="get" path="/hris/{connection_id}/deduction" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDeductionsRequest req = new ListHrisDeductionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Deduction.ListHrisDeductionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListHrisDeductionsRequest](../../Models/Requests/ListHrisDeductionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListHrisDeductionsResponse](../../Models/Requests/ListHrisDeductionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDeduction

Update a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisDeduction" method="patch" path="/hris/{connection_id}/deduction/{id}" example="hris_deduction" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDeductionRequest req = new PatchHrisDeductionRequest() {
    HrisDeduction = new HrisDeduction() {
        Amount = 139655D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeOnly,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EmployerAmount = 22611D,
        EmployerType = EmployerType.Fixed,
        EndAt = System.DateTime.Parse("2026-06-13T20:05:36.869Z").ToUniversalTime(),
        Frequency = HrisDeductionFrequency.Biweekly,
        GarnishmentType = GarnishmentType.Other,
        Id = "6598ef77-e61d-41d8-aba3-8868627cf0e6",
        IsActive = false,
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-03-07T17:02:44.747Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-16T03:24:52.310Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deduction.PatchHrisDeductionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchHrisDeductionRequest](../../Models/Requests/PatchHrisDeductionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchHrisDeductionResponse](../../Models/Requests/PatchHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDeduction

Remove a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisDeduction" method="delete" path="/hris/{connection_id}/deduction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deduction.RemoveHrisDeductionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deduction  |

### Response

**[RemoveHrisDeductionResponse](../../Models/Requests/RemoveHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDeduction

Update a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisDeduction" method="put" path="/hris/{connection_id}/deduction/{id}" example="hris_deduction" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDeductionRequest req = new UpdateHrisDeductionRequest() {
    HrisDeduction = new HrisDeduction() {
        Amount = 139655D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeOnly,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EmployerAmount = 22611D,
        EmployerType = EmployerType.Fixed,
        EndAt = System.DateTime.Parse("2026-06-13T20:05:36.869Z").ToUniversalTime(),
        Frequency = HrisDeductionFrequency.Biweekly,
        GarnishmentType = GarnishmentType.Other,
        Id = "6598ef77-e61d-41d8-aba3-8868627cf0e6",
        IsActive = false,
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-03-07T17:02:44.747Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-16T03:24:52.310Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deduction.UpdateHrisDeductionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateHrisDeductionRequest](../../Models/Requests/UpdateHrisDeductionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateHrisDeductionResponse](../../Models/Requests/UpdateHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |