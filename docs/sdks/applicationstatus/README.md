# Applicationstatus
(*Applicationstatus*)

## Overview

### Available Operations

* [ListAtsApplicationstatuses2](#listatsapplicationstatuses2) - List all applicationstatuses

## ListAtsApplicationstatuses2

List all applicationstatuses

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsApplicationstatuses2Request req = new ListAtsApplicationstatuses2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Applicationstatus.ListAtsApplicationstatuses2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListAtsApplicationstatuses2Request](../../Models/Requests/ListAtsApplicationstatuses2Request.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListAtsApplicationstatuses2Response](../../Models/Requests/ListAtsApplicationstatuses2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |