# Session

## Overview

### Available Operations

* [GetAnalyticsSession](#getanalyticssession) - Retrieve a session
* [ListAnalyticsSessions](#listanalyticssessions) - List all sessions

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

var res = await sdk.Session.GetAnalyticsSessionAsync(
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

var res = await sdk.Session.ListAnalyticsSessionsAsync(req);

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