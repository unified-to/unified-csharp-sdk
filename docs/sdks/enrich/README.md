# Enrich
(*Enrich*)

## Overview

### Available Operations

* [ListEnrichCompanies2](#listenrichcompanies2) - Retrieve enrichment information for a company
* [ListEnrichPeople2](#listenrichpeople2) - Retrieve enrichment information for a person

## ListEnrichCompanies2

Retrieve enrichment information for a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Enrich.ListEnrichCompanies2Async(connectionId: "<id>");

// handle response
```

### Parameters

| Parameter                           | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `ConnectionId`                      | *string*                            | :heavy_check_mark:                  | ID of the connection                |
| `Domain`                            | *string*                            | :heavy_minus_sign:                  | The domain of the company to search |
| `Name`                              | *string*                            | :heavy_minus_sign:                  | The name of the company to search   |

### Response

**[ListEnrichCompanies2Response](../../Models/Requests/ListEnrichCompanies2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Enrich.ListEnrichPeople2Async(req);

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