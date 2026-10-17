# Expensereport

## Overview

### Available Operations

* [CreateAccountingExpensereport](#createaccountingexpensereport) - Create an expensereport
* [GetAccountingExpensereport](#getaccountingexpensereport) - Retrieve an expensereport
* [ListAccountingExpensereports](#listaccountingexpensereports) - List all expensereports
* [PatchAccountingExpensereport](#patchaccountingexpensereport) - Update an expensereport
* [RemoveAccountingExpensereport](#removeaccountingexpensereport) - Remove an expensereport
* [UpdateAccountingExpensereport](#updateaccountingexpensereport) - Update an expensereport

## CreateAccountingExpensereport

Create an expensereport

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccountingExpensereport" method="post" path="/accounting/{connection_id}/expensereport" example="accounting_expensereport" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expensereport.CreateAccountingExpensereportAsync(
    accountingExpensereport: new AccountingExpensereport() {
        ApprovedAt = System.DateTime.Parse("2025-04-10T23:59:45.129Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "BMD",
        ExternalNumber = "asporto",
        Id = "806d8e50-8acc-477f-b0ef-19b11d7adc2f",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "5ebc2106-74e5-4495-906c-48c934ed7c77",
                ItemDescription = "The Synchronised motivating software Car offers reliable performance and webbed design",
                ItemName = "Intelligent Gold Cheese",
                ItemSku = "978-0-6550-0228-4",
                Notes = "Utrimque quas vesica spes.",
                TaxAmount = 448D,
                TotalAmount = 10875D,
                UnitAmount = 4092D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "73dbe382-1029-4b11-89f3-a541536aa07a",
                ItemDescription = "Ergonomic Bike made with Marble for all-day coordinated support",
                ItemName = "Practical Steel Pizza",
                ItemSku = "978-1-4129-9332-6",
                Notes = "Corrumpo.",
                TaxAmount = 875D,
                TotalAmount = 12363D,
                UnitAmount = 6783D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Rustic Aluminum Car",
        PostedAt = System.DateTime.Parse("2022-11-01T13:37:15.946Z").ToUniversalTime(),
        ReimbursedAmount = 6696D,
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 983D,
        TotalAmount = 13931D,
        UpdatedAt = System.DateTime.Parse("2025-04-10T23:59:45.129Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingExpensereport`                                                                                                                        | [AccountingExpensereport](../../Models/Components/AccountingExpensereport.md)                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingExpensereportQueryParamFields](../../Models/Requests/CreateAccountingExpensereportQueryParamFields.md)>                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingExpensereportResponse](../../Models/Requests/CreateAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingExpensereport

Retrieve an expensereport

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingExpensereport" method="get" path="/accounting/{connection_id}/expensereport/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expensereport.GetAccountingExpensereportAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Expensereport                                                                                                                          |
| `Fields`                                                                                                                                         | List<[GetAccountingExpensereportQueryParamFields](../../Models/Requests/GetAccountingExpensereportQueryParamFields.md)>                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingExpensereportResponse](../../Models/Requests/GetAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingExpensereports

List all expensereports

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingExpensereports" method="get" path="/accounting/{connection_id}/expensereport" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingExpensereportsRequest req = new ListAccountingExpensereportsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Expensereport.ListAccountingExpensereportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListAccountingExpensereportsRequest](../../Models/Requests/ListAccountingExpensereportsRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[ListAccountingExpensereportsResponse](../../Models/Requests/ListAccountingExpensereportsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingExpensereport

Update an expensereport

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingExpensereport" method="patch" path="/accounting/{connection_id}/expensereport/{id}" example="accounting_expensereport" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingExpensereportRequest req = new PatchAccountingExpensereportRequest() {
    AccountingExpensereport = new AccountingExpensereport() {
        ApprovedAt = System.DateTime.Parse("2025-04-10T23:59:45.168Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "BMD",
        ExternalNumber = "asporto",
        Id = "e5cbf141-1cb6-4448-a62f-ace988417822",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "65a8fcae-74f4-4e1d-9443-dec81c75b478",
                ItemDescription = "The Synchronised motivating software Car offers reliable performance and webbed design",
                ItemName = "Intelligent Gold Cheese",
                ItemSku = "978-0-6550-0228-4",
                Notes = "Utrimque quas vesica spes.",
                TaxAmount = 448D,
                TotalAmount = 10875D,
                UnitAmount = 4092D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "14845de2-b94c-4ca0-880d-02df305ba596",
                ItemDescription = "Ergonomic Bike made with Marble for all-day coordinated support",
                ItemName = "Practical Steel Pizza",
                ItemSku = "978-1-4129-9332-6",
                Notes = "Corrumpo.",
                TaxAmount = 875D,
                TotalAmount = 12363D,
                UnitAmount = 6783D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Rustic Aluminum Car",
        PostedAt = System.DateTime.Parse("2022-11-01T13:37:15.965Z").ToUniversalTime(),
        ReimbursedAmount = 6696D,
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 983D,
        TotalAmount = 13931D,
        UpdatedAt = System.DateTime.Parse("2025-04-10T23:59:45.168Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expensereport.PatchAccountingExpensereportAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [PatchAccountingExpensereportRequest](../../Models/Requests/PatchAccountingExpensereportRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[PatchAccountingExpensereportResponse](../../Models/Requests/PatchAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingExpensereport

Remove an expensereport

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingExpensereport" method="delete" path="/accounting/{connection_id}/expensereport/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Expensereport.RemoveAccountingExpensereportAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter               | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `ConnectionId`          | *string*                | :heavy_check_mark:      | ID of the connection    |
| `Id`                    | *string*                | :heavy_check_mark:      | ID of the Expensereport |

### Response

**[RemoveAccountingExpensereportResponse](../../Models/Requests/RemoveAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingExpensereport

Update an expensereport

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingExpensereport" method="put" path="/accounting/{connection_id}/expensereport/{id}" example="accounting_expensereport" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingExpensereportRequest req = new UpdateAccountingExpensereportRequest() {
    AccountingExpensereport = new AccountingExpensereport() {
        ApprovedAt = System.DateTime.Parse("2025-04-10T23:59:45.168Z").ToUniversalTime(),
        Attachments = new List<AccountingAttachment>() {},
        CategoryIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2020-05-29T02:04:59.078Z").ToUniversalTime(),
        Currency = "BMD",
        ExternalNumber = "asporto",
        Id = "e5cbf141-1cb6-4448-a62f-ace988417822",
        Lineitems = new List<AccountingLineitem>() {
            new AccountingLineitem() {
                Id = "65a8fcae-74f4-4e1d-9443-dec81c75b478",
                ItemDescription = "The Synchronised motivating software Car offers reliable performance and webbed design",
                ItemName = "Intelligent Gold Cheese",
                ItemSku = "978-0-6550-0228-4",
                Notes = "Utrimque quas vesica spes.",
                TaxAmount = 448D,
                TotalAmount = 10875D,
                UnitAmount = 4092D,
                UnitQuantity = 1D,
            },
            new AccountingLineitem() {
                Id = "14845de2-b94c-4ca0-880d-02df305ba596",
                ItemDescription = "Ergonomic Bike made with Marble for all-day coordinated support",
                ItemName = "Practical Steel Pizza",
                ItemSku = "978-1-4129-9332-6",
                Notes = "Corrumpo.",
                TaxAmount = 875D,
                TotalAmount = 12363D,
                UnitAmount = 6783D,
                UnitQuantity = 1D,
            },
        },
        Metadata = new List<AccountingMetadata>() {},
        Name = "Rustic Aluminum Car",
        PostedAt = System.DateTime.Parse("2022-11-01T13:37:15.965Z").ToUniversalTime(),
        ReimbursedAmount = 6696D,
        Status = AccountingExpensereportStatus.Paid,
        TaxAmount = 983D,
        TotalAmount = 13931D,
        UpdatedAt = System.DateTime.Parse("2025-04-10T23:59:45.168Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Expensereport.UpdateAccountingExpensereportAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [UpdateAccountingExpensereportRequest](../../Models/Requests/UpdateAccountingExpensereportRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[UpdateAccountingExpensereportResponse](../../Models/Requests/UpdateAccountingExpensereportResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |