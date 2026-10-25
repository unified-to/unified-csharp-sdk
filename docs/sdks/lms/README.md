# Lms

## Overview

### Available Operations

* [CreateLmsActivity](#createlmsactivity) - Create an activity
* [CreateLmsClass](#createlmsclass) - Create a class
* [CreateLmsCollection](#createlmscollection) - Create a collection
* [CreateLmsContent](#createlmscontent) - Create a content
* [CreateLmsCourse](#createlmscourse) - Create a course
* [CreateLmsInstructor](#createlmsinstructor) - Create an instructor
* [CreateLmsStudent](#createlmsstudent) - Create a student
* [GetLmsActivity](#getlmsactivity) - Retrieve an activity
* [GetLmsClass](#getlmsclass) - Retrieve a class
* [GetLmsCollection](#getlmscollection) - Retrieve a collection
* [GetLmsContent](#getlmscontent) - Retrieve a content
* [GetLmsCourse](#getlmscourse) - Retrieve a course
* [GetLmsInstructor](#getlmsinstructor) - Retrieve an instructor
* [GetLmsStudent](#getlmsstudent) - Retrieve a student
* [ListLmsActivities](#listlmsactivities) - List all activities
* [ListLmsClasses](#listlmsclasses) - List all classes
* [ListLmsCollections](#listlmscollections) - List all collections
* [ListLmsContents](#listlmscontents) - List all contents
* [ListLmsCourses](#listlmscourses) - List all courses
* [ListLmsInstructors](#listlmsinstructors) - List all instructors
* [ListLmsStudents](#listlmsstudents) - List all students
* [PatchLmsActivity](#patchlmsactivity) - Update an activity
* [PatchLmsClass](#patchlmsclass) - Update a class
* [PatchLmsCollection](#patchlmscollection) - Update a collection
* [PatchLmsContent](#patchlmscontent) - Update a content
* [PatchLmsCourse](#patchlmscourse) - Update a course
* [PatchLmsInstructor](#patchlmsinstructor) - Update an instructor
* [PatchLmsStudent](#patchlmsstudent) - Update a student
* [RemoveLmsActivity](#removelmsactivity) - Remove an activity
* [RemoveLmsClass](#removelmsclass) - Remove a class
* [RemoveLmsCollection](#removelmscollection) - Remove a collection
* [RemoveLmsContent](#removelmscontent) - Remove a content
* [RemoveLmsCourse](#removelmscourse) - Remove a course
* [RemoveLmsInstructor](#removelmsinstructor) - Remove an instructor
* [RemoveLmsStudent](#removelmsstudent) - Remove a student
* [UpdateLmsActivity](#updatelmsactivity) - Update an activity
* [UpdateLmsClass](#updatelmsclass) - Update a class
* [UpdateLmsCollection](#updatelmscollection) - Update a collection
* [UpdateLmsContent](#updatelmscontent) - Update a content
* [UpdateLmsCourse](#updatelmscourse) - Update a course
* [UpdateLmsInstructor](#updatelmsinstructor) - Update an instructor
* [UpdateLmsStudent](#updatelmsstudent) - Update a student

## CreateLmsActivity

Creates a LmsActivity. Provide the unified LmsActivity fields in the request body; they are mapped to the provider's API. Returns the created LmsActivity.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsActivity" method="post" path="/lms/{connection_id}/activity" example="lms_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsActivityAsync(
    lmsActivity: new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2023-12-08T01:29:35.088Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "748268dd-c721-4f46-8243-3fc6df2b9037",
        IsCompleted = true,
        Metadata = new List<LmsMetadata>() {},
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2021-04-25T12:39:52.602Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-31T20:10:44.518Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsActivity`                                                                                                                                    | [LmsActivity](../../Models/Components/LmsActivity.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsActivityQueryParamFields](../../Models/Requests/CreateLmsActivityQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsActivityResponse](../../Models/Requests/CreateLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsClass

Creates a LmsClass. Provide the unified LmsClass fields in the request body; they are mapped to the provider's API. Returns the created LmsClass.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsClass" method="post" path="/lms/{connection_id}/class" example="lms_class" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsClassAsync(
    lmsClass: new LmsClass() {
        CreatedAt = System.DateTime.Parse("2020-02-20T14:48:51.845Z").ToUniversalTime(),
        Description = "Anser sperno decerno.",
        Id = "509301cc-ce37-42ff-8129-5779db077025",
        Instructors = new List<LmsReference>() {},
        Languages = new List<string>() {
            "in",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Defetiscor aetas acies benevolentia ulterius. Creta bis beneficium canis. Bonus valeo vulgo creator arca peior ceno earum culpa. Tabesco apostolus talis. Ultra accommodo deinde sono culpo arto cruciamentum triduana.",
                Description = "Esse confido.",
                Languages = new List<string>() {
                    "fa",
                    "da",
                },
                Name = "illo",
                ThumbnailUrl = "https://loremflickr.com/199/1934?lock=4323325966476891",
                Type = LmsMediaType.Video,
                Url = "https://loremflickr.com/487/921?lock=5127962071241632",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "virtus",
        Students = new List<LmsReference>() {},
        UpdatedAt = System.DateTime.Parse("2025-08-07T03:37:47.917Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsClass`                                                                                                                                       | [LmsClass](../../Models/Components/LmsClass.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsClassQueryParamFields](../../Models/Requests/CreateLmsClassQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsClassResponse](../../Models/Requests/CreateLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsCollection

Creates a LmsCollection. Provide the unified LmsCollection fields in the request body; they are mapped to the provider's API. Returns the created LmsCollection.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsCollection" method="post" path="/lms/{connection_id}/collection" example="lms_collection" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsCollectionAsync(
    lmsCollection: new LmsCollection() {
        CreatedAt = System.DateTime.Parse("2019-08-19T14:40:29.227Z").ToUniversalTime(),
        Description = "Ab.",
        Id = "dc9e71e5-db4d-4781-9cd6-a96771a2fc4f",
        IsActive = true,
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Accusamus earum sulum libero adficio testimonium vitae. Calcar contra vergo curis sollers. Caste brevis denuo. Tam amita ducimus capillus. Vulgaris temporibus arbustum solium id. Suppono commodo fuga surculus tripudio doloribus.",
                Description = "Aliquam tardus careo hic umbra.",
                Languages = new List<string>() {
                    "gl",
                },
                Name = "thymum",
                ThumbnailUrl = "https://picsum.photos/seed/15O5EfV/2982/752",
                Type = LmsMediaType.Headshot,
                Url = "https://loremflickr.com/2679/70?lock=6078357625960554",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "ara",
        UpdatedAt = System.DateTime.Parse("2026-08-03T03:34:04.458Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsCollection`                                                                                                                                  | [LmsCollection](../../Models/Components/LmsCollection.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsCollectionQueryParamFields](../../Models/Requests/CreateLmsCollectionQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsCollectionResponse](../../Models/Requests/CreateLmsCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsContent

Creates a LmsContent. Provide the unified LmsContent fields in the request body; they are mapped to the provider's API. Returns the created LmsContent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsContent" method="post" path="/lms/{connection_id}/content" example="lms_content" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsContentAsync(
    lmsContent: new LmsContent() {
        Categories = new List<string>() {
            "territo",
        },
        CreatedAt = System.DateTime.Parse("2020-10-22T22:30:50.963Z").ToUniversalTime(),
        Description = "Usque laboriosam ventosus adflicto.",
        Difficulty = "Beginner",
        DurationMinutes = 19D,
        Id = "f7dc65d9-63d4-440b-af40-6017a20985d9",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        Languages = new List<string>() {
            "despecto",
            "suppellex",
        },
        Localizations = new List<LmsContentLocalization>() {
            new LmsContentLocalization() {
                Description = "Acervus.",
                Language = "es",
                Name = "talis",
            },
            new LmsContentLocalization() {
                Description = "Ratione.",
                Language = "es",
                Name = "sint",
            },
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adnuo antepono vulticulus incidunt. Commemoro voro ocer arca velut vigor venustas una audeo. Consectetur totidem amor amo vigor. Patior ulciscor cohors necessitatibus beatae. Copiose cedo sub decens acer.",
                Description = "Venia aeternus tandem spargo.",
                Languages = new List<string>() {
                    "zu",
                    "ba",
                },
                Name = "subiungo",
                ThumbnailUrl = "https://loremflickr.com/2056/3712?lock=5644845642923518",
                Type = LmsMediaType.Other,
                Url = "https://loremflickr.com/2593/1553?lock=8591263400111785",
            },
            new LmsMedia() {
                Content = "Terminatio acidus tripudio teres. Compono demum aut aestivus ambitus pecus tergum verumtamen vestrum. Absque adversus desino aut tabernus tollo vigor. Cur agnitio totidem consuasor bene doloribus. Vetus abundans curriculum curatio usitas.",
                Description = "Comedo valde caste combibo.",
                Languages = new List<string>() {
                    "it",
                    "hu",
                },
                Name = "beneficium",
                ThumbnailUrl = "https://picsum.photos/seed/pNFr1/2597/885",
                Type = LmsMediaType.Web,
                Url = "https://loremflickr.com/3597/239?lock=7142808124990633",
            },
            new LmsMedia() {
                Content = "Coepi demo adversus capillus aro unus templum. Aspicio alius vehemens terminatio varietas vomica. Apud thorax defero decet impedit verbera pauci laboriosam molestiae urbanus. Aveho vergo crux certus nulla caute sophismata. Caute voluptatibus patrocinor demo verumtamen adeo canis sapiente depraedor verus.",
                Description = "Tunc barba decens.",
                Languages = new List<string>() {
                    "bn",
                    "yo",
                },
                Name = "qui",
                ThumbnailUrl = "https://loremflickr.com/1375/3377?lock=6601832177607674",
                Type = LmsMediaType.Image,
                Url = "https://loremflickr.com/3927/2086?lock=5199784913821481",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "ut",
        ProviderName = "Bins LLC",
        PublishedAt = System.DateTime.Parse("2022-09-04T11:59:22.656Z").ToUniversalTime(),
        ShortDescription = "Caritas.",
        Skills = new List<string>() {
            "trucido",
        },
        SortOrder = 3D,
        Subjects = new List<LmsSubject>() {
            new LmsSubject() {
                Name = "tibi",
                Rank = 1D,
            },
        },
        Tags = new List<string>() {
            "dens",
        },
        UpdatedAt = System.DateTime.Parse("2022-10-05T11:36:39.163Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsContent`                                                                                                                                     | [LmsContent](../../Models/Components/LmsContent.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsContentQueryParamFields](../../Models/Requests/CreateLmsContentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsContentResponse](../../Models/Requests/CreateLmsContentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsCourse

Creates a LmsCourse. Provide the unified LmsCourse fields in the request body; they are mapped to the provider's API. Returns the created LmsCourse.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsCourse" method="post" path="/lms/{connection_id}/course" example="lms_course" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsCourseAsync(
    lmsCourse: new LmsCourse() {
        Categories = new List<string>() {
            "tergiversatio",
            "tumultus",
        },
        CreatedAt = System.DateTime.Parse("2022-10-06T09:58:53.559Z").ToUniversalTime(),
        Currency = "FJD",
        Description = "Vinco alias aut capitulus.",
        DurationMinutes = 148D,
        Id = "14647a58-4301-45de-9a7b-eca5ffd9e05c",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        IsPrivate = false,
        Languages = new List<string>() {
            "desparatus",
            "earum",
            "deripio",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adeptio crudelis ipsum utrimque quae architecto. Cum eius conitor anser abutor error adsuesco abeo. Denego nihil caries aveho.",
                Description = "Adipiscor.",
                Languages = new List<string>() {
                    "ms",
                    "te",
                },
                Name = "tandem",
                ThumbnailUrl = "https://picsum.photos/seed/syTatRhK03/928/273",
                Type = LmsMediaType.Other,
                Url = "https://picsum.photos/seed/fQAbsk/2472/1671",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2022-11-05T20:08:55.636Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-10T02:30:47.137Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsCourse`                                                                                                                                      | [LmsCourse](../../Models/Components/LmsCourse.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsCourseQueryParamFields](../../Models/Requests/CreateLmsCourseQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsCourseResponse](../../Models/Requests/CreateLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsInstructor

Creates a LmsInstructor. Provide the unified LmsInstructor fields in the request body; they are mapped to the provider's API. Returns the created LmsInstructor.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsInstructor" method="post" path="/lms/{connection_id}/instructor" example="lms_instructor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsInstructorAsync(
    lmsInstructor: new LmsInstructor() {
        CreatedAt = System.DateTime.Parse("2021-10-12T16:38:54.979Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Deangelo",
        Id = "7104f247-7d91-4b3f-b1d6-67b2d26ff409",
        ImageUrl = "https://avatars.githubusercontent.com/u/95131132",
        LastName = "Ritchie",
        Metadata = new List<LmsMetadata>() {},
        Name = "Deangelo Ritchie",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(605) 752-8163",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(430) 415-2451",
                Type = LmsTelephoneType.Home,
            },
        },
        Title = "Regional Security Agent",
        UpdatedAt = System.DateTime.Parse("2025-07-27T10:13:00.195Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsInstructor`                                                                                                                                  | [LmsInstructor](../../Models/Components/LmsInstructor.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsInstructorQueryParamFields](../../Models/Requests/CreateLmsInstructorQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsInstructorResponse](../../Models/Requests/CreateLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLmsStudent

Creates a LmsStudent. Provide the unified LmsStudent fields in the request body; they are mapped to the provider's API. Returns the created LmsStudent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsStudent" method="post" path="/lms/{connection_id}/student" example="lms_student" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.CreateLmsStudentAsync(
    lmsStudent: new LmsStudent() {
        Address = new PropertyLmsStudentAddress() {
            Address1 = "15033 Corwin Circles",
            City = "New Craigside",
            CountryCode = "US",
            PostalCode = "73966",
            Region = "New Jersey",
            RegionCode = "TX",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "b92c31f3-40b9-4929-af41-1070df0ba3d6",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/male/512/56.jpg",
        LastName = "Murazik",
        Metadata = new List<LmsMetadata>() {},
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(899) 827-6400",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(487) 213-8236",
                Type = LmsTelephoneType.Fax,
            },
            new LmsTelephone() {
                Telephone = "(980) 775-2940",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-07-02T08:25:27.159Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsStudent`                                                                                                                                     | [LmsStudent](../../Models/Components/LmsStudent.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsStudentQueryParamFields](../../Models/Requests/CreateLmsStudentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsStudentResponse](../../Models/Requests/CreateLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsActivity

Retrieves a single LmsActivity by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsActivity" method="get" path="/lms/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsActivityAsync(
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
| `Fields`                                                                                                                                         | List<[GetLmsActivityQueryParamFields](../../Models/Requests/GetLmsActivityQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsActivityResponse](../../Models/Requests/GetLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsClass

Retrieves a single LmsClass by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsClass" method="get" path="/lms/{connection_id}/class/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsClassAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Class                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetLmsClassQueryParamFields](../../Models/Requests/GetLmsClassQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsClassResponse](../../Models/Requests/GetLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsCollection

Retrieves a single LmsCollection by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsCollection" method="get" path="/lms/{connection_id}/collection/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsCollectionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Collection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetLmsCollectionQueryParamFields](../../Models/Requests/GetLmsCollectionQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsCollectionResponse](../../Models/Requests/GetLmsCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsContent

Retrieves a single LmsContent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsContent" method="get" path="/lms/{connection_id}/content/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsContentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Content                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetLmsContentQueryParamFields](../../Models/Requests/GetLmsContentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsContentResponse](../../Models/Requests/GetLmsContentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsCourse

Retrieves a single LmsCourse by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsCourse" method="get" path="/lms/{connection_id}/course/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsCourseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Course                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetLmsCourseQueryParamFields](../../Models/Requests/GetLmsCourseQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsCourseResponse](../../Models/Requests/GetLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsInstructor

Retrieves a single LmsInstructor by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsInstructor" method="get" path="/lms/{connection_id}/instructor/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsInstructorAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Instructor                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetLmsInstructorQueryParamFields](../../Models/Requests/GetLmsInstructorQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsInstructorResponse](../../Models/Requests/GetLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsStudent

Retrieves a single LmsStudent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsStudent" method="get" path="/lms/{connection_id}/student/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.GetLmsStudentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Student                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetLmsStudentQueryParamFields](../../Models/Requests/GetLmsStudentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsStudentResponse](../../Models/Requests/GetLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsActivities

Returns a list of LmsActivities. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsActivities" method="get" path="/lms/{connection_id}/activity" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsActivitiesRequest req = new ListLmsActivitiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsActivitiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListLmsActivitiesRequest](../../Models/Requests/ListLmsActivitiesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListLmsActivitiesResponse](../../Models/Requests/ListLmsActivitiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsClasses

Returns a list of LmsClasses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsClasses" method="get" path="/lms/{connection_id}/class" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsClassesRequest req = new ListLmsClassesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsClassesAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListLmsClassesRequest](../../Models/Requests/ListLmsClassesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListLmsClassesResponse](../../Models/Requests/ListLmsClassesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsCollections

Returns a list of LmsCollections. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsCollections" method="get" path="/lms/{connection_id}/collection" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsCollectionsRequest req = new ListLmsCollectionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsCollectionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListLmsCollectionsRequest](../../Models/Requests/ListLmsCollectionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListLmsCollectionsResponse](../../Models/Requests/ListLmsCollectionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsContents

Returns a list of LmsContents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsContents" method="get" path="/lms/{connection_id}/content" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsContentsRequest req = new ListLmsContentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsContentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListLmsContentsRequest](../../Models/Requests/ListLmsContentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListLmsContentsResponse](../../Models/Requests/ListLmsContentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsCourses

Returns a list of LmsCourses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsCourses" method="get" path="/lms/{connection_id}/course" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsCoursesRequest req = new ListLmsCoursesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsCoursesAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListLmsCoursesRequest](../../Models/Requests/ListLmsCoursesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListLmsCoursesResponse](../../Models/Requests/ListLmsCoursesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsInstructors

Returns a list of LmsInstructors. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsInstructors" method="get" path="/lms/{connection_id}/instructor" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsInstructorsRequest req = new ListLmsInstructorsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsInstructorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListLmsInstructorsRequest](../../Models/Requests/ListLmsInstructorsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListLmsInstructorsResponse](../../Models/Requests/ListLmsInstructorsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsStudents

Returns a list of LmsStudents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsStudents" method="get" path="/lms/{connection_id}/student" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsStudentsRequest req = new ListLmsStudentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Lms.ListLmsStudentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListLmsStudentsRequest](../../Models/Requests/ListLmsStudentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListLmsStudentsResponse](../../Models/Requests/ListLmsStudentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsActivity

Updates the LmsActivity identified by `id`. Provide the unified LmsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsActivity" method="patch" path="/lms/{connection_id}/activity/{id}" example="lms_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsActivityRequest req = new PatchLmsActivityRequest() {
    LmsActivity = new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2023-12-08T01:29:35.094Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "94de8da3-e3d6-4eb4-8f0a-ad57b79f0838",
        IsCompleted = true,
        Metadata = new List<LmsMetadata>() {},
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2021-04-25T12:39:52.603Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-31T20:10:44.521Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchLmsActivityRequest](../../Models/Requests/PatchLmsActivityRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchLmsActivityResponse](../../Models/Requests/PatchLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsClass

Updates the LmsClass identified by `id`. Provide the unified LmsClass fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsClass" method="patch" path="/lms/{connection_id}/class/{id}" example="lms_class" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsClassRequest req = new PatchLmsClassRequest() {
    LmsClass = new LmsClass() {
        CreatedAt = System.DateTime.Parse("2020-02-20T14:48:51.845Z").ToUniversalTime(),
        Description = "Anser sperno decerno.",
        Id = "85569cfd-648c-46ac-a5ca-f02321d6e508",
        Instructors = new List<LmsReference>() {},
        Languages = new List<string>() {
            "in",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Defetiscor aetas acies benevolentia ulterius. Creta bis beneficium canis. Bonus valeo vulgo creator arca peior ceno earum culpa. Tabesco apostolus talis. Ultra accommodo deinde sono culpo arto cruciamentum triduana.",
                Description = "Esse confido.",
                Languages = new List<string>() {
                    "fa",
                    "da",
                },
                Name = "illo",
                ThumbnailUrl = "https://loremflickr.com/199/1934?lock=4323325966476891",
                Type = LmsMediaType.Video,
                Url = "https://loremflickr.com/487/921?lock=5127962071241632",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "virtus",
        Students = new List<LmsReference>() {},
        UpdatedAt = System.DateTime.Parse("2025-08-07T03:37:47.930Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsClassAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchLmsClassRequest](../../Models/Requests/PatchLmsClassRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchLmsClassResponse](../../Models/Requests/PatchLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsCollection

Updates the LmsCollection identified by `id`. Provide the unified LmsCollection fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsCollection" method="patch" path="/lms/{connection_id}/collection/{id}" example="lms_collection" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsCollectionRequest req = new PatchLmsCollectionRequest() {
    LmsCollection = new LmsCollection() {
        CreatedAt = System.DateTime.Parse("2019-08-19T14:40:29.227Z").ToUniversalTime(),
        Description = "Ab.",
        Id = "169514ed-e9b7-4e05-bc0b-171ec1f9bd56",
        IsActive = true,
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Accusamus earum sulum libero adficio testimonium vitae. Calcar contra vergo curis sollers. Caste brevis denuo. Tam amita ducimus capillus. Vulgaris temporibus arbustum solium id. Suppono commodo fuga surculus tripudio doloribus.",
                Description = "Aliquam tardus careo hic umbra.",
                Languages = new List<string>() {
                    "gl",
                },
                Name = "thymum",
                ThumbnailUrl = "https://picsum.photos/seed/15O5EfV/2982/752",
                Type = LmsMediaType.Headshot,
                Url = "https://loremflickr.com/2679/70?lock=6078357625960554",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "ara",
        UpdatedAt = System.DateTime.Parse("2026-08-03T03:34:04.471Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsCollectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchLmsCollectionRequest](../../Models/Requests/PatchLmsCollectionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchLmsCollectionResponse](../../Models/Requests/PatchLmsCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsContent

Updates the LmsContent identified by `id`. Provide the unified LmsContent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsContent" method="patch" path="/lms/{connection_id}/content/{id}" example="lms_content" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsContentRequest req = new PatchLmsContentRequest() {
    LmsContent = new LmsContent() {
        Categories = new List<string>() {
            "territo",
        },
        CreatedAt = System.DateTime.Parse("2020-10-22T22:30:50.963Z").ToUniversalTime(),
        Description = "Usque laboriosam ventosus adflicto.",
        Difficulty = "Beginner",
        DurationMinutes = 19D,
        Id = "8653591e-e93a-4ba7-bb18-fad2ce986b54",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        Languages = new List<string>() {
            "despecto",
            "suppellex",
        },
        Localizations = new List<LmsContentLocalization>() {
            new LmsContentLocalization() {
                Description = "Acervus.",
                Language = "es",
                Name = "talis",
            },
            new LmsContentLocalization() {
                Description = "Ratione.",
                Language = "es",
                Name = "sint",
            },
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adnuo antepono vulticulus incidunt. Commemoro voro ocer arca velut vigor venustas una audeo. Consectetur totidem amor amo vigor. Patior ulciscor cohors necessitatibus beatae. Copiose cedo sub decens acer.",
                Description = "Venia aeternus tandem spargo.",
                Languages = new List<string>() {
                    "zu",
                    "ba",
                },
                Name = "subiungo",
                ThumbnailUrl = "https://loremflickr.com/2056/3712?lock=5644845642923518",
                Type = LmsMediaType.Other,
                Url = "https://loremflickr.com/2593/1553?lock=8591263400111785",
            },
            new LmsMedia() {
                Content = "Terminatio acidus tripudio teres. Compono demum aut aestivus ambitus pecus tergum verumtamen vestrum. Absque adversus desino aut tabernus tollo vigor. Cur agnitio totidem consuasor bene doloribus. Vetus abundans curriculum curatio usitas.",
                Description = "Comedo valde caste combibo.",
                Languages = new List<string>() {
                    "it",
                    "hu",
                },
                Name = "beneficium",
                ThumbnailUrl = "https://picsum.photos/seed/pNFr1/2597/885",
                Type = LmsMediaType.Web,
                Url = "https://loremflickr.com/3597/239?lock=7142808124990633",
            },
            new LmsMedia() {
                Content = "Coepi demo adversus capillus aro unus templum. Aspicio alius vehemens terminatio varietas vomica. Apud thorax defero decet impedit verbera pauci laboriosam molestiae urbanus. Aveho vergo crux certus nulla caute sophismata. Caute voluptatibus patrocinor demo verumtamen adeo canis sapiente depraedor verus.",
                Description = "Tunc barba decens.",
                Languages = new List<string>() {
                    "bn",
                    "yo",
                },
                Name = "qui",
                ThumbnailUrl = "https://loremflickr.com/1375/3377?lock=6601832177607674",
                Type = LmsMediaType.Image,
                Url = "https://loremflickr.com/3927/2086?lock=5199784913821481",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "ut",
        ProviderName = "Bins LLC",
        PublishedAt = System.DateTime.Parse("2022-09-04T11:59:22.663Z").ToUniversalTime(),
        ShortDescription = "Caritas.",
        Skills = new List<string>() {
            "trucido",
        },
        SortOrder = 3D,
        Subjects = new List<LmsSubject>() {
            new LmsSubject() {
                Name = "tibi",
                Rank = 1D,
            },
        },
        Tags = new List<string>() {
            "dens",
        },
        UpdatedAt = System.DateTime.Parse("2022-10-05T11:36:39.169Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsContentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchLmsContentRequest](../../Models/Requests/PatchLmsContentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchLmsContentResponse](../../Models/Requests/PatchLmsContentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsCourse

Updates the LmsCourse identified by `id`. Provide the unified LmsCourse fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsCourse" method="patch" path="/lms/{connection_id}/course/{id}" example="lms_course" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsCourseRequest req = new PatchLmsCourseRequest() {
    LmsCourse = new LmsCourse() {
        Categories = new List<string>() {
            "tergiversatio",
            "tumultus",
        },
        CreatedAt = System.DateTime.Parse("2022-10-06T09:58:53.559Z").ToUniversalTime(),
        Currency = "FJD",
        Description = "Vinco alias aut capitulus.",
        DurationMinutes = 148D,
        Id = "51d5c9e1-3598-4dd7-b371-541f17e7f6f3",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        IsPrivate = false,
        Languages = new List<string>() {
            "desparatus",
            "earum",
            "deripio",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adeptio crudelis ipsum utrimque quae architecto. Cum eius conitor anser abutor error adsuesco abeo. Denego nihil caries aveho.",
                Description = "Adipiscor.",
                Languages = new List<string>() {
                    "ms",
                    "te",
                },
                Name = "tandem",
                ThumbnailUrl = "https://picsum.photos/seed/syTatRhK03/928/273",
                Type = LmsMediaType.Other,
                Url = "https://picsum.photos/seed/fQAbsk/2472/1671",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2022-11-05T20:08:55.636Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-10T02:30:47.139Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsCourseAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchLmsCourseRequest](../../Models/Requests/PatchLmsCourseRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchLmsCourseResponse](../../Models/Requests/PatchLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsInstructor

Updates the LmsInstructor identified by `id`. Provide the unified LmsInstructor fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsInstructor" method="patch" path="/lms/{connection_id}/instructor/{id}" example="lms_instructor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsInstructorRequest req = new PatchLmsInstructorRequest() {
    LmsInstructor = new LmsInstructor() {
        CreatedAt = System.DateTime.Parse("2021-10-12T16:38:54.979Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Deangelo",
        Id = "9e1fd562-1ada-41bc-a045-d0b07490298b",
        ImageUrl = "https://avatars.githubusercontent.com/u/95131132",
        LastName = "Ritchie",
        Metadata = new List<LmsMetadata>() {},
        Name = "Deangelo Ritchie",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(605) 752-8163",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(430) 415-2451",
                Type = LmsTelephoneType.Home,
            },
        },
        Title = "Regional Security Agent",
        UpdatedAt = System.DateTime.Parse("2025-07-27T10:13:00.202Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsInstructorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchLmsInstructorRequest](../../Models/Requests/PatchLmsInstructorRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchLmsInstructorResponse](../../Models/Requests/PatchLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsStudent

Updates the LmsStudent identified by `id`. Provide the unified LmsStudent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsStudent" method="patch" path="/lms/{connection_id}/student/{id}" example="lms_student" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsStudentRequest req = new PatchLmsStudentRequest() {
    LmsStudent = new LmsStudent() {
        Address = new PropertyLmsStudentAddress() {
            Address1 = "15033 Corwin Circles",
            City = "New Craigside",
            CountryCode = "US",
            PostalCode = "73966",
            Region = "New Jersey",
            RegionCode = "TX",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "629a8199-5564-42fb-ae24-3bc366749764",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/male/512/56.jpg",
        LastName = "Murazik",
        Metadata = new List<LmsMetadata>() {},
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(899) 827-6400",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(487) 213-8236",
                Type = LmsTelephoneType.Fax,
            },
            new LmsTelephone() {
                Telephone = "(980) 775-2940",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-07-02T08:25:27.167Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.PatchLmsStudentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchLmsStudentRequest](../../Models/Requests/PatchLmsStudentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchLmsStudentResponse](../../Models/Requests/PatchLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsActivity

Deletes the LmsActivity identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsActivity" method="delete" path="/lms/{connection_id}/activity/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsActivityAsync(
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

**[RemoveLmsActivityResponse](../../Models/Requests/RemoveLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsClass

Deletes the LmsClass identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsClass" method="delete" path="/lms/{connection_id}/class/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsClassAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Class      |

### Response

**[RemoveLmsClassResponse](../../Models/Requests/RemoveLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsCollection

Deletes the LmsCollection identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsCollection" method="delete" path="/lms/{connection_id}/collection/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsCollectionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Collection |

### Response

**[RemoveLmsCollectionResponse](../../Models/Requests/RemoveLmsCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsContent

Deletes the LmsContent identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsContent" method="delete" path="/lms/{connection_id}/content/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsContentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Content    |

### Response

**[RemoveLmsContentResponse](../../Models/Requests/RemoveLmsContentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsCourse

Deletes the LmsCourse identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsCourse" method="delete" path="/lms/{connection_id}/course/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsCourseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Course     |

### Response

**[RemoveLmsCourseResponse](../../Models/Requests/RemoveLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsInstructor

Deletes the LmsInstructor identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsInstructor" method="delete" path="/lms/{connection_id}/instructor/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsInstructorAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Instructor |

### Response

**[RemoveLmsInstructorResponse](../../Models/Requests/RemoveLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsStudent

Deletes the LmsStudent identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsStudent" method="delete" path="/lms/{connection_id}/student/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Lms.RemoveLmsStudentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Student    |

### Response

**[RemoveLmsStudentResponse](../../Models/Requests/RemoveLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsActivity

Updates the LmsActivity identified by `id`. Provide the unified LmsActivity fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsActivity" method="put" path="/lms/{connection_id}/activity/{id}" example="lms_activity" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsActivityRequest req = new UpdateLmsActivityRequest() {
    LmsActivity = new LmsActivity() {
        AssignedGrade = "summopere",
        CompletedAt = System.DateTime.Parse("2023-12-08T01:29:35.094Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-17T01:25:21.745Z").ToUniversalTime(),
        DurationMinutes = 55D,
        Id = "94de8da3-e3d6-4eb4-8f0a-ad57b79f0838",
        IsCompleted = true,
        Metadata = new List<LmsMetadata>() {},
        ProgressPercentage = 100D,
        StartedAt = System.DateTime.Parse("2021-04-25T12:39:52.603Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2022-01-31T20:10:44.521Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateLmsActivityRequest](../../Models/Requests/UpdateLmsActivityRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateLmsActivityResponse](../../Models/Requests/UpdateLmsActivityResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsClass

Updates the LmsClass identified by `id`. Provide the unified LmsClass fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsClass" method="put" path="/lms/{connection_id}/class/{id}" example="lms_class" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsClassRequest req = new UpdateLmsClassRequest() {
    LmsClass = new LmsClass() {
        CreatedAt = System.DateTime.Parse("2020-02-20T14:48:51.845Z").ToUniversalTime(),
        Description = "Anser sperno decerno.",
        Id = "85569cfd-648c-46ac-a5ca-f02321d6e508",
        Instructors = new List<LmsReference>() {},
        Languages = new List<string>() {
            "in",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Defetiscor aetas acies benevolentia ulterius. Creta bis beneficium canis. Bonus valeo vulgo creator arca peior ceno earum culpa. Tabesco apostolus talis. Ultra accommodo deinde sono culpo arto cruciamentum triduana.",
                Description = "Esse confido.",
                Languages = new List<string>() {
                    "fa",
                    "da",
                },
                Name = "illo",
                ThumbnailUrl = "https://loremflickr.com/199/1934?lock=4323325966476891",
                Type = LmsMediaType.Video,
                Url = "https://loremflickr.com/487/921?lock=5127962071241632",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "virtus",
        Students = new List<LmsReference>() {},
        UpdatedAt = System.DateTime.Parse("2025-08-07T03:37:47.930Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsClassAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateLmsClassRequest](../../Models/Requests/UpdateLmsClassRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateLmsClassResponse](../../Models/Requests/UpdateLmsClassResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsCollection

Updates the LmsCollection identified by `id`. Provide the unified LmsCollection fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsCollection" method="put" path="/lms/{connection_id}/collection/{id}" example="lms_collection" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsCollectionRequest req = new UpdateLmsCollectionRequest() {
    LmsCollection = new LmsCollection() {
        CreatedAt = System.DateTime.Parse("2019-08-19T14:40:29.227Z").ToUniversalTime(),
        Description = "Ab.",
        Id = "169514ed-e9b7-4e05-bc0b-171ec1f9bd56",
        IsActive = true,
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Accusamus earum sulum libero adficio testimonium vitae. Calcar contra vergo curis sollers. Caste brevis denuo. Tam amita ducimus capillus. Vulgaris temporibus arbustum solium id. Suppono commodo fuga surculus tripudio doloribus.",
                Description = "Aliquam tardus careo hic umbra.",
                Languages = new List<string>() {
                    "gl",
                },
                Name = "thymum",
                ThumbnailUrl = "https://picsum.photos/seed/15O5EfV/2982/752",
                Type = LmsMediaType.Headshot,
                Url = "https://loremflickr.com/2679/70?lock=6078357625960554",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "ara",
        UpdatedAt = System.DateTime.Parse("2026-08-03T03:34:04.471Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsCollectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateLmsCollectionRequest](../../Models/Requests/UpdateLmsCollectionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateLmsCollectionResponse](../../Models/Requests/UpdateLmsCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsContent

Updates the LmsContent identified by `id`. Provide the unified LmsContent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsContent" method="put" path="/lms/{connection_id}/content/{id}" example="lms_content" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsContentRequest req = new UpdateLmsContentRequest() {
    LmsContent = new LmsContent() {
        Categories = new List<string>() {
            "territo",
        },
        CreatedAt = System.DateTime.Parse("2020-10-22T22:30:50.963Z").ToUniversalTime(),
        Description = "Usque laboriosam ventosus adflicto.",
        Difficulty = "Beginner",
        DurationMinutes = 19D,
        Id = "8653591e-e93a-4ba7-bb18-fad2ce986b54",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        Languages = new List<string>() {
            "despecto",
            "suppellex",
        },
        Localizations = new List<LmsContentLocalization>() {
            new LmsContentLocalization() {
                Description = "Acervus.",
                Language = "es",
                Name = "talis",
            },
            new LmsContentLocalization() {
                Description = "Ratione.",
                Language = "es",
                Name = "sint",
            },
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adnuo antepono vulticulus incidunt. Commemoro voro ocer arca velut vigor venustas una audeo. Consectetur totidem amor amo vigor. Patior ulciscor cohors necessitatibus beatae. Copiose cedo sub decens acer.",
                Description = "Venia aeternus tandem spargo.",
                Languages = new List<string>() {
                    "zu",
                    "ba",
                },
                Name = "subiungo",
                ThumbnailUrl = "https://loremflickr.com/2056/3712?lock=5644845642923518",
                Type = LmsMediaType.Other,
                Url = "https://loremflickr.com/2593/1553?lock=8591263400111785",
            },
            new LmsMedia() {
                Content = "Terminatio acidus tripudio teres. Compono demum aut aestivus ambitus pecus tergum verumtamen vestrum. Absque adversus desino aut tabernus tollo vigor. Cur agnitio totidem consuasor bene doloribus. Vetus abundans curriculum curatio usitas.",
                Description = "Comedo valde caste combibo.",
                Languages = new List<string>() {
                    "it",
                    "hu",
                },
                Name = "beneficium",
                ThumbnailUrl = "https://picsum.photos/seed/pNFr1/2597/885",
                Type = LmsMediaType.Web,
                Url = "https://loremflickr.com/3597/239?lock=7142808124990633",
            },
            new LmsMedia() {
                Content = "Coepi demo adversus capillus aro unus templum. Aspicio alius vehemens terminatio varietas vomica. Apud thorax defero decet impedit verbera pauci laboriosam molestiae urbanus. Aveho vergo crux certus nulla caute sophismata. Caute voluptatibus patrocinor demo verumtamen adeo canis sapiente depraedor verus.",
                Description = "Tunc barba decens.",
                Languages = new List<string>() {
                    "bn",
                    "yo",
                },
                Name = "qui",
                ThumbnailUrl = "https://loremflickr.com/1375/3377?lock=6601832177607674",
                Type = LmsMediaType.Image,
                Url = "https://loremflickr.com/3927/2086?lock=5199784913821481",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "ut",
        ProviderName = "Bins LLC",
        PublishedAt = System.DateTime.Parse("2022-09-04T11:59:22.663Z").ToUniversalTime(),
        ShortDescription = "Caritas.",
        Skills = new List<string>() {
            "trucido",
        },
        SortOrder = 3D,
        Subjects = new List<LmsSubject>() {
            new LmsSubject() {
                Name = "tibi",
                Rank = 1D,
            },
        },
        Tags = new List<string>() {
            "dens",
        },
        UpdatedAt = System.DateTime.Parse("2022-10-05T11:36:39.169Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsContentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateLmsContentRequest](../../Models/Requests/UpdateLmsContentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateLmsContentResponse](../../Models/Requests/UpdateLmsContentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsCourse

Updates the LmsCourse identified by `id`. Provide the unified LmsCourse fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsCourse" method="put" path="/lms/{connection_id}/course/{id}" example="lms_course" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsCourseRequest req = new UpdateLmsCourseRequest() {
    LmsCourse = new LmsCourse() {
        Categories = new List<string>() {
            "tergiversatio",
            "tumultus",
        },
        CreatedAt = System.DateTime.Parse("2022-10-06T09:58:53.559Z").ToUniversalTime(),
        Currency = "FJD",
        Description = "Vinco alias aut capitulus.",
        DurationMinutes = 148D,
        Id = "51d5c9e1-3598-4dd7-b371-541f17e7f6f3",
        Instructors = new List<LmsReference>() {},
        IsActive = true,
        IsPrivate = false,
        Languages = new List<string>() {
            "desparatus",
            "earum",
            "deripio",
        },
        Media = new List<LmsMedia>() {
            new LmsMedia() {
                Content = "Adeptio crudelis ipsum utrimque quae architecto. Cum eius conitor anser abutor error adsuesco abeo. Denego nihil caries aveho.",
                Description = "Adipiscor.",
                Languages = new List<string>() {
                    "ms",
                    "te",
                },
                Name = "tandem",
                ThumbnailUrl = "https://picsum.photos/seed/syTatRhK03/928/273",
                Type = LmsMediaType.Other,
                Url = "https://picsum.photos/seed/fQAbsk/2472/1671",
            },
        },
        Metadata = new List<LmsMetadata>() {},
        Name = "comptus",
        PriceAmount = 84D,
        ProviderName = "Homenick - Wunsch",
        PublishedAt = System.DateTime.Parse("2022-11-05T20:08:55.636Z").ToUniversalTime(),
        Skills = new List<string>() {
            "adiuvo",
            "tam",
        },
        Students = new List<LmsReference>() {},
        TimeEstimateMinutes = 100D,
        UpdatedAt = System.DateTime.Parse("2023-02-10T02:30:47.139Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsCourseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateLmsCourseRequest](../../Models/Requests/UpdateLmsCourseRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateLmsCourseResponse](../../Models/Requests/UpdateLmsCourseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsInstructor

Updates the LmsInstructor identified by `id`. Provide the unified LmsInstructor fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsInstructor" method="put" path="/lms/{connection_id}/instructor/{id}" example="lms_instructor" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsInstructorRequest req = new UpdateLmsInstructorRequest() {
    LmsInstructor = new LmsInstructor() {
        CreatedAt = System.DateTime.Parse("2021-10-12T16:38:54.979Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Deangelo",
        Id = "9e1fd562-1ada-41bc-a045-d0b07490298b",
        ImageUrl = "https://avatars.githubusercontent.com/u/95131132",
        LastName = "Ritchie",
        Metadata = new List<LmsMetadata>() {},
        Name = "Deangelo Ritchie",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(605) 752-8163",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(430) 415-2451",
                Type = LmsTelephoneType.Home,
            },
        },
        Title = "Regional Security Agent",
        UpdatedAt = System.DateTime.Parse("2025-07-27T10:13:00.202Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsInstructorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateLmsInstructorRequest](../../Models/Requests/UpdateLmsInstructorRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateLmsInstructorResponse](../../Models/Requests/UpdateLmsInstructorResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsStudent

Updates the LmsStudent identified by `id`. Provide the unified LmsStudent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsStudent" method="put" path="/lms/{connection_id}/student/{id}" example="lms_student" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsStudentRequest req = new UpdateLmsStudentRequest() {
    LmsStudent = new LmsStudent() {
        Address = new PropertyLmsStudentAddress() {
            Address1 = "15033 Corwin Circles",
            City = "New Craigside",
            CountryCode = "US",
            PostalCode = "73966",
            Region = "New Jersey",
            RegionCode = "TX",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "629a8199-5564-42fb-ae24-3bc366749764",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/male/512/56.jpg",
        LastName = "Murazik",
        Metadata = new List<LmsMetadata>() {},
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(899) 827-6400",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(487) 213-8236",
                Type = LmsTelephoneType.Fax,
            },
            new LmsTelephone() {
                Telephone = "(980) 775-2940",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-07-02T08:25:27.167Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.UpdateLmsStudentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateLmsStudentRequest](../../Models/Requests/UpdateLmsStudentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateLmsStudentResponse](../../Models/Requests/UpdateLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |