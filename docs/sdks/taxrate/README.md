# Taxrate
(*Taxrate*)

## Overview

### Available Operations

* [CreateAccountingTaxrate](#createaccountingtaxrate) - Create a taxrate
* [GetAccountingTaxrate](#getaccountingtaxrate) - Retrieve a taxrate
* [ListAccountingTaxrates](#listaccountingtaxrates) - List all taxrates
* [PatchAccountingTaxrate](#patchaccountingtaxrate) - Update a taxrate
* [RemoveAccountingTaxrate](#removeaccountingtaxrate) - Remove a taxrate
* [UpdateAccountingTaxrate](#updateaccountingtaxrate) - Update a taxrate

## CreateAccountingTaxrate

Create a taxrate

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.CreateAccountingTaxrateAsync(
    accountingTaxrate: new AccountingTaxrate() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AccountingTaxrate`                                               | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md) | :heavy_check_mark:                                                | N/A                                                               |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Fields`                                                          | List<*string*>                                                    | :heavy_minus_sign:                                                | Comma-delimited fields to return                                  |

### Response

**[CreateAccountingTaxrateResponse](../../Models/Requests/CreateAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingTaxrate

Retrieve a taxrate

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.GetAccountingTaxrateAsync(
    connectionId: "<id>",
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Taxrate                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetAccountingTaxrateResponse](../../Models/Requests/GetAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingTaxrates

List all taxrates

### Example Usage

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

Update a taxrate

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.PatchAccountingTaxrateAsync(
    accountingTaxrate: new AccountingTaxrate() {},
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AccountingTaxrate`                                               | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md) | :heavy_check_mark:                                                | N/A                                                               |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Taxrate                                                 |
| `Fields`                                                          | List<*string*>                                                    | :heavy_minus_sign:                                                | Comma-delimited fields to return                                  |

### Response

**[PatchAccountingTaxrateResponse](../../Models/Requests/PatchAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingTaxrate

Remove a taxrate

### Example Usage

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

Update a taxrate

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Taxrate.UpdateAccountingTaxrateAsync(
    accountingTaxrate: new AccountingTaxrate() {},
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AccountingTaxrate`                                               | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md) | :heavy_check_mark:                                                | N/A                                                               |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Taxrate                                                 |
| `Fields`                                                          | List<*string*>                                                    | :heavy_minus_sign:                                                | Comma-delimited fields to return                                  |

### Response

**[UpdateAccountingTaxrateResponse](../../Models/Requests/UpdateAccountingTaxrateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |