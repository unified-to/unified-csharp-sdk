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
        Id = "c66d6057-e2df-4e2b-9af5-3201d98a3fa3",
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
                Id = "0daf5fbf-d851-4221-827f-5b5b595d74bc",
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
                OpenedAt = System.DateTime.Parse("2026-06-10T10:19:18.006Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-08-04T16:25:42.540Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "66665971-3586-4c20-bd38-66fe7c33032b",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-31T01:17:02.257Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "15b09602-36b8-423f-b19e-e841c71ba59a",
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
                Id = "4da974d0-43a3-406f-9049-49a322fd19ee",
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
                Id = "0e2cbd14-93d6-4884-9128-35a6d2d40593",
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
        UpdatedAt = System.DateTime.Parse("2026-03-01T17:01:03.190Z").ToUniversalTime(),
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

Creates a HrisJob. Provide the unified HrisJob fields in the request body; they are mapped to the provider's API. Returns the created HrisJob.

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
        Id = "cdead5a0-15bf-42c9-952a-f9d8ca0ac570",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-31T07:07:44.196Z").ToUniversalTime(),
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

Retrieves a single AtsJob by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single HrisJob by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of HrisJobs. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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
        Id = "a8f16c7a-20df-4f0b-bf1f-3145fdb2293c",
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
                Id = "eaf1ffa5-90ce-4621-9f6d-81e4f25a11da",
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
                OpenedAt = System.DateTime.Parse("2026-06-10T10:19:18.073Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-08-04T16:25:42.610Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "c4defcd5-dab4-4301-b942-065546c2e5b6",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-31T01:17:02.328Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "bdf07387-706b-48de-a2d9-ea81a93c1553",
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
                Id = "a4245f0c-f416-49d6-a198-0ddf7d20cfaa",
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
                Id = "53fbca16-e6be-4c10-9ce6-ed1e1ac9581f",
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
        UpdatedAt = System.DateTime.Parse("2026-03-01T17:01:03.251Z").ToUniversalTime(),
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

Updates the HrisJob identified by `id`. Provide the unified HrisJob fields to change in the request body.

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
        Id = "cbece947-6487-49ba-a108-09156bb7c463",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-31T07:07:44.241Z").ToUniversalTime(),
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

Deletes the AtsJob identified by `id`.

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

Deletes the HrisJob identified by `id`.

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
        Id = "a8f16c7a-20df-4f0b-bf1f-3145fdb2293c",
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
                Id = "eaf1ffa5-90ce-4621-9f6d-81e4f25a11da",
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
                OpenedAt = System.DateTime.Parse("2026-06-10T10:19:18.073Z").ToUniversalTime(),
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
                CreatedAt = System.DateTime.Parse("2026-08-04T16:25:42.610Z").ToUniversalTime(),
                Description = "Beatus eum volutabrum balbus victus ipsa tubineus claustrum.",
                Id = "c4defcd5-dab4-4301-b942-065546c2e5b6",
                IsActive = false,
                Location = "1725 Hessel Keys",
                Name = "International Identity Manager",
                PostingUrl = "https://obedient-yak.com",
                UpdatedAt = System.DateTime.Parse("2026-08-31T01:17:02.328Z").ToUniversalTime(),
            },
        },
        PublicJobUrls = new List<string>() {
            "https://trustworthy-elver.info",
            "https://parched-dash.info",
        },
        Questions = new List<AtsJobQuestion>() {
            new AtsJobQuestion() {
                Description = "Auctus deporto tolero administratio capitulus animi agnosco tendo aetas vado.",
                Id = "bdf07387-706b-48de-a2d9-ea81a93c1553",
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
                Id = "a4245f0c-f416-49d6-a198-0ddf7d20cfaa",
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
                Id = "53fbca16-e6be-4c10-9ce6-ed1e1ac9581f",
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
        UpdatedAt = System.DateTime.Parse("2026-03-01T17:01:03.251Z").ToUniversalTime(),
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

Updates the HrisJob identified by `id`. Provide the unified HrisJob fields to change in the request body.

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
        Id = "cbece947-6487-49ba-a108-09156bb7c463",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-31T07:07:44.241Z").ToUniversalTime(),
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