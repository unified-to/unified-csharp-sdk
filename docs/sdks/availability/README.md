# Availability
(*Availability*)

## Overview

### Available Operations

* [ListCommerceAvailabilities2](#listcommerceavailabilities2) - List all availabilities

## ListCommerceAvailabilities2

List all availabilities

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceAvailabilities2Request req = new ListCommerceAvailabilities2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Availability.ListCommerceAvailabilities2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListCommerceAvailabilities2Request](../../Models/Requests/ListCommerceAvailabilities2Request.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListCommerceAvailabilities2Response](../../Models/Requests/ListCommerceAvailabilities2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |