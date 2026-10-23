# Taxrate

## Overview

### Available Operations

* [CreateAccountingTaxrate](#createaccountingtaxrate) - Create a taxrate
* [GetAccountingTaxrate](#getaccountingtaxrate) - Retrieve a taxrate
* [ListAccountingTaxrates](#listaccountingtaxrates) - List all taxrates
* [PatchAccountingTaxrate](#patchaccountingtaxrate) - Update a taxrate
* [RemoveAccountingTaxrate](#removeaccountingtaxrate) - Remove a taxrate
* [UpdateAccountingTaxrate](#updateaccountingtaxrate) - Update a taxrate

## CreateAccountingTaxrate

Creates a AccountingTaxrate. Provide the unified AccountingTaxrate fields in the request body; they are mapped to the provider's API. Returns the created AccountingTaxrate.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingTaxrate" method="post" path="/accounting/{connection_id}/taxrate" example="accounting_taxrate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.CreateAccountingTaxrateAsync(
    accountingTaxrate: new AccountingTaxrate() {
        Components = new List<AccountingTaxrateComponent>() {
            new AccountingTaxrateComponent() {
                IsCompound = false,
                Name = "Exempt",
                Rate = 0D,
            },
        },
        Country = "US",
        CreatedAt = System.DateTime.Parse("2020-01-04T10:37:56.894Z").ToUniversalTime(),
        Description = "Exempt (0%)",
        EffectiveRate = 0D,
        Id = "0d26e8e3-0660-4caa-80fd-c8b3d68ced7e",
        IsActive = false,
        IsCompound = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Exempt",
        Rate = 0D,
        Region = "KS",
        TotalRate = 0D,
        Type = AccountingTaxrateType.Sales,
        UpdatedAt = System.DateTime.Parse("2020-02-13T05:56:16.910Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingTaxrate`                                                                                                                              | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingTaxrateQueryParamFields](../../Models/Requests/CreateAccountingTaxrateQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingTaxrateResponse](../../Models/Requests/CreateAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingTaxrate

Retrieves a single AccountingTaxrate by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingTaxrate" method="get" path="/accounting/{connection_id}/taxrate/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.GetAccountingTaxrateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Taxrate                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAccountingTaxrateQueryParamFields](../../Models/Requests/GetAccountingTaxrateQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingTaxrateResponse](../../Models/Requests/GetAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingTaxrates

Returns a list of AccountingTaxrates. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingTaxrates" method="get" path="/accounting/{connection_id}/taxrate" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingTaxratesRequest req = new ListAccountingTaxratesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Taxrate.ListAccountingTaxratesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingTaxratesRequest](../../Models/Requests/ListAccountingTaxratesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingTaxratesResponse](../../Models/Requests/ListAccountingTaxratesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingTaxrate

Updates the AccountingTaxrate identified by `id`. Provide the unified AccountingTaxrate fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingTaxrate" method="patch" path="/accounting/{connection_id}/taxrate/{id}" example="accounting_taxrate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingTaxrateRequest req = new PatchAccountingTaxrateRequest() {
    AccountingTaxrate = new AccountingTaxrate() {
        Components = new List<AccountingTaxrateComponent>() {
            new AccountingTaxrateComponent() {
                IsCompound = false,
                Name = "Exempt",
                Rate = 0D,
            },
        },
        Country = "US",
        CreatedAt = System.DateTime.Parse("2020-01-04T10:37:56.894Z").ToUniversalTime(),
        Description = "Exempt (0%)",
        EffectiveRate = 0D,
        Id = "228d6ab1-859e-48e2-92a1-7b7c541cc432",
        IsActive = false,
        IsCompound = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Exempt",
        Rate = 0D,
        Region = "KS",
        TotalRate = 0D,
        Type = AccountingTaxrateType.Sales,
        UpdatedAt = System.DateTime.Parse("2020-02-13T05:56:16.911Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Taxrate.PatchAccountingTaxrateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingTaxrateRequest](../../Models/Requests/PatchAccountingTaxrateRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingTaxrateResponse](../../Models/Requests/PatchAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingTaxrate

Deletes the AccountingTaxrate identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingTaxrate" method="delete" path="/accounting/{connection_id}/taxrate/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.RemoveAccountingTaxrateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Taxrate    |

### Response

**[RemoveAccountingTaxrateResponse](../../Models/Requests/RemoveAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingTaxrate

Updates the AccountingTaxrate identified by `id`. Provide the unified AccountingTaxrate fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingTaxrate" method="put" path="/accounting/{connection_id}/taxrate/{id}" example="accounting_taxrate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingTaxrateRequest req = new UpdateAccountingTaxrateRequest() {
    AccountingTaxrate = new AccountingTaxrate() {
        Components = new List<AccountingTaxrateComponent>() {
            new AccountingTaxrateComponent() {
                IsCompound = false,
                Name = "Exempt",
                Rate = 0D,
            },
        },
        Country = "US",
        CreatedAt = System.DateTime.Parse("2020-01-04T10:37:56.894Z").ToUniversalTime(),
        Description = "Exempt (0%)",
        EffectiveRate = 0D,
        Id = "228d6ab1-859e-48e2-92a1-7b7c541cc432",
        IsActive = false,
        IsCompound = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Exempt",
        Rate = 0D,
        Region = "KS",
        TotalRate = 0D,
        Type = AccountingTaxrateType.Sales,
        UpdatedAt = System.DateTime.Parse("2020-02-13T05:56:16.911Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Taxrate.UpdateAccountingTaxrateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingTaxrateRequest](../../Models/Requests/UpdateAccountingTaxrateRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingTaxrateResponse](../../Models/Requests/UpdateAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |