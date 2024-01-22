# Group
(*Group*)

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
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Group.CreateHrisGroupAsync(ConnectionId: "string", HrisGroup: new HrisGroup() {
    ManagerIds = new List<string>() {
        "string",
    },
    Raw = new PropertyHrisGroupRaw() {},
    UserIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |


### Response

**[CreateHrisGroupResponse](../../Models/Requests/CreateHrisGroupResponse.md)**


## GetHrisGroup

Retrieve a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Group.GetHrisGroupAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

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


## ListHrisGroups

List all groups

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListHrisGroupsRequest req = new ListHrisGroupsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
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


## PatchHrisGroup

Update a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Group.PatchHrisGroupAsync(ConnectionId: "string", Id: "string", HrisGroup: new HrisGroup() {
    ManagerIds = new List<string>() {
        "string",
    },
    Raw = new PropertyHrisGroupRaw() {},
    UserIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Group                                   |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |


### Response

**[PatchHrisGroupResponse](../../Models/Requests/PatchHrisGroupResponse.md)**


## RemoveHrisGroup

Remove a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Group.RemoveHrisGroupAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Group      |


### Response

**[RemoveHrisGroupResponse](../../Models/Requests/RemoveHrisGroupResponse.md)**


## UpdateHrisGroup

Update a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Group.UpdateHrisGroupAsync(ConnectionId: "string", Id: "string", HrisGroup: new HrisGroup() {
    ManagerIds = new List<string>() {
        "string",
    },
    Raw = new PropertyHrisGroupRaw() {},
    UserIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Group                                   |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |


### Response

**[UpdateHrisGroupResponse](../../Models/Requests/UpdateHrisGroupResponse.md)**

