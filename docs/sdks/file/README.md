# File
(*File*)

### Available Operations

* [CreateCrmFile](#createcrmfile) - Create a file
* [CreateStorageFile](#createstoragefile) - Create a file
* [GetCrmFile](#getcrmfile) - Retrieve a file
* [GetStorageFile](#getstoragefile) - Retrieve a file
* [ListCrmFiles](#listcrmfiles) - List all files
* [ListStorageFiles](#liststoragefiles) - List all files
* [PatchCrmFile](#patchcrmfile) - Update a file
* [PatchStorageFile](#patchstoragefile) - Update a file
* [RemoveCrmFile](#removecrmfile) - Remove a file
* [RemoveStorageFile](#removestoragefile) - Remove a file
* [UpdateCrmFile](#updatecrmfile) - Update a file
* [UpdateStorageFile](#updatestoragefile) - Update a file

## CreateCrmFile

Create a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.File.CreateCrmFileAsync(ConnectionId: "string", CrmFile: new CrmFile() {
    Raw = new PropertyCrmFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `CrmFile`                                     | [CrmFile](../../Models/Components/CrmFile.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[CreateCrmFileResponse](../../Models/Requests/CreateCrmFileResponse.md)**


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

var res = await sdk.File.CreateStorageFileAsync(ConnectionId: "string", StorageFile: new StorageFile() {
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


## GetCrmFile

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

var res = await sdk.File.GetCrmFileAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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

**[GetCrmFileResponse](../../Models/Requests/GetCrmFileResponse.md)**


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

var res = await sdk.File.GetStorageFileAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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


## ListCrmFiles

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

ListCrmFilesRequest req = new ListCrmFilesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.File.ListCrmFilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmFilesRequest](../../Models/Requests/ListCrmFilesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmFilesResponse](../../Models/Requests/ListCrmFilesResponse.md)**


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

var res = await sdk.File.ListStorageFilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListStorageFilesRequest](../../Models/Requests/ListStorageFilesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListStorageFilesResponse](../../Models/Requests/ListStorageFilesResponse.md)**


## PatchCrmFile

Update a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.File.PatchCrmFileAsync(ConnectionId: "string", Id: "string", CrmFile: new CrmFile() {
    Raw = new PropertyCrmFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the File                                |
| `CrmFile`                                     | [CrmFile](../../Models/Components/CrmFile.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[PatchCrmFileResponse](../../Models/Requests/PatchCrmFileResponse.md)**


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

var res = await sdk.File.PatchStorageFileAsync(ConnectionId: "string", Id: "string", StorageFile: new StorageFile() {
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


## RemoveCrmFile

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

var res = await sdk.File.RemoveCrmFileAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the File       |


### Response

**[RemoveCrmFileResponse](../../Models/Requests/RemoveCrmFileResponse.md)**


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

var res = await sdk.File.RemoveStorageFileAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the File       |


### Response

**[RemoveStorageFileResponse](../../Models/Requests/RemoveStorageFileResponse.md)**


## UpdateCrmFile

Update a file

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.File.UpdateCrmFileAsync(ConnectionId: "string", Id: "string", CrmFile: new CrmFile() {
    Raw = new PropertyCrmFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the File                                |
| `CrmFile`                                     | [CrmFile](../../Models/Components/CrmFile.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[UpdateCrmFileResponse](../../Models/Requests/UpdateCrmFileResponse.md)**


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

var res = await sdk.File.UpdateStorageFileAsync(ConnectionId: "string", Id: "string", StorageFile: new StorageFile() {
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

