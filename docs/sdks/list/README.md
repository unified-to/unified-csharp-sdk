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

Create a list

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMartechList" method="post" path="/martech/{connection_id}/list" example="martech_list" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.CreateMartechListAsync(
    marketingList: new MarketingList() {
        Address = new PropertyMarketingListAddress() {
            Address1 = "922 Elmore Manor",
            Address2 = "Suite 925",
            City = "Deerfield Beach",
            Country = "Bahrain",
            PostalCode = "30765-6471",
            Region = "FL",
        },
        CreatedAt = System.DateTime.Parse("2019-09-18T02:01:36.950Z").ToUniversalTime(),
        Description = "Currus.",
        Id = "1beff3ac-e264-4b2d-8582-5e67bc7a1270",
        IsActive = true,
        Language = "it",
        Name = "Annette Nolan",
        SenderCompany = "Hickle - Homenick",
        SenderEmail = "Matt_Steuber@hotmail.com",
        SenderName = "Salvatore Roob",
        SenderPhone = "896-328-1153 x4957",
        Subject = "Tenetur thymum circumvenio triumphus celo.",
        UpdatedAt = System.DateTime.Parse("2022-08-30T22:24:21.627Z").ToUniversalTime(),
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

Retrieve a list

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

List all lists

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

Update a list

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMartechList" method="patch" path="/martech/{connection_id}/list/{id}" example="martech_list" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMartechListRequest req = new PatchMartechListRequest() {
    MarketingList = new MarketingList() {
        Address = new PropertyMarketingListAddress() {
            Address1 = "922 Elmore Manor",
            Address2 = "Suite 925",
            City = "Deerfield Beach",
            Country = "Bahrain",
            PostalCode = "30765-6471",
            Region = "FL",
        },
        CreatedAt = System.DateTime.Parse("2019-09-18T02:01:36.950Z").ToUniversalTime(),
        Description = "Currus.",
        Id = "99c2cea2-17e8-4b6c-8c54-48e458f427e7",
        IsActive = true,
        Language = "it",
        Name = "Annette Nolan",
        SenderCompany = "Hickle - Homenick",
        SenderEmail = "Matt_Steuber@hotmail.com",
        SenderName = "Salvatore Roob",
        SenderPhone = "896-328-1153 x4957",
        Subject = "Tenetur thymum circumvenio triumphus celo.",
        UpdatedAt = System.DateTime.Parse("2022-08-30T22:24:21.635Z").ToUniversalTime(),
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

Remove a list

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

Update a list

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMartechList" method="put" path="/martech/{connection_id}/list/{id}" example="martech_list" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMartechListRequest req = new UpdateMartechListRequest() {
    MarketingList = new MarketingList() {
        Address = new PropertyMarketingListAddress() {
            Address1 = "922 Elmore Manor",
            Address2 = "Suite 925",
            City = "Deerfield Beach",
            Country = "Bahrain",
            PostalCode = "30765-6471",
            Region = "FL",
        },
        CreatedAt = System.DateTime.Parse("2019-09-18T02:01:36.950Z").ToUniversalTime(),
        Description = "Currus.",
        Id = "99c2cea2-17e8-4b6c-8c54-48e458f427e7",
        IsActive = true,
        Language = "it",
        Name = "Annette Nolan",
        SenderCompany = "Hickle - Homenick",
        SenderEmail = "Matt_Steuber@hotmail.com",
        SenderName = "Salvatore Roob",
        SenderPhone = "896-328-1153 x4957",
        Subject = "Tenetur thymum circumvenio triumphus celo.",
        UpdatedAt = System.DateTime.Parse("2022-08-30T22:24:21.635Z").ToUniversalTime(),
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