# Review

## Overview

### Available Operations

* [CreateCommerceReview](#createcommercereview) - Create a review
* [GetCommerceReview](#getcommercereview) - Retrieve a review
* [GetPerformanceReview](#getperformancereview) - Retrieve a review
* [GetSocialReview](#getsocialreview) - Retrieve a review
* [ListCommerceReviews](#listcommercereviews) - List all reviews
* [ListPerformanceReviews](#listperformancereviews) - List all reviews
* [ListSocialReviews](#listsocialreviews) - List all reviews
* [PatchCommerceReview](#patchcommercereview) - Update a review
* [PatchSocialReview](#patchsocialreview) - Update a review
* [RemoveCommerceReview](#removecommercereview) - Remove a review
* [UpdateCommerceReview](#updatecommercereview) - Update a review
* [UpdateSocialReview](#updatesocialreview) - Update a review

## CreateCommerceReview

Create a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceReview" method="post" path="/commerce/{connection_id}/review" example="commerce_review" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Review.CreateCommerceReviewAsync(
    commerceReview: new CommerceReview() {
        AuthorAvatarUrl = "https://picsum.photos/seed/ix4Br3LA/2245/1245",
        AuthorEmail = "Cleve_Yundt@hotmail.com",
        AuthorLocation = "ipsum",
        AuthorName = "Marsha Krajcik",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 26D,
        Id = "a3a8627e-6fff-4a60-a0a2-2a60c86c90de",
        IsFeatured = true,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Adulescens.",
                Height = 519D,
                Id = "279dbc48-b710-40b4-b9e4-1344a22b9810",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "ab9c3901-43ca-4b55-a0f6-b4e7a0c99efe",
                        Slug = "aggero",
                        Value = CommerceMetadataValue.CreateStr(
                            "tero"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/882/1004?lock=7448492654002422",
                Width = 75D,
            },
            new CommerceItemMedia() {
                Alt = "Pauci timidus sol comburo thema.",
                Height = 297D,
                Id = "a1aedf71-4b34-4d89-bbbc-e3a846218768",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "fcc6518e-5d86-4f52-8d77-2e577d27a6f6",
                        Slug = "vito",
                        Value = CommerceMetadataValue.CreateStr(
                            "cuppedia"
                        ),
                    },
                },
                Position = 61D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/3QDZ8/1208/2171",
                Width = 96D,
            },
            new CommerceItemMedia() {
                Alt = "Cuppedia vestrum patruus.",
                Height = 6D,
                Id = "fc1c3c4b-b404-4fb2-a209-4674a9f9381a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "4301cbc5-9765-40f9-b34e-ea184384ed76",
                        Slug = "arbitro",
                        Value = CommerceMetadataValue.CreateStr(
                            "villa"
                        ),
                    },
                },
                Position = 60D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/ytybC/2616/710",
                Width = 74D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 49D,
        UpdatedAt = System.DateTime.Parse("2025-08-19T15:23:21.988Z").ToUniversalTime(),
        Url = "https://excitable-underneath.com",
        VerifiedPurchase = false,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceReview`                                                                                                                                 | [CommerceReview](../../Models/Components/CommerceReview.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceReviewQueryParamFields](../../Models/Requests/CreateCommerceReviewQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceReviewResponse](../../Models/Requests/CreateCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceReview

Retrieve a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceReview" method="get" path="/commerce/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Review.GetCommerceReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Review                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetCommerceReviewQueryParamFields](../../Models/Requests/GetCommerceReviewQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceReviewResponse](../../Models/Requests/GetCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPerformanceReview

Retrieve a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPerformanceReview" method="get" path="/performance/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Review.GetPerformanceReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Review                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetPerformanceReviewQueryParamFields](../../Models/Requests/GetPerformanceReviewQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPerformanceReviewResponse](../../Models/Requests/GetPerformanceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetSocialReview

Retrieve a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSocialReview" method="get" path="/social/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Review.GetSocialReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Review                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetSocialReviewQueryParamFields](../../Models/Requests/GetSocialReviewQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSocialReviewResponse](../../Models/Requests/GetSocialReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceReviews

List all reviews

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceReviews" method="get" path="/commerce/{connection_id}/review" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceReviewsRequest req = new ListCommerceReviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Review.ListCommerceReviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListCommerceReviewsRequest](../../Models/Requests/ListCommerceReviewsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListCommerceReviewsResponse](../../Models/Requests/ListCommerceReviewsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPerformanceReviews

List all reviews

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPerformanceReviews" method="get" path="/performance/{connection_id}/review" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPerformanceReviewsRequest req = new ListPerformanceReviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Review.ListPerformanceReviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListPerformanceReviewsRequest](../../Models/Requests/ListPerformanceReviewsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListPerformanceReviewsResponse](../../Models/Requests/ListPerformanceReviewsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListSocialReviews

List all reviews

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSocialReviews" method="get" path="/social/{connection_id}/review" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSocialReviewsRequest req = new ListSocialReviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Review.ListSocialReviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListSocialReviewsRequest](../../Models/Requests/ListSocialReviewsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListSocialReviewsResponse](../../Models/Requests/ListSocialReviewsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceReview

Update a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceReview" method="patch" path="/commerce/{connection_id}/review/{id}" example="commerce_review" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceReviewRequest req = new PatchCommerceReviewRequest() {
    CommerceReview = new CommerceReview() {
        AuthorAvatarUrl = "https://picsum.photos/seed/ix4Br3LA/2245/1245",
        AuthorEmail = "Cleve_Yundt@hotmail.com",
        AuthorLocation = "ipsum",
        AuthorName = "Marsha Krajcik",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 26D,
        Id = "065c7835-3966-4d05-8900-2b0d2b3404a9",
        IsFeatured = true,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Adulescens.",
                Height = 519D,
                Id = "eed1ea22-b4b4-494f-85bc-be077bf9052c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "aa2bbb4d-93b2-4977-880c-12a0dfc9a974",
                        Slug = "aggero",
                        Value = CommerceMetadataValue.CreateStr(
                            "tero"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/882/1004?lock=7448492654002422",
                Width = 75D,
            },
            new CommerceItemMedia() {
                Alt = "Pauci timidus sol comburo thema.",
                Height = 297D,
                Id = "b9170e4c-5352-4a47-8835-f05c502c95cb",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "19504dcd-c14a-4358-9745-7d5b51b05b08",
                        Slug = "vito",
                        Value = CommerceMetadataValue.CreateStr(
                            "cuppedia"
                        ),
                    },
                },
                Position = 61D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/3QDZ8/1208/2171",
                Width = 96D,
            },
            new CommerceItemMedia() {
                Alt = "Cuppedia vestrum patruus.",
                Height = 6D,
                Id = "d98120f7-a1b6-4045-8b8c-b1a560a2e45a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "0a44fdbf-b9a4-4df2-8ea0-7d14970973f3",
                        Slug = "arbitro",
                        Value = CommerceMetadataValue.CreateStr(
                            "villa"
                        ),
                    },
                },
                Position = 60D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/ytybC/2616/710",
                Width = 74D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 49D,
        UpdatedAt = System.DateTime.Parse("2025-08-19T15:23:22.019Z").ToUniversalTime(),
        Url = "https://excitable-underneath.com",
        VerifiedPurchase = false,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Review.PatchCommerceReviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchCommerceReviewRequest](../../Models/Requests/PatchCommerceReviewRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchCommerceReviewResponse](../../Models/Requests/PatchCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchSocialReview

Update a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchSocialReview" method="patch" path="/social/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchSocialReviewRequest req = new PatchSocialReviewRequest() {
    SocialReview = new SocialReview() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Review.PatchSocialReviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchSocialReviewRequest](../../Models/Requests/PatchSocialReviewRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchSocialReviewResponse](../../Models/Requests/PatchSocialReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceReview

Remove a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceReview" method="delete" path="/commerce/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Review.RemoveCommerceReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Review     |

### Response

**[RemoveCommerceReviewResponse](../../Models/Requests/RemoveCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceReview

Update a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceReview" method="put" path="/commerce/{connection_id}/review/{id}" example="commerce_review" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceReviewRequest req = new UpdateCommerceReviewRequest() {
    CommerceReview = new CommerceReview() {
        AuthorAvatarUrl = "https://picsum.photos/seed/ix4Br3LA/2245/1245",
        AuthorEmail = "Cleve_Yundt@hotmail.com",
        AuthorLocation = "ipsum",
        AuthorName = "Marsha Krajcik",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 26D,
        Id = "065c7835-3966-4d05-8900-2b0d2b3404a9",
        IsFeatured = true,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Adulescens.",
                Height = 519D,
                Id = "eed1ea22-b4b4-494f-85bc-be077bf9052c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "aa2bbb4d-93b2-4977-880c-12a0dfc9a974",
                        Slug = "aggero",
                        Value = CommerceMetadataValue.CreateStr(
                            "tero"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/882/1004?lock=7448492654002422",
                Width = 75D,
            },
            new CommerceItemMedia() {
                Alt = "Pauci timidus sol comburo thema.",
                Height = 297D,
                Id = "b9170e4c-5352-4a47-8835-f05c502c95cb",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "19504dcd-c14a-4358-9745-7d5b51b05b08",
                        Slug = "vito",
                        Value = CommerceMetadataValue.CreateStr(
                            "cuppedia"
                        ),
                    },
                },
                Position = 61D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/3QDZ8/1208/2171",
                Width = 96D,
            },
            new CommerceItemMedia() {
                Alt = "Cuppedia vestrum patruus.",
                Height = 6D,
                Id = "d98120f7-a1b6-4045-8b8c-b1a560a2e45a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "0a44fdbf-b9a4-4df2-8ea0-7d14970973f3",
                        Slug = "arbitro",
                        Value = CommerceMetadataValue.CreateStr(
                            "villa"
                        ),
                    },
                },
                Position = 60D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/ytybC/2616/710",
                Width = 74D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 49D,
        UpdatedAt = System.DateTime.Parse("2025-08-19T15:23:22.019Z").ToUniversalTime(),
        Url = "https://excitable-underneath.com",
        VerifiedPurchase = false,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Review.UpdateCommerceReviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateCommerceReviewRequest](../../Models/Requests/UpdateCommerceReviewRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateCommerceReviewResponse](../../Models/Requests/UpdateCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateSocialReview

Update a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSocialReview" method="put" path="/social/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateSocialReviewRequest req = new UpdateSocialReviewRequest() {
    SocialReview = new SocialReview() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Review.UpdateSocialReviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateSocialReviewRequest](../../Models/Requests/UpdateSocialReviewRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateSocialReviewResponse](../../Models/Requests/UpdateSocialReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |