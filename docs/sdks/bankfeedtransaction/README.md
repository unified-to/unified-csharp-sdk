# Bankfeedtransaction

## Overview

### Available Operations

* [CreateAccountingBankfeedtransaction](#createaccountingbankfeedtransaction) - Create a bankfeedtransaction
* [GetAccountingBankfeedtransaction](#getaccountingbankfeedtransaction) - Retrieve a bankfeedtransaction
* [ListAccountingBankfeedtransactions](#listaccountingbankfeedtransactions) - List all bankfeedtransactions
* [PatchAccountingBankfeedtransaction](#patchaccountingbankfeedtransaction) - Update a bankfeedtransaction
* [RemoveAccountingBankfeedtransaction](#removeaccountingbankfeedtransaction) - Remove a bankfeedtransaction
* [UpdateAccountingBankfeedtransaction](#updateaccountingbankfeedtransaction) - Update a bankfeedtransaction

## CreateAccountingBankfeedtransaction

Create a bankfeedtransaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingBankfeedtransaction" method="post" path="/accounting/{connection_id}/bankfeedtransaction" example="accounting_bankfeedtransaction" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankfeedtransaction.CreateAccountingBankfeedtransactionAsync(
    accountingBankfeedtransaction: new AccountingBankfeedtransaction() {
        AccountId = "b7dc4175-1368-4b89-a700-d621b6666648",
        Amount = 60889D,
        BankCategory = "Games",
        BankfeedaccountId = "34c1d05f-5b62-4bcd-9121-3be8b720941f",
        CategoryIds = new List<string>() {},
        ContactId = "1ef58ebe-f9c9-46f6-9d9c-2df2658503be",
        CreatedAt = System.DateTime.Parse("2022-03-24T23:41:08.374Z").ToUniversalTime(),
        Currency = "SRD",
        Description = "payment transaction at McLaughlin - Schaden using card ending with ****8233 for DOP 574.03 in account ***9523.",
        Id = "30fb790d-3f8e-48ab-8f69-cfc3c408e989",
        IsPending = true,
        MerchantName = "Reichert, Erdman and Tillman",
        PostedAt = System.DateTime.Parse("2025-03-23T18:34:48.066Z").ToUniversalTime(),
        Reference = "93642593",
        TransactionAt = System.DateTime.Parse("2022-07-27T19:48:15.221Z").ToUniversalTime(),
        Type = AccountingBankfeedtransactionType.Credit,
        UpdatedAt = System.DateTime.Parse("2022-05-23T20:47:21.834Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingBankfeedtransaction`                                                                                                                  | [AccountingBankfeedtransaction](../../Models/Components/AccountingBankfeedtransaction.md)                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingBankfeedtransactionQueryParamFields](../../Models/Requests/CreateAccountingBankfeedtransactionQueryParamFields.md)>        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingBankfeedtransactionResponse](../../Models/Requests/CreateAccountingBankfeedtransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingBankfeedtransaction

Retrieve a bankfeedtransaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingBankfeedtransaction" method="get" path="/accounting/{connection_id}/bankfeedtransaction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankfeedtransaction.GetAccountingBankfeedtransactionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Bankfeedtransaction                                                                                                                    |
| `Fields`                                                                                                                                         | List<[GetAccountingBankfeedtransactionQueryParamFields](../../Models/Requests/GetAccountingBankfeedtransactionQueryParamFields.md)>              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingBankfeedtransactionResponse](../../Models/Requests/GetAccountingBankfeedtransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingBankfeedtransactions

List all bankfeedtransactions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingBankfeedtransactions" method="get" path="/accounting/{connection_id}/bankfeedtransaction" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingBankfeedtransactionsRequest req = new ListAccountingBankfeedtransactionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Bankfeedtransaction.ListAccountingBankfeedtransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [ListAccountingBankfeedtransactionsRequest](../../Models/Requests/ListAccountingBankfeedtransactionsRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |

### Response

**[ListAccountingBankfeedtransactionsResponse](../../Models/Requests/ListAccountingBankfeedtransactionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingBankfeedtransaction

Update a bankfeedtransaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingBankfeedtransaction" method="patch" path="/accounting/{connection_id}/bankfeedtransaction/{id}" example="accounting_bankfeedtransaction" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingBankfeedtransactionRequest req = new PatchAccountingBankfeedtransactionRequest() {
    AccountingBankfeedtransaction = new AccountingBankfeedtransaction() {
        AccountId = "b7dc4175-1368-4b89-a700-d621b6666648",
        Amount = 60889D,
        BankCategory = "Games",
        BankfeedaccountId = "34c1d05f-5b62-4bcd-9121-3be8b720941f",
        CategoryIds = new List<string>() {},
        ContactId = "1ef58ebe-f9c9-46f6-9d9c-2df2658503be",
        CreatedAt = System.DateTime.Parse("2022-03-24T23:41:08.374Z").ToUniversalTime(),
        Currency = "SRD",
        Description = "payment transaction at McLaughlin - Schaden using card ending with ****8233 for DOP 574.03 in account ***9523.",
        Id = "99973f58-3052-444a-a355-5b7ffb177172",
        IsPending = true,
        MerchantName = "Reichert, Erdman and Tillman",
        PostedAt = System.DateTime.Parse("2025-03-23T18:34:48.075Z").ToUniversalTime(),
        Reference = "93642593",
        TransactionAt = System.DateTime.Parse("2022-07-27T19:48:15.222Z").ToUniversalTime(),
        Type = AccountingBankfeedtransactionType.Credit,
        UpdatedAt = System.DateTime.Parse("2022-05-23T20:47:21.835Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bankfeedtransaction.PatchAccountingBankfeedtransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [PatchAccountingBankfeedtransactionRequest](../../Models/Requests/PatchAccountingBankfeedtransactionRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |

### Response

**[PatchAccountingBankfeedtransactionResponse](../../Models/Requests/PatchAccountingBankfeedtransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingBankfeedtransaction

Remove a bankfeedtransaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingBankfeedtransaction" method="delete" path="/accounting/{connection_id}/bankfeedtransaction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankfeedtransaction.RemoveAccountingBankfeedtransactionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                     | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `ConnectionId`                | *string*                      | :heavy_check_mark:            | ID of the connection          |
| `Id`                          | *string*                      | :heavy_check_mark:            | ID of the Bankfeedtransaction |

### Response

**[RemoveAccountingBankfeedtransactionResponse](../../Models/Requests/RemoveAccountingBankfeedtransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingBankfeedtransaction

Update a bankfeedtransaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingBankfeedtransaction" method="put" path="/accounting/{connection_id}/bankfeedtransaction/{id}" example="accounting_bankfeedtransaction" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingBankfeedtransactionRequest req = new UpdateAccountingBankfeedtransactionRequest() {
    AccountingBankfeedtransaction = new AccountingBankfeedtransaction() {
        AccountId = "b7dc4175-1368-4b89-a700-d621b6666648",
        Amount = 60889D,
        BankCategory = "Games",
        BankfeedaccountId = "34c1d05f-5b62-4bcd-9121-3be8b720941f",
        CategoryIds = new List<string>() {},
        ContactId = "1ef58ebe-f9c9-46f6-9d9c-2df2658503be",
        CreatedAt = System.DateTime.Parse("2022-03-24T23:41:08.374Z").ToUniversalTime(),
        Currency = "SRD",
        Description = "payment transaction at McLaughlin - Schaden using card ending with ****8233 for DOP 574.03 in account ***9523.",
        Id = "99973f58-3052-444a-a355-5b7ffb177172",
        IsPending = true,
        MerchantName = "Reichert, Erdman and Tillman",
        PostedAt = System.DateTime.Parse("2025-03-23T18:34:48.075Z").ToUniversalTime(),
        Reference = "93642593",
        TransactionAt = System.DateTime.Parse("2022-07-27T19:48:15.222Z").ToUniversalTime(),
        Type = AccountingBankfeedtransactionType.Credit,
        UpdatedAt = System.DateTime.Parse("2022-05-23T20:47:21.835Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bankfeedtransaction.UpdateAccountingBankfeedtransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [UpdateAccountingBankfeedtransactionRequest](../../Models/Requests/UpdateAccountingBankfeedtransactionRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[UpdateAccountingBankfeedtransactionResponse](../../Models/Requests/UpdateAccountingBankfeedtransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |