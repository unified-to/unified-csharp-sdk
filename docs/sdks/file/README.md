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

Create a file

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
        Data = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZlcnNpb249IjEuMSIgYmFzZVByb2ZpbGU9ImZ1bGwiIHdpZHRoPSI4MzIiIGhlaWdodD0iMTg2MSI+PHJlY3Qgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgZmlsbD0iIzFmYzM1NSIvPjx0ZXh0IHg9IjQxNiIgeT0iOTMwLjUiIGZvbnQtc2l6ZT0iMjAiIGFsaWdubWVudC1iYXNlbGluZT0ibWlkZGxlIiB0ZXh0LWFuY2hvcj0ibWlkZGxlIiBmaWxsPSJ3aGl0ZSI+ODMyeDE4NjE8L3RleHQ+PC9zdmc+",
        Description = "Crastinus cupiditate debilito cimentarius virgo.",
        DownloadUrl = "https://stingy-casement.name/",
        Hash = "fe6a659e-75cd-4079-9b76-351f9af2205a",
        Id = "53dc27e2-0030-4501-8b1b-6e9e4b170adb",
        MimeType = "FOLDER",
        Name = "softly.tiff",
        References = new List<StorageReference>() {
            new StorageReference() {
                Id = "ab705f3b-e368-4a94-8b22-d5f693c14a76",
                Name = "tamisium viduo odio cauda",
                Type = "accounting_bill",
            },
            new StorageReference() {
                Id = "9f0f694e-b6f4-4c12-b5f6-ab08d4e81140",
                Name = "quia",
                Type = "accounting_expense",
            },
        },
        Size = 10276D,
        Tags = new List<string>() {
            "spoliatio",
        },
        Type = StorageFileType.File,
        UpdatedAt = System.DateTime.Parse("2023-01-27T11:58:12.326Z").ToUniversalTime(),
        Version = "1",
        WebUrl = "https://sandy-distinction.info/",
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

Retrieve a file

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

List all files

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

Update a file

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
        Data = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZlcnNpb249IjEuMSIgYmFzZVByb2ZpbGU9ImZ1bGwiIHdpZHRoPSI4MzIiIGhlaWdodD0iMTg2MSI+PHJlY3Qgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgZmlsbD0iIzFmYzM1NSIvPjx0ZXh0IHg9IjQxNiIgeT0iOTMwLjUiIGZvbnQtc2l6ZT0iMjAiIGFsaWdubWVudC1iYXNlbGluZT0ibWlkZGxlIiB0ZXh0LWFuY2hvcj0ibWlkZGxlIiBmaWxsPSJ3aGl0ZSI+ODMyeDE4NjE8L3RleHQ+PC9zdmc+",
        Description = "Crastinus cupiditate debilito cimentarius virgo.",
        DownloadUrl = "https://stingy-casement.name/",
        Hash = "fe6a659e-75cd-4079-9b76-351f9af2205a",
        Id = "d475f153-100a-4257-a6ad-70f276ab57ff",
        MimeType = "FOLDER",
        Name = "softly.tiff",
        References = new List<StorageReference>() {
            new StorageReference() {
                Id = "ab705f3b-e368-4a94-8b22-d5f693c14a76",
                Name = "tamisium viduo odio cauda",
                Type = "accounting_bill",
            },
            new StorageReference() {
                Id = "9f0f694e-b6f4-4c12-b5f6-ab08d4e81140",
                Name = "quia",
                Type = "accounting_expense",
            },
        },
        Size = 10276D,
        Tags = new List<string>() {
            "spoliatio",
        },
        Type = StorageFileType.File,
        UpdatedAt = System.DateTime.Parse("2023-01-27T11:58:12.331Z").ToUniversalTime(),
        Version = "1",
        WebUrl = "https://sandy-distinction.info/",
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

Remove a file

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

Update a file

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
        Data = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZlcnNpb249IjEuMSIgYmFzZVByb2ZpbGU9ImZ1bGwiIHdpZHRoPSI4MzIiIGhlaWdodD0iMTg2MSI+PHJlY3Qgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgZmlsbD0iIzFmYzM1NSIvPjx0ZXh0IHg9IjQxNiIgeT0iOTMwLjUiIGZvbnQtc2l6ZT0iMjAiIGFsaWdubWVudC1iYXNlbGluZT0ibWlkZGxlIiB0ZXh0LWFuY2hvcj0ibWlkZGxlIiBmaWxsPSJ3aGl0ZSI+ODMyeDE4NjE8L3RleHQ+PC9zdmc+",
        Description = "Crastinus cupiditate debilito cimentarius virgo.",
        DownloadUrl = "https://stingy-casement.name/",
        Hash = "fe6a659e-75cd-4079-9b76-351f9af2205a",
        Id = "d475f153-100a-4257-a6ad-70f276ab57ff",
        MimeType = "FOLDER",
        Name = "softly.tiff",
        References = new List<StorageReference>() {
            new StorageReference() {
                Id = "ab705f3b-e368-4a94-8b22-d5f693c14a76",
                Name = "tamisium viduo odio cauda",
                Type = "accounting_bill",
            },
            new StorageReference() {
                Id = "9f0f694e-b6f4-4c12-b5f6-ab08d4e81140",
                Name = "quia",
                Type = "accounting_expense",
            },
        },
        Size = 10276D,
        Tags = new List<string>() {
            "spoliatio",
        },
        Type = StorageFileType.File,
        UpdatedAt = System.DateTime.Parse("2023-01-27T11:58:12.331Z").ToUniversalTime(),
        Version = "1",
        WebUrl = "https://sandy-distinction.info/",
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