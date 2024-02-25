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

var sdk = new UnifiedToSDK();

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Call.ListUcCallsAsync(
    security: new ListUcCallsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListUcCallsRequest](../../Models/Requests/ListUcCallsRequest.md)                             | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [UnifiedTo.Models.Requests.ListUcCallsSecurity](../../Models/Requests/ListUcCallsSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |


### Response

**[ListUcCallsResponse](../../Models/Requests/ListUcCallsResponse.md)**

