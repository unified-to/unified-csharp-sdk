# Lead

## Overview

### Available Operations

* [CreateCrmLead](#createcrmlead) - Create a lead
* [GetCrmLead](#getcrmlead) - Retrieve a lead
* [ListCrmLeads](#listcrmleads) - List all leads
* [PatchCrmLead](#patchcrmlead) - Update a lead
* [RemoveCrmLead](#removecrmlead) - Remove a lead
* [UpdateCrmLead](#updatecrmlead) - Update a lead

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

var res = await sdk.Lead.CreateCrmLeadAsync(
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
        Id = "a8b22a76-479d-4e74-8830-ac4ba8c13193",
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
                Id = "ac0d6adc-e135-4144-9ac9-9c09fd73b999",
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
        UpdatedAt = System.DateTime.Parse("2020-05-17T09:02:51.333Z").ToUniversalTime(),
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

var res = await sdk.Lead.GetCrmLeadAsync(
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

var res = await sdk.Lead.ListCrmLeadsAsync(req);

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
        Id = "f25afdba-289a-4cfd-ab09-201bae9c02f0",
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
                Id = "047afa60-66ba-444e-af7c-8ef74a8c5f28",
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
        UpdatedAt = System.DateTime.Parse("2020-05-17T09:02:51.335Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lead.PatchCrmLeadAsync(req);

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

var res = await sdk.Lead.RemoveCrmLeadAsync(
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
        Id = "f25afdba-289a-4cfd-ab09-201bae9c02f0",
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
                Id = "047afa60-66ba-444e-af7c-8ef74a8c5f28",
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
        UpdatedAt = System.DateTime.Parse("2020-05-17T09:02:51.335Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lead.UpdateCrmLeadAsync(req);

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