# Journal

## Overview

### Available Operations

* [CreateAccountingJournal](#createaccountingjournal) - Create a journal
* [GetAccountingJournal](#getaccountingjournal) - Retrieve a journal
* [ListAccountingJournals](#listaccountingjournals) - List all journals
* [PatchAccountingJournal](#patchaccountingjournal) - Update a journal
* [RemoveAccountingJournal](#removeaccountingjournal) - Remove a journal
* [UpdateAccountingJournal](#updateaccountingjournal) - Update a journal

## CreateAccountingJournal

Create a journal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingJournal" method="post" path="/accounting/{connection_id}/journal" example="accounting_journal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.CreateAccountingJournalAsync(
    accountingJournal: new AccountingJournal() {
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-02-20T15:14:55.881Z").ToUniversalTime(),
        Currency = "RUB",
        Description = "Solum commemoro conor nemo ultio.",
        ExchangeRate = 1.0625D,
        Id = "95573ab0-2508-42ed-8504-0b6059c152c6",
        IsInclusiveOfTax = false,
        Lineitems = new List<AccountingJournalLineitem>() {},
        PostedAt = System.DateTime.Parse("2023-10-31T21:10:41.551Z").ToUniversalTime(),
        Reference = "82523039",
        Source = "amplitudo",
        Status = AccountingJournalStatus.Void,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2022-01-07T23:42:12.421Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingJournal`                                                                                                                              | [AccountingJournal](../../Models/Components/AccountingJournal.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingJournalQueryParamFields](../../Models/Requests/CreateAccountingJournalQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingJournalResponse](../../Models/Requests/CreateAccountingJournalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingJournal

Retrieve a journal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingJournal" method="get" path="/accounting/{connection_id}/journal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.GetAccountingJournalAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Journal                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAccountingJournalQueryParamFields](../../Models/Requests/GetAccountingJournalQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingJournalResponse](../../Models/Requests/GetAccountingJournalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingJournals

List all journals

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingJournals" method="get" path="/accounting/{connection_id}/journal" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Journal.ListAccountingJournalsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingJournalsRequest](../../Models/Requests/ListAccountingJournalsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingJournalsResponse](../../Models/Requests/ListAccountingJournalsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingJournal

Update a journal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingJournal" method="patch" path="/accounting/{connection_id}/journal/{id}" example="accounting_journal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingJournalRequest req = new PatchAccountingJournalRequest() {
    AccountingJournal = new AccountingJournal() {
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-02-20T15:14:55.881Z").ToUniversalTime(),
        Currency = "RUB",
        Description = "Solum commemoro conor nemo ultio.",
        ExchangeRate = 1.0625D,
        Id = "c1e00979-6ffe-46b9-b7ca-6815812ac842",
        IsInclusiveOfTax = false,
        Lineitems = new List<AccountingJournalLineitem>() {},
        PostedAt = System.DateTime.Parse("2023-10-31T21:10:41.563Z").ToUniversalTime(),
        Reference = "82523039",
        Source = "amplitudo",
        Status = AccountingJournalStatus.Void,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2022-01-07T23:42:12.427Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Journal.PatchAccountingJournalAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingJournalRequest](../../Models/Requests/PatchAccountingJournalRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingJournalResponse](../../Models/Requests/PatchAccountingJournalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingJournal

Remove a journal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingJournal" method="delete" path="/accounting/{connection_id}/journal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.RemoveAccountingJournalAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Journal    |

### Response

**[RemoveAccountingJournalResponse](../../Models/Requests/RemoveAccountingJournalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingJournal

Update a journal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingJournal" method="put" path="/accounting/{connection_id}/journal/{id}" example="accounting_journal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingJournalRequest req = new UpdateAccountingJournalRequest() {
    AccountingJournal = new AccountingJournal() {
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-02-20T15:14:55.881Z").ToUniversalTime(),
        Currency = "RUB",
        Description = "Solum commemoro conor nemo ultio.",
        ExchangeRate = 1.0625D,
        Id = "c1e00979-6ffe-46b9-b7ca-6815812ac842",
        IsInclusiveOfTax = false,
        Lineitems = new List<AccountingJournalLineitem>() {},
        PostedAt = System.DateTime.Parse("2023-10-31T21:10:41.563Z").ToUniversalTime(),
        Reference = "82523039",
        Source = "amplitudo",
        Status = AccountingJournalStatus.Void,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2022-01-07T23:42:12.427Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Journal.UpdateAccountingJournalAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingJournalRequest](../../Models/Requests/UpdateAccountingJournalRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingJournalResponse](../../Models/Requests/UpdateAccountingJournalResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |