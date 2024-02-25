# Member
(*Member*)

### Available Operations

* [CreateMartechMember](#createmartechmember) - Create a member
* [GetMartechMember](#getmartechmember) - Retrieve a member
* [ListMartechMembers](#listmartechmembers) - List all members
* [PatchMartechMember](#patchmartechmember) - Update a member
* [RemoveMartechMember](#removemartechmember) - Remove member
* [UpdateMartechMember](#updatemartechmember) - Update a member

## CreateMartechMember

Create a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Member.CreateMartechMemberAsync(
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


## GetMartechMember

Retrieve a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Member.GetMartechMemberAsync(
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

var res = await sdk.Member.ListMartechMembersAsync(
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


## PatchMartechMember

Update a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Member.PatchMartechMemberAsync(
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


## RemoveMartechMember

Remove member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Member.RemoveMartechMemberAsync(
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


## UpdateMartechMember

Update a member

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Member.UpdateMartechMemberAsync(
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

