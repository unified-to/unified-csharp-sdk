# Analytics

## Overview

### Available Operations

* [CreateAnalyticsEvent](#createanalyticsevent) - Create an event
* [CreateAnalyticsProperty](#createanalyticsproperty) - Create a property
* [CreateAnalyticsVisitor](#createanalyticsvisitor) - Create a visitor
* [GetAnalyticsEvent](#getanalyticsevent) - Retrieve an event
* [GetAnalyticsProperty](#getanalyticsproperty) - Retrieve a property
* [GetAnalyticsSession](#getanalyticssession) - Retrieve a session
* [GetAnalyticsVisitor](#getanalyticsvisitor) - Retrieve a visitor
* [ListAnalyticsEvents](#listanalyticsevents) - List all events
* [ListAnalyticsProperties](#listanalyticsproperties) - List all properties
* [ListAnalyticsReports](#listanalyticsreports) - List all reports
* [ListAnalyticsSessions](#listanalyticssessions) - List all sessions
* [ListAnalyticsVisitors](#listanalyticsvisitors) - List all visitors
* [PatchAnalyticsProperty](#patchanalyticsproperty) - Update a property
* [PatchAnalyticsVisitor](#patchanalyticsvisitor) - Update a visitor
* [RemoveAnalyticsProperty](#removeanalyticsproperty) - Remove a property
* [RemoveAnalyticsVisitor](#removeanalyticsvisitor) - Remove a visitor
* [UpdateAnalyticsProperty](#updateanalyticsproperty) - Update a property
* [UpdateAnalyticsVisitor](#updateanalyticsvisitor) - Update a visitor

## CreateAnalyticsEvent

Create an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAnalyticsEvent" method="post" path="/analytics/{connection_id}/event" example="analytics_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Analytics.CreateAnalyticsEventAsync(
    analyticsEvent: new AnalyticsEvent() {
        CreatedAt = System.DateTime.Parse("2023-06-21T03:13:22.954Z").ToUniversalTime(),
        EventType = EventType.ScreenView,
        Id = "d72f92f6-8ce6-4da7-b761-ec024e9c93e9",
        Metadata = new Dictionary<string, PropertyAnalyticsEventMetadata>() {
            { "key", new PropertyAnalyticsEventMetadata() {} },
        },
        Name = "Xk707ttsb51v",
        UpdatedAt = System.DateTime.Parse("2023-09-22T04:06:28.143Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AnalyticsEvent`                                                                                                                                 | [AnalyticsEvent](../../Models/Components/AnalyticsEvent.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAnalyticsEventQueryParamFields](../../Models/Requests/CreateAnalyticsEventQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAnalyticsEventResponse](../../Models/Requests/CreateAnalyticsEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAnalyticsProperty

Create a property

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAnalyticsProperty" method="post" path="/analytics/{connection_id}/property" example="analytics_property" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Analytics.CreateAnalyticsPropertyAsync(
    analyticsProperty: new AnalyticsProperty() {
        CreatedAt = System.DateTime.Parse("2021-09-05T19:04:58.430Z").ToUniversalTime(),
        Currency = "USD",
        Id = "204e7ec3-d77d-444b-98c2-e68471307a14",
        Name = "Daniel, Goldner and Dickinson",
        Timezone = "UTC",
        UpdatedAt = System.DateTime.Parse("2021-09-14T16:43:11.921Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AnalyticsProperty`                                                                                                                              | [AnalyticsProperty](../../Models/Components/AnalyticsProperty.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAnalyticsPropertyQueryParamFields](../../Models/Requests/CreateAnalyticsPropertyQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAnalyticsPropertyResponse](../../Models/Requests/CreateAnalyticsPropertyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Analytics.CreateAnalyticsVisitorAsync(
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

## GetAnalyticsEvent

Retrieve an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAnalyticsEvent" method="get" path="/analytics/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Analytics.GetAnalyticsEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Event                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAnalyticsEventQueryParamFields](../../Models/Requests/GetAnalyticsEventQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAnalyticsEventResponse](../../Models/Requests/GetAnalyticsEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAnalyticsProperty

Retrieve a property

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAnalyticsProperty" method="get" path="/analytics/{connection_id}/property/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Analytics.GetAnalyticsPropertyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Property                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAnalyticsPropertyQueryParamFields](../../Models/Requests/GetAnalyticsPropertyQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAnalyticsPropertyResponse](../../Models/Requests/GetAnalyticsPropertyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAnalyticsSession

Retrieve a session

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAnalyticsSession" method="get" path="/analytics/{connection_id}/session/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Analytics.GetAnalyticsSessionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Session                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAnalyticsSessionQueryParamFields](../../Models/Requests/GetAnalyticsSessionQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAnalyticsSessionResponse](../../Models/Requests/GetAnalyticsSessionResponse.md)**

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

var res = await sdk.Analytics.GetAnalyticsVisitorAsync(
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

## ListAnalyticsEvents

List all events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAnalyticsEvents" method="get" path="/analytics/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsEventsRequest req = new ListAnalyticsEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Analytics.ListAnalyticsEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAnalyticsEventsRequest](../../Models/Requests/ListAnalyticsEventsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListAnalyticsEventsResponse](../../Models/Requests/ListAnalyticsEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAnalyticsProperties

List all properties

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAnalyticsProperties" method="get" path="/analytics/{connection_id}/property" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsPropertiesRequest req = new ListAnalyticsPropertiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Analytics.ListAnalyticsPropertiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAnalyticsPropertiesRequest](../../Models/Requests/ListAnalyticsPropertiesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ListAnalyticsPropertiesResponse](../../Models/Requests/ListAnalyticsPropertiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAnalyticsReports

List all reports

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAnalyticsReports" method="get" path="/analytics/{connection_id}/report" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsReportsRequest req = new ListAnalyticsReportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Analytics.ListAnalyticsReportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListAnalyticsReportsRequest](../../Models/Requests/ListAnalyticsReportsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListAnalyticsReportsResponse](../../Models/Requests/ListAnalyticsReportsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAnalyticsSessions

List all sessions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAnalyticsSessions" method="get" path="/analytics/{connection_id}/session" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAnalyticsSessionsRequest req = new ListAnalyticsSessionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Analytics.ListAnalyticsSessionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListAnalyticsSessionsRequest](../../Models/Requests/ListAnalyticsSessionsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListAnalyticsSessionsResponse](../../Models/Requests/ListAnalyticsSessionsResponse.md)**

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

var res = await sdk.Analytics.ListAnalyticsVisitorsAsync(req);

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

## PatchAnalyticsProperty

Update a property

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAnalyticsProperty" method="patch" path="/analytics/{connection_id}/property/{id}" example="analytics_property" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAnalyticsPropertyRequest req = new PatchAnalyticsPropertyRequest() {
    AnalyticsProperty = new AnalyticsProperty() {
        CreatedAt = System.DateTime.Parse("2021-09-05T19:04:58.430Z").ToUniversalTime(),
        Currency = "USD",
        Id = "e4da6be0-7736-4a3f-8e62-3196e4b5aa54",
        Name = "Daniel, Goldner and Dickinson",
        Timezone = "UTC",
        UpdatedAt = System.DateTime.Parse("2021-09-14T16:43:11.921Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Analytics.PatchAnalyticsPropertyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAnalyticsPropertyRequest](../../Models/Requests/PatchAnalyticsPropertyRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAnalyticsPropertyResponse](../../Models/Requests/PatchAnalyticsPropertyResponse.md)**

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

var res = await sdk.Analytics.PatchAnalyticsVisitorAsync(req);

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

## RemoveAnalyticsProperty

Remove a property

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAnalyticsProperty" method="delete" path="/analytics/{connection_id}/property/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Analytics.RemoveAnalyticsPropertyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Property   |

### Response

**[RemoveAnalyticsPropertyResponse](../../Models/Requests/RemoveAnalyticsPropertyResponse.md)**

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

var res = await sdk.Analytics.RemoveAnalyticsVisitorAsync(
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

## UpdateAnalyticsProperty

Update a property

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAnalyticsProperty" method="put" path="/analytics/{connection_id}/property/{id}" example="analytics_property" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAnalyticsPropertyRequest req = new UpdateAnalyticsPropertyRequest() {
    AnalyticsProperty = new AnalyticsProperty() {
        CreatedAt = System.DateTime.Parse("2021-09-05T19:04:58.430Z").ToUniversalTime(),
        Currency = "USD",
        Id = "e4da6be0-7736-4a3f-8e62-3196e4b5aa54",
        Name = "Daniel, Goldner and Dickinson",
        Timezone = "UTC",
        UpdatedAt = System.DateTime.Parse("2021-09-14T16:43:11.921Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Analytics.UpdateAnalyticsPropertyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAnalyticsPropertyRequest](../../Models/Requests/UpdateAnalyticsPropertyRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAnalyticsPropertyResponse](../../Models/Requests/UpdateAnalyticsPropertyResponse.md)**

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

var res = await sdk.Analytics.UpdateAnalyticsVisitorAsync(req);

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