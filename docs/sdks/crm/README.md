# Crm

## Overview

### Available Operations

* [CreateCrmCompany](#createcrmcompany) - Create a company
* [CreateCrmContact](#createcrmcontact) - Create a contact
* [CreateCrmDeal](#createcrmdeal) - Create a deal
* [CreateCrmEvent](#createcrmevent) - Create an event
* [CreateCrmLead](#createcrmlead) - Create a lead
* [CreateCrmPipeline](#createcrmpipeline) - Create a pipeline
* [GetCrmCompany](#getcrmcompany) - Retrieve a company
* [GetCrmContact](#getcrmcontact) - Retrieve a contact
* [GetCrmDeal](#getcrmdeal) - Retrieve a deal
* [GetCrmEvent](#getcrmevent) - Retrieve an event
* [GetCrmLead](#getcrmlead) - Retrieve a lead
* [GetCrmPipeline](#getcrmpipeline) - Retrieve a pipeline
* [ListCrmCompanies](#listcrmcompanies) - List all companies
* [ListCrmContacts](#listcrmcontacts) - List all contacts
* [ListCrmDeals](#listcrmdeals) - List all deals
* [ListCrmEvents](#listcrmevents) - List all events
* [ListCrmLeads](#listcrmleads) - List all leads
* [ListCrmPipelines](#listcrmpipelines) - List all pipelines
* [ListCrmTaxonomies](#listcrmtaxonomies) - List all taxonomies
* [PatchCrmCompany](#patchcrmcompany) - Update a company
* [PatchCrmContact](#patchcrmcontact) - Update a contact
* [PatchCrmDeal](#patchcrmdeal) - Update a deal
* [PatchCrmEvent](#patchcrmevent) - Update an event
* [PatchCrmLead](#patchcrmlead) - Update a lead
* [PatchCrmPipeline](#patchcrmpipeline) - Update a pipeline
* [RemoveCrmCompany](#removecrmcompany) - Remove a company
* [RemoveCrmContact](#removecrmcontact) - Remove a contact
* [RemoveCrmDeal](#removecrmdeal) - Remove a deal
* [RemoveCrmEvent](#removecrmevent) - Remove an event
* [RemoveCrmLead](#removecrmlead) - Remove a lead
* [RemoveCrmPipeline](#removecrmpipeline) - Remove a pipeline
* [UpdateCrmCompany](#updatecrmcompany) - Update a company
* [UpdateCrmContact](#updatecrmcontact) - Update a contact
* [UpdateCrmDeal](#updatecrmdeal) - Update a deal
* [UpdateCrmEvent](#updatecrmevent) - Update an event
* [UpdateCrmLead](#updatecrmlead) - Update a lead
* [UpdateCrmPipeline](#updatecrmpipeline) - Update a pipeline

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

var res = await sdk.Crm.CreateCrmCompanyAsync(
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
        Id = "8c00a300-3be6-4c52-9269-7ad0a8811c0b",
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
                Id = "4b089547-c718-46ef-bb40-98fc0c781fc8",
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
        UpdatedAt = System.DateTime.Parse("2025-03-03T03:56:40.927Z").ToUniversalTime(),
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

var res = await sdk.Crm.CreateCrmContactAsync(
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
        Id = "2a17266a-ae35-4620-9775-fd254091c73f",
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
                Id = "2e81c79b-9557-45ad-82d7-bad66dfb4a5e",
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
        UpdatedAt = System.DateTime.Parse("2021-02-24T05:06:56.977Z").ToUniversalTime(),
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

## CreateCrmDeal

Create a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmDeal" method="post" path="/crm/{connection_id}/deal" example="crm_deal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.CreateCrmDealAsync(
    crmDeal: new CrmDeal() {
        Amount = 98162D,
        ClosedAt = System.DateTime.Parse("2024-03-10T10:10:00.332Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-31T12:48:39.602Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "USD",
        Description = "Comis tepidus sit cavus crustulum trans tubineus adfectus.",
        Id = "9d20cc08-53c9-4f73-b633-7eb5fd228ab7",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "21955c2d-f36b-414b-9d2b-f534e9b2272d",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Stoltenberg - Funk - Luxurious Rubber Chicken",
        Probability = 42D,
        Source = "cubo",
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-11T21:19:19.397Z").ToUniversalTime(),
        WonReason = "Usque libero soleo.",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmDeal`                                                                                                                                        | [CrmDeal](../../Models/Components/CrmDeal.md)                                                                                                    | :heavy_check_mark:                                                                                                                               | A deal represents an opportunity with companies and/or contacts                                                                                  |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmDealQueryParamFields](../../Models/Requests/CreateCrmDealQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmDealResponse](../../Models/Requests/CreateCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmEvent

Create an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmEvent" method="post" path="/crm/{connection_id}/event" example="crm_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.CreateCrmEventAsync(
    crmEvent: new CrmEvent() {
        Call = new PropertyCrmEventCall() {
            Description = "Arbitro aptus.",
            Duration = 64D,
            StartAt = System.DateTime.Parse("2024-12-11T00:59:53.650Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "93c219bb-1032-4722-9091-6ba16501c012",
        Metadata = new List<CrmMetadata>() {},
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-11T13:12:05.824Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmEvent`                                                                                                                                       | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company                                  |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmEventQueryParamFields](../../Models/Requests/CreateCrmEventQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmEventResponse](../../Models/Requests/CreateCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmLead

Create a lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmLead" method="post" path="/crm/{connection_id}/lead" example="crm_lead" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.CreateCrmLeadAsync(
    crmLead: new CrmLead() {
        Address = new PropertyCrmLeadAddress() {
            Address1 = "87206 Hudson Street",
            City = "Leslieboro",
            CountryCode = "US",
            PostalCode = "49909-1183",
            Region = "Michigan",
            RegionCode = "MO",
        },
        CompanyName = "Tillman - Wiegand",
        CreatedAt = System.DateTime.Parse("2019-10-12T11:27:59.003Z").ToUniversalTime(),
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "velda.sporer@icloud.com",
                Type = CrmEmailType.Work,
            },
        },
        FirstName = "Velda",
        Id = "306d9ac4-a773-42a8-8437-30821be97079",
        IsActive = true,
        LastName = "Sporer",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/velda-sporer",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "c62862d4-b27c-486d-b6df-a3c5d98011dd",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "vitiosus"
                ),
            },
        },
        Name = "Velda Sporer",
        Source = "Advertisement",
        Status = "New",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(841) 271-0595",
                Type = CrmTelephoneType.Fax,
            },
            new CrmTelephone() {
                Telephone = "(664) 498-4952",
                Type = CrmTelephoneType.Home,
            },
            new CrmTelephone() {
                Telephone = "(281) 288-0037",
                Type = CrmTelephoneType.Other,
            },
        },
        Title = "International Factors Administrator",
        UpdatedAt = System.DateTime.Parse("2020-05-17T21:36:13.965Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmLead`                                                                                                                                        | [CrmLead](../../Models/Components/CrmLead.md)                                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmLeadQueryParamFields](../../Models/Requests/CreateCrmLeadQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmLeadResponse](../../Models/Requests/CreateCrmLeadResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCrmPipeline

Create a pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmPipeline" method="post" path="/crm/{connection_id}/pipeline" example="crm_pipeline" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.CreateCrmPipelineAsync(
    crmPipeline: new CrmPipeline() {
        CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
        DealProbability = 99D,
        DisplayOrder = 8D,
        Id = "3856f37f-bb76-41af-8c59-558e0521fdbe",
        IsActive = true,
        Metadata = new List<CrmMetadata>() {},
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "edca416e-4810-4d64-a410-9f5b713ef26a",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-10T12:40:31.977Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-11-01T06:07:06.990Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmPipeline`                                                                                                                                    | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmPipelineQueryParamFields](../../Models/Requests/CreateCrmPipelineQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmPipelineResponse](../../Models/Requests/CreateCrmPipelineResponse.md)**

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

var res = await sdk.Crm.GetCrmCompanyAsync(
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

var res = await sdk.Crm.GetCrmContactAsync(
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

## GetCrmDeal

Retrieve a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmDeal" method="get" path="/crm/{connection_id}/deal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.GetCrmDealAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Deal                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCrmDealQueryParamFields](../../Models/Requests/GetCrmDealQueryParamFields.md)>                                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmDealResponse](../../Models/Requests/GetCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmEvent

Retrieve an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmEvent" method="get" path="/crm/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.GetCrmEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Event                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetCrmEventQueryParamFields](../../Models/Requests/GetCrmEventQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmEventResponse](../../Models/Requests/GetCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmLead

Retrieve a lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmLead" method="get" path="/crm/{connection_id}/lead/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.GetCrmLeadAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Lead                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCrmLeadQueryParamFields](../../Models/Requests/GetCrmLeadQueryParamFields.md)>                                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmLeadResponse](../../Models/Requests/GetCrmLeadResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmPipeline

Retrieve a pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmPipeline" method="get" path="/crm/{connection_id}/pipeline/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.GetCrmPipelineAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Pipeline                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetCrmPipelineQueryParamFields](../../Models/Requests/GetCrmPipelineQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmPipelineResponse](../../Models/Requests/GetCrmPipelineResponse.md)**

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

var res = await sdk.Crm.ListCrmCompaniesAsync(req);

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

var res = await sdk.Crm.ListCrmContactsAsync(req);

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

## ListCrmDeals

List all deals

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmDeals" method="get" path="/crm/{connection_id}/deal" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmDealsRequest req = new ListCrmDealsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Crm.ListCrmDealsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmDealsRequest](../../Models/Requests/ListCrmDealsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListCrmDealsResponse](../../Models/Requests/ListCrmDealsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmEvents

List all events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmEvents" method="get" path="/crm/{connection_id}/event" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmEventsRequest req = new ListCrmEventsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Crm.ListCrmEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCrmEventsRequest](../../Models/Requests/ListCrmEventsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListCrmEventsResponse](../../Models/Requests/ListCrmEventsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmLeads

List all leads

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmLeads" method="get" path="/crm/{connection_id}/lead" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmLeadsRequest req = new ListCrmLeadsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Crm.ListCrmLeadsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmLeadsRequest](../../Models/Requests/ListCrmLeadsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListCrmLeadsResponse](../../Models/Requests/ListCrmLeadsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmPipelines

List all pipelines

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmPipelines" method="get" path="/crm/{connection_id}/pipeline" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmPipelinesRequest req = new ListCrmPipelinesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Crm.ListCrmPipelinesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListCrmPipelinesRequest](../../Models/Requests/ListCrmPipelinesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListCrmPipelinesResponse](../../Models/Requests/ListCrmPipelinesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmTaxonomies

List all taxonomies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmTaxonomies" method="get" path="/crm/{connection_id}/taxonomy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmTaxonomiesRequest req = new ListCrmTaxonomiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Crm.ListCrmTaxonomiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCrmTaxonomiesRequest](../../Models/Requests/ListCrmTaxonomiesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCrmTaxonomiesResponse](../../Models/Requests/ListCrmTaxonomiesResponse.md)**

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
        Id = "20b975ae-a20d-4b12-958d-35ceb1b8f52f",
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
                Id = "5f5357c5-bce0-4d29-a58f-624b31f33367",
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
        UpdatedAt = System.DateTime.Parse("2025-03-03T03:56:40.942Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://www.goodwinsons.com",
        },
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.PatchCrmCompanyAsync(req);

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
        Id = "840e33b2-a05c-483e-8e30-53d1434ffaa0",
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
                Id = "fb6e0969-a00b-4511-aff5-50e9b75f4664",
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
        UpdatedAt = System.DateTime.Parse("2021-02-24T05:06:56.978Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.PatchCrmContactAsync(req);

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

## PatchCrmDeal

Update a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmDeal" method="patch" path="/crm/{connection_id}/deal/{id}" example="crm_deal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmDealRequest req = new PatchCrmDealRequest() {
    CrmDeal = new CrmDeal() {
        Amount = 98162D,
        ClosedAt = System.DateTime.Parse("2024-03-10T10:10:00.336Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-31T12:48:39.613Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "USD",
        Description = "Comis tepidus sit cavus crustulum trans tubineus adfectus.",
        Id = "6c0bb7e4-858c-409f-9a13-444cb2aba4a4",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "74548368-7d1b-41d5-9cb5-95364e2ddd88",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Stoltenberg - Funk - Luxurious Rubber Chicken",
        Probability = 42D,
        Source = "cubo",
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-11T21:19:19.404Z").ToUniversalTime(),
        WonReason = "Usque libero soleo.",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.PatchCrmDealAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [PatchCrmDealRequest](../../Models/Requests/PatchCrmDealRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[PatchCrmDealResponse](../../Models/Requests/PatchCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmEvent" method="patch" path="/crm/{connection_id}/event/{id}" example="crm_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmEventRequest req = new PatchCrmEventRequest() {
    CrmEvent = new CrmEvent() {
        Call = new PropertyCrmEventCall() {
            Description = "Arbitro aptus.",
            Duration = 64D,
            StartAt = System.DateTime.Parse("2024-12-11T00:59:53.674Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "8c92e6d4-a43b-4881-a3f9-abade98dc352",
        Metadata = new List<CrmMetadata>() {},
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-11T13:12:05.858Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.PatchCrmEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchCrmEventRequest](../../Models/Requests/PatchCrmEventRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchCrmEventResponse](../../Models/Requests/PatchCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmLead

Update a lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmLead" method="patch" path="/crm/{connection_id}/lead/{id}" example="crm_lead" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmLeadRequest req = new PatchCrmLeadRequest() {
    CrmLead = new CrmLead() {
        Address = new PropertyCrmLeadAddress() {
            Address1 = "87206 Hudson Street",
            City = "Leslieboro",
            CountryCode = "US",
            PostalCode = "49909-1183",
            Region = "Michigan",
            RegionCode = "MO",
        },
        CompanyName = "Tillman - Wiegand",
        CreatedAt = System.DateTime.Parse("2019-10-12T11:27:59.003Z").ToUniversalTime(),
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "velda.sporer@icloud.com",
                Type = CrmEmailType.Work,
            },
        },
        FirstName = "Velda",
        Id = "39d4598c-a669-4809-aea2-2aa2e970addf",
        IsActive = true,
        LastName = "Sporer",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/velda-sporer",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "c70f003d-b03d-4aa1-b643-c395b7b7f2ed",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "vitiosus"
                ),
            },
        },
        Name = "Velda Sporer",
        Source = "Advertisement",
        Status = "New",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(841) 271-0595",
                Type = CrmTelephoneType.Fax,
            },
            new CrmTelephone() {
                Telephone = "(664) 498-4952",
                Type = CrmTelephoneType.Home,
            },
            new CrmTelephone() {
                Telephone = "(281) 288-0037",
                Type = CrmTelephoneType.Other,
            },
        },
        Title = "International Factors Administrator",
        UpdatedAt = System.DateTime.Parse("2020-05-17T21:36:13.967Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.PatchCrmLeadAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [PatchCrmLeadRequest](../../Models/Requests/PatchCrmLeadRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[PatchCrmLeadResponse](../../Models/Requests/PatchCrmLeadResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmPipeline

Update a pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmPipeline" method="patch" path="/crm/{connection_id}/pipeline/{id}" example="crm_pipeline" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmPipelineRequest req = new PatchCrmPipelineRequest() {
    CrmPipeline = new CrmPipeline() {
        CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
        DealProbability = 99D,
        DisplayOrder = 8D,
        Id = "110bd91a-1a1e-493f-a449-0db3a73c3811",
        IsActive = true,
        Metadata = new List<CrmMetadata>() {},
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "0c4beff6-ae22-4221-a16a-7501535b131a",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-10T12:40:31.984Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-11-01T06:07:06.997Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.PatchCrmPipelineAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchCrmPipelineRequest](../../Models/Requests/PatchCrmPipelineRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchCrmPipelineResponse](../../Models/Requests/PatchCrmPipelineResponse.md)**

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

var res = await sdk.Crm.RemoveCrmCompanyAsync(
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

var res = await sdk.Crm.RemoveCrmContactAsync(
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

## RemoveCrmDeal

Remove a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmDeal" method="delete" path="/crm/{connection_id}/deal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.RemoveCrmDealAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deal       |

### Response

**[RemoveCrmDealResponse](../../Models/Requests/RemoveCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmEvent

Remove an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmEvent" method="delete" path="/crm/{connection_id}/event/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.RemoveCrmEventAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Event      |

### Response

**[RemoveCrmEventResponse](../../Models/Requests/RemoveCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmLead

Remove a lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmLead" method="delete" path="/crm/{connection_id}/lead/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.RemoveCrmLeadAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Lead       |

### Response

**[RemoveCrmLeadResponse](../../Models/Requests/RemoveCrmLeadResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmPipeline

Remove a pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmPipeline" method="delete" path="/crm/{connection_id}/pipeline/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Crm.RemoveCrmPipelineAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Pipeline   |

### Response

**[RemoveCrmPipelineResponse](../../Models/Requests/RemoveCrmPipelineResponse.md)**

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
        Id = "20b975ae-a20d-4b12-958d-35ceb1b8f52f",
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
                Id = "5f5357c5-bce0-4d29-a58f-624b31f33367",
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
        UpdatedAt = System.DateTime.Parse("2025-03-03T03:56:40.942Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://www.goodwinsons.com",
        },
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.UpdateCrmCompanyAsync(req);

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
        Id = "840e33b2-a05c-483e-8e30-53d1434ffaa0",
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
                Id = "fb6e0969-a00b-4511-aff5-50e9b75f4664",
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
        UpdatedAt = System.DateTime.Parse("2021-02-24T05:06:56.978Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.UpdateCrmContactAsync(req);

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

## UpdateCrmDeal

Update a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmDeal" method="put" path="/crm/{connection_id}/deal/{id}" example="crm_deal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmDealRequest req = new UpdateCrmDealRequest() {
    CrmDeal = new CrmDeal() {
        Amount = 98162D,
        ClosedAt = System.DateTime.Parse("2024-03-10T10:10:00.336Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-31T12:48:39.613Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "USD",
        Description = "Comis tepidus sit cavus crustulum trans tubineus adfectus.",
        Id = "6c0bb7e4-858c-409f-9a13-444cb2aba4a4",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "74548368-7d1b-41d5-9cb5-95364e2ddd88",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Stoltenberg - Funk - Luxurious Rubber Chicken",
        Probability = 42D,
        Source = "cubo",
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-11T21:19:19.404Z").ToUniversalTime(),
        WonReason = "Usque libero soleo.",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.UpdateCrmDealAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateCrmDealRequest](../../Models/Requests/UpdateCrmDealRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateCrmDealResponse](../../Models/Requests/UpdateCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmEvent

Update an event

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmEvent" method="put" path="/crm/{connection_id}/event/{id}" example="crm_event" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmEventRequest req = new UpdateCrmEventRequest() {
    CrmEvent = new CrmEvent() {
        Call = new PropertyCrmEventCall() {
            Description = "Arbitro aptus.",
            Duration = 64D,
            StartAt = System.DateTime.Parse("2024-12-11T00:59:53.674Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "8c92e6d4-a43b-4881-a3f9-abade98dc352",
        Metadata = new List<CrmMetadata>() {},
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-11T13:12:05.858Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.UpdateCrmEventAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCrmEventRequest](../../Models/Requests/UpdateCrmEventRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateCrmEventResponse](../../Models/Requests/UpdateCrmEventResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmLead

Update a lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmLead" method="put" path="/crm/{connection_id}/lead/{id}" example="crm_lead" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmLeadRequest req = new UpdateCrmLeadRequest() {
    CrmLead = new CrmLead() {
        Address = new PropertyCrmLeadAddress() {
            Address1 = "87206 Hudson Street",
            City = "Leslieboro",
            CountryCode = "US",
            PostalCode = "49909-1183",
            Region = "Michigan",
            RegionCode = "MO",
        },
        CompanyName = "Tillman - Wiegand",
        CreatedAt = System.DateTime.Parse("2019-10-12T11:27:59.003Z").ToUniversalTime(),
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "velda.sporer@icloud.com",
                Type = CrmEmailType.Work,
            },
        },
        FirstName = "Velda",
        Id = "39d4598c-a669-4809-aea2-2aa2e970addf",
        IsActive = true,
        LastName = "Sporer",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/velda-sporer",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "c70f003d-b03d-4aa1-b643-c395b7b7f2ed",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "vitiosus"
                ),
            },
        },
        Name = "Velda Sporer",
        Source = "Advertisement",
        Status = "New",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(841) 271-0595",
                Type = CrmTelephoneType.Fax,
            },
            new CrmTelephone() {
                Telephone = "(664) 498-4952",
                Type = CrmTelephoneType.Home,
            },
            new CrmTelephone() {
                Telephone = "(281) 288-0037",
                Type = CrmTelephoneType.Other,
            },
        },
        Title = "International Factors Administrator",
        UpdatedAt = System.DateTime.Parse("2020-05-17T21:36:13.967Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.UpdateCrmLeadAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateCrmLeadRequest](../../Models/Requests/UpdateCrmLeadRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateCrmLeadResponse](../../Models/Requests/UpdateCrmLeadResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmPipeline

Update a pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmPipeline" method="put" path="/crm/{connection_id}/pipeline/{id}" example="crm_pipeline" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmPipelineRequest req = new UpdateCrmPipelineRequest() {
    CrmPipeline = new CrmPipeline() {
        CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
        DealProbability = 99D,
        DisplayOrder = 8D,
        Id = "110bd91a-1a1e-493f-a449-0db3a73c3811",
        IsActive = true,
        Metadata = new List<CrmMetadata>() {},
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "0c4beff6-ae22-4221-a16a-7501535b131a",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-10T12:40:31.984Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-11-01T06:07:06.997Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Crm.UpdateCrmPipelineAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateCrmPipelineRequest](../../Models/Requests/UpdateCrmPipelineRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateCrmPipelineResponse](../../Models/Requests/UpdateCrmPipelineResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |