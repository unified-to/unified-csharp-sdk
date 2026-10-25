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

Creates a AdsCampaign. Provide the unified AdsCampaign fields in the request body; they are mapped to the provider's API. Returns the created AdsCampaign.

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
        EndAt = System.DateTime.Parse("2025-06-03T16:59:59.886Z").ToUniversalTime(),
        Id = "81f79148-67a4-4317-9545-5f1ca0bf6708",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T14:27:15.657Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2026-01-04T20:19:31.167Z").ToUniversalTime(),
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

var res = await sdk.Campaign.CreateMartechCampaignAsync(
    marketingCampaign: new MarketingCampaign() {
        CreatedAt = System.DateTime.Parse("2019-05-19T11:18:15.589Z").ToUniversalTime(),
        FromEmail = "graham.mertz@gmail.com",
        FromName = "Graham Mertz",
        Id = "f2acdab9-bc8b-4db3-a2fd-a96c802af54e",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-23T18:37:34.345Z").ToUniversalTime(),
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

Retrieves a single AdsCampaign by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single MarketingCampaign by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AdsCampaigns. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the AdsCampaign identified by `id`. Provide the unified AdsCampaign fields to change in the request body.

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
        EndAt = System.DateTime.Parse("2025-06-03T16:59:59.949Z").ToUniversalTime(),
        Id = "c0bcf74b-26ac-44a3-b3f9-153369b27d6f",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T14:27:15.660Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2026-01-04T20:19:31.242Z").ToUniversalTime(),
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
        Id = "8968436f-65d3-4718-b3a5-c91a30521384",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-23T18:37:34.350Z").ToUniversalTime(),
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

Deletes the AdsCampaign identified by `id`.

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

Deletes the MarketingCampaign identified by `id`.

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

Updates the AdsCampaign identified by `id`. Provide the unified AdsCampaign fields to change in the request body.

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
        EndAt = System.DateTime.Parse("2025-06-03T16:59:59.949Z").ToUniversalTime(),
        Id = "c0bcf74b-26ac-44a3-b3f9-153369b27d6f",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T14:27:15.660Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2026-01-04T20:19:31.242Z").ToUniversalTime(),
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
        Id = "8968436f-65d3-4718-b3a5-c91a30521384",
        Metadata = new List<MarketingMetadata>() {},
        Name = "Consequatur atqui sustineo.",
        PreviewText = "Auctus votum ver umbra corroboro turpis spoliatio tamen strues auxilium benigne tempus error eaque suasoria.",
        ReplyToEmail = "graham.mertz@icloud.com",
        SendAt = System.DateTime.Parse("2024-01-23T21:19:26.708Z").ToUniversalTime(),
        Status = MarketingCampaignStatus.Scheduled,
        SubjectLine = "Trepide utpote conculco tibi solio supplanto peior tibi.",
        Type = "absplit",
        UpdatedAt = System.DateTime.Parse("2022-06-23T18:37:34.350Z").ToUniversalTime(),
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