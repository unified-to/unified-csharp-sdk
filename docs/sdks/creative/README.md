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

Create a creative

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
        Id = "5dd7b3ce-88d6-4c92-965d-a4f57ced5201",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-21T01:01:35.446Z").ToUniversalTime(),
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

Retrieve a creative

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

List all creatives

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

Update a creative

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
        Id = "d118ec82-e89d-4441-8941-08ef9518487f",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-21T01:01:35.450Z").ToUniversalTime(),
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

Remove a creative

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

Update a creative

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
        Id = "d118ec82-e89d-4441-8941-08ef9518487f",
        Labels = new List<string>() {
            "coma",
            "accedo",
            "termes",
        },
        Name = "Brekke, Bradtke and Robel",
        Status = AdsCreativeStatus.Paused,
        UpdatedAt = System.DateTime.Parse("2021-06-21T01:01:35.450Z").ToUniversalTime(),
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