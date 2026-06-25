# Deduction
(*Deduction*)

## Overview

### Available Operations

* [CreateHrisDeduction2](#createhrisdeduction2) - Create a deduction
* [GetHrisDeduction2](#gethrisdeduction2) - Retrieve a deduction
* [ListHrisDeductions2](#listhrisdeductions2) - List all deductions
* [PatchHrisDeduction2](#patchhrisdeduction2) - Update a deduction
* [RemoveHrisDeduction2](#removehrisdeduction2) - Remove a deduction
* [UpdateHrisDeduction2](#updatehrisdeduction2) - Update a deduction

## CreateHrisDeduction2

Create a deduction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deduction.CreateHrisDeduction2Async(
    hrisDeduction: new HrisDeduction() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDeduction`                                                                                                                                  | [HrisDeduction](../../Models/Components/HrisDeduction.md)                                                                                        | :heavy_check_mark:                                                                                                                               | Employee-specific deduction/benefit enrolment.                                                                                                   |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDeduction2QueryParamFields](../../Models/Requests/CreateHrisDeduction2QueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDeduction2Response](../../Models/Requests/CreateHrisDeduction2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDeduction2

Retrieve a deduction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deduction.GetHrisDeduction2Async(
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
| `Fields`                                                                                                                                         | List<[GetHrisDeduction2QueryParamFields](../../Models/Requests/GetHrisDeduction2QueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDeduction2Response](../../Models/Requests/GetHrisDeduction2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDeductions2

List all deductions

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDeductions2Request req = new ListHrisDeductions2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Deduction.ListHrisDeductions2Async(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListHrisDeductions2Request](../../Models/Requests/ListHrisDeductions2Request.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListHrisDeductions2Response](../../Models/Requests/ListHrisDeductions2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDeduction2

Update a deduction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDeduction2Request req = new PatchHrisDeduction2Request() {
    HrisDeduction = new HrisDeduction() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deduction.PatchHrisDeduction2Async(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchHrisDeduction2Request](../../Models/Requests/PatchHrisDeduction2Request.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchHrisDeduction2Response](../../Models/Requests/PatchHrisDeduction2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDeduction2

Remove a deduction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deduction.RemoveHrisDeduction2Async(
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

**[RemoveHrisDeduction2Response](../../Models/Requests/RemoveHrisDeduction2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDeduction2

Update a deduction

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDeduction2Request req = new UpdateHrisDeduction2Request() {
    HrisDeduction = new HrisDeduction() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deduction.UpdateHrisDeduction2Async(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateHrisDeduction2Request](../../Models/Requests/UpdateHrisDeduction2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateHrisDeduction2Response](../../Models/Requests/UpdateHrisDeduction2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |