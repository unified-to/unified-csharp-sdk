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

Create a page

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
        Id = "6dd0542d-1208-431b-9ccf-e4de65847b63",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-09-11T14:54:39.502Z").ToUniversalTime(),
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

Retrieve a page

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

List all pages

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

Update a page

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
        Id = "efe0b1a6-592b-4335-8b38-50a019f71d2f",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-09-11T14:54:39.517Z").ToUniversalTime(),
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

Remove a page

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

Update a page

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
        Id = "efe0b1a6-592b-4335-8b38-50a019f71d2f",
        IsActive = true,
        Metadata = new List<KmsPageMetadata>() {},
        Title = "even minister extract",
        Type = KmsPageType.Html,
        UpdatedAt = System.DateTime.Parse("2025-09-11T14:54:39.517Z").ToUniversalTime(),
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