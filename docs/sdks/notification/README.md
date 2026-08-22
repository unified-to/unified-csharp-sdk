# Notification

## Overview

### Available Operations

* [ListUnifiedNotifications](#listunifiednotifications) - List event notifications

## ListUnifiedNotifications

List event notifications

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUnifiedNotifications" method="get" path="/unified/notification" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedNotificationsRequest? req = null;

var res = await sdk.Notification.ListUnifiedNotificationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListUnifiedNotificationsRequest](../../Models/Requests/ListUnifiedNotificationsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListUnifiedNotificationsResponse](../../Models/Requests/ListUnifiedNotificationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |