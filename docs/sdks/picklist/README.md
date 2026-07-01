# Picklist
(*Picklist*)

## Overview

### Available Operations

* [ListCrmPicklists2](#listcrmpicklists2) - List all picklists

## ListCrmPicklists2

List all picklists

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmPicklists2Request req = new ListCrmPicklists2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Picklist.ListCrmPicklists2Async(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCrmPicklists2Request](../../Models/Requests/ListCrmPicklists2Request.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCrmPicklists2Response](../../Models/Requests/ListCrmPicklists2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |