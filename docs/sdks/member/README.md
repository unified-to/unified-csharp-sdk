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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Member.CreateMartechMemberAsync(ConnectionId: "string", MarketingMember: new MarketingMember() {
    Emails = new List<MarketingEmail>() {
        new MarketingEmail() {
            Email = "Eldridge.Marvin@gmail.com",
        },
    },
    ListIds = new List<string>() {
        "string",
    },
    Raw = new PropertyMarketingMemberRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `MarketingMember`                                             | [MarketingMember](../../Models/Components/MarketingMember.md) | :heavy_minus_sign:                                            | A member represents a person                                  |


### Response

**[CreateMartechMemberResponse](../../Models/Requests/CreateMartechMemberResponse.md)**


## GetMartechMember

Retrieve a member

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Member.GetMartechMemberAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Member                 |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetMartechMemberResponse](../../Models/Requests/GetMartechMemberResponse.md)**


## ListMartechMembers

List all members

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListMartechMembersRequest req = new ListMartechMembersRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Member.ListMartechMembersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListMartechMembersRequest](../../Models/Requests/ListMartechMembersRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[ListMartechMembersResponse](../../Models/Requests/ListMartechMembersResponse.md)**


## PatchMartechMember

Update a member

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Member.PatchMartechMemberAsync(ConnectionId: "string", Id: "string", MarketingMember: new MarketingMember() {
    Emails = new List<MarketingEmail>() {
        new MarketingEmail() {
            Email = "Shana_Boyle@yahoo.com",
        },
    },
    ListIds = new List<string>() {
        "string",
    },
    Raw = new PropertyMarketingMemberRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Member                                              |
| `MarketingMember`                                             | [MarketingMember](../../Models/Components/MarketingMember.md) | :heavy_minus_sign:                                            | A member represents a person                                  |


### Response

**[PatchMartechMemberResponse](../../Models/Requests/PatchMartechMemberResponse.md)**


## RemoveMartechMember

Remove member

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Member.RemoveMartechMemberAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Member     |


### Response

**[RemoveMartechMemberResponse](../../Models/Requests/RemoveMartechMemberResponse.md)**


## UpdateMartechMember

Update a member

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Member.UpdateMartechMemberAsync(ConnectionId: "string", Id: "string", MarketingMember: new MarketingMember() {
    Emails = new List<MarketingEmail>() {
        new MarketingEmail() {
            Email = "Antonette.Kerluke@hotmail.com",
        },
    },
    ListIds = new List<string>() {
        "string",
    },
    Raw = new PropertyMarketingMemberRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Member                                              |
| `MarketingMember`                                             | [MarketingMember](../../Models/Components/MarketingMember.md) | :heavy_minus_sign:                                            | A member represents a person                                  |


### Response

**[UpdateMartechMemberResponse](../../Models/Requests/UpdateMartechMemberResponse.md)**

