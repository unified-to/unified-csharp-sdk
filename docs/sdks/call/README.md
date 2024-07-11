# Call
(*Call*)

### Available Operations

* [ListUcCalls](#listuccalls) - List all calls

## ListUcCalls

List all calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Call.ListUcCallsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListUcCallsRequest](../../Models/Requests/ListUcCallsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[ListUcCallsResponse](../../Models/Requests/ListUcCallsResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
