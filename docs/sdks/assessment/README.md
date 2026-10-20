# Assessment

## Overview

### Available Operations

* [CreateAssessmentOrder](#createassessmentorder) - Create an order
* [CreateAssessmentPackage](#createassessmentpackage) - Create an assessment package
* [GetAssessmentOrder](#getassessmentorder) - Retrieve an order
* [GetAssessmentPackage](#getassessmentpackage) - Get an assessment package
* [ListAssessmentPackages](#listassessmentpackages) - List assessment packages
* [PatchAssessmentOrder](#patchassessmentorder) - Update an order
* [PatchAssessmentPackage](#patchassessmentpackage) - Update an assessment package
* [RemoveAssessmentPackage](#removeassessmentpackage) - Delete an assessment package
* [UpdateAssessmentOrder](#updateassessmentorder) - Update an order
* [UpdateAssessmentPackage](#updateassessmentpackage) - Update an assessment package

## CreateAssessmentOrder

Create an order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAssessmentOrder" method="post" path="/assessment/{connection_id}/order" example="assessment_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Assessment.CreateAssessmentOrderAsync(
    assessmentOrder: new AssessmentOrder() {
        ConnectionId = "<id>",
        CreatedAt = System.DateTime.Parse("2021-09-18T10:33:57.803Z").ToUniversalTime(),
        Id = "1d98db36-0946-4f39-a3db-7174eb800083",
        Metadata = new List<AssessmentMetadata>() {},
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "amy.kris.windler@icloud.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(341) 425-5828",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 84D,
        ResponseScore = 82D,
        ResponseStatus = ResponseStatus.Rejected,
        ResponseUrl = "https://rowdy-fisherman.biz/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-25T12:51:33.789Z").ToUniversalTime(),
        WorkspaceId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AssessmentOrder`                                                                                                                                | [AssessmentOrder](../../Models/Components/AssessmentOrder.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAssessmentOrderQueryParamFields](../../Models/Requests/CreateAssessmentOrderQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAssessmentOrderResponse](../../Models/Requests/CreateAssessmentOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Assessment.CreateAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Aliases = new List<string>() {
            "quia",
        },
        CreatedAt = System.DateTime.Parse("2022-11-18T19:48:39.433Z").ToUniversalTime(),
        Description = "Eos aedificium consectetur urbs. Admitto summa accusator tabesco distinctio vapulus culpo templum ancilla.",
        HasRedirectUrl = true,
        HasTargetUrl = false,
        Id = "690a0b63-7fc3-43f3-bed5-a4c10cbe80f7",
        InfoUrl = "https://ugly-instance.biz/",
        IntegrationTypes = new List<string>() {
            "viridis",
        },
        MaxScore = 22D,
        Metadata = new List<AssessmentMetadata>() {},
        Name = "Carus sed vox doloremque vigor surgo tabella cupiditas abduco clarus.",
        NeedsIpAddress = true,
        Parameters = new List<AssessmentParameter>() {},
        Regions = new List<AssessmentPackageRegion>() {},
        Tags = new List<string>() {
            "clamo",
        },
        Type = AssessmentPackageType.VideoInterview,
        UpdatedAt = System.DateTime.Parse("2023-09-25T02:56:59.220Z").ToUniversalTime(),
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

## GetAssessmentOrder

Retrieve an order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAssessmentOrder" method="get" path="/assessment/{connection_id}/order/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Assessment.GetAssessmentOrderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Order                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAssessmentOrderQueryParamFields](../../Models/Requests/GetAssessmentOrderQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAssessmentOrderResponse](../../Models/Requests/GetAssessmentOrderResponse.md)**

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

var res = await sdk.Assessment.GetAssessmentPackageAsync(
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

var res = await sdk.Assessment.ListAssessmentPackagesAsync(connectionId: "<id>");

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

## PatchAssessmentOrder

Update an order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAssessmentOrder" method="patch" path="/assessment/{connection_id}/order/{id}" example="assessment_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAssessmentOrderRequest req = new PatchAssessmentOrderRequest() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
        CreatedAt = System.DateTime.Parse("2021-09-18T10:33:57.803Z").ToUniversalTime(),
        Id = "f6c17b8b-db22-4749-bbbb-21540b95de57",
        Metadata = new List<AssessmentMetadata>() {},
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "amy.kris.windler@icloud.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(341) 425-5828",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 84D,
        ResponseScore = 82D,
        ResponseStatus = ResponseStatus.Rejected,
        ResponseUrl = "https://rowdy-fisherman.biz/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-25T12:51:33.799Z").ToUniversalTime(),
        WorkspaceId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Assessment.PatchAssessmentOrderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchAssessmentOrderRequest](../../Models/Requests/PatchAssessmentOrderRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchAssessmentOrderResponse](../../Models/Requests/PatchAssessmentOrderResponse.md)**

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

var res = await sdk.Assessment.PatchAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Aliases = new List<string>() {
            "quia",
        },
        CreatedAt = System.DateTime.Parse("2022-11-18T19:48:39.433Z").ToUniversalTime(),
        Description = "Eos aedificium consectetur urbs. Admitto summa accusator tabesco distinctio vapulus culpo templum ancilla.",
        HasRedirectUrl = true,
        HasTargetUrl = false,
        Id = "2406db35-df10-49d3-8ee6-8cdd7371d32c",
        InfoUrl = "https://ugly-instance.biz/",
        IntegrationTypes = new List<string>() {
            "viridis",
        },
        MaxScore = 22D,
        Metadata = new List<AssessmentMetadata>() {},
        Name = "Carus sed vox doloremque vigor surgo tabella cupiditas abduco clarus.",
        NeedsIpAddress = true,
        Parameters = new List<AssessmentParameter>() {},
        Regions = new List<AssessmentPackageRegion>() {},
        Tags = new List<string>() {
            "clamo",
        },
        Type = AssessmentPackageType.VideoInterview,
        UpdatedAt = System.DateTime.Parse("2023-09-25T02:56:59.225Z").ToUniversalTime(),
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

var res = await sdk.Assessment.RemoveAssessmentPackageAsync(
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

## UpdateAssessmentOrder

Update an order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAssessmentOrder" method="put" path="/assessment/{connection_id}/order/{id}" example="assessment_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAssessmentOrderRequest req = new UpdateAssessmentOrderRequest() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
        CreatedAt = System.DateTime.Parse("2021-09-18T10:33:57.803Z").ToUniversalTime(),
        Id = "f6c17b8b-db22-4749-bbbb-21540b95de57",
        Metadata = new List<AssessmentMetadata>() {},
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "amy.kris.windler@icloud.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(341) 425-5828",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 84D,
        ResponseScore = 82D,
        ResponseStatus = ResponseStatus.Rejected,
        ResponseUrl = "https://rowdy-fisherman.biz/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-25T12:51:33.799Z").ToUniversalTime(),
        WorkspaceId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Assessment.UpdateAssessmentOrderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateAssessmentOrderRequest](../../Models/Requests/UpdateAssessmentOrderRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateAssessmentOrderResponse](../../Models/Requests/UpdateAssessmentOrderResponse.md)**

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

var res = await sdk.Assessment.UpdateAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Aliases = new List<string>() {
            "quia",
        },
        CreatedAt = System.DateTime.Parse("2022-11-18T19:48:39.433Z").ToUniversalTime(),
        Description = "Eos aedificium consectetur urbs. Admitto summa accusator tabesco distinctio vapulus culpo templum ancilla.",
        HasRedirectUrl = true,
        HasTargetUrl = false,
        Id = "2406db35-df10-49d3-8ee6-8cdd7371d32c",
        InfoUrl = "https://ugly-instance.biz/",
        IntegrationTypes = new List<string>() {
            "viridis",
        },
        MaxScore = 22D,
        Metadata = new List<AssessmentMetadata>() {},
        Name = "Carus sed vox doloremque vigor surgo tabella cupiditas abduco clarus.",
        NeedsIpAddress = true,
        Parameters = new List<AssessmentParameter>() {},
        Regions = new List<AssessmentPackageRegion>() {},
        Tags = new List<string>() {
            "clamo",
        },
        Type = AssessmentPackageType.VideoInterview,
        UpdatedAt = System.DateTime.Parse("2023-09-25T02:56:59.225Z").ToUniversalTime(),
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