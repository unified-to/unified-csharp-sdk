# Campaign
(*Campaign*)

## Overview

### Available Operations

* [CreateAdsCampaign2](#createadscampaign2) - Create a campaign
* [CreateMartechCampaign2](#createmartechcampaign2) - Create a campaign
* [GetAdsCampaign2](#getadscampaign2) - Retrieve a campaign
* [GetMartechCampaign2](#getmartechcampaign2) - Retrieve a campaign
* [ListAdsCampaigns2](#listadscampaigns2) - List all campaigns
* [ListMartechCampaigns2](#listmartechcampaigns2) - List all campaigns
* [PatchAdsCampaign2](#patchadscampaign2) - Update a campaign
* [PatchMartechCampaign2](#patchmartechcampaign2) - Update a campaign
* [RemoveAdsCampaign2](#removeadscampaign2) - Remove a campaign
* [RemoveMartechCampaign2](#removemartechcampaign2) - Remove a campaign
* [UpdateAdsCampaign2](#updateadscampaign2) - Update a campaign
* [UpdateMartechCampaign2](#updatemartechcampaign2) - Update a campaign

## CreateAdsCampaign2

Create a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.CreateAdsCampaign2Async(
    adsCampaign: new AdsCampaign() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsCampaign`                                                                                                                                    | [AdsCampaign](../../Models/Components/AdsCampaign.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsCampaign2QueryParamFields](../../Models/Requests/CreateAdsCampaign2QueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsCampaign2Response](../../Models/Requests/CreateAdsCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateMartechCampaign2

Create a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.CreateMartechCampaign2Async(
    marketingCampaign: new MarketingCampaign() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MarketingCampaign`                                                                                                                              | [MarketingCampaign](../../Models/Components/MarketingCampaign.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMartechCampaign2QueryParamFields](../../Models/Requests/CreateMartechCampaign2QueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMartechCampaign2Response](../../Models/Requests/CreateMartechCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsCampaign2

Retrieve a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.GetAdsCampaign2Async(
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
| `Fields`                                                                                                                                         | List<[GetAdsCampaign2QueryParamFields](../../Models/Requests/GetAdsCampaign2QueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsCampaign2Response](../../Models/Requests/GetAdsCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMartechCampaign2

Retrieve a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.GetMartechCampaign2Async(
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
| `Fields`                                                                                                                                         | List<[GetMartechCampaign2QueryParamFields](../../Models/Requests/GetMartechCampaign2QueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMartechCampaign2Response](../../Models/Requests/GetMartechCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsCampaigns2

List all campaigns

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsCampaigns2Request req = new ListAdsCampaigns2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Campaign.ListAdsCampaigns2Async(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAdsCampaigns2Request](../../Models/Requests/ListAdsCampaigns2Request.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAdsCampaigns2Response](../../Models/Requests/ListAdsCampaigns2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMartechCampaigns2

List all campaigns

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechCampaigns2Request req = new ListMartechCampaigns2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Campaign.ListMartechCampaigns2Async(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListMartechCampaigns2Request](../../Models/Requests/ListMartechCampaigns2Request.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListMartechCampaigns2Response](../../Models/Requests/ListMartechCampaigns2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsCampaign2

Update a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsCampaign2Request req = new PatchAdsCampaign2Request() {
    AdsCampaign = new AdsCampaign() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Campaign.PatchAdsCampaign2Async(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchAdsCampaign2Request](../../Models/Requests/PatchAdsCampaign2Request.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchAdsCampaign2Response](../../Models/Requests/PatchAdsCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMartechCampaign2

Update a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMartechCampaign2Request req = new PatchMartechCampaign2Request() {
    MarketingCampaign = new MarketingCampaign() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Campaign.PatchMartechCampaign2Async(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchMartechCampaign2Request](../../Models/Requests/PatchMartechCampaign2Request.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchMartechCampaign2Response](../../Models/Requests/PatchMartechCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsCampaign2

Remove a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.RemoveAdsCampaign2Async(
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

**[RemoveAdsCampaign2Response](../../Models/Requests/RemoveAdsCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMartechCampaign2

Remove a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Campaign.RemoveMartechCampaign2Async(
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

**[RemoveMartechCampaign2Response](../../Models/Requests/RemoveMartechCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsCampaign2

Update a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsCampaign2Request req = new UpdateAdsCampaign2Request() {
    AdsCampaign = new AdsCampaign() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Campaign.UpdateAdsCampaign2Async(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateAdsCampaign2Request](../../Models/Requests/UpdateAdsCampaign2Request.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateAdsCampaign2Response](../../Models/Requests/UpdateAdsCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMartechCampaign2

Update a campaign

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMartechCampaign2Request req = new UpdateMartechCampaign2Request() {
    MarketingCampaign = new MarketingCampaign() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Campaign.UpdateMartechCampaign2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateMartechCampaign2Request](../../Models/Requests/UpdateMartechCampaign2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateMartechCampaign2Response](../../Models/Requests/UpdateMartechCampaign2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |