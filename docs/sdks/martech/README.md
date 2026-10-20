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

Create a campaign

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
        Id = "a7dfef4e-54d2-4390-92a9-558a53a98130",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-21T14:44:59.366Z").ToUniversalTime(),
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

Create a list

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
        Id = "3291f8e8-ada9-4a05-88ee-e4517225bc4d",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-12T21:55:00.550Z").ToUniversalTime(),
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

Create a member

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
        Id = "1b064799-9e4f-49e3-adc0-5d312f115a94",
        LastName = "Leffler",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "adnuo",
            "verumtamen",
        },
        UpdatedAt = System.DateTime.Parse("2025-07-07T23:06:32.961Z").ToUniversalTime(),
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

Retrieve a campaign

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

Retrieve a list

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

Retrieve a member

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

List all campaigns

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

List all members

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

List all reports

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

Update a campaign

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
        Id = "3dfb5ccd-053a-426b-ae99-c5355e2fa690",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-21T14:44:59.377Z").ToUniversalTime(),
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

Update a list

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
        Id = "05137f1d-df5e-4078-bfe1-619cfa69b25b",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-12T21:55:00.563Z").ToUniversalTime(),
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

Update a member

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
        Id = "57c44751-e1d9-43ce-8702-e105e5ef3fc4",
        LastName = "Leffler",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "adnuo",
            "verumtamen",
        },
        UpdatedAt = System.DateTime.Parse("2025-07-07T23:06:32.973Z").ToUniversalTime(),
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

Remove a campaign

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

Remove a list

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

Remove a member

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

Update a campaign

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
        Id = "3dfb5ccd-053a-426b-ae99-c5355e2fa690",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-21T14:44:59.377Z").ToUniversalTime(),
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

Update a list

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
        Id = "05137f1d-df5e-4078-bfe1-619cfa69b25b",
        IsActive = true,
        Language = "ru",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Electronics Newsletter",
        SenderCompany = "Koepp and Sons",
        SenderEmail = "blake.kuhn@hotmail.com",
        SenderName = "Blake Kuhn",
        SenderPhone = "359.305.7962 x28115",
        Subject = "Theca caecus copia crebro valeo ulciscor.",
        UpdatedAt = System.DateTime.Parse("2022-09-12T21:55:00.563Z").ToUniversalTime(),
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

Update a member

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
        Id = "57c44751-e1d9-43ce-8702-e105e5ef3fc4",
        LastName = "Leffler",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "adnuo",
            "verumtamen",
        },
        UpdatedAt = System.DateTime.Parse("2025-07-07T23:06:32.973Z").ToUniversalTime(),
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