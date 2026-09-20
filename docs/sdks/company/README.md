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

Create a company

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
        Id = "7971df34-2a05-4bd1-9ad1-5b731649606f",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-25T04:48:48.050Z").ToUniversalTime(),
        WebsiteUrl = "https://somber-substitution.com/",
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

Create a company

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
            Address1 = "7261 Salisbury Road",
            Address2 = "Apt. 778",
            City = "Harrisburg",
            CountryCode = "US",
            PostalCode = "56293-3678",
            Region = "Pennsylvania",
            RegionCode = "ID",
        },
        CreatedAt = System.DateTime.Parse("2020-05-11T18:26:32.925Z").ToUniversalTime(),
        Description = "Balbus crapula spiculum.",
        Domains = new List<string>() {
            "fussy-nerve.info",
            "sturdy-lobster.org",
            "greedy-offset.name",
        },
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Sandrine_Jacobi@hotmail.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "Sandrine_Jacobi@gmail.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "Sandrine.Jacobi@yahoo.com",
                Type = CrmEmailType.Other,
            },
        },
        Employees = 967D,
        Id = "b41fb9c5-8494-4677-8f60-3f506465cf87",
        Industry = "Infrastructure",
        IsActive = true,
        LinkUrls = new List<string>() {
            "https://blue-license.org",
            "https://minor-formation.com",
            "https://ecstatic-hammock.com",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "e3d045a8-010e-4c71-9a41-9cd3ffec837c",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "esse"
                ),
            },
        },
        Name = "Goodwin and Sons",
        Tags = new List<string>() {
            "quaerat",
            "valeo",
        },
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(432) 849-2690",
                Type = CrmTelephoneType.Mobile,
            },
            new CrmTelephone() {
                Telephone = "(606) 871-2046",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(842) 258-9395",
                Type = CrmTelephoneType.Mobile,
            },
        },
        Timezone = "Europe/San_Marino",
        UpdatedAt = System.DateTime.Parse("2025-02-08T00:35:52.246Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://wise-possession.org",
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

Create a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisCompany" method="post" path="/hris/{connection_id}/company" example="hris_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Company.CreateHrisCompanyAsync(
    hrisCompany: new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "2549 Church Walk",
            City = "Lake Nettiebury",
            CountryCode = "US",
            PostalCode = "32877-4898",
            Region = "Idaho",
            RegionCode = "PA",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "3b256604-57f6-45fd-9675-d6024ee650ad",
        LegalName = "Schultz LLC",
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-09-07T21:10:52.400Z").ToUniversalTime(),
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

Retrieve a company

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

Retrieve a company

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

Retrieve a company

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

List all companies

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

List all companies

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

List all companies

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

Update a company

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
        Id = "e90dba0b-309e-494e-aac2-0b1ab71432d9",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-25T04:48:48.052Z").ToUniversalTime(),
        WebsiteUrl = "https://somber-substitution.com/",
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

Update a company

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
            Address1 = "7261 Salisbury Road",
            Address2 = "Apt. 778",
            City = "Harrisburg",
            CountryCode = "US",
            PostalCode = "56293-3678",
            Region = "Pennsylvania",
            RegionCode = "ID",
        },
        CreatedAt = System.DateTime.Parse("2020-05-11T18:26:32.925Z").ToUniversalTime(),
        Description = "Balbus crapula spiculum.",
        Domains = new List<string>() {
            "fussy-nerve.info",
            "sturdy-lobster.org",
            "greedy-offset.name",
        },
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Sandrine_Jacobi@hotmail.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "Sandrine_Jacobi@gmail.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "Sandrine.Jacobi@yahoo.com",
                Type = CrmEmailType.Other,
            },
        },
        Employees = 967D,
        Id = "8486dbb0-6ec2-4e9c-8f45-af5f710bd060",
        Industry = "Infrastructure",
        IsActive = true,
        LinkUrls = new List<string>() {
            "https://blue-license.org",
            "https://minor-formation.com",
            "https://ecstatic-hammock.com",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "4b632807-cf70-44a3-819a-04a1f94e134c",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "esse"
                ),
            },
        },
        Name = "Goodwin and Sons",
        Tags = new List<string>() {
            "quaerat",
            "valeo",
        },
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(432) 849-2690",
                Type = CrmTelephoneType.Mobile,
            },
            new CrmTelephone() {
                Telephone = "(606) 871-2046",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(842) 258-9395",
                Type = CrmTelephoneType.Mobile,
            },
        },
        Timezone = "Europe/San_Marino",
        UpdatedAt = System.DateTime.Parse("2025-02-08T00:35:52.265Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://wise-possession.org",
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

Update a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisCompany" method="patch" path="/hris/{connection_id}/company/{id}" example="hris_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisCompanyRequest req = new PatchHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "2549 Church Walk",
            City = "Lake Nettiebury",
            CountryCode = "US",
            PostalCode = "32877-4898",
            Region = "Idaho",
            RegionCode = "PA",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "a5e7fc12-b923-4ab4-adff-a7609ec7396d",
        LegalName = "Schultz LLC",
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-09-07T21:10:52.408Z").ToUniversalTime(),
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

Remove a company

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

Remove a company

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

Remove a company

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

Update a company

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
        Id = "e90dba0b-309e-494e-aac2-0b1ab71432d9",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-25T04:48:48.052Z").ToUniversalTime(),
        WebsiteUrl = "https://somber-substitution.com/",
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

Update a company

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
            Address1 = "7261 Salisbury Road",
            Address2 = "Apt. 778",
            City = "Harrisburg",
            CountryCode = "US",
            PostalCode = "56293-3678",
            Region = "Pennsylvania",
            RegionCode = "ID",
        },
        CreatedAt = System.DateTime.Parse("2020-05-11T18:26:32.925Z").ToUniversalTime(),
        Description = "Balbus crapula spiculum.",
        Domains = new List<string>() {
            "fussy-nerve.info",
            "sturdy-lobster.org",
            "greedy-offset.name",
        },
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Sandrine_Jacobi@hotmail.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "Sandrine_Jacobi@gmail.com",
                Type = CrmEmailType.Work,
            },
            new CrmEmail() {
                Email = "Sandrine.Jacobi@yahoo.com",
                Type = CrmEmailType.Other,
            },
        },
        Employees = 967D,
        Id = "8486dbb0-6ec2-4e9c-8f45-af5f710bd060",
        Industry = "Infrastructure",
        IsActive = true,
        LinkUrls = new List<string>() {
            "https://blue-license.org",
            "https://minor-formation.com",
            "https://ecstatic-hammock.com",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "4b632807-cf70-44a3-819a-04a1f94e134c",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "esse"
                ),
            },
        },
        Name = "Goodwin and Sons",
        Tags = new List<string>() {
            "quaerat",
            "valeo",
        },
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(432) 849-2690",
                Type = CrmTelephoneType.Mobile,
            },
            new CrmTelephone() {
                Telephone = "(606) 871-2046",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(842) 258-9395",
                Type = CrmTelephoneType.Mobile,
            },
        },
        Timezone = "Europe/San_Marino",
        UpdatedAt = System.DateTime.Parse("2025-02-08T00:35:52.265Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://wise-possession.org",
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

Update a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisCompany" method="put" path="/hris/{connection_id}/company/{id}" example="hris_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisCompanyRequest req = new UpdateHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "2549 Church Walk",
            City = "Lake Nettiebury",
            CountryCode = "US",
            PostalCode = "32877-4898",
            Region = "Idaho",
            RegionCode = "PA",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "a5e7fc12-b923-4ab4-adff-a7609ec7396d",
        LegalName = "Schultz LLC",
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-09-07T21:10:52.408Z").ToUniversalTime(),
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