# File

## Overview

### Available Operations

* [CreateStorageFile](#createstoragefile) - Create a file
* [GetStorageFile](#getstoragefile) - Retrieve a file
* [ListStorageFiles](#liststoragefiles) - List all files
* [PatchStorageFile](#patchstoragefile) - Update a file
* [RemoveStorageFile](#removestoragefile) - Remove a file
* [UpdateStorageFile](#updatestoragefile) - Update a file

## CreateStorageFile

Creates a StorageFile. Provide the unified StorageFile fields in the request body; they are mapped to the provider's API. Returns the created StorageFile.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createStorageFile" method="post" path="/storage/{connection_id}/file" example="storage_file" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.File.CreateStorageFileAsync(
    storageFile: new StorageFile() {
        CreatedAt = System.DateTime.Parse("2021-09-12T16:48:23.774Z").ToUniversalTime(),
        Description = "Deprimo crastinus cupiditate debilito cimentarius virgo acidus.",
        DownloadUrl = "https://clueless-laughter.biz",
        Hash = "d9d88dda7bc0acaa8472fdef2307f94a1fc355ce",
        Id = "cb1572d9-7d45-425c-87ab-519bfc7b3b76",
        Metadata = new List<StorageMetadata>() {},
        MimeType = "application/pdf",
        Name = "softly.pdf",
        Size = 1134456D,
        Tags = new List<string>() {
            "suasoria",
        },
        Type = StorageFileType.Folder,
        UpdatedAt = System.DateTime.Parse("2023-02-06T21:19:43.388Z").ToUniversalTime(),
        Version = "1",
        WebUrl = "https://faraway-inspection.org",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `StorageFile`                                                                                                                                    | [StorageFile](../../Models/Components/StorageFile.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateStorageFileQueryParamFields](../../Models/Requests/CreateStorageFileQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateStorageFileResponse](../../Models/Requests/CreateStorageFileResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetStorageFile

Retrieves a single StorageFile by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getStorageFile" method="get" path="/storage/{connection_id}/file/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.File.GetStorageFileAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the File                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetStorageFileQueryParamFields](../../Models/Requests/GetStorageFileQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetStorageFileResponse](../../Models/Requests/GetStorageFileResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListStorageFiles

Returns a list of StorageFiles. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listStorageFiles" method="get" path="/storage/{connection_id}/file" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListStorageFilesRequest req = new ListStorageFilesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.File.ListStorageFilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListStorageFilesRequest](../../Models/Requests/ListStorageFilesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListStorageFilesResponse](../../Models/Requests/ListStorageFilesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchStorageFile

Updates the StorageFile identified by `id`. Provide the unified StorageFile fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchStorageFile" method="patch" path="/storage/{connection_id}/file/{id}" example="storage_file" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchStorageFileRequest req = new PatchStorageFileRequest() {
    StorageFile = new StorageFile() {
        CreatedAt = System.DateTime.Parse("2021-09-12T16:48:23.774Z").ToUniversalTime(),
        Description = "Deprimo crastinus cupiditate debilito cimentarius virgo acidus.",
        DownloadUrl = "https://clueless-laughter.biz",
        Hash = "d9d88dda7bc0acaa8472fdef2307f94a1fc355ce",
        Id = "5464212e-bb3b-4c6b-b2fd-ef1d406869fb",
        Metadata = new List<StorageMetadata>() {},
        MimeType = "application/pdf",
        Name = "softly.pdf",
        Size = 1134456D,
        Tags = new List<string>() {
            "suasoria",
        },
        Type = StorageFileType.Folder,
        UpdatedAt = System.DateTime.Parse("2023-02-06T21:19:43.395Z").ToUniversalTime(),
        Version = "1",
        WebUrl = "https://faraway-inspection.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.File.PatchStorageFileAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchStorageFileRequest](../../Models/Requests/PatchStorageFileRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchStorageFileResponse](../../Models/Requests/PatchStorageFileResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveStorageFile

Deletes the StorageFile identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeStorageFile" method="delete" path="/storage/{connection_id}/file/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.File.RemoveStorageFileAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the File       |

### Response

**[RemoveStorageFileResponse](../../Models/Requests/RemoveStorageFileResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateStorageFile

Updates the StorageFile identified by `id`. Provide the unified StorageFile fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateStorageFile" method="put" path="/storage/{connection_id}/file/{id}" example="storage_file" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateStorageFileRequest req = new UpdateStorageFileRequest() {
    StorageFile = new StorageFile() {
        CreatedAt = System.DateTime.Parse("2021-09-12T16:48:23.774Z").ToUniversalTime(),
        Description = "Deprimo crastinus cupiditate debilito cimentarius virgo acidus.",
        DownloadUrl = "https://clueless-laughter.biz",
        Hash = "d9d88dda7bc0acaa8472fdef2307f94a1fc355ce",
        Id = "5464212e-bb3b-4c6b-b2fd-ef1d406869fb",
        Metadata = new List<StorageMetadata>() {},
        MimeType = "application/pdf",
        Name = "softly.pdf",
        Size = 1134456D,
        Tags = new List<string>() {
            "suasoria",
        },
        Type = StorageFileType.Folder,
        UpdatedAt = System.DateTime.Parse("2023-02-06T21:19:43.395Z").ToUniversalTime(),
        Version = "1",
        WebUrl = "https://faraway-inspection.org",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.File.UpdateStorageFileAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateStorageFileRequest](../../Models/Requests/UpdateStorageFileRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateStorageFileResponse](../../Models/Requests/UpdateStorageFileResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |