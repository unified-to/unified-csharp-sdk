# Snapshot

## Overview

### Available Operations

* [CreateComputeSnapshot](#createcomputesnapshot) - Create a snapshot
* [GetComputeSnapshot](#getcomputesnapshot) - Retrieve a snapshot
* [ListComputeSnapshots](#listcomputesnapshots) - List all snapshots
* [RemoveComputeSnapshot](#removecomputesnapshot) - Remove a snapshot

## CreateComputeSnapshot

Create a snapshot

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeSnapshot" method="post" path="/compute/{connection_id}/snapshot" example="compute_snapshot" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Snapshot.CreateComputeSnapshotAsync(
    computeSnapshot: new ComputeSnapshot() {
        CreatedAt = System.DateTime.Parse("2021-09-24T14:40:06.110Z").ToUniversalTime(),
        Id = "6ce71478-11d4-40f2-9224-60ecf5451b24",
        Metadata = new List<ComputeMetadata>() {},
        Name = "snap-alius",
        SizeMb = 169984D,
        Status = ComputeSnapshotStatus.Deleting,
        Type = ComputeSnapshotType.Disk,
        UpdatedAt = System.DateTime.Parse("2026-03-29T01:06:37.717Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ComputeSnapshot`                                                                                                                                | [ComputeSnapshot](../../Models/Components/ComputeSnapshot.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateComputeSnapshotQueryParamFields](../../Models/Requests/CreateComputeSnapshotQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateComputeSnapshotResponse](../../Models/Requests/CreateComputeSnapshotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetComputeSnapshot

Retrieve a snapshot

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeSnapshot" method="get" path="/compute/{connection_id}/snapshot/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Snapshot.GetComputeSnapshotAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Snapshot                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetComputeSnapshotQueryParamFields](../../Models/Requests/GetComputeSnapshotQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetComputeSnapshotResponse](../../Models/Requests/GetComputeSnapshotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListComputeSnapshots

List all snapshots

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeSnapshots" method="get" path="/compute/{connection_id}/snapshot" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListComputeSnapshotsRequest req = new ListComputeSnapshotsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Snapshot.ListComputeSnapshotsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListComputeSnapshotsRequest](../../Models/Requests/ListComputeSnapshotsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListComputeSnapshotsResponse](../../Models/Requests/ListComputeSnapshotsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveComputeSnapshot

Remove a snapshot

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeComputeSnapshot" method="delete" path="/compute/{connection_id}/snapshot/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Snapshot.RemoveComputeSnapshotAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Snapshot   |

### Response

**[RemoveComputeSnapshotResponse](../../Models/Requests/RemoveComputeSnapshotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |