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
        Amount = 60889D,
        BankCategory = "Clothing",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-24T23:41:08.374Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Payment of SRD 92.72 for withdrawal at Halvorson - Ziemann, processed with card ending ****3731 linked to account ***7781.",
        Id = "4accf641-e3ef-4774-9084-6728a2d60223",
        IsPending = true,
        MerchantName = "Buckridge - Feest",
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2025-04-14T00:34:14.074Z").ToUniversalTime(),
        Reference = "79574105",
        TransactionAt = System.DateTime.Parse("2022-07-30T05:57:29.892Z").ToUniversalTime(),
        Type = AccountingBankfeedtransactionType.Credit,
        UpdatedAt = System.DateTime.Parse("2022-05-25T00:40:59.883Z").ToUniversalTime(),
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
        Amount = 60889D,
        BankCategory = "Clothing",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-24T23:41:08.374Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Payment of SRD 92.72 for withdrawal at Halvorson - Ziemann, processed with card ending ****3731 linked to account ***7781.",
        Id = "493ce2cd-7f9e-411d-b462-b3e5816d97cc",
        IsPending = true,
        MerchantName = "Buckridge - Feest",
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2025-04-14T00:34:14.086Z").ToUniversalTime(),
        Reference = "79574105",
        TransactionAt = System.DateTime.Parse("2022-07-30T05:57:29.893Z").ToUniversalTime(),
        Type = AccountingBankfeedtransactionType.Credit,
        UpdatedAt = System.DateTime.Parse("2022-05-25T00:40:59.883Z").ToUniversalTime(),
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
        Amount = 60889D,
        BankCategory = "Clothing",
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-03-24T23:41:08.374Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Payment of SRD 92.72 for withdrawal at Halvorson - Ziemann, processed with card ending ****3731 linked to account ***7781.",
        Id = "493ce2cd-7f9e-411d-b462-b3e5816d97cc",
        IsPending = true,
        MerchantName = "Buckridge - Feest",
        Metadata = new List<AccountingMetadata>() {},
        PostedAt = System.DateTime.Parse("2025-04-14T00:34:14.086Z").ToUniversalTime(),
        Reference = "79574105",
        TransactionAt = System.DateTime.Parse("2022-07-30T05:57:29.893Z").ToUniversalTime(),
        Type = AccountingBankfeedtransactionType.Credit,
        UpdatedAt = System.DateTime.Parse("2022-05-25T00:40:59.883Z").ToUniversalTime(),
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