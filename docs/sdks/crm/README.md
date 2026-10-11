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
        Id = "3c7d3c70-550e-4784-9fd1-aa0863e26e73",
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
                Id = "1e056b32-d774-4438-9420-7ecf529620a6",
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
        UpdatedAt = System.DateTime.Parse("2025-02-23T16:41:55.842Z").ToUniversalTime(),
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
        Id = "b14e3254-2431-4d98-a07b-d0d5e4764255",
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
                Id = "015a0955-5666-45a8-873f-d458fc9bfd38",
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
        UpdatedAt = System.DateTime.Parse("2021-02-23T23:05:07.126Z").ToUniversalTime(),
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
        ClosedAt = System.DateTime.Parse("2024-03-08T08:20:31.024Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-24T23:29:40.318Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "205a38cf-b0f6-40bc-8544-ff04eb9ffb55",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "6ad25ffe-54aa-4a31-8517-928d9609dc6a",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Frozen Silk Chicken",
        Pipelines = new List<CrmReference>() {
            new CrmReference() {
                Id = "d3e980ee-1e17-407e-84e8-c7c8ad0d9116",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "addc2637-1d57-4ab0-ad07-605e424b73e3",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "ad929775-18d4-45a7-9a5e-eb5ef618480f",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T00:32:10.775Z").ToUniversalTime(),
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
            StartAt = System.DateTime.Parse("2024-12-04T00:03:10.232Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "f41dff41-7eab-4e3e-9fc2-f7f4ee6082d6",
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-01T14:02:16.353Z").ToUniversalTime(),
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
            Address1 = "528 Forest Road",
            Address2 = "Apt. 643",
            City = "Palm Springs",
            CountryCode = "US",
            PostalCode = "55624-6499",
            Region = "New Jersey",
            RegionCode = "LA",
        },
        CompanyName = "Tillman - Wiegand",
        CreatedAt = System.DateTime.Parse("2019-10-12T11:27:59.003Z").ToUniversalTime(),
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Velda.Sporer16@yahoo.com",
                Type = CrmEmailType.Other,
            },
            new CrmEmail() {
                Email = "Velda.Sporer@yahoo.com",
                Type = CrmEmailType.Home,
            },
        },
        FirstName = "Velda",
        Id = "1351c7f6-dcd1-4a84-837f-a54b59713590",
        IsActive = true,
        LastName = "Sporer",
        LinkUrls = new List<string>() {
            "https://ruddy-unblinking.info/",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "35f894d9-ad78-475e-9c03-219997df5b35",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "vitiosus"
                ),
            },
        },
        Name = "Velda Sporer",
        Source = "aetas",
        Status = "vesco",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(955) 643-9849",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(621) 811-8800",
                Type = CrmTelephoneType.Work,
            },
        },
        Title = "Direct Research Assistant",
        UpdatedAt = System.DateTime.Parse("2020-05-17T01:09:27.631Z").ToUniversalTime(),
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
        Id = "bd89772d-6d0a-405c-b79e-ee8583ecaf20",
        IsActive = true,
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "ed5aa045-8e71-412c-8615-768137c3ee08",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-03T05:16:44.504Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-10-24T18:58:29.345Z").ToUniversalTime(),
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
        Id = "2dc413b5-9ceb-4714-b7f2-0251d5291a09",
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
                Id = "95a97d56-9b32-45f6-88ea-dda47441d19b",
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
        UpdatedAt = System.DateTime.Parse("2025-02-23T16:41:55.866Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://wise-possession.org",
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
        Id = "3d197be4-3078-4cdc-89cd-6edd2aebf2d5",
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
                Id = "166ca224-cff1-42da-a3bd-01df42d85a55",
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
        UpdatedAt = System.DateTime.Parse("2021-02-23T23:05:07.127Z").ToUniversalTime(),
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
        ClosedAt = System.DateTime.Parse("2024-03-08T08:20:31.029Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-24T23:29:40.333Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "f41f5d60-f6ea-4fb2-b3c4-61e997f3dd66",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "8ddf385b-1f76-4701-975a-619fadafa352",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Frozen Silk Chicken",
        Pipelines = new List<CrmReference>() {
            new CrmReference() {
                Id = "d0e9f42b-f335-4181-a2af-d309419b2203",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "7456e13a-38f3-4500-93f0-94810912aba0",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "1aad3541-dac5-4cea-ac3f-039d90d807ce",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T00:32:10.784Z").ToUniversalTime(),
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
            StartAt = System.DateTime.Parse("2024-12-04T00:03:10.265Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "d6178a7c-c3f0-47dc-bce8-ac1e88f0409d",
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-01T14:02:16.398Z").ToUniversalTime(),
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
            Address1 = "528 Forest Road",
            Address2 = "Apt. 643",
            City = "Palm Springs",
            CountryCode = "US",
            PostalCode = "55624-6499",
            Region = "New Jersey",
            RegionCode = "LA",
        },
        CompanyName = "Tillman - Wiegand",
        CreatedAt = System.DateTime.Parse("2019-10-12T11:27:59.003Z").ToUniversalTime(),
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Velda.Sporer16@yahoo.com",
                Type = CrmEmailType.Other,
            },
            new CrmEmail() {
                Email = "Velda.Sporer@yahoo.com",
                Type = CrmEmailType.Home,
            },
        },
        FirstName = "Velda",
        Id = "f563b6c8-fd43-41c8-9689-147f6af572c7",
        IsActive = true,
        LastName = "Sporer",
        LinkUrls = new List<string>() {
            "https://ruddy-unblinking.info/",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "c66c4398-66ca-42aa-85c7-7f969707934f",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "vitiosus"
                ),
            },
        },
        Name = "Velda Sporer",
        Source = "aetas",
        Status = "vesco",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(955) 643-9849",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(621) 811-8800",
                Type = CrmTelephoneType.Work,
            },
        },
        Title = "Direct Research Assistant",
        UpdatedAt = System.DateTime.Parse("2020-05-17T01:09:27.634Z").ToUniversalTime(),
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
        Id = "9f3f38fc-54a4-490a-8c47-b9f3e63eccca",
        IsActive = true,
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "b889fd50-6a8c-4f9d-a32a-3e09a7a31ff9",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-03T05:16:44.508Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-10-24T18:58:29.350Z").ToUniversalTime(),
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
        Id = "2dc413b5-9ceb-4714-b7f2-0251d5291a09",
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
                Id = "95a97d56-9b32-45f6-88ea-dda47441d19b",
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
        UpdatedAt = System.DateTime.Parse("2025-02-23T16:41:55.866Z").ToUniversalTime(),
        Websites = new List<string>() {
            "https://wise-possession.org",
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
        Id = "3d197be4-3078-4cdc-89cd-6edd2aebf2d5",
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
                Id = "166ca224-cff1-42da-a3bd-01df42d85a55",
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
        UpdatedAt = System.DateTime.Parse("2021-02-23T23:05:07.127Z").ToUniversalTime(),
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
        ClosedAt = System.DateTime.Parse("2024-03-08T08:20:31.029Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-24T23:29:40.333Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "f41f5d60-f6ea-4fb2-b3c4-61e997f3dd66",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "8ddf385b-1f76-4701-975a-619fadafa352",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Frozen Silk Chicken",
        Pipelines = new List<CrmReference>() {
            new CrmReference() {
                Id = "d0e9f42b-f335-4181-a2af-d309419b2203",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "7456e13a-38f3-4500-93f0-94810912aba0",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "1aad3541-dac5-4cea-ac3f-039d90d807ce",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T00:32:10.784Z").ToUniversalTime(),
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
            StartAt = System.DateTime.Parse("2024-12-04T00:03:10.265Z").ToUniversalTime(),
        },
        CreatedAt = System.DateTime.Parse("2020-07-14T04:53:23.784Z").ToUniversalTime(),
        Id = "d6178a7c-c3f0-47dc-bce8-ac1e88f0409d",
        Type = CrmEventType.Call,
        UpdatedAt = System.DateTime.Parse("2026-10-01T14:02:16.398Z").ToUniversalTime(),
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
            Address1 = "528 Forest Road",
            Address2 = "Apt. 643",
            City = "Palm Springs",
            CountryCode = "US",
            PostalCode = "55624-6499",
            Region = "New Jersey",
            RegionCode = "LA",
        },
        CompanyName = "Tillman - Wiegand",
        CreatedAt = System.DateTime.Parse("2019-10-12T11:27:59.003Z").ToUniversalTime(),
        Emails = new List<CrmEmail>() {
            new CrmEmail() {
                Email = "Velda.Sporer16@yahoo.com",
                Type = CrmEmailType.Other,
            },
            new CrmEmail() {
                Email = "Velda.Sporer@yahoo.com",
                Type = CrmEmailType.Home,
            },
        },
        FirstName = "Velda",
        Id = "f563b6c8-fd43-41c8-9689-147f6af572c7",
        IsActive = true,
        LastName = "Sporer",
        LinkUrls = new List<string>() {
            "https://ruddy-unblinking.info/",
        },
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "c66c4398-66ca-42aa-85c7-7f969707934f",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "vitiosus"
                ),
            },
        },
        Name = "Velda Sporer",
        Source = "aetas",
        Status = "vesco",
        Telephones = new List<CrmTelephone>() {
            new CrmTelephone() {
                Telephone = "(955) 643-9849",
                Type = CrmTelephoneType.Other,
            },
            new CrmTelephone() {
                Telephone = "(621) 811-8800",
                Type = CrmTelephoneType.Work,
            },
        },
        Title = "Direct Research Assistant",
        UpdatedAt = System.DateTime.Parse("2020-05-17T01:09:27.634Z").ToUniversalTime(),
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
        Id = "9f3f38fc-54a4-490a-8c47-b9f3e63eccca",
        IsActive = true,
        Name = "Small Steel Bacon",
        Stages = new List<CrmStage>() {
            new CrmStage() {
                Active = false,
                CreatedAt = System.DateTime.Parse("2022-12-28T13:45:38.446Z").ToUniversalTime(),
                DealProbability = 84D,
                DisplayOrder = 72D,
                Id = "b889fd50-6a8c-4f9d-a32a-3e09a7a31ff9",
                IsClosed = true,
                Name = "Veniam.",
                UpdatedAt = System.DateTime.Parse("2025-10-03T05:16:44.508Z").ToUniversalTime(),
            },
        },
        UpdatedAt = System.DateTime.Parse("2025-10-24T18:58:29.350Z").ToUniversalTime(),
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