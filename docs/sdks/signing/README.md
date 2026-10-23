# Signing

## Overview

### Available Operations

* [CreateSigningDocument](#createsigningdocument) - Create a document
* [CreateSigningSignatory](#createsigningsignatory) - Create a signatory
* [GetSigningDocument](#getsigningdocument) - Retrieve a document
* [GetSigningSignatory](#getsigningsignatory) - Retrieve a signatory
* [GetSigningTemplate](#getsigningtemplate) - Retrieve a template
* [ListSigningDocuments](#listsigningdocuments) - List all documents
* [ListSigningSignatories](#listsigningsignatories) - List all signatories
* [ListSigningTemplates](#listsigningtemplates) - List all templates
* [PatchSigningDocument](#patchsigningdocument) - Update a document
* [PatchSigningSignatory](#patchsigningsignatory) - Update a signatory
* [RemoveSigningDocument](#removesigningdocument) - Remove a document
* [RemoveSigningSignatory](#removesigningsignatory) - Remove a signatory
* [UpdateSigningDocument](#updatesigningdocument) - Update a document
* [UpdateSigningSignatory](#updatesigningsignatory) - Update a signatory

## CreateSigningDocument

Creates a SigningDocument. Provide the unified SigningDocument fields in the request body; they are mapped to the provider's API. Returns the created SigningDocument.

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

var res = await sdk.Signing.CreateSigningDocumentAsync(
    signingDocument: new SigningDocument() {
        CreatedAt = System.DateTime.Parse("2021-05-02T09:35:23.679Z").ToUniversalTime(),
        Description = "Aer asporto caste umbra coerceo anser color allatus aestas perspiciatis.",
        ExpiresAt = System.DateTime.Parse("2021-06-04T01:21:34.949Z").ToUniversalTime(),
        Id = "b30f4eaa-7b1e-4d31-9e16-b4f7d79da58b",
        Metadata = new List<SigningMetadata>() {},
        Name = "Denesik Group NDA",
        SentAt = System.DateTime.Parse("2022-06-29T22:19:33.511Z").ToUniversalTime(),
        Status = SigningDocumentStatus.Draft,
        UpdatedAt = System.DateTime.Parse("2025-09-04T12:46:41.416Z").ToUniversalTime(),
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

## CreateSigningSignatory

Creates a SigningSignatory. Provide the unified SigningSignatory fields in the request body; they are mapped to the provider's API. Returns the created SigningSignatory.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSigningSignatory" method="post" path="/signing/{connection_id}/signatory" example="signing_signatory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Signing.CreateSigningSignatoryAsync(
    signingSignatory: new SigningSignatory() {
        CreatedAt = System.DateTime.Parse("2022-04-16T19:25:01.966Z").ToUniversalTime(),
        Email = "anais.lakin@icloud.com",
        Id = "9611225b-6f3b-4003-ae5c-43afd0def715",
        Metadata = new List<SigningMetadata>() {},
        Name = "Anais Lakin",
        Role = SigningSignatoryRole.Signer,
        Status = SigningSignatoryStatus.Error,
        UpdatedAt = System.DateTime.Parse("2024-05-18T18:17:10.385Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SigningSignatory`                                                                                                                               | [SigningSignatory](../../Models/Components/SigningSignatory.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateSigningSignatoryQueryParamFields](../../Models/Requests/CreateSigningSignatoryQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateSigningSignatoryResponse](../../Models/Requests/CreateSigningSignatoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetSigningDocument

Retrieves a single SigningDocument by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSigningDocument" method="get" path="/signing/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Signing.GetSigningDocumentAsync(
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

## GetSigningSignatory

Retrieves a single SigningSignatory by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSigningSignatory" method="get" path="/signing/{connection_id}/signatory/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Signing.GetSigningSignatoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Signatory                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetSigningSignatoryQueryParamFields](../../Models/Requests/GetSigningSignatoryQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSigningSignatoryResponse](../../Models/Requests/GetSigningSignatoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetSigningTemplate

Retrieves a single SigningTemplate by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSigningTemplate" method="get" path="/signing/{connection_id}/template/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Signing.GetSigningTemplateAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Template                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetSigningTemplateQueryParamFields](../../Models/Requests/GetSigningTemplateQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSigningTemplateResponse](../../Models/Requests/GetSigningTemplateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListSigningDocuments

Returns a list of SigningDocuments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Signing.ListSigningDocumentsAsync(req);

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

## ListSigningSignatories

Returns a list of SigningSignatories. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSigningSignatories" method="get" path="/signing/{connection_id}/signatory" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSigningSignatoriesRequest req = new ListSigningSignatoriesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Signing.ListSigningSignatoriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListSigningSignatoriesRequest](../../Models/Requests/ListSigningSignatoriesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListSigningSignatoriesResponse](../../Models/Requests/ListSigningSignatoriesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListSigningTemplates

Returns a list of SigningTemplates. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSigningTemplates" method="get" path="/signing/{connection_id}/template" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSigningTemplatesRequest req = new ListSigningTemplatesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Signing.ListSigningTemplatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListSigningTemplatesRequest](../../Models/Requests/ListSigningTemplatesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListSigningTemplatesResponse](../../Models/Requests/ListSigningTemplatesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchSigningDocument

Updates the SigningDocument identified by `id`. Provide the unified SigningDocument fields to change in the request body.

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
        Id = "11edaa29-95d0-4507-9cc3-95e589b3c6e9",
        Metadata = new List<SigningMetadata>() {},
        Name = "Denesik Group NDA",
        SentAt = System.DateTime.Parse("2022-06-29T22:19:33.516Z").ToUniversalTime(),
        Status = SigningDocumentStatus.Draft,
        UpdatedAt = System.DateTime.Parse("2025-09-04T12:46:41.434Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Signing.PatchSigningDocumentAsync(req);

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

## PatchSigningSignatory

Updates the SigningSignatory identified by `id`. Provide the unified SigningSignatory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchSigningSignatory" method="patch" path="/signing/{connection_id}/signatory/{id}" example="signing_signatory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchSigningSignatoryRequest req = new PatchSigningSignatoryRequest() {
    SigningSignatory = new SigningSignatory() {
        CreatedAt = System.DateTime.Parse("2022-04-16T19:25:01.966Z").ToUniversalTime(),
        Email = "anais.lakin@icloud.com",
        Id = "f9a59469-5062-4696-b75d-2405530fc292",
        Metadata = new List<SigningMetadata>() {},
        Name = "Anais Lakin",
        Role = SigningSignatoryRole.Signer,
        Status = SigningSignatoryStatus.Error,
        UpdatedAt = System.DateTime.Parse("2024-05-18T18:17:10.391Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Signing.PatchSigningSignatoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchSigningSignatoryRequest](../../Models/Requests/PatchSigningSignatoryRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchSigningSignatoryResponse](../../Models/Requests/PatchSigningSignatoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveSigningDocument

Deletes the SigningDocument identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeSigningDocument" method="delete" path="/signing/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Signing.RemoveSigningDocumentAsync(
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

## RemoveSigningSignatory

Deletes the SigningSignatory identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeSigningSignatory" method="delete" path="/signing/{connection_id}/signatory/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Signing.RemoveSigningSignatoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Signatory  |

### Response

**[RemoveSigningSignatoryResponse](../../Models/Requests/RemoveSigningSignatoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateSigningDocument

Updates the SigningDocument identified by `id`. Provide the unified SigningDocument fields to change in the request body.

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
        Id = "11edaa29-95d0-4507-9cc3-95e589b3c6e9",
        Metadata = new List<SigningMetadata>() {},
        Name = "Denesik Group NDA",
        SentAt = System.DateTime.Parse("2022-06-29T22:19:33.516Z").ToUniversalTime(),
        Status = SigningDocumentStatus.Draft,
        UpdatedAt = System.DateTime.Parse("2025-09-04T12:46:41.434Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Signing.UpdateSigningDocumentAsync(req);

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

## UpdateSigningSignatory

Updates the SigningSignatory identified by `id`. Provide the unified SigningSignatory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSigningSignatory" method="put" path="/signing/{connection_id}/signatory/{id}" example="signing_signatory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateSigningSignatoryRequest req = new UpdateSigningSignatoryRequest() {
    SigningSignatory = new SigningSignatory() {
        CreatedAt = System.DateTime.Parse("2022-04-16T19:25:01.966Z").ToUniversalTime(),
        Email = "anais.lakin@icloud.com",
        Id = "f9a59469-5062-4696-b75d-2405530fc292",
        Metadata = new List<SigningMetadata>() {},
        Name = "Anais Lakin",
        Role = SigningSignatoryRole.Signer,
        Status = SigningSignatoryStatus.Error,
        UpdatedAt = System.DateTime.Parse("2024-05-18T18:17:10.391Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Signing.UpdateSigningSignatoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateSigningSignatoryRequest](../../Models/Requests/UpdateSigningSignatoryRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateSigningSignatoryResponse](../../Models/Requests/UpdateSigningSignatoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |