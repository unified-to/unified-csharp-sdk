# Taxonomy

## Overview

### Available Operations

* [CreateHrisTaxonomy](#createhristaxonomy) - Create a taxonomy
* [GetHrisTaxonomy](#gethristaxonomy) - Retrieve a taxonomy
* [ListCrmTaxonomies](#listcrmtaxonomies) - List all taxonomies
* [ListHrisTaxonomies](#listhristaxonomies) - List all taxonomies

## CreateHrisTaxonomy

Create a taxonomy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisTaxonomy" method="post" path="/hris/{connection_id}/taxonomy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxonomy.CreateHrisTaxonomyAsync(
    hrisTaxonomy: new HrisTaxonomy() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTaxonomy`                                                                                                                                   | [HrisTaxonomy](../../Models/Components/HrisTaxonomy.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTaxonomyQueryParamFields](../../Models/Requests/CreateHrisTaxonomyQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTaxonomyResponse](../../Models/Requests/CreateHrisTaxonomyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTaxonomy

Retrieve a taxonomy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisTaxonomy" method="get" path="/hris/{connection_id}/taxonomy/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxonomy.GetHrisTaxonomyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Taxonomy                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHrisTaxonomyQueryParamFields](../../Models/Requests/GetHrisTaxonomyQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTaxonomyResponse](../../Models/Requests/GetHrisTaxonomyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmTaxonomies

List all taxonomies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmTaxonomies" method="get" path="/crm/{connection_id}/taxonomy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmTaxonomiesRequest req = new ListCrmTaxonomiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Taxonomy.ListCrmTaxonomiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCrmTaxonomiesRequest](../../Models/Requests/ListCrmTaxonomiesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCrmTaxonomiesResponse](../../Models/Requests/ListCrmTaxonomiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTaxonomies

List all taxonomies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisTaxonomies" method="get" path="/hris/{connection_id}/taxonomy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTaxonomiesRequest req = new ListHrisTaxonomiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Taxonomy.ListHrisTaxonomiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListHrisTaxonomiesRequest](../../Models/Requests/ListHrisTaxonomiesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListHrisTaxonomiesResponse](../../Models/Requests/ListHrisTaxonomiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |