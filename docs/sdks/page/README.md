# Page

## Overview

### Available Operations

* [CreateKmsPage](#createkmspage) - Create a page
* [GetKmsPage](#getkmspage) - Retrieve a page
* [ListKmsPages](#listkmspages) - List all pages
* [PatchKmsPage](#patchkmspage) - Update a page
* [RemoveKmsPage](#removekmspage) - Remove a page
* [UpdateKmsPage](#updatekmspage) - Update a page

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

var res = await sdk.Page.CreateKmsPageAsync(
    kmsPage: new KmsPage() {
        CreatedAt = System.DateTime.Parse("2019-05-20T18:06:50.749Z").ToUniversalTime(),
        DownloadUrl = "https://agitated-validity.info",
        HasChildren = true,
        Id = "dd3b08ad-f869-4579-9edd-3b888507aa42",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-10-15T18:40:34.522Z").ToUniversalTime(),
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

var res = await sdk.Page.GetKmsPageAsync(
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

var res = await sdk.Page.ListKmsPagesAsync(req);

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
        Id = "3f730c4e-8905-4ebe-81c4-69045b03454d",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-10-15T18:40:34.531Z").ToUniversalTime(),
        WebUrl = "https://another-petticoat.info",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Page.PatchKmsPageAsync(req);

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

var res = await sdk.Page.RemoveKmsPageAsync(
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
        Id = "3f730c4e-8905-4ebe-81c4-69045b03454d",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-10-15T18:40:34.531Z").ToUniversalTime(),
        WebUrl = "https://another-petticoat.info",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Page.UpdateKmsPageAsync(req);

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