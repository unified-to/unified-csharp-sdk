# Ad

## Overview

### Available Operations

* [CreateAdsAd](#createadsad) - Create an ad
* [GetAdsAd](#getadsad) - Retrieve an ad
* [ListAdsAds](#listadsads) - List all ads
* [PatchAdsAd](#patchadsad) - Update an ad
* [RemoveAdsAd](#removeadsad) - Remove an ad
* [UpdateAdsAd](#updateadsad) - Update an ad

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

var res = await sdk.Ad.CreateAdsAdAsync(
    adsAd: new AdsAd() {
        AdCopy = "Ascisco tolero caute sapiente. Valens unde comedo cursus crinis nobis thema. Cohaero nisi ullam tum unde ultio vilicus auditor capio.",
        AdType = AdType.Social,
        AdvertiserName = "Robel, Nader and Rau",
        CreatedAt = System.DateTime.Parse("2022-11-08T03:38:20.978Z").ToUniversalTime(),
        CreativeAssetUrl = "https://picsum.photos/seed/LwOzrpr9/948/2793",
        Description = "Accedo vespillo carpo dolor decet stillicidium comptus tenuis.",
        FinalUrl = "https://improbable-sanity.com",
        Id = "1ce0d64f-d72d-4158-84c6-a824bf725093",
        Metadata = new List<AdsMetadata>() {},
        Name = "Hermiston Group",
        Status = AdsAdStatus.Archived,
        UpdatedAt = System.DateTime.Parse("2024-06-20T13:46:04.840Z").ToUniversalTime(),
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

var res = await sdk.Ad.GetAdsAdAsync(
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

var res = await sdk.Ad.ListAdsAdsAsync(req);

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
        Id = "86abcc8e-f5a3-4760-8ceb-f32262ada37d",
        Metadata = new List<AdsMetadata>() {},
        Name = "Hermiston Group",
        Status = AdsAdStatus.Archived,
        UpdatedAt = System.DateTime.Parse("2024-06-20T13:46:04.853Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ad.PatchAdsAdAsync(req);

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

var res = await sdk.Ad.RemoveAdsAdAsync(
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
        Id = "86abcc8e-f5a3-4760-8ceb-f32262ada37d",
        Metadata = new List<AdsMetadata>() {},
        Name = "Hermiston Group",
        Status = AdsAdStatus.Archived,
        UpdatedAt = System.DateTime.Parse("2024-06-20T13:46:04.853Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ad.UpdateAdsAdAsync(req);

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