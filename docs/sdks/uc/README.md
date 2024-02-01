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
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Uc.CreateUcContactAsync(
    connectionId: "string",
    ucContact: new UcContact() {
    Emails = new List<UcEmail>() {
        new UcEmail() {
            Email = "Dulce_Becker30@yahoo.com",
        },
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Telephones = new List<UcTelephone>() {
        new UcTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_minus_sign:                                                      | A contact represents a person that optionally is associated with a call |


### Response

**[CreateUcContactResponse](../../Models/Requests/CreateUcContactResponse.md)**


## GetUcContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Uc.GetUcContactAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Contact                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetUcContactResponse](../../Models/Requests/GetUcContactResponse.md)**


## ListUcCalls

List all calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Uc.ListUcCallsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListUcCallsRequest](../../Models/Requests/ListUcCallsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[ListUcCallsResponse](../../Models/Requests/ListUcCallsResponse.md)**


## ListUcContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUcContactsRequest req = new ListUcContactsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Uc.ListUcContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListUcContactsRequest](../../Models/Requests/ListUcContactsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListUcContactsResponse](../../Models/Requests/ListUcContactsResponse.md)**


## PatchUcContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Uc.PatchUcContactAsync(
    connectionId: "string",
    id: "string",
    ucContact: new UcContact() {
    Emails = new List<UcEmail>() {
        new UcEmail() {
            Email = "Norene_Boehm97@hotmail.com",
        },
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Telephones = new List<UcTelephone>() {
        new UcTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Id`                                                                    | *string*                                                                | :heavy_check_mark:                                                      | ID of the Contact                                                       |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_minus_sign:                                                      | A contact represents a person that optionally is associated with a call |


### Response

**[PatchUcContactResponse](../../Models/Requests/PatchUcContactResponse.md)**


## RemoveUcContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Uc.RemoveUcContactAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |


### Response

**[RemoveUcContactResponse](../../Models/Requests/RemoveUcContactResponse.md)**


## UpdateUcContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Uc.UpdateUcContactAsync(
    connectionId: "string",
    id: "string",
    ucContact: new UcContact() {
    Emails = new List<UcEmail>() {
        new UcEmail() {
            Email = "Kianna.Witting90@gmail.com",
        },
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Telephones = new List<UcTelephone>() {
        new UcTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Id`                                                                    | *string*                                                                | :heavy_check_mark:                                                      | ID of the Contact                                                       |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_minus_sign:                                                      | A contact represents a person that optionally is associated with a call |


### Response

**[UpdateUcContactResponse](../../Models/Requests/UpdateUcContactResponse.md)**

