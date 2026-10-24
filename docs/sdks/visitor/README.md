# Visitor

## Overview

### Available Operations

* [CreateAnalyticsVisitor](#createanalyticsvisitor) - Create a visitor
* [GetAnalyticsVisitor](#getanalyticsvisitor) - Retrieve a visitor
* [ListAnalyticsVisitors](#listanalyticsvisitors) - List all visitors
* [PatchAnalyticsVisitor](#patchanalyticsvisitor) - Update a visitor
* [RemoveAnalyticsVisitor](#removeanalyticsvisitor) - Remove a visitor
* [UpdateAnalyticsVisitor](#updateanalyticsvisitor) - Update a visitor

## CreateAnalyticsVisitor

Creates a AnalyticsVisitor. Provide the unified AnalyticsVisitor fields in the request body; they are mapped to the provider's API. Returns the created AnalyticsVisitor.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAnalyticsVisitor" method="post" path="/analytics/{connection_id}/visitor" example="analytics_visitor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Visitor.CreateAnalyticsVisitorAsync(
    analyticsVisitor: new AnalyticsVisitor() {
        CreatedAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Email = "desiree.o.hara@icloud.com",
        FirstSeenAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Id = "6f7c281d-2ac2-4d81-a693-0bed13f7b228",
        LastSeenAt = System.DateTime.Parse("2025-01-13T09:18:46.599Z").ToUniversalTime(),
        Metadata = new Dictionary<string, PropertyAnalyticsVisitorMetadata>() {
            { "segment", new PropertyAnalyticsVisitorMetadata() {} },
        },
        TotalEvents = 2916D,
        UpdatedAt = System.DateTime.Parse("2025-07-01T23:54:09.089Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AnalyticsVisitor`                                                                                                                               | [AnalyticsVisitor](../../Models/Components/AnalyticsVisitor.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAnalyticsVisitorQueryParamFields](../../Models/Requests/CreateAnalyticsVisitorQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAnalyticsVisitorResponse](../../Models/Requests/CreateAnalyticsVisitorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAnalyticsVisitor

Retrieves a single AnalyticsVisitor by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAnalyticsVisitor" method="get" path="/analytics/{connection_id}/visitor/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Visitor.GetAnalyticsVisitorAsync(
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
| `Fields`                                                                                                                                         | List<[GetAnalyticsVisitorQueryParamFields](../../Models/Requests/GetAnalyticsVisitorQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAnalyticsVisitorResponse](../../Models/Requests/GetAnalyticsVisitorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAnalyticsVisitors

Returns a list of AnalyticsVisitors. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAnalyticsVisitors" method="get" path="/analytics/{connection_id}/visitor" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsVisitorsRequest req = new ListAnalyticsVisitorsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Visitor.ListAnalyticsVisitorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListAnalyticsVisitorsRequest](../../Models/Requests/ListAnalyticsVisitorsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListAnalyticsVisitorsResponse](../../Models/Requests/ListAnalyticsVisitorsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAnalyticsVisitor

Updates the AnalyticsVisitor identified by `id`. Provide the unified AnalyticsVisitor fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAnalyticsVisitor" method="patch" path="/analytics/{connection_id}/visitor/{id}" example="analytics_visitor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAnalyticsVisitorRequest req = new PatchAnalyticsVisitorRequest() {
    AnalyticsVisitor = new AnalyticsVisitor() {
        CreatedAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Email = "desiree.o.hara@icloud.com",
        FirstSeenAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Id = "97978b73-6347-4996-bdc2-4da9bd6a6235",
        LastSeenAt = System.DateTime.Parse("2025-01-13T09:18:46.621Z").ToUniversalTime(),
        Metadata = new Dictionary<string, PropertyAnalyticsVisitorMetadata>() {
            { "segment", new PropertyAnalyticsVisitorMetadata() {} },
        },
        TotalEvents = 2916D,
        UpdatedAt = System.DateTime.Parse("2025-07-01T23:54:09.113Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Visitor.PatchAnalyticsVisitorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchAnalyticsVisitorRequest](../../Models/Requests/PatchAnalyticsVisitorRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchAnalyticsVisitorResponse](../../Models/Requests/PatchAnalyticsVisitorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAnalyticsVisitor

Deletes the AnalyticsVisitor identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAnalyticsVisitor" method="delete" path="/analytics/{connection_id}/visitor/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Visitor.RemoveAnalyticsVisitorAsync(
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

**[RemoveAnalyticsVisitorResponse](../../Models/Requests/RemoveAnalyticsVisitorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAnalyticsVisitor

Updates the AnalyticsVisitor identified by `id`. Provide the unified AnalyticsVisitor fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAnalyticsVisitor" method="put" path="/analytics/{connection_id}/visitor/{id}" example="analytics_visitor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAnalyticsVisitorRequest req = new UpdateAnalyticsVisitorRequest() {
    AnalyticsVisitor = new AnalyticsVisitor() {
        CreatedAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Email = "desiree.o.hara@icloud.com",
        FirstSeenAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Id = "97978b73-6347-4996-bdc2-4da9bd6a6235",
        LastSeenAt = System.DateTime.Parse("2025-01-13T09:18:46.621Z").ToUniversalTime(),
        Metadata = new Dictionary<string, PropertyAnalyticsVisitorMetadata>() {
            { "segment", new PropertyAnalyticsVisitorMetadata() {} },
        },
        TotalEvents = 2916D,
        UpdatedAt = System.DateTime.Parse("2025-07-01T23:54:09.113Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Visitor.UpdateAnalyticsVisitorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateAnalyticsVisitorRequest](../../Models/Requests/UpdateAnalyticsVisitorRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateAnalyticsVisitorResponse](../../Models/Requests/UpdateAnalyticsVisitorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |