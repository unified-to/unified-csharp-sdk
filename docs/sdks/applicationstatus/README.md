# Applicationstatus
(*Applicationstatus*)

## Overview

### Available Operations

* [ListAtsApplicationstatuses](#listatsapplicationstatuses) - List all applicationstatuses

## ListAtsApplicationstatuses

List all applicationstatuses

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsApplicationstatusesRequest req = new ListAtsApplicationstatusesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Applicationstatus.ListAtsApplicationstatusesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAtsApplicationstatusesRequest](../../Models/Requests/ListAtsApplicationstatusesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListAtsApplicationstatusesResponse](../../Models/Requests/ListAtsApplicationstatusesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |