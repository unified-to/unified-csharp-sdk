# Creditmemo
(*Creditmemo*)

## Overview

### Available Operations

* [CreateAccountingCreditmemo2](#createaccountingcreditmemo2) - Create a creditmemo
* [GetAccountingCreditmemo2](#getaccountingcreditmemo2) - Retrieve a creditmemo
* [ListAccountingCreditmemoes2](#listaccountingcreditmemoes2) - List all creditmemoes
* [PatchAccountingCreditmemo2](#patchaccountingcreditmemo2) - Update a creditmemo
* [RemoveAccountingCreditmemo2](#removeaccountingcreditmemo2) - Remove a creditmemo
* [UpdateAccountingCreditmemo2](#updateaccountingcreditmemo2) - Update a creditmemo

## CreateAccountingCreditmemo2

Create a creditmemo

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Creditmemo.CreateAccountingCreditmemo2Async(
    accountingCreditmemo: new AccountingCreditmemo() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingCreditmemo`                                                                                                                           | [AccountingCreditmemo](../../Models/Components/AccountingCreditmemo.md)                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingCreditmemo2QueryParamFields](../../Models/Requests/CreateAccountingCreditmemo2QueryParamFields.md)>                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingCreditmemo2Response](../../Models/Requests/CreateAccountingCreditmemo2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingCreditmemo2

Retrieve a creditmemo

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Creditmemo.GetAccountingCreditmemo2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Creditmemo                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetAccountingCreditmemo2QueryParamFields](../../Models/Requests/GetAccountingCreditmemo2QueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingCreditmemo2Response](../../Models/Requests/GetAccountingCreditmemo2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingCreditmemoes2

List all creditmemoes

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingCreditmemoes2Request req = new ListAccountingCreditmemoes2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Creditmemo.ListAccountingCreditmemoes2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListAccountingCreditmemoes2Request](../../Models/Requests/ListAccountingCreditmemoes2Request.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListAccountingCreditmemoes2Response](../../Models/Requests/ListAccountingCreditmemoes2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingCreditmemo2

Update a creditmemo

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingCreditmemo2Request req = new PatchAccountingCreditmemo2Request() {
    AccountingCreditmemo = new AccountingCreditmemo() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Creditmemo.PatchAccountingCreditmemo2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [PatchAccountingCreditmemo2Request](../../Models/Requests/PatchAccountingCreditmemo2Request.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[PatchAccountingCreditmemo2Response](../../Models/Requests/PatchAccountingCreditmemo2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingCreditmemo2

Remove a creditmemo

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Creditmemo.RemoveAccountingCreditmemo2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Creditmemo |

### Response

**[RemoveAccountingCreditmemo2Response](../../Models/Requests/RemoveAccountingCreditmemo2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingCreditmemo2

Update a creditmemo

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingCreditmemo2Request req = new UpdateAccountingCreditmemo2Request() {
    AccountingCreditmemo = new AccountingCreditmemo() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Creditmemo.UpdateAccountingCreditmemo2Async(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [UpdateAccountingCreditmemo2Request](../../Models/Requests/UpdateAccountingCreditmemo2Request.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[UpdateAccountingCreditmemo2Response](../../Models/Requests/UpdateAccountingCreditmemo2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |