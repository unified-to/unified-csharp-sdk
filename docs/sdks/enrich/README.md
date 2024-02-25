# Enrich
(*Enrich*)

### Available Operations

* [ListEnrichCompanies](#listenrichcompanies) - Retrieve enrichment information for a company
* [ListEnrichPeople](#listenrichpeople) - Retrieve enrichment information for a person

## ListEnrichCompanies

Retrieve enrichment information for a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Enrich.ListEnrichCompaniesAsync(
    security: new ListEnrichCompaniesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    domain: "<value>",
    name: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.ListEnrichCompaniesSecurity](../../Models/Requests/ListEnrichCompaniesSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Domain`                                                                                                      | *string*                                                                                                      | :heavy_minus_sign:                                                                                            | The domain of the company to search                                                                           |
| `Name`                                                                                                        | *string*                                                                                                      | :heavy_minus_sign:                                                                                            | The name of the company to search                                                                             |


### Response

**[ListEnrichCompaniesResponse](../../Models/Requests/ListEnrichCompaniesResponse.md)**


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

var res = await sdk.Enrich.ListEnrichPeopleAsync(
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

