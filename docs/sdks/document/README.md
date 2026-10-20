# Document

## Overview

### Available Operations

* [CreateAtsDocument](#createatsdocument) - Create a document
* [CreateHrisDocument](#createhrisdocument) - Create a document
* [CreateSigningDocument](#createsigningdocument) - Create a document
* [GetAtsDocument](#getatsdocument) - Retrieve a document
* [GetHrisDocument](#gethrisdocument) - Retrieve a document
* [GetSigningDocument](#getsigningdocument) - Retrieve a document
* [ListAtsDocuments](#listatsdocuments) - List all documents
* [ListHrisDocuments](#listhrisdocuments) - List all documents
* [ListSigningDocuments](#listsigningdocuments) - List all documents
* [PatchAtsDocument](#patchatsdocument) - Update a document
* [PatchHrisDocument](#patchhrisdocument) - Update a document
* [PatchSigningDocument](#patchsigningdocument) - Update a document
* [RemoveAtsDocument](#removeatsdocument) - Remove a document
* [RemoveHrisDocument](#removehrisdocument) - Remove a document
* [RemoveSigningDocument](#removesigningdocument) - Remove a document
* [UpdateAtsDocument](#updateatsdocument) - Update a document
* [UpdateHrisDocument](#updatehrisdocument) - Update a document
* [UpdateSigningDocument](#updatesigningdocument) - Update a document

## CreateAtsDocument

Create a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsDocument" method="post" path="/ats/{connection_id}/document" example="ats_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.CreateAtsDocumentAsync(
    atsDocument: new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "lonzo_schowalter_resume.pdf",
        Id = "8c3d864b-9921-4c29-a188-1be34b1166a3",
        Metadata = new List<AtsMetadata>() {},
        Type = AtsDocumentType.CoverLetter,
        UpdatedAt = System.DateTime.Parse("2022-12-06T21:42:48.538Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsDocument`                                                                                                                                    | [AtsDocument](../../Models/Components/AtsDocument.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsDocumentQueryParamFields](../../Models/Requests/CreateAtsDocumentQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsDocumentResponse](../../Models/Requests/CreateAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisDocument

Create a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisDocument" method="post" path="/hris/{connection_id}/document" example="hris_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.CreateHrisDocumentAsync(
    hrisDocument: new HrisDocument() {
        CreatedAt = System.DateTime.Parse("2022-10-27T11:47:26.086Z").ToUniversalTime(),
        DocumentUrl = "https://sore-decision.biz/",
        Filename = "ridge_forager.xsl",
        Id = "e78a52b0-b0ef-474d-b28a-a175f51451f3",
        Metadata = new List<HrisMetadata>() {},
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-10-10T16:33:05.270Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDocument`                                                                                                                                   | [HrisDocument](../../Models/Components/HrisDocument.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDocumentQueryParamFields](../../Models/Requests/CreateHrisDocumentQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDocumentResponse](../../Models/Requests/CreateHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateSigningDocument

Create a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSigningDocument" method="post" path="/signing/{connection_id}/document" example="signing_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.CreateSigningDocumentAsync(
    signingDocument: new SigningDocument() {
        CreatedAt = System.DateTime.Parse("2021-05-02T09:35:23.679Z").ToUniversalTime(),
        Description = "Aer asporto caste umbra coerceo anser color allatus aestas perspiciatis.",
        ExpiresAt = System.DateTime.Parse("2021-06-04T01:21:34.949Z").ToUniversalTime(),
        Id = "8a1086ca-7b30-4414-a38c-aa2627a82f02",
        Metadata = new List<SigningMetadata>() {},
        Name = "Denesik Group NDA",
        SentAt = System.DateTime.Parse("2022-06-29T05:57:10.503Z").ToUniversalTime(),
        Status = SigningDocumentStatus.Draft,
        UpdatedAt = System.DateTime.Parse("2025-09-01T23:27:38.390Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SigningDocument`                                                                                                                                | [SigningDocument](../../Models/Components/SigningDocument.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateSigningDocumentQueryParamFields](../../Models/Requests/CreateSigningDocumentQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateSigningDocumentResponse](../../Models/Requests/CreateSigningDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsDocument

Retrieve a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsDocument" method="get" path="/ats/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.GetAtsDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Document                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetAtsDocumentQueryParamFields](../../Models/Requests/GetAtsDocumentQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsDocumentResponse](../../Models/Requests/GetAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDocument

Retrieve a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisDocument" method="get" path="/hris/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.GetHrisDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Document                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHrisDocumentQueryParamFields](../../Models/Requests/GetHrisDocumentQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDocumentResponse](../../Models/Requests/GetHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetSigningDocument

Retrieve a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSigningDocument" method="get" path="/signing/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.GetSigningDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Document                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetSigningDocumentQueryParamFields](../../Models/Requests/GetSigningDocumentQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSigningDocumentResponse](../../Models/Requests/GetSigningDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsDocuments

List all documents

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsDocuments" method="get" path="/ats/{connection_id}/document" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsDocumentsRequest req = new ListAtsDocumentsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDocuments

List all documents

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisDocuments" method="get" path="/hris/{connection_id}/document" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDocumentsRequest req = new ListHrisDocumentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Document.ListHrisDocumentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisDocumentsRequest](../../Models/Requests/ListHrisDocumentsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisDocumentsResponse](../../Models/Requests/ListHrisDocumentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListSigningDocuments

List all documents

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSigningDocuments" method="get" path="/signing/{connection_id}/document" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSigningDocumentsRequest req = new ListSigningDocumentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Document.ListSigningDocumentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListSigningDocumentsRequest](../../Models/Requests/ListSigningDocumentsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListSigningDocumentsResponse](../../Models/Requests/ListSigningDocumentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsDocument" method="patch" path="/ats/{connection_id}/document/{id}" example="ats_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsDocumentRequest req = new PatchAtsDocumentRequest() {
    AtsDocument = new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "lonzo_schowalter_resume.pdf",
        Id = "df326b4d-c94a-4a39-bb57-cd04b3cd16df",
        Metadata = new List<AtsMetadata>() {},
        Type = AtsDocumentType.CoverLetter,
        UpdatedAt = System.DateTime.Parse("2022-12-06T21:42:48.542Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Document.PatchAtsDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchAtsDocumentRequest](../../Models/Requests/PatchAtsDocumentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchAtsDocumentResponse](../../Models/Requests/PatchAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisDocument" method="patch" path="/hris/{connection_id}/document/{id}" example="hris_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDocumentRequest req = new PatchHrisDocumentRequest() {
    HrisDocument = new HrisDocument() {
        CreatedAt = System.DateTime.Parse("2022-10-27T11:47:26.086Z").ToUniversalTime(),
        DocumentUrl = "https://sore-decision.biz/",
        Filename = "ridge_forager.xsl",
        Id = "280e0bfa-2cc9-43e0-b278-6301912522d1",
        Metadata = new List<HrisMetadata>() {},
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-10-10T16:33:05.278Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Document.PatchHrisDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchHrisDocumentRequest](../../Models/Requests/PatchHrisDocumentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchHrisDocumentResponse](../../Models/Requests/PatchHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchSigningDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchSigningDocument" method="patch" path="/signing/{connection_id}/document/{id}" example="signing_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchSigningDocumentRequest req = new PatchSigningDocumentRequest() {
    SigningDocument = new SigningDocument() {
        CreatedAt = System.DateTime.Parse("2021-05-02T09:35:23.679Z").ToUniversalTime(),
        Description = "Aer asporto caste umbra coerceo anser color allatus aestas perspiciatis.",
        ExpiresAt = System.DateTime.Parse("2021-06-04T01:21:34.949Z").ToUniversalTime(),
        Id = "2b926e3c-46e3-4434-a92e-0df7b0817610",
        Metadata = new List<SigningMetadata>() {},
        Name = "Denesik Group NDA",
        SentAt = System.DateTime.Parse("2022-06-29T05:57:10.506Z").ToUniversalTime(),
        Status = SigningDocumentStatus.Draft,
        UpdatedAt = System.DateTime.Parse("2025-09-01T23:27:38.404Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Document.PatchSigningDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchSigningDocumentRequest](../../Models/Requests/PatchSigningDocumentRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchSigningDocumentResponse](../../Models/Requests/PatchSigningDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsDocument

Remove a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsDocument" method="delete" path="/ats/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.RemoveAtsDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |

### Response

**[RemoveAtsDocumentResponse](../../Models/Requests/RemoveAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDocument

Remove a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisDocument" method="delete" path="/hris/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.RemoveHrisDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |

### Response

**[RemoveHrisDocumentResponse](../../Models/Requests/RemoveHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveSigningDocument

Remove a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeSigningDocument" method="delete" path="/signing/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Document.RemoveSigningDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |

### Response

**[RemoveSigningDocumentResponse](../../Models/Requests/RemoveSigningDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsDocument" method="put" path="/ats/{connection_id}/document/{id}" example="ats_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsDocumentRequest req = new UpdateAtsDocumentRequest() {
    AtsDocument = new AtsDocument() {
        CreatedAt = System.DateTime.Parse("2021-08-20T08:00:27.437Z").ToUniversalTime(),
        DocumentUrl = "https://vengeful-lashes.biz",
        Filename = "lonzo_schowalter_resume.pdf",
        Id = "df326b4d-c94a-4a39-bb57-cd04b3cd16df",
        Metadata = new List<AtsMetadata>() {},
        Type = AtsDocumentType.CoverLetter,
        UpdatedAt = System.DateTime.Parse("2022-12-06T21:42:48.542Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Document.UpdateAtsDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateAtsDocumentRequest](../../Models/Requests/UpdateAtsDocumentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateAtsDocumentResponse](../../Models/Requests/UpdateAtsDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisDocument" method="put" path="/hris/{connection_id}/document/{id}" example="hris_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDocumentRequest req = new UpdateHrisDocumentRequest() {
    HrisDocument = new HrisDocument() {
        CreatedAt = System.DateTime.Parse("2022-10-27T11:47:26.086Z").ToUniversalTime(),
        DocumentUrl = "https://sore-decision.biz/",
        Filename = "ridge_forager.xsl",
        Id = "280e0bfa-2cc9-43e0-b278-6301912522d1",
        Metadata = new List<HrisMetadata>() {},
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-10-10T16:33:05.278Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Document.UpdateHrisDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateHrisDocumentRequest](../../Models/Requests/UpdateHrisDocumentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateHrisDocumentResponse](../../Models/Requests/UpdateHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateSigningDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSigningDocument" method="put" path="/signing/{connection_id}/document/{id}" example="signing_document" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateSigningDocumentRequest req = new UpdateSigningDocumentRequest() {
    SigningDocument = new SigningDocument() {
        CreatedAt = System.DateTime.Parse("2021-05-02T09:35:23.679Z").ToUniversalTime(),
        Description = "Aer asporto caste umbra coerceo anser color allatus aestas perspiciatis.",
        ExpiresAt = System.DateTime.Parse("2021-06-04T01:21:34.949Z").ToUniversalTime(),
        Id = "2b926e3c-46e3-4434-a92e-0df7b0817610",
        Metadata = new List<SigningMetadata>() {},
        Name = "Denesik Group NDA",
        SentAt = System.DateTime.Parse("2022-06-29T05:57:10.506Z").ToUniversalTime(),
        Status = SigningDocumentStatus.Draft,
        UpdatedAt = System.DateTime.Parse("2025-09-01T23:27:38.404Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Document.UpdateSigningDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateSigningDocumentRequest](../../Models/Requests/UpdateSigningDocumentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateSigningDocumentResponse](../../Models/Requests/UpdateSigningDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |