# Call
(*Call*)

### Available Operations

* [ListUcCalls](#listuccalls) - List all calls

## ListUcCalls

List all calls

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
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

