# Promoted
(*Promoted*)

## Overview

### Available Operations

* [ListAdsPromoteds](#listadspromoteds) - List all promoteds

## ListAdsPromoteds

List all promoteds

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsPromotedsRequest req = new ListAdsPromotedsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Promoted.ListAdsPromotedsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAdsPromotedsRequest](../../Models/Requests/ListAdsPromotedsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListAdsPromotedsResponse](../../Models/Requests/ListAdsPromotedsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |