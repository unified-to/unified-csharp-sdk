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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Document.CreateAtsDocumentAsync(ConnectionId: "string", AtsDocument: new AtsDocument() {
    Raw = new PropertyAtsDocumentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `AtsDocument`                                         | [AtsDocument](../../Models/Components/AtsDocument.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreateAtsDocumentResponse](../../Models/Requests/CreateAtsDocumentResponse.md)**


## GetAtsDocument

Retrieve a document

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

var res = await sdk.Document.GetAtsDocumentAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Document               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsDocumentResponse](../../Models/Requests/GetAtsDocumentResponse.md)**


## ListAtsDocuments

List all documents

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

ListAtsDocumentsRequest req = new ListAtsDocumentsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Document.ListAtsDocumentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAtsDocumentsRequest](../../Models/Requests/ListAtsDocumentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListAtsDocumentsResponse](../../Models/Requests/ListAtsDocumentsResponse.md)**


## PatchAtsDocument

Update a document

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Document.PatchAtsDocumentAsync(ConnectionId: "string", Id: "string", AtsDocument: new AtsDocument() {
    Raw = new PropertyAtsDocumentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Document                                    |
| `AtsDocument`                                         | [AtsDocument](../../Models/Components/AtsDocument.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchAtsDocumentResponse](../../Models/Requests/PatchAtsDocumentResponse.md)**


## RemoveAtsDocument

Remove a document

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Document.RemoveAtsDocumentAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |


### Response

**[RemoveAtsDocumentResponse](../../Models/Requests/RemoveAtsDocumentResponse.md)**


## UpdateAtsDocument

Update a document

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Document.UpdateAtsDocumentAsync(ConnectionId: "string", Id: "string", AtsDocument: new AtsDocument() {
    Raw = new PropertyAtsDocumentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Document                                    |
| `AtsDocument`                                         | [AtsDocument](../../Models/Components/AtsDocument.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdateAtsDocumentResponse](../../Models/Requests/UpdateAtsDocumentResponse.md)**

