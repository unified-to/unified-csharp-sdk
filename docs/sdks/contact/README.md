# Contact
(*Contact*)

### Available Operations

* [CreateAccountingContact](#createaccountingcontact) - Create a contact
* [CreateCrmContact](#createcrmcontact) - Create a contact
* [CreateUcContact](#createuccontact) - Create a contact
* [GetAccountingContact](#getaccountingcontact) - Retrieve a contact
* [GetCrmContact](#getcrmcontact) - Retrieve a contact
* [GetUcContact](#getuccontact) - Retrieve a contact
* [ListAccountingContacts](#listaccountingcontacts) - List all contacts
* [ListCrmContacts](#listcrmcontacts) - List all contacts
* [ListUcContacts](#listuccontacts) - List all contacts
* [PatchAccountingContact](#patchaccountingcontact) - Update a contact
* [PatchCrmContact](#patchcrmcontact) - Update a contact
* [PatchUcContact](#patchuccontact) - Update a contact
* [RemoveAccountingContact](#removeaccountingcontact) - Remove a contact
* [RemoveCrmContact](#removecrmcontact) - Remove a contact
* [RemoveUcContact](#removeuccontact) - Remove a contact
* [UpdateAccountingContact](#updateaccountingcontact) - Update a contact
* [UpdateCrmContact](#updatecrmcontact) - Update a contact
* [UpdateUcContact](#updateuccontact) - Update a contact

## CreateAccountingContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.CreateAccountingContactAsync(
    security: new CreateAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingContact: new AccountingContact() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateAccountingContactSecurity](../../Models/Requests/CreateAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `AccountingContact`                                                                                                   | [AccountingContact](../../Models/Components/AccountingContact.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[CreateAccountingContactResponse](../../Models/Requests/CreateAccountingContactResponse.md)**


## CreateCrmContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.CreateCrmContactAsync(
    security: new CreateCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmContact: new CrmContact() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.CreateCrmContactSecurity](../../Models/Requests/CreateCrmContactSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `CrmContact`                                                                                            | [CrmContact](../../Models/Components/CrmContact.md)                                                     | :heavy_minus_sign:                                                                                      | A contact represents a person that optionally is associated with a deal and/or a company                |


### Response

**[CreateCrmContactResponse](../../Models/Requests/CreateCrmContactResponse.md)**


## CreateUcContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.CreateUcContactAsync(
    security: new CreateUcContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    ucContact: new UcContact() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.CreateUcContactSecurity](../../Models/Requests/CreateUcContactSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `UcContact`                                                                                           | [UcContact](../../Models/Components/UcContact.md)                                                     | :heavy_minus_sign:                                                                                    | A contact represents a person that optionally is associated with a call                               |


### Response

**[CreateUcContactResponse](../../Models/Requests/CreateUcContactResponse.md)**


## GetAccountingContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.GetAccountingContactAsync(
    security: new GetAccountingContactSecurity() {
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
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetAccountingContactSecurity](../../Models/Requests/GetAccountingContactSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Contact                                                                                               |
| `Fields`                                                                                                        | List<*string*>                                                                                                  | :heavy_minus_sign:                                                                                              | Comma-delimited fields to return                                                                                |


### Response

**[GetAccountingContactResponse](../../Models/Requests/GetAccountingContactResponse.md)**


## GetCrmContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.GetCrmContactAsync(
    security: new GetCrmContactSecurity() {
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

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.GetCrmContactSecurity](../../Models/Requests/GetCrmContactSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Contact                                                                                 |
| `Fields`                                                                                          | List<*string*>                                                                                    | :heavy_minus_sign:                                                                                | Comma-delimited fields to return                                                                  |


### Response

**[GetCrmContactResponse](../../Models/Requests/GetCrmContactResponse.md)**


## GetUcContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.GetUcContactAsync(
    security: new GetUcContactSecurity() {
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

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.GetUcContactSecurity](../../Models/Requests/GetUcContactSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Contact                                                                               |
| `Fields`                                                                                        | List<*string*>                                                                                  | :heavy_minus_sign:                                                                              | Comma-delimited fields to return                                                                |


### Response

**[GetUcContactResponse](../../Models/Requests/GetUcContactResponse.md)**


## ListAccountingContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingContactsRequest req = new ListAccountingContactsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Contact.ListAccountingContactsAsync(
    security: new ListAccountingContactsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingContactsRequest](../../Models/Requests/ListAccountingContactsRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListAccountingContactsSecurity](../../Models/Requests/ListAccountingContactsSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListAccountingContactsResponse](../../Models/Requests/ListAccountingContactsResponse.md)**


## ListCrmContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmContactsRequest req = new ListCrmContactsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Contact.ListCrmContactsAsync(
    security: new ListCrmContactsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListCrmContactsRequest](../../Models/Requests/ListCrmContactsRequest.md)                             | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |
| `security`                                                                                            | [UnifiedTo.Models.Requests.ListCrmContactsSecurity](../../Models/Requests/ListCrmContactsSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |


### Response

**[ListCrmContactsResponse](../../Models/Requests/ListCrmContactsResponse.md)**


## ListUcContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListUcContactsRequest req = new ListUcContactsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Contact.ListUcContactsAsync(
    security: new ListUcContactsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListUcContactsRequest](../../Models/Requests/ListUcContactsRequest.md)                             | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |
| `security`                                                                                          | [UnifiedTo.Models.Requests.ListUcContactsSecurity](../../Models/Requests/ListUcContactsSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |


### Response

**[ListUcContactsResponse](../../Models/Requests/ListUcContactsResponse.md)**


## PatchAccountingContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.PatchAccountingContactAsync(
    security: new PatchAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingContact: new AccountingContact() {});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchAccountingContactSecurity](../../Models/Requests/PatchAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Contact                                                                                                   |
| `AccountingContact`                                                                                                 | [AccountingContact](../../Models/Components/AccountingContact.md)                                                   | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[PatchAccountingContactResponse](../../Models/Requests/PatchAccountingContactResponse.md)**


## PatchCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.PatchCrmContactAsync(
    security: new PatchCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmContact: new CrmContact() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.PatchCrmContactSecurity](../../Models/Requests/PatchCrmContactSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Contact                                                                                     |
| `CrmContact`                                                                                          | [CrmContact](../../Models/Components/CrmContact.md)                                                   | :heavy_minus_sign:                                                                                    | A contact represents a person that optionally is associated with a deal and/or a company              |


### Response

**[PatchCrmContactResponse](../../Models/Requests/PatchCrmContactResponse.md)**


## PatchUcContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.PatchUcContactAsync(
    security: new PatchUcContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ucContact: new UcContact() {});

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.PatchUcContactSecurity](../../Models/Requests/PatchUcContactSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Contact                                                                                   |
| `UcContact`                                                                                         | [UcContact](../../Models/Components/UcContact.md)                                                   | :heavy_minus_sign:                                                                                  | A contact represents a person that optionally is associated with a call                             |


### Response

**[PatchUcContactResponse](../../Models/Requests/PatchUcContactResponse.md)**


## RemoveAccountingContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.RemoveAccountingContactAsync(
    security: new RemoveAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveAccountingContactSecurity](../../Models/Requests/RemoveAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Contact                                                                                                     |


### Response

**[RemoveAccountingContactResponse](../../Models/Requests/RemoveAccountingContactResponse.md)**


## RemoveCrmContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.RemoveCrmContactAsync(
    security: new RemoveCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.RemoveCrmContactSecurity](../../Models/Requests/RemoveCrmContactSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Contact                                                                                       |


### Response

**[RemoveCrmContactResponse](../../Models/Requests/RemoveCrmContactResponse.md)**


## RemoveUcContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.RemoveUcContactAsync(
    security: new RemoveUcContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.RemoveUcContactSecurity](../../Models/Requests/RemoveUcContactSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Contact                                                                                     |


### Response

**[RemoveUcContactResponse](../../Models/Requests/RemoveUcContactResponse.md)**


## UpdateAccountingContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.UpdateAccountingContactAsync(
    security: new UpdateAccountingContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    accountingContact: new AccountingContact() {});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateAccountingContactSecurity](../../Models/Requests/UpdateAccountingContactSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `ConnectionId`                                                                                                        | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the connection                                                                                                  |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Contact                                                                                                     |
| `AccountingContact`                                                                                                   | [AccountingContact](../../Models/Components/AccountingContact.md)                                                     | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |


### Response

**[UpdateAccountingContactResponse](../../Models/Requests/UpdateAccountingContactResponse.md)**


## UpdateCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.UpdateCrmContactAsync(
    security: new UpdateCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmContact: new CrmContact() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.UpdateCrmContactSecurity](../../Models/Requests/UpdateCrmContactSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Contact                                                                                       |
| `CrmContact`                                                                                            | [CrmContact](../../Models/Components/CrmContact.md)                                                     | :heavy_minus_sign:                                                                                      | A contact represents a person that optionally is associated with a deal and/or a company                |


### Response

**[UpdateCrmContactResponse](../../Models/Requests/UpdateCrmContactResponse.md)**


## UpdateUcContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Contact.UpdateUcContactAsync(
    security: new UpdateUcContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    ucContact: new UcContact() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.UpdateUcContactSecurity](../../Models/Requests/UpdateUcContactSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Contact                                                                                     |
| `UcContact`                                                                                           | [UcContact](../../Models/Components/UcContact.md)                                                     | :heavy_minus_sign:                                                                                    | A contact represents a person that optionally is associated with a call                               |


### Response

**[UpdateUcContactResponse](../../Models/Requests/UpdateUcContactResponse.md)**

