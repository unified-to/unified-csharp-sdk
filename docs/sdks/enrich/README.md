# Enrich
(*Enrich*)

### Available Operations

* [ListEnrichCompanies](#listenrichcompanies) - Retrieve enrichment information for a company
* [ListEnrichPeople](#listenrichpeople) - Retrieve enrichment information for a person

## ListEnrichCompanies

Retrieve enrichment information for a company

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Enrich.ListEnrichCompaniesAsync(ConnectionId: "string", Domain: "string", Name: "string");

// handle response
```

### Parameters

| Parameter                           | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `ConnectionId`                      | *string*                            | :heavy_check_mark:                  | ID of the connection                |
| `Domain`                            | *string*                            | :heavy_minus_sign:                  | The domain of the company to search |
| `Name`                              | *string*                            | :heavy_minus_sign:                  | The name of the company to search   |


### Response

**[ListEnrichCompaniesResponse](../../Models/Requests/ListEnrichCompaniesResponse.md)**


## ListEnrichPeople

Retrieve enrichment information for a person

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListEnrichPeopleRequest req = new ListEnrichPeopleRequest() {
    ConnectionId = "string",
};

var res = await sdk.Enrich.ListEnrichPeopleAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListEnrichPeopleRequest](../../Models/Requests/ListEnrichPeopleRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListEnrichPeopleResponse](../../Models/Requests/ListEnrichPeopleResponse.md)**

