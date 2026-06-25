# Assessment
(*Assessment*)

## Overview

### Available Operations

* [CreateAssessmentPackage2](#createassessmentpackage2) - Create an assessment package
* [GetAssessmentPackage2](#getassessmentpackage2) - Get an assessment package
* [ListAssessmentPackages2](#listassessmentpackages2) - List assessment packages
* [PatchAssessmentOrder2](#patchassessmentorder2) - Update an order
* [PatchAssessmentPackage2](#patchassessmentpackage2) - Update an assessment package
* [RemoveAssessmentPackage2](#removeassessmentpackage2) - Delete an assessment package
* [UpdateAssessmentOrder2](#updateassessmentorder2) - Update an order
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

var res = await sdk.Assessment.CreateAssessmentPackage2Async(
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

var res = await sdk.Assessment.GetAssessmentPackage2Async(
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

## ListAssessmentPackages2

List assessment packages

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Assessment.ListAssessmentPackages2Async(connectionId: "<id>");

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

## PatchAssessmentOrder2

Update an order

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAssessmentOrder2Request req = new PatchAssessmentOrder2Request() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
        WorkspaceId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Assessment.PatchAssessmentOrder2Async(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchAssessmentOrder2Request](../../Models/Requests/PatchAssessmentOrder2Request.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchAssessmentOrder2Response](../../Models/Requests/PatchAssessmentOrder2Response.md)**

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

var res = await sdk.Assessment.PatchAssessmentPackage2Async(
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

var res = await sdk.Assessment.RemoveAssessmentPackage2Async(
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

## UpdateAssessmentOrder2

Update an order

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAssessmentOrder2Request req = new UpdateAssessmentOrder2Request() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
        WorkspaceId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Assessment.UpdateAssessmentOrder2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateAssessmentOrder2Request](../../Models/Requests/UpdateAssessmentOrder2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateAssessmentOrder2Response](../../Models/Requests/UpdateAssessmentOrder2Response.md)**

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

var res = await sdk.Assessment.UpdateAssessmentPackage2Async(
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