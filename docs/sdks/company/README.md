# Company
(*Company*)

### Available Operations

* [CreateCrmCompany](#createcrmcompany) - Create a company
* [GetCrmCompany](#getcrmcompany) - Retrieve a company
* [ListCrmCompanies](#listcrmcompanies) - List all companies
* [ListEnrichCompanies](#listenrichcompanies) - Retrieve enrichment information for a company
* [PatchCrmCompany](#patchcrmcompany) - Update a company
* [RemoveCrmCompany](#removecrmcompany) - Remove a company
* [UpdateCrmCompany](#updatecrmcompany) - Update a company

## CreateCrmCompany

Create a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Company.CreateCrmCompanyAsync(ConnectionId: "string", CrmCompany: new CrmCompany() {
    Address = new PropertyCrmCompanyAddress() {},
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyCrmCompanyRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
    Websites = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                 | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the connection                                                                           |
| `CrmCompany`                                                                                   | [CrmCompany](../../Models/Components/CrmCompany.md)                                            | :heavy_minus_sign:                                                                             | A company represents an organization that optionally is associated with a deal and/or contacts |


### Response

**[CreateCrmCompanyResponse](../../Models/Requests/CreateCrmCompanyResponse.md)**


## GetCrmCompany

Retrieve a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Company.GetCrmCompanyAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Company                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmCompanyResponse](../../Models/Requests/GetCrmCompanyResponse.md)**


## ListCrmCompanies

List all companies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmCompaniesRequest req = new ListCrmCompaniesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Company.ListCrmCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListCrmCompaniesRequest](../../Models/Requests/ListCrmCompaniesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListCrmCompaniesResponse](../../Models/Requests/ListCrmCompaniesResponse.md)**


## ListEnrichCompanies

Retrieve enrichment information for a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Company.ListEnrichCompaniesAsync(ConnectionId: "string", Domain: "string", Name: "string");

// handle response
```

### Parameters

| Parameter                           | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `ConnectionId`                      | *string*                            | :heavy_check_mark:                  | ID of the connection                |
| `Domain`                            | *string*                            | :heavy_minus_sign:                  | The domain of the company to search |
| `Name`                              | *string*                            | :heavy_minus_sign:                  | The name of the company to search   |


### Response

**[ListEnrichCompaniesResponse](../../Models/Requests/ListEnrichCompaniesResponse.md)**


## PatchCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Company.PatchCrmCompanyAsync(ConnectionId: "string", Id: "string", CrmCompany: new CrmCompany() {
    Address = new PropertyCrmCompanyAddress() {},
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyCrmCompanyRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
    Websites = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                 | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the connection                                                                           |
| `Id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the Company                                                                              |
| `CrmCompany`                                                                                   | [CrmCompany](../../Models/Components/CrmCompany.md)                                            | :heavy_minus_sign:                                                                             | A company represents an organization that optionally is associated with a deal and/or contacts |


### Response

**[PatchCrmCompanyResponse](../../Models/Requests/PatchCrmCompanyResponse.md)**


## RemoveCrmCompany

Remove a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Company.RemoveCrmCompanyAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Company    |


### Response

**[RemoveCrmCompanyResponse](../../Models/Requests/RemoveCrmCompanyResponse.md)**


## UpdateCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Company.UpdateCrmCompanyAsync(ConnectionId: "string", Id: "string", CrmCompany: new CrmCompany() {
    Address = new PropertyCrmCompanyAddress() {},
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyCrmCompanyRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
    Websites = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                 | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the connection                                                                           |
| `Id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the Company                                                                              |
| `CrmCompany`                                                                                   | [CrmCompany](../../Models/Components/CrmCompany.md)                                            | :heavy_minus_sign:                                                                             | A company represents an organization that optionally is associated with a deal and/or contacts |


### Response

**[UpdateCrmCompanyResponse](../../Models/Requests/UpdateCrmCompanyResponse.md)**

