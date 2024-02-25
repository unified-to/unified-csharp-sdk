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
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Storage.CreateStorageFileAsync(
    security: new CreateStorageFileSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    storageFile: new StorageFile() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.CreateStorageFileSecurity](../../Models/Requests/CreateStorageFileSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `StorageFile`                                                                                             | [StorageFile](../../Models/Components/StorageFile.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[CreateStorageFileResponse](../../Models/Requests/CreateStorageFileResponse.md)**


## GetStorageFile

Retrieve a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Storage.GetStorageFileAsync(
    security: new GetStorageFileSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.GetStorageFileSecurity](../../Models/Requests/GetStorageFileSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the File                                                                                      |
| `Fields`                                                                                            | List<*string*>                                                                                      | :heavy_minus_sign:                                                                                  | Comma-delimited fields to return                                                                    |


### Response

**[GetStorageFileResponse](../../Models/Requests/GetStorageFileResponse.md)**


## ListStorageFiles

List all files

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListStorageFilesRequest req = new ListStorageFilesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Storage.ListStorageFilesAsync(
    security: new ListStorageFilesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListStorageFilesRequest](../../Models/Requests/ListStorageFilesRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListStorageFilesSecurity](../../Models/Requests/ListStorageFilesSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListStorageFilesResponse](../../Models/Requests/ListStorageFilesResponse.md)**


## PatchStorageFile

Update a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Storage.PatchStorageFileAsync(
    security: new PatchStorageFileSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    storageFile: new StorageFile() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.PatchStorageFileSecurity](../../Models/Requests/PatchStorageFileSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the File                                                                                          |
| `StorageFile`                                                                                           | [StorageFile](../../Models/Components/StorageFile.md)                                                   | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |


### Response

**[PatchStorageFileResponse](../../Models/Requests/PatchStorageFileResponse.md)**


## RemoveStorageFile

Remove a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Storage.RemoveStorageFileAsync(
    security: new RemoveStorageFileSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.RemoveStorageFileSecurity](../../Models/Requests/RemoveStorageFileSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the File                                                                                            |


### Response

**[RemoveStorageFileResponse](../../Models/Requests/RemoveStorageFileResponse.md)**


## UpdateStorageFile

Update a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Storage.UpdateStorageFileAsync(
    security: new UpdateStorageFileSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    storageFile: new StorageFile() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.UpdateStorageFileSecurity](../../Models/Requests/UpdateStorageFileSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the File                                                                                            |
| `StorageFile`                                                                                             | [StorageFile](../../Models/Components/StorageFile.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[UpdateStorageFileResponse](../../Models/Requests/UpdateStorageFileResponse.md)**

