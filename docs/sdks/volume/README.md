# Volume

## Overview

### Available Operations

* [CreateComputeVolume](#createcomputevolume) - Create a volume
* [GetComputeVolume](#getcomputevolume) - Retrieve a volume
* [ListComputeVolumes](#listcomputevolumes) - List all volumes
* [PatchComputeVolume](#patchcomputevolume) - Update a volume
* [RemoveComputeVolume](#removecomputevolume) - Remove a volume
* [UpdateComputeVolume](#updatecomputevolume) - Update a volume

## CreateComputeVolume

Creates a ComputeVolume. Provide the unified ComputeVolume fields in the request body; they are mapped to the provider's API. Returns the created ComputeVolume.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeVolume" method="post" path="/compute/{connection_id}/volume" example="compute_volume" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Volume.CreateComputeVolumeAsync(
    computeVolume: new ComputeVolume() {
        CreatedAt = System.DateTime.Parse("2022-11-15T15:12:48.055Z").ToUniversalTime(),
        Id = "3fadf850-f9fb-4b4f-bfad-d5769b208496",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-12T07:39:35.773Z").ToUniversalTime(),
        UsedMb = 524986D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeVolume`                                                                                                                                  | [ComputeVolume](../../Models/Components/ComputeVolume.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeVolumeQueryParamFields](../../Models/Requests/CreateComputeVolumeQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeVolumeResponse](../../Models/Requests/CreateComputeVolumeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeVolume

Retrieves a single ComputeVolume by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeVolume" method="get" path="/compute/{connection_id}/volume/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Volume.GetComputeVolumeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Volume                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetComputeVolumeQueryParamFields](../../Models/Requests/GetComputeVolumeQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeVolumeResponse](../../Models/Requests/GetComputeVolumeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeVolumes

Returns a list of ComputeVolumes. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeVolumes" method="get" path="/compute/{connection_id}/volume" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeVolumesRequest req = new ListComputeVolumesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Volume.ListComputeVolumesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListComputeVolumesRequest](../../Models/Requests/ListComputeVolumesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListComputeVolumesResponse](../../Models/Requests/ListComputeVolumesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchComputeVolume

Updates the ComputeVolume identified by `id`. Provide the unified ComputeVolume fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchComputeVolume" method="patch" path="/compute/{connection_id}/volume/{id}" example="compute_volume" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchComputeVolumeRequest req = new PatchComputeVolumeRequest() {
    ComputeVolume = new ComputeVolume() {
        CreatedAt = System.DateTime.Parse("2022-11-15T15:12:48.055Z").ToUniversalTime(),
        Id = "cdca16d4-6492-432b-8765-83c2e83d79cc",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-12T07:39:35.778Z").ToUniversalTime(),
        UsedMb = 524986D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Volume.PatchComputeVolumeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchComputeVolumeRequest](../../Models/Requests/PatchComputeVolumeRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchComputeVolumeResponse](../../Models/Requests/PatchComputeVolumeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeVolume

Deletes the ComputeVolume identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeVolume" method="delete" path="/compute/{connection_id}/volume/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Volume.RemoveComputeVolumeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Volume     |

### Response

**[RemoveComputeVolumeResponse](../../Models/Requests/RemoveComputeVolumeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateComputeVolume

Updates the ComputeVolume identified by `id`. Provide the unified ComputeVolume fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateComputeVolume" method="put" path="/compute/{connection_id}/volume/{id}" example="compute_volume" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateComputeVolumeRequest req = new UpdateComputeVolumeRequest() {
    ComputeVolume = new ComputeVolume() {
        CreatedAt = System.DateTime.Parse("2022-11-15T15:12:48.055Z").ToUniversalTime(),
        Id = "cdca16d4-6492-432b-8765-83c2e83d79cc",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-12T07:39:35.778Z").ToUniversalTime(),
        UsedMb = 524986D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Volume.UpdateComputeVolumeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateComputeVolumeRequest](../../Models/Requests/UpdateComputeVolumeRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateComputeVolumeResponse](../../Models/Requests/UpdateComputeVolumeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |