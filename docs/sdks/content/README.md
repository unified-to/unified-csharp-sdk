# Content

## Overview

### Available Operations

* [CreateLmsContent](#createlmscontent) - Create a content
* [GetLmsContent](#getlmscontent) - Retrieve a content
* [ListLmsContents](#listlmscontents) - List all contents
* [PatchLmsContent](#patchlmscontent) - Update a content
* [RemoveLmsContent](#removelmscontent) - Remove a content
* [UpdateLmsContent](#updatelmscontent) - Update a content

## CreateLmsContent

Create a content

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

var res = await sdk.Content.CreateLmsContentAsync(
    lmsContent: new LmsContent() {
        Categories = new List<string>() {
            "territo",
        },
        CreatedAt = System.DateTime.Parse("2020-10-22T22:30:50.963Z").ToUniversalTime(),
        Description = "Usque laboriosam ventosus adflicto.",
        Difficulty = "Beginner",
        DurationMinutes = 19D,
        ExternalReference = "0d230e31-a9c4-4a35-a5b9-9168e91ffff5",
        Id = "09b21f68-cdb1-4147-bb3e-6d70468ec346",
        Instructors = new List<LmsReference>() {
            new LmsReference() {
                Id = "91a23b20-a7a3-4323-9548-0897c09eb49e",
                Name = "Winston Ferry",
            },
        },
        IsActive = true,
        Languages = new List<string>() {
            "despecto",
            "suppellex",
        },
        Localizations = new List<LmsContentLocalization>() {
            new LmsContentLocalization() {
                Description = "Numquam.",
                Language = "es",
                Name = "validus",
            },
            new LmsContentLocalization() {
                Description = "Callide.",
                Language = "fr",
                Name = "crux",
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
        Name = "ut",
        ProviderName = "Berge LLC",
        PublishedAt = System.DateTime.Parse("2023-11-08T11:32:09.080Z").ToUniversalTime(),
        ShortDescription = "Commemoro.",
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
        UpdatedAt = System.DateTime.Parse("2022-09-23T11:13:51.788Z").ToUniversalTime(),
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

## GetLmsContent

Retrieve a content

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsContent" method="get" path="/lms/{connection_id}/content/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Content.GetLmsContentAsync(
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

## ListLmsContents

List all contents

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

var res = await sdk.Content.ListLmsContentsAsync(req);

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

## PatchLmsContent

Update a content

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
        ExternalReference = "0d230e31-a9c4-4a35-a5b9-9168e91ffff5",
        Id = "f4465935-c7ed-442f-97e4-8edf4fdfc16e",
        Instructors = new List<LmsReference>() {
            new LmsReference() {
                Id = "91a23b20-a7a3-4323-9548-0897c09eb49e",
                Name = "Winston Ferry",
            },
        },
        IsActive = true,
        Languages = new List<string>() {
            "despecto",
            "suppellex",
        },
        Localizations = new List<LmsContentLocalization>() {
            new LmsContentLocalization() {
                Description = "Numquam.",
                Language = "es",
                Name = "validus",
            },
            new LmsContentLocalization() {
                Description = "Callide.",
                Language = "fr",
                Name = "crux",
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
        Name = "ut",
        ProviderName = "Berge LLC",
        PublishedAt = System.DateTime.Parse("2023-11-08T11:32:09.080Z").ToUniversalTime(),
        ShortDescription = "Commemoro.",
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
        UpdatedAt = System.DateTime.Parse("2022-09-23T11:13:51.798Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Content.PatchLmsContentAsync(req);

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

## RemoveLmsContent

Remove a content

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsContent" method="delete" path="/lms/{connection_id}/content/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Content.RemoveLmsContentAsync(
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

## UpdateLmsContent

Update a content

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
        ExternalReference = "0d230e31-a9c4-4a35-a5b9-9168e91ffff5",
        Id = "f4465935-c7ed-442f-97e4-8edf4fdfc16e",
        Instructors = new List<LmsReference>() {
            new LmsReference() {
                Id = "91a23b20-a7a3-4323-9548-0897c09eb49e",
                Name = "Winston Ferry",
            },
        },
        IsActive = true,
        Languages = new List<string>() {
            "despecto",
            "suppellex",
        },
        Localizations = new List<LmsContentLocalization>() {
            new LmsContentLocalization() {
                Description = "Numquam.",
                Language = "es",
                Name = "validus",
            },
            new LmsContentLocalization() {
                Description = "Callide.",
                Language = "fr",
                Name = "crux",
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
        Name = "ut",
        ProviderName = "Berge LLC",
        PublishedAt = System.DateTime.Parse("2023-11-08T11:32:09.080Z").ToUniversalTime(),
        ShortDescription = "Commemoro.",
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
        UpdatedAt = System.DateTime.Parse("2022-09-23T11:13:51.798Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Content.UpdateLmsContentAsync(req);

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