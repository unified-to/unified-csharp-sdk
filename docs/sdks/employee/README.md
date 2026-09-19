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

Create an employee

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
            Address1 = "52008 Lansdowne Road",
            Address2 = "Apt. 101",
            City = "Connellyberg",
            CountryCode = "US",
            PostalCode = "18978",
            Region = "South Dakota",
            RegionCode = "NM",
        },
        Bio = "sushi devotee, singer",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 69148D,
                Currency = "CRC",
                Frequency = HrisCompensationFrequency.Quarter,
                Notes = "Tergeo laborum laboriosam tutis.",
                Type = HrisCompensationType.Equity,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "IDR",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "Zetta_Prohaska67@hotmail.com",
                Type = HrisEmailType.Home,
            },
        },
        EmployeeNumber = "YuOt169CGu",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.Volunteer,
        FirstName = "Zetta",
        Gender = HrisEmployeeGender.Intersex,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2023-05-11T04:37:54.703Z").ToUniversalTime(),
        Id = "6cd9101e-e1b8-419f-9cab-63e1cfc3e2ac",
        ImageUrl = "https://loremflickr.com/3684/2116?lock=4686991638584456",
        LanguageLocale = "es",
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
                Id = "9bb1ae78-f6f7-492a-aecd-6e3d1e9c4941",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tenetur"
                ),
            },
        },
        Name = "Zetta Prohaska",
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Deshaun.Sanford24@yahoo.com",
                    },
                    new HrisEmail() {
                        Email = "Rebeca.Dibbert11@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Hester80@gmail.com",
                    },
                },
                Name = "Automotive",
                Type = HrisEmployeerelationshipType.Emergency,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Benedict_Wisozk83@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Princess_Rath43@gmail.com",
                    },
                    new HrisEmail() {
                        Email = "Elmira92@yahoo.com",
                    },
                },
                Name = "Music",
                Type = HrisEmployeerelationshipType.Friend,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Jane30@gmail.com",
                    },
                },
                Name = "Jewelry",
                Type = HrisEmployeerelationshipType.Sibling,
            },
        },
        Salutation = "Miss",
        SsnSin = "yMRtj0Q3xO",
        StorageQuotaAllocated = 3674489D,
        StorageQuotaAvailable = 7748057D,
        StorageQuotaUsed = 301727D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(409) 801-3705",
                Type = HrisTelephoneType.Fax,
            },
        },
        TerminationReason = "Communis adnuo damnatio atavus terebro acies canis cogito triumphus creber temptatio defendo cubo amissio paulatim corroboro.",
        TimeoffDaysTotal = 12D,
        TimeoffDaysUsed = 6D,
        Timezone = "Africa/Harare",
        Title = "Investor Paradigm Liaison",
        UpdatedAt = System.DateTime.Parse("2022-02-19T15:16:40.928Z").ToUniversalTime(),
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

Retrieve an employee

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

List all employees

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

Update an employee

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
            Address1 = "52008 Lansdowne Road",
            Address2 = "Apt. 101",
            City = "Connellyberg",
            CountryCode = "US",
            PostalCode = "18978",
            Region = "South Dakota",
            RegionCode = "NM",
        },
        Bio = "sushi devotee, singer",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 69148D,
                Currency = "CRC",
                Frequency = HrisCompensationFrequency.Quarter,
                Notes = "Tergeo laborum laboriosam tutis.",
                Type = HrisCompensationType.Equity,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "IDR",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "Zetta_Prohaska67@hotmail.com",
                Type = HrisEmailType.Home,
            },
        },
        EmployeeNumber = "YuOt169CGu",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.Volunteer,
        FirstName = "Zetta",
        Gender = HrisEmployeeGender.Intersex,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2023-05-11T04:37:54.752Z").ToUniversalTime(),
        Id = "27b5a40e-eb9f-44d5-a039-62df6697f625",
        ImageUrl = "https://loremflickr.com/3684/2116?lock=4686991638584456",
        LanguageLocale = "es",
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
                Id = "918c060a-fa04-4e39-a700-9bb71caab15e",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tenetur"
                ),
            },
        },
        Name = "Zetta Prohaska",
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Deshaun.Sanford24@yahoo.com",
                    },
                    new HrisEmail() {
                        Email = "Rebeca.Dibbert11@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Hester80@gmail.com",
                    },
                },
                Name = "Automotive",
                Type = HrisEmployeerelationshipType.Emergency,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Benedict_Wisozk83@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Princess_Rath43@gmail.com",
                    },
                    new HrisEmail() {
                        Email = "Elmira92@yahoo.com",
                    },
                },
                Name = "Music",
                Type = HrisEmployeerelationshipType.Friend,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Jane30@gmail.com",
                    },
                },
                Name = "Jewelry",
                Type = HrisEmployeerelationshipType.Sibling,
            },
        },
        Salutation = "Miss",
        SsnSin = "yMRtj0Q3xO",
        StorageQuotaAllocated = 3674489D,
        StorageQuotaAvailable = 7748057D,
        StorageQuotaUsed = 301727D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(409) 801-3705",
                Type = HrisTelephoneType.Fax,
            },
        },
        TerminationReason = "Communis adnuo damnatio atavus terebro acies canis cogito triumphus creber temptatio defendo cubo amissio paulatim corroboro.",
        TimeoffDaysTotal = 12D,
        TimeoffDaysUsed = 6D,
        Timezone = "Africa/Harare",
        Title = "Investor Paradigm Liaison",
        UpdatedAt = System.DateTime.Parse("2022-02-19T15:16:40.961Z").ToUniversalTime(),
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

Remove an employee

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

Update an employee

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
            Address1 = "52008 Lansdowne Road",
            Address2 = "Apt. 101",
            City = "Connellyberg",
            CountryCode = "US",
            PostalCode = "18978",
            Region = "South Dakota",
            RegionCode = "NM",
        },
        Bio = "sushi devotee, singer",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 69148D,
                Currency = "CRC",
                Frequency = HrisCompensationFrequency.Quarter,
                Notes = "Tergeo laborum laboriosam tutis.",
                Type = HrisCompensationType.Equity,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "IDR",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "Zetta_Prohaska67@hotmail.com",
                Type = HrisEmailType.Home,
            },
        },
        EmployeeNumber = "YuOt169CGu",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.Volunteer,
        FirstName = "Zetta",
        Gender = HrisEmployeeGender.Intersex,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2023-05-11T04:37:54.752Z").ToUniversalTime(),
        Id = "27b5a40e-eb9f-44d5-a039-62df6697f625",
        ImageUrl = "https://loremflickr.com/3684/2116?lock=4686991638584456",
        LanguageLocale = "es",
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
                Id = "918c060a-fa04-4e39-a700-9bb71caab15e",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tenetur"
                ),
            },
        },
        Name = "Zetta Prohaska",
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Deshaun.Sanford24@yahoo.com",
                    },
                    new HrisEmail() {
                        Email = "Rebeca.Dibbert11@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Hester80@gmail.com",
                    },
                },
                Name = "Automotive",
                Type = HrisEmployeerelationshipType.Emergency,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Benedict_Wisozk83@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Princess_Rath43@gmail.com",
                    },
                    new HrisEmail() {
                        Email = "Elmira92@yahoo.com",
                    },
                },
                Name = "Music",
                Type = HrisEmployeerelationshipType.Friend,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Jane30@gmail.com",
                    },
                },
                Name = "Jewelry",
                Type = HrisEmployeerelationshipType.Sibling,
            },
        },
        Salutation = "Miss",
        SsnSin = "yMRtj0Q3xO",
        StorageQuotaAllocated = 3674489D,
        StorageQuotaAvailable = 7748057D,
        StorageQuotaUsed = 301727D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(409) 801-3705",
                Type = HrisTelephoneType.Fax,
            },
        },
        TerminationReason = "Communis adnuo damnatio atavus terebro acies canis cogito triumphus creber temptatio defendo cubo amissio paulatim corroboro.",
        TimeoffDaysTotal = 12D,
        TimeoffDaysUsed = 6D,
        Timezone = "Africa/Harare",
        Title = "Investor Paradigm Liaison",
        UpdatedAt = System.DateTime.Parse("2022-02-19T15:16:40.961Z").ToUniversalTime(),
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