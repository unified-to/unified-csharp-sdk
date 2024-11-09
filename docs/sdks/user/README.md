# User
(*User*)

## Overview

### Available Operations

* [CreateScimUsers](#createscimusers) - Create user
* [GetScimUsers](#getscimusers) - Get user
* [ListScimUsers](#listscimusers) - List users
* [PatchScimUsers](#patchscimusers) - Update user
* [RemoveScimUsers](#removescimusers) - Delete user
* [UpdateScimUsers](#updatescimusers) - Update user

## CreateScimUsers

Create user

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

CreateScimUsersRequest req = new CreateScimUsersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.User.CreateScimUsersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateScimUsersRequest](../../Models/Requests/CreateScimUsersRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[CreateScimUsersResponse](../../Models/Requests/CreateScimUsersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetScimUsers

Get user

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.User.GetScimUsersAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the User       |

### Response

**[GetScimUsersResponse](../../Models/Requests/GetScimUsersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListScimUsers

List users

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListScimUsersRequest req = new ListScimUsersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.User.ListScimUsersAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListScimUsersRequest](../../Models/Requests/ListScimUsersRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListScimUsersResponse](../../Models/Requests/ListScimUsersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchScimUsers

Update user

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.User.PatchScimUsersAsync(
    connectionId: "<id>",
    id: "<id>",
    scimUser: new ScimUser() {}
);

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Id`                                            | *string*                                        | :heavy_check_mark:                              | ID of the User                                  |
| `ScimUser`                                      | [ScimUser](../../Models/Components/ScimUser.md) | :heavy_minus_sign:                              | N/A                                             |

### Response

**[PatchScimUsersResponse](../../Models/Requests/PatchScimUsersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveScimUsers

Delete user

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.User.RemoveScimUsersAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the User       |

### Response

**[RemoveScimUsersResponse](../../Models/Requests/RemoveScimUsersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateScimUsers

Update user

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.User.UpdateScimUsersAsync(
    connectionId: "<id>",
    id: "<id>",
    scimUser: new ScimUser() {}
);

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Id`                                            | *string*                                        | :heavy_check_mark:                              | ID of the User                                  |
| `ScimUser`                                      | [ScimUser](../../Models/Components/ScimUser.md) | :heavy_minus_sign:                              | N/A                                             |

### Response

**[UpdateScimUsersResponse](../../Models/Requests/UpdateScimUsersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |