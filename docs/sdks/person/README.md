# Person
(*Person*)

## Overview

### Available Operations

* [ListEnrichPeople](#listenrichpeople) - Retrieve enrichment information for a person

## ListEnrichPeople

Retrieve enrichment information for a person

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListEnrichPeopleRequest req = new ListEnrichPeopleRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Person.ListEnrichPeopleAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListEnrichPeopleRequest](../../Models/Requests/ListEnrichPeopleRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListEnrichPeopleResponse](../../Models/Requests/ListEnrichPeopleResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |