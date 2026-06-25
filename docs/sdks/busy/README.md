# Busy
(*Busy*)

## Overview

### Available Operations

* [ListCalendarBusies2](#listcalendarbusies2) - List all busies

## ListCalendarBusies2

List all busies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarBusies2Request req = new ListCalendarBusies2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Busy.ListCalendarBusies2Async(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListCalendarBusies2Request](../../Models/Requests/ListCalendarBusies2Request.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListCalendarBusies2Response](../../Models/Requests/ListCalendarBusies2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |