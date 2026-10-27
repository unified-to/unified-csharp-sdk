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

Creates a AccountingPurchaseorder. Provide the unified AccountingPurchaseorder fields in the request body; they are mapped to the provider's API. Returns the created AccountingPurchaseorder.

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
        Attachments = new List<AccountingAttachment>() {},
        BillingAddress = new PropertyAccountingPurchaseorderBillingAddress() {
            Address1 = "72142 Willow Street",
            Address2 = "Apt. 967",
            City = "South Annabelleton",
            CountryCode = "US",
            PostalCode = "30337",
            Region = "Nevada",
            RegionCode = "FL",
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        Currency = "EUR",
        Id = "bbcdbd7e-5a11-4ede-abb5-7d1cbe712425",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingPurchaseorderShippingAddress() {
            Address1 = "76494 Medhurst Club",
            City = "Kshlerinfurt",
            CountryCode = "US",
            PostalCode = "92116-5474",
            Region = "Oregon",
            RegionCode = "WY",
        },
        Status = AccountingPurchaseorderStatus.Submitted,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2021-08-11T22:21:25.175Z").ToUniversalTime(),
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

Retrieves a single AccountingPurchaseorder by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AccountingPurchaseorders. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the AccountingPurchaseorder identified by `id`. Provide the unified AccountingPurchaseorder fields to change in the request body.

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
        Attachments = new List<AccountingAttachment>() {},
        BillingAddress = new PropertyAccountingPurchaseorderBillingAddress() {
            Address1 = "72142 Willow Street",
            Address2 = "Apt. 967",
            City = "South Annabelleton",
            CountryCode = "US",
            PostalCode = "30337",
            Region = "Nevada",
            RegionCode = "FL",
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        Currency = "EUR",
        Id = "9b7483eb-86ed-41fb-8206-78f6dee48cbe",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingPurchaseorderShippingAddress() {
            Address1 = "76494 Medhurst Club",
            City = "Kshlerinfurt",
            CountryCode = "US",
            PostalCode = "92116-5474",
            Region = "Oregon",
            RegionCode = "WY",
        },
        Status = AccountingPurchaseorderStatus.Submitted,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2021-08-11T22:21:25.181Z").ToUniversalTime(),
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

Deletes the AccountingPurchaseorder identified by `id`.

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

Updates the AccountingPurchaseorder identified by `id`. Provide the unified AccountingPurchaseorder fields to change in the request body.

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
        Attachments = new List<AccountingAttachment>() {},
        BillingAddress = new PropertyAccountingPurchaseorderBillingAddress() {
            Address1 = "72142 Willow Street",
            Address2 = "Apt. 967",
            City = "South Annabelleton",
            CountryCode = "US",
            PostalCode = "30337",
            Region = "Nevada",
            RegionCode = "FL",
        },
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        Currency = "EUR",
        Id = "9b7483eb-86ed-41fb-8206-78f6dee48cbe",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2020-12-12T07:17:47.021Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingPurchaseorderShippingAddress() {
            Address1 = "76494 Medhurst Club",
            City = "Kshlerinfurt",
            CountryCode = "US",
            PostalCode = "92116-5474",
            Region = "Oregon",
            RegionCode = "WY",
        },
        Status = AccountingPurchaseorderStatus.Submitted,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2021-08-11T22:21:25.181Z").ToUniversalTime(),
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