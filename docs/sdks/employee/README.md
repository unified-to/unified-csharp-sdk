# Employee

## Overview

### Available Operations

* [CreateHrisEmployee](#createhrisemployee) - Create an employee
* [GetHrisEmployee](#gethrisemployee) - Retrieve an employee
* [ListHrisEmployees](#listhrisemployees) - List all employees
* [PatchHrisEmployee](#patchhrisemployee) - Update an employee
* [RemoveHrisEmployee](#removehrisemployee) - Remove an employee
* [UpdateHrisEmployee](#updatehrisemployee) - Update an employee

## CreateHrisEmployee

Creates a HrisEmployee. Provide the unified HrisEmployee fields in the request body; they are mapped to the provider's API. Returns the created HrisEmployee.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisEmployee" method="post" path="/hris/{connection_id}/employee" example="hris_employee" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Employee.CreateHrisEmployeeAsync(
    hrisEmployee: new HrisEmployee() {
        Address = new PropertyHrisEmployeeAddress() {
            Address1 = "7431 Hintz Parkway",
            Address2 = "Apt. 520",
            City = "Port Rogerview",
            CountryCode = "US",
            PostalCode = "01711",
            Region = "Missouri",
            RegionCode = "TN",
        },
        Bio = "fun advocate  🇱🇻",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 95000D,
                Currency = "USD",
                Frequency = HrisCompensationFrequency.Year,
                Notes = "Eius.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "USD",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "zetta.prohaska@insidious-stump.net",
                Type = HrisEmailType.Work,
            },
        },
        EmployeeNumber = "uCk3qaL1ei",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.PartTime,
        FirstName = "Zetta",
        FlsaStatus = FlsaStatus.Exempt,
        Gender = HrisEmployeeGender.Male,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Id = "e9397090-b5dd-451c-ae64-03b300275731",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/female/512/85.jpg",
        LanguageLocale = "in",
        LastName = "Prohaska",
        Locations = new List<HrisLocation>() {},
        MaritalStatus = MaritalStatus.Married,
        Metadata = new List<HrisMetadata>() {
            new HrisMetadata() {
                ExtraData = HrisMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = HrisMetadataFormat.Text,
                Id = "9641898b-2f73-4f5f-b5dd-58b02a3c7a52",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tutis"
                ),
            },
        },
        Name = "Zetta Prohaska",
        PayFrequency = PayFrequency.Week,
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keith.prohaska@gmail.com",
                    },
                },
                Name = "Keith Prohaska",
                Type = HrisEmployeerelationshipType.Sibling,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keely.prohaska@icloud.com",
                    },
                },
                Name = "Keely Prohaska",
                Type = HrisEmployeerelationshipType.Other,
            },
        },
        Salutation = "Ms.",
        SsnSin = "284-82-8167",
        StorageQuotaAllocated = 3653713D,
        StorageQuotaAvailable = 3017275D,
        StorageQuotaUsed = 367449D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(320) 980-1370",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(694) 840-0166",
                Type = HrisTelephoneType.Fax,
            },
        },
        TimeoffDaysTotal = 17D,
        TimeoffDaysUsed = 9D,
        Timezone = "Europe/Ljubljana",
        Title = "District Branding Specialist",
        UpdatedAt = System.DateTime.Parse("2020-07-19T09:55:24.845Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisEmployee`                                                                                                                                   | [HrisEmployee](../../Models/Components/HrisEmployee.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisEmployeeQueryParamFields](../../Models/Requests/CreateHrisEmployeeQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisEmployeeResponse](../../Models/Requests/CreateHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisEmployee

Retrieves a single HrisEmployee by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisEmployee" method="get" path="/hris/{connection_id}/employee/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Employee.GetHrisEmployeeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Employee                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHrisEmployeeQueryParamFields](../../Models/Requests/GetHrisEmployeeQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisEmployeeResponse](../../Models/Requests/GetHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisEmployees

Returns a list of HrisEmployees. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisEmployees" method="get" path="/hris/{connection_id}/employee" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisEmployeesRequest req = new ListHrisEmployeesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Employee.ListHrisEmployeesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisEmployeesRequest](../../Models/Requests/ListHrisEmployeesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisEmployeesResponse](../../Models/Requests/ListHrisEmployeesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisEmployee

Updates the HrisEmployee identified by `id`. Provide the unified HrisEmployee fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisEmployee" method="patch" path="/hris/{connection_id}/employee/{id}" example="hris_employee" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisEmployeeRequest req = new PatchHrisEmployeeRequest() {
    HrisEmployee = new HrisEmployee() {
        Address = new PropertyHrisEmployeeAddress() {
            Address1 = "7431 Hintz Parkway",
            Address2 = "Apt. 520",
            City = "Port Rogerview",
            CountryCode = "US",
            PostalCode = "01711",
            Region = "Missouri",
            RegionCode = "TN",
        },
        Bio = "fun advocate  🇱🇻",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 95000D,
                Currency = "USD",
                Frequency = HrisCompensationFrequency.Year,
                Notes = "Eius.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "USD",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "zetta.prohaska@insidious-stump.net",
                Type = HrisEmailType.Work,
            },
        },
        EmployeeNumber = "uCk3qaL1ei",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.PartTime,
        FirstName = "Zetta",
        FlsaStatus = FlsaStatus.Exempt,
        Gender = HrisEmployeeGender.Male,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Id = "dbcf0ed5-e9ca-4246-8db7-38d22a7e4a3f",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/female/512/85.jpg",
        LanguageLocale = "in",
        LastName = "Prohaska",
        Locations = new List<HrisLocation>() {},
        MaritalStatus = MaritalStatus.Married,
        Metadata = new List<HrisMetadata>() {
            new HrisMetadata() {
                ExtraData = HrisMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = HrisMetadataFormat.Text,
                Id = "a0f11408-0cae-4cec-89a7-0698711a7830",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tutis"
                ),
            },
        },
        Name = "Zetta Prohaska",
        PayFrequency = PayFrequency.Week,
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keith.prohaska@gmail.com",
                    },
                },
                Name = "Keith Prohaska",
                Type = HrisEmployeerelationshipType.Sibling,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keely.prohaska@icloud.com",
                    },
                },
                Name = "Keely Prohaska",
                Type = HrisEmployeerelationshipType.Other,
            },
        },
        Salutation = "Ms.",
        SsnSin = "284-82-8167",
        StorageQuotaAllocated = 3653713D,
        StorageQuotaAvailable = 3017275D,
        StorageQuotaUsed = 367449D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(320) 980-1370",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(694) 840-0166",
                Type = HrisTelephoneType.Fax,
            },
        },
        TimeoffDaysTotal = 17D,
        TimeoffDaysUsed = 9D,
        Timezone = "Europe/Ljubljana",
        Title = "District Branding Specialist",
        UpdatedAt = System.DateTime.Parse("2020-07-19T09:55:24.860Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Employee.PatchHrisEmployeeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchHrisEmployeeRequest](../../Models/Requests/PatchHrisEmployeeRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchHrisEmployeeResponse](../../Models/Requests/PatchHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisEmployee

Deletes the HrisEmployee identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisEmployee" method="delete" path="/hris/{connection_id}/employee/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Employee.RemoveHrisEmployeeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Employee   |

### Response

**[RemoveHrisEmployeeResponse](../../Models/Requests/RemoveHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisEmployee

Updates the HrisEmployee identified by `id`. Provide the unified HrisEmployee fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisEmployee" method="put" path="/hris/{connection_id}/employee/{id}" example="hris_employee" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisEmployeeRequest req = new UpdateHrisEmployeeRequest() {
    HrisEmployee = new HrisEmployee() {
        Address = new PropertyHrisEmployeeAddress() {
            Address1 = "7431 Hintz Parkway",
            Address2 = "Apt. 520",
            City = "Port Rogerview",
            CountryCode = "US",
            PostalCode = "01711",
            Region = "Missouri",
            RegionCode = "TN",
        },
        Bio = "fun advocate  🇱🇻",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 95000D,
                Currency = "USD",
                Frequency = HrisCompensationFrequency.Year,
                Notes = "Eius.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "USD",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "zetta.prohaska@insidious-stump.net",
                Type = HrisEmailType.Work,
            },
        },
        EmployeeNumber = "uCk3qaL1ei",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.PartTime,
        FirstName = "Zetta",
        FlsaStatus = FlsaStatus.Exempt,
        Gender = HrisEmployeeGender.Male,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Id = "dbcf0ed5-e9ca-4246-8db7-38d22a7e4a3f",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/female/512/85.jpg",
        LanguageLocale = "in",
        LastName = "Prohaska",
        Locations = new List<HrisLocation>() {},
        MaritalStatus = MaritalStatus.Married,
        Metadata = new List<HrisMetadata>() {
            new HrisMetadata() {
                ExtraData = HrisMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = HrisMetadataFormat.Text,
                Id = "a0f11408-0cae-4cec-89a7-0698711a7830",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tutis"
                ),
            },
        },
        Name = "Zetta Prohaska",
        PayFrequency = PayFrequency.Week,
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keith.prohaska@gmail.com",
                    },
                },
                Name = "Keith Prohaska",
                Type = HrisEmployeerelationshipType.Sibling,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keely.prohaska@icloud.com",
                    },
                },
                Name = "Keely Prohaska",
                Type = HrisEmployeerelationshipType.Other,
            },
        },
        Salutation = "Ms.",
        SsnSin = "284-82-8167",
        StorageQuotaAllocated = 3653713D,
        StorageQuotaAvailable = 3017275D,
        StorageQuotaUsed = 367449D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(320) 980-1370",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(694) 840-0166",
                Type = HrisTelephoneType.Fax,
            },
        },
        TimeoffDaysTotal = 17D,
        TimeoffDaysUsed = 9D,
        Timezone = "Europe/Ljubljana",
        Title = "District Branding Specialist",
        UpdatedAt = System.DateTime.Parse("2020-07-19T09:55:24.860Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Employee.UpdateHrisEmployeeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateHrisEmployeeRequest](../../Models/Requests/UpdateHrisEmployeeRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateHrisEmployeeResponse](../../Models/Requests/UpdateHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |