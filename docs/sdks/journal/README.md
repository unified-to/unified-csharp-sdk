# Journal
(*Journal*)

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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.CreateAccountingJournalAsync(
    connectionId: "<value>",
    accountingJournal: new AccountingJournal() {}
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `AccountingJournal`                                               | [AccountingJournal](../../Models/Components/AccountingJournal.md) | :heavy_minus_sign:                                                | N/A                                                               |

### Response

**[CreateAccountingJournalResponse](../../Models/Requests/CreateAccountingJournalResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## GetAccountingJournal

Retrieve a journal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.GetAccountingJournalAsync(
    connectionId: "<value>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Journal                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetAccountingJournalResponse](../../Models/Requests/GetAccountingJournalResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## ListAccountingJournals

List all journals

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    ConnectionId = "<value>",
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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## PatchAccountingJournal

Update a journal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.PatchAccountingJournalAsync(
    connectionId: "<value>",
    id: "<id>",
    accountingJournal: new AccountingJournal() {}
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Journal                                                 |
| `AccountingJournal`                                               | [AccountingJournal](../../Models/Components/AccountingJournal.md) | :heavy_minus_sign:                                                | N/A                                                               |

### Response

**[PatchAccountingJournalResponse](../../Models/Requests/PatchAccountingJournalResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## RemoveAccountingJournal

Remove a journal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.RemoveAccountingJournalAsync(
    connectionId: "<value>",
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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## UpdateAccountingJournal

Update a journal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Journal.UpdateAccountingJournalAsync(
    connectionId: "<value>",
    id: "<id>",
    accountingJournal: new AccountingJournal() {}
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Journal                                                 |
| `AccountingJournal`                                               | [AccountingJournal](../../Models/Components/AccountingJournal.md) | :heavy_minus_sign:                                                | N/A                                                               |

### Response

**[UpdateAccountingJournalResponse](../../Models/Requests/UpdateAccountingJournalResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
