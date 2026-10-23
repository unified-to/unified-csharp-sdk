# Creditmemo

## Overview

### Available Operations

* [CreateAccountingCreditmemo](#createaccountingcreditmemo) - Create a creditmemo
* [GetAccountingCreditmemo](#getaccountingcreditmemo) - Retrieve a creditmemo
* [ListAccountingCreditmemoes](#listaccountingcreditmemoes) - List all creditmemoes
* [PatchAccountingCreditmemo](#patchaccountingcreditmemo) - Update a creditmemo
* [RemoveAccountingCreditmemo](#removeaccountingcreditmemo) - Remove a creditmemo
* [UpdateAccountingCreditmemo](#updateaccountingcreditmemo) - Update a creditmemo

## CreateAccountingCreditmemo

Creates a AccountingCreditmemo. Provide the unified AccountingCreditmemo fields in the request body; they are mapped to the provider's API. Returns the created AccountingCreditmemo.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingCreditmemo" method="post" path="/accounting/{connection_id}/creditmemo" example="accounting_creditmemo" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Creditmemo.CreateAccountingCreditmemoAsync(
    accountingCreditmemo: new AccountingCreditmemo() {
        Applications = new List<AccountingCreditApplication>() {},
        Attachments = new List<AccountingAttachment>() {},
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        CreditmemoNumber = "CM-99537",
        Currency = "AUD",
        DiscountAmount = 0D,
        Id = "b3933390-8308-4f6f-b0c1-3f46c0827f76",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Hic vorax dedecor amo adfero torqueo quas victoria.",
        PostedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        Send = true,
        Status = AccountingCreditmemoStatus.Authorized,
        TaxAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-09-12T14:54:02.824Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingCreditmemo`                                                                                                                           | [AccountingCreditmemo](../../Models/Components/AccountingCreditmemo.md)                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingCreditmemoQueryParamFields](../../Models/Requests/CreateAccountingCreditmemoQueryParamFields.md)>                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingCreditmemoResponse](../../Models/Requests/CreateAccountingCreditmemoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingCreditmemo

Retrieves a single AccountingCreditmemo by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingCreditmemo" method="get" path="/accounting/{connection_id}/creditmemo/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Creditmemo.GetAccountingCreditmemoAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Creditmemo                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetAccountingCreditmemoQueryParamFields](../../Models/Requests/GetAccountingCreditmemoQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingCreditmemoResponse](../../Models/Requests/GetAccountingCreditmemoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingCreditmemoes

Returns a list of AccountingCreditmemoes. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingCreditmemoes" method="get" path="/accounting/{connection_id}/creditmemo" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingCreditmemoesRequest req = new ListAccountingCreditmemoesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Creditmemo.ListAccountingCreditmemoesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingCreditmemoesRequest](../../Models/Requests/ListAccountingCreditmemoesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListAccountingCreditmemoesResponse](../../Models/Requests/ListAccountingCreditmemoesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingCreditmemo

Updates the AccountingCreditmemo identified by `id`. Provide the unified AccountingCreditmemo fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingCreditmemo" method="patch" path="/accounting/{connection_id}/creditmemo/{id}" example="accounting_creditmemo" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingCreditmemoRequest req = new PatchAccountingCreditmemoRequest() {
    AccountingCreditmemo = new AccountingCreditmemo() {
        Applications = new List<AccountingCreditApplication>() {},
        Attachments = new List<AccountingAttachment>() {},
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        CreditmemoNumber = "CM-99537",
        Currency = "AUD",
        DiscountAmount = 0D,
        Id = "2f873f5b-200e-4b13-91c1-2600a91b99b8",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Hic vorax dedecor amo adfero torqueo quas victoria.",
        PostedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        Send = true,
        Status = AccountingCreditmemoStatus.Authorized,
        TaxAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-09-12T14:54:02.842Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Creditmemo.PatchAccountingCreditmemoAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [PatchAccountingCreditmemoRequest](../../Models/Requests/PatchAccountingCreditmemoRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[PatchAccountingCreditmemoResponse](../../Models/Requests/PatchAccountingCreditmemoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingCreditmemo

Deletes the AccountingCreditmemo identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingCreditmemo" method="delete" path="/accounting/{connection_id}/creditmemo/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Creditmemo.RemoveAccountingCreditmemoAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Creditmemo |

### Response

**[RemoveAccountingCreditmemoResponse](../../Models/Requests/RemoveAccountingCreditmemoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingCreditmemo

Updates the AccountingCreditmemo identified by `id`. Provide the unified AccountingCreditmemo fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingCreditmemo" method="put" path="/accounting/{connection_id}/creditmemo/{id}" example="accounting_creditmemo" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingCreditmemoRequest req = new UpdateAccountingCreditmemoRequest() {
    AccountingCreditmemo = new AccountingCreditmemo() {
        Applications = new List<AccountingCreditApplication>() {},
        Attachments = new List<AccountingAttachment>() {},
        BalanceAmount = 0D,
        CreatedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        CreditmemoNumber = "CM-99537",
        Currency = "AUD",
        DiscountAmount = 0D,
        Id = "2f873f5b-200e-4b13-91c1-2600a91b99b8",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Hic vorax dedecor amo adfero torqueo quas victoria.",
        PostedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        Send = true,
        Status = AccountingCreditmemoStatus.Authorized,
        TaxAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2025-09-12T14:54:02.842Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Creditmemo.UpdateAccountingCreditmemoAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [UpdateAccountingCreditmemoRequest](../../Models/Requests/UpdateAccountingCreditmemoRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[UpdateAccountingCreditmemoResponse](../../Models/Requests/UpdateAccountingCreditmemoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |