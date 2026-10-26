# Kms

## Overview

### Available Operations

* [CreateKmsComment](#createkmscomment) - Create a comment
* [CreateKmsPage](#createkmspage) - Create a page
* [CreateKmsSpace](#createkmsspace) - Create a space
* [GetKmsComment](#getkmscomment) - Retrieve a comment
* [GetKmsPage](#getkmspage) - Retrieve a page
* [GetKmsSpace](#getkmsspace) - Retrieve a space
* [ListKmsComments](#listkmscomments) - List all comments
* [ListKmsPages](#listkmspages) - List all pages
* [ListKmsSpaces](#listkmsspaces) - List all spaces
* [PatchKmsComment](#patchkmscomment) - Update a comment
* [PatchKmsPage](#patchkmspage) - Update a page
* [PatchKmsSpace](#patchkmsspace) - Update a space
* [RemoveKmsComment](#removekmscomment) - Remove a comment
* [RemoveKmsPage](#removekmspage) - Remove a page
* [RemoveKmsSpace](#removekmsspace) - Remove a space
* [UpdateKmsComment](#updatekmscomment) - Update a comment
* [UpdateKmsPage](#updatekmspage) - Update a page
* [UpdateKmsSpace](#updatekmsspace) - Update a space

## CreateKmsComment

Creates a KmsComment. Provide the unified KmsComment fields in the request body; they are mapped to the provider's API. Returns the created KmsComment.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createKmsComment" method="post" path="/kms/{connection_id}/comment" example="kms_comment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.CreateKmsCommentAsync(
    kmsComment: new KmsComment() {
        Content = "Decimus tolero viriliter usque.",
        ContentType = ContentType.Html,
        CreatedAt = System.DateTime.Parse("2022-08-26T14:40:49.732Z").ToUniversalTime(),
        Id = "81a059a4-5147-4065-8442-494e538010f7",
        Metadata = new List<KmsPageMetadata>() {},
        Type = KmsCommentType.Page,
        UpdatedAt = System.DateTime.Parse("2023-11-27T18:19:12.212Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `KmsComment`                                                                                                                                     | [KmsComment](../../Models/Components/KmsComment.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateKmsCommentQueryParamFields](../../Models/Requests/CreateKmsCommentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateKmsCommentResponse](../../Models/Requests/CreateKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateKmsPage

Creates a KmsPage. Provide the unified KmsPage fields in the request body; they are mapped to the provider's API. Returns the created KmsPage.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createKmsPage" method="post" path="/kms/{connection_id}/page" example="kms_page" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.CreateKmsPageAsync(
    kmsPage: new KmsPage() {
        CreatedAt = System.DateTime.Parse("2019-05-20T18:06:50.749Z").ToUniversalTime(),
        DownloadUrl = "https://agitated-validity.info",
        HasChildren = true,
        Id = "3029200e-cd17-4782-a117-8b6daf6b7c72",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-10-13T09:56:21.141Z").ToUniversalTime(),
        WebUrl = "https://another-petticoat.info",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `KmsPage`                                                                                                                                        | [KmsPage](../../Models/Components/KmsPage.md)                                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateKmsPageQueryParamFields](../../Models/Requests/CreateKmsPageQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateKmsPageResponse](../../Models/Requests/CreateKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateKmsSpace

Creates a KmsSpace. Provide the unified KmsSpace fields in the request body; they are mapped to the provider's API. Returns the created KmsSpace.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createKmsSpace" method="post" path="/kms/{connection_id}/space" example="kms_space" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.CreateKmsSpaceAsync(
    kmsSpace: new KmsSpace() {
        CreatedAt = System.DateTime.Parse("2022-10-31T00:56:54.246Z").ToUniversalTime(),
        Description = "Acer.",
        Id = "af87ba29-66ed-41ff-875a-d136ebaeb78c",
        IsActive = false,
        Metadata = new List<KmsPageMetadata>() {},
        Name = "into nor afore",
        UpdatedAt = System.DateTime.Parse("2026-01-02T20:51:07.837Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `KmsSpace`                                                                                                                                       | [KmsSpace](../../Models/Components/KmsSpace.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateKmsSpaceQueryParamFields](../../Models/Requests/CreateKmsSpaceQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateKmsSpaceResponse](../../Models/Requests/CreateKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetKmsComment

Retrieves a single KmsComment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getKmsComment" method="get" path="/kms/{connection_id}/comment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.GetKmsCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Comment                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetKmsCommentQueryParamFields](../../Models/Requests/GetKmsCommentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetKmsCommentResponse](../../Models/Requests/GetKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetKmsPage

Retrieves a single KmsPage by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getKmsPage" method="get" path="/kms/{connection_id}/page/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.GetKmsPageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Page                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetKmsPageQueryParamFields](../../Models/Requests/GetKmsPageQueryParamFields.md)>                                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetKmsPageResponse](../../Models/Requests/GetKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetKmsSpace

Retrieves a single KmsSpace by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getKmsSpace" method="get" path="/kms/{connection_id}/space/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.GetKmsSpaceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Space                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetKmsSpaceQueryParamFields](../../Models/Requests/GetKmsSpaceQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetKmsSpaceResponse](../../Models/Requests/GetKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListKmsComments

Returns a list of KmsComments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listKmsComments" method="get" path="/kms/{connection_id}/comment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListKmsCommentsRequest req = new ListKmsCommentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Kms.ListKmsCommentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListKmsCommentsRequest](../../Models/Requests/ListKmsCommentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListKmsCommentsResponse](../../Models/Requests/ListKmsCommentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListKmsPages

Returns a list of KmsPages. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listKmsPages" method="get" path="/kms/{connection_id}/page" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListKmsPagesRequest req = new ListKmsPagesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Kms.ListKmsPagesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListKmsPagesRequest](../../Models/Requests/ListKmsPagesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListKmsPagesResponse](../../Models/Requests/ListKmsPagesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListKmsSpaces

Returns a list of KmsSpaces. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listKmsSpaces" method="get" path="/kms/{connection_id}/space" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListKmsSpacesRequest req = new ListKmsSpacesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Kms.ListKmsSpacesAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListKmsSpacesRequest](../../Models/Requests/ListKmsSpacesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListKmsSpacesResponse](../../Models/Requests/ListKmsSpacesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchKmsComment

Updates the KmsComment identified by `id`. Provide the unified KmsComment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchKmsComment" method="patch" path="/kms/{connection_id}/comment/{id}" example="kms_comment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchKmsCommentRequest req = new PatchKmsCommentRequest() {
    KmsComment = new KmsComment() {
        Content = "Decimus tolero viriliter usque.",
        ContentType = ContentType.Html,
        CreatedAt = System.DateTime.Parse("2022-08-26T14:40:49.732Z").ToUniversalTime(),
        Id = "a94ffbc2-29a7-4d52-acd9-67cf2e89c8be",
        Metadata = new List<KmsPageMetadata>() {},
        Type = KmsCommentType.Page,
        UpdatedAt = System.DateTime.Parse("2023-11-27T18:19:12.217Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Kms.PatchKmsCommentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchKmsCommentRequest](../../Models/Requests/PatchKmsCommentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchKmsCommentResponse](../../Models/Requests/PatchKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchKmsPage

Updates the KmsPage identified by `id`. Provide the unified KmsPage fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchKmsPage" method="patch" path="/kms/{connection_id}/page/{id}" example="kms_page" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchKmsPageRequest req = new PatchKmsPageRequest() {
    KmsPage = new KmsPage() {
        CreatedAt = System.DateTime.Parse("2019-05-20T18:06:50.749Z").ToUniversalTime(),
        DownloadUrl = "https://agitated-validity.info",
        HasChildren = true,
        Id = "6808e924-283d-4474-b655-59cb6501bf8e",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-10-13T09:56:21.154Z").ToUniversalTime(),
        WebUrl = "https://another-petticoat.info",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Kms.PatchKmsPageAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [PatchKmsPageRequest](../../Models/Requests/PatchKmsPageRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[PatchKmsPageResponse](../../Models/Requests/PatchKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchKmsSpace

Updates the KmsSpace identified by `id`. Provide the unified KmsSpace fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchKmsSpace" method="patch" path="/kms/{connection_id}/space/{id}" example="kms_space" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchKmsSpaceRequest req = new PatchKmsSpaceRequest() {
    KmsSpace = new KmsSpace() {
        CreatedAt = System.DateTime.Parse("2022-10-31T00:56:54.246Z").ToUniversalTime(),
        Description = "Acer.",
        Id = "740ba1cc-e195-4054-ab89-020824b3e9db",
        IsActive = false,
        Metadata = new List<KmsPageMetadata>() {},
        Name = "into nor afore",
        UpdatedAt = System.DateTime.Parse("2026-01-02T20:51:07.848Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Kms.PatchKmsSpaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchKmsSpaceRequest](../../Models/Requests/PatchKmsSpaceRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchKmsSpaceResponse](../../Models/Requests/PatchKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveKmsComment

Deletes the KmsComment identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeKmsComment" method="delete" path="/kms/{connection_id}/comment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.RemoveKmsCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Comment    |

### Response

**[RemoveKmsCommentResponse](../../Models/Requests/RemoveKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveKmsPage

Deletes the KmsPage identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeKmsPage" method="delete" path="/kms/{connection_id}/page/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.RemoveKmsPageAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Page       |

### Response

**[RemoveKmsPageResponse](../../Models/Requests/RemoveKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveKmsSpace

Deletes the KmsSpace identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeKmsSpace" method="delete" path="/kms/{connection_id}/space/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Kms.RemoveKmsSpaceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Space      |

### Response

**[RemoveKmsSpaceResponse](../../Models/Requests/RemoveKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateKmsComment

Updates the KmsComment identified by `id`. Provide the unified KmsComment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateKmsComment" method="put" path="/kms/{connection_id}/comment/{id}" example="kms_comment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateKmsCommentRequest req = new UpdateKmsCommentRequest() {
    KmsComment = new KmsComment() {
        Content = "Decimus tolero viriliter usque.",
        ContentType = ContentType.Html,
        CreatedAt = System.DateTime.Parse("2022-08-26T14:40:49.732Z").ToUniversalTime(),
        Id = "a94ffbc2-29a7-4d52-acd9-67cf2e89c8be",
        Metadata = new List<KmsPageMetadata>() {},
        Type = KmsCommentType.Page,
        UpdatedAt = System.DateTime.Parse("2023-11-27T18:19:12.217Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Kms.UpdateKmsCommentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateKmsCommentRequest](../../Models/Requests/UpdateKmsCommentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateKmsCommentResponse](../../Models/Requests/UpdateKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateKmsPage

Updates the KmsPage identified by `id`. Provide the unified KmsPage fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateKmsPage" method="put" path="/kms/{connection_id}/page/{id}" example="kms_page" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateKmsPageRequest req = new UpdateKmsPageRequest() {
    KmsPage = new KmsPage() {
        CreatedAt = System.DateTime.Parse("2019-05-20T18:06:50.749Z").ToUniversalTime(),
        DownloadUrl = "https://agitated-validity.info",
        HasChildren = true,
        Id = "6808e924-283d-4474-b655-59cb6501bf8e",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-10-13T09:56:21.154Z").ToUniversalTime(),
        WebUrl = "https://another-petticoat.info",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Kms.UpdateKmsPageAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateKmsPageRequest](../../Models/Requests/UpdateKmsPageRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateKmsPageResponse](../../Models/Requests/UpdateKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateKmsSpace

Updates the KmsSpace identified by `id`. Provide the unified KmsSpace fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateKmsSpace" method="put" path="/kms/{connection_id}/space/{id}" example="kms_space" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateKmsSpaceRequest req = new UpdateKmsSpaceRequest() {
    KmsSpace = new KmsSpace() {
        CreatedAt = System.DateTime.Parse("2022-10-31T00:56:54.246Z").ToUniversalTime(),
        Description = "Acer.",
        Id = "740ba1cc-e195-4054-ab89-020824b3e9db",
        IsActive = false,
        Metadata = new List<KmsPageMetadata>() {},
        Name = "into nor afore",
        UpdatedAt = System.DateTime.Parse("2026-01-02T20:51:07.848Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Kms.UpdateKmsSpaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateKmsSpaceRequest](../../Models/Requests/UpdateKmsSpaceRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateKmsSpaceResponse](../../Models/Requests/UpdateKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |