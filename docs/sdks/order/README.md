# Order

## Overview

### Available Operations

* [~~CreateAccountingOrder~~](#createaccountingorder) - Create an order :warning: **Deprecated**
* [CreateAssessmentOrder](#createassessmentorder) - Create an order
* [~~GetAccountingOrder~~](#getaccountingorder) - Retrieve an order :warning: **Deprecated**
* [GetAssessmentOrder](#getassessmentorder) - Retrieve an order
* [~~ListAccountingOrders~~](#listaccountingorders) - List all orders :warning: **Deprecated**
* [~~PatchAccountingOrder~~](#patchaccountingorder) - Update an order :warning: **Deprecated**
* [PatchAssessmentOrder](#patchassessmentorder) - Update an order
* [~~RemoveAccountingOrder~~](#removeaccountingorder) - Remove an order :warning: **Deprecated**
* [~~UpdateAccountingOrder~~](#updateaccountingorder) - Update an order :warning: **Deprecated**
* [UpdateAssessmentOrder](#updateassessmentorder) - Update an order

## ~~CreateAccountingOrder~~

Creates a AccountingOrder. Provide the unified AccountingOrder fields in the request body; they are mapped to the provider's API. Returns the created AccountingOrder.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingOrder" method="post" path="/accounting/{connection_id}/order" example="accounting_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Order.CreateAccountingOrderAsync(
    accountingOrder: new AccountingOrder() {
        BillingAddress = new PropertyAccountingOrderBillingAddress() {
            Address1 = "7654 Treutel Square",
            City = "Forrestport",
            CountryCode = "US",
            PostalCode = "42190-3694",
            Region = "Maine",
            RegionCode = "OR",
        },
        CreatedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        Currency = "GBP",
        Id = "a49e8a3c-1077-48d5-88f9-14d1b980cbde",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingOrderShippingAddress() {
            Address1 = "4974 Beatty Corners",
            City = "Alizeport",
            CountryCode = "US",
            PostalCode = "56252",
            Region = "Alaska",
            RegionCode = "VT",
        },
        Status = AccountingOrderStatus.Authorized,
        TotalAmount = 0D,
        Type = AccountingOrderType.Sales,
        UpdatedAt = System.DateTime.Parse("2022-02-09T02:59:18.170Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingOrder`                                                                                                                                | [AccountingOrder](../../Models/Components/AccountingOrder.md)                                                                                    | :heavy_check_mark:                                                                                                                               | @deprecated; use AccountingSalesorder or AccountingPurchaseorder                                                                                 |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingOrderQueryParamFields](../../Models/Requests/CreateAccountingOrderQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingOrderResponse](../../Models/Requests/CreateAccountingOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAssessmentOrder

Creates a AssessmentOrder. Provide the unified AssessmentOrder fields in the request body; they are mapped to the provider's API. Returns the created AssessmentOrder.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAssessmentOrder" method="post" path="/assessment/{connection_id}/order" example="assessment_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Order.CreateAssessmentOrderAsync(
    assessmentOrder: new AssessmentOrder() {
        ConnectionId = "<id>",
        CreatedAt = System.DateTime.Parse("2021-09-18T10:33:57.803Z").ToUniversalTime(),
        Id = "ba1887ca-23d9-4e01-9ea2-b81383ff229e",
        Metadata = new List<AssessmentMetadata>() {},
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "amy.kris.windler@icloud.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(341) 425-5828",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 84D,
        ResponseScore = 82D,
        ResponseStatus = ResponseStatus.Rejected,
        ResponseUrl = "https://rowdy-fisherman.biz/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-26T21:59:04.747Z").ToUniversalTime(),
        WorkspaceId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AssessmentOrder`                                                                                                                                | [AssessmentOrder](../../Models/Components/AssessmentOrder.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAssessmentOrderQueryParamFields](../../Models/Requests/CreateAssessmentOrderQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAssessmentOrderResponse](../../Models/Requests/CreateAssessmentOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ~~GetAccountingOrder~~

Retrieves a single AccountingOrder by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingOrder" method="get" path="/accounting/{connection_id}/order/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Order.GetAccountingOrderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Order                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAccountingOrderQueryParamFields](../../Models/Requests/GetAccountingOrderQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingOrderResponse](../../Models/Requests/GetAccountingOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAssessmentOrder

Retrieves a single AssessmentOrder by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAssessmentOrder" method="get" path="/assessment/{connection_id}/order/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Order.GetAssessmentOrderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Order                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetAssessmentOrderQueryParamFields](../../Models/Requests/GetAssessmentOrderQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAssessmentOrderResponse](../../Models/Requests/GetAssessmentOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ~~ListAccountingOrders~~

Returns a list of AccountingOrders. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingOrders" method="get" path="/accounting/{connection_id}/order" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingOrdersRequest req = new ListAccountingOrdersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Order.ListAccountingOrdersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListAccountingOrdersRequest](../../Models/Requests/ListAccountingOrdersRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListAccountingOrdersResponse](../../Models/Requests/ListAccountingOrdersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ~~PatchAccountingOrder~~

Updates the AccountingOrder identified by `id`. Provide the unified AccountingOrder fields to change in the request body.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingOrder" method="patch" path="/accounting/{connection_id}/order/{id}" example="accounting_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingOrderRequest req = new PatchAccountingOrderRequest() {
    AccountingOrder = new AccountingOrder() {
        BillingAddress = new PropertyAccountingOrderBillingAddress() {
            Address1 = "7654 Treutel Square",
            City = "Forrestport",
            CountryCode = "US",
            PostalCode = "42190-3694",
            Region = "Maine",
            RegionCode = "OR",
        },
        CreatedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        Currency = "GBP",
        Id = "067a4581-c3ae-4c6d-8f56-2d76ffeadaec",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingOrderShippingAddress() {
            Address1 = "4974 Beatty Corners",
            City = "Alizeport",
            CountryCode = "US",
            PostalCode = "56252",
            Region = "Alaska",
            RegionCode = "VT",
        },
        Status = AccountingOrderStatus.Authorized,
        TotalAmount = 0D,
        Type = AccountingOrderType.Sales,
        UpdatedAt = System.DateTime.Parse("2022-02-09T02:59:18.177Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Order.PatchAccountingOrderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchAccountingOrderRequest](../../Models/Requests/PatchAccountingOrderRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchAccountingOrderResponse](../../Models/Requests/PatchAccountingOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAssessmentOrder

Updates the AssessmentOrder identified by `id`. Provide the unified AssessmentOrder fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAssessmentOrder" method="patch" path="/assessment/{connection_id}/order/{id}" example="assessment_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAssessmentOrderRequest req = new PatchAssessmentOrderRequest() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
        CreatedAt = System.DateTime.Parse("2021-09-18T10:33:57.803Z").ToUniversalTime(),
        Id = "1b1d5698-cb43-4f5c-9b26-61531fb1e192",
        Metadata = new List<AssessmentMetadata>() {},
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "amy.kris.windler@icloud.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(341) 425-5828",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 84D,
        ResponseScore = 82D,
        ResponseStatus = ResponseStatus.Rejected,
        ResponseUrl = "https://rowdy-fisherman.biz/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-26T21:59:04.755Z").ToUniversalTime(),
        WorkspaceId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Order.PatchAssessmentOrderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchAssessmentOrderRequest](../../Models/Requests/PatchAssessmentOrderRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchAssessmentOrderResponse](../../Models/Requests/PatchAssessmentOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ~~RemoveAccountingOrder~~

Deletes the AccountingOrder identified by `id`.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingOrder" method="delete" path="/accounting/{connection_id}/order/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Order.RemoveAccountingOrderAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Order      |

### Response

**[RemoveAccountingOrderResponse](../../Models/Requests/RemoveAccountingOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ~~UpdateAccountingOrder~~

Updates the AccountingOrder identified by `id`. Provide the unified AccountingOrder fields to change in the request body.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingOrder" method="put" path="/accounting/{connection_id}/order/{id}" example="accounting_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingOrderRequest req = new UpdateAccountingOrderRequest() {
    AccountingOrder = new AccountingOrder() {
        BillingAddress = new PropertyAccountingOrderBillingAddress() {
            Address1 = "7654 Treutel Square",
            City = "Forrestport",
            CountryCode = "US",
            PostalCode = "42190-3694",
            Region = "Maine",
            RegionCode = "OR",
        },
        CreatedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        Currency = "GBP",
        Id = "067a4581-c3ae-4c6d-8f56-2d76ffeadaec",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingOrderShippingAddress() {
            Address1 = "4974 Beatty Corners",
            City = "Alizeport",
            CountryCode = "US",
            PostalCode = "56252",
            Region = "Alaska",
            RegionCode = "VT",
        },
        Status = AccountingOrderStatus.Authorized,
        TotalAmount = 0D,
        Type = AccountingOrderType.Sales,
        UpdatedAt = System.DateTime.Parse("2022-02-09T02:59:18.177Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Order.UpdateAccountingOrderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateAccountingOrderRequest](../../Models/Requests/UpdateAccountingOrderRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateAccountingOrderResponse](../../Models/Requests/UpdateAccountingOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAssessmentOrder

Updates the AssessmentOrder identified by `id`. Provide the unified AssessmentOrder fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAssessmentOrder" method="put" path="/assessment/{connection_id}/order/{id}" example="assessment_order" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAssessmentOrderRequest req = new UpdateAssessmentOrderRequest() {
    AssessmentOrder = new AssessmentOrder() {
        ConnectionId = "<id>",
        CreatedAt = System.DateTime.Parse("2021-09-18T10:33:57.803Z").ToUniversalTime(),
        Id = "1b1d5698-cb43-4f5c-9b26-61531fb1e192",
        Metadata = new List<AssessmentMetadata>() {},
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "amy.kris.windler@icloud.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(341) 425-5828",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 84D,
        ResponseScore = 82D,
        ResponseStatus = ResponseStatus.Rejected,
        ResponseUrl = "https://rowdy-fisherman.biz/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-26T21:59:04.755Z").ToUniversalTime(),
        WorkspaceId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Order.UpdateAssessmentOrderAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateAssessmentOrderRequest](../../Models/Requests/UpdateAssessmentOrderRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateAssessmentOrderResponse](../../Models/Requests/UpdateAssessmentOrderResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |