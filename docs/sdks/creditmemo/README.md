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

Create a creditmemo

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
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://enlightened-chairperson.com/",
                Id = "ad41da31-3dae-4937-a657-fa489a07a343",
                MimeType = "complectus",
                Name = "thesis",
            },
        },
        CreatedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        CreditmemoNumber = "ulterius",
        Currency = "MKD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2023-10-18T04:35:00.543Z").ToUniversalTime(),
        Id = "2982e05d-ce1c-460e-8c4d-0c2d698552e4",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Dedecor amo adfero torqueo quas.",
        PaymentCollectionMethod = AccountingCreditmemoPaymentCollectionMethod.ChargeAutomatically,
        PostedAt = System.DateTime.Parse("2025-11-16T04:10:08.958Z").ToUniversalTime(),
        RefundAmount = 0D,
        RefundReason = "Virgo inflammatio quibusdam aestivus magnam.",
        RefundedAt = System.DateTime.Parse("2023-10-23T00:35:36.814Z").ToUniversalTime(),
        Send = false,
        Status = AccountingCreditmemoStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2024-11-15T22:43:50.085Z").ToUniversalTime(),
        Url = "https://lighthearted-bandwidth.net/",
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

Retrieve a creditmemo

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

List all creditmemoes

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

Update a creditmemo

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
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://enlightened-chairperson.com/",
                Id = "18a149b6-ba34-4c85-bd95-7adefbf6bef1",
                MimeType = "complectus",
                Name = "thesis",
            },
        },
        CreatedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        CreditmemoNumber = "ulterius",
        Currency = "MKD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2023-10-18T04:35:00.543Z").ToUniversalTime(),
        Id = "1419c5ce-e6fd-4f57-bb23-0466b2cc27d5",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Dedecor amo adfero torqueo quas.",
        PaymentCollectionMethod = AccountingCreditmemoPaymentCollectionMethod.ChargeAutomatically,
        PostedAt = System.DateTime.Parse("2025-11-16T04:10:08.990Z").ToUniversalTime(),
        RefundAmount = 0D,
        RefundReason = "Virgo inflammatio quibusdam aestivus magnam.",
        RefundedAt = System.DateTime.Parse("2023-10-23T00:35:36.814Z").ToUniversalTime(),
        Send = false,
        Status = AccountingCreditmemoStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2024-11-15T22:43:50.102Z").ToUniversalTime(),
        Url = "https://lighthearted-bandwidth.net/",
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

Remove a creditmemo

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

Update a creditmemo

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
        Attachments = new List<AccountingAttachment>() {
            new AccountingAttachment() {
                DownloadUrl = "https://enlightened-chairperson.com/",
                Id = "18a149b6-ba34-4c85-bd95-7adefbf6bef1",
                MimeType = "complectus",
                Name = "thesis",
            },
        },
        CreatedAt = System.DateTime.Parse("2023-09-20T01:47:01.571Z").ToUniversalTime(),
        CreditmemoNumber = "ulterius",
        Currency = "MKD",
        DiscountAmount = 0D,
        DueAt = System.DateTime.Parse("2023-10-18T04:35:00.543Z").ToUniversalTime(),
        Id = "1419c5ce-e6fd-4f57-bb23-0466b2cc27d5",
        Lineitems = new List<AccountingLineitem>() {},
        Metadata = new List<AccountingMetadata>() {},
        Notes = "Dedecor amo adfero torqueo quas.",
        PaymentCollectionMethod = AccountingCreditmemoPaymentCollectionMethod.ChargeAutomatically,
        PostedAt = System.DateTime.Parse("2025-11-16T04:10:08.990Z").ToUniversalTime(),
        RefundAmount = 0D,
        RefundReason = "Virgo inflammatio quibusdam aestivus magnam.",
        RefundedAt = System.DateTime.Parse("2023-10-23T00:35:36.814Z").ToUniversalTime(),
        Send = false,
        Status = AccountingCreditmemoStatus.Paid,
        TaxAmount = 0D,
        TotalAmount = 0D,
        UpdatedAt = System.DateTime.Parse("2024-11-15T22:43:50.102Z").ToUniversalTime(),
        Url = "https://lighthearted-bandwidth.net/",
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