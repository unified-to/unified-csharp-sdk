# Ats

## Overview

### Available Operations

* [CreateAtsActivity](#createatsactivity) - Create an activity
* [CreateAtsApplication](#createatsapplication) - Create an application
* [CreateAtsCandidate](#createatscandidate) - Create a candidate
* [CreateAtsCompany](#createatscompany) - Create a company
* [CreateAtsDocument](#createatsdocument) - Create a document
* [CreateAtsInterview](#createatsinterview) - Create an interview
* [CreateAtsJob](#createatsjob) - Create a job
* [CreateAtsScorecard](#createatsscorecard) - Create a scorecard
* [GetAtsActivity](#getatsactivity) - Retrieve an activity
* [GetAtsApplication](#getatsapplication) - Retrieve an application
* [GetAtsApplicationstatus](#getatsapplicationstatus) - Retrieve an applicationstatus
* [GetAtsCandidate](#getatscandidate) - Retrieve a candidate
* [GetAtsCompany](#getatscompany) - Retrieve a company
* [GetAtsDocument](#getatsdocument) - Retrieve a document
* [GetAtsInterview](#getatsinterview) - Retrieve an interview
* [GetAtsJob](#getatsjob) - Retrieve a job
* [GetAtsScorecard](#getatsscorecard) - Retrieve a scorecard
* [ListAtsActivities](#listatsactivities) - List all activities
* [ListAtsApplications](#listatsapplications) - List all applications
* [ListAtsApplicationstatuses](#listatsapplicationstatuses) - List all applicationstatuses
* [ListAtsCandidates](#listatscandidates) - List all candidates
* [ListAtsCompanies](#listatscompanies) - List all companies
* [ListAtsDocuments](#listatsdocuments) - List all documents
* [ListAtsInterviews](#listatsinterviews) - List all interviews
* [ListAtsJobs](#listatsjobs) - List all jobs
* [ListAtsScorecards](#listatsscorecards) - List all scorecards
* [PatchAtsActivity](#patchatsactivity) - Update an activity
* [PatchAtsApplication](#patchatsapplication) - Update an application
* [PatchAtsCandidate](#patchatscandidate) - Update a candidate
* [PatchAtsCompany](#patchatscompany) - Update a company
* [PatchAtsDocument](#patchatsdocument) - Update a document
* [PatchAtsInterview](#patchatsinterview) - Update an interview
* [PatchAtsJob](#patchatsjob) - Update a job
* [PatchAtsScorecard](#patchatsscorecard) - Update a scorecard
* [RemoveAtsActivity](#removeatsactivity) - Remove an activity
* [RemoveAtsApplication](#removeatsapplication) - Remove an application
* [RemoveAtsCandidate](#removeatscandidate) - Remove a candidate
* [RemoveAtsCompany](#removeatscompany) - Remove a company
* [RemoveAtsDocument](#removeatsdocument) - Remove a document
* [RemoveAtsInterview](#removeatsinterview) - Remove an interview
* [RemoveAtsJob](#removeatsjob) - Remove a job
* [RemoveAtsScorecard](#removeatsscorecard) - Remove a scorecard
* [UpdateAtsActivity](#updateatsactivity) - Update an activity
* [UpdateAtsApplication](#updateatsapplication) - Update an application
* [UpdateAtsCandidate](#updateatscandidate) - Update a candidate
* [UpdateAtsCompany](#updateatscompany) - Update a company
* [UpdateAtsDocument](#updateatsdocument) - Update a document
* [UpdateAtsInterview](#updateatsinterview) - Update an interview
* [UpdateAtsJob](#updateatsjob) - Update a job
* [UpdateAtsScorecard](#updateatsscorecard) - Update a scorecard

## CreateAtsActivity

Creates a AtsActivity. Provide the unified AtsActivity fields in the request body; they are mapped to the provider's API. Returns the created AtsActivity.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsActivity" method="post" path="/ats/{connection_id}/activity" example="ats_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsActivityAsync(
    atsActivity: new AtsActivity() {
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Sapiente.",
        Id = "234ae7c7-32e1-4645-8e71-51355bdc4283",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "b8677710-ad4a-4efb-a758-a8cb2ecb6256",
                Namespace = "activity",
                Slug = "cimentarius",
                Value = AtsMetadataValue.CreateStr(
                    "Reprehenderit verto."
                ),
            },
        },
        SubType = "TASK",
        Title = "Venio blandior aureus.",
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-04-06T00:38:27.363Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsActivity`                                                                                                                                    | [AtsActivity](../../Models/Components/AtsActivity.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsActivityQueryParamFields](../../Models/Requests/CreateAtsActivityQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsActivityResponse](../../Models/Requests/CreateAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAtsApplication

Creates a AtsApplication. Provide the unified AtsApplication fields in the request body; they are mapped to the provider's API. Returns the created AtsApplication.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsApplication" method="post" path="/ats/{connection_id}/application" example="ats_application" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsApplicationAsync(
    atsApplication: new AtsApplication() {
        Answers = new List<AtsApplicationAnswer>() {},
        AppliedAt = System.DateTime.Parse("2025-10-01T02:01:14.973Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-14T11:42:47.511Z").ToUniversalTime(),
        Id = "590bfa93-bc5b-45c0-8d5b-710c35d458df",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "ad0065d1-c9be-45d8-90b5-30720a9f72f3",
                Namespace = "application",
                Slug = "stella",
                Value = AtsMetadataValue.CreateStr(
                    "Caput."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-10-13T12:59:07.100Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Arguo repudiandae defessus. Adflicto caecus claustrum annus addo vere crebro. Alias sponte turbo sopor vergo surculus nam.",
        UpdatedAt = System.DateTime.Parse("2026-10-20T09:31:25.054Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsApplication`                                                                                                                                 | [AtsApplication](../../Models/Components/AtsApplication.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsApplicationQueryParamFields](../../Models/Requests/CreateAtsApplicationQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsApplicationResponse](../../Models/Requests/CreateAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAtsCandidate

Creates a AtsCandidate. Provide the unified AtsCandidate fields in the request body; they are mapped to the provider's API. Returns the created AtsCandidate.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsCandidate" method="post" path="/ats/{connection_id}/candidate" example="ats_candidate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsCandidateAsync(
    atsCandidate: new AtsCandidate() {
        Address = new PropertyAtsCandidateAddress() {
            Address1 = "6790 S 1st Street",
            City = "Ferrystad",
            CountryCode = "US",
            PostalCode = "91605",
            Region = "Idaho",
            RegionCode = "HI",
        },
        CompanyName = "Lehner and Sons",
        CreatedAt = System.DateTime.Parse("2023-10-16T05:42:56.049Z").ToUniversalTime(),
        DateOfBirth = System.DateTime.Parse("1994-07-05T19:48:57.631Z").ToUniversalTime(),
        Education = new List<AtsCandidateEducation>() {
            new AtsCandidateEducation() {
                Degree = "emphasize tricky",
                EndAt = System.DateTime.Parse("1978-04-14T07:58:36.326Z").ToUniversalTime(),
                FieldOfStudy = "curtus",
                Institution = "Abbott - Batz",
                Level = "phd",
                StartAt = System.DateTime.Parse("1994-06-09T13:31:39.059Z").ToUniversalTime(),
            },
            new AtsCandidateEducation() {
                Degree = "blah cappelletti",
                EndAt = System.DateTime.Parse("1989-09-06T03:32:39.901Z").ToUniversalTime(),
                FieldOfStudy = "crustulum",
                Institution = "Herman, Franey and Lebsack",
                Level = "highschool",
                StartAt = System.DateTime.Parse("1992-11-28T20:23:20.311Z").ToUniversalTime(),
            },
        },
        Emails = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "ardith.beatty@outlook.com",
                Name = "Ardith Beatty",
                Type = AtsEmailType.Home,
            },
        },
        Experiences = new List<AtsCandidateExperience>() {
            new AtsCandidateExperience() {
                CompanyName = "Kutch, Lind and Marks",
                EndAt = System.DateTime.Parse("1974-03-01T17:02:58.824Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1999-09-21T22:12:51.663Z").ToUniversalTime(),
                Title = "Lead Security Technician",
            },
            new AtsCandidateExperience() {
                CompanyName = "Trantow, Sipes and Witting",
                EndAt = System.DateTime.Parse("2004-10-14T14:01:00.717Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1996-12-15T04:12:04.582Z").ToUniversalTime(),
                Title = "Regional Applications Planner",
            },
        },
        FirstName = "Ardith",
        Id = "700e8535-67c4-40d0-80c5-f051be53c98f",
        ImageUrl = "https://avatars.githubusercontent.com/u/27464445",
        JobIds = new List<string>() {},
        LastName = "Beatty",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/ardith-beatty",
        },
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "ef8efc9b-aba5-478f-b725-3b20559dff4c",
                Namespace = "custom",
                Slug = "custom_field",
                Value = AtsMetadataValue.CreateStr(
                    "officia"
                ),
            },
        },
        Name = "Ardith Beatty",
        Origin = Origin.Agency,
        Skills = new List<string>() {
            "trepide",
            "voveo",
        },
        Sources = new List<string>() {
            "vesper",
            "utroque",
        },
        Summary = "Laborum trado carcer delibero patruus totam. Vita cohors cariosus trans denego barba rerum similique. Templum totam suus voluptatem cui depraedor virgo cui comminor commodi.",
        Tags = new List<string>() {
            "voro",
        },
        Telephones = new List<AtsTelephone>() {
            new AtsTelephone() {
                Telephone = "(837) 251-3896",
                Type = AtsTelephoneType.Mobile,
            },
        },
        Title = "Customer Division Producer",
        UpdatedAt = System.DateTime.Parse("2024-04-29T02:22:03.326Z").ToUniversalTime(),
        WebUrl = "https://fragrant-husband.net/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsCandidate`                                                                                                                                   | [AtsCandidate](../../Models/Components/AtsCandidate.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsCandidateQueryParamFields](../../Models/Requests/CreateAtsCandidateQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsCandidateResponse](../../Models/Requests/CreateAtsCandidateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ats.CreateAtsCompanyAsync(
    atsCompany: new AtsCompany() {
        CreatedAt = System.DateTime.Parse("2019-04-22T03:50:02.920Z").ToUniversalTime(),
        Id = "2885822d-7f44-4e4d-baff-7172e3c217d2",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-882-360-2010",
        UpdatedAt = System.DateTime.Parse("2020-10-01T13:30:53.022Z").ToUniversalTime(),
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

## CreateAtsDocument

Creates a AtsDocument. Provide the unified AtsDocument fields in the request body; they are mapped to the provider's API. Returns the created AtsDocument.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsDocument" method="post" path="/ats/{connection_id}/document" example="ats_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsDocumentAsync(
    atsDocument: new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "lonzo_schowalter_resume.pdf",
        Id = "91cb7af6-5d47-4979-88d7-de3c35074ce1",
        Metadata = new List<AtsMetadata>() {},
        Type = AtsDocumentType.CoverLetter,
        UpdatedAt = System.DateTime.Parse("2022-12-07T17:07:09.102Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsDocument`                                                                                                                                    | [AtsDocument](../../Models/Components/AtsDocument.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsDocumentQueryParamFields](../../Models/Requests/CreateAtsDocumentQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsDocumentResponse](../../Models/Requests/CreateAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAtsInterview

Creates a AtsInterview. Provide the unified AtsInterview fields in the request body; they are mapped to the provider's API. Returns the created AtsInterview.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsInterview" method="post" path="/ats/{connection_id}/interview" example="ats_interview" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsInterviewAsync(
    atsInterview: new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2021-12-08T06:33:19.583Z").ToUniversalTime(),
        Id = "ece287e1-b69d-4b47-869c-31d7e2a1b735",
        Location = "26596 Halle Trafficway",
        MeetingUrl = "https://immaculate-foodstuffs.biz",
        Metadata = new List<AtsMetadata>() {},
        StartAt = System.DateTime.Parse("2021-12-08T06:03:19.583Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2023-09-24T10:35:59.559Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsInterview`                                                                                                                                   | [AtsInterview](../../Models/Components/AtsInterview.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsInterviewQueryParamFields](../../Models/Requests/CreateAtsInterviewQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsInterviewResponse](../../Models/Requests/CreateAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAtsJob

Creates a AtsJob. Provide the unified AtsJob fields in the request body; they are mapped to the provider's API. Returns the created AtsJob.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsJob" method="post" path="/ats/{connection_id}/job" example="ats_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsJobAsync(
    atsJob: new AtsJob() {
        Addresses = new List<AtsAddress>() {
            new AtsAddress() {
                Address1 = "98097 Carlo Trail",
                City = "South Judd",
                CountryCode = "US",
                PostalCode = "89776-0669",
                Region = "Mississippi",
                RegionCode = "FL",
            },
        },
        Compensation = new List<AtsCompensation>() {
            new AtsCompensation() {
                Currency = "AUD",
                Frequency = Frequency.Day,
                Max = 174303D,
                Min = 174042D,
                Type = AtsCompensationType.Bonus,
            },
            new AtsCompensation() {
                Currency = "MZN",
                Frequency = Frequency.Month,
                Max = 171171D,
                Min = 151975D,
                Type = AtsCompensationType.Salary,
            },
        },
        CreatedAt = System.DateTime.Parse("2023-06-16T12:51:44.518Z").ToUniversalTime(),
        Description = "Global",
        EmploymentType = EmploymentType.Freelance,
        HiringManagers = new List<AtsReference>() {},
        Id = "70a0cd50-6a73-4931-81df-955e547db81f",
        Industry = "Handcrafted Bamboo Soap",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "e17b2e2c-e1f6-4bbe-9c55-35c78b7de037",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "desolo"
                ),
            },
        },
        MinimumDegree = "Bachelor",
        MinimumExperienceYears = 3D,
        Name = "Forward Brand Producer",
        NumberOfOpenings = 1D,
        Openings = new List<AtsJobOpening>() {
            new AtsJobOpening() {
                CloseReason = "Admoveo trado textilis.",
                OpenedAt = System.DateTime.Parse("2026-06-09T16:24:53.329Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "75008 Medhurst Road",
                    City = "Madelynnshire",
                    CountryCode = "US",
                    PostalCode = "98754",
                    Region = "Wisconsin",
                    RegionCode = "CO",
                },
                CreatedAt = System.DateTime.Parse("2026-08-03T21:36:49.692Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "bcf1ec45-8f8b-4e84-b11f-6acde4e11288",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-30T06:02:09.746Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "00d3f950-2418-49d5-b0b0-bb9f37c75e92",
                MaxLength = 117D,
                MinLength = 1D,
                Options = new List<string>() {
                    "tactus",
                    "vehemens",
                },
                Prompt = "Totam maxime tres tergiversatio.",
                Question = "Doloribus mollitia.",
                Required = true,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Id = "3762d1ab-c48b-4b5f-827a-6e4724007336",
                MaxLength = 453D,
                MinLength = 1D,
                Options = new List<string>() {
                    "constans",
                },
                Prompt = "Veritatis sodalitas nemo natus attonbitus reprehenderit voro depono.",
                Question = "Nam.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Taceo rem compello spectaculum mollitia arcus compello.",
                Id = "af3f8959-7390-475f-8930-aa409bc463ad",
                MaxLength = 66D,
                MinLength = 1D,
                Options = new List<string>() {
                    "repellendus",
                },
                Prompt = "Tum tamisium autus.",
                Question = "Confero trepide.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "suadeo",
            "utrimque",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Crepusculum adsuesco vere.",
        UpdatedAt = System.DateTime.Parse("2026-03-01T00:45:55.924Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsJob`                                                                                                                                         | [AtsJob](../../Models/Components/AtsJob.md)                                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsJobQueryParamFields](../../Models/Requests/CreateAtsJobQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsJobResponse](../../Models/Requests/CreateAtsJobResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateAtsScorecard

Creates a AtsScorecard. Provide the unified AtsScorecard fields in the request body; they are mapped to the provider's API. Returns the created AtsScorecard.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsScorecard" method="post" path="/ats/{connection_id}/scorecard" example="ats_scorecard" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsScorecardAsync(
    atsScorecard: new AtsScorecard() {
        Comment = "Maiores enim.",
        CreatedAt = System.DateTime.Parse("2022-02-20T17:09:45.498Z").ToUniversalTime(),
        Id = "20003d53-47c0-4460-94a2-5b91e17342c5",
        Metadata = new List<AtsMetadata>() {},
        Questions = new List<AtsScorecardQuestion>() {
            new AtsScorecardQuestion() {
                Description = "Sulum textor eveniet facere vita.",
                Text = "Aliquam.",
            },
            new AtsScorecardQuestion() {
                Answer = "Decretum.",
                Description = "Conatus cicuta doloremque statua bonus.",
                Text = "Pecto vulpes libero vomer comburo.",
            },
        },
        Recommendation = Recommendation.StrongYes,
        UpdatedAt = System.DateTime.Parse("2023-06-06T02:59:11.555Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsScorecard`                                                                                                                                   | [AtsScorecard](../../Models/Components/AtsScorecard.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsScorecardQueryParamFields](../../Models/Requests/CreateAtsScorecardQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsScorecardResponse](../../Models/Requests/CreateAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsActivity

Retrieves a single AtsActivity by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsActivity" method="get" path="/ats/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Activity                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAtsActivityQueryParamFields](../../Models/Requests/GetAtsActivityQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsActivityResponse](../../Models/Requests/GetAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsApplication

Retrieves a single AtsApplication by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsApplication" method="get" path="/ats/{connection_id}/application/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsApplicationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Application                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetAtsApplicationQueryParamFields](../../Models/Requests/GetAtsApplicationQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsApplicationResponse](../../Models/Requests/GetAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsApplicationstatus

Retrieves a single AtsStatus by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsApplicationstatus" method="get" path="/ats/{connection_id}/applicationstatus/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsApplicationstatusAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Applicationstatus                                                                                                                      |
| `Fields`                                                                                                                                         | List<[GetAtsApplicationstatusQueryParamFields](../../Models/Requests/GetAtsApplicationstatusQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsApplicationstatusResponse](../../Models/Requests/GetAtsApplicationstatusResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsCandidate

Retrieves a single AtsCandidate by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsCandidate" method="get" path="/ats/{connection_id}/candidate/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsCandidateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Candidate                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetAtsCandidateQueryParamFields](../../Models/Requests/GetAtsCandidateQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsCandidateResponse](../../Models/Requests/GetAtsCandidateResponse.md)**

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

var res = await sdk.Ats.GetAtsCompanyAsync(
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

## GetAtsDocument

Retrieves a single AtsDocument by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsDocument" method="get" path="/ats/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Document                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAtsDocumentQueryParamFields](../../Models/Requests/GetAtsDocumentQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsDocumentResponse](../../Models/Requests/GetAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsInterview

Retrieves a single AtsInterview by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsInterview" method="get" path="/ats/{connection_id}/interview/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsInterviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Interview                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetAtsInterviewQueryParamFields](../../Models/Requests/GetAtsInterviewQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsInterviewResponse](../../Models/Requests/GetAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsJob

Retrieves a single AtsJob by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsJob" method="get" path="/ats/{connection_id}/job/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsJobAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Job                                                                                                                                    |
| `Fields`                                                                                                                                         | List<[GetAtsJobQueryParamFields](../../Models/Requests/GetAtsJobQueryParamFields.md)>                                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsJobResponse](../../Models/Requests/GetAtsJobResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsScorecard

Retrieves a single AtsScorecard by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsScorecard" method="get" path="/ats/{connection_id}/scorecard/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.GetAtsScorecardAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Scorecard                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetAtsScorecardQueryParamFields](../../Models/Requests/GetAtsScorecardQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsScorecardResponse](../../Models/Requests/GetAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsActivities

Returns a list of AtsActivities. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsActivities" method="get" path="/ats/{connection_id}/activity" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsActivitiesRequest req = new ListAtsActivitiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsActivitiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsActivitiesRequest](../../Models/Requests/ListAtsActivitiesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsActivitiesResponse](../../Models/Requests/ListAtsActivitiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsApplications

Returns a list of AtsApplications. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsApplications" method="get" path="/ats/{connection_id}/application" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsApplicationsRequest req = new ListAtsApplicationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsApplicationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAtsApplicationsRequest](../../Models/Requests/ListAtsApplicationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListAtsApplicationsResponse](../../Models/Requests/ListAtsApplicationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsApplicationstatuses

Returns a list of AtsStatuses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsApplicationstatuses" method="get" path="/ats/{connection_id}/applicationstatus" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsApplicationstatusesRequest req = new ListAtsApplicationstatusesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsApplicationstatusesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAtsApplicationstatusesRequest](../../Models/Requests/ListAtsApplicationstatusesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListAtsApplicationstatusesResponse](../../Models/Requests/ListAtsApplicationstatusesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsCandidates

Returns a list of AtsCandidates. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsCandidates" method="get" path="/ats/{connection_id}/candidate" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsCandidatesRequest req = new ListAtsCandidatesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsCandidatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsCandidatesRequest](../../Models/Requests/ListAtsCandidatesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsCandidatesResponse](../../Models/Requests/ListAtsCandidatesResponse.md)**

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

var res = await sdk.Ats.ListAtsCompaniesAsync(req);

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

## ListAtsDocuments

Returns a list of AtsDocuments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsDocuments" method="get" path="/ats/{connection_id}/document" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsDocumentsRequest req = new ListAtsDocumentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsDocumentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAtsDocumentsRequest](../../Models/Requests/ListAtsDocumentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListAtsDocumentsResponse](../../Models/Requests/ListAtsDocumentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsInterviews

Returns a list of AtsInterviews. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsInterviews" method="get" path="/ats/{connection_id}/interview" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsInterviewsRequest req = new ListAtsInterviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsInterviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsInterviewsRequest](../../Models/Requests/ListAtsInterviewsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsInterviewsResponse](../../Models/Requests/ListAtsInterviewsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsJobs

Returns a list of AtsJobs. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsJobs" method="get" path="/ats/{connection_id}/job" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsJobsRequest req = new ListAtsJobsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsJobsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListAtsJobsRequest](../../Models/Requests/ListAtsJobsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListAtsJobsResponse](../../Models/Requests/ListAtsJobsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsScorecards

Returns a list of AtsScorecards. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsScorecards" method="get" path="/ats/{connection_id}/scorecard" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsScorecardsRequest req = new ListAtsScorecardsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Ats.ListAtsScorecardsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsScorecardsRequest](../../Models/Requests/ListAtsScorecardsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsScorecardsResponse](../../Models/Requests/ListAtsScorecardsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsActivity

Updates the AtsActivity identified by `id`. Provide the unified AtsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsActivity" method="patch" path="/ats/{connection_id}/activity/{id}" example="ats_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsActivityRequest req = new PatchAtsActivityRequest() {
    AtsActivity = new AtsActivity() {
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Sapiente.",
        Id = "413a9aba-4459-4215-ad1c-a369b0157c38",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "7db47775-5471-4a4b-a8f4-0c1aeaf5727b",
                Namespace = "activity",
                Slug = "cimentarius",
                Value = AtsMetadataValue.CreateStr(
                    "Reprehenderit verto."
                ),
            },
        },
        SubType = "TASK",
        Title = "Venio blandior aureus.",
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-04-06T00:38:27.387Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchAtsActivityRequest](../../Models/Requests/PatchAtsActivityRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchAtsActivityResponse](../../Models/Requests/PatchAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsApplication

Updates the AtsApplication identified by `id`. Provide the unified AtsApplication fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsApplication" method="patch" path="/ats/{connection_id}/application/{id}" example="ats_application" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsApplicationRequest req = new PatchAtsApplicationRequest() {
    AtsApplication = new AtsApplication() {
        Answers = new List<AtsApplicationAnswer>() {},
        AppliedAt = System.DateTime.Parse("2025-10-01T02:01:14.997Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-14T11:42:47.542Z").ToUniversalTime(),
        Id = "06b8a64c-dac5-4046-9f93-22dd20a13efc",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "eb340a7f-3ea4-4850-89d9-cc00bbd7ef03",
                Namespace = "application",
                Slug = "stella",
                Value = AtsMetadataValue.CreateStr(
                    "Caput."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-10-13T12:59:07.137Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Arguo repudiandae defessus. Adflicto caecus claustrum annus addo vere crebro. Alias sponte turbo sopor vergo surculus nam.",
        UpdatedAt = System.DateTime.Parse("2026-10-20T09:31:25.091Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsApplicationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchAtsApplicationRequest](../../Models/Requests/PatchAtsApplicationRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchAtsApplicationResponse](../../Models/Requests/PatchAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsCandidate

Updates the AtsCandidate identified by `id`. Provide the unified AtsCandidate fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsCandidate" method="patch" path="/ats/{connection_id}/candidate/{id}" example="ats_candidate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsCandidateRequest req = new PatchAtsCandidateRequest() {
    AtsCandidate = new AtsCandidate() {
        Address = new PropertyAtsCandidateAddress() {
            Address1 = "6790 S 1st Street",
            City = "Ferrystad",
            CountryCode = "US",
            PostalCode = "91605",
            Region = "Idaho",
            RegionCode = "HI",
        },
        CompanyName = "Lehner and Sons",
        CreatedAt = System.DateTime.Parse("2023-10-16T05:42:56.049Z").ToUniversalTime(),
        DateOfBirth = System.DateTime.Parse("1994-07-05T19:48:57.631Z").ToUniversalTime(),
        Education = new List<AtsCandidateEducation>() {
            new AtsCandidateEducation() {
                Degree = "emphasize tricky",
                EndAt = System.DateTime.Parse("1978-04-14T07:58:36.326Z").ToUniversalTime(),
                FieldOfStudy = "curtus",
                Institution = "Abbott - Batz",
                Level = "phd",
                StartAt = System.DateTime.Parse("1994-06-09T13:31:39.059Z").ToUniversalTime(),
            },
            new AtsCandidateEducation() {
                Degree = "blah cappelletti",
                EndAt = System.DateTime.Parse("1989-09-06T03:32:39.901Z").ToUniversalTime(),
                FieldOfStudy = "crustulum",
                Institution = "Herman, Franey and Lebsack",
                Level = "highschool",
                StartAt = System.DateTime.Parse("1992-11-28T20:23:20.311Z").ToUniversalTime(),
            },
        },
        Emails = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "ardith.beatty@outlook.com",
                Name = "Ardith Beatty",
                Type = AtsEmailType.Home,
            },
        },
        Experiences = new List<AtsCandidateExperience>() {
            new AtsCandidateExperience() {
                CompanyName = "Kutch, Lind and Marks",
                EndAt = System.DateTime.Parse("1974-03-01T17:02:58.824Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1999-09-21T22:12:51.663Z").ToUniversalTime(),
                Title = "Lead Security Technician",
            },
            new AtsCandidateExperience() {
                CompanyName = "Trantow, Sipes and Witting",
                EndAt = System.DateTime.Parse("2004-10-14T14:01:00.717Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1996-12-15T04:12:04.582Z").ToUniversalTime(),
                Title = "Regional Applications Planner",
            },
        },
        FirstName = "Ardith",
        Id = "b62747af-e683-47ed-a8ae-2623785d72f4",
        ImageUrl = "https://avatars.githubusercontent.com/u/27464445",
        JobIds = new List<string>() {},
        LastName = "Beatty",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/ardith-beatty",
        },
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "e04fb999-8a3e-4db0-9b3b-a2031cc8e9da",
                Namespace = "custom",
                Slug = "custom_field",
                Value = AtsMetadataValue.CreateStr(
                    "officia"
                ),
            },
        },
        Name = "Ardith Beatty",
        Origin = Origin.Agency,
        Skills = new List<string>() {
            "trepide",
            "voveo",
        },
        Sources = new List<string>() {
            "vesper",
            "utroque",
        },
        Summary = "Laborum trado carcer delibero patruus totam. Vita cohors cariosus trans denego barba rerum similique. Templum totam suus voluptatem cui depraedor virgo cui comminor commodi.",
        Tags = new List<string>() {
            "voro",
        },
        Telephones = new List<AtsTelephone>() {
            new AtsTelephone() {
                Telephone = "(837) 251-3896",
                Type = AtsTelephoneType.Mobile,
            },
        },
        Title = "Customer Division Producer",
        UpdatedAt = System.DateTime.Parse("2024-04-29T02:22:03.335Z").ToUniversalTime(),
        WebUrl = "https://fragrant-husband.net/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsCandidateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchAtsCandidateRequest](../../Models/Requests/PatchAtsCandidateRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchAtsCandidateResponse](../../Models/Requests/PatchAtsCandidateResponse.md)**

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
        Id = "ed968e66-5a84-4ef2-8d83-34a96c34da50",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-882-360-2010",
        UpdatedAt = System.DateTime.Parse("2020-10-01T13:30:53.028Z").ToUniversalTime(),
        WebsiteUrl = "https://www.gulgowskidibbert.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsCompanyAsync(req);

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

## PatchAtsDocument

Updates the AtsDocument identified by `id`. Provide the unified AtsDocument fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsDocument" method="patch" path="/ats/{connection_id}/document/{id}" example="ats_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsDocumentRequest req = new PatchAtsDocumentRequest() {
    AtsDocument = new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "lonzo_schowalter_resume.pdf",
        Id = "aff0a09c-c82f-4e08-83d0-7a014dcb4899",
        Metadata = new List<AtsMetadata>() {},
        Type = AtsDocumentType.CoverLetter,
        UpdatedAt = System.DateTime.Parse("2022-12-07T17:07:09.106Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchAtsDocumentRequest](../../Models/Requests/PatchAtsDocumentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchAtsDocumentResponse](../../Models/Requests/PatchAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsInterview

Updates the AtsInterview identified by `id`. Provide the unified AtsInterview fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsInterview" method="patch" path="/ats/{connection_id}/interview/{id}" example="ats_interview" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsInterviewRequest req = new PatchAtsInterviewRequest() {
    AtsInterview = new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2021-12-08T06:33:19.583Z").ToUniversalTime(),
        Id = "521e3523-ee5b-4e8d-a302-b88d9fb93450",
        Location = "26596 Halle Trafficway",
        MeetingUrl = "https://immaculate-foodstuffs.biz",
        Metadata = new List<AtsMetadata>() {},
        StartAt = System.DateTime.Parse("2021-12-08T06:03:19.583Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2023-09-24T10:35:59.566Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsInterviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchAtsInterviewRequest](../../Models/Requests/PatchAtsInterviewRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchAtsInterviewResponse](../../Models/Requests/PatchAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsJob

Updates the AtsJob identified by `id`. Provide the unified AtsJob fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsJob" method="patch" path="/ats/{connection_id}/job/{id}" example="ats_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsJobRequest req = new PatchAtsJobRequest() {
    AtsJob = new AtsJob() {
        Addresses = new List<AtsAddress>() {
            new AtsAddress() {
                Address1 = "98097 Carlo Trail",
                City = "South Judd",
                CountryCode = "US",
                PostalCode = "89776-0669",
                Region = "Mississippi",
                RegionCode = "FL",
            },
        },
        Compensation = new List<AtsCompensation>() {
            new AtsCompensation() {
                Currency = "AUD",
                Frequency = Frequency.Day,
                Max = 174303D,
                Min = 174042D,
                Type = AtsCompensationType.Bonus,
            },
            new AtsCompensation() {
                Currency = "MZN",
                Frequency = Frequency.Month,
                Max = 171171D,
                Min = 151975D,
                Type = AtsCompensationType.Salary,
            },
        },
        CreatedAt = System.DateTime.Parse("2023-06-16T12:51:44.518Z").ToUniversalTime(),
        Description = "Global",
        EmploymentType = EmploymentType.Freelance,
        HiringManagers = new List<AtsReference>() {},
        Id = "39dcb301-75a0-4683-9d80-98986cad0970",
        Industry = "Handcrafted Bamboo Soap",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "7d3c875b-388f-4fa5-9486-231726ae3e1f",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "desolo"
                ),
            },
        },
        MinimumDegree = "Bachelor",
        MinimumExperienceYears = 3D,
        Name = "Forward Brand Producer",
        NumberOfOpenings = 1D,
        Openings = new List<AtsJobOpening>() {
            new AtsJobOpening() {
                CloseReason = "Admoveo trado textilis.",
                OpenedAt = System.DateTime.Parse("2026-06-09T16:24:53.389Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "75008 Medhurst Road",
                    City = "Madelynnshire",
                    CountryCode = "US",
                    PostalCode = "98754",
                    Region = "Wisconsin",
                    RegionCode = "CO",
                },
                CreatedAt = System.DateTime.Parse("2026-08-03T21:36:49.755Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "8bbb41c8-157f-4d37-8120-017c596bd92b",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-30T06:02:09.810Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "bfdab806-8190-44bb-aa02-34bf36b152a5",
                MaxLength = 117D,
                MinLength = 1D,
                Options = new List<string>() {
                    "tactus",
                    "vehemens",
                },
                Prompt = "Totam maxime tres tergiversatio.",
                Question = "Doloribus mollitia.",
                Required = true,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Id = "85fcc01e-3625-4af2-8337-819fd9e01885",
                MaxLength = 453D,
                MinLength = 1D,
                Options = new List<string>() {
                    "constans",
                },
                Prompt = "Veritatis sodalitas nemo natus attonbitus reprehenderit voro depono.",
                Question = "Nam.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Taceo rem compello spectaculum mollitia arcus compello.",
                Id = "bac3b4f7-1c59-4e00-bf45-5abc9aa014a7",
                MaxLength = 66D,
                MinLength = 1D,
                Options = new List<string>() {
                    "repellendus",
                },
                Prompt = "Tum tamisium autus.",
                Question = "Confero trepide.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "suadeo",
            "utrimque",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Crepusculum adsuesco vere.",
        UpdatedAt = System.DateTime.Parse("2026-03-01T00:45:55.978Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [PatchAtsJobRequest](../../Models/Requests/PatchAtsJobRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[PatchAtsJobResponse](../../Models/Requests/PatchAtsJobResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsScorecard

Updates the AtsScorecard identified by `id`. Provide the unified AtsScorecard fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsScorecard" method="patch" path="/ats/{connection_id}/scorecard/{id}" example="ats_scorecard" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsScorecardRequest req = new PatchAtsScorecardRequest() {
    AtsScorecard = new AtsScorecard() {
        Comment = "Maiores enim.",
        CreatedAt = System.DateTime.Parse("2022-02-20T17:09:45.498Z").ToUniversalTime(),
        Id = "79a78c17-44be-45a6-9a76-7ca6a02cc88b",
        Metadata = new List<AtsMetadata>() {},
        Questions = new List<AtsScorecardQuestion>() {
            new AtsScorecardQuestion() {
                Description = "Sulum textor eveniet facere vita.",
                Text = "Aliquam.",
            },
            new AtsScorecardQuestion() {
                Answer = "Decretum.",
                Description = "Conatus cicuta doloremque statua bonus.",
                Text = "Pecto vulpes libero vomer comburo.",
            },
        },
        Recommendation = Recommendation.StrongYes,
        UpdatedAt = System.DateTime.Parse("2023-06-06T02:59:11.560Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.PatchAtsScorecardAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchAtsScorecardRequest](../../Models/Requests/PatchAtsScorecardRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchAtsScorecardResponse](../../Models/Requests/PatchAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsActivity

Deletes the AtsActivity identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsActivity" method="delete" path="/ats/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsActivityAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Activity   |

### Response

**[RemoveAtsActivityResponse](../../Models/Requests/RemoveAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsApplication

Deletes the AtsApplication identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsApplication" method="delete" path="/ats/{connection_id}/application/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsApplicationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Application |

### Response

**[RemoveAtsApplicationResponse](../../Models/Requests/RemoveAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsCandidate

Deletes the AtsCandidate identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsCandidate" method="delete" path="/ats/{connection_id}/candidate/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsCandidateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Candidate  |

### Response

**[RemoveAtsCandidateResponse](../../Models/Requests/RemoveAtsCandidateResponse.md)**

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

var res = await sdk.Ats.RemoveAtsCompanyAsync(
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

## RemoveAtsDocument

Deletes the AtsDocument identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsDocument" method="delete" path="/ats/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |

### Response

**[RemoveAtsDocumentResponse](../../Models/Requests/RemoveAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsInterview

Deletes the AtsInterview identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsInterview" method="delete" path="/ats/{connection_id}/interview/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsInterviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Interview  |

### Response

**[RemoveAtsInterviewResponse](../../Models/Requests/RemoveAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsJob

Deletes the AtsJob identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsJob" method="delete" path="/ats/{connection_id}/job/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsJobAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Job        |

### Response

**[RemoveAtsJobResponse](../../Models/Requests/RemoveAtsJobResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsScorecard

Deletes the AtsScorecard identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsScorecard" method="delete" path="/ats/{connection_id}/scorecard/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.RemoveAtsScorecardAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Scorecard  |

### Response

**[RemoveAtsScorecardResponse](../../Models/Requests/RemoveAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsActivity

Updates the AtsActivity identified by `id`. Provide the unified AtsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsActivity" method="put" path="/ats/{connection_id}/activity/{id}" example="ats_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsActivityRequest req = new UpdateAtsActivityRequest() {
    AtsActivity = new AtsActivity() {
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Sapiente.",
        Id = "413a9aba-4459-4215-ad1c-a369b0157c38",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "7db47775-5471-4a4b-a8f4-0c1aeaf5727b",
                Namespace = "activity",
                Slug = "cimentarius",
                Value = AtsMetadataValue.CreateStr(
                    "Reprehenderit verto."
                ),
            },
        },
        SubType = "TASK",
        Title = "Venio blandior aureus.",
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-04-06T00:38:27.387Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateAtsActivityRequest](../../Models/Requests/UpdateAtsActivityRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateAtsActivityResponse](../../Models/Requests/UpdateAtsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsApplication

Updates the AtsApplication identified by `id`. Provide the unified AtsApplication fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsApplication" method="put" path="/ats/{connection_id}/application/{id}" example="ats_application" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsApplicationRequest req = new UpdateAtsApplicationRequest() {
    AtsApplication = new AtsApplication() {
        Answers = new List<AtsApplicationAnswer>() {},
        AppliedAt = System.DateTime.Parse("2025-10-01T02:01:14.997Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-14T11:42:47.542Z").ToUniversalTime(),
        Id = "06b8a64c-dac5-4046-9f93-22dd20a13efc",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "eb340a7f-3ea4-4850-89d9-cc00bbd7ef03",
                Namespace = "application",
                Slug = "stella",
                Value = AtsMetadataValue.CreateStr(
                    "Caput."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-10-13T12:59:07.137Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Arguo repudiandae defessus. Adflicto caecus claustrum annus addo vere crebro. Alias sponte turbo sopor vergo surculus nam.",
        UpdatedAt = System.DateTime.Parse("2026-10-20T09:31:25.091Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsApplicationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateAtsApplicationRequest](../../Models/Requests/UpdateAtsApplicationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateAtsApplicationResponse](../../Models/Requests/UpdateAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsCandidate

Updates the AtsCandidate identified by `id`. Provide the unified AtsCandidate fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsCandidate" method="put" path="/ats/{connection_id}/candidate/{id}" example="ats_candidate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsCandidateRequest req = new UpdateAtsCandidateRequest() {
    AtsCandidate = new AtsCandidate() {
        Address = new PropertyAtsCandidateAddress() {
            Address1 = "6790 S 1st Street",
            City = "Ferrystad",
            CountryCode = "US",
            PostalCode = "91605",
            Region = "Idaho",
            RegionCode = "HI",
        },
        CompanyName = "Lehner and Sons",
        CreatedAt = System.DateTime.Parse("2023-10-16T05:42:56.049Z").ToUniversalTime(),
        DateOfBirth = System.DateTime.Parse("1994-07-05T19:48:57.631Z").ToUniversalTime(),
        Education = new List<AtsCandidateEducation>() {
            new AtsCandidateEducation() {
                Degree = "emphasize tricky",
                EndAt = System.DateTime.Parse("1978-04-14T07:58:36.326Z").ToUniversalTime(),
                FieldOfStudy = "curtus",
                Institution = "Abbott - Batz",
                Level = "phd",
                StartAt = System.DateTime.Parse("1994-06-09T13:31:39.059Z").ToUniversalTime(),
            },
            new AtsCandidateEducation() {
                Degree = "blah cappelletti",
                EndAt = System.DateTime.Parse("1989-09-06T03:32:39.901Z").ToUniversalTime(),
                FieldOfStudy = "crustulum",
                Institution = "Herman, Franey and Lebsack",
                Level = "highschool",
                StartAt = System.DateTime.Parse("1992-11-28T20:23:20.311Z").ToUniversalTime(),
            },
        },
        Emails = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "ardith.beatty@outlook.com",
                Name = "Ardith Beatty",
                Type = AtsEmailType.Home,
            },
        },
        Experiences = new List<AtsCandidateExperience>() {
            new AtsCandidateExperience() {
                CompanyName = "Kutch, Lind and Marks",
                EndAt = System.DateTime.Parse("1974-03-01T17:02:58.824Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1999-09-21T22:12:51.663Z").ToUniversalTime(),
                Title = "Lead Security Technician",
            },
            new AtsCandidateExperience() {
                CompanyName = "Trantow, Sipes and Witting",
                EndAt = System.DateTime.Parse("2004-10-14T14:01:00.717Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1996-12-15T04:12:04.582Z").ToUniversalTime(),
                Title = "Regional Applications Planner",
            },
        },
        FirstName = "Ardith",
        Id = "b62747af-e683-47ed-a8ae-2623785d72f4",
        ImageUrl = "https://avatars.githubusercontent.com/u/27464445",
        JobIds = new List<string>() {},
        LastName = "Beatty",
        LinkUrls = new List<string>() {
            "https://www.linkedin.com/in/ardith-beatty",
        },
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "e04fb999-8a3e-4db0-9b3b-a2031cc8e9da",
                Namespace = "custom",
                Slug = "custom_field",
                Value = AtsMetadataValue.CreateStr(
                    "officia"
                ),
            },
        },
        Name = "Ardith Beatty",
        Origin = Origin.Agency,
        Skills = new List<string>() {
            "trepide",
            "voveo",
        },
        Sources = new List<string>() {
            "vesper",
            "utroque",
        },
        Summary = "Laborum trado carcer delibero patruus totam. Vita cohors cariosus trans denego barba rerum similique. Templum totam suus voluptatem cui depraedor virgo cui comminor commodi.",
        Tags = new List<string>() {
            "voro",
        },
        Telephones = new List<AtsTelephone>() {
            new AtsTelephone() {
                Telephone = "(837) 251-3896",
                Type = AtsTelephoneType.Mobile,
            },
        },
        Title = "Customer Division Producer",
        UpdatedAt = System.DateTime.Parse("2024-04-29T02:22:03.335Z").ToUniversalTime(),
        WebUrl = "https://fragrant-husband.net/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsCandidateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateAtsCandidateRequest](../../Models/Requests/UpdateAtsCandidateRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateAtsCandidateResponse](../../Models/Requests/UpdateAtsCandidateResponse.md)**

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
        Id = "ed968e66-5a84-4ef2-8d83-34a96c34da50",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-882-360-2010",
        UpdatedAt = System.DateTime.Parse("2020-10-01T13:30:53.028Z").ToUniversalTime(),
        WebsiteUrl = "https://www.gulgowskidibbert.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsCompanyAsync(req);

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

## UpdateAtsDocument

Updates the AtsDocument identified by `id`. Provide the unified AtsDocument fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsDocument" method="put" path="/ats/{connection_id}/document/{id}" example="ats_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsDocumentRequest req = new UpdateAtsDocumentRequest() {
    AtsDocument = new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "lonzo_schowalter_resume.pdf",
        Id = "aff0a09c-c82f-4e08-83d0-7a014dcb4899",
        Metadata = new List<AtsMetadata>() {},
        Type = AtsDocumentType.CoverLetter,
        UpdatedAt = System.DateTime.Parse("2022-12-07T17:07:09.106Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateAtsDocumentRequest](../../Models/Requests/UpdateAtsDocumentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateAtsDocumentResponse](../../Models/Requests/UpdateAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsInterview

Updates the AtsInterview identified by `id`. Provide the unified AtsInterview fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsInterview" method="put" path="/ats/{connection_id}/interview/{id}" example="ats_interview" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsInterviewRequest req = new UpdateAtsInterviewRequest() {
    AtsInterview = new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2021-12-08T06:33:19.583Z").ToUniversalTime(),
        Id = "521e3523-ee5b-4e8d-a302-b88d9fb93450",
        Location = "26596 Halle Trafficway",
        MeetingUrl = "https://immaculate-foodstuffs.biz",
        Metadata = new List<AtsMetadata>() {},
        StartAt = System.DateTime.Parse("2021-12-08T06:03:19.583Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2023-09-24T10:35:59.566Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsInterviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateAtsInterviewRequest](../../Models/Requests/UpdateAtsInterviewRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateAtsInterviewResponse](../../Models/Requests/UpdateAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsJob

Updates the AtsJob identified by `id`. Provide the unified AtsJob fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsJob" method="put" path="/ats/{connection_id}/job/{id}" example="ats_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsJobRequest req = new UpdateAtsJobRequest() {
    AtsJob = new AtsJob() {
        Addresses = new List<AtsAddress>() {
            new AtsAddress() {
                Address1 = "98097 Carlo Trail",
                City = "South Judd",
                CountryCode = "US",
                PostalCode = "89776-0669",
                Region = "Mississippi",
                RegionCode = "FL",
            },
        },
        Compensation = new List<AtsCompensation>() {
            new AtsCompensation() {
                Currency = "AUD",
                Frequency = Frequency.Day,
                Max = 174303D,
                Min = 174042D,
                Type = AtsCompensationType.Bonus,
            },
            new AtsCompensation() {
                Currency = "MZN",
                Frequency = Frequency.Month,
                Max = 171171D,
                Min = 151975D,
                Type = AtsCompensationType.Salary,
            },
        },
        CreatedAt = System.DateTime.Parse("2023-06-16T12:51:44.518Z").ToUniversalTime(),
        Description = "Global",
        EmploymentType = EmploymentType.Freelance,
        HiringManagers = new List<AtsReference>() {},
        Id = "39dcb301-75a0-4683-9d80-98986cad0970",
        Industry = "Handcrafted Bamboo Soap",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "7d3c875b-388f-4fa5-9486-231726ae3e1f",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "desolo"
                ),
            },
        },
        MinimumDegree = "Bachelor",
        MinimumExperienceYears = 3D,
        Name = "Forward Brand Producer",
        NumberOfOpenings = 1D,
        Openings = new List<AtsJobOpening>() {
            new AtsJobOpening() {
                CloseReason = "Admoveo trado textilis.",
                OpenedAt = System.DateTime.Parse("2026-06-09T16:24:53.389Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "75008 Medhurst Road",
                    City = "Madelynnshire",
                    CountryCode = "US",
                    PostalCode = "98754",
                    Region = "Wisconsin",
                    RegionCode = "CO",
                },
                CreatedAt = System.DateTime.Parse("2026-08-03T21:36:49.755Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "8bbb41c8-157f-4d37-8120-017c596bd92b",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-30T06:02:09.810Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "bfdab806-8190-44bb-aa02-34bf36b152a5",
                MaxLength = 117D,
                MinLength = 1D,
                Options = new List<string>() {
                    "tactus",
                    "vehemens",
                },
                Prompt = "Totam maxime tres tergiversatio.",
                Question = "Doloribus mollitia.",
                Required = true,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Id = "85fcc01e-3625-4af2-8337-819fd9e01885",
                MaxLength = 453D,
                MinLength = 1D,
                Options = new List<string>() {
                    "constans",
                },
                Prompt = "Veritatis sodalitas nemo natus attonbitus reprehenderit voro depono.",
                Question = "Nam.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Taceo rem compello spectaculum mollitia arcus compello.",
                Id = "bac3b4f7-1c59-4e00-bf45-5abc9aa014a7",
                MaxLength = 66D,
                MinLength = 1D,
                Options = new List<string>() {
                    "repellendus",
                },
                Prompt = "Tum tamisium autus.",
                Question = "Confero trepide.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "suadeo",
            "utrimque",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Crepusculum adsuesco vere.",
        UpdatedAt = System.DateTime.Parse("2026-03-01T00:45:55.978Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [UpdateAtsJobRequest](../../Models/Requests/UpdateAtsJobRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[UpdateAtsJobResponse](../../Models/Requests/UpdateAtsJobResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsScorecard

Updates the AtsScorecard identified by `id`. Provide the unified AtsScorecard fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsScorecard" method="put" path="/ats/{connection_id}/scorecard/{id}" example="ats_scorecard" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsScorecardRequest req = new UpdateAtsScorecardRequest() {
    AtsScorecard = new AtsScorecard() {
        Comment = "Maiores enim.",
        CreatedAt = System.DateTime.Parse("2022-02-20T17:09:45.498Z").ToUniversalTime(),
        Id = "79a78c17-44be-45a6-9a76-7ca6a02cc88b",
        Metadata = new List<AtsMetadata>() {},
        Questions = new List<AtsScorecardQuestion>() {
            new AtsScorecardQuestion() {
                Description = "Sulum textor eveniet facere vita.",
                Text = "Aliquam.",
            },
            new AtsScorecardQuestion() {
                Answer = "Decretum.",
                Description = "Conatus cicuta doloremque statua bonus.",
                Text = "Pecto vulpes libero vomer comburo.",
            },
        },
        Recommendation = Recommendation.StrongYes,
        UpdatedAt = System.DateTime.Parse("2023-06-06T02:59:11.560Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Ats.UpdateAtsScorecardAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateAtsScorecardRequest](../../Models/Requests/UpdateAtsScorecardRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateAtsScorecardResponse](../../Models/Requests/UpdateAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |