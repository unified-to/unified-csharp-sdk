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
        Id = "a977827b-b121-44aa-b5fb-03d6e92712df",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "7de2060b-8067-42d9-ba3e-401db0c4a770",
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
                Id = "00b15a32-2f6a-45ac-94fb-7a5ca45725dd",
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
        UpdatedAt = System.DateTime.Parse("2026-03-29T22:34:14.655Z").ToUniversalTime(),
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
        AppliedAt = System.DateTime.Parse("2025-09-25T19:11:11.993Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-07T12:52:55.827Z").ToUniversalTime(),
        Id = "2d553764-468a-4345-bbcf-4f7e346e4069",
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
        RejectedAt = System.DateTime.Parse("2026-10-05T11:10:23.468Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Comburo quidem vesica vulnus curatio. Appositus amita attonbitus conatus degenero charisma sordeo villa victoria varius. Cenaculum acsi officia.",
        UpdatedAt = System.DateTime.Parse("2026-10-12T06:29:41.938Z").ToUniversalTime(),
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
        Id = "913c941d-1d53-482c-8d5d-3b84a386c30f",
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
                Id = "7fc99af0-70a3-4043-9e9b-e074e612adc5",
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
        UpdatedAt = System.DateTime.Parse("2024-04-27T15:38:48.107Z").ToUniversalTime(),
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
        Id = "f98d0840-70db-47cf-a7a4-f30b332ec971",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-29T23:49:34.951Z").ToUniversalTime(),
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
        Id = "3098c63d-413c-410b-88ab-817a920da81d",
        Type = AtsDocumentType.Resume,
        UpdatedAt = System.DateTime.Parse("2022-12-05T16:02:36.637Z").ToUniversalTime(),
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
        EndAt = System.DateTime.Parse("2025-10-14T17:00:06.672Z").ToUniversalTime(),
        ExternalEventXref = "651bb3c9-9d97-4dfb-9ee9-8fa8ba3f12a3",
        Id = "5316e013-4cd0-4759-8ff8-1fd06244af0d",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-07T16:26:14.818Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:26:58.393Z").ToUniversalTime(),
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
                Id = "eb3bbf4e-4022-4122-9d44-39fd5b501e80",
                Name = "Troy Greenholt",
            },
        },
        Id = "12706923-0855-49ed-b537-680dc937d0a2",
        Industry = "Modern Granite Gloves",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "15c4acef-f0b9-4af7-98de-7ffc075a6da2",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "vomica"
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
                OpenedAt = System.DateTime.Parse("2026-06-02T10:31:40.937Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "51372 Kshlerin Creek",
                    City = "Logancester",
                    CountryCode = "US",
                    PostalCode = "85013-9865",
                    Region = "Vermont",
                    RegionCode = "MO",
                },
                CreatedAt = System.DateTime.Parse("2026-07-27T06:54:41.313Z").ToUniversalTime(),
                Description = "Provident turbo cunabula spoliatio agnitio.",
                Id = "372178cd-2056-4388-870e-e7c199761c7c",
                IsActive = false,
                Location = "2925 Connie Green",
                Name = "Lead Intranet Developer",
                PostingUrl = "https://smart-summer.name/",
                UpdatedAt = System.DateTime.Parse("2026-08-22T11:07:36.061Z").ToUniversalTime(),
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
                MaxLength = 387D,
                MinLength = 1D,
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
                Id = "3a0b53b3-8f3e-48d4-ab9f-413a900d79b0",
                MaxLength = 430D,
                MinLength = 1D,
                Options = new List<string>() {
                    "aetas",
                },
                Prompt = "Contra damno desolo suadeo utrimque cresco.",
                Question = "Sodalitas desino sollers viduo volo cresco ventus tui sufficio iusto.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Ara thermae aetas vivo constans victoria volo carbo vehemens praesentium.",
                Id = "060ed8c8-ab8a-417c-8b25-edf38cb19b1c",
                MaxLength = 381D,
                MinLength = 1D,
                Options = new List<string>() {
                    "utroque",
                },
                Prompt = "Vir crepusculum ait adeptio ait defendo cotidie porro uterque.",
                Question = "Vulticulus depono abstergo possimus quibusdam deinde amoveo.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "coaegresco",
            "appello",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Iste sto communis.",
        UpdatedAt = System.DateTime.Parse("2026-02-22T10:56:53.721Z").ToUniversalTime(),
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
        Id = "8bd3bed6-93d9-4d27-b925-610a49e68d64",
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
        UpdatedAt = System.DateTime.Parse("2023-06-03T21:03:35.144Z").ToUniversalTime(),
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

## GetAtsApplicationstatus

Retrieve an applicationstatus

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
        Id = "108ea3ca-903d-4c05-aeb0-6b0b0ae25996",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "c4c7bdae-7cd4-489b-b7e5-5caca3ef8d08",
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
                Id = "b388f661-e2ea-4b96-b496-5af06fccbd04",
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
        UpdatedAt = System.DateTime.Parse("2026-03-29T22:34:14.678Z").ToUniversalTime(),
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
        AppliedAt = System.DateTime.Parse("2025-09-25T19:11:12.013Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-07T12:52:55.853Z").ToUniversalTime(),
        Id = "961b1f14-5381-4a08-9f04-97cbf09195ce",
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
        RejectedAt = System.DateTime.Parse("2026-10-05T11:10:23.498Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Comburo quidem vesica vulnus curatio. Appositus amita attonbitus conatus degenero charisma sordeo villa victoria varius. Cenaculum acsi officia.",
        UpdatedAt = System.DateTime.Parse("2026-10-12T06:29:41.969Z").ToUniversalTime(),
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
        Id = "13fc82a0-a8df-4aea-8fc8-4c68c6bafd4e",
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
                Id = "317df2a1-8c07-4fea-bb5c-967f33ad5948",
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
        UpdatedAt = System.DateTime.Parse("2024-04-27T15:38:48.116Z").ToUniversalTime(),
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
        Id = "0c9c23f5-38b1-4365-91f0-a1fadf8b29ad",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-29T23:49:34.957Z").ToUniversalTime(),
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
        Id = "86076b14-4599-47c3-8e32-6d668c2dc6da",
        Type = AtsDocumentType.Resume,
        UpdatedAt = System.DateTime.Parse("2022-12-05T16:02:36.640Z").ToUniversalTime(),
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
        EndAt = System.DateTime.Parse("2025-10-14T17:00:06.677Z").ToUniversalTime(),
        ExternalEventXref = "9776cf6b-4fd5-468a-8e94-dd4dc3bf15fc",
        Id = "ebd2b690-a375-42b3-82be-f774eb289869",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-07T16:26:14.823Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:26:58.399Z").ToUniversalTime(),
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
                Id = "eb3bbf4e-4022-4122-9d44-39fd5b501e80",
                Name = "Troy Greenholt",
            },
        },
        Id = "6b1bb87c-e766-4df2-b6b5-826bc918566b",
        Industry = "Modern Granite Gloves",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "9ded9721-ed68-4f68-8577-2fe807971141",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "vomica"
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
                OpenedAt = System.DateTime.Parse("2026-06-02T10:31:40.994Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "51372 Kshlerin Creek",
                    City = "Logancester",
                    CountryCode = "US",
                    PostalCode = "85013-9865",
                    Region = "Vermont",
                    RegionCode = "MO",
                },
                CreatedAt = System.DateTime.Parse("2026-07-27T06:54:41.374Z").ToUniversalTime(),
                Description = "Provident turbo cunabula spoliatio agnitio.",
                Id = "372178cd-2056-4388-870e-e7c199761c7c",
                IsActive = false,
                Location = "2925 Connie Green",
                Name = "Lead Intranet Developer",
                PostingUrl = "https://smart-summer.name/",
                UpdatedAt = System.DateTime.Parse("2026-08-22T11:07:36.123Z").ToUniversalTime(),
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
                MaxLength = 387D,
                MinLength = 1D,
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
                Id = "3a0b53b3-8f3e-48d4-ab9f-413a900d79b0",
                MaxLength = 430D,
                MinLength = 1D,
                Options = new List<string>() {
                    "aetas",
                },
                Prompt = "Contra damno desolo suadeo utrimque cresco.",
                Question = "Sodalitas desino sollers viduo volo cresco ventus tui sufficio iusto.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Ara thermae aetas vivo constans victoria volo carbo vehemens praesentium.",
                Id = "060ed8c8-ab8a-417c-8b25-edf38cb19b1c",
                MaxLength = 381D,
                MinLength = 1D,
                Options = new List<string>() {
                    "utroque",
                },
                Prompt = "Vir crepusculum ait adeptio ait defendo cotidie porro uterque.",
                Question = "Vulticulus depono abstergo possimus quibusdam deinde amoveo.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "coaegresco",
            "appello",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Iste sto communis.",
        UpdatedAt = System.DateTime.Parse("2026-02-22T10:56:53.773Z").ToUniversalTime(),
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
        Id = "1346d275-25a0-4a0b-82bb-3b1e0e19201f",
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
        UpdatedAt = System.DateTime.Parse("2023-06-03T21:03:35.147Z").ToUniversalTime(),
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
        Id = "108ea3ca-903d-4c05-aeb0-6b0b0ae25996",
        IsPrivate = false,
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "c4c7bdae-7cd4-489b-b7e5-5caca3ef8d08",
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
                Id = "b388f661-e2ea-4b96-b496-5af06fccbd04",
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
        UpdatedAt = System.DateTime.Parse("2026-03-29T22:34:14.678Z").ToUniversalTime(),
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
        AppliedAt = System.DateTime.Parse("2025-09-25T19:11:12.013Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-07T12:52:55.853Z").ToUniversalTime(),
        Id = "961b1f14-5381-4a08-9f04-97cbf09195ce",
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
        RejectedAt = System.DateTime.Parse("2026-10-05T11:10:23.498Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Comburo quidem vesica vulnus curatio. Appositus amita attonbitus conatus degenero charisma sordeo villa victoria varius. Cenaculum acsi officia.",
        UpdatedAt = System.DateTime.Parse("2026-10-12T06:29:41.969Z").ToUniversalTime(),
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
        Id = "13fc82a0-a8df-4aea-8fc8-4c68c6bafd4e",
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
                Id = "317df2a1-8c07-4fea-bb5c-967f33ad5948",
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
        UpdatedAt = System.DateTime.Parse("2024-04-27T15:38:48.116Z").ToUniversalTime(),
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
        Id = "0c9c23f5-38b1-4365-91f0-a1fadf8b29ad",
        Name = "Gulgowski, Dibbert and Wilderman",
        Phone = "1-602-210-4548",
        UpdatedAt = System.DateTime.Parse("2020-09-29T23:49:34.957Z").ToUniversalTime(),
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
        Id = "86076b14-4599-47c3-8e32-6d668c2dc6da",
        Type = AtsDocumentType.Resume,
        UpdatedAt = System.DateTime.Parse("2022-12-05T16:02:36.640Z").ToUniversalTime(),
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
        EndAt = System.DateTime.Parse("2025-10-14T17:00:06.677Z").ToUniversalTime(),
        ExternalEventXref = "9776cf6b-4fd5-468a-8e94-dd4dc3bf15fc",
        Id = "ebd2b690-a375-42b3-82be-f774eb289869",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-07T16:26:14.823Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:26:58.399Z").ToUniversalTime(),
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
                Id = "eb3bbf4e-4022-4122-9d44-39fd5b501e80",
                Name = "Troy Greenholt",
            },
        },
        Id = "6b1bb87c-e766-4df2-b6b5-826bc918566b",
        Industry = "Modern Granite Gloves",
        LanguageLocale = "en",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "9ded9721-ed68-4f68-8577-2fe807971141",
                Namespace = "custom",
                Slug = "custom_property",
                Value = AtsMetadataValue.CreateStr(
                    "vomica"
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
                OpenedAt = System.DateTime.Parse("2026-06-02T10:31:40.994Z").ToUniversalTime(),
                Status = AtsJobOpeningStatus.Open,
            },
        },
        Postings = new List<AtsJobPosting>() {
            new AtsJobPosting() {
                Address = new PropertyAtsJobPostingAddress() {
                    Address1 = "51372 Kshlerin Creek",
                    City = "Logancester",
                    CountryCode = "US",
                    PostalCode = "85013-9865",
                    Region = "Vermont",
                    RegionCode = "MO",
                },
                CreatedAt = System.DateTime.Parse("2026-07-27T06:54:41.374Z").ToUniversalTime(),
                Description = "Provident turbo cunabula spoliatio agnitio.",
                Id = "372178cd-2056-4388-870e-e7c199761c7c",
                IsActive = false,
                Location = "2925 Connie Green",
                Name = "Lead Intranet Developer",
                PostingUrl = "https://smart-summer.name/",
                UpdatedAt = System.DateTime.Parse("2026-08-22T11:07:36.123Z").ToUniversalTime(),
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
                MaxLength = 387D,
                MinLength = 1D,
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
                Id = "3a0b53b3-8f3e-48d4-ab9f-413a900d79b0",
                MaxLength = 430D,
                MinLength = 1D,
                Options = new List<string>() {
                    "aetas",
                },
                Prompt = "Contra damno desolo suadeo utrimque cresco.",
                Question = "Sodalitas desino sollers viduo volo cresco ventus tui sufficio iusto.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
            new AtsJobQuestion() {
                Description = "Ara thermae aetas vivo constans victoria volo carbo vehemens praesentium.",
                Id = "060ed8c8-ab8a-417c-8b25-edf38cb19b1c",
                MaxLength = 381D,
                MinLength = 1D,
                Options = new List<string>() {
                    "utroque",
                },
                Prompt = "Vir crepusculum ait adeptio ait defendo cotidie porro uterque.",
                Question = "Vulticulus depono abstergo possimus quibusdam deinde amoveo.",
                Required = false,
                Type = AtsJobQuestionType.Text,
            },
        },
        Skills = new List<string>() {
            "coaegresco",
            "appello",
        },
        Status = AtsJobStatus.Archived,
        Summary = "Iste sto communis.",
        UpdatedAt = System.DateTime.Parse("2026-02-22T10:56:53.773Z").ToUniversalTime(),
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
        Id = "1346d275-25a0-4a0b-82bb-3b1e0e19201f",
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
        UpdatedAt = System.DateTime.Parse("2023-06-03T21:03:35.147Z").ToUniversalTime(),
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