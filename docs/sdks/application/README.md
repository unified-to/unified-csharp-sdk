# Application

## Overview

### Available Operations

* [CreateAtsApplication](#createatsapplication) - Create an application
* [GetAtsApplication](#getatsapplication) - Retrieve an application
* [ListAtsApplications](#listatsapplications) - List all applications
* [PatchAtsApplication](#patchatsapplication) - Update an application
* [RemoveAtsApplication](#removeatsapplication) - Remove an application
* [UpdateAtsApplication](#updateatsapplication) - Update an application

## CreateAtsApplication

Creates a AtsApplication. Provide the unified AtsApplication fields in the request body; they are mapped to the provider's API. Returns the created AtsApplication.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsApplication" method="post" path="/ats/{connection_id}/application" example="ats_application" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Application.CreateAtsApplicationAsync(
    atsApplication: new AtsApplication() {
        Answers = new List<AtsApplicationAnswer>() {},
        AppliedAt = System.DateTime.Parse("2025-10-02T23:13:47.341Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-16T23:10:43.465Z").ToUniversalTime(),
        Id = "1e03db79-ae42-4d7d-886a-81de81e58478",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "3ed41e35-45f8-4fb1-9594-da121c722126",
                Namespace = "application",
                Slug = "stella",
                Value = AtsMetadataValue.CreateStr(
                    "Caput."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-10-16T10:04:04.936Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Arguo repudiandae defessus. Adflicto caecus claustrum annus addo vere crebro. Alias sponte turbo sopor vergo surculus nam.",
        UpdatedAt = System.DateTime.Parse("2026-10-23T07:02:23.921Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsApplication`                                                                                                                                 | [AtsApplication](../../Models/Components/AtsApplication.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsApplicationQueryParamFields](../../Models/Requests/CreateAtsApplicationQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsApplicationResponse](../../Models/Requests/CreateAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsApplication

Retrieves a single AtsApplication by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsApplication" method="get" path="/ats/{connection_id}/application/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Application.GetAtsApplicationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Application                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetAtsApplicationQueryParamFields](../../Models/Requests/GetAtsApplicationQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsApplicationResponse](../../Models/Requests/GetAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsApplications

Returns a list of AtsApplications. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsApplications" method="get" path="/ats/{connection_id}/application" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsApplicationsRequest req = new ListAtsApplicationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Application.ListAtsApplicationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAtsApplicationsRequest](../../Models/Requests/ListAtsApplicationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListAtsApplicationsResponse](../../Models/Requests/ListAtsApplicationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsApplication

Updates the AtsApplication identified by `id`. Provide the unified AtsApplication fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsApplication" method="patch" path="/ats/{connection_id}/application/{id}" example="ats_application" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsApplicationRequest req = new PatchAtsApplicationRequest() {
    AtsApplication = new AtsApplication() {
        Answers = new List<AtsApplicationAnswer>() {},
        AppliedAt = System.DateTime.Parse("2025-10-02T23:13:47.363Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-16T23:10:43.494Z").ToUniversalTime(),
        Id = "345ebcf6-bcf3-4cb0-9d71-6bc3f662da2b",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "1d90018b-5d0f-42db-a2c9-759c910a4820",
                Namespace = "application",
                Slug = "stella",
                Value = AtsMetadataValue.CreateStr(
                    "Caput."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-10-16T10:04:04.970Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Arguo repudiandae defessus. Adflicto caecus claustrum annus addo vere crebro. Alias sponte turbo sopor vergo surculus nam.",
        UpdatedAt = System.DateTime.Parse("2026-10-23T07:02:23.955Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Application.PatchAtsApplicationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchAtsApplicationRequest](../../Models/Requests/PatchAtsApplicationRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchAtsApplicationResponse](../../Models/Requests/PatchAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsApplication

Deletes the AtsApplication identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsApplication" method="delete" path="/ats/{connection_id}/application/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Application.RemoveAtsApplicationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Application |

### Response

**[RemoveAtsApplicationResponse](../../Models/Requests/RemoveAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsApplication

Updates the AtsApplication identified by `id`. Provide the unified AtsApplication fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsApplication" method="put" path="/ats/{connection_id}/application/{id}" example="ats_application" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsApplicationRequest req = new UpdateAtsApplicationRequest() {
    AtsApplication = new AtsApplication() {
        Answers = new List<AtsApplicationAnswer>() {},
        AppliedAt = System.DateTime.Parse("2025-10-02T23:13:47.363Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-10-17T07:19:48.787Z").ToUniversalTime(),
        HiredAt = System.DateTime.Parse("2026-05-16T23:10:43.494Z").ToUniversalTime(),
        Id = "345ebcf6-bcf3-4cb0-9d71-6bc3f662da2b",
        Metadata = new List<AtsMetadata>() {
            new AtsMetadata() {
                ExtraData = AtsMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {

                    }
                ),
                Format = AtsMetadataFormat.Text,
                Id = "1d90018b-5d0f-42db-a2c9-759c910a4820",
                Namespace = "application",
                Slug = "stella",
                Value = AtsMetadataValue.CreateStr(
                    "Caput."
                ),
            },
        },
        Offers = new List<AtsOffer>() {},
        OriginalStatus = "vomica",
        OriginalSubstatus = "allatus",
        RejectedAt = System.DateTime.Parse("2026-10-16T10:04:04.970Z").ToUniversalTime(),
        RejectedReason = "Cometes amplitudo videlicet talio.",
        Source = "credo",
        Status = AtsApplicationStatus.Reviewing,
        Summary = "Arguo repudiandae defessus. Adflicto caecus claustrum annus addo vere crebro. Alias sponte turbo sopor vergo surculus nam.",
        UpdatedAt = System.DateTime.Parse("2026-10-23T07:02:23.955Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Application.UpdateAtsApplicationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateAtsApplicationRequest](../../Models/Requests/UpdateAtsApplicationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateAtsApplicationResponse](../../Models/Requests/UpdateAtsApplicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |