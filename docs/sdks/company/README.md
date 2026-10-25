# Company

## Overview

### Available Operations

* [CreateAtsCompany](#createatscompany) - Create a company
* [CreateCrmCompany](#createcrmcompany) - Create a company
* [CreateHrisCompany](#createhriscompany) - Create a company
* [GetAtsCompany](#getatscompany) - Retrieve a company
* [GetCrmCompany](#getcrmcompany) - Retrieve a company
* [GetHrisCompany](#gethriscompany) - Retrieve a company
* [ListAtsCompanies](#listatscompanies) - List all companies
* [ListCrmCompanies](#listcrmcompanies) - List all companies
* [ListEnrichCompanies](#listenrichcompanies) - Retrieve enrichment information for a company
* [ListHrisCompanies](#listhriscompanies) - List all companies
* [PatchAtsCompany](#patchatscompany) - Update a company
* [PatchCrmCompany](#patchcrmcompany) - Update a company
* [PatchHrisCompany](#patchhriscompany) - Update a company
* [RemoveAtsCompany](#removeatscompany) - Remove a company
* [RemoveCrmCompany](#removecrmcompany) - Remove a company
* [RemoveHrisCompany](#removehriscompany) - Remove a company
* [UpdateAtsCompany](#updateatscompany) - Update a company
* [UpdateCrmCompany](#updatecrmcompany) - Update a company
* [UpdateHrisCompany](#updatehriscompany) - Update a company

## CreateAtsCompany

Creates a AtsCompany. Provide the unified AtsCompany fields in the request body; they are mapped to the provider's API. Returns the created AtsCompany.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsCompany" method="post" path="/ats/{connection_id}/company" example="ats_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.CreateAtsCompanyAsync(
    atsCompany: new AtsCompany() {
        CreatedAt = System.DateTime.Parse("2019-04-22T03:50:02.920Z").ToUniversalTime(),
        Id = "7ef89f54-9460-4c99-b3c3-25dbcdfeedff",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-882-360-2010",
        UpdatedAt = System.DateTime.Parse("2020-10-01T22:37:04.474Z").ToUniversalTime(),
        WebsiteUrl = "https://www.gulgowskidibbert.com",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsCompany`                                                                                                                                     | [AtsCompany](../../Models/Components/AtsCompany.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsCompanyQueryParamFields](../../Models/Requests/CreateAtsCompanyQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsCompanyResponse](../../Models/Requests/CreateAtsCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmCompany

Creates a CrmCompany. Provide the unified CrmCompany fields in the request body; they are mapped to the provider's API. Returns the created CrmCompany.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmCompany" method="post" path="/crm/{connection_id}/company" example="crm_company" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.CreateCrmCompanyAsync(
    crmCompany: new CrmCompany() {
        Address = new PropertyCrmCompanyAddress() {
            Address1 = "3328 Wunsch Flat",
            Address2 = "Suite 905",
            City = "New Ryderfort",
            CountryCode = "US",
            PostalCode = "04674",
            Region = "Delaware",
            RegionCode = "NY",
        },
        CreatedAt = System.DateTime.Parse("2020-05-11T18:26:32.925Z").ToUniversalTime(),
        Description = "Venustas cruentus votum patruus terebro.",
        Domains = new List<string>() {
            "goodwinsons.com",
        },
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "info@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "sales@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "support@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
        },
        Employees = 4177D,
        Id = "4392546b-a2cc-4171-94e2-5c81ed76aa7f",
        Industry = "Metrics",
        IsActive = true,
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/company/goodwin-and-sons",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "2ebeec46-37f2-4370-8f7e-66e58fa54b95",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "unde"
                ),
            },
        },
        Name = "Goodwin and Sons",
        Tags = new List<string>() {
            "censura",
            "abstergo",
            "ipsam",
        },
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(667) 607-5872",
                Type = CrmTelephoneType.Home,
            },
        },
        Timezone = "Atlantic/Azores",
        UpdatedAt = System.DateTime.Parse("2025-03-06T03:01:10.027Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://www.goodwinsons.com",
        },
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmCompany`                                                                                                                                     | [CrmCompany](../../Models/Components/CrmCompany.md)                                                                                              | :heavy_check_mark:                                                                                                                               | A company represents an organization that optionally is associated with a deal and/or contacts                                                   |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmCompanyQueryParamFields](../../Models/Requests/CreateCrmCompanyQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmCompanyResponse](../../Models/Requests/CreateCrmCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisCompany

Creates a HrisCompany. Provide the unified HrisCompany fields in the request body; they are mapped to the provider's API. Returns the created HrisCompany.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisCompany" method="post" path="/hris/{connection_id}/company" example="hris_company" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.CreateHrisCompanyAsync(
    hrisCompany: new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "675 Lavinia Lights",
            City = "Rocky Mount",
            CountryCode = "US",
            PostalCode = "67325",
            Region = "Kentucky",
            RegionCode = "MO",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "9a57a290-019d-4769-9314-f2b6580fda35",
        LegalName = "Gottlieb Group LLC",
        Metadata = new List<HrisMetadata>() {},
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-10-12T15:17:37.818Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisCompany`                                                                                                                                    | [HrisCompany](../../Models/Components/HrisCompany.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisCompanyQueryParamFields](../../Models/Requests/CreateHrisCompanyQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisCompanyResponse](../../Models/Requests/CreateHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsCompany

Retrieves a single AtsCompany by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsCompany" method="get" path="/ats/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.GetAtsCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Company                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetAtsCompanyQueryParamFields](../../Models/Requests/GetAtsCompanyQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsCompanyResponse](../../Models/Requests/GetAtsCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmCompany

Retrieves a single CrmCompany by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmCompany" method="get" path="/crm/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.GetCrmCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Company                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetCrmCompanyQueryParamFields](../../Models/Requests/GetCrmCompanyQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmCompanyResponse](../../Models/Requests/GetCrmCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisCompany

Retrieves a single HrisCompany by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisCompany" method="get" path="/hris/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.GetHrisCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Company                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisCompanyQueryParamFields](../../Models/Requests/GetHrisCompanyQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisCompanyResponse](../../Models/Requests/GetHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsCompanies

Returns a list of AtsCompanies. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsCompanies" method="get" path="/ats/{connection_id}/company" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsCompaniesRequest req = new ListAtsCompaniesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Company.ListAtsCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAtsCompaniesRequest](../../Models/Requests/ListAtsCompaniesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListAtsCompaniesResponse](../../Models/Requests/ListAtsCompaniesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmCompanies

Returns a list of CrmCompanies. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmCompanies" method="get" path="/crm/{connection_id}/company" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmCompaniesRequest req = new ListCrmCompaniesRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListEnrichCompanies

Retrieve enrichment information for a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEnrichCompanies" method="get" path="/enrich/{connection_id}/company" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.ListEnrichCompaniesAsync(connectionId: "<id>");

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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisCompanies

Returns a list of HrisCompanies. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisCompanies" method="get" path="/hris/{connection_id}/company" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisCompaniesRequest req = new ListHrisCompaniesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Company.ListHrisCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisCompaniesRequest](../../Models/Requests/ListHrisCompaniesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisCompaniesResponse](../../Models/Requests/ListHrisCompaniesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsCompany

Updates the AtsCompany identified by `id`. Provide the unified AtsCompany fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsCompany" method="patch" path="/ats/{connection_id}/company/{id}" example="ats_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsCompanyRequest req = new PatchAtsCompanyRequest() {
    AtsCompany = new AtsCompany() {
        CreatedAt = System.DateTime.Parse("2019-04-22T03:50:02.920Z").ToUniversalTime(),
        Id = "af2e0bc2-fcca-43a5-a91d-ef6f11fb8326",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-882-360-2010",
        UpdatedAt = System.DateTime.Parse("2020-10-01T22:37:04.477Z").ToUniversalTime(),
        WebsiteUrl = "https://www.gulgowskidibbert.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Company.PatchAtsCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchAtsCompanyRequest](../../Models/Requests/PatchAtsCompanyRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchAtsCompanyResponse](../../Models/Requests/PatchAtsCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmCompany

Updates the CrmCompany identified by `id`. Provide the unified CrmCompany fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmCompany" method="patch" path="/crm/{connection_id}/company/{id}" example="crm_company" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmCompanyRequest req = new PatchCrmCompanyRequest() {
    CrmCompany = new CrmCompany() {
        Address = new PropertyCrmCompanyAddress() {
            Address1 = "3328 Wunsch Flat",
            Address2 = "Suite 905",
            City = "New Ryderfort",
            CountryCode = "US",
            PostalCode = "04674",
            Region = "Delaware",
            RegionCode = "NY",
        },
        CreatedAt = System.DateTime.Parse("2020-05-11T18:26:32.925Z").ToUniversalTime(),
        Description = "Venustas cruentus votum patruus terebro.",
        Domains = new List<string>() {
            "goodwinsons.com",
        },
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "info@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "sales@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "support@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
        },
        Employees = 4177D,
        Id = "3cf3eecb-2767-4630-9bfe-3a752b8f9ce2",
        Industry = "Metrics",
        IsActive = true,
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/company/goodwin-and-sons",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "e78d132d-c1a6-4afd-a1b8-7f5b382955c0",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "unde"
                ),
            },
        },
        Name = "Goodwin and Sons",
        Tags = new List<string>() {
            "censura",
            "abstergo",
            "ipsam",
        },
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(667) 607-5872",
                Type = CrmTelephoneType.Home,
            },
        },
        Timezone = "Atlantic/Azores",
        UpdatedAt = System.DateTime.Parse("2025-03-06T03:01:10.046Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://www.goodwinsons.com",
        },
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Company.PatchCrmCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchCrmCompanyRequest](../../Models/Requests/PatchCrmCompanyRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchCrmCompanyResponse](../../Models/Requests/PatchCrmCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisCompany

Updates the HrisCompany identified by `id`. Provide the unified HrisCompany fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisCompany" method="patch" path="/hris/{connection_id}/company/{id}" example="hris_company" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisCompanyRequest req = new PatchHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "675 Lavinia Lights",
            City = "Rocky Mount",
            CountryCode = "US",
            PostalCode = "67325",
            Region = "Kentucky",
            RegionCode = "MO",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "11e67b1a-3dd2-4faf-a8fa-c5d188c676aa",
        LegalName = "Gottlieb Group LLC",
        Metadata = new List<HrisMetadata>() {},
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-10-12T15:17:37.838Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Company.PatchHrisCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisCompanyRequest](../../Models/Requests/PatchHrisCompanyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisCompanyResponse](../../Models/Requests/PatchHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsCompany

Deletes the AtsCompany identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsCompany" method="delete" path="/ats/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.RemoveAtsCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Company    |

### Response

**[RemoveAtsCompanyResponse](../../Models/Requests/RemoveAtsCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmCompany

Deletes the CrmCompany identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmCompany" method="delete" path="/crm/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.RemoveCrmCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Company    |

### Response

**[RemoveCrmCompanyResponse](../../Models/Requests/RemoveCrmCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisCompany

Deletes the HrisCompany identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisCompany" method="delete" path="/hris/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.RemoveHrisCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Company    |

### Response

**[RemoveHrisCompanyResponse](../../Models/Requests/RemoveHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsCompany

Updates the AtsCompany identified by `id`. Provide the unified AtsCompany fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsCompany" method="put" path="/ats/{connection_id}/company/{id}" example="ats_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsCompanyRequest req = new UpdateAtsCompanyRequest() {
    AtsCompany = new AtsCompany() {
        CreatedAt = System.DateTime.Parse("2019-04-22T03:50:02.920Z").ToUniversalTime(),
        Id = "af2e0bc2-fcca-43a5-a91d-ef6f11fb8326",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-882-360-2010",
        UpdatedAt = System.DateTime.Parse("2020-10-01T22:37:04.477Z").ToUniversalTime(),
        WebsiteUrl = "https://www.gulgowskidibbert.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Company.UpdateAtsCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateAtsCompanyRequest](../../Models/Requests/UpdateAtsCompanyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateAtsCompanyResponse](../../Models/Requests/UpdateAtsCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmCompany

Updates the CrmCompany identified by `id`. Provide the unified CrmCompany fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmCompany" method="put" path="/crm/{connection_id}/company/{id}" example="crm_company" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmCompanyRequest req = new UpdateCrmCompanyRequest() {
    CrmCompany = new CrmCompany() {
        Address = new PropertyCrmCompanyAddress() {
            Address1 = "3328 Wunsch Flat",
            Address2 = "Suite 905",
            City = "New Ryderfort",
            CountryCode = "US",
            PostalCode = "04674",
            Region = "Delaware",
            RegionCode = "NY",
        },
        CreatedAt = System.DateTime.Parse("2020-05-11T18:26:32.925Z").ToUniversalTime(),
        Description = "Venustas cruentus votum patruus terebro.",
        Domains = new List<string>() {
            "goodwinsons.com",
        },
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "info@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "sales@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "support@goodwinsons.com",
                Type = CrmEmailType.Work,
            },
        },
        Employees = 4177D,
        Id = "3cf3eecb-2767-4630-9bfe-3a752b8f9ce2",
        Industry = "Metrics",
        IsActive = true,
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/company/goodwin-and-sons",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "e78d132d-c1a6-4afd-a1b8-7f5b382955c0",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "unde"
                ),
            },
        },
        Name = "Goodwin and Sons",
        Tags = new List<string>() {
            "censura",
            "abstergo",
            "ipsam",
        },
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(667) 607-5872",
                Type = CrmTelephoneType.Home,
            },
        },
        Timezone = "Atlantic/Azores",
        UpdatedAt = System.DateTime.Parse("2025-03-06T03:01:10.046Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://www.goodwinsons.com",
        },
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Company.UpdateCrmCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateCrmCompanyRequest](../../Models/Requests/UpdateCrmCompanyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateCrmCompanyResponse](../../Models/Requests/UpdateCrmCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisCompany

Updates the HrisCompany identified by `id`. Provide the unified HrisCompany fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisCompany" method="put" path="/hris/{connection_id}/company/{id}" example="hris_company" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisCompanyRequest req = new UpdateHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "675 Lavinia Lights",
            City = "Rocky Mount",
            CountryCode = "US",
            PostalCode = "67325",
            Region = "Kentucky",
            RegionCode = "MO",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "11e67b1a-3dd2-4faf-a8fa-c5d188c676aa",
        LegalName = "Gottlieb Group LLC",
        Metadata = new List<HrisMetadata>() {},
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-10-12T15:17:37.838Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Company.UpdateHrisCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisCompanyRequest](../../Models/Requests/UpdateHrisCompanyRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisCompanyResponse](../../Models/Requests/UpdateHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |