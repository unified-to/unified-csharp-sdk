# List
(*List*)

## Overview

### Available Operations

* [CreateMartechList](#createmartechlist) - Create a list
* [GetMartechList](#getmartechlist) - Retrieve a list
* [ListMartechLists](#listmartechlists) - List all lists
* [PatchMartechList](#patchmartechlist) - Update a list
* [RemoveMartechList](#removemartechlist) - Remove a list
* [UpdateMartechList](#updatemartechlist) - Update a list

## CreateMartechList

Create a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.CreateMartechListAsync(
    connectionId: "<id>",
    marketingList: new MarketingList() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `MarketingList`                                           | [MarketingList](../../Models/Components/MarketingList.md) | :heavy_minus_sign:                                        | Mailing List                                              |
| `Fields`                                                  | List<*string*>                                            | :heavy_minus_sign:                                        | Comma-delimited fields to return                          |

### Response

**[CreateMartechListResponse](../../Models/Requests/CreateMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetMartechList

Retrieve a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.GetMartechListAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the List                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetMartechListResponse](../../Models/Requests/GetMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListMartechLists

List all lists

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListMartechListsRequest req = new ListMartechListsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.List.ListMartechListsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListMartechListsRequest](../../Models/Requests/ListMartechListsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListMartechListsResponse](../../Models/Requests/ListMartechListsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchMartechList

Update a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.PatchMartechListAsync(
    connectionId: "<id>",
    id: "<id>",
    marketingList: new MarketingList() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `Id`                                                      | *string*                                                  | :heavy_check_mark:                                        | ID of the List                                            |
| `MarketingList`                                           | [MarketingList](../../Models/Components/MarketingList.md) | :heavy_minus_sign:                                        | Mailing List                                              |
| `Fields`                                                  | List<*string*>                                            | :heavy_minus_sign:                                        | Comma-delimited fields to return                          |

### Response

**[PatchMartechListResponse](../../Models/Requests/PatchMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveMartechList

Remove a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.RemoveMartechListAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the List       |

### Response

**[RemoveMartechListResponse](../../Models/Requests/RemoveMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateMartechList

Update a list

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.List.UpdateMartechListAsync(
    connectionId: "<id>",
    id: "<id>",
    marketingList: new MarketingList() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `Id`                                                      | *string*                                                  | :heavy_check_mark:                                        | ID of the List                                            |
| `MarketingList`                                           | [MarketingList](../../Models/Components/MarketingList.md) | :heavy_minus_sign:                                        | Mailing List                                              |
| `Fields`                                                  | List<*string*>                                            | :heavy_minus_sign:                                        | Comma-delimited fields to return                          |

### Response

**[UpdateMartechListResponse](../../Models/Requests/UpdateMartechListResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |