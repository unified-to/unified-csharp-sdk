# Page
(*Page*)

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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Page.CreateKmsPageAsync(
    connectionId: "<id>",
    kmsPage: new KmsPage() {
        DownloadUrl = "https://bitter-adult.biz/",
        Id = "<id>",
        SpaceId = "<id>",
        Title = "<value>",
        Type = UnifiedTo.Models.Components.KmsPageType.Html,
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `KmsPage`                                     | [KmsPage](../../Models/Components/KmsPage.md) | :heavy_minus_sign:                            | N/A                                           |
| `Fields`                                      | List<*string*>                                | :heavy_minus_sign:                            | Comma-delimited fields to return              |

### Response

**[CreateKmsPageResponse](../../Models/Requests/CreateKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetKmsPage

Retrieve a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Page.GetKmsPageAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Page                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetKmsPageResponse](../../Models/Requests/GetKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListKmsPages

List all pages

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Page.PatchKmsPageAsync(
    connectionId: "<id>",
    id: "<id>",
    kmsPage: new KmsPage() {
        DownloadUrl = "https://evil-tackle.info",
        Id = "<id>",
        SpaceId = "<id>",
        Title = "<value>",
        Type = UnifiedTo.Models.Components.KmsPageType.Markdown,
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Page                                |
| `KmsPage`                                     | [KmsPage](../../Models/Components/KmsPage.md) | :heavy_minus_sign:                            | N/A                                           |
| `Fields`                                      | List<*string*>                                | :heavy_minus_sign:                            | Comma-delimited fields to return              |

### Response

**[PatchKmsPageResponse](../../Models/Requests/PatchKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveKmsPage

Remove a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
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

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Page.UpdateKmsPageAsync(
    connectionId: "<id>",
    id: "<id>",
    kmsPage: new KmsPage() {
        DownloadUrl = "https://salty-devil.com",
        Id = "<id>",
        SpaceId = "<id>",
        Title = "<value>",
        Type = UnifiedTo.Models.Components.KmsPageType.Text,
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Page                                |
| `KmsPage`                                     | [KmsPage](../../Models/Components/KmsPage.md) | :heavy_minus_sign:                            | N/A                                           |
| `Fields`                                      | List<*string*>                                | :heavy_minus_sign:                            | Comma-delimited fields to return              |

### Response

**[UpdateKmsPageResponse](../../Models/Requests/UpdateKmsPageResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |