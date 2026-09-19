# Bankfeedaccount

## Overview

### Available Operations

* [CreateAccountingBankfeedaccount](#createaccountingbankfeedaccount) - Create a bankfeedaccount
* [GetAccountingBankfeedaccount](#getaccountingbankfeedaccount) - Retrieve a bankfeedaccount
* [ListAccountingBankfeedaccounts](#listaccountingbankfeedaccounts) - List all bankfeedaccounts
* [PatchAccountingBankfeedaccount](#patchaccountingbankfeedaccount) - Update a bankfeedaccount
* [RemoveAccountingBankfeedaccount](#removeaccountingbankfeedaccount) - Remove a bankfeedaccount
* [UpdateAccountingBankfeedaccount](#updateaccountingbankfeedaccount) - Update a bankfeedaccount

## CreateAccountingBankfeedaccount

Create a bankfeedaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingBankfeedaccount" method="post" path="/accounting/{connection_id}/bankfeedaccount" example="accounting_bankfeedaccount" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankfeedaccount.CreateAccountingBankfeedaccountAsync(
    accountingBankfeedaccount: new AccountingBankfeedaccount() {
        AccountId = "baa0e9a4-65e9-4bf5-856a-ce46fc36ebb1",
        AccountNumber = "30369722",
        AccountNumberLast4 = "9722",
        AccountType = AccountType.Loan,
        Balance = 90358D,
        BankName = "Weissnat Inc",
        CreatedAt = System.DateTime.Parse("2022-10-31T16:42:19.277Z").ToUniversalTime(),
        Currency = "SSP",
        FeedStartAt = System.DateTime.Parse("2022-10-31T16:42:19.277Z").ToUniversalTime(),
        Id = "be494e6d-daa0-42fd-92c7-ffed53744d51",
        Name = "Corwin, Donnelly and Connelly Savings",
        RoutingNumber = "667753156",
        Status = AccountingBankfeedaccountStatus.Active,
        UpdatedAt = System.DateTime.Parse("2024-04-11T21:48:26.320Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingBankfeedaccount`                                                                                                                      | [AccountingBankfeedaccount](../../Models/Components/AccountingBankfeedaccount.md)                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingBankfeedaccountQueryParamFields](../../Models/Requests/CreateAccountingBankfeedaccountQueryParamFields.md)>                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingBankfeedaccountResponse](../../Models/Requests/CreateAccountingBankfeedaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingBankfeedaccount

Retrieve a bankfeedaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingBankfeedaccount" method="get" path="/accounting/{connection_id}/bankfeedaccount/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankfeedaccount.GetAccountingBankfeedaccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Bankfeedaccount                                                                                                                        |
| `Fields`                                                                                                                                         | List<[GetAccountingBankfeedaccountQueryParamFields](../../Models/Requests/GetAccountingBankfeedaccountQueryParamFields.md)>                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingBankfeedaccountResponse](../../Models/Requests/GetAccountingBankfeedaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingBankfeedaccounts

List all bankfeedaccounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingBankfeedaccounts" method="get" path="/accounting/{connection_id}/bankfeedaccount" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingBankfeedaccountsRequest req = new ListAccountingBankfeedaccountsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Bankfeedaccount.ListAccountingBankfeedaccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListAccountingBankfeedaccountsRequest](../../Models/Requests/ListAccountingBankfeedaccountsRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[ListAccountingBankfeedaccountsResponse](../../Models/Requests/ListAccountingBankfeedaccountsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingBankfeedaccount

Update a bankfeedaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingBankfeedaccount" method="patch" path="/accounting/{connection_id}/bankfeedaccount/{id}" example="accounting_bankfeedaccount" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingBankfeedaccountRequest req = new PatchAccountingBankfeedaccountRequest() {
    AccountingBankfeedaccount = new AccountingBankfeedaccount() {
        AccountId = "baa0e9a4-65e9-4bf5-856a-ce46fc36ebb1",
        AccountNumber = "30369722",
        AccountNumberLast4 = "9722",
        AccountType = AccountType.Loan,
        Balance = 90358D,
        BankName = "Weissnat Inc",
        CreatedAt = System.DateTime.Parse("2022-10-31T16:42:19.277Z").ToUniversalTime(),
        Currency = "SSP",
        FeedStartAt = System.DateTime.Parse("2022-10-31T16:42:19.277Z").ToUniversalTime(),
        Id = "fed5c383-13a1-4a40-9faa-5f49ba5bed67",
        Name = "Corwin, Donnelly and Connelly Savings",
        RoutingNumber = "667753156",
        Status = AccountingBankfeedaccountStatus.Active,
        UpdatedAt = System.DateTime.Parse("2024-04-11T21:48:26.325Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bankfeedaccount.PatchAccountingBankfeedaccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [PatchAccountingBankfeedaccountRequest](../../Models/Requests/PatchAccountingBankfeedaccountRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[PatchAccountingBankfeedaccountResponse](../../Models/Requests/PatchAccountingBankfeedaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingBankfeedaccount

Remove a bankfeedaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingBankfeedaccount" method="delete" path="/accounting/{connection_id}/bankfeedaccount/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankfeedaccount.RemoveAccountingBankfeedaccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `ConnectionId`            | *string*                  | :heavy_check_mark:        | ID of the connection      |
| `Id`                      | *string*                  | :heavy_check_mark:        | ID of the Bankfeedaccount |

### Response

**[RemoveAccountingBankfeedaccountResponse](../../Models/Requests/RemoveAccountingBankfeedaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingBankfeedaccount

Update a bankfeedaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingBankfeedaccount" method="put" path="/accounting/{connection_id}/bankfeedaccount/{id}" example="accounting_bankfeedaccount" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingBankfeedaccountRequest req = new UpdateAccountingBankfeedaccountRequest() {
    AccountingBankfeedaccount = new AccountingBankfeedaccount() {
        AccountId = "baa0e9a4-65e9-4bf5-856a-ce46fc36ebb1",
        AccountNumber = "30369722",
        AccountNumberLast4 = "9722",
        AccountType = AccountType.Loan,
        Balance = 90358D,
        BankName = "Weissnat Inc",
        CreatedAt = System.DateTime.Parse("2022-10-31T16:42:19.277Z").ToUniversalTime(),
        Currency = "SSP",
        FeedStartAt = System.DateTime.Parse("2022-10-31T16:42:19.277Z").ToUniversalTime(),
        Id = "fed5c383-13a1-4a40-9faa-5f49ba5bed67",
        Name = "Corwin, Donnelly and Connelly Savings",
        RoutingNumber = "667753156",
        Status = AccountingBankfeedaccountStatus.Active,
        UpdatedAt = System.DateTime.Parse("2024-04-11T21:48:26.325Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bankfeedaccount.UpdateAccountingBankfeedaccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [UpdateAccountingBankfeedaccountRequest](../../Models/Requests/UpdateAccountingBankfeedaccountRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[UpdateAccountingBankfeedaccountResponse](../../Models/Requests/UpdateAccountingBankfeedaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |