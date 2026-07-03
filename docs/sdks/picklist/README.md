# Picklist
(*Picklist*)

## Overview

### Available Operations

* [ListCrmPicklists](#listcrmpicklists) - List all picklists

## ListCrmPicklists

List all picklists

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmPicklistsRequest req = new ListCrmPicklistsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Picklist.ListCrmPicklistsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListCrmPicklistsRequest](../../Models/Requests/ListCrmPicklistsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListCrmPicklistsResponse](../../Models/Requests/ListCrmPicklistsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |