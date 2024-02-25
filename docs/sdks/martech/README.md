# Martech
(*Martech*)

### Available Operations

* [CreateMartechList](#createmartechlist) - Create a list
* [CreateMartechMember](#createmartechmember) - Create a member
* [GetMartechList](#getmartechlist) - Retrieve a list
* [GetMartechMember](#getmartechmember) - Retrieve a member
* [ListMartechLists](#listmartechlists) - List all lists
* [ListMartechMembers](#listmartechmembers) - List all members
* [PatchMartechList](#patchmartechlist) - Update a list
* [PatchMartechMember](#patchmartechmember) - Update a member
* [RemoveMartechList](#removemartechlist) - Remove a list
* [RemoveMartechMember](#removemartechmember) - Remove member
* [UpdateMartechList](#updatemartechlist) - Update a list
* [UpdateMartechMember](#updatemartechmember) - Update a member

## CreateMartechList

Create a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.CreateMartechListAsync(
    security: new CreateMartechListSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    marketingList: new MarketingList() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.CreateMartechListSecurity](../../Models/Requests/CreateMartechListSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `MarketingList`                                                                                           | [MarketingList](../../Models/Components/MarketingList.md)                                                 | :heavy_minus_sign:                                                                                        | Mailing List                                                                                              |


### Response

**[CreateMartechListResponse](../../Models/Requests/CreateMartechListResponse.md)**


## CreateMartechMember

Create a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.CreateMartechMemberAsync(
    security: new CreateMartechMemberSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    marketingMember: new MarketingMember() {});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.CreateMartechMemberSecurity](../../Models/Requests/CreateMartechMemberSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `MarketingMember`                                                                                             | [MarketingMember](../../Models/Components/MarketingMember.md)                                                 | :heavy_minus_sign:                                                                                            | A member represents a person                                                                                  |


### Response

**[CreateMartechMemberResponse](../../Models/Requests/CreateMartechMemberResponse.md)**


## GetMartechList

Retrieve a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.GetMartechListAsync(
    security: new GetMartechListSecurity() {
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

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.GetMartechListSecurity](../../Models/Requests/GetMartechListSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the List                                                                                      |
| `Fields`                                                                                            | List<*string*>                                                                                      | :heavy_minus_sign:                                                                                  | Comma-delimited fields to return                                                                    |


### Response

**[GetMartechListResponse](../../Models/Requests/GetMartechListResponse.md)**


## GetMartechMember

Retrieve a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.GetMartechMemberAsync(
    security: new GetMartechMemberSecurity() {
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

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.GetMartechMemberSecurity](../../Models/Requests/GetMartechMemberSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Member                                                                                        |
| `Fields`                                                                                                | List<*string*>                                                                                          | :heavy_minus_sign:                                                                                      | Comma-delimited fields to return                                                                        |


### Response

**[GetMartechMemberResponse](../../Models/Requests/GetMartechMemberResponse.md)**


## ListMartechLists

List all lists

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListMartechListsRequest req = new ListMartechListsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Martech.ListMartechListsAsync(
    security: new ListMartechListsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListMartechListsRequest](../../Models/Requests/ListMartechListsRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListMartechListsSecurity](../../Models/Requests/ListMartechListsSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListMartechListsResponse](../../Models/Requests/ListMartechListsResponse.md)**


## ListMartechMembers

List all members

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListMartechMembersRequest req = new ListMartechMembersRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Martech.ListMartechMembersAsync(
    security: new ListMartechMembersSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [ListMartechMembersRequest](../../Models/Requests/ListMartechMembersRequest.md)                             | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.ListMartechMembersSecurity](../../Models/Requests/ListMartechMembersSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |


### Response

**[ListMartechMembersResponse](../../Models/Requests/ListMartechMembersResponse.md)**


## PatchMartechList

Update a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.PatchMartechListAsync(
    security: new PatchMartechListSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    marketingList: new MarketingList() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.PatchMartechListSecurity](../../Models/Requests/PatchMartechListSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the List                                                                                          |
| `MarketingList`                                                                                         | [MarketingList](../../Models/Components/MarketingList.md)                                               | :heavy_minus_sign:                                                                                      | Mailing List                                                                                            |


### Response

**[PatchMartechListResponse](../../Models/Requests/PatchMartechListResponse.md)**


## PatchMartechMember

Update a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.PatchMartechMemberAsync(
    security: new PatchMartechMemberSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    marketingMember: new MarketingMember() {});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.PatchMartechMemberSecurity](../../Models/Requests/PatchMartechMemberSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Member                                                                                            |
| `MarketingMember`                                                                                           | [MarketingMember](../../Models/Components/MarketingMember.md)                                               | :heavy_minus_sign:                                                                                          | A member represents a person                                                                                |


### Response

**[PatchMartechMemberResponse](../../Models/Requests/PatchMartechMemberResponse.md)**


## RemoveMartechList

Remove a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.RemoveMartechListAsync(
    security: new RemoveMartechListSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.RemoveMartechListSecurity](../../Models/Requests/RemoveMartechListSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the List                                                                                            |


### Response

**[RemoveMartechListResponse](../../Models/Requests/RemoveMartechListResponse.md)**


## RemoveMartechMember

Remove member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.RemoveMartechMemberAsync(
    security: new RemoveMartechMemberSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.RemoveMartechMemberSecurity](../../Models/Requests/RemoveMartechMemberSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Member                                                                                              |


### Response

**[RemoveMartechMemberResponse](../../Models/Requests/RemoveMartechMemberResponse.md)**


## UpdateMartechList

Update a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.UpdateMartechListAsync(
    security: new UpdateMartechListSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    marketingList: new MarketingList() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.UpdateMartechListSecurity](../../Models/Requests/UpdateMartechListSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the List                                                                                            |
| `MarketingList`                                                                                           | [MarketingList](../../Models/Components/MarketingList.md)                                                 | :heavy_minus_sign:                                                                                        | Mailing List                                                                                              |


### Response

**[UpdateMartechListResponse](../../Models/Requests/UpdateMartechListResponse.md)**


## UpdateMartechMember

Update a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Martech.UpdateMartechMemberAsync(
    security: new UpdateMartechMemberSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    marketingMember: new MarketingMember() {});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.UpdateMartechMemberSecurity](../../Models/Requests/UpdateMartechMemberSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Member                                                                                              |
| `MarketingMember`                                                                                             | [MarketingMember](../../Models/Components/MarketingMember.md)                                                 | :heavy_minus_sign:                                                                                            | A member represents a person                                                                                  |


### Response

**[UpdateMartechMemberResponse](../../Models/Requests/UpdateMartechMemberResponse.md)**

