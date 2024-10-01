# Group
(*Group*)

## Overview

### Available Operations

* [CreateHrisGroup](#createhrisgroup) - Create a group
* [GetHrisGroup](#gethrisgroup) - Retrieve a group
* [ListHrisGroups](#listhrisgroups) - List all groups
* [PatchHrisGroup](#patchhrisgroup) - Update a group
* [RemoveHrisGroup](#removehrisgroup) - Remove a group
* [UpdateHrisGroup](#updatehrisgroup) - Update a group

## CreateHrisGroup

Create a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Group.CreateHrisGroupAsync(
    connectionId: "<id>",
    hrisGroup: new HrisGroup() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |

### Response

**[CreateHrisGroupResponse](../../Models/Requests/CreateHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisGroup

Retrieve a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Group.GetHrisGroupAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Group                  |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetHrisGroupResponse](../../Models/Requests/GetHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisGroups

List all groups

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisGroupsRequest req = new ListHrisGroupsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Group.ListHrisGroupsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListHrisGroupsRequest](../../Models/Requests/ListHrisGroupsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListHrisGroupsResponse](../../Models/Requests/ListHrisGroupsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisGroup

Update a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Group.PatchHrisGroupAsync(
    connectionId: "<id>",
    id: "<id>",
    hrisGroup: new HrisGroup() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Group                                   |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |

### Response

**[PatchHrisGroupResponse](../../Models/Requests/PatchHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisGroup

Remove a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Group.RemoveHrisGroupAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Group      |

### Response

**[RemoveHrisGroupResponse](../../Models/Requests/RemoveHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisGroup

Update a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Group.UpdateHrisGroupAsync(
    connectionId: "<id>",
    id: "<id>",
    hrisGroup: new HrisGroup() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Group                                   |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |

### Response

**[UpdateHrisGroupResponse](../../Models/Requests/UpdateHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |