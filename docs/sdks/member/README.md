# Member

## Overview

### Available Operations

* [CreateMartechMember](#createmartechmember) - Create a member
* [GetClubsMember](#getclubsmember) - Retrieve a member
* [GetMartechMember](#getmartechmember) - Retrieve a member
* [ListClubsMembers](#listclubsmembers) - List all members
* [ListMartechMembers](#listmartechmembers) - List all members
* [PatchMartechMember](#patchmartechmember) - Update a member
* [RemoveMartechMember](#removemartechmember) - Remove a member
* [UpdateMartechMember](#updatemartechmember) - Update a member

## CreateMartechMember

Create a member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMartechMember" method="post" path="/martech/{connection_id}/member" example="martech_member" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Member.CreateMartechMemberAsync(
    marketingMember: new MarketingMember() {
        Company = "Miller - Franecki",
        CreatedAt = System.DateTime.Parse("2022-04-15T15:32:38.496Z").ToUniversalTime(),
        Emails = new List<MarketingEmail>() {
            new MarketingEmail() {
                Email = "Thalia.Abernathy61@gmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Maymie59@hotmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Coty27@hotmail.com",
                Type = MarketingEmailType.Work,
            },
        },
        FirstName = "Jude",
        Id = "30acc8f9-cc8e-4ee8-876e-9f9138d03725",
        LastName = "Leffler",
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "vinco",
            "ceno",
        },
        UpdatedAt = System.DateTime.Parse("2025-06-15T22:08:00.789Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `MarketingMember`                                                                                                                                | [MarketingMember](../../Models/Components/MarketingMember.md)                                                                                    | :heavy_check_mark:                                                                                                                               | A member represents a person                                                                                                                     |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateMartechMemberQueryParamFields](../../Models/Requests/CreateMartechMemberQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateMartechMemberResponse](../../Models/Requests/CreateMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetClubsMember

Retrieve a member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClubsMember" method="get" path="/clubs/{connection_id}/member/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Member.GetClubsMemberAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Member                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetClubsMemberQueryParamFields](../../Models/Requests/GetClubsMemberQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetClubsMemberResponse](../../Models/Requests/GetClubsMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMartechMember

Retrieve a member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMartechMember" method="get" path="/martech/{connection_id}/member/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Member.GetMartechMemberAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Member                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetMartechMemberQueryParamFields](../../Models/Requests/GetMartechMemberQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetMartechMemberResponse](../../Models/Requests/GetMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListClubsMembers

List all members

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClubsMembers" method="get" path="/clubs/{connection_id}/member" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListClubsMembersRequest req = new ListClubsMembersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Member.ListClubsMembersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListClubsMembersRequest](../../Models/Requests/ListClubsMembersRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListClubsMembersResponse](../../Models/Requests/ListClubsMembersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMartechMembers

List all members

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMartechMembers" method="get" path="/martech/{connection_id}/member" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechMembersRequest req = new ListMartechMembersRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMartechMember

Update a member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchMartechMember" method="patch" path="/martech/{connection_id}/member/{id}" example="martech_member" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchMartechMemberRequest req = new PatchMartechMemberRequest() {
    MarketingMember = new MarketingMember() {
        Company = "Miller - Franecki",
        CreatedAt = System.DateTime.Parse("2022-04-15T15:32:38.496Z").ToUniversalTime(),
        Emails = new List<MarketingEmail>() {
            new MarketingEmail() {
                Email = "Thalia.Abernathy61@gmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Maymie59@hotmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Coty27@hotmail.com",
                Type = MarketingEmailType.Work,
            },
        },
        FirstName = "Jude",
        Id = "a857f1be-c4fb-4dc8-b345-62fd1c8fee81",
        LastName = "Leffler",
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "vinco",
            "ceno",
        },
        UpdatedAt = System.DateTime.Parse("2025-06-15T22:08:00.800Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Member.PatchMartechMemberAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchMartechMemberRequest](../../Models/Requests/PatchMartechMemberRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchMartechMemberResponse](../../Models/Requests/PatchMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMartechMember

Remove a member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeMartechMember" method="delete" path="/martech/{connection_id}/member/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Member.RemoveMartechMemberAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Member     |

### Response

**[RemoveMartechMemberResponse](../../Models/Requests/RemoveMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMartechMember

Update a member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMartechMember" method="put" path="/martech/{connection_id}/member/{id}" example="martech_member" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateMartechMemberRequest req = new UpdateMartechMemberRequest() {
    MarketingMember = new MarketingMember() {
        Company = "Miller - Franecki",
        CreatedAt = System.DateTime.Parse("2022-04-15T15:32:38.496Z").ToUniversalTime(),
        Emails = new List<MarketingEmail>() {
            new MarketingEmail() {
                Email = "Thalia.Abernathy61@gmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Maymie59@hotmail.com",
                Type = MarketingEmailType.Home,
            },
            new MarketingEmail() {
                Email = "Coty27@hotmail.com",
                Type = MarketingEmailType.Work,
            },
        },
        FirstName = "Jude",
        Id = "a857f1be-c4fb-4dc8-b345-62fd1c8fee81",
        LastName = "Leffler",
        Name = "Jude Leffler",
        Status = MarketingMemberStatus.Unsubscribed,
        Tags = new List<string>() {
            "vinco",
            "ceno",
        },
        UpdatedAt = System.DateTime.Parse("2025-06-15T22:08:00.800Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Member.UpdateMartechMemberAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateMartechMemberRequest](../../Models/Requests/UpdateMartechMemberRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateMartechMemberResponse](../../Models/Requests/UpdateMartechMemberResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |