# Purchaseorder

## Overview

### Available Operations

* [CreateAccountingPurchaseorder](#createaccountingpurchaseorder) - Create a purchaseorder
* [GetAccountingPurchaseorder](#getaccountingpurchaseorder) - Retrieve a purchaseorder
* [ListAccountingPurchaseorders](#listaccountingpurchaseorders) - List all purchaseorders
* [PatchAccountingPurchaseorder](#patchaccountingpurchaseorder) - Update a purchaseorder
* [RemoveAccountingPurchaseorder](#removeaccountingpurchaseorder) - Remove a purchaseorder
* [UpdateAccountingPurchaseorder](#updateaccountingpurchaseorder) - Update a purchaseorder

## CreateAccountingPurchaseorder

Create a purchaseorder

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingPurchaseorder" method="post" path="/accounting/{connection_id}/purchaseorder" example="accounting_purchaseorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Purchaseorder.CreateAccountingPurchaseorderAsync(
    accountingPurchaseorder: new AccountingPurchaseorder() {
        BillingAddress = new PropertyAccountingPurchaseorderBillingAddress() {
            Address1 = "37214 Tanya Walks",
            City = "South Annabelleton",
            CountryCode = "US",
            PostalCode = "30337",
            Region = "Nevada",
            RegionCode = "MA",
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        Currency = "ZMW",
        Id = "2c15629f-d92a-450f-9a90-c739019fa131",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2025-04-27T06:22:37.375Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingPurchaseorderShippingAddress() {
            Address1 = "649 Maggio Overpass",
            City = "Lake Jaylan",
            CountryCode = "US",
            PostalCode = "99211-6547",
            Region = "North Carolina",
            RegionCode = "ID",
        },
        Status = AccountingPurchaseorderStatus.PartiallyRefunded,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2021-02-26T05:43:51.981Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingPurchaseorder`                                                                                                                        | [AccountingPurchaseorder](../../Models/Components/AccountingPurchaseorder.md)                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingPurchaseorderQueryParamFields](../../Models/Requests/CreateAccountingPurchaseorderQueryParamFields.md)>                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingPurchaseorderResponse](../../Models/Requests/CreateAccountingPurchaseorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingPurchaseorder

Retrieve a purchaseorder

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingPurchaseorder" method="get" path="/accounting/{connection_id}/purchaseorder/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Purchaseorder.GetAccountingPurchaseorderAsync(
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
| `Fields`                                                                                                                                         | List<[GetAccountingPurchaseorderQueryParamFields](../../Models/Requests/GetAccountingPurchaseorderQueryParamFields.md)>                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingPurchaseorderResponse](../../Models/Requests/GetAccountingPurchaseorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingPurchaseorders

List all purchaseorders

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingPurchaseorders" method="get" path="/accounting/{connection_id}/purchaseorder" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingPurchaseordersRequest req = new ListAccountingPurchaseordersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Purchaseorder.ListAccountingPurchaseordersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListAccountingPurchaseordersRequest](../../Models/Requests/ListAccountingPurchaseordersRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[ListAccountingPurchaseordersResponse](../../Models/Requests/ListAccountingPurchaseordersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingPurchaseorder

Update a purchaseorder

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingPurchaseorder" method="patch" path="/accounting/{connection_id}/purchaseorder/{id}" example="accounting_purchaseorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingPurchaseorderRequest req = new PatchAccountingPurchaseorderRequest() {
    AccountingPurchaseorder = new AccountingPurchaseorder() {
        BillingAddress = new PropertyAccountingPurchaseorderBillingAddress() {
            Address1 = "37214 Tanya Walks",
            City = "South Annabelleton",
            CountryCode = "US",
            PostalCode = "30337",
            Region = "Nevada",
            RegionCode = "MA",
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        Currency = "ZMW",
        Id = "ccae6f41-dac0-491f-9987-35fe17107580",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2025-04-27T06:22:37.417Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingPurchaseorderShippingAddress() {
            Address1 = "649 Maggio Overpass",
            City = "Lake Jaylan",
            CountryCode = "US",
            PostalCode = "99211-6547",
            Region = "North Carolina",
            RegionCode = "ID",
        },
        Status = AccountingPurchaseorderStatus.PartiallyRefunded,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2021-02-26T05:43:51.983Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Purchaseorder.PatchAccountingPurchaseorderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [PatchAccountingPurchaseorderRequest](../../Models/Requests/PatchAccountingPurchaseorderRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[PatchAccountingPurchaseorderResponse](../../Models/Requests/PatchAccountingPurchaseorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingPurchaseorder

Remove a purchaseorder

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingPurchaseorder" method="delete" path="/accounting/{connection_id}/purchaseorder/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Purchaseorder.RemoveAccountingPurchaseorderAsync(
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

**[RemoveAccountingPurchaseorderResponse](../../Models/Requests/RemoveAccountingPurchaseorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingPurchaseorder

Update a purchaseorder

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingPurchaseorder" method="put" path="/accounting/{connection_id}/purchaseorder/{id}" example="accounting_purchaseorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingPurchaseorderRequest req = new UpdateAccountingPurchaseorderRequest() {
    AccountingPurchaseorder = new AccountingPurchaseorder() {
        BillingAddress = new PropertyAccountingPurchaseorderBillingAddress() {
            Address1 = "37214 Tanya Walks",
            City = "South Annabelleton",
            CountryCode = "US",
            PostalCode = "30337",
            Region = "Nevada",
            RegionCode = "MA",
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        Currency = "ZMW",
        Id = "ccae6f41-dac0-491f-9987-35fe17107580",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2025-04-27T06:22:37.417Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingPurchaseorderShippingAddress() {
            Address1 = "649 Maggio Overpass",
            City = "Lake Jaylan",
            CountryCode = "US",
            PostalCode = "99211-6547",
            Region = "North Carolina",
            RegionCode = "ID",
        },
        Status = AccountingPurchaseorderStatus.PartiallyRefunded,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2021-02-26T05:43:51.983Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Purchaseorder.UpdateAccountingPurchaseorderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [UpdateAccountingPurchaseorderRequest](../../Models/Requests/UpdateAccountingPurchaseorderRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[UpdateAccountingPurchaseorderResponse](../../Models/Requests/UpdateAccountingPurchaseorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |