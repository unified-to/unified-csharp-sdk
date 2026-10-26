# Space

## Overview

### Available Operations

* [CreateKmsSpace](#createkmsspace) - Create a space
* [GetKmsSpace](#getkmsspace) - Retrieve a space
* [ListKmsSpaces](#listkmsspaces) - List all spaces
* [PatchKmsSpace](#patchkmsspace) - Update a space
* [RemoveKmsSpace](#removekmsspace) - Remove a space
* [UpdateKmsSpace](#updatekmsspace) - Update a space

## CreateKmsSpace

Creates a KmsSpace. Provide the unified KmsSpace fields in the request body; they are mapped to the provider's API. Returns the created KmsSpace.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createKmsSpace" method="post" path="/kms/{connection_id}/space" example="kms_space" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Space.CreateKmsSpaceAsync(
    kmsSpace: new KmsSpace() {
        CreatedAt = System.DateTime.Parse("2022-10-31T00:56:54.246Z").ToUniversalTime(),
        Description = "Acer.",
        Id = "af87ba29-66ed-41ff-875a-d136ebaeb78c",
        IsActive = false,
        Metadata = new List<KmsPageMetadata>() {},
        Name = "into nor afore",
        UpdatedAt = System.DateTime.Parse("2026-01-02T20:51:07.837Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `KmsSpace`                                                                                                                                       | [KmsSpace](../../Models/Components/KmsSpace.md)                                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateKmsSpaceQueryParamFields](../../Models/Requests/CreateKmsSpaceQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateKmsSpaceResponse](../../Models/Requests/CreateKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetKmsSpace

Retrieves a single KmsSpace by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getKmsSpace" method="get" path="/kms/{connection_id}/space/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Space.GetKmsSpaceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Space                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetKmsSpaceQueryParamFields](../../Models/Requests/GetKmsSpaceQueryParamFields.md)>                                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetKmsSpaceResponse](../../Models/Requests/GetKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListKmsSpaces

Returns a list of KmsSpaces. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listKmsSpaces" method="get" path="/kms/{connection_id}/space" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListKmsSpacesRequest req = new ListKmsSpacesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Space.ListKmsSpacesAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListKmsSpacesRequest](../../Models/Requests/ListKmsSpacesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListKmsSpacesResponse](../../Models/Requests/ListKmsSpacesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchKmsSpace

Updates the KmsSpace identified by `id`. Provide the unified KmsSpace fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchKmsSpace" method="patch" path="/kms/{connection_id}/space/{id}" example="kms_space" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchKmsSpaceRequest req = new PatchKmsSpaceRequest() {
    KmsSpace = new KmsSpace() {
        CreatedAt = System.DateTime.Parse("2022-10-31T00:56:54.246Z").ToUniversalTime(),
        Description = "Acer.",
        Id = "740ba1cc-e195-4054-ab89-020824b3e9db",
        IsActive = false,
        Metadata = new List<KmsPageMetadata>() {},
        Name = "into nor afore",
        UpdatedAt = System.DateTime.Parse("2026-01-02T20:51:07.848Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Space.PatchKmsSpaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [PatchKmsSpaceRequest](../../Models/Requests/PatchKmsSpaceRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[PatchKmsSpaceResponse](../../Models/Requests/PatchKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveKmsSpace

Deletes the KmsSpace identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeKmsSpace" method="delete" path="/kms/{connection_id}/space/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Space.RemoveKmsSpaceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Space      |

### Response

**[RemoveKmsSpaceResponse](../../Models/Requests/RemoveKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateKmsSpace

Updates the KmsSpace identified by `id`. Provide the unified KmsSpace fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateKmsSpace" method="put" path="/kms/{connection_id}/space/{id}" example="kms_space" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateKmsSpaceRequest req = new UpdateKmsSpaceRequest() {
    KmsSpace = new KmsSpace() {
        CreatedAt = System.DateTime.Parse("2022-10-31T00:56:54.246Z").ToUniversalTime(),
        Description = "Acer.",
        Id = "740ba1cc-e195-4054-ab89-020824b3e9db",
        IsActive = false,
        Metadata = new List<KmsPageMetadata>() {},
        Name = "into nor afore",
        UpdatedAt = System.DateTime.Parse("2026-01-02T20:51:07.848Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Space.UpdateKmsSpaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateKmsSpaceRequest](../../Models/Requests/UpdateKmsSpaceRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdateKmsSpaceResponse](../../Models/Requests/UpdateKmsSpaceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |