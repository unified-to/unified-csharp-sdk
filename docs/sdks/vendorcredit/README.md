# Vendorcredit

## Overview

### Available Operations

* [CreateAccountingVendorcredit](#createaccountingvendorcredit) - Create a vendorcredit
* [GetAccountingVendorcredit](#getaccountingvendorcredit) - Retrieve a vendorcredit
* [ListAccountingVendorcredits](#listaccountingvendorcredits) - List all vendorcredits
* [PatchAccountingVendorcredit](#patchaccountingvendorcredit) - Update a vendorcredit
* [RemoveAccountingVendorcredit](#removeaccountingvendorcredit) - Remove a vendorcredit
* [UpdateAccountingVendorcredit](#updateaccountingvendorcredit) - Update a vendorcredit

## CreateAccountingVendorcredit

Create a vendorcredit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingVendorcredit" method="post" path="/accounting/{connection_id}/vendorcredit" example="accounting_vendorcredit" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Vendorcredit.CreateAccountingVendorcreditAsync(
    accountingVendorcredit: new AccountingVendorcredit() {
        Applications = new List<AccountingCreditApplication>() {},
        ApplyAmount = 1D,
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Currency = "KGS",
        DueAt = System.DateTime.Parse("2023-05-06T20:38:46.775Z").ToUniversalTime(),
        Id = "e53c082c-1aa1-4192-be20-f4cdfd0cea57",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Conatus cruciamentum decor avaritia tantum.",
        PostedAt = System.DateTime.Parse("2023-09-28T16:43:46.445Z").ToUniversalTime(),
        Status = AccountingVendorcreditStatus.Submitted,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-11-26T14:35:53.369Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingVendorcredit`                                                                                                                         | [AccountingVendorcredit](../../Models/Components/AccountingVendorcredit.md)                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingVendorcreditQueryParamFields](../../Models/Requests/CreateAccountingVendorcreditQueryParamFields.md)>                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingVendorcreditResponse](../../Models/Requests/CreateAccountingVendorcreditResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingVendorcredit

Retrieve a vendorcredit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingVendorcredit" method="get" path="/accounting/{connection_id}/vendorcredit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Vendorcredit.GetAccountingVendorcreditAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Vendorcredit                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetAccountingVendorcreditQueryParamFields](../../Models/Requests/GetAccountingVendorcreditQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingVendorcreditResponse](../../Models/Requests/GetAccountingVendorcreditResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingVendorcredits

List all vendorcredits

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingVendorcredits" method="get" path="/accounting/{connection_id}/vendorcredit" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingVendorcreditsRequest req = new ListAccountingVendorcreditsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Vendorcredit.ListAccountingVendorcreditsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListAccountingVendorcreditsRequest](../../Models/Requests/ListAccountingVendorcreditsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListAccountingVendorcreditsResponse](../../Models/Requests/ListAccountingVendorcreditsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingVendorcredit

Update a vendorcredit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingVendorcredit" method="patch" path="/accounting/{connection_id}/vendorcredit/{id}" example="accounting_vendorcredit" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingVendorcreditRequest req = new PatchAccountingVendorcreditRequest() {
    AccountingVendorcredit = new AccountingVendorcredit() {
        Applications = new List<AccountingCreditApplication>() {},
        ApplyAmount = 1D,
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Currency = "KGS",
        DueAt = System.DateTime.Parse("2023-05-06T20:38:46.775Z").ToUniversalTime(),
        Id = "79c98d35-f30c-4832-82a9-eaa45fdf6b58",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Conatus cruciamentum decor avaritia tantum.",
        PostedAt = System.DateTime.Parse("2023-09-28T16:43:46.448Z").ToUniversalTime(),
        Status = AccountingVendorcreditStatus.Submitted,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-11-26T14:35:53.374Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Vendorcredit.PatchAccountingVendorcreditAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [PatchAccountingVendorcreditRequest](../../Models/Requests/PatchAccountingVendorcreditRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[PatchAccountingVendorcreditResponse](../../Models/Requests/PatchAccountingVendorcreditResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingVendorcredit

Remove a vendorcredit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingVendorcredit" method="delete" path="/accounting/{connection_id}/vendorcredit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Vendorcredit.RemoveAccountingVendorcreditAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Vendorcredit |

### Response

**[RemoveAccountingVendorcreditResponse](../../Models/Requests/RemoveAccountingVendorcreditResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingVendorcredit

Update a vendorcredit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingVendorcredit" method="put" path="/accounting/{connection_id}/vendorcredit/{id}" example="accounting_vendorcredit" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingVendorcreditRequest req = new UpdateAccountingVendorcreditRequest() {
    AccountingVendorcredit = new AccountingVendorcredit() {
        Applications = new List<AccountingCreditApplication>() {},
        ApplyAmount = 1D,
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Currency = "KGS",
        DueAt = System.DateTime.Parse("2023-05-06T20:38:46.775Z").ToUniversalTime(),
        Id = "79c98d35-f30c-4832-82a9-eaa45fdf6b58",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Conatus cruciamentum decor avaritia tantum.",
        PostedAt = System.DateTime.Parse("2023-09-28T16:43:46.448Z").ToUniversalTime(),
        Status = AccountingVendorcreditStatus.Submitted,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-11-26T14:35:53.374Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Vendorcredit.UpdateAccountingVendorcreditAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [UpdateAccountingVendorcreditRequest](../../Models/Requests/UpdateAccountingVendorcreditRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[UpdateAccountingVendorcreditResponse](../../Models/Requests/UpdateAccountingVendorcreditResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |