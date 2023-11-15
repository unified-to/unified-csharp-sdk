# File
(*File*)

### Available Operations

* [CreateCrmFile](#createcrmfile) - Create a file
* [GetCrmFile](#getcrmfile) - Retrieve a file
* [ListCrmFiles](#listcrmfiles) - List all files
* [PatchCrmFile](#patchcrmfile) - Update a file
* [RemoveCrmFile](#removecrmfile) - Remove a file
* [UpdateCrmFile](#updatecrmfile) - Update a file

## CreateCrmFile

Create a file

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.File.CreateCrmFileAsync("string", new CrmFile() {
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


## GetCrmFile

Retrieve a file

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.File.GetCrmFileAsync("string", "string", new List<string>() {
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


## ListCrmFiles

List all files

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo();

var res = await sdk.File.ListCrmFilesAsync(new ListCrmFilesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmFilesRequest](../../Models/Requests/ListCrmFilesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmFilesResponse](../../Models/Requests/ListCrmFilesResponse.md)**


## PatchCrmFile

Update a file

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.File.PatchCrmFileAsync("string", "string", new CrmFile() {
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


## RemoveCrmFile

Remove a file

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.File.RemoveCrmFileAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the File       |


### Response

**[RemoveCrmFileResponse](../../Models/Requests/RemoveCrmFileResponse.md)**


## UpdateCrmFile

Update a file

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo();

var res = await sdk.File.UpdateCrmFileAsync("string", "string", new CrmFile() {
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

