# Assessment
(*Assessment*)

## Overview

### Available Operations

* [CreateAssessmentPackage](#createassessmentpackage) - Create an assessment package
* [GetAssessmentPackage](#getassessmentpackage) - Get an assessment package
* [ListAssessmentPackages](#listassessmentpackages) - List assessment packages
* [PatchAssessmentOrder](#patchassessmentorder) - Update an order
* [PatchAssessmentPackage](#patchassessmentpackage) - Update an assessment package
* [RemoveAssessmentPackage](#removeassessmentpackage) - Delete an assessment package
* [UpdateAssessmentOrder](#updateassessmentorder) - Update an order
* [UpdateAssessmentPackage](#updateassessmentpackage) - Update an assessment package

## CreateAssessmentPackage

Create an assessment package

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Assessment.CreateAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Id = "<id>",
        Name = "<value>",
        Type = AssessmentPackageType.ReferenceCheck,
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAssessmentOrderRequest req = new PatchAssessmentOrderRequest() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Assessment.PatchAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Id = "<id>",
        Name = "<value>",
        Type = AssessmentPackageType.BackgroundCheck,
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAssessmentOrderRequest req = new UpdateAssessmentOrderRequest() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Assessment.UpdateAssessmentPackageAsync(
    assessmentPackage: new AssessmentPackage() {
        Id = "<id>",
        Name = "<value>",
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

**[UpdateAssessmentPackageResponse](../../Models/Requests/UpdateAssessmentPackageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |