# Account
(*Account*)

### Available Operations

* [CreateAccountingAccount](#createaccountingaccount) - Create an account
* [GetAccountingAccount](#getaccountingaccount) - Retrieve an account
* [ListAccountingAccounts](#listaccountingaccounts) - List all accounts
* [PatchAccountingAccount](#patchaccountingaccount) - Update an account
* [RemoveAccountingAccount](#removeaccountingaccount) - Remove an account
* [UpdateAccountingAccount](#updateaccountingaccount) - Update an account

## CreateAccountingAccount

Create an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Account.CreateAccountingAccountAsync(
    security: new CreateAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingAccountSecurity](../../Models/Requests/CreateAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingAccount`                                                                                                   | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingAccountResponse](../../Models/Requests/CreateAccountingAccountResponse.md)**


## GetAccountingAccount

Retrieve an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Account.GetAccountingAccountAsync(
    security: new GetAccountingAccountSecurity() {
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
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingAccountSecurity](../../Models/Requests/GetAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Account                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingAccountResponse](../../Models/Requests/GetAccountingAccountResponse.md)**


## ListAccountingAccounts

List all accounts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Account.ListAccountingAccountsAsync(
    security: new ListAccountingAccountsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingAccountsRequest](../../Models/Requests/ListAccountingAccountsRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingAccountsSecurity](../../Models/Requests/ListAccountingAccountsSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingAccountsResponse](../../Models/Requests/ListAccountingAccountsResponse.md)**


## PatchAccountingAccount

Update an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Account.PatchAccountingAccountAsync(
    security: new PatchAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingAccountSecurity](../../Models/Requests/PatchAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Account                                                                                                   |
| `AccountingAccount`                                                                                                 | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingAccountResponse](../../Models/Requests/PatchAccountingAccountResponse.md)**


## RemoveAccountingAccount

Remove an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Account.RemoveAccountingAccountAsync(
    security: new RemoveAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingAccountSecurity](../../Models/Requests/RemoveAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Account                                                                                                     |


### Response

**[RemoveAccountingAccountResponse](../../Models/Requests/RemoveAccountingAccountResponse.md)**


## UpdateAccountingAccount

Update an account

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Account.UpdateAccountingAccountAsync(
    security: new UpdateAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingAccountSecurity](../../Models/Requests/UpdateAccountingAccountSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Account                                                                                                     |
| `AccountingAccount`                                                                                                   | [AccountingAccount](../../Models/Components/AccountingAccount.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingAccountResponse](../../Models/Requests/UpdateAccountingAccountResponse.md)**

