# Salesorder

## Overview

### Available Operations

* [CreateAccountingSalesorder](#createaccountingsalesorder) - Create a salesorder
* [GetAccountingSalesorder](#getaccountingsalesorder) - Retrieve a salesorder
* [ListAccountingSalesorders](#listaccountingsalesorders) - List all salesorders
* [PatchAccountingSalesorder](#patchaccountingsalesorder) - Update a salesorder
* [RemoveAccountingSalesorder](#removeaccountingsalesorder) - Remove a salesorder
* [UpdateAccountingSalesorder](#updateaccountingsalesorder) - Update a salesorder

## CreateAccountingSalesorder

Creates a AccountingSalesorder. Provide the unified AccountingSalesorder fields in the request body; they are mapped to the provider's API. Returns the created AccountingSalesorder.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingSalesorder" method="post" path="/accounting/{connection_id}/salesorder" example="accounting_salesorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Salesorder.CreateAccountingSalesorderAsync(
    accountingSalesorder: new AccountingSalesorder() {
        BillingAddress = new PropertyAccountingSalesorderBillingAddress() {
            Address1 = "26530 Stroman Rest",
            Address2 = "Suite 801",
            City = "Pocatello",
            CountryCode = "US",
            PostalCode = "05015-8546",
            Region = "Louisiana",
            RegionCode = "MO",
        },
        CategoryIds = new List<string>() {},
        ClosedAt = System.DateTime.Parse("2023-03-27T10:39:40.344Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        Currency = "USD",
        DiscountAmount = 0D,
        Fees = new List<AccountingFee>() {},
        FulfillmentType = FulfillmentType.Other,
        Id = "f8ae4bb2-a81e-47f2-b0c2-da29dfacd9b7",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        OrderNumber = "832663",
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        RefundedAmount = 0D,
        SalesChannel = "Wholesale",
        ServiceChargeAmount = 0D,
        ShippingAddress = new PropertyAccountingSalesorderShippingAddress() {
            Address1 = "69878 Bradley Mill",
            City = "Port Matildestad",
            CountryCode = "US",
            PostalCode = "07989-2148",
            Region = "Arkansas",
            RegionCode = "AK",
        },
        Status = AccountingSalesorderStatus.Paid,
        SubtotalAmount = 0D,
        TaxAmount = 0D,
        TipAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-03-27T10:39:40.344Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingSalesorder`                                                                                                                           | [AccountingSalesorder](../../Models/Components/AccountingSalesorder.md)                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingSalesorderQueryParamFields](../../Models/Requests/CreateAccountingSalesorderQueryParamFields.md)>                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingSalesorderResponse](../../Models/Requests/CreateAccountingSalesorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingSalesorder

Retrieves a single AccountingSalesorder by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingSalesorder" method="get" path="/accounting/{connection_id}/salesorder/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Salesorder.GetAccountingSalesorderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Salesorder                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetAccountingSalesorderQueryParamFields](../../Models/Requests/GetAccountingSalesorderQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingSalesorderResponse](../../Models/Requests/GetAccountingSalesorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingSalesorders

Returns a list of AccountingSalesorders. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingSalesorders" method="get" path="/accounting/{connection_id}/salesorder" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingSalesordersRequest req = new ListAccountingSalesordersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Salesorder.ListAccountingSalesordersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListAccountingSalesordersRequest](../../Models/Requests/ListAccountingSalesordersRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ListAccountingSalesordersResponse](../../Models/Requests/ListAccountingSalesordersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingSalesorder

Updates the AccountingSalesorder identified by `id`. Provide the unified AccountingSalesorder fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingSalesorder" method="patch" path="/accounting/{connection_id}/salesorder/{id}" example="accounting_salesorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingSalesorderRequest req = new PatchAccountingSalesorderRequest() {
    AccountingSalesorder = new AccountingSalesorder() {
        BillingAddress = new PropertyAccountingSalesorderBillingAddress() {
            Address1 = "26530 Stroman Rest",
            Address2 = "Suite 801",
            City = "Pocatello",
            CountryCode = "US",
            PostalCode = "05015-8546",
            Region = "Louisiana",
            RegionCode = "MO",
        },
        CategoryIds = new List<string>() {},
        ClosedAt = System.DateTime.Parse("2023-03-27T10:39:40.361Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        Currency = "USD",
        DiscountAmount = 0D,
        Fees = new List<AccountingFee>() {},
        FulfillmentType = FulfillmentType.Other,
        Id = "3e90f708-0286-4855-bfa9-f777f72be3b4",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        OrderNumber = "832663",
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        RefundedAmount = 0D,
        SalesChannel = "Wholesale",
        ServiceChargeAmount = 0D,
        ShippingAddress = new PropertyAccountingSalesorderShippingAddress() {
            Address1 = "69878 Bradley Mill",
            City = "Port Matildestad",
            CountryCode = "US",
            PostalCode = "07989-2148",
            Region = "Arkansas",
            RegionCode = "AK",
        },
        Status = AccountingSalesorderStatus.Paid,
        SubtotalAmount = 0D,
        TaxAmount = 0D,
        TipAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-03-27T10:39:40.361Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Salesorder.PatchAccountingSalesorderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [PatchAccountingSalesorderRequest](../../Models/Requests/PatchAccountingSalesorderRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[PatchAccountingSalesorderResponse](../../Models/Requests/PatchAccountingSalesorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingSalesorder

Deletes the AccountingSalesorder identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingSalesorder" method="delete" path="/accounting/{connection_id}/salesorder/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Salesorder.RemoveAccountingSalesorderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Salesorder |

### Response

**[RemoveAccountingSalesorderResponse](../../Models/Requests/RemoveAccountingSalesorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingSalesorder

Updates the AccountingSalesorder identified by `id`. Provide the unified AccountingSalesorder fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingSalesorder" method="put" path="/accounting/{connection_id}/salesorder/{id}" example="accounting_salesorder" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingSalesorderRequest req = new UpdateAccountingSalesorderRequest() {
    AccountingSalesorder = new AccountingSalesorder() {
        BillingAddress = new PropertyAccountingSalesorderBillingAddress() {
            Address1 = "26530 Stroman Rest",
            Address2 = "Suite 801",
            City = "Pocatello",
            CountryCode = "US",
            PostalCode = "05015-8546",
            Region = "Louisiana",
            RegionCode = "MO",
        },
        CategoryIds = new List<string>() {},
        ClosedAt = System.DateTime.Parse("2023-03-27T10:39:40.361Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        Currency = "USD",
        DiscountAmount = 0D,
        Fees = new List<AccountingFee>() {},
        FulfillmentType = FulfillmentType.Other,
        Id = "3e90f708-0286-4855-bfa9-f777f72be3b4",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        OrderNumber = "832663",
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        RefundedAmount = 0D,
        SalesChannel = "Wholesale",
        ServiceChargeAmount = 0D,
        ShippingAddress = new PropertyAccountingSalesorderShippingAddress() {
            Address1 = "69878 Bradley Mill",
            City = "Port Matildestad",
            CountryCode = "US",
            PostalCode = "07989-2148",
            Region = "Arkansas",
            RegionCode = "AK",
        },
        Status = AccountingSalesorderStatus.Paid,
        SubtotalAmount = 0D,
        TaxAmount = 0D,
        TipAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-03-27T10:39:40.361Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Salesorder.UpdateAccountingSalesorderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [UpdateAccountingSalesorderRequest](../../Models/Requests/UpdateAccountingSalesorderRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[UpdateAccountingSalesorderResponse](../../Models/Requests/UpdateAccountingSalesorderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |