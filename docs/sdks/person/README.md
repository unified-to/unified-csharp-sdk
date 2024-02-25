# Person
(*Person*)

### Available Operations

* [ListEnrichPeople](#listenrichpeople) - Retrieve enrichment information for a person

## ListEnrichPeople

Retrieve enrichment information for a person

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

ListEnrichPeopleRequest req = new ListEnrichPeopleRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Person.ListEnrichPeopleAsync(
    security: new ListEnrichPeopleSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListEnrichPeopleRequest](../../Models/Requests/ListEnrichPeopleRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListEnrichPeopleSecurity](../../Models/Requests/ListEnrichPeopleSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListEnrichPeopleResponse](../../Models/Requests/ListEnrichPeopleResponse.md)**

