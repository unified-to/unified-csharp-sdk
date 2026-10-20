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
        Id = "b58b17a4-1a99-42f2-9ea5-528098e41dc3",
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
                Id = "d2926d67-77d0-473c-93f9-39e182d7238a",
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
        UpdatedAt = System.DateTime.Parse("2024-04-28T12:38:17.192Z").ToUniversalTime(),
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
        Id = "6a571ea4-9d85-4e5f-a098-f42daf453801",
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
                Id = "aa2c1921-9889-4c1d-8d8b-9fb9b467e32d",
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
        UpdatedAt = System.DateTime.Parse("2024-04-28T12:38:17.202Z").ToUniversalTime(),
        WebUrl = "https://fragrant-husband.net/",
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
        Id = "6a571ea4-9d85-4e5f-a098-f42daf453801",
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
                Id = "aa2c1921-9889-4c1d-8d8b-9fb9b467e32d",
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
        UpdatedAt = System.DateTime.Parse("2024-04-28T12:38:17.202Z").ToUniversalTime(),
        WebUrl = "https://fragrant-husband.net/",
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