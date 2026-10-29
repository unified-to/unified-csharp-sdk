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

Creates a AccountingVendorcredit. Provide the unified AccountingVendorcredit fields in the request body; they are mapped to the provider's API. Returns the created AccountingVendorcredit.

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
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Currency = "USD",
        Id = "8e21bf9d-9901-4a26-8d7d-a755bd735917",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Volup conatus cruciamentum decor avaritia.",
        PostedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Status = AccountingVendorcreditStatus.Authorized,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-04T02:04:16.450Z").ToUniversalTime(),
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

Retrieves a single AccountingVendorcredit by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AccountingVendorcredits. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the AccountingVendorcredit identified by `id`. Provide the unified AccountingVendorcredit fields to change in the request body.

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
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Currency = "USD",
        Id = "6cb40c0f-258e-4add-b63a-03ada1aa5df0",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Volup conatus cruciamentum decor avaritia.",
        PostedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Status = AccountingVendorcreditStatus.Authorized,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-04T02:04:16.456Z").ToUniversalTime(),
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

Deletes the AccountingVendorcredit identified by `id`.

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

Updates the AccountingVendorcredit identified by `id`. Provide the unified AccountingVendorcredit fields to change in the request body.

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
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Currency = "USD",
        Id = "6cb40c0f-258e-4add-b63a-03ada1aa5df0",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Volup conatus cruciamentum decor avaritia.",
        PostedAt = System.DateTime.Parse("2023-04-15T21:14:08.197Z").ToUniversalTime(),
        Status = AccountingVendorcreditStatus.Authorized,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2023-10-04T02:04:16.456Z").ToUniversalTime(),
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