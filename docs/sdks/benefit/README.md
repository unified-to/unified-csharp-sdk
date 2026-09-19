# Benefit

## Overview

### Available Operations

* [CreateHrisBenefit](#createhrisbenefit) - Create a benefit
* [GetHrisBenefit](#gethrisbenefit) - Retrieve a benefit
* [ListHrisBenefits](#listhrisbenefits) - List all benefits
* [PatchHrisBenefit](#patchhrisbenefit) - Update a benefit
* [RemoveHrisBenefit](#removehrisbenefit) - Remove a benefit
* [UpdateHrisBenefit](#updatehrisbenefit) - Update a benefit

## CreateHrisBenefit

Create a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisBenefit" method="post" path="/hris/{connection_id}/benefit" example="hris_benefit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Benefit.CreateHrisBenefitAsync(
    hrisBenefit: new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "JOD",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Hour,
        Id = "116b3278-2af3-4e73-b62c-7d0f4fd62287",
        IsActive = false,
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Garnishment,
        UpdatedAt = System.DateTime.Parse("2023-03-06T21:22:57.403Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisBenefit`                                                                                                                                    | [HrisBenefit](../../Models/Components/HrisBenefit.md)                                                                                            | :heavy_check_mark:                                                                                                                               | Company-wide benefit plans available to employees.                                                                                               |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisBenefitQueryParamFields](../../Models/Requests/CreateHrisBenefitQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisBenefitResponse](../../Models/Requests/CreateHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisBenefit

Retrieve a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisBenefit" method="get" path="/hris/{connection_id}/benefit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Benefit.GetHrisBenefitAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Benefit                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisBenefitQueryParamFields](../../Models/Requests/GetHrisBenefitQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisBenefitResponse](../../Models/Requests/GetHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisBenefits

List all benefits

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisBenefits" method="get" path="/hris/{connection_id}/benefit" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisBenefitsRequest req = new ListHrisBenefitsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Benefit.ListHrisBenefitsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisBenefitsRequest](../../Models/Requests/ListHrisBenefitsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisBenefitsResponse](../../Models/Requests/ListHrisBenefitsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisBenefit

Update a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisBenefit" method="patch" path="/hris/{connection_id}/benefit/{id}" example="hris_benefit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisBenefitRequest req = new PatchHrisBenefitRequest() {
    HrisBenefit = new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "JOD",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Hour,
        Id = "3f6bf9c5-bc22-4425-a8e5-42d8c5bbf3b1",
        IsActive = false,
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Garnishment,
        UpdatedAt = System.DateTime.Parse("2023-03-06T21:22:57.408Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Benefit.PatchHrisBenefitAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisBenefitRequest](../../Models/Requests/PatchHrisBenefitRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisBenefitResponse](../../Models/Requests/PatchHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisBenefit

Remove a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisBenefit" method="delete" path="/hris/{connection_id}/benefit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Benefit.RemoveHrisBenefitAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Benefit    |

### Response

**[RemoveHrisBenefitResponse](../../Models/Requests/RemoveHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisBenefit

Update a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisBenefit" method="put" path="/hris/{connection_id}/benefit/{id}" example="hris_benefit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisBenefitRequest req = new UpdateHrisBenefitRequest() {
    HrisBenefit = new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "JOD",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Hour,
        Id = "3f6bf9c5-bc22-4425-a8e5-42d8c5bbf3b1",
        IsActive = false,
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Garnishment,
        UpdatedAt = System.DateTime.Parse("2023-03-06T21:22:57.408Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Benefit.UpdateHrisBenefitAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisBenefitRequest](../../Models/Requests/UpdateHrisBenefitRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisBenefitResponse](../../Models/Requests/UpdateHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |