# Creative

## Overview

### Available Operations

* [CreateAdsCreative](#createadscreative) - Create a creative
* [GetAdsCreative](#getadscreative) - Retrieve a creative
* [ListAdsCreatives](#listadscreatives) - List all creatives
* [PatchAdsCreative](#patchadscreative) - Update a creative
* [RemoveAdsCreative](#removeadscreative) - Remove a creative
* [UpdateAdsCreative](#updateadscreative) - Update a creative

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

var res = await sdk.Creative.CreateAdsCreativeAsync(
    adsCreative: new AdsCreative() {
        CreatedAt = System.DateTime.Parse("2020-02-17T11:24:51.093Z").ToUniversalTime(),
        Id = "bcd16e0d-e681-45ac-8ad4-fa33dca697d6",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-27T22:44:59.563Z").ToUniversalTime(),
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

var res = await sdk.Creative.GetAdsCreativeAsync(
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

var res = await sdk.Creative.ListAdsCreativesAsync(req);

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
        Id = "b5b501af-f891-49a8-9f63-6e23612c9ab9",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-27T22:44:59.568Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Creative.PatchAdsCreativeAsync(req);

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

var res = await sdk.Creative.RemoveAdsCreativeAsync(
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
        Id = "b5b501af-f891-49a8-9f63-6e23612c9ab9",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Metadata = new List<AdsMetadata>() {},
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-27T22:44:59.568Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Creative.UpdateAdsCreativeAsync(req);

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