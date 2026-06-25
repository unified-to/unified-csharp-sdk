# Person
(*Person*)

## Overview

### Available Operations

* [ListEnrichPeople2](#listenrichpeople2) - Retrieve enrichment information for a person

## ListEnrichPeople2

Retrieve enrichment information for a person

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListEnrichPeople2Request req = new ListEnrichPeople2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Person.ListEnrichPeople2Async(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListEnrichPeople2Request](../../Models/Requests/ListEnrichPeople2Request.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListEnrichPeople2Response](../../Models/Requests/ListEnrichPeople2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |