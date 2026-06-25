# Insertionorder
(*Insertionorder*)

## Overview

### Available Operations

* [CreateAdsInsertionorder2](#createadsinsertionorder2) - Create an insertionorder
* [GetAdsInsertionorder2](#getadsinsertionorder2) - Retrieve an insertionorder
* [ListAdsInsertionorders2](#listadsinsertionorders2) - List all insertionorders
* [PatchAdsInsertionorder2](#patchadsinsertionorder2) - Update an insertionorder
* [RemoveAdsInsertionorder2](#removeadsinsertionorder2) - Remove an insertionorder
* [UpdateAdsInsertionorder2](#updateadsinsertionorder2) - Update an insertionorder

## CreateAdsInsertionorder2

Create an insertionorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Insertionorder.CreateAdsInsertionorder2Async(
    adsInsertionorder: new AdsInsertionorder() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsInsertionorder`                                                                                                                              | [AdsInsertionorder](../../Models/Components/AdsInsertionorder.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsInsertionorder2QueryParamFields](../../Models/Requests/CreateAdsInsertionorder2QueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsInsertionorder2Response](../../Models/Requests/CreateAdsInsertionorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsInsertionorder2

Retrieve an insertionorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Insertionorder.GetAdsInsertionorder2Async(
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
| `Fields`                                                                                                                                         | List<[GetAdsInsertionorder2QueryParamFields](../../Models/Requests/GetAdsInsertionorder2QueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsInsertionorder2Response](../../Models/Requests/GetAdsInsertionorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsInsertionorders2

List all insertionorders

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsInsertionorders2Request req = new ListAdsInsertionorders2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Insertionorder.ListAdsInsertionorders2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAdsInsertionorders2Request](../../Models/Requests/ListAdsInsertionorders2Request.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ListAdsInsertionorders2Response](../../Models/Requests/ListAdsInsertionorders2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsInsertionorder2

Update an insertionorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsInsertionorder2Request req = new PatchAdsInsertionorder2Request() {
    AdsInsertionorder = new AdsInsertionorder() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Insertionorder.PatchAdsInsertionorder2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [PatchAdsInsertionorder2Request](../../Models/Requests/PatchAdsInsertionorder2Request.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[PatchAdsInsertionorder2Response](../../Models/Requests/PatchAdsInsertionorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsInsertionorder2

Remove an insertionorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Insertionorder.RemoveAdsInsertionorder2Async(
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

**[RemoveAdsInsertionorder2Response](../../Models/Requests/RemoveAdsInsertionorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsInsertionorder2

Update an insertionorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsInsertionorder2Request req = new UpdateAdsInsertionorder2Request() {
    AdsInsertionorder = new AdsInsertionorder() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Insertionorder.UpdateAdsInsertionorder2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UpdateAdsInsertionorder2Request](../../Models/Requests/UpdateAdsInsertionorder2Request.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[UpdateAdsInsertionorder2Response](../../Models/Requests/UpdateAdsInsertionorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |