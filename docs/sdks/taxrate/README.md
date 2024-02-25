# Taxrate
(*Taxrate*)

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
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Taxrate.CreateAccountingTaxrateAsync(
    security: new CreateAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingTaxrate: new AccountingTaxrate() {
    Name = "<value>",
    Rate = 1719.1D,
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingTaxrateSecurity](../../Models/Requests/CreateAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingTaxrate`                                                                                                   | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingTaxrateResponse](../../Models/Requests/CreateAccountingTaxrateResponse.md)**


## GetAccountingTaxrate

Retrieve a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Taxrate.GetAccountingTaxrateAsync(
    security: new GetAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingTaxrateSecurity](../../Models/Requests/GetAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Taxrate                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingTaxrateResponse](../../Models/Requests/GetAccountingTaxrateResponse.md)**


## ListAccountingTaxrates

List all taxrates

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingTaxratesRequest req = new ListAccountingTaxratesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Taxrate.ListAccountingTaxratesAsync(
    security: new ListAccountingTaxratesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingTaxratesRequest](../../Models/Requests/ListAccountingTaxratesRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingTaxratesSecurity](../../Models/Requests/ListAccountingTaxratesSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingTaxratesResponse](../../Models/Requests/ListAccountingTaxratesResponse.md)**


## PatchAccountingTaxrate

Update a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Taxrate.PatchAccountingTaxrateAsync(
    security: new PatchAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTaxrate: new AccountingTaxrate() {
    Name = "<value>",
    Rate = 5991.47D,
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingTaxrateSecurity](../../Models/Requests/PatchAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Taxrate                                                                                                   |
| `AccountingTaxrate`                                                                                                 | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingTaxrateResponse](../../Models/Requests/PatchAccountingTaxrateResponse.md)**


## RemoveAccountingTaxrate

Remove a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Taxrate.RemoveAccountingTaxrateAsync(
    security: new RemoveAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingTaxrateSecurity](../../Models/Requests/RemoveAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Taxrate                                                                                                     |


### Response

**[RemoveAccountingTaxrateResponse](../../Models/Requests/RemoveAccountingTaxrateResponse.md)**


## UpdateAccountingTaxrate

Update a taxrate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Taxrate.UpdateAccountingTaxrateAsync(
    security: new UpdateAccountingTaxrateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingTaxrate: new AccountingTaxrate() {
    Name = "<value>",
    Rate = 3382.78D,
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingTaxrateSecurity](../../Models/Requests/UpdateAccountingTaxrateSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Taxrate                                                                                                     |
| `AccountingTaxrate`                                                                                                   | [AccountingTaxrate](../../Models/Components/AccountingTaxrate.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingTaxrateResponse](../../Models/Requests/UpdateAccountingTaxrateResponse.md)**

