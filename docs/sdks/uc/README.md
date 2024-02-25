# Uc
(*Uc*)

### Available Operations

* [CreateUcContact](#createuccontact) - Create a contact
* [GetUcContact](#getuccontact) - Retrieve a contact
* [ListUcCalls](#listuccalls) - List all calls
* [ListUcContacts](#listuccontacts) - List all contacts
* [PatchUcContact](#patchuccontact) - Update a contact
* [RemoveUcContact](#removeuccontact) - Remove a contact
* [UpdateUcContact](#updateuccontact) - Update a contact

## CreateUcContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Uc.CreateUcContactAsync(
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


## GetUcContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Uc.GetUcContactAsync(
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


## ListUcCalls

List all calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Uc.ListUcCallsAsync(
    security: new ListUcCallsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListUcCallsRequest](../../Models/Requests/ListUcCallsRequest.md)                             | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [UnifiedTo.Models.Requests.ListUcCallsSecurity](../../Models/Requests/ListUcCallsSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |


### Response

**[ListUcCallsResponse](../../Models/Requests/ListUcCallsResponse.md)**


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

var res = await sdk.Uc.ListUcContactsAsync(
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


## PatchUcContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Uc.PatchUcContactAsync(
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


## RemoveUcContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Uc.RemoveUcContactAsync(
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


## UpdateUcContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Uc.UpdateUcContactAsync(
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

