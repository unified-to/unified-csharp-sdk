# Insertionorder

## Overview

### Available Operations

* [CreateAdsInsertionorder](#createadsinsertionorder) - Create an insertionorder
* [GetAdsInsertionorder](#getadsinsertionorder) - Retrieve an insertionorder
* [ListAdsInsertionorders](#listadsinsertionorders) - List all insertionorders
* [PatchAdsInsertionorder](#patchadsinsertionorder) - Update an insertionorder
* [RemoveAdsInsertionorder](#removeadsinsertionorder) - Remove an insertionorder
* [UpdateAdsInsertionorder](#updateadsinsertionorder) - Update an insertionorder

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

var res = await sdk.Insertionorder.CreateAdsInsertionorderAsync(
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

var res = await sdk.Insertionorder.GetAdsInsertionorderAsync(
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

var res = await sdk.Insertionorder.ListAdsInsertionordersAsync(req);

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

var res = await sdk.Insertionorder.PatchAdsInsertionorderAsync(req);

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

var res = await sdk.Insertionorder.RemoveAdsInsertionorderAsync(
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

var res = await sdk.Insertionorder.UpdateAdsInsertionorderAsync(req);

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