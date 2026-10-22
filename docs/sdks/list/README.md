# List

## Overview

### Available Operations

* [CreateMartechList](#createmartechlist) - Create a list
* [GetMartechList](#getmartechlist) - Retrieve a list
* [ListMartechLists](#listmartechlists) - List all lists
* [PatchMartechList](#patchmartechlist) - Update a list
* [RemoveMartechList](#removemartechlist) - Remove a list
* [UpdateMartechList](#updatemartechlist) - Update a list

## CreateMartechList

Creates a MarketingList. Provide the unified MarketingList fields in the request body; they are mapped to the provider's API. Returns the created MarketingList.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMartechList" method="post" path="/martech/{connection_id}/list" example="martech_list" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.CreateMartechListAsync(
    marketingList: new MarketingList() {
        Address = new PropertyMarketingListAddress() {
            Address1 = "76564 Coronation Road",
            Address2 = "Suite 922",
            City = "West Jordon",
            Country = "Mexico",
            PostalCode = "04183",
            Region = "NC",
        },
        CreatedAt = System.DateTime.Parse("2019-09-18T02:01:36.950Z").ToUniversalTime(),
        Description = "Vilis.",
        Id = "960709f6-d027-4e9b-9f0a-6d03c6947c4d",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-13T19:22:14.739Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MarketingList`                                                                                                                                  | [MarketingList](../../Models/Components/MarketingList.md)                                                                                        | :heavy_check_mark:                                                                                                                               | Mailing List                                                                                                                                     |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMartechListQueryParamFields](../../Models/Requests/CreateMartechListQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMartechListResponse](../../Models/Requests/CreateMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMartechList

Retrieves a single MarketingList by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMartechList" method="get" path="/martech/{connection_id}/list/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.GetMartechListAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the List                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetMartechListQueryParamFields](../../Models/Requests/GetMartechListQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMartechListResponse](../../Models/Requests/GetMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMartechLists

Returns a list of MarketingLists. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMartechLists" method="get" path="/martech/{connection_id}/list" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechListsRequest req = new ListMartechListsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.List.ListMartechListsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListMartechListsRequest](../../Models/Requests/ListMartechListsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListMartechListsResponse](../../Models/Requests/ListMartechListsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMartechList

Updates the MarketingList identified by `id`. Provide the unified MarketingList fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMartechList" method="patch" path="/martech/{connection_id}/list/{id}" example="martech_list" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMartechListRequest req = new PatchMartechListRequest() {
    MarketingList = new MarketingList() {
        Address = new PropertyMarketingListAddress() {
            Address1 = "76564 Coronation Road",
            Address2 = "Suite 922",
            City = "West Jordon",
            Country = "Mexico",
            PostalCode = "04183",
            Region = "NC",
        },
        CreatedAt = System.DateTime.Parse("2019-09-18T02:01:36.950Z").ToUniversalTime(),
        Description = "Vilis.",
        Id = "b770449c-2b82-4216-90f1-7c9eb06b63f9",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-13T19:22:14.746Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.List.PatchMartechListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchMartechListRequest](../../Models/Requests/PatchMartechListRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchMartechListResponse](../../Models/Requests/PatchMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMartechList

Deletes the MarketingList identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMartechList" method="delete" path="/martech/{connection_id}/list/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.RemoveMartechListAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the List       |

### Response

**[RemoveMartechListResponse](../../Models/Requests/RemoveMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMartechList

Updates the MarketingList identified by `id`. Provide the unified MarketingList fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMartechList" method="put" path="/martech/{connection_id}/list/{id}" example="martech_list" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMartechListRequest req = new UpdateMartechListRequest() {
    MarketingList = new MarketingList() {
        Address = new PropertyMarketingListAddress() {
            Address1 = "76564 Coronation Road",
            Address2 = "Suite 922",
            City = "West Jordon",
            Country = "Mexico",
            PostalCode = "04183",
            Region = "NC",
        },
        CreatedAt = System.DateTime.Parse("2019-09-18T02:01:36.950Z").ToUniversalTime(),
        Description = "Vilis.",
        Id = "b770449c-2b82-4216-90f1-7c9eb06b63f9",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-13T19:22:14.746Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.List.UpdateMartechListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateMartechListRequest](../../Models/Requests/UpdateMartechListRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateMartechListResponse](../../Models/Requests/UpdateMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |