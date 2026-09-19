# Account

## Overview

### Available Operations

* [CreateAccountingAccount](#createaccountingaccount) - Create an account
* [GetAccountingAccount](#getaccountingaccount) - Retrieve an account
* [ListAccountingAccounts](#listaccountingaccounts) - List all accounts
* [PatchAccountingAccount](#patchaccountingaccount) - Update an account
* [RemoveAccountingAccount](#removeaccountingaccount) - Remove an account
* [UpdateAccountingAccount](#updateaccountingaccount) - Update an account

## CreateAccountingAccount

Create an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingAccount" method="post" path="/accounting/{connection_id}/account" example="accounting_account" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Account.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {
        Balance = 12092D,
        CreatedAt = System.DateTime.Parse("2022-07-03T17:57:07.391Z").ToUniversalTime(),
        Currency = "BOB",
        CustomerDefinedCode = "quo",
        Description = "Spoliatio comedo vilitas harum cupiditate.",
        Id = "a952c491-7265-40de-bca8-dabac09ed7d2",
        IsPayable = true,
        Name = "Electronic Aluminum Tuna",
        Status = Status.Archived,
        Taxonomy = new List<AccountingAccountTaxonomy>() {
            new AccountingAccountTaxonomy() {
                OriginalType = "vesper",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "iste",
            },
            new AccountingAccountTaxonomy() {
                OriginalType = "adamo",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "peccatus",
            },
        },
        Type = UnifiedTo.Models.Components.Type.Bank,
        UpdatedAt = System.DateTime.Parse("2023-01-03T06:01:37.837Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingAccount`                                                                                                                              | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                                                | :heavy_check_mark:                                                                                                                               | Chart of accounts                                                                                                                                |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[Fields](../../Models/Requests/Fields.md)>                                                                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingAccountResponse](../../Models/Requests/CreateAccountingAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingAccount

Retrieve an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingAccount" method="get" path="/accounting/{connection_id}/account/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Account.GetAccountingAccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Account                                                                                                                                |
| `Fields`                                                                                                                                         | List<[QueryParamFields](../../Models/Requests/QueryParamFields.md)>                                                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingAccountResponse](../../Models/Requests/GetAccountingAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingAccounts

List all accounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingAccounts" method="get" path="/accounting/{connection_id}/account" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Account.ListAccountingAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingAccountsRequest](../../Models/Requests/ListAccountingAccountsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingAccountsResponse](../../Models/Requests/ListAccountingAccountsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingAccount

Update an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingAccount" method="patch" path="/accounting/{connection_id}/account/{id}" example="accounting_account" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingAccountRequest req = new PatchAccountingAccountRequest() {
    AccountingAccount = new AccountingAccount() {
        Balance = 12092D,
        CreatedAt = System.DateTime.Parse("2022-07-03T17:57:07.391Z").ToUniversalTime(),
        Currency = "BOB",
        CustomerDefinedCode = "quo",
        Description = "Spoliatio comedo vilitas harum cupiditate.",
        Id = "31bd63eb-839f-4969-b5e7-c1532b221569",
        IsPayable = true,
        Name = "Electronic Aluminum Tuna",
        Status = Status.Archived,
        Taxonomy = new List<AccountingAccountTaxonomy>() {
            new AccountingAccountTaxonomy() {
                OriginalType = "vesper",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "iste",
            },
            new AccountingAccountTaxonomy() {
                OriginalType = "adamo",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "peccatus",
            },
        },
        Type = UnifiedTo.Models.Components.Type.Bank,
        UpdatedAt = System.DateTime.Parse("2023-01-03T06:01:37.839Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Account.PatchAccountingAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingAccountRequest](../../Models/Requests/PatchAccountingAccountRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingAccountResponse](../../Models/Requests/PatchAccountingAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingAccount

Remove an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingAccount" method="delete" path="/accounting/{connection_id}/account/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Account.RemoveAccountingAccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Account    |

### Response

**[RemoveAccountingAccountResponse](../../Models/Requests/RemoveAccountingAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingAccount

Update an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingAccount" method="put" path="/accounting/{connection_id}/account/{id}" example="accounting_account" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingAccountRequest req = new UpdateAccountingAccountRequest() {
    AccountingAccount = new AccountingAccount() {
        Balance = 12092D,
        CreatedAt = System.DateTime.Parse("2022-07-03T17:57:07.391Z").ToUniversalTime(),
        Currency = "BOB",
        CustomerDefinedCode = "quo",
        Description = "Spoliatio comedo vilitas harum cupiditate.",
        Id = "31bd63eb-839f-4969-b5e7-c1532b221569",
        IsPayable = true,
        Name = "Electronic Aluminum Tuna",
        Status = Status.Archived,
        Taxonomy = new List<AccountingAccountTaxonomy>() {
            new AccountingAccountTaxonomy() {
                OriginalType = "vesper",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "iste",
            },
            new AccountingAccountTaxonomy() {
                OriginalType = "adamo",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "peccatus",
            },
        },
        Type = UnifiedTo.Models.Components.Type.Bank,
        UpdatedAt = System.DateTime.Parse("2023-01-03T06:01:37.839Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Account.UpdateAccountingAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingAccountRequest](../../Models/Requests/UpdateAccountingAccountRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingAccountResponse](../../Models/Requests/UpdateAccountingAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |