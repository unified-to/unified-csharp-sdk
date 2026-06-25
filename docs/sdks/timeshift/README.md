# Timeshift
(*Timeshift*)

## Overview

### Available Operations

* [CreateHrisTimeshift2](#createhristimeshift2) - Create a timeshift
* [GetHrisTimeshift2](#gethristimeshift2) - Retrieve a timeshift
* [ListHrisTimeshifts2](#listhristimeshifts2) - List all timeshifts
* [PatchHrisTimeshift2](#patchhristimeshift2) - Update a timeshift
* [RemoveHrisTimeshift2](#removehristimeshift2) - Remove a timeshift
* [UpdateHrisTimeshift2](#updatehristimeshift2) - Update a timeshift

## CreateHrisTimeshift2

Create a timeshift

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeshift.CreateHrisTimeshift2Async(
    hrisTimeshift: new HrisTimeshift() {
        EmployeeUserId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTimeshift`                                                                                                                                  | [HrisTimeshift](../../Models/Components/HrisTimeshift.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTimeshift2QueryParamFields](../../Models/Requests/CreateHrisTimeshift2QueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTimeshift2Response](../../Models/Requests/CreateHrisTimeshift2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTimeshift2

Retrieve a timeshift

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeshift.GetHrisTimeshift2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Timeshift                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHrisTimeshift2QueryParamFields](../../Models/Requests/GetHrisTimeshift2QueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTimeshift2Response](../../Models/Requests/GetHrisTimeshift2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTimeshifts2

List all timeshifts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTimeshifts2Request req = new ListHrisTimeshifts2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Timeshift.ListHrisTimeshifts2Async(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListHrisTimeshifts2Request](../../Models/Requests/ListHrisTimeshifts2Request.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListHrisTimeshifts2Response](../../Models/Requests/ListHrisTimeshifts2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisTimeshift2

Update a timeshift

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisTimeshift2Request req = new PatchHrisTimeshift2Request() {
    HrisTimeshift = new HrisTimeshift() {
        EmployeeUserId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeshift.PatchHrisTimeshift2Async(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchHrisTimeshift2Request](../../Models/Requests/PatchHrisTimeshift2Request.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchHrisTimeshift2Response](../../Models/Requests/PatchHrisTimeshift2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisTimeshift2

Remove a timeshift

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Timeshift.RemoveHrisTimeshift2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Timeshift  |

### Response

**[RemoveHrisTimeshift2Response](../../Models/Requests/RemoveHrisTimeshift2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisTimeshift2

Update a timeshift

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisTimeshift2Request req = new UpdateHrisTimeshift2Request() {
    HrisTimeshift = new HrisTimeshift() {
        EmployeeUserId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeshift.UpdateHrisTimeshift2Async(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateHrisTimeshift2Request](../../Models/Requests/UpdateHrisTimeshift2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateHrisTimeshift2Response](../../Models/Requests/UpdateHrisTimeshift2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |