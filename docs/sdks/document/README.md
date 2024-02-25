# Document
(*Document*)

### Available Operations

* [CreateAtsDocument](#createatsdocument) - Create a document
* [GetAtsDocument](#getatsdocument) - Retrieve a document
* [ListAtsDocuments](#listatsdocuments) - List all documents
* [PatchAtsDocument](#patchatsdocument) - Update a document
* [RemoveAtsDocument](#removeatsdocument) - Remove a document
* [UpdateAtsDocument](#updateatsdocument) - Update a document

## CreateAtsDocument

Create a document

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Document.CreateAtsDocumentAsync(
    security: new CreateAtsDocumentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    atsDocument: new AtsDocument() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.CreateAtsDocumentSecurity](../../Models/Requests/CreateAtsDocumentSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `AtsDocument`                                                                                             | [AtsDocument](../../Models/Components/AtsDocument.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[CreateAtsDocumentResponse](../../Models/Requests/CreateAtsDocumentResponse.md)**


## GetAtsDocument

Retrieve a document

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Document.GetAtsDocumentAsync(
    security: new GetAtsDocumentSecurity() {
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
| `security`                                                                                          | [UnifiedTo.Models.Requests.GetAtsDocumentSecurity](../../Models/Requests/GetAtsDocumentSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Document                                                                                  |
| `Fields`                                                                                            | List<*string*>                                                                                      | :heavy_minus_sign:                                                                                  | Comma-delimited fields to return                                                                    |


### Response

**[GetAtsDocumentResponse](../../Models/Requests/GetAtsDocumentResponse.md)**


## ListAtsDocuments

List all documents

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAtsDocumentsRequest req = new ListAtsDocumentsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Document.ListAtsDocumentsAsync(
    security: new ListAtsDocumentsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListAtsDocumentsRequest](../../Models/Requests/ListAtsDocumentsRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListAtsDocumentsSecurity](../../Models/Requests/ListAtsDocumentsSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListAtsDocumentsResponse](../../Models/Requests/ListAtsDocumentsResponse.md)**


## PatchAtsDocument

Update a document

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Document.PatchAtsDocumentAsync(
    security: new PatchAtsDocumentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsDocument: new AtsDocument() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.PatchAtsDocumentSecurity](../../Models/Requests/PatchAtsDocumentSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Document                                                                                      |
| `AtsDocument`                                                                                           | [AtsDocument](../../Models/Components/AtsDocument.md)                                                   | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |


### Response

**[PatchAtsDocumentResponse](../../Models/Requests/PatchAtsDocumentResponse.md)**


## RemoveAtsDocument

Remove a document

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Document.RemoveAtsDocumentAsync(
    security: new RemoveAtsDocumentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.RemoveAtsDocumentSecurity](../../Models/Requests/RemoveAtsDocumentSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Document                                                                                        |


### Response

**[RemoveAtsDocumentResponse](../../Models/Requests/RemoveAtsDocumentResponse.md)**


## UpdateAtsDocument

Update a document

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Document.UpdateAtsDocumentAsync(
    security: new UpdateAtsDocumentSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsDocument: new AtsDocument() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.UpdateAtsDocumentSecurity](../../Models/Requests/UpdateAtsDocumentSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Document                                                                                        |
| `AtsDocument`                                                                                             | [AtsDocument](../../Models/Components/AtsDocument.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[UpdateAtsDocumentResponse](../../Models/Requests/UpdateAtsDocumentResponse.md)**

