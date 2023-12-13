# Applicationstatus
(*Applicationstatus*)

### Available Operations

* [ListAtsApplicationstatuses](#listatsapplicationstatuses) - List all application statuses

## ListAtsApplicationstatuses

List all application statuses

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsApplicationstatusesRequest req = new ListAtsApplicationstatusesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
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

