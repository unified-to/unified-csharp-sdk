# Segment

## Overview

### Available Operations

* [CreateCdpSegment](#createcdpsegment) - Create a segment
* [GetCdpSegment](#getcdpsegment) - Retrieve a segment
* [ListCdpSegments](#listcdpsegments) - List all segments
* [PatchCdpSegment](#patchcdpsegment) - Update a segment
* [RemoveCdpSegment](#removecdpsegment) - Remove a segment
* [UpdateCdpSegment](#updatecdpsegment) - Update a segment

## CreateCdpSegment

Create a segment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCdpSegment" method="post" path="/cdp/{connection_id}/segment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Segment.CreateCdpSegmentAsync(
    cdpSegment: new CdpSegment() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CdpSegment`                                                                                                                                     | [CdpSegment](../../Models/Components/CdpSegment.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCdpSegmentQueryParamFields](../../Models/Requests/CreateCdpSegmentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCdpSegmentResponse](../../Models/Requests/CreateCdpSegmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCdpSegment

Retrieve a segment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCdpSegment" method="get" path="/cdp/{connection_id}/segment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Segment.GetCdpSegmentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Segment                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetCdpSegmentQueryParamFields](../../Models/Requests/GetCdpSegmentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCdpSegmentResponse](../../Models/Requests/GetCdpSegmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCdpSegments

List all segments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCdpSegments" method="get" path="/cdp/{connection_id}/segment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCdpSegmentsRequest req = new ListCdpSegmentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Segment.ListCdpSegmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListCdpSegmentsRequest](../../Models/Requests/ListCdpSegmentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListCdpSegmentsResponse](../../Models/Requests/ListCdpSegmentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCdpSegment

Update a segment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCdpSegment" method="patch" path="/cdp/{connection_id}/segment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCdpSegmentRequest req = new PatchCdpSegmentRequest() {
    CdpSegment = new CdpSegment() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Segment.PatchCdpSegmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchCdpSegmentRequest](../../Models/Requests/PatchCdpSegmentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchCdpSegmentResponse](../../Models/Requests/PatchCdpSegmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCdpSegment

Remove a segment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCdpSegment" method="delete" path="/cdp/{connection_id}/segment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Segment.RemoveCdpSegmentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Segment    |

### Response

**[RemoveCdpSegmentResponse](../../Models/Requests/RemoveCdpSegmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCdpSegment

Update a segment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCdpSegment" method="put" path="/cdp/{connection_id}/segment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCdpSegmentRequest req = new UpdateCdpSegmentRequest() {
    CdpSegment = new CdpSegment() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Segment.UpdateCdpSegmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateCdpSegmentRequest](../../Models/Requests/UpdateCdpSegmentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateCdpSegmentResponse](../../Models/Requests/UpdateCdpSegmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |