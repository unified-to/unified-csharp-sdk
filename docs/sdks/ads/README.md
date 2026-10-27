# Ads

## Overview

### Available Operations

* [CreateAdsAd](#createadsad) - Create an ad
* [CreateAdsAsset](#createadsasset) - Create an asset
* [CreateAdsCampaign](#createadscampaign) - Create a campaign
* [CreateAdsCreative](#createadscreative) - Create a creative
* [CreateAdsGroup](#createadsgroup) - Create a group
* [CreateAdsInsertionorder](#createadsinsertionorder) - Create an insertionorder
* [CreateAdsOrganization](#createadsorganization) - Create an organization
* [GetAdsAd](#getadsad) - Retrieve an ad
* [GetAdsAsset](#getadsasset) - Retrieve an asset
* [GetAdsCampaign](#getadscampaign) - Retrieve a campaign
* [GetAdsCreative](#getadscreative) - Retrieve a creative
* [GetAdsGroup](#getadsgroup) - Retrieve a group
* [GetAdsInsertionorder](#getadsinsertionorder) - Retrieve an insertionorder
* [GetAdsOrganization](#getadsorganization) - Retrieve an organization
* [GetAdsPromoted](#getadspromoted) - Retrieve a promoted
* [GetAdsTarget](#getadstarget) - Retrieve a target
* [ListAdsAds](#listadsads) - List all ads
* [ListAdsAssets](#listadsassets) - List all assets
* [ListAdsCampaigns](#listadscampaigns) - List all campaigns
* [ListAdsCreatives](#listadscreatives) - List all creatives
* [ListAdsGroups](#listadsgroups) - List all groups
* [ListAdsInsertionorders](#listadsinsertionorders) - List all insertionorders
* [ListAdsOrganizations](#listadsorganizations) - List all organizations
* [ListAdsPromoteds](#listadspromoteds) - List all promoteds
* [ListAdsReports](#listadsreports) - List all reports
* [ListAdsTargets](#listadstargets) - List all targets
* [PatchAdsAd](#patchadsad) - Update an ad
* [PatchAdsCampaign](#patchadscampaign) - Update a campaign
* [PatchAdsCreative](#patchadscreative) - Update a creative
* [PatchAdsGroup](#patchadsgroup) - Update a group
* [PatchAdsInsertionorder](#patchadsinsertionorder) - Update an insertionorder
* [PatchAdsOrganization](#patchadsorganization) - Update an organization
* [RemoveAdsAd](#removeadsad) - Remove an ad
* [RemoveAdsCampaign](#removeadscampaign) - Remove a campaign
* [RemoveAdsCreative](#removeadscreative) - Remove a creative
* [RemoveAdsGroup](#removeadsgroup) - Remove a group
* [RemoveAdsInsertionorder](#removeadsinsertionorder) - Remove an insertionorder
* [RemoveAdsOrganization](#removeadsorganization) - Remove an organization
* [UpdateAdsAd](#updateadsad) - Update an ad
* [UpdateAdsCampaign](#updateadscampaign) - Update a campaign
* [UpdateAdsCreative](#updateadscreative) - Update a creative
* [UpdateAdsGroup](#updateadsgroup) - Update a group
* [UpdateAdsInsertionorder](#updateadsinsertionorder) - Update an insertionorder
* [UpdateAdsOrganization](#updateadsorganization) - Update an organization

## CreateAdsAd

Creates a AdsAd. Provide the unified AdsAd fields in the request body; they are mapped to the provider's API. Returns the created AdsAd.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsAd" method="post" path="/ads/{connection_id}/ad" example="ads_ad" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.CreateAdsAdAsync(
    adsAd: new AdsAd() {
        AdCopy = "Ascisco tolero caute sapiente. Valens unde comedo cursus crinis nobis thema. Cohaero nisi ullam tum unde ultio vilicus auditor capio.",
        AdType = AdType.Social,
        AdvertiserName = "Robel, Nader and Rau",
        CreatedAt = System.DateTime.Parse("2022-11-08T03:38:20.978Z").ToUniversalTime(),
        CreativeAssetUrl = "https://picsum.photos/seed/LwOzrpr9/948/2793",
        Description = "Accedo vespillo carpo dolor decet stillicidium comptus tenuis.",
        FinalUrl = "https://improbable-sanity.com",
        Id = "9b27768c-e78a-4f41-a60c-661a66adfd2b",
        Metadata = new List<AdsMetadata>() {},
        Name = "Hermiston Group",
        Status = AdsAdStatus.Archived,
        UpdatedAt = System.DateTime.Parse("2024-06-21T00:36:08.295Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsAd`                                                                                                                                          | [AdsAd](../../Models/Components/AdsAd.md)                                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsAdQueryParamFields](../../Models/Requests/CreateAdsAdQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsAdResponse](../../Models/Requests/CreateAdsAdResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAdsAsset

Creates a AdsAsset. Provide the unified AdsAsset fields in the request body; they are mapped to the provider's API. Returns the created AdsAsset.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsAsset" method="post" path="/ads/{connection_id}/asset" example="ads_asset" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.CreateAdsAssetAsync(
    adsAsset: new AdsAsset() {
        CreatedAt = System.DateTime.Parse("2020-03-27T20:14:38.603Z").ToUniversalTime(),
        Height = 400D,
        Id = "e6ae16e6-efa8-403f-b14e-67fc8870caa3",
        Metadata = new List<AdsMetadata>() {},
        MimeType = "IMAGE_PNG",
        Name = "Lockman - DuBuque",
        Type = AdsAssetType.Image,
        UpdatedAt = System.DateTime.Parse("2022-03-27T00:29:10.941Z").ToUniversalTime(),
        Url = "https://informal-perfection.com/",
        Width = 600D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsAsset`                                                                                                                                       | [AdsAsset](../../Models/Components/AdsAsset.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsAssetQueryParamFields](../../Models/Requests/CreateAdsAssetQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsAssetResponse](../../Models/Requests/CreateAdsAssetResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ads.CreateAdsCampaignAsync(
    adsCampaign: new AdsCampaign() {
        BudgetAmount = 8743.179536121897D,
        BudgetPeriod = BudgetPeriod.Monthly,
        Category = "CREDIT",
        CreatedAt = System.DateTime.Parse("2022-05-21T08:51:41.868Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = EffectiveStatus.NotEligible,
        EndAt = System.DateTime.Parse("2025-06-05T02:37:25.708Z").ToUniversalTime(),
        Id = "e48f29b3-601b-4091-89c4-edf21690f879",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T16:18:37.115Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2026-01-06T12:28:11.888Z").ToUniversalTime(),
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

## CreateAdsCreative

Creates a AdsCreative. Provide the unified AdsCreative fields in the request body; they are mapped to the provider's API. Returns the created AdsCreative.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsCreative" method="post" path="/ads/{connection_id}/creative" example="ads_creative" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.CreateAdsCreativeAsync(
    adsCreative: new AdsCreative() {
        CreatedAt = System.DateTime.Parse("2020-02-17T11:24:51.093Z").ToUniversalTime(),
        Id = "ed82936a-3de5-45d3-ad2c-6e317a0101a7",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-28T23:43:08.462Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsCreative`                                                                                                                                    | [AdsCreative](../../Models/Components/AdsCreative.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsCreativeQueryParamFields](../../Models/Requests/CreateAdsCreativeQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsCreativeResponse](../../Models/Requests/CreateAdsCreativeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAdsGroup

Creates a AdsGroup. Provide the unified AdsGroup fields in the request body; they are mapped to the provider's API. Returns the created AdsGroup.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsGroup" method="post" path="/ads/{connection_id}/group" example="ads_group" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.CreateAdsGroupAsync(
    adsGroup: new AdsGroup() {
        BidAmount = 26.16030164062977D,
        BudgetAmount = 5099.175239447504D,
        BudgetPeriod = AdsGroupBudgetPeriod.Monthly,
        CreatedAt = System.DateTime.Parse("2019-08-29T17:59:41.045Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = AdsGroupEffectiveStatus.Paused,
        EndAt = System.DateTime.Parse("2026-06-30T19:34:42.229Z").ToUniversalTime(),
        Id = "cea741b3-6dce-41e3-886d-df470f431238",
        LanguageLocale = "fr-FR",
        Metadata = new List<AdsMetadata>() {},
        Name = "Stark - Baumbach",
        StartAt = System.DateTime.Parse("2026-01-14T15:34:43.854Z").ToUniversalTime(),
        Status = AdsGroupStatus.Processing,
        Targeting = new PropertyAdsGroupTargeting() {},
        UpdatedAt = System.DateTime.Parse("2022-01-15T16:18:33.274Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsGroup`                                                                                                                                       | [AdsGroup](../../Models/Components/AdsGroup.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsGroupQueryParamFields](../../Models/Requests/CreateAdsGroupQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsGroupResponse](../../Models/Requests/CreateAdsGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAdsInsertionorder

Creates a AdsInsertionorder. Provide the unified AdsInsertionorder fields in the request body; they are mapped to the provider's API. Returns the created AdsInsertionorder.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsInsertionorder" method="post" path="/ads/{connection_id}/insertionorder" example="ads_insertionorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.CreateAdsInsertionorderAsync(
    adsInsertionorder: new AdsInsertionorder() {
        CreatedAt = System.DateTime.Parse("2021-04-10T06:57:36.611Z").ToUniversalTime(),
        Id = "b2b49201-549c-45b5-84e6-58513ee215fc",
        Metadata = new List<AdsMetadata>() {},
        Name = "Kunde, Smith and Reinger",
        Status = AdsInsertionorderStatus.Unspecified,
        UpdatedAt = System.DateTime.Parse("2021-04-28T21:07:04.436Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsInsertionorder`                                                                                                                              | [AdsInsertionorder](../../Models/Components/AdsInsertionorder.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsInsertionorderQueryParamFields](../../Models/Requests/CreateAdsInsertionorderQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsInsertionorderResponse](../../Models/Requests/CreateAdsInsertionorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAdsOrganization

Creates a AdsOrganization. Provide the unified AdsOrganization fields in the request body; they are mapped to the provider's API. Returns the created AdsOrganization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsOrganization" method="post" path="/ads/{connection_id}/organization" example="ads_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.CreateAdsOrganizationAsync(
    adsOrganization: new AdsOrganization() {
        AccountNumber = "LQUJx8zQBW",
        CreatedAt = System.DateTime.Parse("2020-07-23T21:47:11.440Z").ToUniversalTime(),
        Currency = "USD",
        Id = "46e84d78-e4f9-4128-9160-89459ede1e0d",
        Managers = new List<AdsManager>() {},
        Metadata = new List<AdsMetadata>() {},
        Name = "Ankunding Inc",
        Status = AdsOrganizationStatus.Processing,
        Timezone = "Europe/Chisinau",
        UpdatedAt = System.DateTime.Parse("2026-04-03T14:33:35.542Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsOrganization`                                                                                                                                | [AdsOrganization](../../Models/Components/AdsOrganization.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsOrganizationQueryParamFields](../../Models/Requests/CreateAdsOrganizationQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsOrganizationResponse](../../Models/Requests/CreateAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsAd

Retrieves a single AdsAd by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsAd" method="get" path="/ads/{connection_id}/ad/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsAdAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Ad                                                                                                                                     |
| `Fields`                                                                                                                                         | List<[GetAdsAdQueryParamFields](../../Models/Requests/GetAdsAdQueryParamFields.md)>                                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsAdResponse](../../Models/Requests/GetAdsAdResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsAsset

Retrieves a single AdsAsset by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsAsset" method="get" path="/ads/{connection_id}/asset/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsAssetAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Asset                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAdsAssetQueryParamFields](../../Models/Requests/GetAdsAssetQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsAssetResponse](../../Models/Requests/GetAdsAssetResponse.md)**

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

var res = await sdk.Ads.GetAdsCampaignAsync(
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

## GetAdsCreative

Retrieves a single AdsCreative by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsCreative" method="get" path="/ads/{connection_id}/creative/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsCreativeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Creative                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAdsCreativeQueryParamFields](../../Models/Requests/GetAdsCreativeQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsCreativeResponse](../../Models/Requests/GetAdsCreativeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsGroup

Retrieves a single AdsGroup by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsGroup" method="get" path="/ads/{connection_id}/group/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsGroupAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Group                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAdsGroupQueryParamFields](../../Models/Requests/GetAdsGroupQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsGroupResponse](../../Models/Requests/GetAdsGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsInsertionorder

Retrieves a single AdsInsertionorder by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsInsertionorder" method="get" path="/ads/{connection_id}/insertionorder/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsInsertionorderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Insertionorder                                                                                                                         |
| `Fields`                                                                                                                                         | List<[GetAdsInsertionorderQueryParamFields](../../Models/Requests/GetAdsInsertionorderQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsInsertionorderResponse](../../Models/Requests/GetAdsInsertionorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsOrganization

Retrieves a single AdsOrganization by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsOrganization" method="get" path="/ads/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsOrganizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Organization                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetAdsOrganizationQueryParamFields](../../Models/Requests/GetAdsOrganizationQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsOrganizationResponse](../../Models/Requests/GetAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsPromoted

Retrieves a single AdsPromoted by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsPromoted" method="get" path="/ads/{connection_id}/promoted/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsPromotedAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Promoted                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAdsPromotedQueryParamFields](../../Models/Requests/GetAdsPromotedQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsPromotedResponse](../../Models/Requests/GetAdsPromotedResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsTarget

Retrieves a single AdsTarget by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsTarget" method="get" path="/ads/{connection_id}/target/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.GetAdsTargetAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Target                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetAdsTargetQueryParamFields](../../Models/Requests/GetAdsTargetQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsTargetResponse](../../Models/Requests/GetAdsTargetResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsAds

Returns a list of AdsAds. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsAds" method="get" path="/ads/{connection_id}/ad" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsAdsRequest req = new ListAdsAdsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsAdsAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListAdsAdsRequest](../../Models/Requests/ListAdsAdsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[ListAdsAdsResponse](../../Models/Requests/ListAdsAdsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsAssets

Returns a list of AdsAssets. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsAssets" method="get" path="/ads/{connection_id}/asset" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsAssetsRequest req = new ListAdsAssetsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsAssetsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListAdsAssetsRequest](../../Models/Requests/ListAdsAssetsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListAdsAssetsResponse](../../Models/Requests/ListAdsAssetsResponse.md)**

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

var res = await sdk.Ads.ListAdsCampaignsAsync(req);

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

## ListAdsCreatives

Returns a list of AdsCreatives. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsCreatives" method="get" path="/ads/{connection_id}/creative" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsCreativesRequest req = new ListAdsCreativesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsCreativesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAdsCreativesRequest](../../Models/Requests/ListAdsCreativesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListAdsCreativesResponse](../../Models/Requests/ListAdsCreativesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsGroups

Returns a list of AdsGroups. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsGroups" method="get" path="/ads/{connection_id}/group" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsGroupsRequest req = new ListAdsGroupsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsGroupsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListAdsGroupsRequest](../../Models/Requests/ListAdsGroupsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListAdsGroupsResponse](../../Models/Requests/ListAdsGroupsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsInsertionorders

Returns a list of AdsInsertionorders. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsInsertionorders" method="get" path="/ads/{connection_id}/insertionorder" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsInsertionordersRequest req = new ListAdsInsertionordersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsInsertionordersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAdsInsertionordersRequest](../../Models/Requests/ListAdsInsertionordersRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAdsInsertionordersResponse](../../Models/Requests/ListAdsInsertionordersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsOrganizations

Returns a list of AdsOrganizations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsOrganizations" method="get" path="/ads/{connection_id}/organization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsOrganizationsRequest req = new ListAdsOrganizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListAdsOrganizationsRequest](../../Models/Requests/ListAdsOrganizationsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListAdsOrganizationsResponse](../../Models/Requests/ListAdsOrganizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsPromoteds

Returns a list of AdsPromoteds. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsPromoteds" method="get" path="/ads/{connection_id}/promoted" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsPromotedsRequest req = new ListAdsPromotedsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsPromotedsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAdsPromotedsRequest](../../Models/Requests/ListAdsPromotedsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListAdsPromotedsResponse](../../Models/Requests/ListAdsPromotedsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsReports

Returns a list of AdsReports. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsReports" method="get" path="/ads/{connection_id}/report" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsReportsRequest req = new ListAdsReportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsReportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListAdsReportsRequest](../../Models/Requests/ListAdsReportsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListAdsReportsResponse](../../Models/Requests/ListAdsReportsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsTargets

Returns a list of AdsTargets. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsTargets" method="get" path="/ads/{connection_id}/target" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsTargetsRequest req = new ListAdsTargetsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ads.ListAdsTargetsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListAdsTargetsRequest](../../Models/Requests/ListAdsTargetsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListAdsTargetsResponse](../../Models/Requests/ListAdsTargetsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsAd

Updates the AdsAd identified by `id`. Provide the unified AdsAd fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsAd" method="patch" path="/ads/{connection_id}/ad/{id}" example="ads_ad" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsAdRequest req = new PatchAdsAdRequest() {
    AdsAd = new AdsAd() {
        AdCopy = "Ascisco tolero caute sapiente. Valens unde comedo cursus crinis nobis thema. Cohaero nisi ullam tum unde ultio vilicus auditor capio.",
        AdType = AdType.Social,
        AdvertiserName = "Robel, Nader and Rau",
        CreatedAt = System.DateTime.Parse("2022-11-08T03:38:20.978Z").ToUniversalTime(),
        CreativeAssetUrl = "https://picsum.photos/seed/LwOzrpr9/948/2793",
        Description = "Accedo vespillo carpo dolor decet stillicidium comptus tenuis.",
        FinalUrl = "https://improbable-sanity.com",
        Id = "4f634ca5-9ef0-45c6-8169-8a1d01db32e8",
        Metadata = new List<AdsMetadata>() {},
        Name = "Hermiston Group",
        Status = AdsAdStatus.Archived,
        UpdatedAt = System.DateTime.Parse("2024-06-21T00:36:08.311Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.PatchAdsAdAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [PatchAdsAdRequest](../../Models/Requests/PatchAdsAdRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[PatchAdsAdResponse](../../Models/Requests/PatchAdsAdResponse.md)**

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
        EndAt = System.DateTime.Parse("2025-06-05T02:37:25.828Z").ToUniversalTime(),
        Id = "b1a707a8-59bc-4d2f-aa56-3fc7d9c6ebca",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T16:18:37.121Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2026-01-06T12:28:12.031Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.PatchAdsCampaignAsync(req);

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

## PatchAdsCreative

Updates the AdsCreative identified by `id`. Provide the unified AdsCreative fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsCreative" method="patch" path="/ads/{connection_id}/creative/{id}" example="ads_creative" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsCreativeRequest req = new PatchAdsCreativeRequest() {
    AdsCreative = new AdsCreative() {
        CreatedAt = System.DateTime.Parse("2020-02-17T11:24:51.093Z").ToUniversalTime(),
        Id = "4a686004-a240-44dc-93eb-31363ec1bbcc",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-28T23:43:08.471Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.PatchAdsCreativeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchAdsCreativeRequest](../../Models/Requests/PatchAdsCreativeRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchAdsCreativeResponse](../../Models/Requests/PatchAdsCreativeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsGroup

Updates the AdsGroup identified by `id`. Provide the unified AdsGroup fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsGroup" method="patch" path="/ads/{connection_id}/group/{id}" example="ads_group" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsGroupRequest req = new PatchAdsGroupRequest() {
    AdsGroup = new AdsGroup() {
        BidAmount = 26.16030164062977D,
        BudgetAmount = 5099.175239447504D,
        BudgetPeriod = AdsGroupBudgetPeriod.Monthly,
        CreatedAt = System.DateTime.Parse("2019-08-29T17:59:41.045Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = AdsGroupEffectiveStatus.Paused,
        EndAt = System.DateTime.Parse("2026-06-30T19:34:42.379Z").ToUniversalTime(),
        Id = "cdba80c1-4b34-4aa9-b4de-b0d70fb7c651",
        LanguageLocale = "fr-FR",
        Metadata = new List<AdsMetadata>() {},
        Name = "Stark - Baumbach",
        StartAt = System.DateTime.Parse("2026-01-14T15:34:43.994Z").ToUniversalTime(),
        Status = AdsGroupStatus.Processing,
        Targeting = new PropertyAdsGroupTargeting() {},
        UpdatedAt = System.DateTime.Parse("2022-01-15T16:18:33.326Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.PatchAdsGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchAdsGroupRequest](../../Models/Requests/PatchAdsGroupRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchAdsGroupResponse](../../Models/Requests/PatchAdsGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsInsertionorder

Updates the AdsInsertionorder identified by `id`. Provide the unified AdsInsertionorder fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsInsertionorder" method="patch" path="/ads/{connection_id}/insertionorder/{id}" example="ads_insertionorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsInsertionorderRequest req = new PatchAdsInsertionorderRequest() {
    AdsInsertionorder = new AdsInsertionorder() {
        CreatedAt = System.DateTime.Parse("2021-04-10T06:57:36.611Z").ToUniversalTime(),
        Id = "1d49fe0a-e2b7-430f-95e1-2c5d98adf419",
        Metadata = new List<AdsMetadata>() {},
        Name = "Kunde, Smith and Reinger",
        Status = AdsInsertionorderStatus.Unspecified,
        UpdatedAt = System.DateTime.Parse("2021-04-28T21:07:04.436Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.PatchAdsInsertionorderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAdsInsertionorderRequest](../../Models/Requests/PatchAdsInsertionorderRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAdsInsertionorderResponse](../../Models/Requests/PatchAdsInsertionorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsOrganization

Updates the AdsOrganization identified by `id`. Provide the unified AdsOrganization fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsOrganization" method="patch" path="/ads/{connection_id}/organization/{id}" example="ads_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsOrganizationRequest req = new PatchAdsOrganizationRequest() {
    AdsOrganization = new AdsOrganization() {
        AccountNumber = "LQUJx8zQBW",
        CreatedAt = System.DateTime.Parse("2020-07-23T21:47:11.440Z").ToUniversalTime(),
        Currency = "USD",
        Id = "f2b15c5c-9fa7-41f5-962c-282287052268",
        Managers = new List<AdsManager>() {},
        Metadata = new List<AdsMetadata>() {},
        Name = "Ankunding Inc",
        Status = AdsOrganizationStatus.Processing,
        Timezone = "Europe/Chisinau",
        UpdatedAt = System.DateTime.Parse("2026-04-03T14:33:35.560Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.PatchAdsOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchAdsOrganizationRequest](../../Models/Requests/PatchAdsOrganizationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchAdsOrganizationResponse](../../Models/Requests/PatchAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsAd

Deletes the AdsAd identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsAd" method="delete" path="/ads/{connection_id}/ad/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.RemoveAdsAdAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Ad         |

### Response

**[RemoveAdsAdResponse](../../Models/Requests/RemoveAdsAdResponse.md)**

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

var res = await sdk.Ads.RemoveAdsCampaignAsync(
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

## RemoveAdsCreative

Deletes the AdsCreative identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsCreative" method="delete" path="/ads/{connection_id}/creative/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.RemoveAdsCreativeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Creative   |

### Response

**[RemoveAdsCreativeResponse](../../Models/Requests/RemoveAdsCreativeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsGroup

Deletes the AdsGroup identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsGroup" method="delete" path="/ads/{connection_id}/group/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.RemoveAdsGroupAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Group      |

### Response

**[RemoveAdsGroupResponse](../../Models/Requests/RemoveAdsGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsInsertionorder

Deletes the AdsInsertionorder identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsInsertionorder" method="delete" path="/ads/{connection_id}/insertionorder/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.RemoveAdsInsertionorderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `ConnectionId`           | *string*                 | :heavy_check_mark:       | ID of the connection     |
| `Id`                     | *string*                 | :heavy_check_mark:       | ID of the Insertionorder |

### Response

**[RemoveAdsInsertionorderResponse](../../Models/Requests/RemoveAdsInsertionorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsOrganization

Deletes the AdsOrganization identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsOrganization" method="delete" path="/ads/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ads.RemoveAdsOrganizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Organization |

### Response

**[RemoveAdsOrganizationResponse](../../Models/Requests/RemoveAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsAd

Updates the AdsAd identified by `id`. Provide the unified AdsAd fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsAd" method="put" path="/ads/{connection_id}/ad/{id}" example="ads_ad" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsAdRequest req = new UpdateAdsAdRequest() {
    AdsAd = new AdsAd() {
        AdCopy = "Ascisco tolero caute sapiente. Valens unde comedo cursus crinis nobis thema. Cohaero nisi ullam tum unde ultio vilicus auditor capio.",
        AdType = AdType.Social,
        AdvertiserName = "Robel, Nader and Rau",
        CreatedAt = System.DateTime.Parse("2022-11-08T03:38:20.978Z").ToUniversalTime(),
        CreativeAssetUrl = "https://picsum.photos/seed/LwOzrpr9/948/2793",
        Description = "Accedo vespillo carpo dolor decet stillicidium comptus tenuis.",
        FinalUrl = "https://improbable-sanity.com",
        Id = "4f634ca5-9ef0-45c6-8169-8a1d01db32e8",
        Metadata = new List<AdsMetadata>() {},
        Name = "Hermiston Group",
        Status = AdsAdStatus.Archived,
        UpdatedAt = System.DateTime.Parse("2024-06-21T00:36:08.311Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.UpdateAdsAdAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [UpdateAdsAdRequest](../../Models/Requests/UpdateAdsAdRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[UpdateAdsAdResponse](../../Models/Requests/UpdateAdsAdResponse.md)**

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
        EndAt = System.DateTime.Parse("2025-06-05T02:37:25.828Z").ToUniversalTime(),
        Id = "b1a707a8-59bc-4d2f-aa56-3fc7d9c6ebca",
        Labels = new List<string>() {
            "comedo",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Emard Inc",
        StartAt = System.DateTime.Parse("2022-07-21T16:18:37.121Z").ToUniversalTime(),
        Status = AdsCampaignStatus.ProcessingFailed,
        Targeting = new PropertyAdsCampaignTargeting() {},
        TotalSpendAmount = 2349.8642875347286D,
        UpdatedAt = System.DateTime.Parse("2026-01-06T12:28:12.031Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.UpdateAdsCampaignAsync(req);

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

## UpdateAdsCreative

Updates the AdsCreative identified by `id`. Provide the unified AdsCreative fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsCreative" method="put" path="/ads/{connection_id}/creative/{id}" example="ads_creative" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsCreativeRequest req = new UpdateAdsCreativeRequest() {
    AdsCreative = new AdsCreative() {
        CreatedAt = System.DateTime.Parse("2020-02-17T11:24:51.093Z").ToUniversalTime(),
        Id = "4a686004-a240-44dc-93eb-31363ec1bbcc",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-28T23:43:08.471Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.UpdateAdsCreativeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateAdsCreativeRequest](../../Models/Requests/UpdateAdsCreativeRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateAdsCreativeResponse](../../Models/Requests/UpdateAdsCreativeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsGroup

Updates the AdsGroup identified by `id`. Provide the unified AdsGroup fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsGroup" method="put" path="/ads/{connection_id}/group/{id}" example="ads_group" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsGroupRequest req = new UpdateAdsGroupRequest() {
    AdsGroup = new AdsGroup() {
        BidAmount = 26.16030164062977D,
        BudgetAmount = 5099.175239447504D,
        BudgetPeriod = AdsGroupBudgetPeriod.Monthly,
        CreatedAt = System.DateTime.Parse("2019-08-29T17:59:41.045Z").ToUniversalTime(),
        Currency = "USD",
        EffectiveStatus = AdsGroupEffectiveStatus.Paused,
        EndAt = System.DateTime.Parse("2026-06-30T19:34:42.379Z").ToUniversalTime(),
        Id = "cdba80c1-4b34-4aa9-b4de-b0d70fb7c651",
        LanguageLocale = "fr-FR",
        Metadata = new List<AdsMetadata>() {},
        Name = "Stark - Baumbach",
        StartAt = System.DateTime.Parse("2026-01-14T15:34:43.994Z").ToUniversalTime(),
        Status = AdsGroupStatus.Processing,
        Targeting = new PropertyAdsGroupTargeting() {},
        UpdatedAt = System.DateTime.Parse("2022-01-15T16:18:33.326Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.UpdateAdsGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateAdsGroupRequest](../../Models/Requests/UpdateAdsGroupRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateAdsGroupResponse](../../Models/Requests/UpdateAdsGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsInsertionorder

Updates the AdsInsertionorder identified by `id`. Provide the unified AdsInsertionorder fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsInsertionorder" method="put" path="/ads/{connection_id}/insertionorder/{id}" example="ads_insertionorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsInsertionorderRequest req = new UpdateAdsInsertionorderRequest() {
    AdsInsertionorder = new AdsInsertionorder() {
        CreatedAt = System.DateTime.Parse("2021-04-10T06:57:36.611Z").ToUniversalTime(),
        Id = "1d49fe0a-e2b7-430f-95e1-2c5d98adf419",
        Metadata = new List<AdsMetadata>() {},
        Name = "Kunde, Smith and Reinger",
        Status = AdsInsertionorderStatus.Unspecified,
        UpdatedAt = System.DateTime.Parse("2021-04-28T21:07:04.436Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.UpdateAdsInsertionorderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAdsInsertionorderRequest](../../Models/Requests/UpdateAdsInsertionorderRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAdsInsertionorderResponse](../../Models/Requests/UpdateAdsInsertionorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsOrganization

Updates the AdsOrganization identified by `id`. Provide the unified AdsOrganization fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsOrganization" method="put" path="/ads/{connection_id}/organization/{id}" example="ads_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsOrganizationRequest req = new UpdateAdsOrganizationRequest() {
    AdsOrganization = new AdsOrganization() {
        AccountNumber = "LQUJx8zQBW",
        CreatedAt = System.DateTime.Parse("2020-07-23T21:47:11.440Z").ToUniversalTime(),
        Currency = "USD",
        Id = "f2b15c5c-9fa7-41f5-962c-282287052268",
        Managers = new List<AdsManager>() {},
        Metadata = new List<AdsMetadata>() {},
        Name = "Ankunding Inc",
        Status = AdsOrganizationStatus.Processing,
        Timezone = "Europe/Chisinau",
        UpdatedAt = System.DateTime.Parse("2026-04-03T14:33:35.560Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ads.UpdateAdsOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateAdsOrganizationRequest](../../Models/Requests/UpdateAdsOrganizationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateAdsOrganizationResponse](../../Models/Requests/UpdateAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |