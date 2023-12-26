# Storage
(*Storage*)

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

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Storage.CreateStorageFileAsync(ConnectionId: "string", StorageFile: new StorageFile() {
    Permissions = new List<StoragePermission>() {
        new StoragePermission() {
            Roles = new List<PropertyStoragePermissionRoles>() {
                PropertyStoragePermissionRoles.Write,
            },
        },
    },
    Raw = new PropertyStorageFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `StorageFile`                                         | [StorageFile](../../Models/Components/StorageFile.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreateStorageFileResponse](../../Models/Requests/CreateStorageFileResponse.md)**


## GetStorageFile

Retrieve a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Storage.GetStorageFileAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the File                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetStorageFileResponse](../../Models/Requests/GetStorageFileResponse.md)**


## ListStorageFiles

List all files

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListStorageFilesRequest req = new ListStorageFilesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Storage.ListStorageFilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListStorageFilesRequest](../../Models/Requests/ListStorageFilesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListStorageFilesResponse](../../Models/Requests/ListStorageFilesResponse.md)**


## PatchStorageFile

Update a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Storage.PatchStorageFileAsync(ConnectionId: "string", Id: "string", StorageFile: new StorageFile() {
    Permissions = new List<StoragePermission>() {
        new StoragePermission() {
            Roles = new List<PropertyStoragePermissionRoles>() {
                PropertyStoragePermissionRoles.Owner,
            },
        },
    },
    Raw = new PropertyStorageFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the File                                        |
| `StorageFile`                                         | [StorageFile](../../Models/Components/StorageFile.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchStorageFileResponse](../../Models/Requests/PatchStorageFileResponse.md)**


## RemoveStorageFile

Remove a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Storage.RemoveStorageFileAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the File       |


### Response

**[RemoveStorageFileResponse](../../Models/Requests/RemoveStorageFileResponse.md)**


## UpdateStorageFile

Update a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Storage.UpdateStorageFileAsync(ConnectionId: "string", Id: "string", StorageFile: new StorageFile() {
    Permissions = new List<StoragePermission>() {
        new StoragePermission() {
            Roles = new List<PropertyStoragePermissionRoles>() {
                PropertyStoragePermissionRoles.Write,
            },
        },
    },
    Raw = new PropertyStorageFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the File                                        |
| `StorageFile`                                         | [StorageFile](../../Models/Components/StorageFile.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdateStorageFileResponse](../../Models/Requests/UpdateStorageFileResponse.md)**

