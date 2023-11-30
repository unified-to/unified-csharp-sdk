# Contact
(*Contact*)

### Available Operations

* [CreateCrmContact](#createcrmcontact) - Create a contact
* [CreateUcContact](#createuccontact) - Create a contact
* [GetCrmContact](#getcrmcontact) - Retrieve a contact
* [GetUcContact](#getuccontact) - Retrieve a contact
* [ListCrmContacts](#listcrmcontacts) - List all contacts
* [ListUcContacts](#listuccontacts) - List all contacts
* [PatchCrmContact](#patchcrmcontact) - Update a contact
* [PatchUcContact](#patchuccontact) - Update a contact
* [RemoveCrmContact](#removecrmcontact) - Remove a contact
* [RemoveUcContact](#removeuccontact) - Remove a contact
* [UpdateCrmContact](#updatecrmcontact) - Update a contact
* [UpdateUcContact](#updateuccontact) - Update a contact

## CreateCrmContact

Create a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.CreateCrmContactAsync(ConnectionId: "string", CrmContact: new CrmContact() {
    Address = new PropertyCrmContactAddress() {},
    CompanyIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmContactRaw() {},
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                           | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the connection                                                                     |
| `CrmContact`                                                                             | [CrmContact](../../Models/Components/CrmContact.md)                                      | :heavy_minus_sign:                                                                       | A contact represents a person that optionally is associated with a deal and/or a company |


### Response

**[CreateCrmContactResponse](../../Models/Requests/CreateCrmContactResponse.md)**


## CreateUcContact

Create a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.CreateUcContactAsync(ConnectionId: "string", UcContact: new UcContact() {
    Emails = new List<UcEmail>() {
        new UcEmail() {
            Email = "Dulce_Becker30@yahoo.com",
        },
    },
    Raw = new PropertyUcContactRaw() {},
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


## GetCrmContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.GetCrmContactAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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

**[GetCrmContactResponse](../../Models/Requests/GetCrmContactResponse.md)**


## GetUcContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.GetUcContactAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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


## ListCrmContacts

List all contacts

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

ListCrmContactsRequest req = new ListCrmContactsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Contact.ListCrmContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListCrmContactsRequest](../../Models/Requests/ListCrmContactsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[ListCrmContactsResponse](../../Models/Requests/ListCrmContactsResponse.md)**


## ListUcContacts

List all contacts

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

ListUcContactsRequest req = new ListUcContactsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Contact.ListUcContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListUcContactsRequest](../../Models/Requests/ListUcContactsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListUcContactsResponse](../../Models/Requests/ListUcContactsResponse.md)**


## PatchCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.PatchCrmContactAsync(ConnectionId: "string", Id: "string", CrmContact: new CrmContact() {
    Address = new PropertyCrmContactAddress() {},
    CompanyIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmContactRaw() {},
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                           | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the connection                                                                     |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the Contact                                                                        |
| `CrmContact`                                                                             | [CrmContact](../../Models/Components/CrmContact.md)                                      | :heavy_minus_sign:                                                                       | A contact represents a person that optionally is associated with a deal and/or a company |


### Response

**[PatchCrmContactResponse](../../Models/Requests/PatchCrmContactResponse.md)**


## PatchUcContact

Update a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.PatchUcContactAsync(ConnectionId: "string", Id: "string", UcContact: new UcContact() {
    Emails = new List<UcEmail>() {
        new UcEmail() {
            Email = "Norene_Boehm97@hotmail.com",
        },
    },
    Raw = new PropertyUcContactRaw() {},
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


## RemoveCrmContact

Remove a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.RemoveCrmContactAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |


### Response

**[RemoveCrmContactResponse](../../Models/Requests/RemoveCrmContactResponse.md)**


## RemoveUcContact

Remove a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.RemoveUcContactAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |


### Response

**[RemoveUcContactResponse](../../Models/Requests/RemoveUcContactResponse.md)**


## UpdateCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.UpdateCrmContactAsync(ConnectionId: "string", Id: "string", CrmContact: new CrmContact() {
    Address = new PropertyCrmContactAddress() {},
    CompanyIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmContactRaw() {},
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                           | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the connection                                                                     |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the Contact                                                                        |
| `CrmContact`                                                                             | [CrmContact](../../Models/Components/CrmContact.md)                                      | :heavy_minus_sign:                                                                       | A contact represents a person that optionally is associated with a deal and/or a company |


### Response

**[UpdateCrmContactResponse](../../Models/Requests/UpdateCrmContactResponse.md)**


## UpdateUcContact

Update a contact

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

var res = await sdk.Contact.UpdateUcContactAsync(ConnectionId: "string", Id: "string", UcContact: new UcContact() {
    Emails = new List<UcEmail>() {
        new UcEmail() {
            Email = "Kianna.Witting90@gmail.com",
        },
    },
    Raw = new PropertyUcContactRaw() {},
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

