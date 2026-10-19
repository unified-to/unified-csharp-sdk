# Contact

## Overview

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

<!-- UsageSnippet language="csharp" operationID="createAccountingContact" method="post" path="/accounting/{connection_id}/contact" example="accounting_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.CreateAccountingContactAsync(
    accountingContact: new AccountingContact() {
        AssociatedContacts = new List<AccountingAssociatedContact>() {
            new AccountingAssociatedContact() {
                Id = "a0532065-c586-4433-abf6-6f065300586b",
                Name = "Delores Reynolds",
            },
            new AccountingAssociatedContact() {
                Id = "ac4a17f5-7302-46a6-aa6c-f51071d84348",
                Name = "Delores Reynolds",
            },
        },
        BillingAddress = new PropertyAccountingContactBillingAddress() {
            Address1 = "2633 Stoney Lane",
            Address2 = "Suite 176",
            City = "Ladariusboro",
            CountryCode = "US",
            PostalCode = "70131-2908",
            Region = "Illinois",
            RegionCode = "NV",
        },
        CompanyName = "Marquardt Inc",
        CreatedAt = System.DateTime.Parse("2021-08-15T14:56:50.258Z").ToUniversalTime(),
        Currency = "ISK",
        Emails = new List<AccountingEmail>() {
            new AccountingEmail() {
                Email = "Delores.Reynolds10@hotmail.com",
                Type = AccountingEmailType.Home,
            },
        },
        FirstName = "Delores",
        Id = "d52d7847-dc3a-4997-8415-69d0ac0167cd",
        Identification = "amicitia",
        IsActive = true,
        IsCustomer = true,
        LastName = "Reynolds",
        Name = "Delores Reynolds",
        Notes = "Caput accusamus et videlicet.",
        PaymentMethods = new List<AccountingContactPaymentMethod>() {
            new AccountingContactPaymentMethod() {
                Default = true,
                Id = "cceaae83-41c3-437f-90ac-0c80b7348d64",
                Name = "Visa 1234",
                Type = AccountingContactPaymentMethodType.Card,
            },
        },
        PortalUrl = "https://scented-t-shirt.info/",
        ShippingAddress = new PropertyAccountingContactShippingAddress() {
            Address1 = "786 Renner Stream",
            Address2 = "Apt. 555",
            City = "Roanoke",
            CountryCode = "US",
            PostalCode = "80686-7556",
            Region = "Vermont",
            RegionCode = "NE",
        },
        TaxExemption = TaxExemption.Resale,
        TaxNumber = "amplexus",
        Telephones = new List<AccountingTelephone>() {
            new AccountingTelephone() {
                Telephone = "(427) 701-7160",
                Type = AccountingTelephoneType.Home,
            },
            new AccountingTelephone() {
                Telephone = "(540) 913-9171",
                Type = AccountingTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2023-12-18T22:19:55.431Z").ToUniversalTime(),
        Website = "https://noxious-advertisement.org",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AccountingContact`                                                                                                                              | [AccountingContact](../../Models/Components/AccountingContact.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAccountingContactQueryParamFields](../../Models/Requests/CreateAccountingContactQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAccountingContactResponse](../../Models/Requests/CreateAccountingContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmContact

Create a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmContact" method="post" path="/crm/{connection_id}/contact" example="crm_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.CreateCrmContactAsync(
    crmContact: new CrmContact() {
        Address = new PropertyCrmContactAddress() {
            Address1 = "518 Brannon Burg",
            City = "East Helenebury",
            CountryCode = "US",
            PostalCode = "92622-2406",
            Region = "Vermont",
            RegionCode = "AZ",
        },
        Company = "Lowe - Jakubowski",
        CreatedAt = System.DateTime.Parse("2021-01-02T00:41:38.885Z").ToUniversalTime(),
        Department = "systematic",
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Mohammad.Bartell45@hotmail.com",
                Type = CrmEmailType.Home,
            },
            new CrmEmail() {
                Email = "Mohammad.Bartell90@hotmail.com",
                Type = CrmEmailType.Home,
            },
            new CrmEmail() {
                Email = "Mohammad_Bartell@hotmail.com",
                Type = CrmEmailType.Work,
            },
        },
        FirstName = "Mohammad",
        Id = "2bff57e2-f632-45b0-ba8c-bb21209f20a9",
        ImageUrl = "https://picsum.photos/seed/zmbPeg/2905/378",
        LastName = "Bartell",
        LinkUrls = new List<string>() {
            "https://limited-parade.info",
            "https://faint-papa.com/",
            "https://windy-accountability.name",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "e1d633ef-78e8-4fdc-84c2-ebed45fe2933",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "autem"
                ),
            },
        },
        Name = "Mohammad Bartell",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(975) 986-1658",
                Type = CrmTelephoneType.Work,
            },
            new CrmTelephone() {
                Telephone = "(489) 332-3509",
                Type = CrmTelephoneType.Home,
            },
            new CrmTelephone() {
                Telephone = "(205) 880-8886",
                Type = CrmTelephoneType.Home,
            },
        },
        Title = "National Tactics Analyst",
        UpdatedAt = System.DateTime.Parse("2021-02-24T03:51:32.015Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmContact`                                                                                                                                     | [CrmContact](../../Models/Components/CrmContact.md)                                                                                              | :heavy_check_mark:                                                                                                                               | A contact represents a person that optionally is associated with a deal and/or a company                                                         |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmContactQueryParamFields](../../Models/Requests/CreateCrmContactQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmContactResponse](../../Models/Requests/CreateCrmContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateUcContact

Create a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createUcContact" method="post" path="/uc/{connection_id}/contact" example="uc_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.CreateUcContactAsync(
    ucContact: new UcContact() {
        Company = "Tillman Group",
        CreatedAt = System.DateTime.Parse("2019-10-28T11:06:56.460Z").ToUniversalTime(),
        Emails = new List<UcEmail>() {
            new UcEmail() {
                Email = "Luther_Rogahn32@yahoo.com",
                Type = UcEmailType.Work,
            },
        },
        FirstName = "Luther",
        Id = "073273e2-a0f2-404c-89f7-17ef37cc3c8d",
        LastName = "Rogahn",
        Name = "Luther Rogahn",
        Telephones = new List<UcTelephone>() {
            new UcTelephone() {
                Telephone = "(809) 992-1681",
                Type = UcTelephoneType.Fax,
            },
            new UcTelephone() {
                Telephone = "(868) 238-2746",
                Type = UcTelephoneType.Home,
            },
            new UcTelephone() {
                Telephone = "(219) 736-0357",
                Type = UcTelephoneType.Mobile,
            },
        },
        Title = "Chief Optimization Executive",
        UpdatedAt = System.DateTime.Parse("2023-12-07T03:47:05.240Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `UcContact`                                                                                                                                      | [UcContact](../../Models/Components/UcContact.md)                                                                                                | :heavy_check_mark:                                                                                                                               | A contact represents a person that optionally is associated with a call                                                                          |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateUcContactQueryParamFields](../../Models/Requests/CreateUcContactQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateUcContactResponse](../../Models/Requests/CreateUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingContact

Retrieve a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingContact" method="get" path="/accounting/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.GetAccountingContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Contact                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAccountingContactQueryParamFields](../../Models/Requests/GetAccountingContactQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingContactResponse](../../Models/Requests/GetAccountingContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmContact

Retrieve a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmContact" method="get" path="/crm/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.GetCrmContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Contact                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetCrmContactQueryParamFields](../../Models/Requests/GetCrmContactQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmContactResponse](../../Models/Requests/GetCrmContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcContact

Retrieve a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUcContact" method="get" path="/uc/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.GetUcContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Contact                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetUcContactQueryParamFields](../../Models/Requests/GetUcContactQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetUcContactResponse](../../Models/Requests/GetUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingContacts

List all contacts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingContacts" method="get" path="/accounting/{connection_id}/contact" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingContactsRequest req = new ListAccountingContactsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Contact.ListAccountingContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingContactsRequest](../../Models/Requests/ListAccountingContactsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingContactsResponse](../../Models/Requests/ListAccountingContactsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmContacts

List all contacts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmContacts" method="get" path="/crm/{connection_id}/contact" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmContactsRequest req = new ListCrmContactsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcContacts

List all contacts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUcContacts" method="get" path="/uc/{connection_id}/contact" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcContactsRequest req = new ListUcContactsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAccountingContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAccountingContact" method="patch" path="/accounting/{connection_id}/contact/{id}" example="accounting_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAccountingContactRequest req = new PatchAccountingContactRequest() {
    AccountingContact = new AccountingContact() {
        AssociatedContacts = new List<AccountingAssociatedContact>() {
            new AccountingAssociatedContact() {
                Id = "be73f450-7e89-42f8-85d2-32cd2f3ed81f",
                Name = "Delores Reynolds",
            },
            new AccountingAssociatedContact() {
                Id = "94c6211e-ed4b-4b5f-b598-bafa2ef82fb5",
                Name = "Delores Reynolds",
            },
        },
        BillingAddress = new PropertyAccountingContactBillingAddress() {
            Address1 = "2633 Stoney Lane",
            Address2 = "Suite 176",
            City = "Ladariusboro",
            CountryCode = "US",
            PostalCode = "70131-2908",
            Region = "Illinois",
            RegionCode = "NV",
        },
        CompanyName = "Marquardt Inc",
        CreatedAt = System.DateTime.Parse("2021-08-15T14:56:50.258Z").ToUniversalTime(),
        Currency = "ISK",
        Emails = new List<AccountingEmail>() {
            new AccountingEmail() {
                Email = "Delores.Reynolds10@hotmail.com",
                Type = AccountingEmailType.Home,
            },
        },
        FirstName = "Delores",
        Id = "850f3f93-0302-48b0-9d6b-203e4a0dd496",
        Identification = "amicitia",
        IsActive = true,
        IsCustomer = true,
        LastName = "Reynolds",
        Name = "Delores Reynolds",
        Notes = "Caput accusamus et videlicet.",
        PaymentMethods = new List<AccountingContactPaymentMethod>() {
            new AccountingContactPaymentMethod() {
                Default = true,
                Id = "9c472a8e-26c5-4fcc-9b7d-f23fd3e0ba7a",
                Name = "Visa 1234",
                Type = AccountingContactPaymentMethodType.Card,
            },
        },
        PortalUrl = "https://scented-t-shirt.info/",
        ShippingAddress = new PropertyAccountingContactShippingAddress() {
            Address1 = "786 Renner Stream",
            Address2 = "Apt. 555",
            City = "Roanoke",
            CountryCode = "US",
            PostalCode = "80686-7556",
            Region = "Vermont",
            RegionCode = "NE",
        },
        TaxExemption = TaxExemption.Resale,
        TaxNumber = "amplexus",
        Telephones = new List<AccountingTelephone>() {
            new AccountingTelephone() {
                Telephone = "(427) 701-7160",
                Type = AccountingTelephoneType.Home,
            },
            new AccountingTelephone() {
                Telephone = "(540) 913-9171",
                Type = AccountingTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2023-12-18T22:19:55.450Z").ToUniversalTime(),
        Website = "https://noxious-advertisement.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Contact.PatchAccountingContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchAccountingContactRequest](../../Models/Requests/PatchAccountingContactRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchAccountingContactResponse](../../Models/Requests/PatchAccountingContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmContact" method="patch" path="/crm/{connection_id}/contact/{id}" example="crm_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmContactRequest req = new PatchCrmContactRequest() {
    CrmContact = new CrmContact() {
        Address = new PropertyCrmContactAddress() {
            Address1 = "518 Brannon Burg",
            City = "East Helenebury",
            CountryCode = "US",
            PostalCode = "92622-2406",
            Region = "Vermont",
            RegionCode = "AZ",
        },
        Company = "Lowe - Jakubowski",
        CreatedAt = System.DateTime.Parse("2021-01-02T00:41:38.885Z").ToUniversalTime(),
        Department = "systematic",
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Mohammad.Bartell45@hotmail.com",
                Type = CrmEmailType.Home,
            },
            new CrmEmail() {
                Email = "Mohammad.Bartell90@hotmail.com",
                Type = CrmEmailType.Home,
            },
            new CrmEmail() {
                Email = "Mohammad_Bartell@hotmail.com",
                Type = CrmEmailType.Work,
            },
        },
        FirstName = "Mohammad",
        Id = "fad1475e-d83e-45db-8e8c-35d904e32c45",
        ImageUrl = "https://picsum.photos/seed/zmbPeg/2905/378",
        LastName = "Bartell",
        LinkUrls = new List<string>() {
            "https://limited-parade.info",
            "https://faint-papa.com/",
            "https://windy-accountability.name",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "17e6cede-9042-472d-9447-56d5cd31fef3",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "autem"
                ),
            },
        },
        Name = "Mohammad Bartell",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(975) 986-1658",
                Type = CrmTelephoneType.Work,
            },
            new CrmTelephone() {
                Telephone = "(489) 332-3509",
                Type = CrmTelephoneType.Home,
            },
            new CrmTelephone() {
                Telephone = "(205) 880-8886",
                Type = CrmTelephoneType.Home,
            },
        },
        Title = "National Tactics Analyst",
        UpdatedAt = System.DateTime.Parse("2021-02-24T03:51:32.015Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Contact.PatchCrmContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchCrmContactRequest](../../Models/Requests/PatchCrmContactRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchCrmContactResponse](../../Models/Requests/PatchCrmContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchUcContact" method="patch" path="/uc/{connection_id}/contact/{id}" example="uc_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchUcContactRequest req = new PatchUcContactRequest() {
    UcContact = new UcContact() {
        Company = "Tillman Group",
        CreatedAt = System.DateTime.Parse("2019-10-28T11:06:56.460Z").ToUniversalTime(),
        Emails = new List<UcEmail>() {
            new UcEmail() {
                Email = "Luther_Rogahn32@yahoo.com",
                Type = UcEmailType.Work,
            },
        },
        FirstName = "Luther",
        Id = "4bfa49d7-2918-4d2c-a738-20d604812582",
        LastName = "Rogahn",
        Name = "Luther Rogahn",
        Telephones = new List<UcTelephone>() {
            new UcTelephone() {
                Telephone = "(809) 992-1681",
                Type = UcTelephoneType.Fax,
            },
            new UcTelephone() {
                Telephone = "(868) 238-2746",
                Type = UcTelephoneType.Home,
            },
            new UcTelephone() {
                Telephone = "(219) 736-0357",
                Type = UcTelephoneType.Mobile,
            },
        },
        Title = "Chief Optimization Executive",
        UpdatedAt = System.DateTime.Parse("2023-12-07T03:47:05.247Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Contact.PatchUcContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchUcContactRequest](../../Models/Requests/PatchUcContactRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchUcContactResponse](../../Models/Requests/PatchUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAccountingContact

Remove a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountingContact" method="delete" path="/accounting/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.RemoveAccountingContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |

### Response

**[RemoveAccountingContactResponse](../../Models/Requests/RemoveAccountingContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmContact

Remove a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmContact" method="delete" path="/crm/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.RemoveCrmContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |

### Response

**[RemoveCrmContactResponse](../../Models/Requests/RemoveCrmContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUcContact

Remove a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeUcContact" method="delete" path="/uc/{connection_id}/contact/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Contact.RemoveUcContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |

### Response

**[RemoveUcContactResponse](../../Models/Requests/RemoveUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAccountingContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccountingContact" method="put" path="/accounting/{connection_id}/contact/{id}" example="accounting_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAccountingContactRequest req = new UpdateAccountingContactRequest() {
    AccountingContact = new AccountingContact() {
        AssociatedContacts = new List<AccountingAssociatedContact>() {
            new AccountingAssociatedContact() {
                Id = "be73f450-7e89-42f8-85d2-32cd2f3ed81f",
                Name = "Delores Reynolds",
            },
            new AccountingAssociatedContact() {
                Id = "94c6211e-ed4b-4b5f-b598-bafa2ef82fb5",
                Name = "Delores Reynolds",
            },
        },
        BillingAddress = new PropertyAccountingContactBillingAddress() {
            Address1 = "2633 Stoney Lane",
            Address2 = "Suite 176",
            City = "Ladariusboro",
            CountryCode = "US",
            PostalCode = "70131-2908",
            Region = "Illinois",
            RegionCode = "NV",
        },
        CompanyName = "Marquardt Inc",
        CreatedAt = System.DateTime.Parse("2021-08-15T14:56:50.258Z").ToUniversalTime(),
        Currency = "ISK",
        Emails = new List<AccountingEmail>() {
            new AccountingEmail() {
                Email = "Delores.Reynolds10@hotmail.com",
                Type = AccountingEmailType.Home,
            },
        },
        FirstName = "Delores",
        Id = "850f3f93-0302-48b0-9d6b-203e4a0dd496",
        Identification = "amicitia",
        IsActive = true,
        IsCustomer = true,
        LastName = "Reynolds",
        Name = "Delores Reynolds",
        Notes = "Caput accusamus et videlicet.",
        PaymentMethods = new List<AccountingContactPaymentMethod>() {
            new AccountingContactPaymentMethod() {
                Default = true,
                Id = "9c472a8e-26c5-4fcc-9b7d-f23fd3e0ba7a",
                Name = "Visa 1234",
                Type = AccountingContactPaymentMethodType.Card,
            },
        },
        PortalUrl = "https://scented-t-shirt.info/",
        ShippingAddress = new PropertyAccountingContactShippingAddress() {
            Address1 = "786 Renner Stream",
            Address2 = "Apt. 555",
            City = "Roanoke",
            CountryCode = "US",
            PostalCode = "80686-7556",
            Region = "Vermont",
            RegionCode = "NE",
        },
        TaxExemption = TaxExemption.Resale,
        TaxNumber = "amplexus",
        Telephones = new List<AccountingTelephone>() {
            new AccountingTelephone() {
                Telephone = "(427) 701-7160",
                Type = AccountingTelephoneType.Home,
            },
            new AccountingTelephone() {
                Telephone = "(540) 913-9171",
                Type = AccountingTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2023-12-18T22:19:55.450Z").ToUniversalTime(),
        Website = "https://noxious-advertisement.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Contact.UpdateAccountingContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateAccountingContactRequest](../../Models/Requests/UpdateAccountingContactRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateAccountingContactResponse](../../Models/Requests/UpdateAccountingContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmContact" method="put" path="/crm/{connection_id}/contact/{id}" example="crm_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmContactRequest req = new UpdateCrmContactRequest() {
    CrmContact = new CrmContact() {
        Address = new PropertyCrmContactAddress() {
            Address1 = "518 Brannon Burg",
            City = "East Helenebury",
            CountryCode = "US",
            PostalCode = "92622-2406",
            Region = "Vermont",
            RegionCode = "AZ",
        },
        Company = "Lowe - Jakubowski",
        CreatedAt = System.DateTime.Parse("2021-01-02T00:41:38.885Z").ToUniversalTime(),
        Department = "systematic",
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Mohammad.Bartell45@hotmail.com",
                Type = CrmEmailType.Home,
            },
            new CrmEmail() {
                Email = "Mohammad.Bartell90@hotmail.com",
                Type = CrmEmailType.Home,
            },
            new CrmEmail() {
                Email = "Mohammad_Bartell@hotmail.com",
                Type = CrmEmailType.Work,
            },
        },
        FirstName = "Mohammad",
        Id = "fad1475e-d83e-45db-8e8c-35d904e32c45",
        ImageUrl = "https://picsum.photos/seed/zmbPeg/2905/378",
        LastName = "Bartell",
        LinkUrls = new List<string>() {
            "https://limited-parade.info",
            "https://faint-papa.com/",
            "https://windy-accountability.name",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "17e6cede-9042-472d-9447-56d5cd31fef3",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "autem"
                ),
            },
        },
        Name = "Mohammad Bartell",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(975) 986-1658",
                Type = CrmTelephoneType.Work,
            },
            new CrmTelephone() {
                Telephone = "(489) 332-3509",
                Type = CrmTelephoneType.Home,
            },
            new CrmTelephone() {
                Telephone = "(205) 880-8886",
                Type = CrmTelephoneType.Home,
            },
        },
        Title = "National Tactics Analyst",
        UpdatedAt = System.DateTime.Parse("2021-02-24T03:51:32.015Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Contact.UpdateCrmContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateCrmContactRequest](../../Models/Requests/UpdateCrmContactRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateCrmContactResponse](../../Models/Requests/UpdateCrmContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcContact

Update a contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateUcContact" method="put" path="/uc/{connection_id}/contact/{id}" example="uc_contact" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateUcContactRequest req = new UpdateUcContactRequest() {
    UcContact = new UcContact() {
        Company = "Tillman Group",
        CreatedAt = System.DateTime.Parse("2019-10-28T11:06:56.460Z").ToUniversalTime(),
        Emails = new List<UcEmail>() {
            new UcEmail() {
                Email = "Luther_Rogahn32@yahoo.com",
                Type = UcEmailType.Work,
            },
        },
        FirstName = "Luther",
        Id = "4bfa49d7-2918-4d2c-a738-20d604812582",
        LastName = "Rogahn",
        Name = "Luther Rogahn",
        Telephones = new List<UcTelephone>() {
            new UcTelephone() {
                Telephone = "(809) 992-1681",
                Type = UcTelephoneType.Fax,
            },
            new UcTelephone() {
                Telephone = "(868) 238-2746",
                Type = UcTelephoneType.Home,
            },
            new UcTelephone() {
                Telephone = "(219) 736-0357",
                Type = UcTelephoneType.Mobile,
            },
        },
        Title = "Chief Optimization Executive",
        UpdatedAt = System.DateTime.Parse("2023-12-07T03:47:05.247Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Contact.UpdateUcContactAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateUcContactRequest](../../Models/Requests/UpdateUcContactRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateUcContactResponse](../../Models/Requests/UpdateUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |