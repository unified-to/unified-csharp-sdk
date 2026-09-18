# Order

## Overview

### Available Operations

* [CreateAccountingOrder](#createaccountingorder) - Create an order
* [CreateAssessmentOrder](#createassessmentorder) - Create an order
* [GetAccountingOrder](#getaccountingorder) - Retrieve an order
* [GetAssessmentOrder](#getassessmentorder) - Retrieve an order
* [ListAccountingOrders](#listaccountingorders) - List all orders
* [PatchAccountingOrder](#patchaccountingorder) - Update an order
* [PatchAssessmentOrder](#patchassessmentorder) - Update an order
* [RemoveAccountingOrder](#removeaccountingorder) - Remove an order
* [UpdateAccountingOrder](#updateaccountingorder) - Update an order
* [UpdateAssessmentOrder](#updateassessmentorder) - Update an order

## CreateAccountingOrder

Create an order

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
            Address1 = "802 Bechtelar Park",
            Address2 = "Apt. 436",
            City = "Daniellaville",
            CountryCode = "US",
            PostalCode = "36947",
            Region = "Wisconsin",
            RegionCode = "NY",
        },
        CreatedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        Currency = "USD",
        Id = "62016142-db21-434b-8958-592eefe46e72",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2022-04-05T00:14:38.752Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingOrderShippingAddress() {
            Address1 = "9745 Betty Shore",
            City = "South Alainaland",
            CountryCode = "US",
            PostalCode = "25274-7654",
            Region = "New Hampshire",
            RegionCode = "LA",
        },
        Status = AccountingOrderStatus.Submitted,
        TotalAmount = 0D,
        Type = AccountingOrderType.Purchase,
        UpdatedAt = System.DateTime.Parse("2021-06-17T22:40:42.749Z").ToUniversalTime(),
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

Create an order

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
        Id = "eb559378-8a4c-4147-b0b6-108e9aa26caa",
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "Cleta.Daugherty@gmail.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(828) 263-1594 x5248",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 82D,
        ResponseScore = 92D,
        ResponseStatus = ResponseStatus.Failed,
        ResponseUrl = "https://irresponsible-trench.info/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-17T01:52:25.097Z").ToUniversalTime(),
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

## GetAccountingOrder

Retrieve an order

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

Retrieve an order

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

## ListAccountingOrders

List all orders

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

## PatchAccountingOrder

Update an order

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
            Address1 = "802 Bechtelar Park",
            Address2 = "Apt. 436",
            City = "Daniellaville",
            CountryCode = "US",
            PostalCode = "36947",
            Region = "Wisconsin",
            RegionCode = "NY",
        },
        CreatedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        Currency = "USD",
        Id = "ef699eb0-0563-4717-9061-214486399828",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2022-04-05T00:14:38.762Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingOrderShippingAddress() {
            Address1 = "9745 Betty Shore",
            City = "South Alainaland",
            CountryCode = "US",
            PostalCode = "25274-7654",
            Region = "New Hampshire",
            RegionCode = "LA",
        },
        Status = AccountingOrderStatus.Submitted,
        TotalAmount = 0D,
        Type = AccountingOrderType.Purchase,
        UpdatedAt = System.DateTime.Parse("2021-06-17T22:40:42.753Z").ToUniversalTime(),
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

Update an order

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
        Id = "2165508c-a576-42d8-9e14-4a01fbb91f9d",
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "Cleta.Daugherty@gmail.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(828) 263-1594 x5248",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 82D,
        ResponseScore = 92D,
        ResponseStatus = ResponseStatus.Failed,
        ResponseUrl = "https://irresponsible-trench.info/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-17T01:52:25.109Z").ToUniversalTime(),
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

## RemoveAccountingOrder

Remove an order

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

## UpdateAccountingOrder

Update an order

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
            Address1 = "802 Bechtelar Park",
            Address2 = "Apt. 436",
            City = "Daniellaville",
            CountryCode = "US",
            PostalCode = "36947",
            Region = "Wisconsin",
            RegionCode = "NY",
        },
        CreatedAt = System.DateTime.Parse("2020-11-20T03:46:49.837Z").ToUniversalTime(),
        Currency = "USD",
        Id = "ef699eb0-0563-4717-9061-214486399828",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2022-04-05T00:14:38.762Z").ToUniversalTime(),
        ShippingAddress = new PropertyAccountingOrderShippingAddress() {
            Address1 = "9745 Betty Shore",
            City = "South Alainaland",
            CountryCode = "US",
            PostalCode = "25274-7654",
            Region = "New Hampshire",
            RegionCode = "LA",
        },
        Status = AccountingOrderStatus.Submitted,
        TotalAmount = 0D,
        Type = AccountingOrderType.Purchase,
        UpdatedAt = System.DateTime.Parse("2021-06-17T22:40:42.753Z").ToUniversalTime(),
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

Update an order

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
        Id = "2165508c-a576-42d8-9e14-4a01fbb91f9d",
        Parameters = new List<AssessmentParameterInput>() {},
        ProfileAddresses = new List<AssessmentAddress>() {},
        ProfileDateOfBirth = "1989-07-22T16:18:37.650Z",
        ProfileEmails = new List<string>() {
            "Cleta.Daugherty@gmail.com",
        },
        ProfileFirstName = "Amy",
        ProfileGender = ProfileGender.NonBinary,
        ProfileLastName = "Kris-Windler",
        ProfileName = "Amy Kris-Windler",
        ProfileResumeUrl = "https://enchanted-cycle.biz/",
        ProfileSocialMediaUrls = new List<string>() {},
        ProfileTelephones = new List<string>() {
            "(828) 263-1594 x5248",
        },
        Reference = "ab",
        ResponseAttributes = new List<AssessmentAttribute>() {},
        ResponseDetails = new List<AssessmentResponseDetail>() {},
        ResponseDownloadUrls = new List<string>() {},
        ResponseMaxScore = 82D,
        ResponseScore = 92D,
        ResponseStatus = ResponseStatus.Failed,
        ResponseUrl = "https://irresponsible-trench.info/",
        Status = AssessmentOrderStatus.Rejected,
        TargetUrl = "https://cautious-turret.info",
        UpdatedAt = System.DateTime.Parse("2023-01-17T01:52:25.109Z").ToUniversalTime(),
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