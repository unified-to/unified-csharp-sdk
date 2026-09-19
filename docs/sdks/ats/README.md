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

Create an activity

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
        Bcc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Mabel_Schuppe-Schowalter42@hotmail.com",
                Name = "Rochelle Franey-Bechtelar",
                Type = AtsEmailType.Home,
            },
        },
        Cc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sasha24@hotmail.com",
                Name = "Dr. Elbert Kuvalis",
                Type = AtsEmailType.Home,
            },
            new AtsEmail() {
                Email = "Rosetta_Donnelly@gmail.com",
                Name = "Ramon Daniel",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Kathryne_Jast@yahoo.com",
                Name = "Christian Jacobson",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Eldred95@yahoo.com",
                Name = "Edna Bogan",
                Type = AtsEmailType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Amplus.",
        From = new PropertyAtsActivityFrom() {
            Email = "Norwood.Wiza47@yahoo.com",
            Name = "Toby Grant",
            Type = PropertyAtsActivityFromType.Other,
        },
        Id = "4d616fb7-05f7-4fa7-9483-7522155eaccd",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "aca30544-6772-4db8-a920-2aa7b47d12d2",
                Namespace = "activity",
                Slug = "acer",
                Value = AtsMetadataValue.CreateStr(
                    "Pauci eius cena adamo summisse arguo pectus communis arcesso tergeo."
                ),
            },
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "f0dc1719-6b04-489d-89c7-6dc00ad85026",
                Namespace = "activity",
                Slug = "tremo",
                Value = AtsMetadataValue.CreateStr(
                    "Amita delectus dicta temptatio utroque ex."
                ),
            },
        },
        SubType = "TASK",
        Title = "Senior Interactions Manager",
        To = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sister91@hotmail.com",
                Name = "Eddie Nienow PhD",
                Type = AtsEmailType.Work,
            },
        },
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-03-07T10:15:31.456Z").ToUniversalTime(),
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

Create an application

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
        AppliedAt = System.DateTime.Parse("2025-09-09T00:14:07.164Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-04-15T10:51:39.782Z").ToUniversalTime(),
        Id = "e313225a-89a6-4844-991f-e83d250f88d2",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "a1302a79-0341-40e6-b91a-daeb95584617",
                Namespace = "application",
                Slug = "despecto",
                Value = AtsMetadataValue.CreateStr(
                    "Argentum decretum cultellus aveho distinctio verecundia stella depono."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-09-09T19:25:59.827Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Comburo quidem vesica vulnus curatio. Appositus amita attonbitus conatus degenero charisma sordeo villa victoria varius. Cenaculum acsi officia.",
        UpdatedAt = System.DateTime.Parse("2026-09-16T10:53:24.705Z").ToUniversalTime(),
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

Create a candidate

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
            Address1 = "802 Roberts Squares",
            Address2 = "Suite 550",
            City = "Lake Raeganside",
            CountryCode = "US",
            PostalCode = "44530-0054",
            Region = "Tennessee",
            RegionCode = "NV",
        },
        CompanyName = "Ferry, Legros and Feest",
        CreatedAt = System.DateTime.Parse("2023-10-16T05:42:56.049Z").ToUniversalTime(),
        Education = new List<AtsCandidateEducation>() {
            new AtsCandidateEducation() {
                Degree = "mouser throughout",
                EndAt = System.DateTime.Parse("1992-11-28T20:23:20.311Z").ToUniversalTime(),
                FieldOfStudy = "solutio",
                Institution = "Heller - Lubowitz",
                Level = "phd",
                StartAt = System.DateTime.Parse("2001-03-26T08:12:11.510Z").ToUniversalTime(),
            },
        },
        Emails = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Ardith.Beatty@hotmail.com",
                Name = "Opal Lindgren",
                Type = AtsEmailType.Work,
            },
            new AtsEmail() {
                Email = "Ardith_Beatty@gmail.com",
                Name = "Kristi Nader",
                Type = AtsEmailType.Other,
            },
        },
        Experiences = new List<AtsCandidateExperience>() {
            new AtsCandidateExperience() {
                CompanyName = "Donnelly, Buckridge and Steuber",
                EndAt = System.DateTime.Parse("1978-06-20T02:53:48.383Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1980-02-06T17:16:53.798Z").ToUniversalTime(),
                Title = "Principal Brand Strategist",
            },
        },
        FirstName = "Ardith",
        Id = "e6f61bc4-a70f-4f5e-8260-a5d120496830",
        ImageUrl = "https://loremflickr.com/40/3693?lock=5634712403880328",
        JobIds = new List<string>() {},
        LastName = "Beatty",
        LinkUrls = new List<string>() {
            "https://sizzling-legislature.com",
            "https://soupy-interchange.net",
            "https://troubled-substitution.info",
        },
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "edbca8cc-918f-403a-8d6b-9d98ce326174",
                Namespace = "custom",
                Slug = "custom_field",
                Value = AtsMetadataValue.CreateStr(
                    "cariosus"
                ),
            },
        },
        Name = "Ardith Beatty",
        Origin = Origin.Sourced,
        Skills = new List<string>() {
            "vita",
            "cohors",
        },
        Sources = new List<string>() {
            "tactus",
        },
        Summary = "Denego barba rerum similique via templum totam suus voluptatem. Depraedor virgo cui comminor commodi curvo. Chirographum pax spero nostrum damnatio averto pecus cervus aspicio absens.",
        Tags = new List<string>() {
            "aliquid",
        },
        Telephones = new List<AtsTelephone>() {
            new AtsTelephone() {
                Telephone = "(779) 296-5994",
                Type = AtsTelephoneType.Home,
            },
        },
        Title = "Principal Implementation Analyst",
        UpdatedAt = System.DateTime.Parse("2024-04-23T01:20:19.046Z").ToUniversalTime(),
        WebUrl = "https://expert-lender.name/",
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

var res = await sdk.Ats.CreateAtsCompanyAsync(
    atsCompany: new AtsCompany() {
        CreatedAt = System.DateTime.Parse("2019-04-22T03:50:02.920Z").ToUniversalTime(),
        Id = "0cdd45db-2955-4964-9ef1-04c1de1909dd",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-25T00:05:26.577Z").ToUniversalTime(),
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

## CreateAtsDocument

Create a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsDocument" method="post" path="/ats/{connection_id}/document" example="ats_document" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsDocumentAsync(
    atsDocument: new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "bah_white_frantically.bz",
        Id = "365a5ffc-d717-475d-a202-6c59f383b4da",
        Type = AtsDocumentType.Resume,
        UpdatedAt = System.DateTime.Parse("2022-11-29T04:07:49.309Z").ToUniversalTime(),
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

Create an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsInterview" method="post" path="/ats/{connection_id}/interview" example="ats_interview" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Ats.CreateAtsInterviewAsync(
    atsInterview: new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-09-24T03:12:45.642Z").ToUniversalTime(),
        ExternalEventXref = "9c3b4c42-314e-4fa9-b716-ddf96bdb395c",
        Id = "9ad5d424-59eb-45ea-ba59-485302bc79bb",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-05-19T23:37:23.888Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-04T21:20:55.157Z").ToUniversalTime(),
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

Create a job

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
        HiringManagers = new List<AtsReference>() {
            new AtsReference() {
                Id = "fd9852e3-9035-4f42-beb3-bbf4e4022122",
                Name = "Eloise Mueller PhD",
            },
        },
        Id = "8e27288a-9adf-492e-8046-95892d82dfef",
        Industry = "Gorgeous Plastic Computer",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "d433dbaf-c75b-4155-9ec8-7a679f1a1161",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "acceptus"
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
                OpenedAt = System.DateTime.Parse("2026-05-10T10:05:26.877Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "8460 Nils Trace",
                    City = "West Mervinburgh",
                    CountryCode = "US",
                    PostalCode = "14162",
                    Region = "Maine",
                    RegionCode = "MO",
                },
                CreatedAt = System.DateTime.Parse("2026-07-03T02:28:02.215Z").ToUniversalTime(),
                Description = "Deduco cultellus alii terebro depono thesaurus.",
                Id = "f6101769-deb3-4721-978c-d205638870ee",
                IsActive = false,
                Location = "6788 Oxford Road",
                Name = "Forward Security Orchestrator",
                PostingUrl = "https://ajar-metabolite.net/",
                UpdatedAt = System.DateTime.Parse("2026-07-28T17:19:00.419Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Trepide provident taceo rem.",
                Id = "289f27c0-311c-41e5-ad9d-cbe2097332c2",
                Options = new List<string>() {
                    "censura",
                    "tum",
                },
                Prompt = "Spectaculum mollitia arcus compello.",
                Question = "Sodalitas nemo natus attonbitus reprehenderit voro depono constans vehemens ante.",
                Required = true,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Id = "b3a0b53b-38f3-4e8d-84b9-f413a900d79b",
                Options = new List<string>() {
                    "odit",
                },
                Prompt = "Similique absque temeritas celebrer enim.",
                Question = "Vinitor sodalitas desino sollers viduo volo.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Abstergo possimus quibusdam deinde amoveo.",
                Id = "568be61d-060e-4d8c-a8ab-8a17cb25edf3",
                Options = new List<string>() {
                    "vallum",
                },
                Prompt = "Ara thermae aetas vivo constans victoria volo carbo vehemens praesentium.",
                Question = "Subiungo ambitus neque talis amitto terreo alienus quae vulticulus.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "amiculum",
            "crux",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Amicitia vergo hic.",
        UpdatedAt = System.DateTime.Parse("2026-02-01T13:33:49.366Z").ToUniversalTime(),
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

Create a scorecard

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
        Id = "18fdfa51-527d-44dc-bc5c-ccd7e772c186",
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
        UpdatedAt = System.DateTime.Parse("2023-05-27T17:44:04.987Z").ToUniversalTime(),
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

Retrieve an activity

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

Retrieve an application

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

## GetAtsCandidate

Retrieve a candidate

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

Retrieve a company

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

Retrieve a document

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

Retrieve an interview

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

Retrieve a job

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

Retrieve a scorecard

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

List all activities

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

List all applications

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

List all applicationstatuses

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

List all candidates

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

List all documents

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

List all interviews

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

List all jobs

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

List all scorecards

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

Update an activity

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
        Bcc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Mabel_Schuppe-Schowalter42@hotmail.com",
                Name = "Rochelle Franey-Bechtelar",
                Type = AtsEmailType.Home,
            },
        },
        Cc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sasha24@hotmail.com",
                Name = "Dr. Elbert Kuvalis",
                Type = AtsEmailType.Home,
            },
            new AtsEmail() {
                Email = "Rosetta_Donnelly@gmail.com",
                Name = "Ramon Daniel",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Kathryne_Jast@yahoo.com",
                Name = "Christian Jacobson",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Eldred95@yahoo.com",
                Name = "Edna Bogan",
                Type = AtsEmailType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Amplus.",
        From = new PropertyAtsActivityFrom() {
            Email = "Norwood.Wiza47@yahoo.com",
            Name = "Toby Grant",
            Type = PropertyAtsActivityFromType.Other,
        },
        Id = "397e2d21-180b-4879-88cc-86e32fa70adb",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "48530d91-5661-4e38-b667-5a1d906ba973",
                Namespace = "activity",
                Slug = "acer",
                Value = AtsMetadataValue.CreateStr(
                    "Pauci eius cena adamo summisse arguo pectus communis arcesso tergeo."
                ),
            },
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "b4a47985-5b67-49b1-b5d1-c6c39c55e243",
                Namespace = "activity",
                Slug = "tremo",
                Value = AtsMetadataValue.CreateStr(
                    "Amita delectus dicta temptatio utroque ex."
                ),
            },
        },
        SubType = "TASK",
        Title = "Senior Interactions Manager",
        To = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sister91@hotmail.com",
                Name = "Eddie Nienow PhD",
                Type = AtsEmailType.Work,
            },
        },
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-03-07T10:15:31.482Z").ToUniversalTime(),
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

Update an application

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
        AppliedAt = System.DateTime.Parse("2025-09-09T00:14:07.189Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-04-15T10:51:39.815Z").ToUniversalTime(),
        Id = "06ca876c-e470-4357-94a9-fc5eaa5c9a13",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "a1302a79-0341-40e6-b91a-daeb95584617",
                Namespace = "application",
                Slug = "despecto",
                Value = AtsMetadataValue.CreateStr(
                    "Argentum decretum cultellus aveho distinctio verecundia stella depono."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-09-09T19:25:59.866Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Comburo quidem vesica vulnus curatio. Appositus amita attonbitus conatus degenero charisma sordeo villa victoria varius. Cenaculum acsi officia.",
        UpdatedAt = System.DateTime.Parse("2026-09-16T10:53:24.744Z").ToUniversalTime(),
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

Update a candidate

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
            Address1 = "802 Roberts Squares",
            Address2 = "Suite 550",
            City = "Lake Raeganside",
            CountryCode = "US",
            PostalCode = "44530-0054",
            Region = "Tennessee",
            RegionCode = "NV",
        },
        CompanyName = "Ferry, Legros and Feest",
        CreatedAt = System.DateTime.Parse("2023-10-16T05:42:56.049Z").ToUniversalTime(),
        Education = new List<AtsCandidateEducation>() {
            new AtsCandidateEducation() {
                Degree = "mouser throughout",
                EndAt = System.DateTime.Parse("1992-11-28T20:23:20.311Z").ToUniversalTime(),
                FieldOfStudy = "solutio",
                Institution = "Heller - Lubowitz",
                Level = "phd",
                StartAt = System.DateTime.Parse("2001-03-26T08:12:11.510Z").ToUniversalTime(),
            },
        },
        Emails = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Ardith.Beatty@hotmail.com",
                Name = "Opal Lindgren",
                Type = AtsEmailType.Work,
            },
            new AtsEmail() {
                Email = "Ardith_Beatty@gmail.com",
                Name = "Kristi Nader",
                Type = AtsEmailType.Other,
            },
        },
        Experiences = new List<AtsCandidateExperience>() {
            new AtsCandidateExperience() {
                CompanyName = "Donnelly, Buckridge and Steuber",
                EndAt = System.DateTime.Parse("1978-06-20T02:53:48.383Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1980-02-06T17:16:53.798Z").ToUniversalTime(),
                Title = "Principal Brand Strategist",
            },
        },
        FirstName = "Ardith",
        Id = "8c6674e7-f41c-46f8-923e-22754598aecb",
        ImageUrl = "https://loremflickr.com/40/3693?lock=5634712403880328",
        JobIds = new List<string>() {},
        LastName = "Beatty",
        LinkUrls = new List<string>() {
            "https://sizzling-legislature.com",
            "https://soupy-interchange.net",
            "https://troubled-substitution.info",
        },
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "866b1d12-e4f0-497b-9e2e-c7263d10be48",
                Namespace = "custom",
                Slug = "custom_field",
                Value = AtsMetadataValue.CreateStr(
                    "cariosus"
                ),
            },
        },
        Name = "Ardith Beatty",
        Origin = Origin.Sourced,
        Skills = new List<string>() {
            "vita",
            "cohors",
        },
        Sources = new List<string>() {
            "tactus",
        },
        Summary = "Denego barba rerum similique via templum totam suus voluptatem. Depraedor virgo cui comminor commodi curvo. Chirographum pax spero nostrum damnatio averto pecus cervus aspicio absens.",
        Tags = new List<string>() {
            "aliquid",
        },
        Telephones = new List<AtsTelephone>() {
            new AtsTelephone() {
                Telephone = "(779) 296-5994",
                Type = AtsTelephoneType.Home,
            },
        },
        Title = "Principal Implementation Analyst",
        UpdatedAt = System.DateTime.Parse("2024-04-23T01:20:19.054Z").ToUniversalTime(),
        WebUrl = "https://expert-lender.name/",
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
        Id = "1bb28a03-7d40-473d-9cb5-45380ff0d017",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-25T00:05:26.581Z").ToUniversalTime(),
        WebsiteUrl = "https://somber-substitution.com/",
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

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsDocument" method="patch" path="/ats/{connection_id}/document/{id}" example="ats_document" -->
```csharp
using System;
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
        Filename = "bah_white_frantically.bz",
        Id = "a9af2cb5-6181-4c92-8b53-53078962f209",
        Type = AtsDocumentType.Resume,
        UpdatedAt = System.DateTime.Parse("2022-11-29T04:07:49.311Z").ToUniversalTime(),
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

Update an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsInterview" method="patch" path="/ats/{connection_id}/interview/{id}" example="ats_interview" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsInterviewRequest req = new PatchAtsInterviewRequest() {
    AtsInterview = new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-09-24T03:12:45.650Z").ToUniversalTime(),
        ExternalEventXref = "948dae4e-d3a4-4510-ae54-7ba47c693a09",
        Id = "2deb3bc6-2684-458b-9913-29daf8d2b30b",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-05-19T23:37:23.895Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-04T21:20:55.166Z").ToUniversalTime(),
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

Update a job

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
        HiringManagers = new List<AtsReference>() {
            new AtsReference() {
                Id = "fd9852e3-9035-4f42-beb3-bbf4e4022122",
                Name = "Eloise Mueller PhD",
            },
        },
        Id = "fb3f5df0-08bd-485d-888e-bd162f757a99",
        Industry = "Gorgeous Plastic Computer",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "0463bfcf-8c69-4ab2-8afb-40244d5f7051",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "acceptus"
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
                OpenedAt = System.DateTime.Parse("2026-05-10T10:05:26.932Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "8460 Nils Trace",
                    City = "West Mervinburgh",
                    CountryCode = "US",
                    PostalCode = "14162",
                    Region = "Maine",
                    RegionCode = "MO",
                },
                CreatedAt = System.DateTime.Parse("2026-07-03T02:28:02.273Z").ToUniversalTime(),
                Description = "Deduco cultellus alii terebro depono thesaurus.",
                Id = "f6101769-deb3-4721-978c-d205638870ee",
                IsActive = false,
                Location = "6788 Oxford Road",
                Name = "Forward Security Orchestrator",
                PostingUrl = "https://ajar-metabolite.net/",
                UpdatedAt = System.DateTime.Parse("2026-07-28T17:19:00.478Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Trepide provident taceo rem.",
                Id = "289f27c0-311c-41e5-ad9d-cbe2097332c2",
                Options = new List<string>() {
                    "censura",
                    "tum",
                },
                Prompt = "Spectaculum mollitia arcus compello.",
                Question = "Sodalitas nemo natus attonbitus reprehenderit voro depono constans vehemens ante.",
                Required = true,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Id = "b3a0b53b-38f3-4e8d-84b9-f413a900d79b",
                Options = new List<string>() {
                    "odit",
                },
                Prompt = "Similique absque temeritas celebrer enim.",
                Question = "Vinitor sodalitas desino sollers viduo volo.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Abstergo possimus quibusdam deinde amoveo.",
                Id = "568be61d-060e-4d8c-a8ab-8a17cb25edf3",
                Options = new List<string>() {
                    "vallum",
                },
                Prompt = "Ara thermae aetas vivo constans victoria volo carbo vehemens praesentium.",
                Question = "Subiungo ambitus neque talis amitto terreo alienus quae vulticulus.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "amiculum",
            "crux",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Amicitia vergo hic.",
        UpdatedAt = System.DateTime.Parse("2026-02-01T13:33:49.416Z").ToUniversalTime(),
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

Update a scorecard

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
        Id = "9167335f-324c-494c-ba3d-6cc68c1c904e",
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
        UpdatedAt = System.DateTime.Parse("2023-05-27T17:44:04.990Z").ToUniversalTime(),
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

Remove an activity

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

Remove an application

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

Remove a candidate

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

Remove a company

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

Remove a document

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

Remove an interview

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

Remove a job

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

Remove a scorecard

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

Update an activity

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
        Bcc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Mabel_Schuppe-Schowalter42@hotmail.com",
                Name = "Rochelle Franey-Bechtelar",
                Type = AtsEmailType.Home,
            },
        },
        Cc = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sasha24@hotmail.com",
                Name = "Dr. Elbert Kuvalis",
                Type = AtsEmailType.Home,
            },
            new AtsEmail() {
                Email = "Rosetta_Donnelly@gmail.com",
                Name = "Ramon Daniel",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Kathryne_Jast@yahoo.com",
                Name = "Christian Jacobson",
                Type = AtsEmailType.Other,
            },
            new AtsEmail() {
                Email = "Eldred95@yahoo.com",
                Name = "Edna Bogan",
                Type = AtsEmailType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2022-08-07T03:16:43.865Z").ToUniversalTime(),
        Description = "Amplus.",
        From = new PropertyAtsActivityFrom() {
            Email = "Norwood.Wiza47@yahoo.com",
            Name = "Toby Grant",
            Type = PropertyAtsActivityFromType.Other,
        },
        Id = "397e2d21-180b-4879-88cc-86e32fa70adb",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "48530d91-5661-4e38-b667-5a1d906ba973",
                Namespace = "activity",
                Slug = "acer",
                Value = AtsMetadataValue.CreateStr(
                    "Pauci eius cena adamo summisse arguo pectus communis arcesso tergeo."
                ),
            },
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "b4a47985-5b67-49b1-b5d1-c6c39c55e243",
                Namespace = "activity",
                Slug = "tremo",
                Value = AtsMetadataValue.CreateStr(
                    "Amita delectus dicta temptatio utroque ex."
                ),
            },
        },
        SubType = "TASK",
        Title = "Senior Interactions Manager",
        To = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Sister91@hotmail.com",
                Name = "Eddie Nienow PhD",
                Type = AtsEmailType.Work,
            },
        },
        Type = AtsActivityType.Task,
        UpdatedAt = System.DateTime.Parse("2026-03-07T10:15:31.482Z").ToUniversalTime(),
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

Update an application

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
        AppliedAt = System.DateTime.Parse("2025-09-09T00:14:07.189Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-04-15T10:51:39.815Z").ToUniversalTime(),
        Id = "06ca876c-e470-4357-94a9-fc5eaa5c9a13",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "a1302a79-0341-40e6-b91a-daeb95584617",
                Namespace = "application",
                Slug = "despecto",
                Value = AtsMetadataValue.CreateStr(
                    "Argentum decretum cultellus aveho distinctio verecundia stella depono."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-09-09T19:25:59.866Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Comburo quidem vesica vulnus curatio. Appositus amita attonbitus conatus degenero charisma sordeo villa victoria varius. Cenaculum acsi officia.",
        UpdatedAt = System.DateTime.Parse("2026-09-16T10:53:24.744Z").ToUniversalTime(),
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

Update a candidate

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
            Address1 = "802 Roberts Squares",
            Address2 = "Suite 550",
            City = "Lake Raeganside",
            CountryCode = "US",
            PostalCode = "44530-0054",
            Region = "Tennessee",
            RegionCode = "NV",
        },
        CompanyName = "Ferry, Legros and Feest",
        CreatedAt = System.DateTime.Parse("2023-10-16T05:42:56.049Z").ToUniversalTime(),
        Education = new List<AtsCandidateEducation>() {
            new AtsCandidateEducation() {
                Degree = "mouser throughout",
                EndAt = System.DateTime.Parse("1992-11-28T20:23:20.311Z").ToUniversalTime(),
                FieldOfStudy = "solutio",
                Institution = "Heller - Lubowitz",
                Level = "phd",
                StartAt = System.DateTime.Parse("2001-03-26T08:12:11.510Z").ToUniversalTime(),
            },
        },
        Emails = new List<AtsEmail>() {
            new AtsEmail() {
                Email = "Ardith.Beatty@hotmail.com",
                Name = "Opal Lindgren",
                Type = AtsEmailType.Work,
            },
            new AtsEmail() {
                Email = "Ardith_Beatty@gmail.com",
                Name = "Kristi Nader",
                Type = AtsEmailType.Other,
            },
        },
        Experiences = new List<AtsCandidateExperience>() {
            new AtsCandidateExperience() {
                CompanyName = "Donnelly, Buckridge and Steuber",
                EndAt = System.DateTime.Parse("1978-06-20T02:53:48.383Z").ToUniversalTime(),
                StartAt = System.DateTime.Parse("1980-02-06T17:16:53.798Z").ToUniversalTime(),
                Title = "Principal Brand Strategist",
            },
        },
        FirstName = "Ardith",
        Id = "8c6674e7-f41c-46f8-923e-22754598aecb",
        ImageUrl = "https://loremflickr.com/40/3693?lock=5634712403880328",
        JobIds = new List<string>() {},
        LastName = "Beatty",
        LinkUrls = new List<string>() {
            "https://sizzling-legislature.com",
            "https://soupy-interchange.net",
            "https://troubled-substitution.info",
        },
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "866b1d12-e4f0-497b-9e2e-c7263d10be48",
                Namespace = "custom",
                Slug = "custom_field",
                Value = AtsMetadataValue.CreateStr(
                    "cariosus"
                ),
            },
        },
        Name = "Ardith Beatty",
        Origin = Origin.Sourced,
        Skills = new List<string>() {
            "vita",
            "cohors",
        },
        Sources = new List<string>() {
            "tactus",
        },
        Summary = "Denego barba rerum similique via templum totam suus voluptatem. Depraedor virgo cui comminor commodi curvo. Chirographum pax spero nostrum damnatio averto pecus cervus aspicio absens.",
        Tags = new List<string>() {
            "aliquid",
        },
        Telephones = new List<AtsTelephone>() {
            new AtsTelephone() {
                Telephone = "(779) 296-5994",
                Type = AtsTelephoneType.Home,
            },
        },
        Title = "Principal Implementation Analyst",
        UpdatedAt = System.DateTime.Parse("2024-04-23T01:20:19.054Z").ToUniversalTime(),
        WebUrl = "https://expert-lender.name/",
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
        Id = "1bb28a03-7d40-473d-9cb5-45380ff0d017",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-25T00:05:26.581Z").ToUniversalTime(),
        WebsiteUrl = "https://somber-substitution.com/",
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

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsDocument" method="put" path="/ats/{connection_id}/document/{id}" example="ats_document" -->
```csharp
using System;
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
        Filename = "bah_white_frantically.bz",
        Id = "a9af2cb5-6181-4c92-8b53-53078962f209",
        Type = AtsDocumentType.Resume,
        UpdatedAt = System.DateTime.Parse("2022-11-29T04:07:49.311Z").ToUniversalTime(),
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

Update an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsInterview" method="put" path="/ats/{connection_id}/interview/{id}" example="ats_interview" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsInterviewRequest req = new UpdateAtsInterviewRequest() {
    AtsInterview = new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-09-24T03:12:45.650Z").ToUniversalTime(),
        ExternalEventXref = "948dae4e-d3a4-4510-ae54-7ba47c693a09",
        Id = "2deb3bc6-2684-458b-9913-29daf8d2b30b",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-05-19T23:37:23.895Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-04T21:20:55.166Z").ToUniversalTime(),
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

Update a job

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
        HiringManagers = new List<AtsReference>() {
            new AtsReference() {
                Id = "fd9852e3-9035-4f42-beb3-bbf4e4022122",
                Name = "Eloise Mueller PhD",
            },
        },
        Id = "fb3f5df0-08bd-485d-888e-bd162f757a99",
        Industry = "Gorgeous Plastic Computer",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "0463bfcf-8c69-4ab2-8afb-40244d5f7051",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "acceptus"
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
                OpenedAt = System.DateTime.Parse("2026-05-10T10:05:26.932Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "8460 Nils Trace",
                    City = "West Mervinburgh",
                    CountryCode = "US",
                    PostalCode = "14162",
                    Region = "Maine",
                    RegionCode = "MO",
                },
                CreatedAt = System.DateTime.Parse("2026-07-03T02:28:02.273Z").ToUniversalTime(),
                Description = "Deduco cultellus alii terebro depono thesaurus.",
                Id = "f6101769-deb3-4721-978c-d205638870ee",
                IsActive = false,
                Location = "6788 Oxford Road",
                Name = "Forward Security Orchestrator",
                PostingUrl = "https://ajar-metabolite.net/",
                UpdatedAt = System.DateTime.Parse("2026-07-28T17:19:00.478Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Trepide provident taceo rem.",
                Id = "289f27c0-311c-41e5-ad9d-cbe2097332c2",
                Options = new List<string>() {
                    "censura",
                    "tum",
                },
                Prompt = "Spectaculum mollitia arcus compello.",
                Question = "Sodalitas nemo natus attonbitus reprehenderit voro depono constans vehemens ante.",
                Required = true,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Id = "b3a0b53b-38f3-4e8d-84b9-f413a900d79b",
                Options = new List<string>() {
                    "odit",
                },
                Prompt = "Similique absque temeritas celebrer enim.",
                Question = "Vinitor sodalitas desino sollers viduo volo.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Abstergo possimus quibusdam deinde amoveo.",
                Id = "568be61d-060e-4d8c-a8ab-8a17cb25edf3",
                Options = new List<string>() {
                    "vallum",
                },
                Prompt = "Ara thermae aetas vivo constans victoria volo carbo vehemens praesentium.",
                Question = "Subiungo ambitus neque talis amitto terreo alienus quae vulticulus.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "amiculum",
            "crux",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Amicitia vergo hic.",
        UpdatedAt = System.DateTime.Parse("2026-02-01T13:33:49.416Z").ToUniversalTime(),
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

Update a scorecard

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
        Id = "9167335f-324c-494c-ba3d-6cc68c1c904e",
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
        UpdatedAt = System.DateTime.Parse("2023-05-27T17:44:04.990Z").ToUniversalTime(),
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