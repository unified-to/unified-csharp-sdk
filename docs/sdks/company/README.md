# Company
(*Company*)

### Available Operations

* [CreateCrmCompany](#createcrmcompany) - Create a company
* [GetAtsCompany](#getatscompany) - Retrieve a company
* [GetCrmCompany](#getcrmcompany) - Retrieve a company
* [ListAtsCompanies](#listatscompanies) - List all companies
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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.CreateCrmCompanyAsync(
    security: new CreateCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmCompany: new CrmCompany() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.CreateCrmCompanySecurity](../../Models/Requests/CreateCrmCompanySecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `CrmCompany`                                                                                            | [CrmCompany](../../Models/Components/CrmCompany.md)                                                     | :heavy_minus_sign:                                                                                      | A company represents an organization that optionally is associated with a deal and/or contacts          |


### Response

**[CreateCrmCompanyResponse](../../Models/Requests/CreateCrmCompanyResponse.md)**


## GetAtsCompany

Retrieve a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.GetAtsCompanyAsync(
    security: new GetAtsCompanySecurity() {
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
| `security`                                                                                        | [UnifiedTo.Models.Requests.GetAtsCompanySecurity](../../Models/Requests/GetAtsCompanySecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Company                                                                                 |
| `Fields`                                                                                          | List<*string*>                                                                                    | :heavy_minus_sign:                                                                                | Comma-delimited fields to return                                                                  |


### Response

**[GetAtsCompanyResponse](../../Models/Requests/GetAtsCompanyResponse.md)**


## GetCrmCompany

Retrieve a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.GetCrmCompanyAsync(
    security: new GetCrmCompanySecurity() {
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
| `security`                                                                                        | [UnifiedTo.Models.Requests.GetCrmCompanySecurity](../../Models/Requests/GetCrmCompanySecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Company                                                                                 |
| `Fields`                                                                                          | List<*string*>                                                                                    | :heavy_minus_sign:                                                                                | Comma-delimited fields to return                                                                  |


### Response

**[GetCrmCompanyResponse](../../Models/Requests/GetCrmCompanyResponse.md)**


## ListAtsCompanies

List all companies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAtsCompaniesRequest req = new ListAtsCompaniesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Company.ListAtsCompaniesAsync(
    security: new ListAtsCompaniesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListAtsCompaniesRequest](../../Models/Requests/ListAtsCompaniesRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListAtsCompaniesSecurity](../../Models/Requests/ListAtsCompaniesSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListAtsCompaniesResponse](../../Models/Requests/ListAtsCompaniesResponse.md)**


## ListCrmCompanies

List all companies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmCompaniesRequest req = new ListCrmCompaniesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Company.ListCrmCompaniesAsync(
    security: new ListCrmCompaniesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListCrmCompaniesRequest](../../Models/Requests/ListCrmCompaniesRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListCrmCompaniesSecurity](../../Models/Requests/ListCrmCompaniesSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListCrmCompaniesResponse](../../Models/Requests/ListCrmCompaniesResponse.md)**


## ListEnrichCompanies

Retrieve enrichment information for a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.ListEnrichCompaniesAsync(
    security: new ListEnrichCompaniesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    domain: "<value>",
    name: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.ListEnrichCompaniesSecurity](../../Models/Requests/ListEnrichCompaniesSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Domain`                                                                                                      | *string*                                                                                                      | :heavy_minus_sign:                                                                                            | The domain of the company to search                                                                           |
| `Name`                                                                                                        | *string*                                                                                                      | :heavy_minus_sign:                                                                                            | The name of the company to search                                                                             |


### Response

**[ListEnrichCompaniesResponse](../../Models/Requests/ListEnrichCompaniesResponse.md)**


## PatchCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.PatchCrmCompanyAsync(
    security: new PatchCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmCompany: new CrmCompany() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.PatchCrmCompanySecurity](../../Models/Requests/PatchCrmCompanySecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Company                                                                                     |
| `CrmCompany`                                                                                          | [CrmCompany](../../Models/Components/CrmCompany.md)                                                   | :heavy_minus_sign:                                                                                    | A company represents an organization that optionally is associated with a deal and/or contacts        |


### Response

**[PatchCrmCompanyResponse](../../Models/Requests/PatchCrmCompanyResponse.md)**


## RemoveCrmCompany

Remove a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.RemoveCrmCompanyAsync(
    security: new RemoveCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.RemoveCrmCompanySecurity](../../Models/Requests/RemoveCrmCompanySecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Company                                                                                       |


### Response

**[RemoveCrmCompanyResponse](../../Models/Requests/RemoveCrmCompanyResponse.md)**


## UpdateCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Company.UpdateCrmCompanyAsync(
    security: new UpdateCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmCompany: new CrmCompany() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.UpdateCrmCompanySecurity](../../Models/Requests/UpdateCrmCompanySecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Company                                                                                       |
| `CrmCompany`                                                                                            | [CrmCompany](../../Models/Components/CrmCompany.md)                                                     | :heavy_minus_sign:                                                                                      | A company represents an organization that optionally is associated with a deal and/or contacts          |


### Response

**[UpdateCrmCompanyResponse](../../Models/Requests/UpdateCrmCompanyResponse.md)**

