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

Create a volume

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
        Id = "86868beb-0c25-4172-8988-a683dda59805",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T23:15:38.087Z").ToUniversalTime(),
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

Retrieve a volume

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

List all volumes

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

Update a volume

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
        Id = "be973df4-27d2-429a-93bf-865701c1d0ee",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T23:15:38.092Z").ToUniversalTime(),
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

Remove a volume

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

Update a volume

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
        Id = "be973df4-27d2-429a-93bf-865701c1d0ee",
        InstanceIds = new List<string>() {},
        Metadata = new List<ComputeMetadata>() {},
        Name = "vol-solum",
        SizeMb = 1024000D,
        Status = ComputeVolumeStatus.Other,
        Type = ComputeVolumeType.HighPerformance,
        UpdatedAt = System.DateTime.Parse("2024-02-08T23:15:38.092Z").ToUniversalTime(),
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