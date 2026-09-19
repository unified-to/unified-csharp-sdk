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
        CreatedAt = System.DateTime.Parse("2023-08-01T22:29:12.121Z").ToUniversalTime(),
        FromEmail = "Nick.Beahan@hotmail.com",
        FromName = "Javier Rempel",
        Id = "ad215e0b-404b-46be-a4de-c3271cff85b4",
        ListIds = new List<string>() {
            "bde5cab9-cf2f-4ed5-adab-b33c88bac5af",
        },
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Bellicus tener cinis causa cavus toties.",
        ReplyToEmail = "Antwan.Abshire@hotmail.com",
        SendAt = System.DateTime.Parse("2023-03-28T12:33:25.052Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Sent,
        SubjectLine = "Depromo depulso turpis teres apparatus placeat ventus tolero cunctatio.",
        Type = "plaintext",
        UpdatedAt = System.DateTime.Parse("2023-12-17T22:11:31.702Z").ToUniversalTime(),
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
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Martech.CreateMartechListAsync(
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
                Email = "Thalia.Abernathy61@gmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Maymie59@hotmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Coty27@hotmail.com",
                Type = MarketingEmailType.Work,
            },
        },
        FirstName = "Jude",
        Id = "30acc8f9-cc8e-4ee8-876e-9f9138d03725",
        LastName = "Leffler",
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "vinco",
            "ceno",
        },
        UpdatedAt = System.DateTime.Parse("2025-06-15T22:08:00.789Z").ToUniversalTime(),
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
        CreatedAt = System.DateTime.Parse("2023-08-01T22:29:12.121Z").ToUniversalTime(),
        FromEmail = "Nick.Beahan@hotmail.com",
        FromName = "Javier Rempel",
        Id = "301f0e2e-5bf6-4783-8d9d-fd296c2efc32",
        ListIds = new List<string>() {
            "bde5cab9-cf2f-4ed5-adab-b33c88bac5af",
        },
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Bellicus tener cinis causa cavus toties.",
        ReplyToEmail = "Antwan.Abshire@hotmail.com",
        SendAt = System.DateTime.Parse("2023-03-28T12:33:25.052Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Sent,
        SubjectLine = "Depromo depulso turpis teres apparatus placeat ventus tolero cunctatio.",
        Type = "plaintext",
        UpdatedAt = System.DateTime.Parse("2023-12-17T22:11:31.702Z").ToUniversalTime(),
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
                Email = "Thalia.Abernathy61@gmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Maymie59@hotmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Coty27@hotmail.com",
                Type = MarketingEmailType.Work,
            },
        },
        FirstName = "Jude",
        Id = "a857f1be-c4fb-4dc8-b345-62fd1c8fee81",
        LastName = "Leffler",
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "vinco",
            "ceno",
        },
        UpdatedAt = System.DateTime.Parse("2025-06-15T22:08:00.800Z").ToUniversalTime(),
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
        CreatedAt = System.DateTime.Parse("2023-08-01T22:29:12.121Z").ToUniversalTime(),
        FromEmail = "Nick.Beahan@hotmail.com",
        FromName = "Javier Rempel",
        Id = "301f0e2e-5bf6-4783-8d9d-fd296c2efc32",
        ListIds = new List<string>() {
            "bde5cab9-cf2f-4ed5-adab-b33c88bac5af",
        },
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Bellicus tener cinis causa cavus toties.",
        ReplyToEmail = "Antwan.Abshire@hotmail.com",
        SendAt = System.DateTime.Parse("2023-03-28T12:33:25.052Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Sent,
        SubjectLine = "Depromo depulso turpis teres apparatus placeat ventus tolero cunctatio.",
        Type = "plaintext",
        UpdatedAt = System.DateTime.Parse("2023-12-17T22:11:31.702Z").ToUniversalTime(),
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
                Email = "Thalia.Abernathy61@gmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Maymie59@hotmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Coty27@hotmail.com",
                Type = MarketingEmailType.Work,
            },
        },
        FirstName = "Jude",
        Id = "a857f1be-c4fb-4dc8-b345-62fd1c8fee81",
        LastName = "Leffler",
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "vinco",
            "ceno",
        },
        UpdatedAt = System.DateTime.Parse("2025-06-15T22:08:00.800Z").ToUniversalTime(),
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