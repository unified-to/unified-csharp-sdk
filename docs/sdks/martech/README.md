# Martech

## Overview

### Available Operations

* [CreateMartechCampaign](#createmartechcampaign) - Create a campaign
* [CreateMartechList](#createmartechlist) - Create a list
* [CreateMartechMember](#createmartechmember) - Create a member
* [GetMartechCampaign](#getmartechcampaign) - Retrieve a campaign
* [GetMartechList](#getmartechlist) - Retrieve a list
* [GetMartechMember](#getmartechmember) - Retrieve a member
* [ListMartechCampaigns](#listmartechcampaigns) - List all campaigns
* [ListMartechLists](#listmartechlists) - List all lists
* [ListMartechMembers](#listmartechmembers) - List all members
* [ListMartechReports](#listmartechreports) - List all reports
* [PatchMartechCampaign](#patchmartechcampaign) - Update a campaign
* [PatchMartechList](#patchmartechlist) - Update a list
* [PatchMartechMember](#patchmartechmember) - Update a member
* [RemoveMartechCampaign](#removemartechcampaign) - Remove a campaign
* [RemoveMartechList](#removemartechlist) - Remove a list
* [RemoveMartechMember](#removemartechmember) - Remove a member
* [UpdateMartechCampaign](#updatemartechcampaign) - Update a campaign
* [UpdateMartechList](#updatemartechlist) - Update a list
* [UpdateMartechMember](#updatemartechmember) - Update a member

## CreateMartechCampaign

Creates a MarketingCampaign. Provide the unified MarketingCampaign fields in the request body; they are mapped to the provider's API. Returns the created MarketingCampaign.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMartechCampaign" method="post" path="/martech/{connection_id}/campaign" example="martech_campaign" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.CreateMartechCampaignAsync(
    marketingCampaign: new MarketingCampaign() {
        CreatedAt = System.DateTime.Parse("2019-05-19T11:18:15.589Z").ToUniversalTime(),
        FromEmail = "graham.mertz@gmail.com",
        FromName = "Graham Mertz",
        Id = "9f58837b-5765-422f-b26d-d9473ba26aba",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-22T22:57:16.268Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MarketingCampaign`                                                                                                                              | [MarketingCampaign](../../Models/Components/MarketingCampaign.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMartechCampaignQueryParamFields](../../Models/Requests/CreateMartechCampaignQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMartechCampaignResponse](../../Models/Requests/CreateMartechCampaignResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Martech.CreateMartechListAsync(
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
        Id = "79547eaa-5d19-4eb0-9997-cbadde8b4413",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-14T06:29:25.163Z").ToUniversalTime(),
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

## CreateMartechMember

Creates a MarketingMember. Provide the unified MarketingMember fields in the request body; they are mapped to the provider's API. Returns the created MarketingMember.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMartechMember" method="post" path="/martech/{connection_id}/member" example="martech_member" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.CreateMartechMemberAsync(
    marketingMember: new MarketingMember() {
        Company = "Miller - Franecki",
        CreatedAt = System.DateTime.Parse("2022-04-15T15:32:38.496Z").ToUniversalTime(),
        Emails = new List<MarketingEmail>() {
            new MarketingEmail() {
                Email = "jude.leffler@hotmail.com",
                Type = MarketingEmailType.Home,
            },
        },
        FirstName = "Jude",
        Id = "ea72cd41-a4cf-45a0-9f89-c381dc6021ce",
        LastName = "Leffler",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "adnuo",
            "verumtamen",
        },
        UpdatedAt = System.DateTime.Parse("2025-07-10T06:25:19.654Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MarketingMember`                                                                                                                                | [MarketingMember](../../Models/Components/MarketingMember.md)                                                                                    | :heavy_check_mark:                                                                                                                               | A member represents a person                                                                                                                     |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMartechMemberQueryParamFields](../../Models/Requests/CreateMartechMemberQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMartechMemberResponse](../../Models/Requests/CreateMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMartechCampaign

Retrieves a single MarketingCampaign by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMartechCampaign" method="get" path="/martech/{connection_id}/campaign/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.GetMartechCampaignAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Campaign                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetMartechCampaignQueryParamFields](../../Models/Requests/GetMartechCampaignQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMartechCampaignResponse](../../Models/Requests/GetMartechCampaignResponse.md)**

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

var res = await sdk.Martech.GetMartechListAsync(
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

## GetMartechMember

Retrieves a single MarketingMember by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMartechMember" method="get" path="/martech/{connection_id}/member/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.GetMartechMemberAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Member                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetMartechMemberQueryParamFields](../../Models/Requests/GetMartechMemberQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMartechMemberResponse](../../Models/Requests/GetMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMartechCampaigns

Returns a list of MarketingCampaigns. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMartechCampaigns" method="get" path="/martech/{connection_id}/campaign" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechCampaignsRequest req = new ListMartechCampaignsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Martech.ListMartechCampaignsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListMartechCampaignsRequest](../../Models/Requests/ListMartechCampaignsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListMartechCampaignsResponse](../../Models/Requests/ListMartechCampaignsResponse.md)**

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

var res = await sdk.Martech.ListMartechListsAsync(req);

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

## ListMartechMembers

Returns a list of MarketingMembers. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMartechMembers" method="get" path="/martech/{connection_id}/member" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechMembersRequest req = new ListMartechMembersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Martech.ListMartechMembersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListMartechMembersRequest](../../Models/Requests/ListMartechMembersRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListMartechMembersResponse](../../Models/Requests/ListMartechMembersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMartechReports

Returns a list of MarketingReports. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMartechReports" method="get" path="/martech/{connection_id}/report" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechReportsRequest req = new ListMartechReportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Martech.ListMartechReportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListMartechReportsRequest](../../Models/Requests/ListMartechReportsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListMartechReportsResponse](../../Models/Requests/ListMartechReportsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMartechCampaign

Updates the MarketingCampaign identified by `id`. Provide the unified MarketingCampaign fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMartechCampaign" method="patch" path="/martech/{connection_id}/campaign/{id}" example="martech_campaign" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMartechCampaignRequest req = new PatchMartechCampaignRequest() {
    MarketingCampaign = new MarketingCampaign() {
        CreatedAt = System.DateTime.Parse("2019-05-19T11:18:15.589Z").ToUniversalTime(),
        FromEmail = "graham.mertz@gmail.com",
        FromName = "Graham Mertz",
        Id = "aa96cdd5-353f-4725-af38-e99416622817",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-22T22:57:16.278Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Martech.PatchMartechCampaignAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchMartechCampaignRequest](../../Models/Requests/PatchMartechCampaignRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchMartechCampaignResponse](../../Models/Requests/PatchMartechCampaignResponse.md)**

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
        Id = "4a563715-48c6-4baa-bc8b-07f5a2f81820",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-14T06:29:25.171Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Martech.PatchMartechListAsync(req);

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

## PatchMartechMember

Updates the MarketingMember identified by `id`. Provide the unified MarketingMember fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMartechMember" method="patch" path="/martech/{connection_id}/member/{id}" example="martech_member" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMartechMemberRequest req = new PatchMartechMemberRequest() {
    MarketingMember = new MarketingMember() {
        Company = "Miller - Franecki",
        CreatedAt = System.DateTime.Parse("2022-04-15T15:32:38.496Z").ToUniversalTime(),
        Emails = new List<MarketingEmail>() {
            new MarketingEmail() {
                Email = "jude.leffler@hotmail.com",
                Type = MarketingEmailType.Home,
            },
        },
        FirstName = "Jude",
        Id = "1cbbafe8-9cd9-4922-84d0-b380794f55d6",
        LastName = "Leffler",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "adnuo",
            "verumtamen",
        },
        UpdatedAt = System.DateTime.Parse("2025-07-10T06:25:19.662Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Martech.PatchMartechMemberAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchMartechMemberRequest](../../Models/Requests/PatchMartechMemberRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchMartechMemberResponse](../../Models/Requests/PatchMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMartechCampaign

Deletes the MarketingCampaign identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMartechCampaign" method="delete" path="/martech/{connection_id}/campaign/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.RemoveMartechCampaignAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Campaign   |

### Response

**[RemoveMartechCampaignResponse](../../Models/Requests/RemoveMartechCampaignResponse.md)**

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

var res = await sdk.Martech.RemoveMartechListAsync(
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

## RemoveMartechMember

Deletes the MarketingMember identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMartechMember" method="delete" path="/martech/{connection_id}/member/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.RemoveMartechMemberAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Member     |

### Response

**[RemoveMartechMemberResponse](../../Models/Requests/RemoveMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMartechCampaign

Updates the MarketingCampaign identified by `id`. Provide the unified MarketingCampaign fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMartechCampaign" method="put" path="/martech/{connection_id}/campaign/{id}" example="martech_campaign" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMartechCampaignRequest req = new UpdateMartechCampaignRequest() {
    MarketingCampaign = new MarketingCampaign() {
        CreatedAt = System.DateTime.Parse("2019-05-19T11:18:15.589Z").ToUniversalTime(),
        FromEmail = "graham.mertz@gmail.com",
        FromName = "Graham Mertz",
        Id = "aa96cdd5-353f-4725-af38-e99416622817",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-22T22:57:16.278Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Martech.UpdateMartechCampaignAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateMartechCampaignRequest](../../Models/Requests/UpdateMartechCampaignRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateMartechCampaignResponse](../../Models/Requests/UpdateMartechCampaignResponse.md)**

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
        Id = "4a563715-48c6-4baa-bc8b-07f5a2f81820",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-14T06:29:25.171Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Martech.UpdateMartechListAsync(req);

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

## UpdateMartechMember

Updates the MarketingMember identified by `id`. Provide the unified MarketingMember fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMartechMember" method="put" path="/martech/{connection_id}/member/{id}" example="martech_member" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMartechMemberRequest req = new UpdateMartechMemberRequest() {
    MarketingMember = new MarketingMember() {
        Company = "Miller - Franecki",
        CreatedAt = System.DateTime.Parse("2022-04-15T15:32:38.496Z").ToUniversalTime(),
        Emails = new List<MarketingEmail>() {
            new MarketingEmail() {
                Email = "jude.leffler@hotmail.com",
                Type = MarketingEmailType.Home,
            },
        },
        FirstName = "Jude",
        Id = "1cbbafe8-9cd9-4922-84d0-b380794f55d6",
        LastName = "Leffler",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "adnuo",
            "verumtamen",
        },
        UpdatedAt = System.DateTime.Parse("2025-07-10T06:25:19.662Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Martech.UpdateMartechMemberAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateMartechMemberRequest](../../Models/Requests/UpdateMartechMemberRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateMartechMemberResponse](../../Models/Requests/UpdateMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |