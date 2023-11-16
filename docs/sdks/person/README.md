# Person
(*Person*)

### Available Operations

* [ListEnrichPeople](#listenrichpeople) - Retrieve enrichment information for a person

## ListEnrichPeople

Retrieve enrichment information for a person

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.Person.ListEnrichPeopleAsync(new ListEnrichPeopleRequest() {
    ConnectionId = "string",
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListEnrichPeopleRequest](../../Models/Requests/ListEnrichPeopleRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListEnrichPeopleResponse](../../Models/Requests/ListEnrichPeopleResponse.md)**

