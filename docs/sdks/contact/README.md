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

Creates a AccountingContact. Provide the unified AccountingContact fields in the request body; they are mapped to the provider's API. Returns the created AccountingContact.

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
        AssociatedContacts = new List<AccountingAssociatedContact>() {},
        BalanceAmount = 55574D,
        BillingAddress = new PropertyAccountingContactBillingAddress() {
            Address1 = "4091 Tromp Coves",
            City = "Lake Emmybury",
            CountryCode = "US",
            PostalCode = "50764-5226",
            Region = "Washington",
            RegionCode = "CA",
        },
        CompanyName = "Kertzmann Group",
        CreatedAt = System.DateTime.Parse("2021-08-15T14:56:50.258Z").ToUniversalTime(),
        Currency = "AUD",
        Emails = new List<AccountingEmail>() {
            new AccountingEmail() {
                Email = "delores.reynolds@kertzmanngroup.com",
                Type = AccountingEmailType.Work,
            },
            new AccountingEmail() {
                Email = "accounts@kertzmanngroup.com",
                Type = AccountingEmailType.Other,
            },
        },
        FirstName = "Delores",
        Id = "6464a679-cb05-4a42-8bb3-e7da3e2653bd",
        Identification = "531850872",
        IsActive = true,
        IsCustomer = true,
        LastName = "Reynolds",
        Metadata = new List<AccountingMetadata>() {},
        Name = "Kertzmann Group",
        Notes = "Et videlicet pauci.",
        PaymentMethods = new List<AccountingContactPaymentMethod>() {
            new AccountingContactPaymentMethod() {
                Default = true,
                Id = "f0fd9a2f-68d2-4fc9-ab80-6357b30278f8",
                Name = "Visa 7844",
                Type = AccountingContactPaymentMethodType.Card,
            },
        },
        PortalUrl = "https://kertzmanngroup.com/billing",
        ShippingAddress = new PropertyAccountingContactShippingAddress() {
            Address1 = "23129 Rebekah Mews",
            City = "Mortimerhaven",
            CountryCode = "US",
            PostalCode = "55878-6806",
            Region = "Florida",
            RegionCode = "OK",
        },
        TaxExemption = TaxExemption.Foreign,
        TaxNumber = "867556410",
        Telephones = new List<AccountingTelephone>() {
            new AccountingTelephone() {
                Telephone = "(432) 760-1716",
                Type = AccountingTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2023-12-21T16:04:05.999Z").ToUniversalTime(),
        Website = "https://kertzmanngroup.com",
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

Creates a CrmContact. Provide the unified CrmContact fields in the request body; they are mapped to the provider's API. Returns the created CrmContact.

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
            Address1 = "65838 College Avenue",
            Address2 = "Apt. 335",
            City = "Fort Alexandratown",
            CountryCode = "US",
            PostalCode = "80888-6094",
            Region = "Montana",
            RegionCode = "NM",
        },
        CreatedAt = System.DateTime.Parse("2021-01-02T00:41:38.885Z").ToUniversalTime(),
        Department = "Beauty",
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "mohammad.bartell@hotmail.com",
                Type = CrmEmailType.Home,
            },
        },
        FirstName = "Mohammad",
        Id = "3a77bf20-a81a-44b8-89eb-5f47cb73c451",
        ImageUrl = "https://avatars.githubusercontent.com/u/26803724",
        LastName = "Bartell",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/mohammad-bartell",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "7be9c96f-6f96-422e-bbd8-e78e7c8bb2b6",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "antiquus"
                ),
            },
        },
        Name = "Mohammad Bartell",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(254) 404-3529",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(469) 989-7588",
                Type = CrmTelephoneType.Work,
            },
        },
        Title = "National Tactics Analyst",
        UpdatedAt = System.DateTime.Parse("2021-02-24T07:30:25.389Z").ToUniversalTime(),
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

Creates a UcContact. Provide the unified UcContact fields in the request body; they are mapped to the provider's API. Returns the created UcContact.

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
        Id = "36dd45bb-8e15-48c3-8bed-ddeb0c445114",
        LastName = "Rogahn",
        Metadata = new List<UcMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2023-12-10T17:22:11.031Z").ToUniversalTime(),
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

Retrieves a single AccountingContact by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CrmContact by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single UcContact by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of AccountingContacts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CrmContacts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of UcContacts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the AccountingContact identified by `id`. Provide the unified AccountingContact fields to change in the request body.

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
        AssociatedContacts = new List<AccountingAssociatedContact>() {},
        BalanceAmount = 55574D,
        BillingAddress = new PropertyAccountingContactBillingAddress() {
            Address1 = "4091 Tromp Coves",
            City = "Lake Emmybury",
            CountryCode = "US",
            PostalCode = "50764-5226",
            Region = "Washington",
            RegionCode = "CA",
        },
        CompanyName = "Kertzmann Group",
        CreatedAt = System.DateTime.Parse("2021-08-15T14:56:50.258Z").ToUniversalTime(),
        Currency = "AUD",
        Emails = new List<AccountingEmail>() {
            new AccountingEmail() {
                Email = "delores.reynolds@kertzmanngroup.com",
                Type = AccountingEmailType.Work,
            },
            new AccountingEmail() {
                Email = "accounts@kertzmanngroup.com",
                Type = AccountingEmailType.Other,
            },
        },
        FirstName = "Delores",
        Id = "4e03d390-1054-47db-a556-e105040a0a6f",
        Identification = "531850872",
        IsActive = true,
        IsCustomer = true,
        LastName = "Reynolds",
        Metadata = new List<AccountingMetadata>() {},
        Name = "Kertzmann Group",
        Notes = "Et videlicet pauci.",
        PaymentMethods = new List<AccountingContactPaymentMethod>() {
            new AccountingContactPaymentMethod() {
                Default = true,
                Id = "8ec96076-0bb8-4d8e-8578-4162b06c4e0b",
                Name = "Visa 7844",
                Type = AccountingContactPaymentMethodType.Card,
            },
        },
        PortalUrl = "https://kertzmanngroup.com/billing",
        ShippingAddress = new PropertyAccountingContactShippingAddress() {
            Address1 = "23129 Rebekah Mews",
            City = "Mortimerhaven",
            CountryCode = "US",
            PostalCode = "55878-6806",
            Region = "Florida",
            RegionCode = "OK",
        },
        TaxExemption = TaxExemption.Foreign,
        TaxNumber = "867556410",
        Telephones = new List<AccountingTelephone>() {
            new AccountingTelephone() {
                Telephone = "(432) 760-1716",
                Type = AccountingTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2023-12-21T16:04:06.024Z").ToUniversalTime(),
        Website = "https://kertzmanngroup.com",
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

Updates the CrmContact identified by `id`. Provide the unified CrmContact fields to change in the request body.

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
            Address1 = "65838 College Avenue",
            Address2 = "Apt. 335",
            City = "Fort Alexandratown",
            CountryCode = "US",
            PostalCode = "80888-6094",
            Region = "Montana",
            RegionCode = "NM",
        },
        CreatedAt = System.DateTime.Parse("2021-01-02T00:41:38.885Z").ToUniversalTime(),
        Department = "Beauty",
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "mohammad.bartell@hotmail.com",
                Type = CrmEmailType.Home,
            },
        },
        FirstName = "Mohammad",
        Id = "7a24b0a3-f7ee-42b2-8ec9-9a8a52eb56b4",
        ImageUrl = "https://avatars.githubusercontent.com/u/26803724",
        LastName = "Bartell",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/mohammad-bartell",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "1d7d5e9c-020e-44a4-b144-b90f3eba51c5",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "antiquus"
                ),
            },
        },
        Name = "Mohammad Bartell",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(254) 404-3529",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(469) 989-7588",
                Type = CrmTelephoneType.Work,
            },
        },
        Title = "National Tactics Analyst",
        UpdatedAt = System.DateTime.Parse("2021-02-24T07:30:25.390Z").ToUniversalTime(),
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

Updates the UcContact identified by `id`. Provide the unified UcContact fields to change in the request body.

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
        Id = "ac1bef6b-d31b-4ac9-a511-386dedfcf00b",
        LastName = "Rogahn",
        Metadata = new List<UcMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2023-12-10T17:22:11.043Z").ToUniversalTime(),
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

Deletes the AccountingContact identified by `id`.

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

Deletes the CrmContact identified by `id`.

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

Deletes the UcContact identified by `id`.

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

Updates the AccountingContact identified by `id`. Provide the unified AccountingContact fields to change in the request body.

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
        AssociatedContacts = new List<AccountingAssociatedContact>() {},
        BalanceAmount = 55574D,
        BillingAddress = new PropertyAccountingContactBillingAddress() {
            Address1 = "4091 Tromp Coves",
            City = "Lake Emmybury",
            CountryCode = "US",
            PostalCode = "50764-5226",
            Region = "Washington",
            RegionCode = "CA",
        },
        CompanyName = "Kertzmann Group",
        CreatedAt = System.DateTime.Parse("2021-08-15T14:56:50.258Z").ToUniversalTime(),
        Currency = "AUD",
        Emails = new List<AccountingEmail>() {
            new AccountingEmail() {
                Email = "delores.reynolds@kertzmanngroup.com",
                Type = AccountingEmailType.Work,
            },
            new AccountingEmail() {
                Email = "accounts@kertzmanngroup.com",
                Type = AccountingEmailType.Other,
            },
        },
        FirstName = "Delores",
        Id = "4e03d390-1054-47db-a556-e105040a0a6f",
        Identification = "531850872",
        IsActive = true,
        IsCustomer = true,
        LastName = "Reynolds",
        Metadata = new List<AccountingMetadata>() {},
        Name = "Kertzmann Group",
        Notes = "Et videlicet pauci.",
        PaymentMethods = new List<AccountingContactPaymentMethod>() {
            new AccountingContactPaymentMethod() {
                Default = true,
                Id = "8ec96076-0bb8-4d8e-8578-4162b06c4e0b",
                Name = "Visa 7844",
                Type = AccountingContactPaymentMethodType.Card,
            },
        },
        PortalUrl = "https://kertzmanngroup.com/billing",
        ShippingAddress = new PropertyAccountingContactShippingAddress() {
            Address1 = "23129 Rebekah Mews",
            City = "Mortimerhaven",
            CountryCode = "US",
            PostalCode = "55878-6806",
            Region = "Florida",
            RegionCode = "OK",
        },
        TaxExemption = TaxExemption.Foreign,
        TaxNumber = "867556410",
        Telephones = new List<AccountingTelephone>() {
            new AccountingTelephone() {
                Telephone = "(432) 760-1716",
                Type = AccountingTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2023-12-21T16:04:06.024Z").ToUniversalTime(),
        Website = "https://kertzmanngroup.com",
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

Updates the CrmContact identified by `id`. Provide the unified CrmContact fields to change in the request body.

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
            Address1 = "65838 College Avenue",
            Address2 = "Apt. 335",
            City = "Fort Alexandratown",
            CountryCode = "US",
            PostalCode = "80888-6094",
            Region = "Montana",
            RegionCode = "NM",
        },
        CreatedAt = System.DateTime.Parse("2021-01-02T00:41:38.885Z").ToUniversalTime(),
        Department = "Beauty",
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "mohammad.bartell@hotmail.com",
                Type = CrmEmailType.Home,
            },
        },
        FirstName = "Mohammad",
        Id = "7a24b0a3-f7ee-42b2-8ec9-9a8a52eb56b4",
        ImageUrl = "https://avatars.githubusercontent.com/u/26803724",
        LastName = "Bartell",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/mohammad-bartell",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "1d7d5e9c-020e-44a4-b144-b90f3eba51c5",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "antiquus"
                ),
            },
        },
        Name = "Mohammad Bartell",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(254) 404-3529",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(469) 989-7588",
                Type = CrmTelephoneType.Work,
            },
        },
        Title = "National Tactics Analyst",
        UpdatedAt = System.DateTime.Parse("2021-02-24T07:30:25.390Z").ToUniversalTime(),
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

Updates the UcContact identified by `id`. Provide the unified UcContact fields to change in the request body.

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
        Id = "ac1bef6b-d31b-4ac9-a511-386dedfcf00b",
        LastName = "Rogahn",
        Metadata = new List<UcMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2023-12-10T17:22:11.043Z").ToUniversalTime(),
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