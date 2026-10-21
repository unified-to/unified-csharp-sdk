# Job

## Overview

### Available Operations

* [CreateAtsJob](#createatsjob) - Create a job
* [CreateHrisJob](#createhrisjob) - Create a job
* [GetAtsJob](#getatsjob) - Retrieve a job
* [GetHrisJob](#gethrisjob) - Retrieve a job
* [ListAtsJobs](#listatsjobs) - List all jobs
* [ListHrisJobs](#listhrisjobs) - List all jobs
* [PatchAtsJob](#patchatsjob) - Update a job
* [PatchHrisJob](#patchhrisjob) - Update a job
* [RemoveAtsJob](#removeatsjob) - Remove a job
* [RemoveHrisJob](#removehrisjob) - Remove a job
* [UpdateAtsJob](#updateatsjob) - Update a job
* [UpdateHrisJob](#updatehrisjob) - Update a job

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
        HiringManagers = new List<AtsReference>() {},
        Id = "7d5507c4-9cd4-4da1-a6be-36327afcaf93",
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
                Id = "f98bfe1a-7776-49f4-b6c9-be9936ad7936",
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
                OpenedAt = System.DateTime.Parse("2026-06-07T21:42:43.441Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-08-02T00:44:46.147Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "7ad7e889-0e0c-446b-bbb2-f95c3311c0d3",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-28T08:08:06.849Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "deb78b33-474c-4454-a21b-377f33beb75e",
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
                Id = "5847fb89-c2e7-416c-9145-4032c16775f5",
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
                Id = "4492b258-d53a-4f07-a0ce-6c99cb70981f",
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
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:00:32.763Z").ToUniversalTime(),
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

## CreateHrisJob

Create a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisJob" method="post" path="/hris/{connection_id}/job" example="hris_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Job.CreateHrisJobAsync(
    hrisJob: new HrisJob() {
        Code = "P-05547",
        CreatedAt = System.DateTime.Parse("2020-10-28T01:13:19.491Z").ToUniversalTime(),
        Description = "Alienus timor depromo bonus vobis creator tabella callide cavus triumphus caveo.",
        EmploymentType = HrisJobEmploymentType.Freelance,
        Id = "caa7bb67-8e85-4ec3-9795-cc42af2c21c6",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-30T05:24:52.108Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisJob`                                                                                                                                        | [HrisJob](../../Models/Components/HrisJob.md)                                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisJobQueryParamFields](../../Models/Requests/CreateHrisJobQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisJobResponse](../../Models/Requests/CreateHrisJobResponse.md)**

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

## GetHrisJob

Retrieve a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisJob" method="get" path="/hris/{connection_id}/job/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Job.GetHrisJobAsync(
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
| `Fields`                                                                                                                                         | List<[GetHrisJobQueryParamFields](../../Models/Requests/GetHrisJobQueryParamFields.md)>                                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisJobResponse](../../Models/Requests/GetHrisJobResponse.md)**

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

## ListHrisJobs

List all jobs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisJobs" method="get" path="/hris/{connection_id}/job" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisJobsRequest req = new ListHrisJobsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Job.ListHrisJobsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListHrisJobsRequest](../../Models/Requests/ListHrisJobsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListHrisJobsResponse](../../Models/Requests/ListHrisJobsResponse.md)**

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
        HiringManagers = new List<AtsReference>() {},
        Id = "6eeaab25-327e-4de2-8235-66e5cc2f076c",
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
                Id = "38255357-d7f9-4850-a69a-439b8511c5e3",
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
                OpenedAt = System.DateTime.Parse("2026-06-07T21:42:43.478Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-08-02T00:44:46.186Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "079379ff-1a12-48ce-b29a-9b93f6400e6e",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-28T08:08:06.889Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "0f6b8cdf-a2be-45f5-906c-d2469d8d5493",
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
                Id = "dc06afd1-71bd-4286-8140-f358a0b71982",
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
                Id = "136b91f4-21df-44e8-9ecd-79ff7be1950d",
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
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:00:32.797Z").ToUniversalTime(),
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

## PatchHrisJob

Update a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisJob" method="patch" path="/hris/{connection_id}/job/{id}" example="hris_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisJobRequest req = new PatchHrisJobRequest() {
    HrisJob = new HrisJob() {
        Code = "P-05547",
        CreatedAt = System.DateTime.Parse("2020-10-28T01:13:19.491Z").ToUniversalTime(),
        Description = "Alienus timor depromo bonus vobis creator tabella callide cavus triumphus caveo.",
        EmploymentType = HrisJobEmploymentType.Freelance,
        Id = "cc9b894a-a561-420c-974c-85c030f2340c",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-30T05:24:52.146Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Job.PatchHrisJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [PatchHrisJobRequest](../../Models/Requests/PatchHrisJobRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[PatchHrisJobResponse](../../Models/Requests/PatchHrisJobResponse.md)**

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

## RemoveHrisJob

Remove a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisJob" method="delete" path="/hris/{connection_id}/job/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Job.RemoveHrisJobAsync(
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

**[RemoveHrisJobResponse](../../Models/Requests/RemoveHrisJobResponse.md)**

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
        HiringManagers = new List<AtsReference>() {},
        Id = "6eeaab25-327e-4de2-8235-66e5cc2f076c",
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
                Id = "38255357-d7f9-4850-a69a-439b8511c5e3",
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
                OpenedAt = System.DateTime.Parse("2026-06-07T21:42:43.478Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-08-02T00:44:46.186Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "079379ff-1a12-48ce-b29a-9b93f6400e6e",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-28T08:08:06.889Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "0f6b8cdf-a2be-45f5-906c-d2469d8d5493",
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
                Id = "dc06afd1-71bd-4286-8140-f358a0b71982",
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
                Id = "136b91f4-21df-44e8-9ecd-79ff7be1950d",
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
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:00:32.797Z").ToUniversalTime(),
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

## UpdateHrisJob

Update a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisJob" method="put" path="/hris/{connection_id}/job/{id}" example="hris_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisJobRequest req = new UpdateHrisJobRequest() {
    HrisJob = new HrisJob() {
        Code = "P-05547",
        CreatedAt = System.DateTime.Parse("2020-10-28T01:13:19.491Z").ToUniversalTime(),
        Description = "Alienus timor depromo bonus vobis creator tabella callide cavus triumphus caveo.",
        EmploymentType = HrisJobEmploymentType.Freelance,
        Id = "cc9b894a-a561-420c-974c-85c030f2340c",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-30T05:24:52.146Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Job.UpdateHrisJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateHrisJobRequest](../../Models/Requests/UpdateHrisJobRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateHrisJobResponse](../../Models/Requests/UpdateHrisJobResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |