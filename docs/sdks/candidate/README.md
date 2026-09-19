# Candidate

## Overview

### Available Operations

* [CreateAtsCandidate](#createatscandidate) - Create a candidate
* [GetAtsCandidate](#getatscandidate) - Retrieve a candidate
* [ListAtsCandidates](#listatscandidates) - List all candidates
* [PatchAtsCandidate](#patchatscandidate) - Update a candidate
* [RemoveAtsCandidate](#removeatscandidate) - Remove a candidate
* [UpdateAtsCandidate](#updateatscandidate) - Update a candidate

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

var res = await sdk.Candidate.CreateAtsCandidateAsync(
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

var res = await sdk.Candidate.GetAtsCandidateAsync(
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

var res = await sdk.Candidate.ListAtsCandidatesAsync(req);

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

var res = await sdk.Candidate.PatchAtsCandidateAsync(req);

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

var res = await sdk.Candidate.RemoveAtsCandidateAsync(
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

var res = await sdk.Candidate.UpdateAtsCandidateAsync(req);

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