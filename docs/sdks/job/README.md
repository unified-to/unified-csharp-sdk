# Job

## Overview

### Available Operations

* [CreateAtsJob](#createatsjob) - Create a job
* [GetAtsJob](#getatsjob) - Retrieve a job
* [ListAtsJobs](#listatsjobs) - List all jobs
* [PatchAtsJob](#patchatsjob) - Update a job
* [RemoveAtsJob](#removeatsjob) - Remove a job
* [UpdateAtsJob](#updateatsjob) - Update a job

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

var res = await sdk.Job.CreateAtsJobAsync(
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
        Id = "66ab0110-f43b-4a2e-ac77-00ee9ed7d453",
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
                Id = "fe031341-9e80-483c-9552-147da99d959e",
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
                OpenedAt = System.DateTime.Parse("2026-05-09T12:56:29.780Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-07-02T04:14:45.189Z").ToUniversalTime(),
                Description = "Deduco cultellus alii terebro depono thesaurus.",
                Id = "f6101769-deb3-4721-978c-d205638870ee",
                IsActive = false,
                Location = "6788 Oxford Road",
                Name = "Forward Security Orchestrator",
                PostingUrl = "https://ajar-metabolite.net/",
                UpdatedAt = System.DateTime.Parse("2026-07-27T18:35:01.326Z").ToUniversalTime(),
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
        UpdatedAt = System.DateTime.Parse("2026-01-31T18:22:08.370Z").ToUniversalTime(),
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

var res = await sdk.Job.GetAtsJobAsync(
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

var res = await sdk.Job.ListAtsJobsAsync(req);

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
        Id = "5cfa40e8-1d71-4a46-bae3-5176a66056a5",
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
                Id = "60b94c73-9f9e-4396-a602-910042160eed",
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
                OpenedAt = System.DateTime.Parse("2026-05-09T12:56:29.822Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-07-02T04:14:45.234Z").ToUniversalTime(),
                Description = "Deduco cultellus alii terebro depono thesaurus.",
                Id = "f6101769-deb3-4721-978c-d205638870ee",
                IsActive = false,
                Location = "6788 Oxford Road",
                Name = "Forward Security Orchestrator",
                PostingUrl = "https://ajar-metabolite.net/",
                UpdatedAt = System.DateTime.Parse("2026-07-27T18:35:01.372Z").ToUniversalTime(),
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
        UpdatedAt = System.DateTime.Parse("2026-01-31T18:22:08.408Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Job.PatchAtsJobAsync(req);

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

var res = await sdk.Job.RemoveAtsJobAsync(
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
        Id = "5cfa40e8-1d71-4a46-bae3-5176a66056a5",
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
                Id = "60b94c73-9f9e-4396-a602-910042160eed",
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
                OpenedAt = System.DateTime.Parse("2026-05-09T12:56:29.822Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-07-02T04:14:45.234Z").ToUniversalTime(),
                Description = "Deduco cultellus alii terebro depono thesaurus.",
                Id = "f6101769-deb3-4721-978c-d205638870ee",
                IsActive = false,
                Location = "6788 Oxford Road",
                Name = "Forward Security Orchestrator",
                PostingUrl = "https://ajar-metabolite.net/",
                UpdatedAt = System.DateTime.Parse("2026-07-27T18:35:01.372Z").ToUniversalTime(),
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
        UpdatedAt = System.DateTime.Parse("2026-01-31T18:22:08.408Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Job.UpdateAtsJobAsync(req);

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