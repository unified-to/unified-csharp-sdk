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

Create a visitor

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
        Email = "Dallas_Mitchell@yahoo.com",
        FirstSeenAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Id = "3f6fe351-3c38-46ba-977f-5e4e8beabafd",
        LastSeenAt = System.DateTime.Parse("2021-12-05T00:12:37.260Z").ToUniversalTime(),
        Metadata = new Dictionary<string, PropertyAnalyticsVisitorMetadata>() {
            { "segment", new PropertyAnalyticsVisitorMetadata() {} },
        },
        Name = "Desiree O'Hara",
        TotalEvents = 3639D,
        UpdatedAt = System.DateTime.Parse("2025-06-04T03:28:37.512Z").ToUniversalTime(),
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

Retrieve a visitor

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

List all visitors

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

Update a visitor

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
        Email = "Dallas_Mitchell@yahoo.com",
        FirstSeenAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Id = "d4c0c890-c262-4e4f-ace0-724ecfed2179",
        LastSeenAt = System.DateTime.Parse("2021-12-05T00:12:37.262Z").ToUniversalTime(),
        Metadata = new Dictionary<string, PropertyAnalyticsVisitorMetadata>() {
            { "segment", new PropertyAnalyticsVisitorMetadata() {} },
        },
        Name = "Desiree O'Hara",
        TotalEvents = 3639D,
        UpdatedAt = System.DateTime.Parse("2025-06-04T03:28:37.519Z").ToUniversalTime(),
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

Remove a visitor

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

Update a visitor

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
        Email = "Dallas_Mitchell@yahoo.com",
        FirstSeenAt = System.DateTime.Parse("2020-04-16T20:29:48.281Z").ToUniversalTime(),
        Id = "d4c0c890-c262-4e4f-ace0-724ecfed2179",
        LastSeenAt = System.DateTime.Parse("2021-12-05T00:12:37.262Z").ToUniversalTime(),
        Metadata = new Dictionary<string, PropertyAnalyticsVisitorMetadata>() {
            { "segment", new PropertyAnalyticsVisitorMetadata() {} },
        },
        Name = "Desiree O'Hara",
        TotalEvents = 3639D,
        UpdatedAt = System.DateTime.Parse("2025-06-04T03:28:37.519Z").ToUniversalTime(),
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