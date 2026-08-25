# Post

## Overview

### Available Operations

* [CreateSocialPost](#createsocialpost) - Create a post
* [GetSocialPost](#getsocialpost) - Retrieve a post
* [ListSocialPosts](#listsocialposts) - List all posts
* [PatchSocialPost](#patchsocialpost) - Update a post
* [RemoveSocialPost](#removesocialpost) - Remove a post
* [UpdateSocialPost](#updatesocialpost) - Update a post

## CreateSocialPost

Create a post

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSocialPost" method="post" path="/social/{connection_id}/post" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Post.CreateSocialPostAsync(
    socialPost: new SocialPost() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SocialPost`                                                                                                                                     | [SocialPost](../../Models/Components/SocialPost.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateSocialPostQueryParamFields](../../Models/Requests/CreateSocialPostQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateSocialPostResponse](../../Models/Requests/CreateSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetSocialPost

Retrieve a post

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSocialPost" method="get" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Post.GetSocialPostAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Post                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetSocialPostQueryParamFields](../../Models/Requests/GetSocialPostQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSocialPostResponse](../../Models/Requests/GetSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListSocialPosts

List all posts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSocialPosts" method="get" path="/social/{connection_id}/post" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSocialPostsRequest req = new ListSocialPostsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Post.ListSocialPostsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListSocialPostsRequest](../../Models/Requests/ListSocialPostsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListSocialPostsResponse](../../Models/Requests/ListSocialPostsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchSocialPost

Update a post

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchSocialPost" method="patch" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchSocialPostRequest req = new PatchSocialPostRequest() {
    SocialPost = new SocialPost() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Post.PatchSocialPostAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchSocialPostRequest](../../Models/Requests/PatchSocialPostRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchSocialPostResponse](../../Models/Requests/PatchSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveSocialPost

Remove a post

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeSocialPost" method="delete" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Post.RemoveSocialPostAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Post       |

### Response

**[RemoveSocialPostResponse](../../Models/Requests/RemoveSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateSocialPost

Update a post

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSocialPost" method="put" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateSocialPostRequest req = new UpdateSocialPostRequest() {
    SocialPost = new SocialPost() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Post.UpdateSocialPostAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateSocialPostRequest](../../Models/Requests/UpdateSocialPostRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateSocialPostResponse](../../Models/Requests/UpdateSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |