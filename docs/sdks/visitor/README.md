# Visitor
(*Visitor*)

## Overview

### Available Operations

* [CreateAnalyticsVisitor2](#createanalyticsvisitor2) - Create a visitor
* [GetAnalyticsVisitor2](#getanalyticsvisitor2) - Retrieve a visitor
* [ListAnalyticsVisitors2](#listanalyticsvisitors2) - List all visitors
* [PatchAnalyticsVisitor2](#patchanalyticsvisitor2) - Update a visitor
* [RemoveAnalyticsVisitor2](#removeanalyticsvisitor2) - Remove a visitor
* [UpdateAnalyticsVisitor2](#updateanalyticsvisitor2) - Update a visitor

## CreateAnalyticsVisitor2

Create a visitor

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Visitor.CreateAnalyticsVisitor2Async(
    analyticsVisitor: new AnalyticsVisitor() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AnalyticsVisitor`                                                                                                                               | [AnalyticsVisitor](../../Models/Components/AnalyticsVisitor.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAnalyticsVisitor2QueryParamFields](../../Models/Requests/CreateAnalyticsVisitor2QueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAnalyticsVisitor2Response](../../Models/Requests/CreateAnalyticsVisitor2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAnalyticsVisitor2

Retrieve a visitor

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Visitor.GetAnalyticsVisitor2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Visitor                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAnalyticsVisitor2QueryParamFields](../../Models/Requests/GetAnalyticsVisitor2QueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAnalyticsVisitor2Response](../../Models/Requests/GetAnalyticsVisitor2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAnalyticsVisitors2

List all visitors

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsVisitors2Request req = new ListAnalyticsVisitors2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Visitor.ListAnalyticsVisitors2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAnalyticsVisitors2Request](../../Models/Requests/ListAnalyticsVisitors2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAnalyticsVisitors2Response](../../Models/Requests/ListAnalyticsVisitors2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAnalyticsVisitor2

Update a visitor

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAnalyticsVisitor2Request req = new PatchAnalyticsVisitor2Request() {
    AnalyticsVisitor = new AnalyticsVisitor() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Visitor.PatchAnalyticsVisitor2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAnalyticsVisitor2Request](../../Models/Requests/PatchAnalyticsVisitor2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAnalyticsVisitor2Response](../../Models/Requests/PatchAnalyticsVisitor2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAnalyticsVisitor2

Remove a visitor

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Visitor.RemoveAnalyticsVisitor2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Visitor    |

### Response

**[RemoveAnalyticsVisitor2Response](../../Models/Requests/RemoveAnalyticsVisitor2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAnalyticsVisitor2

Update a visitor

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAnalyticsVisitor2Request req = new UpdateAnalyticsVisitor2Request() {
    AnalyticsVisitor = new AnalyticsVisitor() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Visitor.UpdateAnalyticsVisitor2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAnalyticsVisitor2Request](../../Models/Requests/UpdateAnalyticsVisitor2Request.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAnalyticsVisitor2Response](../../Models/Requests/UpdateAnalyticsVisitor2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |