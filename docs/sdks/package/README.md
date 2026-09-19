# Package

## Overview

### Available Operations

* [CreateAssessmentPackage](#createassessmentpackage) - Create an assessment package
* [GetAssessmentPackage](#getassessmentpackage) - Get an assessment package
* [GetVerificationPackage](#getverificationpackage) - Retrieve a package
* [ListAssessmentPackages](#listassessmentpackages) - List assessment packages
* [ListVerificationPackages](#listverificationpackages) - List all packages
* [PatchAssessmentPackage](#patchassessmentpackage) - Update an assessment package
* [RemoveAssessmentPackage](#removeassessmentpackage) - Delete an assessment package
* [UpdateAssessmentPackage](#updateassessmentpackage) - Update an assessment package

## CreateAssessmentPackage

Create an assessment package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAssessmentPackage" method="post" path="/assessment/{connection_id}/package" example="assessment_package" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.CreateAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Aliases = new List<string>() {
            "quia",
        },
        CreatedAt = System.DateTime.Parse("2022-11-18T19:48:39.433Z").ToUniversalTime(),
        Description = "Eos aedificium consectetur urbs. Admitto summa accusator tabesco distinctio vapulus culpo templum ancilla.",
        HasRedirectUrl = true,
        HasTargetUrl = false,
        Id = "366568ff-25a2-45b1-a4f0-e829d51e3c7f",
        InfoUrl = "https://ugly-instance.biz/",
        IntegrationTypes = new List<string>() {
            "viridis",
        },
        MaxScore = 22D,
        Name = "Carus sed vox doloremque vigor surgo tabella cupiditas abduco clarus.",
        NeedsIpAddress = true,
        Parameters = new List<AssessmentParameter>() {},
        Regions = new List<AssessmentPackageRegion>() {},
        Tags = new List<string>() {
            "clamo",
        },
        Type = AssessmentPackageType.VideoInterview,
        UpdatedAt = System.DateTime.Parse("2023-09-18T10:38:36.941Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AssessmentPackage`                                               | [AssessmentPackage](../../Models/Components/AssessmentPackage.md) | :heavy_check_mark:                                                | Used by assessment providers to SUBMIT packages to ATS systems    |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |

### Response

**[CreateAssessmentPackageResponse](../../Models/Requests/CreateAssessmentPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAssessmentPackage

Get an assessment package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAssessmentPackage" method="get" path="/assessment/{connection_id}/package/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.GetAssessmentPackageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Package    |

### Response

**[GetAssessmentPackageResponse](../../Models/Requests/GetAssessmentPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetVerificationPackage

Retrieve a package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVerificationPackage" method="get" path="/verification/{connection_id}/package/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.GetVerificationPackageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Package                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetVerificationPackageQueryParamFields](../../Models/Requests/GetVerificationPackageQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetVerificationPackageResponse](../../Models/Requests/GetVerificationPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAssessmentPackages

List assessment packages

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAssessmentPackages" method="get" path="/assessment/{connection_id}/package" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.ListAssessmentPackagesAsync(connectionId: "<id>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Limit`              | *double*             | :heavy_minus_sign:   | N/A                  |
| `Offset`             | *double*             | :heavy_minus_sign:   | N/A                  |

### Response

**[ListAssessmentPackagesResponse](../../Models/Requests/ListAssessmentPackagesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListVerificationPackages

List all packages

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listVerificationPackages" method="get" path="/verification/{connection_id}/package" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListVerificationPackagesRequest req = new ListVerificationPackagesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Package.ListVerificationPackagesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListVerificationPackagesRequest](../../Models/Requests/ListVerificationPackagesRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListVerificationPackagesResponse](../../Models/Requests/ListVerificationPackagesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAssessmentPackage

Update an assessment package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAssessmentPackage" method="patch" path="/assessment/{connection_id}/package/{id}" example="assessment_package" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.PatchAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Aliases = new List<string>() {
            "quia",
        },
        CreatedAt = System.DateTime.Parse("2022-11-18T19:48:39.433Z").ToUniversalTime(),
        Description = "Eos aedificium consectetur urbs. Admitto summa accusator tabesco distinctio vapulus culpo templum ancilla.",
        HasRedirectUrl = true,
        HasTargetUrl = false,
        Id = "3a61a674-afa1-4980-b13a-c1a2bd7648f9",
        InfoUrl = "https://ugly-instance.biz/",
        IntegrationTypes = new List<string>() {
            "viridis",
        },
        MaxScore = 22D,
        Name = "Carus sed vox doloremque vigor surgo tabella cupiditas abduco clarus.",
        NeedsIpAddress = true,
        Parameters = new List<AssessmentParameter>() {},
        Regions = new List<AssessmentPackageRegion>() {},
        Tags = new List<string>() {
            "clamo",
        },
        Type = AssessmentPackageType.VideoInterview,
        UpdatedAt = System.DateTime.Parse("2023-09-18T10:38:36.945Z").ToUniversalTime(),
    },
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AssessmentPackage`                                               | [AssessmentPackage](../../Models/Components/AssessmentPackage.md) | :heavy_check_mark:                                                | Used by assessment providers to SUBMIT packages to ATS systems    |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Package                                                 |

### Response

**[PatchAssessmentPackageResponse](../../Models/Requests/PatchAssessmentPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAssessmentPackage

Delete an assessment package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAssessmentPackage" method="delete" path="/assessment/{connection_id}/package/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.RemoveAssessmentPackageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Package    |

### Response

**[RemoveAssessmentPackageResponse](../../Models/Requests/RemoveAssessmentPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAssessmentPackage

Update an assessment package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAssessmentPackage" method="put" path="/assessment/{connection_id}/package/{id}" example="assessment_package" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.UpdateAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Aliases = new List<string>() {
            "quia",
        },
        CreatedAt = System.DateTime.Parse("2022-11-18T19:48:39.433Z").ToUniversalTime(),
        Description = "Eos aedificium consectetur urbs. Admitto summa accusator tabesco distinctio vapulus culpo templum ancilla.",
        HasRedirectUrl = true,
        HasTargetUrl = false,
        Id = "3a61a674-afa1-4980-b13a-c1a2bd7648f9",
        InfoUrl = "https://ugly-instance.biz/",
        IntegrationTypes = new List<string>() {
            "viridis",
        },
        MaxScore = 22D,
        Name = "Carus sed vox doloremque vigor surgo tabella cupiditas abduco clarus.",
        NeedsIpAddress = true,
        Parameters = new List<AssessmentParameter>() {},
        Regions = new List<AssessmentPackageRegion>() {},
        Tags = new List<string>() {
            "clamo",
        },
        Type = AssessmentPackageType.VideoInterview,
        UpdatedAt = System.DateTime.Parse("2023-09-18T10:38:36.945Z").ToUniversalTime(),
    },
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AssessmentPackage`                                               | [AssessmentPackage](../../Models/Components/AssessmentPackage.md) | :heavy_check_mark:                                                | Used by assessment providers to SUBMIT packages to ATS systems    |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Package                                                 |

### Response

**[UpdateAssessmentPackageResponse](../../Models/Requests/UpdateAssessmentPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |