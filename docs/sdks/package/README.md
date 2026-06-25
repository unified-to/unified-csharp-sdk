# Package
(*Package*)

## Overview

### Available Operations

* [CreateAssessmentPackage2](#createassessmentpackage2) - Create an assessment package
* [GetAssessmentPackage2](#getassessmentpackage2) - Get an assessment package
* [GetVerificationPackage2](#getverificationpackage2) - Retrieve a package
* [ListAssessmentPackages2](#listassessmentpackages2) - List assessment packages
* [ListVerificationPackages2](#listverificationpackages2) - List all packages
* [PatchAssessmentPackage2](#patchassessmentpackage2) - Update an assessment package
* [RemoveAssessmentPackage2](#removeassessmentpackage2) - Delete an assessment package
* [UpdateAssessmentPackage2](#updateassessmentpackage2) - Update an assessment package

## CreateAssessmentPackage2

Create an assessment package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.CreateAssessmentPackage2Async(
    assessmentPackage: new AssessmentPackage() {
        Type = AssessmentPackageType.VideoInterview,
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

**[CreateAssessmentPackage2Response](../../Models/Requests/CreateAssessmentPackage2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAssessmentPackage2

Get an assessment package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.GetAssessmentPackage2Async(
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

**[GetAssessmentPackage2Response](../../Models/Requests/GetAssessmentPackage2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetVerificationPackage2

Retrieve a package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.GetVerificationPackage2Async(
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
| `Fields`                                                                                                                                         | List<[GetVerificationPackage2QueryParamFields](../../Models/Requests/GetVerificationPackage2QueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetVerificationPackage2Response](../../Models/Requests/GetVerificationPackage2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAssessmentPackages2

List assessment packages

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.ListAssessmentPackages2Async(connectionId: "<id>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Limit`              | *double*             | :heavy_minus_sign:   | N/A                  |
| `Offset`             | *double*             | :heavy_minus_sign:   | N/A                  |

### Response

**[ListAssessmentPackages2Response](../../Models/Requests/ListAssessmentPackages2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListVerificationPackages2

List all packages

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListVerificationPackages2Request req = new ListVerificationPackages2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Package.ListVerificationPackages2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListVerificationPackages2Request](../../Models/Requests/ListVerificationPackages2Request.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ListVerificationPackages2Response](../../Models/Requests/ListVerificationPackages2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAssessmentPackage2

Update an assessment package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.PatchAssessmentPackage2Async(
    assessmentPackage: new AssessmentPackage() {
        Type = AssessmentPackageType.Other,
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

**[PatchAssessmentPackage2Response](../../Models/Requests/PatchAssessmentPackage2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAssessmentPackage2

Delete an assessment package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.RemoveAssessmentPackage2Async(
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

**[RemoveAssessmentPackage2Response](../../Models/Requests/RemoveAssessmentPackage2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAssessmentPackage2

Update an assessment package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Package.UpdateAssessmentPackage2Async(
    assessmentPackage: new AssessmentPackage() {
        Type = AssessmentPackageType.Other,
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

**[UpdateAssessmentPackage2Response](../../Models/Requests/UpdateAssessmentPackage2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |