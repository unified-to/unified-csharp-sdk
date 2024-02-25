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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Group.CreateHrisGroupAsync(
    security: new CreateHrisGroupSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    hrisGroup: new HrisGroup() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.CreateHrisGroupSecurity](../../Models/Requests/CreateHrisGroupSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `HrisGroup`                                                                                           | [HrisGroup](../../Models/Components/HrisGroup.md)                                                     | :heavy_minus_sign:                                                                                    | N/A                                                                                                   |


### Response

**[CreateHrisGroupResponse](../../Models/Requests/CreateHrisGroupResponse.md)**


## GetHrisGroup

Retrieve a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Group.GetHrisGroupAsync(
    security: new GetHrisGroupSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.GetHrisGroupSecurity](../../Models/Requests/GetHrisGroupSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Group                                                                                 |
| `Fields`                                                                                        | List<*string*>                                                                                  | :heavy_minus_sign:                                                                              | Comma-delimited fields to return                                                                |


### Response

**[GetHrisGroupResponse](../../Models/Requests/GetHrisGroupResponse.md)**


## ListHrisGroups

List all groups

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListHrisGroupsRequest req = new ListHrisGroupsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Group.ListHrisGroupsAsync(
    security: new ListHrisGroupsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListHrisGroupsRequest](../../Models/Requests/ListHrisGroupsRequest.md)                             | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |
| `security`                                                                                          | [UnifiedTo.Models.Requests.ListHrisGroupsSecurity](../../Models/Requests/ListHrisGroupsSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |


### Response

**[ListHrisGroupsResponse](../../Models/Requests/ListHrisGroupsResponse.md)**


## PatchHrisGroup

Update a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Group.PatchHrisGroupAsync(
    security: new PatchHrisGroupSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    hrisGroup: new HrisGroup() {});

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.PatchHrisGroupSecurity](../../Models/Requests/PatchHrisGroupSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Group                                                                                     |
| `HrisGroup`                                                                                         | [HrisGroup](../../Models/Components/HrisGroup.md)                                                   | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |


### Response

**[PatchHrisGroupResponse](../../Models/Requests/PatchHrisGroupResponse.md)**


## RemoveHrisGroup

Remove a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Group.RemoveHrisGroupAsync(
    security: new RemoveHrisGroupSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.RemoveHrisGroupSecurity](../../Models/Requests/RemoveHrisGroupSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Group                                                                                       |


### Response

**[RemoveHrisGroupResponse](../../Models/Requests/RemoveHrisGroupResponse.md)**


## UpdateHrisGroup

Update a group

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Group.UpdateHrisGroupAsync(
    security: new UpdateHrisGroupSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    hrisGroup: new HrisGroup() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.UpdateHrisGroupSecurity](../../Models/Requests/UpdateHrisGroupSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Group                                                                                       |
| `HrisGroup`                                                                                           | [HrisGroup](../../Models/Components/HrisGroup.md)                                                     | :heavy_minus_sign:                                                                                    | N/A                                                                                                   |


### Response

**[UpdateHrisGroupResponse](../../Models/Requests/UpdateHrisGroupResponse.md)**

