# Campaign

## Overview

### Available Operations

* [CreateAdsCampaign](#createadscampaign) - Create a campaign
* [CreateMartechCampaign](#createmartechcampaign) - Create a campaign
* [GetAdsCampaign](#getadscampaign) - Retrieve a campaign
* [GetMartechCampaign](#getmartechcampaign) - Retrieve a campaign
* [ListAdsCampaigns](#listadscampaigns) - List all campaigns
* [ListMartechCampaigns](#listmartechcampaigns) - List all campaigns
* [PatchAdsCampaign](#patchadscampaign) - Update a campaign
* [PatchMartechCampaign](#patchmartechcampaign) - Update a campaign
* [RemoveAdsCampaign](#removeadscampaign) - Remove a campaign
* [RemoveMartechCampaign](#removemartechcampaign) - Remove a campaign
* [UpdateAdsCampaign](#updateadscampaign) - Update a campaign
* [UpdateMartechCampaign](#updatemartechcampaign) - Update a campaign

## CreateAdsCampaign

Create a campaign

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsCampaign" method="post" path="/ads/{connection_id}/campaign" example="ads_campaign" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.CreateAdsCampaignAsync(
    adsCampaign: new AdsCampaign() {
        BudgetAmount = 8743.179536121897D,
        BudgetPeriod = BudgetPeriod.Monthly,
        Category = "CREDIT",
        CreatedAt = System.DateTime.Parse("2022-05-21T08:51:41.868Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = EffectiveStatus.NotEligible,
        EndAt = System.DateTime.Parse("2025-05-31T03:36:17.257Z").ToUniversalTime(),
        Id = "2e8a6397-bc44-4ecf-a6e2-d31eb9966054",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T09:44:26.617Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2025-12-31T14:22:08.841Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsCampaign`                                                                                                                                    | [AdsCampaign](../../Models/Components/AdsCampaign.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsCampaignQueryParamFields](../../Models/Requests/CreateAdsCampaignQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsCampaignResponse](../../Models/Requests/CreateAdsCampaignResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Campaign.CreateMartechCampaignAsync(
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

## GetAdsCampaign

Retrieve a campaign

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsCampaign" method="get" path="/ads/{connection_id}/campaign/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.GetAdsCampaignAsync(
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
| `Fields`                                                                                                                                         | List<[GetAdsCampaignQueryParamFields](../../Models/Requests/GetAdsCampaignQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsCampaignResponse](../../Models/Requests/GetAdsCampaignResponse.md)**

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

var res = await sdk.Campaign.GetMartechCampaignAsync(
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

## ListAdsCampaigns

List all campaigns

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsCampaigns" method="get" path="/ads/{connection_id}/campaign" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsCampaignsRequest req = new ListAdsCampaignsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Campaign.ListAdsCampaignsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAdsCampaignsRequest](../../Models/Requests/ListAdsCampaignsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListAdsCampaignsResponse](../../Models/Requests/ListAdsCampaignsResponse.md)**

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

var res = await sdk.Campaign.ListMartechCampaignsAsync(req);

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

## PatchAdsCampaign

Update a campaign

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsCampaign" method="patch" path="/ads/{connection_id}/campaign/{id}" example="ads_campaign" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsCampaignRequest req = new PatchAdsCampaignRequest() {
    AdsCampaign = new AdsCampaign() {
        BudgetAmount = 8743.179536121897D,
        BudgetPeriod = BudgetPeriod.Monthly,
        Category = "CREDIT",
        CreatedAt = System.DateTime.Parse("2022-05-21T08:51:41.868Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = EffectiveStatus.NotEligible,
        EndAt = System.DateTime.Parse("2025-05-31T03:36:17.344Z").ToUniversalTime(),
        Id = "26c27c05-ebde-4d55-b9f6-cb7398a33b0b",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T09:44:26.622Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2025-12-31T14:22:08.945Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Campaign.PatchAdsCampaignAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchAdsCampaignRequest](../../Models/Requests/PatchAdsCampaignRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchAdsCampaignResponse](../../Models/Requests/PatchAdsCampaignResponse.md)**

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

var res = await sdk.Campaign.PatchMartechCampaignAsync(req);

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

## RemoveAdsCampaign

Remove a campaign

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsCampaign" method="delete" path="/ads/{connection_id}/campaign/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.RemoveAdsCampaignAsync(
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

**[RemoveAdsCampaignResponse](../../Models/Requests/RemoveAdsCampaignResponse.md)**

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

var res = await sdk.Campaign.RemoveMartechCampaignAsync(
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

## UpdateAdsCampaign

Update a campaign

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsCampaign" method="put" path="/ads/{connection_id}/campaign/{id}" example="ads_campaign" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsCampaignRequest req = new UpdateAdsCampaignRequest() {
    AdsCampaign = new AdsCampaign() {
        BudgetAmount = 8743.179536121897D,
        BudgetPeriod = BudgetPeriod.Monthly,
        Category = "CREDIT",
        CreatedAt = System.DateTime.Parse("2022-05-21T08:51:41.868Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = EffectiveStatus.NotEligible,
        EndAt = System.DateTime.Parse("2025-05-31T03:36:17.344Z").ToUniversalTime(),
        Id = "26c27c05-ebde-4d55-b9f6-cb7398a33b0b",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T09:44:26.622Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2025-12-31T14:22:08.945Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Campaign.UpdateAdsCampaignAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateAdsCampaignRequest](../../Models/Requests/UpdateAdsCampaignRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateAdsCampaignResponse](../../Models/Requests/UpdateAdsCampaignResponse.md)**

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

var res = await sdk.Campaign.UpdateMartechCampaignAsync(req);

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