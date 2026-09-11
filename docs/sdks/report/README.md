# Report

## Overview

### Available Operations

* [ListAdsReports](#listadsreports) - List all reports
* [ListAnalyticsReports](#listanalyticsreports) - List all reports
* [ListMartechReports](#listmartechreports) - List all reports

## ListAdsReports

List all reports

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsReports" method="get" path="/ads/{connection_id}/report" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsReportsRequest req = new ListAdsReportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Report.ListAdsReportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListAdsReportsRequest](../../Models/Requests/ListAdsReportsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListAdsReportsResponse](../../Models/Requests/ListAdsReportsResponse.md)**

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

var res = await sdk.Report.ListAnalyticsReportsAsync(req);

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

## ListMartechReports

List all reports

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMartechReports" method="get" path="/martech/{connection_id}/report" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechReportsRequest req = new ListMartechReportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Report.ListMartechReportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListMartechReportsRequest](../../Models/Requests/ListMartechReportsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListMartechReportsResponse](../../Models/Requests/ListMartechReportsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |