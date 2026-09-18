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

Create a salesorder

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
        ClosedAt = System.DateTime.Parse("2023-08-16T21:47:45.013Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        Currency = "ANG",
        DiscountAmount = 99D,
        EmployeeUserId = "4a6b8990-c85a-499f-82d0-5011c3c95a0b",
        Fees = new List<AccountingFee>() {
            new AccountingFee() {
                Amount = 519D,
                Currency = "XCD",
                Type = AccountingFeeType.Promotion,
            },
        },
        FulfillmentType = FulfillmentType.Takeout,
        GuestCount = 8D,
        Id = "4b4b8374-641e-4c7b-84dc-48bb2da0c7fe",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        OrderNumber = "988187",
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2026-01-11T02:11:41.222Z").ToUniversalTime(),
        RefundedAmount = 0D,
        SalesChannel = "Harvey, Collier and Weimann",
        ServiceChargeAmount = 63D,
        ShippingAddress = new PropertyAccountingSalesorderShippingAddress() {
            Address1 = "9878 Bradley Mill",
            Address2 = "Apt. 215",
            City = "Port Matildestad",
            CountryCode = "US",
            PostalCode = "07989-2148",
            Region = "Arkansas",
            RegionCode = "AK",
        },
        Status = AccountingSalesorderStatus.Refunded,
        SubtotalAmount = 0D,
        TaxAmount = 63D,
        TipAmount = 34D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2022-02-10T18:49:09.489Z").ToUniversalTime(),
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

Retrieve a salesorder

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

List all salesorders

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

Update a salesorder

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
        ClosedAt = System.DateTime.Parse("2023-08-16T21:47:45.033Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        Currency = "ANG",
        DiscountAmount = 99D,
        EmployeeUserId = "4a6b8990-c85a-499f-82d0-5011c3c95a0b",
        Fees = new List<AccountingFee>() {
            new AccountingFee() {
                Amount = 519D,
                Currency = "XCD",
                Type = AccountingFeeType.Promotion,
            },
        },
        FulfillmentType = FulfillmentType.Takeout,
        GuestCount = 8D,
        Id = "7a2572c0-20e2-47d3-9ebd-99ebd81b6655",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        OrderNumber = "988187",
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2026-01-11T02:11:41.271Z").ToUniversalTime(),
        RefundedAmount = 0D,
        SalesChannel = "Harvey, Collier and Weimann",
        ServiceChargeAmount = 63D,
        ShippingAddress = new PropertyAccountingSalesorderShippingAddress() {
            Address1 = "9878 Bradley Mill",
            Address2 = "Apt. 215",
            City = "Port Matildestad",
            CountryCode = "US",
            PostalCode = "07989-2148",
            Region = "Arkansas",
            RegionCode = "AK",
        },
        Status = AccountingSalesorderStatus.Refunded,
        SubtotalAmount = 0D,
        TaxAmount = 63D,
        TipAmount = 34D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2022-02-10T18:49:09.490Z").ToUniversalTime(),
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

Remove a salesorder

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

Update a salesorder

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
        ClosedAt = System.DateTime.Parse("2023-08-16T21:47:45.033Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-17T16:11:50.310Z").ToUniversalTime(),
        Currency = "ANG",
        DiscountAmount = 99D,
        EmployeeUserId = "4a6b8990-c85a-499f-82d0-5011c3c95a0b",
        Fees = new List<AccountingFee>() {
            new AccountingFee() {
                Amount = 519D,
                Currency = "XCD",
                Type = AccountingFeeType.Promotion,
            },
        },
        FulfillmentType = FulfillmentType.Takeout,
        GuestCount = 8D,
        Id = "7a2572c0-20e2-47d3-9ebd-99ebd81b6655",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        OrderNumber = "988187",
        Payments = new List<AccountingPaymentReference>() {},
        PostedAt = System.DateTime.Parse("2026-01-11T02:11:41.271Z").ToUniversalTime(),
        RefundedAmount = 0D,
        SalesChannel = "Harvey, Collier and Weimann",
        ServiceChargeAmount = 63D,
        ShippingAddress = new PropertyAccountingSalesorderShippingAddress() {
            Address1 = "9878 Bradley Mill",
            Address2 = "Apt. 215",
            City = "Port Matildestad",
            CountryCode = "US",
            PostalCode = "07989-2148",
            Region = "Arkansas",
            RegionCode = "AK",
        },
        Status = AccountingSalesorderStatus.Refunded,
        SubtotalAmount = 0D,
        TaxAmount = 63D,
        TipAmount = 34D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2022-02-10T18:49:09.490Z").ToUniversalTime(),
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