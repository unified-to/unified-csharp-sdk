# Busy
(*Busy*)

## Overview

### Available Operations

* [ListCalendarBusies](#listcalendarbusies) - List all busies

## ListCalendarBusies

List all busies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarBusiesRequest req = new ListCalendarBusiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Busy.ListCalendarBusiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListCalendarBusiesRequest](../../Models/Requests/ListCalendarBusiesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListCalendarBusiesResponse](../../Models/Requests/ListCalendarBusiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |