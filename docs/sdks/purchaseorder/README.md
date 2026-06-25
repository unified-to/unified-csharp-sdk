# Purchaseorder
(*Purchaseorder*)

## Overview

### Available Operations

* [CreateAccountingPurchaseorder2](#createaccountingpurchaseorder2) - Create a purchaseorder
* [GetAccountingPurchaseorder2](#getaccountingpurchaseorder2) - Retrieve a purchaseorder
* [ListAccountingPurchaseorders2](#listaccountingpurchaseorders2) - List all purchaseorders
* [PatchAccountingPurchaseorder2](#patchaccountingpurchaseorder2) - Update a purchaseorder
* [RemoveAccountingPurchaseorder2](#removeaccountingpurchaseorder2) - Remove a purchaseorder
* [UpdateAccountingPurchaseorder2](#updateaccountingpurchaseorder2) - Update a purchaseorder

## CreateAccountingPurchaseorder2

Create a purchaseorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Purchaseorder.CreateAccountingPurchaseorder2Async(
    accountingPurchaseorder: new AccountingPurchaseorder() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingPurchaseorder`                                                                                                                        | [AccountingPurchaseorder](../../Models/Components/AccountingPurchaseorder.md)                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingPurchaseorder2QueryParamFields](../../Models/Requests/CreateAccountingPurchaseorder2QueryParamFields.md)>                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingPurchaseorder2Response](../../Models/Requests/CreateAccountingPurchaseorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingPurchaseorder2

Retrieve a purchaseorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Purchaseorder.GetAccountingPurchaseorder2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Purchaseorder                                                                                                                          |
| `Fields`                                                                                                                                         | List<[GetAccountingPurchaseorder2QueryParamFields](../../Models/Requests/GetAccountingPurchaseorder2QueryParamFields.md)>                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingPurchaseorder2Response](../../Models/Requests/GetAccountingPurchaseorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingPurchaseorders2

List all purchaseorders

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingPurchaseorders2Request req = new ListAccountingPurchaseorders2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Purchaseorder.ListAccountingPurchaseorders2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListAccountingPurchaseorders2Request](../../Models/Requests/ListAccountingPurchaseorders2Request.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[ListAccountingPurchaseorders2Response](../../Models/Requests/ListAccountingPurchaseorders2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingPurchaseorder2

Update a purchaseorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingPurchaseorder2Request req = new PatchAccountingPurchaseorder2Request() {
    AccountingPurchaseorder = new AccountingPurchaseorder() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Purchaseorder.PatchAccountingPurchaseorder2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [PatchAccountingPurchaseorder2Request](../../Models/Requests/PatchAccountingPurchaseorder2Request.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[PatchAccountingPurchaseorder2Response](../../Models/Requests/PatchAccountingPurchaseorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingPurchaseorder2

Remove a purchaseorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Purchaseorder.RemoveAccountingPurchaseorder2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter               | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `ConnectionId`          | *string*                | :heavy_check_mark:      | ID of the connection    |
| `Id`                    | *string*                | :heavy_check_mark:      | ID of the Purchaseorder |

### Response

**[RemoveAccountingPurchaseorder2Response](../../Models/Requests/RemoveAccountingPurchaseorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingPurchaseorder2

Update a purchaseorder

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingPurchaseorder2Request req = new UpdateAccountingPurchaseorder2Request() {
    AccountingPurchaseorder = new AccountingPurchaseorder() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Purchaseorder.UpdateAccountingPurchaseorder2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateAccountingPurchaseorder2Request](../../Models/Requests/UpdateAccountingPurchaseorder2Request.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[UpdateAccountingPurchaseorder2Response](../../Models/Requests/UpdateAccountingPurchaseorder2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |